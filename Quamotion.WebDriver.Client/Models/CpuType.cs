//-----------------------------------------------------------------------
// <copyright file="CpuType.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Diagnostics.CodeAnalysis;

namespace Quamotion.WebDriver.Client.Models
{
    /// <summary>
    /// Defines well known processor types.
    /// </summary>
    [Flags]
    [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1303:Const field names must begin with upper-case letter", Justification = "Standard x86 naming")]
    public enum CpuType
    {
        /// <summary>
        /// The CPU type is unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// ARMV5TE and later.
        /// </summary>
        ARMv5 = 1,

        /// <summary>
        /// ARMv5 and later instruction sets.
        /// </summary>
        ARMv5AndAbove = ARMv5 | ARMv6AndAbove,

        /// <summary>
        /// ARMv5 and earlier instruction sets.
        /// </summary>
        ARMv5AndBelow = ARMv5,

        /// <summary>
        /// The ARMv6 instruction set.
        /// </summary>
        ARMv6 = 2,

        /// <summary>
        /// ARMv5 and later instruction sets.
        /// </summary>
        ARMv6AndAbove = ARMv6 | ARMv7AndAbove,

        /// <summary>
        /// ARMv5 and earlier instruction sets.
        /// </summary>
        ARMv6AndBelow = ARMv6 | ARMv5AndBelow,

        /// <summary>
        /// ARM v7 and later.
        /// </summary>
        ARMv7 = 4,

        /// <summary>
        /// ARMv7 and later instruction sets.
        /// </summary>
        ARMv7AndAbove = ARMv7 | ARM64v8AndAbove,

        /// <summary>
        /// ARMv5 and earlier instruction sets.
        /// </summary>
        ARMv7AndBelow = ARMv7 | ARMv6AndBelow,

        /// <summary>
        /// ARM 64 v8 and later.
        /// </summary>
        ARM64v8 = 8,

        /// <summary>
        /// ARM64v8 and later instruction sets.
        /// </summary>
        ARM64v8AndAbove = ARM64v8,

        /// <summary>
        /// ARM64v8 and earlier instruction sets.
        /// </summary>
        ARM64v8AndBelow = ARMv7AndBelow | ARM64v8,

        /// <summary>
        /// A x86 processor
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:Element must begin with upper-case letter", Justification = "Standard naming convention.")]
        x86 = 16,

        /// <summary>
        /// x86 and later instruction sets.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:Element must begin with upper-case letter", Justification = "Standard naming convention.")]
        x86AndAbove = x86 | x86_64AndAbove,

        /// <summary>
        /// x86 and earlier instruction sets.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:Element must begin with upper-case letter", Justification = "Standard naming convention.")]
        x86AndBelow = x86,

        /// <summary>
        /// A 64-bit x86 processor
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:Element must begin with upper-case letter", Justification = "Standard naming convention.")]
        x86_64 = 32,

        /// <summary>
        /// x86_64 and later instruction sets.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:Element must begin with upper-case letter", Justification = "Standard naming convention.")]
        x86_64AndAbove = x86_64,

        /// <summary>
        /// x86_64 and earlier instruction sets.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:Element must begin with upper-case letter", Justification = "Standard naming convention.")]
        x86_64AndBelow = x86_64 | x86,

        /// <summary>
        /// A 32-bit MIPS processor: MIPS32r1 and later.
        /// </summary>
        Mips = 64,

        /// <summary>
        /// MIPS and later instruction sets.
        /// </summary>
        MipsAndAbove = Mips | Mips64AndAbove,

        /// <summary>
        /// MIPS and earlier instruction sets.
        /// </summary>
        MipsAndBelow = Mips,

        /// <summary>
        /// A 64-bit MIPS processor: MIPS64r6 and later.
        /// </summary>
        Mips64 = 128,

        /// <summary>
        /// MIPS64 and later instruction sets.
        /// </summary>
        Mips64AndAbove = Mips64,

        /// <summary>
        /// MIPS64 and earlier instruction sets.
        /// </summary>
        Mips64AndBelow = Mips64 | Mips,

        /// <summary>
        /// All CPU types.
        /// </summary>
        All = ARMv5 | ARMv6 | ARMv7 | ARM64v8
            | x86 | x86_64
            | Mips | Mips64
    }
}
