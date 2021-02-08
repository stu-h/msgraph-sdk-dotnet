// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type UnmuteParticipantOperationRequest.
    /// </summary>
    public partial class UnmuteParticipantOperationRequest : BaseRequest, IUnmuteParticipantOperationRequest
    {
        /// <summary>
        /// Constructs a new UnmuteParticipantOperationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UnmuteParticipantOperationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UnmuteParticipantOperation using POST.
        /// </summary>
        /// <param name="unmuteParticipantOperationToCreate">The UnmuteParticipantOperation to create.</param>
        /// <returns>The created UnmuteParticipantOperation.</returns>
        public System.Threading.Tasks.Task<UnmuteParticipantOperation> CreateAsync(UnmuteParticipantOperation unmuteParticipantOperationToCreate)
        {
            return this.CreateAsync(unmuteParticipantOperationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified UnmuteParticipantOperation using POST.
        /// </summary>
        /// <param name="unmuteParticipantOperationToCreate">The UnmuteParticipantOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnmuteParticipantOperation.</returns>
        public async System.Threading.Tasks.Task<UnmuteParticipantOperation> CreateAsync(UnmuteParticipantOperation unmuteParticipantOperationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<UnmuteParticipantOperation>(unmuteParticipantOperationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UnmuteParticipantOperation using POST and returns a <see cref="GraphResponse{UnmuteParticipantOperation}"/> object.
        /// </summary>
        /// <param name="unmuteParticipantOperationToCreate">The UnmuteParticipantOperation to create.</param>
        /// <returns>The <see cref="GraphResponse{UnmuteParticipantOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnmuteParticipantOperation>> CreateResponseAsync(UnmuteParticipantOperation unmuteParticipantOperationToCreate)
        {
            return this.CreateResponseAsync(unmuteParticipantOperationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified UnmuteParticipantOperation using POST and returns a <see cref="GraphResponse{UnmuteParticipantOperation}"/> object.
        /// </summary>
        /// <param name="unmuteParticipantOperationToCreate">The UnmuteParticipantOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnmuteParticipantOperation}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<UnmuteParticipantOperation>> CreateResponseAsync(UnmuteParticipantOperation unmuteParticipantOperationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<UnmuteParticipantOperation>(unmuteParticipantOperationToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UnmuteParticipantOperation.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified UnmuteParticipantOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<UnmuteParticipantOperation>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UnmuteParticipantOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified UnmuteParticipantOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified UnmuteParticipantOperation.
        /// </summary>
        /// <returns>The UnmuteParticipantOperation.</returns>
        public System.Threading.Tasks.Task<UnmuteParticipantOperation> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified UnmuteParticipantOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnmuteParticipantOperation.</returns>
        public async System.Threading.Tasks.Task<UnmuteParticipantOperation> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<UnmuteParticipantOperation>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified UnmuteParticipantOperation using PATCH.
        /// </summary>
        /// <param name="unmuteParticipantOperationToUpdate">The UnmuteParticipantOperation to update.</param>
        /// <returns>The updated UnmuteParticipantOperation.</returns>
        public System.Threading.Tasks.Task<UnmuteParticipantOperation> UpdateAsync(UnmuteParticipantOperation unmuteParticipantOperationToUpdate)
        {
            return this.UpdateAsync(unmuteParticipantOperationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified UnmuteParticipantOperation using PATCH.
        /// </summary>
        /// <param name="unmuteParticipantOperationToUpdate">The UnmuteParticipantOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnmuteParticipantOperation.</returns>
        public async System.Threading.Tasks.Task<UnmuteParticipantOperation> UpdateAsync(UnmuteParticipantOperation unmuteParticipantOperationToUpdate, CancellationToken cancellationToken)
        {
			if (unmuteParticipantOperationToUpdate.AdditionalData != null)
			{
				if (unmuteParticipantOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					unmuteParticipantOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, unmuteParticipantOperationToUpdate.GetType().Name)
						});
				}
			}
            if (unmuteParticipantOperationToUpdate.AdditionalData != null)
            {
                if (unmuteParticipantOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    unmuteParticipantOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, unmuteParticipantOperationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<UnmuteParticipantOperation>(unmuteParticipantOperationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UnmuteParticipantOperation using PATCH and returns a <see cref="GraphResponse{UnmuteParticipantOperation}"/> object.
        /// </summary>
        /// <param name="unmuteParticipantOperationToUpdate">The UnmuteParticipantOperation to update.</param>
        /// <returns>The <see cref="GraphResponse{UnmuteParticipantOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnmuteParticipantOperation>> UpdateResponseAsync(UnmuteParticipantOperation unmuteParticipantOperationToUpdate)
        {
            return this.UpdateResponseAsync(unmuteParticipantOperationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified UnmuteParticipantOperation using PATCH and returns a <see cref="GraphResponse{UnmuteParticipantOperation}"/> object.
        /// </summary>
        /// <param name="unmuteParticipantOperationToUpdate">The UnmuteParticipantOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnmuteParticipantOperation}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<UnmuteParticipantOperation>> UpdateResponseAsync(UnmuteParticipantOperation unmuteParticipantOperationToUpdate, CancellationToken cancellationToken)
        {
			if (unmuteParticipantOperationToUpdate.AdditionalData != null)
			{
				if (unmuteParticipantOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					unmuteParticipantOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, unmuteParticipantOperationToUpdate.GetType().Name)
						});
				}
			}
            if (unmuteParticipantOperationToUpdate.AdditionalData != null)
            {
                if (unmuteParticipantOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    unmuteParticipantOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, unmuteParticipantOperationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<UnmuteParticipantOperation>(unmuteParticipantOperationToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnmuteParticipantOperationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnmuteParticipantOperationRequest Expand(Expression<Func<UnmuteParticipantOperation, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IUnmuteParticipantOperationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUnmuteParticipantOperationRequest Select(Expression<Func<UnmuteParticipantOperation, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="unmuteParticipantOperationToInitialize">The <see cref="UnmuteParticipantOperation"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UnmuteParticipantOperation unmuteParticipantOperationToInitialize)
        {

        }
    }
}
