using Microsoft.VisualStudio.Threading;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client
{
    public abstract class TracingClient
    {
        private CancellationTokenSource cancellationTokenSource;

        private Task runLoop;

        private AsyncManualResetEvent startEvent = new AsyncManualResetEvent(false);

        protected abstract string Url { get; }

        public async Task Start()
        {
            if (this.runLoop != null)
            {
                throw new InvalidOperationException("The client is already started.");
            }

            // This event will receive a notification if the run loop is up & running.
            this.startEvent.Reset();
            this.cancellationTokenSource = new CancellationTokenSource();

            // Start the asynchronous run loop
            this.runLoop = this.RunLoop(this.cancellationTokenSource.Token);

            // Wait for the run loop to receive at least one event; only then return.
            await this.startEvent.WaitAsync().ConfigureAwait(false);
        }

        public async Task Stop()
        {
            if (this.runLoop == null)
            {
                throw new InvalidOperationException("You must first start the client before you can stop it.");
            }

            this.cancellationTokenSource.Cancel();

            try
            {
                await this.runLoop.ConfigureAwait(false);
            }
            catch (TaskCanceledException)
            {
                // That's fine! We cancelled the task :-)
            }

            this.runLoop = null;
        }

        protected abstract void HandleEvent(string data);

        private async Task RunLoop(CancellationToken cancellationToken)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(this.Url, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    using (var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    using (var responseReader = new StreamReader(stream))
                    {
                        while (!cancellationToken.IsCancellationRequested)
                        {
                            var data = await responseReader.ReadLineAsync();
                            this.HandleEvent(data);
                            this.startEvent.Set();
                        }
                    }
                }
            }
        }
    }
}
