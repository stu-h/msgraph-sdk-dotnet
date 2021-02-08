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
    /// The interface IIosCustomConfigurationRequest.
    /// </summary>
    public partial interface IIosCustomConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosCustomConfiguration using POST.
        /// </summary>
        /// <param name="iosCustomConfigurationToCreate">The IosCustomConfiguration to create.</param>
        /// <returns>The created IosCustomConfiguration.</returns>
        System.Threading.Tasks.Task<IosCustomConfiguration> CreateAsync(IosCustomConfiguration iosCustomConfigurationToCreate);

        /// <summary>
        /// Creates the specified IosCustomConfiguration using POST.
        /// </summary>
        /// <param name="iosCustomConfigurationToCreate">The IosCustomConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosCustomConfiguration.</returns>
        System.Threading.Tasks.Task<IosCustomConfiguration> CreateAsync(IosCustomConfiguration iosCustomConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified IosCustomConfiguration using POST and returns a <see cref="GraphResponse{IosCustomConfiguration}"/> object.
        /// </summary>
        /// <param name="iosCustomConfigurationToCreate">The IosCustomConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{IosCustomConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosCustomConfiguration>> CreateResponseAsync(IosCustomConfiguration iosCustomConfigurationToCreate);

        /// <summary>
        /// Creates the specified IosCustomConfiguration using POST and returns a <see cref="GraphResponse{IosCustomConfiguration}"/> object.
        /// </summary>
        /// <param name="iosCustomConfigurationToCreate">The IosCustomConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosCustomConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosCustomConfiguration>> CreateResponseAsync(IosCustomConfiguration iosCustomConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosCustomConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosCustomConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosCustomConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified IosCustomConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosCustomConfiguration.
        /// </summary>
        /// <returns>The IosCustomConfiguration.</returns>
        System.Threading.Tasks.Task<IosCustomConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified IosCustomConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosCustomConfiguration.</returns>
        System.Threading.Tasks.Task<IosCustomConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosCustomConfiguration using PATCH.
        /// </summary>
        /// <param name="iosCustomConfigurationToUpdate">The IosCustomConfiguration to update.</param>
        /// <returns>The updated IosCustomConfiguration.</returns>
        System.Threading.Tasks.Task<IosCustomConfiguration> UpdateAsync(IosCustomConfiguration iosCustomConfigurationToUpdate);

        /// <summary>
        /// Updates the specified IosCustomConfiguration using PATCH.
        /// </summary>
        /// <param name="iosCustomConfigurationToUpdate">The IosCustomConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosCustomConfiguration.</returns>
        System.Threading.Tasks.Task<IosCustomConfiguration> UpdateAsync(IosCustomConfiguration iosCustomConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosCustomConfiguration using PATCH and returns a <see cref="GraphResponse{IosCustomConfiguration}"/> object.
        /// </summary>
        /// <param name="iosCustomConfigurationToUpdate">The IosCustomConfiguration to update.</param>
        /// <returns>The <see cref="GraphResponse{IosCustomConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosCustomConfiguration>> UpdateResponseAsync(IosCustomConfiguration iosCustomConfigurationToUpdate);

        /// <summary>
        /// Updates the specified IosCustomConfiguration using PATCH and returns a <see cref="GraphResponse{IosCustomConfiguration}"/> object.
        /// </summary>
        /// <param name="iosCustomConfigurationToUpdate">The IosCustomConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosCustomConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosCustomConfiguration>> UpdateResponseAsync(IosCustomConfiguration iosCustomConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosCustomConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosCustomConfigurationRequest Expand(Expression<Func<IosCustomConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosCustomConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosCustomConfigurationRequest Select(Expression<Func<IosCustomConfiguration, object>> selectExpression);

    }
}
