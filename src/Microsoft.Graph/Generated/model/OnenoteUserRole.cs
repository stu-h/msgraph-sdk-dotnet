// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum OnenoteUserRole.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OnenoteUserRole
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = -1,
	
        /// <summary>
        /// Owner
        /// </summary>
        Owner = 0,
	
        /// <summary>
        /// Contributor
        /// </summary>
        Contributor = 1,
	
        /// <summary>
        /// Reader
        /// </summary>
        Reader = 2,
	
    }
}
