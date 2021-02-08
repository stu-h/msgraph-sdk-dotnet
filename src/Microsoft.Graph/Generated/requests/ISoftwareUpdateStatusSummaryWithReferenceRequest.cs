// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISoftwareUpdateStatusSummaryWithReferenceRequest.
    /// </summary>
    public partial interface ISoftwareUpdateStatusSummaryWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified SoftwareUpdateStatusSummary.
        /// </summary>
        /// <returns>The SoftwareUpdateStatusSummary.</returns>
        System.Threading.Tasks.Task<SoftwareUpdateStatusSummary> GetAsync();

        /// <summary>
        /// Gets the specified SoftwareUpdateStatusSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SoftwareUpdateStatusSummary.</returns>
        System.Threading.Tasks.Task<SoftwareUpdateStatusSummary> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified SoftwareUpdateStatusSummary using POST.
        /// </summary>
        /// <param name="softwareUpdateStatusSummaryToCreate">The SoftwareUpdateStatusSummary to create.</param>
        /// <returns>The created SoftwareUpdateStatusSummary.</returns>
        System.Threading.Tasks.Task<SoftwareUpdateStatusSummary> CreateAsync(SoftwareUpdateStatusSummary softwareUpdateStatusSummaryToCreate);

        /// <summary>
        /// Creates the specified SoftwareUpdateStatusSummary using POST.
        /// </summary>
        /// <param name="softwareUpdateStatusSummaryToCreate">The SoftwareUpdateStatusSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SoftwareUpdateStatusSummary.</returns>
        System.Threading.Tasks.Task<SoftwareUpdateStatusSummary> CreateAsync(SoftwareUpdateStatusSummary softwareUpdateStatusSummaryToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified SoftwareUpdateStatusSummary using POST and returns a <see cref="GraphResponse{SoftwareUpdateStatusSummary}"/> object.
        /// </summary>
        /// <param name="softwareUpdateStatusSummaryToCreate">The SoftwareUpdateStatusSummary to create.</param>
        /// <returns>The <see cref="GraphResponse{SoftwareUpdateStatusSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SoftwareUpdateStatusSummary>> CreateResponseAsync(SoftwareUpdateStatusSummary softwareUpdateStatusSummaryToCreate);

        /// <summary>
        /// Creates the specified SoftwareUpdateStatusSummary using POST and returns a <see cref="GraphResponse{SoftwareUpdateStatusSummary}"/> object.
        /// </summary>
        /// <param name="softwareUpdateStatusSummaryToCreate">The SoftwareUpdateStatusSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SoftwareUpdateStatusSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SoftwareUpdateStatusSummary>> CreateResponseAsync(SoftwareUpdateStatusSummary softwareUpdateStatusSummaryToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified SoftwareUpdateStatusSummary using PATCH.
        /// </summary>
        /// <param name="softwareUpdateStatusSummaryToUpdate">The SoftwareUpdateStatusSummary to update.</param>
        /// <returns>The updated SoftwareUpdateStatusSummary.</returns>
        System.Threading.Tasks.Task<SoftwareUpdateStatusSummary> UpdateAsync(SoftwareUpdateStatusSummary softwareUpdateStatusSummaryToUpdate);

        /// <summary>
        /// Updates the specified SoftwareUpdateStatusSummary using PATCH.
        /// </summary>
        /// <param name="softwareUpdateStatusSummaryToUpdate">The SoftwareUpdateStatusSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SoftwareUpdateStatusSummary.</returns>
        System.Threading.Tasks.Task<SoftwareUpdateStatusSummary> UpdateAsync(SoftwareUpdateStatusSummary softwareUpdateStatusSummaryToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified SoftwareUpdateStatusSummary using PATCH and returns a <see cref="GraphResponse{SoftwareUpdateStatusSummary}"/> object.
        /// </summary>
        /// <param name="softwareUpdateStatusSummaryToUpdate">The SoftwareUpdateStatusSummary to update.</param>
        /// <returns>The <see cref="GraphResponse{SoftwareUpdateStatusSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SoftwareUpdateStatusSummary>> UpdateResponseAsync(SoftwareUpdateStatusSummary softwareUpdateStatusSummaryToUpdate);

        /// <summary>
        /// Updates the specified SoftwareUpdateStatusSummary using PATCH and returns a <see cref="GraphResponse{SoftwareUpdateStatusSummary}"/> object.
        /// </summary>
        /// <param name="softwareUpdateStatusSummaryToUpdate">The SoftwareUpdateStatusSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SoftwareUpdateStatusSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SoftwareUpdateStatusSummary>> UpdateResponseAsync(SoftwareUpdateStatusSummary softwareUpdateStatusSummaryToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified SoftwareUpdateStatusSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SoftwareUpdateStatusSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified SoftwareUpdateStatusSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified SoftwareUpdateStatusSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISoftwareUpdateStatusSummaryWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISoftwareUpdateStatusSummaryWithReferenceRequest Expand(Expression<Func<SoftwareUpdateStatusSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISoftwareUpdateStatusSummaryWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISoftwareUpdateStatusSummaryWithReferenceRequest Select(Expression<Func<SoftwareUpdateStatusSummary, object>> selectExpression);

    }
}
