// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IListContentTypesCollectionRequestBuilder.
    /// </summary>
    public partial interface IListContentTypesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IListContentTypesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IListContentTypesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IContentTypeRequestBuilder"/> for the specified ContentType.
        /// </summary>
        /// <param name="id">The ID for the ContentType.</param>
        /// <returns>The <see cref="IContentTypeRequestBuilder"/>.</returns>
        IContentTypeRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for ContentTypeAddCopy.
        /// </summary>
        /// <returns>The <see cref="IContentTypeAddCopyRequestBuilder"/>.</returns>
        IContentTypeAddCopyRequestBuilder AddCopy(
            string contentType);
    }
}
