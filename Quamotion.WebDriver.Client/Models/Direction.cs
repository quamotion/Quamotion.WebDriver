using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Enumation representing the different directions: up, down, left, right
    /// </summary>
    public enum Direction
    {
        /// <summary>
        /// Represents an unkown direction.
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Represents the up direction.
        /// </summary>
        [EnumMember(Value = "up")]
        Up,

        /// <summary>
        /// Represents the down direction.
        /// </summary>
        [EnumMember(Value = "down")]
        Down,

        /// <summary>
        /// Represents the left direction.
        /// </summary>
        [EnumMember(Value = "left")]
        Left,

        /// <summary>
        /// Represents the right direction.
        /// </summary>
        [EnumMember(Value = "right")]
        Right
    }
}
