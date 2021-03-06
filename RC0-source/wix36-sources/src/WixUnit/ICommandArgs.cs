//-------------------------------------------------------------------------------------------------
// <copyright file="ICommandArgs.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
//    
//    The use and distribution terms for this software are covered by the
//    Common Public License 1.0 (http://opensource.org/licenses/cpl1.0.php)
//    which can be found in the file CPL.TXT at the root of this distribution.
//    By using this software in any fashion, you are agreeing to be bound by
//    the terms of this license.
//    
//    You must not remove this notice, or any other, from this software.
// </copyright>
// 
// <summary>
// Interface for passing command line arguments to tool classes.
// </summary>
//-------------------------------------------------------------------------------------------------

namespace Microsoft.Tools.WindowsInstallerXml.Unit
{
    using System;

    /// <summary>
    /// Interface for passing command line arguments to tool classes.
    /// </summary>
    public interface ICommandArgs
    {
        /// <summary>
        /// Whether to remove intermediate build files.
        /// </summary>
        bool NoTidy { get; }
    }
}
