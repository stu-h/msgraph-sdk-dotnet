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
    /// The interface ICancelMediaProcessingOperationRequest.
    /// </summary>
    public partial interface ICancelMediaProcessingOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CancelMediaProcessingOperation using POST.
        /// </summary>
        /// <param name="cancelMediaProcessingOperationToCreate">The CancelMediaProcessingOperation to create.</param>
        /// <returns>The created CancelMediaProcessingOperation.</returns>
        System.Threading.Tasks.Task<CancelMediaProcessingOperation> CreateAsync(CancelMediaProcessingOperation cancelMediaProcessingOperationToCreate);

        /// <summary>
        /// Creates the specified CancelMediaProcessingOperation using POST.
        /// </summary>
        /// <param name="cancelMediaProcessingOperationToCreate">The CancelMediaProcessingOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CancelMediaProcessingOperation.</returns>
        System.Threading.Tasks.Task<CancelMediaProcessingOperation> CreateAsync(CancelMediaProcessingOperation cancelMediaProcessingOperationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified CancelMediaProcessingOperation using POST and returns a <see cref="GraphResponse{CancelMediaProcessingOperation}"/> object.
        /// </summary>
        /// <param name="cancelMediaProcessingOperationToCreate">The CancelMediaProcessingOperation to create.</param>
        /// <returns>The <see cref="GraphResponse{CancelMediaProcessingOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CancelMediaProcessingOperation>> CreateResponseAsync(CancelMediaProcessingOperation cancelMediaProcessingOperationToCreate);

        /// <summary>
        /// Creates the specified CancelMediaProcessingOperation using POST and returns a <see cref="GraphResponse{CancelMediaProcessingOperation}"/> object.
        /// </summary>
        /// <param name="cancelMediaProcessingOperationToCreate">The CancelMediaProcessingOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CancelMediaProcessingOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CancelMediaProcessingOperation>> CreateResponseAsync(CancelMediaProcessingOperation cancelMediaProcessingOperationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified CancelMediaProcessingOperation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified CancelMediaProcessingOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified CancelMediaProcessingOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified CancelMediaProcessingOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified CancelMediaProcessingOperation.
        /// </summary>
        /// <returns>The CancelMediaProcessingOperation.</returns>
        System.Threading.Tasks.Task<CancelMediaProcessingOperation> GetAsync();

        /// <summary>
        /// Gets the specified CancelMediaProcessingOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CancelMediaProcessingOperation.</returns>
        System.Threading.Tasks.Task<CancelMediaProcessingOperation> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified CancelMediaProcessingOperation using PATCH.
        /// </summary>
        /// <param name="cancelMediaProcessingOperationToUpdate">The CancelMediaProcessingOperation to update.</param>
        /// <returns>The updated CancelMediaProcessingOperation.</returns>
        System.Threading.Tasks.Task<CancelMediaProcessingOperation> UpdateAsync(CancelMediaProcessingOperation cancelMediaProcessingOperationToUpdate);

        /// <summary>
        /// Updates the specified CancelMediaProcessingOperation using PATCH.
        /// </summary>
        /// <param name="cancelMediaProcessingOperationToUpdate">The CancelMediaProcessingOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CancelMediaProcessingOperation.</returns>
        System.Threading.Tasks.Task<CancelMediaProcessingOperation> UpdateAsync(CancelMediaProcessingOperation cancelMediaProcessingOperationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified CancelMediaProcessingOperation using PATCH and returns a <see cref="GraphResponse{CancelMediaProcessingOperation}"/> object.
        /// </summary>
        /// <param name="cancelMediaProcessingOperationToUpdate">The CancelMediaProcessingOperation to update.</param>
        /// <returns>The <see cref="GraphResponse{CancelMediaProcessingOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CancelMediaProcessingOperation>> UpdateResponseAsync(CancelMediaProcessingOperation cancelMediaProcessingOperationToUpdate);

        /// <summary>
        /// Updates the specified CancelMediaProcessingOperation using PATCH and returns a <see cref="GraphResponse{CancelMediaProcessingOperation}"/> object.
        /// </summary>
        /// <param name="cancelMediaProcessingOperationToUpdate">The CancelMediaProcessingOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CancelMediaProcessingOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CancelMediaProcessingOperation>> UpdateResponseAsync(CancelMediaProcessingOperation cancelMediaProcessingOperationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICancelMediaProcessingOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICancelMediaProcessingOperationRequest Expand(Expression<Func<CancelMediaProcessingOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICancelMediaProcessingOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICancelMediaProcessingOperationRequest Select(Expression<Func<CancelMediaProcessingOperation, object>> selectExpression);

    }
}
