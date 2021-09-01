// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ContentTypeColumnPositionsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class ContentTypeColumnPositionsCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IContentTypeColumnPositionsCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ContentTypeColumnPositionsCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ContentTypeColumnPositionsCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IContentTypeColumnPositionsCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IContentTypeColumnPositionsCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new ContentTypeColumnPositionsCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IColumnDefinitionWithReferenceRequestBuilder"/> for the specified ContentTypeColumnDefinition.
        /// </summary>
        /// <param name="id">The ID for the ContentTypeColumnDefinition.</param>
        /// <returns>The <see cref="IColumnDefinitionWithReferenceRequestBuilder"/>.</returns>
        public IColumnDefinitionWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new ColumnDefinitionWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IContentTypeColumnPositionsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IContentTypeColumnPositionsCollectionReferencesRequestBuilder"/>.</returns>
        public IContentTypeColumnPositionsCollectionReferencesRequestBuilder References
        {
            get
            {
                return new ContentTypeColumnPositionsCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
