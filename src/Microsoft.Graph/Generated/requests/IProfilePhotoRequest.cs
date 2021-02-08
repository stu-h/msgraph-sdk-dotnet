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
    /// The interface IProfilePhotoRequest.
    /// </summary>
    public partial interface IProfilePhotoRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ProfilePhoto using POST.
        /// </summary>
        /// <param name="profilePhotoToCreate">The ProfilePhoto to create.</param>
        /// <returns>The created ProfilePhoto.</returns>
        System.Threading.Tasks.Task<ProfilePhoto> CreateAsync(ProfilePhoto profilePhotoToCreate);

        /// <summary>
        /// Creates the specified ProfilePhoto using POST.
        /// </summary>
        /// <param name="profilePhotoToCreate">The ProfilePhoto to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ProfilePhoto.</returns>
        System.Threading.Tasks.Task<ProfilePhoto> CreateAsync(ProfilePhoto profilePhotoToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified ProfilePhoto using POST and returns a <see cref="GraphResponse{ProfilePhoto}"/> object.
        /// </summary>
        /// <param name="profilePhotoToCreate">The ProfilePhoto to create.</param>
        /// <returns>The <see cref="GraphResponse{ProfilePhoto}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ProfilePhoto>> CreateResponseAsync(ProfilePhoto profilePhotoToCreate);

        /// <summary>
        /// Creates the specified ProfilePhoto using POST and returns a <see cref="GraphResponse{ProfilePhoto}"/> object.
        /// </summary>
        /// <param name="profilePhotoToCreate">The ProfilePhoto to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ProfilePhoto}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ProfilePhoto>> CreateResponseAsync(ProfilePhoto profilePhotoToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ProfilePhoto.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ProfilePhoto.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ProfilePhoto and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified ProfilePhoto and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ProfilePhoto.
        /// </summary>
        /// <returns>The ProfilePhoto.</returns>
        System.Threading.Tasks.Task<ProfilePhoto> GetAsync();

        /// <summary>
        /// Gets the specified ProfilePhoto.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ProfilePhoto.</returns>
        System.Threading.Tasks.Task<ProfilePhoto> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ProfilePhoto using PATCH.
        /// </summary>
        /// <param name="profilePhotoToUpdate">The ProfilePhoto to update.</param>
        /// <returns>The updated ProfilePhoto.</returns>
        System.Threading.Tasks.Task<ProfilePhoto> UpdateAsync(ProfilePhoto profilePhotoToUpdate);

        /// <summary>
        /// Updates the specified ProfilePhoto using PATCH.
        /// </summary>
        /// <param name="profilePhotoToUpdate">The ProfilePhoto to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ProfilePhoto.</returns>
        System.Threading.Tasks.Task<ProfilePhoto> UpdateAsync(ProfilePhoto profilePhotoToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ProfilePhoto using PATCH and returns a <see cref="GraphResponse{ProfilePhoto}"/> object.
        /// </summary>
        /// <param name="profilePhotoToUpdate">The ProfilePhoto to update.</param>
        /// <returns>The <see cref="GraphResponse{ProfilePhoto}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ProfilePhoto>> UpdateResponseAsync(ProfilePhoto profilePhotoToUpdate);

        /// <summary>
        /// Updates the specified ProfilePhoto using PATCH and returns a <see cref="GraphResponse{ProfilePhoto}"/> object.
        /// </summary>
        /// <param name="profilePhotoToUpdate">The ProfilePhoto to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ProfilePhoto}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ProfilePhoto>> UpdateResponseAsync(ProfilePhoto profilePhotoToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IProfilePhotoRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IProfilePhotoRequest Expand(Expression<Func<ProfilePhoto, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IProfilePhotoRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IProfilePhotoRequest Select(Expression<Func<ProfilePhoto, object>> selectExpression);

    }
}
