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
    /// The interface IIdentityCustomUserFlowAttributeRequest.
    /// </summary>
    public partial interface IIdentityCustomUserFlowAttributeRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IdentityCustomUserFlowAttribute using POST.
        /// </summary>
        /// <param name="identityCustomUserFlowAttributeToCreate">The IdentityCustomUserFlowAttribute to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IdentityCustomUserFlowAttribute.</returns>
        System.Threading.Tasks.Task<IdentityCustomUserFlowAttribute> CreateAsync(IdentityCustomUserFlowAttribute identityCustomUserFlowAttributeToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified IdentityCustomUserFlowAttribute using POST and returns a <see cref="GraphResponse{IdentityCustomUserFlowAttribute}"/> object.
        /// </summary>
        /// <param name="identityCustomUserFlowAttributeToCreate">The IdentityCustomUserFlowAttribute to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityCustomUserFlowAttribute}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityCustomUserFlowAttribute>> CreateResponseAsync(IdentityCustomUserFlowAttribute identityCustomUserFlowAttributeToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IdentityCustomUserFlowAttribute.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IdentityCustomUserFlowAttribute and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IdentityCustomUserFlowAttribute.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IdentityCustomUserFlowAttribute.</returns>
        System.Threading.Tasks.Task<IdentityCustomUserFlowAttribute> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IdentityCustomUserFlowAttribute and returns a <see cref="GraphResponse{IdentityCustomUserFlowAttribute}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityCustomUserFlowAttribute}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityCustomUserFlowAttribute>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IdentityCustomUserFlowAttribute using PATCH.
        /// </summary>
        /// <param name="identityCustomUserFlowAttributeToUpdate">The IdentityCustomUserFlowAttribute to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IdentityCustomUserFlowAttribute.</returns>
        System.Threading.Tasks.Task<IdentityCustomUserFlowAttribute> UpdateAsync(IdentityCustomUserFlowAttribute identityCustomUserFlowAttributeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IdentityCustomUserFlowAttribute using PATCH and returns a <see cref="GraphResponse{IdentityCustomUserFlowAttribute}"/> object.
        /// </summary>
        /// <param name="identityCustomUserFlowAttributeToUpdate">The IdentityCustomUserFlowAttribute to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IdentityCustomUserFlowAttribute}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityCustomUserFlowAttribute>> UpdateResponseAsync(IdentityCustomUserFlowAttribute identityCustomUserFlowAttributeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IdentityCustomUserFlowAttribute using PUT.
        /// </summary>
        /// <param name="identityCustomUserFlowAttributeToUpdate">The IdentityCustomUserFlowAttribute object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<IdentityCustomUserFlowAttribute> PutAsync(IdentityCustomUserFlowAttribute identityCustomUserFlowAttributeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IdentityCustomUserFlowAttribute using PUT and returns a <see cref="GraphResponse{IdentityCustomUserFlowAttribute}"/> object.
        /// </summary>
        /// <param name="identityCustomUserFlowAttributeToUpdate">The IdentityCustomUserFlowAttribute object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{IdentityCustomUserFlowAttribute}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityCustomUserFlowAttribute>> PutResponseAsync(IdentityCustomUserFlowAttribute identityCustomUserFlowAttributeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityCustomUserFlowAttributeRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityCustomUserFlowAttributeRequest Expand(Expression<Func<IdentityCustomUserFlowAttribute, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityCustomUserFlowAttributeRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityCustomUserFlowAttributeRequest Select(Expression<Func<IdentityCustomUserFlowAttribute, object>> selectExpression);

    }
}
