// <copyright file="AppCommandInfoRepositoryExtensions.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client
{
    /// <summary>
    /// Provides extension methods to add commands related to application and mobile devices.
    /// </summary>
    public static class AppCommandInfoRepositoryExtensions
    {
        public static void AddAppCommands(this CommandInfoRepository commandInfoRepository)
        {
            commandInfoRepository.TryAddCommand(AppDriverCommand.TakeScreenshot, new CommandInfo(CommandInfo.GetCommand, $"quamotion/device/{{{AppDriverCommand.DeviceId}}}/screenshot"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.GetSessions, new CommandInfo(CommandInfo.GetCommand, "sessions"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.RemoveSession, new CommandInfo(CommandInfo.DeleteCommand, $"session/{{{AppDriverCommand.SessionId}}}"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.GetApplications, new CommandInfo(CommandInfo.GetCommand, "quamotion/app"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.GetDevices, new CommandInfo(CommandInfo.GetCommand, "quamotion/device"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.GetDeviceInformation, new CommandInfo(CommandInfo.GetCommand, $"quamotion/device/{{{AppDriverCommand.DeviceId}}}"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.GetInstalledApplications, new CommandInfo(CommandInfo.GetCommand, $"quamotion/device/{{{AppDriverCommand.DeviceId}}}/app"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.DeleteApplication, new CommandInfo(CommandInfo.DeleteCommand, $"quamotion/device/{{{AppDriverCommand.DeviceId}}}/app/{{{AppDriverCommand.AppId}}}"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.DeleteSettings, new CommandInfo(CommandInfo.DeleteCommand, $"quamotion/device/{{{AppDriverCommand.DeviceId}}}/app/{{{AppDriverCommand.AppId}}}/settings"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.InstallApplication2, new CommandInfo(CommandInfo.PostCommand, $"quamotion/device/{{{AppDriverCommand.DeviceId}}}/app/{{{AppDriverCommand.AppId}}}/{{{AppDriverCommand.AppVersion}}}"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.InstallApplication, new CommandInfo(CommandInfo.PostCommand, $"quamotion/device/{{{AppDriverCommand.DeviceId}}}/app/{{{AppDriverCommand.AppId}}}"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.RebootDevice, new CommandInfo(CommandInfo.PostCommand, $"quamotion/device/{{{AppDriverCommand.DeviceId}}}/reboot"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.StartApplication, new CommandInfo(CommandInfo.PostCommand, $"quamotion/device/{{{AppDriverCommand.DeviceId}}}/app/{{{AppDriverCommand.AppId}}}/launch?strict"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.IsReady, new CommandInfo(CommandInfo.GetCommand, $"session/{{{AppDriverCommand.SessionId}}}/quamotion/isReady"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.GetProperty, new CommandInfo(CommandInfo.GetCommand, $"session/{{{AppDriverCommand.SessionId}}}/element/{{{AppDriverCommand.ElementId}}}/property/{{{AppDriverCommand.PropertyName}}}"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.SetProperty, new CommandInfo(CommandInfo.PostCommand, $"session/{{{AppDriverCommand.SessionId}}}/element/{{{AppDriverCommand.ElementId}}}/property"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.PerformOperation, new CommandInfo(CommandInfo.PostCommand, $"session/{{{AppDriverCommand.SessionId}}}/element/{{{AppDriverCommand.ElementId}}}/perform"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.ElementByCoordinates, new CommandInfo(CommandInfo.GetCommand, $"session/{{{AppDriverCommand.SessionId}}}/quamotion/elementByCoordinates"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.ClickByCoordinate, new CommandInfo(CommandInfo.PostCommand, $"session/{{{AppDriverCommand.SessionId}}}/touch/clickByCoordinate"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.ScrollToVisible, new CommandInfo(CommandInfo.PostCommand, $"session/{{{AppDriverCommand.SessionId}}}/element/{{{AppDriverCommand.ElementId}}}/quamotion/scrollToVisible"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.GetStatus, new CommandInfo(CommandInfo.GetCommand, $"status"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.DismissKeyboard, new CommandInfo(CommandInfo.PostCommand, $"session/{{{AppDriverCommand.SessionId}}}/quamotion/dismissKeyboard"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.ClearText, new CommandInfo(CommandInfo.PostCommand, $"session/{{{AppDriverCommand.SessionId}}}/quamotion/clear"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.ScrollTo, new CommandInfo(CommandInfo.PostCommand, $"session/{{{AppDriverCommand.SessionId}}}/element/{{{AppDriverCommand.ElementId}}}/quamotion/scrollTo"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.GetTimeouts, new CommandInfo(CommandInfo.GetCommand, $"session/{{{AppDriverCommand.SessionId}}}/timeouts"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.FlickCoordinate, new CommandInfo(CommandInfo.PostCommand, $"session/{{{AppDriverCommand.SessionId}}}/touch/flick"));
            commandInfoRepository.TryAddCommand(AppDriverCommand.KillApplication, new CommandInfo(CommandInfo.PostCommand, $"quamotion/device/{{{AppDriverCommand.DeviceId}}}/app/{{{AppDriverCommand.AppId}}}/kill?strict"));
        }
    }
}
