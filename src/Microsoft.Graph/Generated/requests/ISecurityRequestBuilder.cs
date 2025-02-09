// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ISecurityRequestBuilder.
    /// </summary>
    public partial interface ISecurityRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ISecurityRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ISecurityRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Cases.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.SecurityNamespace.ICasesRootRequestBuilder"/>.</returns>
        Microsoft.Graph.SecurityNamespace.ICasesRootRequestBuilder Cases { get; }

        /// <summary>
        /// Gets the request builder for Alerts.
        /// </summary>
        /// <returns>The <see cref="ISecurityAlertsCollectionRequestBuilder"/>.</returns>
        ISecurityAlertsCollectionRequestBuilder Alerts { get; }

        /// <summary>
        /// Gets the request builder for SecureScoreControlProfiles.
        /// </summary>
        /// <returns>The <see cref="ISecuritySecureScoreControlProfilesCollectionRequestBuilder"/>.</returns>
        ISecuritySecureScoreControlProfilesCollectionRequestBuilder SecureScoreControlProfiles { get; }

        /// <summary>
        /// Gets the request builder for SecureScores.
        /// </summary>
        /// <returns>The <see cref="ISecuritySecureScoresCollectionRequestBuilder"/>.</returns>
        ISecuritySecureScoresCollectionRequestBuilder SecureScores { get; }
    
    }
}
