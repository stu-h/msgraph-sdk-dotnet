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
    /// The interface IDeviceAppManagementRequest.
    /// </summary>
    public partial interface IDeviceAppManagementRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceAppManagement using POST.
        /// </summary>
        /// <param name="deviceAppManagementToCreate">The DeviceAppManagement to create.</param>
        /// <returns>The created DeviceAppManagement.</returns>
        System.Threading.Tasks.Task<DeviceAppManagement> CreateAsync(DeviceAppManagement deviceAppManagementToCreate);

        /// <summary>
        /// Creates the specified DeviceAppManagement using POST.
        /// </summary>
        /// <param name="deviceAppManagementToCreate">The DeviceAppManagement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceAppManagement.</returns>
        System.Threading.Tasks.Task<DeviceAppManagement> CreateAsync(DeviceAppManagement deviceAppManagementToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified DeviceAppManagement using POST and returns a <see cref="GraphResponse{DeviceAppManagement}"/> object.
        /// </summary>
        /// <param name="deviceAppManagementToCreate">The DeviceAppManagement to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceAppManagement}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAppManagement>> CreateResponseAsync(DeviceAppManagement deviceAppManagementToCreate);

        /// <summary>
        /// Creates the specified DeviceAppManagement using POST and returns a <see cref="GraphResponse{DeviceAppManagement}"/> object.
        /// </summary>
        /// <param name="deviceAppManagementToCreate">The DeviceAppManagement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceAppManagement}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAppManagement>> CreateResponseAsync(DeviceAppManagement deviceAppManagementToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceAppManagement.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceAppManagement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceAppManagement and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DeviceAppManagement and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceAppManagement.
        /// </summary>
        /// <returns>The DeviceAppManagement.</returns>
        System.Threading.Tasks.Task<DeviceAppManagement> GetAsync();

        /// <summary>
        /// Gets the specified DeviceAppManagement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceAppManagement.</returns>
        System.Threading.Tasks.Task<DeviceAppManagement> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceAppManagement using PATCH.
        /// </summary>
        /// <param name="deviceAppManagementToUpdate">The DeviceAppManagement to update.</param>
        /// <returns>The updated DeviceAppManagement.</returns>
        System.Threading.Tasks.Task<DeviceAppManagement> UpdateAsync(DeviceAppManagement deviceAppManagementToUpdate);

        /// <summary>
        /// Updates the specified DeviceAppManagement using PATCH.
        /// </summary>
        /// <param name="deviceAppManagementToUpdate">The DeviceAppManagement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceAppManagement.</returns>
        System.Threading.Tasks.Task<DeviceAppManagement> UpdateAsync(DeviceAppManagement deviceAppManagementToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceAppManagement using PATCH and returns a <see cref="GraphResponse{DeviceAppManagement}"/> object.
        /// </summary>
        /// <param name="deviceAppManagementToUpdate">The DeviceAppManagement to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceAppManagement}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAppManagement>> UpdateResponseAsync(DeviceAppManagement deviceAppManagementToUpdate);

        /// <summary>
        /// Updates the specified DeviceAppManagement using PATCH and returns a <see cref="GraphResponse{DeviceAppManagement}"/> object.
        /// </summary>
        /// <param name="deviceAppManagementToUpdate">The DeviceAppManagement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceAppManagement}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAppManagement>> UpdateResponseAsync(DeviceAppManagement deviceAppManagementToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementRequest Expand(Expression<Func<DeviceAppManagement, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAppManagementRequest Select(Expression<Func<DeviceAppManagement, object>> selectExpression);

    }
}
