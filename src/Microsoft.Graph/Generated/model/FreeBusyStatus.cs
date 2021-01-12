// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum FreeBusyStatus.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum FreeBusyStatus
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = -1,
	
        /// <summary>
        /// Free
        /// </summary>
        Free = 0,
	
        /// <summary>
        /// Tentative
        /// </summary>
        Tentative = 1,
	
        /// <summary>
        /// Busy
        /// </summary>
        Busy = 2,
	
        /// <summary>
        /// Oof
        /// </summary>
        Oof = 3,
	
        /// <summary>
        /// Working Elsewhere
        /// </summary>
        WorkingElsewhere = 4,
	
    }
}
