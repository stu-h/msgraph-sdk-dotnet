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
    /// The enum RatingNewZealandMoviesType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RatingNewZealandMoviesType
    {
    
        /// <summary>
        /// All Allowed
        /// </summary>
        AllAllowed = 0,
	
        /// <summary>
        /// All Blocked
        /// </summary>
        AllBlocked = 1,
	
        /// <summary>
        /// General
        /// </summary>
        General = 2,
	
        /// <summary>
        /// Parental Guidance
        /// </summary>
        ParentalGuidance = 3,
	
        /// <summary>
        /// Mature
        /// </summary>
        Mature = 4,
	
        /// <summary>
        /// Ages Above13
        /// </summary>
        AgesAbove13 = 5,
	
        /// <summary>
        /// Ages Above15
        /// </summary>
        AgesAbove15 = 6,
	
        /// <summary>
        /// Ages Above16
        /// </summary>
        AgesAbove16 = 7,
	
        /// <summary>
        /// Ages Above18
        /// </summary>
        AgesAbove18 = 8,
	
        /// <summary>
        /// Restricted
        /// </summary>
        Restricted = 9,
	
        /// <summary>
        /// Ages Above16Restricted
        /// </summary>
        AgesAbove16Restricted = 10,
	
    }
}
