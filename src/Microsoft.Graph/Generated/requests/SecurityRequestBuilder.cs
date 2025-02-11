// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type SecurityRequestBuilder.
    /// </summary>
    public partial class SecurityRequestBuilder : EntityRequestBuilder, ISecurityRequestBuilder
    {

        /// <summary>
        /// Constructs a new SecurityRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SecurityRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ISecurityRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ISecurityRequest Request(IEnumerable<Option> options)
        {
            return new SecurityRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Cases.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.SecurityNamespace.ICasesRootRequestBuilder"/>.</returns>
        public Microsoft.Graph.SecurityNamespace.ICasesRootRequestBuilder Cases
        {
            get
            {
                return new Microsoft.Graph.SecurityNamespace.CasesRootRequestBuilder(this.AppendSegmentToRequestUrl("cases"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Alerts.
        /// </summary>
        /// <returns>The <see cref="ISecurityAlertsCollectionRequestBuilder"/>.</returns>
        public ISecurityAlertsCollectionRequestBuilder Alerts
        {
            get
            {
                return new SecurityAlertsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("alerts"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SecureScoreControlProfiles.
        /// </summary>
        /// <returns>The <see cref="ISecuritySecureScoreControlProfilesCollectionRequestBuilder"/>.</returns>
        public ISecuritySecureScoreControlProfilesCollectionRequestBuilder SecureScoreControlProfiles
        {
            get
            {
                return new SecuritySecureScoreControlProfilesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("secureScoreControlProfiles"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SecureScores.
        /// </summary>
        /// <returns>The <see cref="ISecuritySecureScoresCollectionRequestBuilder"/>.</returns>
        public ISecuritySecureScoresCollectionRequestBuilder SecureScores
        {
            get
            {
                return new SecuritySecureScoresCollectionRequestBuilder(this.AppendSegmentToRequestUrl("secureScores"), this.Client);
            }
        }
    
    }
}
