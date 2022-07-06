// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EdiscoveryReviewSetWithReferenceRequestBuilder.
    /// </summary>
    public partial class EdiscoveryReviewSetWithReferenceRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IEdiscoveryReviewSetWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new EdiscoveryReviewSetWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public EdiscoveryReviewSetWithReferenceRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEdiscoveryReviewSetWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEdiscoveryReviewSetWithReferenceRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new EdiscoveryReviewSetWithReferenceRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets the request builder for the reference of the ediscoveryReviewSet.
        /// </summary>
        /// <returns>The <see cref="IEdiscoveryReviewSetReferenceRequestBuilder"/>.</returns>
        public IEdiscoveryReviewSetReferenceRequestBuilder Reference
        {
            get
            {
                return new EdiscoveryReviewSetReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
