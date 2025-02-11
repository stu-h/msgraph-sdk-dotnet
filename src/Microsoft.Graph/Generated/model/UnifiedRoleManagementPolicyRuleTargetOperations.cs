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
    /// The enum UnifiedRoleManagementPolicyRuleTargetOperations.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UnifiedRoleManagementPolicyRuleTargetOperations
    {
    
        /// <summary>
        /// All
        /// </summary>
        All = 0,
	
        /// <summary>
        /// Activate
        /// </summary>
        Activate = 1,
	
        /// <summary>
        /// Deactivate
        /// </summary>
        Deactivate = 2,
	
        /// <summary>
        /// Assign
        /// </summary>
        Assign = 3,
	
        /// <summary>
        /// Update
        /// </summary>
        Update = 4,
	
        /// <summary>
        /// Remove
        /// </summary>
        Remove = 5,
	
        /// <summary>
        /// Extend
        /// </summary>
        Extend = 6,
	
        /// <summary>
        /// Renew
        /// </summary>
        Renew = 7,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 8,
	
    }
}
