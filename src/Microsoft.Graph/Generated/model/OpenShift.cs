// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Open Shift.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OpenShift : ChangeTrackedEntity
    {
    
		///<summary>
		/// The OpenShift constructor
		///</summary>
        public OpenShift()
        {
            this.ODataType = "microsoft.graph.openShift";
        }
	
        /// <summary>
        /// Gets or sets draft open shift.
        /// An unpublished open shift.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "draftOpenShift", Required = Newtonsoft.Json.Required.Default)]
        public OpenShiftItem DraftOpenShift { get; set; }
    
        /// <summary>
        /// Gets or sets scheduling group id.
        /// ID for the scheduling group that the open shift belongs to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schedulingGroupId", Required = Newtonsoft.Json.Required.Default)]
        public string SchedulingGroupId { get; set; }
    
        /// <summary>
        /// Gets or sets shared open shift.
        /// A published open shift.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharedOpenShift", Required = Newtonsoft.Json.Required.Default)]
        public OpenShiftItem SharedOpenShift { get; set; }
    
    }
}

