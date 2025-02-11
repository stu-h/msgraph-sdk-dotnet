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
    /// The type ContentTypeRequestBuilder.
    /// </summary>
    public partial class ContentTypeRequestBuilder : EntityRequestBuilder, IContentTypeRequestBuilder
    {

        /// <summary>
        /// Constructs a new ContentTypeRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ContentTypeRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IContentTypeRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IContentTypeRequest Request(IEnumerable<Option> options)
        {
            return new ContentTypeRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Base.
        /// </summary>
        /// <returns>The <see cref="IContentTypeWithReferenceRequestBuilder"/>.</returns>
        public IContentTypeWithReferenceRequestBuilder Base
        {
            get
            {
                return new ContentTypeWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("base"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for BaseTypes.
        /// </summary>
        /// <returns>The <see cref="IContentTypeBaseTypesCollectionWithReferencesRequestBuilder"/>.</returns>
        public IContentTypeBaseTypesCollectionWithReferencesRequestBuilder BaseTypes
        {
            get
            {
                return new ContentTypeBaseTypesCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("baseTypes"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ColumnLinks.
        /// </summary>
        /// <returns>The <see cref="IContentTypeColumnLinksCollectionRequestBuilder"/>.</returns>
        public IContentTypeColumnLinksCollectionRequestBuilder ColumnLinks
        {
            get
            {
                return new ContentTypeColumnLinksCollectionRequestBuilder(this.AppendSegmentToRequestUrl("columnLinks"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ColumnPositions.
        /// </summary>
        /// <returns>The <see cref="IContentTypeColumnPositionsCollectionWithReferencesRequestBuilder"/>.</returns>
        public IContentTypeColumnPositionsCollectionWithReferencesRequestBuilder ColumnPositions
        {
            get
            {
                return new ContentTypeColumnPositionsCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("columnPositions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Columns.
        /// </summary>
        /// <returns>The <see cref="IContentTypeColumnsCollectionRequestBuilder"/>.</returns>
        public IContentTypeColumnsCollectionRequestBuilder Columns
        {
            get
            {
                return new ContentTypeColumnsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("columns"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for ContentTypePublish.
        /// </summary>
        /// <returns>The <see cref="IContentTypePublishRequestBuilder"/>.</returns>
        public IContentTypePublishRequestBuilder Publish()
        {
            return new ContentTypePublishRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.publish"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ContentTypeUnpublish.
        /// </summary>
        /// <returns>The <see cref="IContentTypeUnpublishRequestBuilder"/>.</returns>
        public IContentTypeUnpublishRequestBuilder Unpublish()
        {
            return new ContentTypeUnpublishRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.unpublish"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ContentTypeAssociateWithHubSites.
        /// </summary>
        /// <returns>The <see cref="IContentTypeAssociateWithHubSitesRequestBuilder"/>.</returns>
        public IContentTypeAssociateWithHubSitesRequestBuilder AssociateWithHubSites(
            IEnumerable<string> hubSiteUrls,
            bool? propagateToExistingLists = null)
        {
            return new ContentTypeAssociateWithHubSitesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.associateWithHubSites"),
                this.Client,
                hubSiteUrls,
                propagateToExistingLists);
        }

        /// <summary>
        /// Gets the request builder for ContentTypeCopyToDefaultContentLocation.
        /// </summary>
        /// <returns>The <see cref="IContentTypeCopyToDefaultContentLocationRequestBuilder"/>.</returns>
        public IContentTypeCopyToDefaultContentLocationRequestBuilder CopyToDefaultContentLocation(
            ItemReference sourceFile,
            string destinationFileName = null)
        {
            return new ContentTypeCopyToDefaultContentLocationRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.copyToDefaultContentLocation"),
                this.Client,
                sourceFile,
                destinationFileName);
        }

        /// <summary>
        /// Gets the request builder for ContentTypeIsPublished.
        /// </summary>
        /// <returns>The <see cref="IContentTypeIsPublishedRequestBuilder"/>.</returns>
        public IContentTypeIsPublishedRequestBuilder IsPublished()
        {
            return new ContentTypeIsPublishedRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.isPublished"),
                this.Client);
        }
    
    }
}
