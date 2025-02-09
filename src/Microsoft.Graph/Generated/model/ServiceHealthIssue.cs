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
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Service Health Issue.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ServiceHealthIssue>))]
    public partial class ServiceHealthIssue : ServiceAnnouncementBase
    {
    
        ///<summary>
        /// The ServiceHealthIssue constructor
        ///</summary>
        public ServiceHealthIssue()
        {
            this.ODataType = "microsoft.graph.serviceHealthIssue";
        }

        /// <summary>
        /// Gets or sets classification.
        /// The type of service health issue. Possible values are: advisory, incident, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("classification")]
        public ServiceHealthClassificationType? Classification { get; set; }
    
        /// <summary>
        /// Gets or sets feature.
        /// The feature name of the service issue.
        /// </summary>
        [JsonPropertyName("feature")]
        public string Feature { get; set; }
    
        /// <summary>
        /// Gets or sets feature group.
        /// The feature group name of the service issue.
        /// </summary>
        [JsonPropertyName("featureGroup")]
        public string FeatureGroup { get; set; }
    
        /// <summary>
        /// Gets or sets impact description.
        /// The description of the service issue impact.
        /// </summary>
        [JsonPropertyName("impactDescription")]
        public string ImpactDescription { get; set; }
    
        /// <summary>
        /// Gets or sets is resolved.
        /// Indicates whether the issue is resolved.
        /// </summary>
        [JsonPropertyName("isResolved")]
        public bool? IsResolved { get; set; }
    
        /// <summary>
        /// Gets or sets origin.
        /// Indicates the origin of the service issue. Possible values are: microsoft, thirdParty, customer, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("origin")]
        public ServiceHealthOrigin? Origin { get; set; }
    
        /// <summary>
        /// Gets or sets posts.
        /// Collection of historical posts for the service issue.
        /// </summary>
        [JsonPropertyName("posts")]
        public IEnumerable<ServiceHealthIssuePost> Posts { get; set; }
    
        /// <summary>
        /// Gets or sets service.
        /// Indicates the service affected by the issue.
        /// </summary>
        [JsonPropertyName("service")]
        public string Service { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The status of the service issue. Possible values are: serviceOperational, investigating, restoringService, verifyingService, serviceRestored, postIncidentReviewPublished, serviceDegradation, serviceInterruption, extendedRecovery, falsePositive, investigationSuspended, resolved, mitigatedExternal, mitigated, resolvedExternal, confirmed, reported, unknownFutureValue. For more details, see serviceHealthStatus values.
        /// </summary>
        [JsonPropertyName("status")]
        public ServiceHealthStatus? Status { get; set; }
    
    }
}

