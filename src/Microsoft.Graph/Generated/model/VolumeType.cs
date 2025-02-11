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
    /// The enum VolumeType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum VolumeType
    {
    
        /// <summary>
        /// Operating System Volume
        /// </summary>
        OperatingSystemVolume = 1,
	
        /// <summary>
        /// Fixed Data Volume
        /// </summary>
        FixedDataVolume = 2,
	
        /// <summary>
        /// Removable Data Volume
        /// </summary>
        RemovableDataVolume = 3,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
    }
}
