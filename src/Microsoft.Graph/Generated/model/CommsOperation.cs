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
    /// The type Comms Operation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class CommsOperation : Entity
    {
    
		///<summary>
		/// The CommsOperation constructor
		///</summary>
        public CommsOperation()
        {
            this.ODataType = "microsoft.graph.commsOperation";
        }
	
        /// <summary>
        /// Gets or sets client context.
        /// Unique Client Context string. Max limit is 256 chars.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientContext", Required = Newtonsoft.Json.Required.Default)]
        public string ClientContext { get; set; }
    
        /// <summary>
        /// Gets or sets result info.
        /// The result information. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resultInfo", Required = Newtonsoft.Json.Required.Default)]
        public ResultInfo ResultInfo { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Possible values are: notStarted, running, completed, failed. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public OperationStatus? Status { get; set; }
    
    }
}

