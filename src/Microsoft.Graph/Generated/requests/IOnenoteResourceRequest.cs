// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IOnenoteResourceRequest.
    /// </summary>
    public partial interface IOnenoteResourceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OnenoteResource using POST.
        /// </summary>
        /// <param name="onenoteResourceToCreate">The OnenoteResource to create.</param>
        /// <returns>The created OnenoteResource.</returns>
        System.Threading.Tasks.Task<OnenoteResource> CreateAsync(OnenoteResource onenoteResourceToCreate);

        /// <summary>
        /// Creates the specified OnenoteResource using POST.
        /// </summary>
        /// <param name="onenoteResourceToCreate">The OnenoteResource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnenoteResource.</returns>
        System.Threading.Tasks.Task<OnenoteResource> CreateAsync(OnenoteResource onenoteResourceToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified OnenoteResource using POST and returns a <see cref="GraphResponse{OnenoteResource}"/> object.
        /// </summary>
        /// <param name="onenoteResourceToCreate">The OnenoteResource to create.</param>
        /// <returns>The <see cref="GraphResponse{OnenoteResource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnenoteResource>> CreateResponseAsync(OnenoteResource onenoteResourceToCreate);

        /// <summary>
        /// Creates the specified OnenoteResource using POST and returns a <see cref="GraphResponse{OnenoteResource}"/> object.
        /// </summary>
        /// <param name="onenoteResourceToCreate">The OnenoteResource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnenoteResource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnenoteResource>> CreateResponseAsync(OnenoteResource onenoteResourceToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OnenoteResource.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OnenoteResource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OnenoteResource and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified OnenoteResource and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OnenoteResource.
        /// </summary>
        /// <returns>The OnenoteResource.</returns>
        System.Threading.Tasks.Task<OnenoteResource> GetAsync();

        /// <summary>
        /// Gets the specified OnenoteResource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnenoteResource.</returns>
        System.Threading.Tasks.Task<OnenoteResource> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OnenoteResource using PATCH.
        /// </summary>
        /// <param name="onenoteResourceToUpdate">The OnenoteResource to update.</param>
        /// <returns>The updated OnenoteResource.</returns>
        System.Threading.Tasks.Task<OnenoteResource> UpdateAsync(OnenoteResource onenoteResourceToUpdate);

        /// <summary>
        /// Updates the specified OnenoteResource using PATCH.
        /// </summary>
        /// <param name="onenoteResourceToUpdate">The OnenoteResource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OnenoteResource.</returns>
        System.Threading.Tasks.Task<OnenoteResource> UpdateAsync(OnenoteResource onenoteResourceToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OnenoteResource using PATCH and returns a <see cref="GraphResponse{OnenoteResource}"/> object.
        /// </summary>
        /// <param name="onenoteResourceToUpdate">The OnenoteResource to update.</param>
        /// <returns>The <see cref="GraphResponse{OnenoteResource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnenoteResource>> UpdateResponseAsync(OnenoteResource onenoteResourceToUpdate);

        /// <summary>
        /// Updates the specified OnenoteResource using PATCH and returns a <see cref="GraphResponse{OnenoteResource}"/> object.
        /// </summary>
        /// <param name="onenoteResourceToUpdate">The OnenoteResource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OnenoteResource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnenoteResource>> UpdateResponseAsync(OnenoteResource onenoteResourceToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteResourceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteResourceRequest Expand(Expression<Func<OnenoteResource, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteResourceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteResourceRequest Select(Expression<Func<OnenoteResource, object>> selectExpression);

    }
}
