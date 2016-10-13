// <copyright file="FileStatus.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Represents the deployment status of a file.
    /// </summary>
    public class FileStatus
    {
        /// <summary>
        /// Gets or sets the path to the file.
        /// </summary>
        public string Path
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the file has been found.
        /// </summary>
        public bool Found
        {
            get;
            set;
        }
    }
}