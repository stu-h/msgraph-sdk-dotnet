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
    /// The type SubscribeToToneOperationRequest.
    /// </summary>
    public partial class SubscribeToToneOperationRequest : BaseRequest, ISubscribeToToneOperationRequest
    {
        /// <summary>
        /// Constructs a new SubscribeToToneOperationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SubscribeToToneOperationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SubscribeToToneOperation using POST.
        /// </summary>
        /// <param name="subscribeToToneOperationToCreate">The SubscribeToToneOperation to create.</param>
        /// <returns>The created SubscribeToToneOperation.</returns>
        public System.Threading.Tasks.Task<SubscribeToToneOperation> CreateAsync(SubscribeToToneOperation subscribeToToneOperationToCreate)
        {
            return this.CreateAsync(subscribeToToneOperationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SubscribeToToneOperation using POST.
        /// </summary>
        /// <param name="subscribeToToneOperationToCreate">The SubscribeToToneOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SubscribeToToneOperation.</returns>
        public async System.Threading.Tasks.Task<SubscribeToToneOperation> CreateAsync(SubscribeToToneOperation subscribeToToneOperationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<SubscribeToToneOperation>(subscribeToToneOperationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SubscribeToToneOperation using POST and returns a <see cref="GraphResponse{SubscribeToToneOperation}"/> object.
        /// </summary>
        /// <param name="subscribeToToneOperationToCreate">The SubscribeToToneOperation to create.</param>
        /// <returns>The <see cref="GraphResponse{SubscribeToToneOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SubscribeToToneOperation>> CreateResponseAsync(SubscribeToToneOperation subscribeToToneOperationToCreate)
        {
            return this.CreateResponseAsync(subscribeToToneOperationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SubscribeToToneOperation using POST and returns a <see cref="GraphResponse{SubscribeToToneOperation}"/> object.
        /// </summary>
        /// <param name="subscribeToToneOperationToCreate">The SubscribeToToneOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SubscribeToToneOperation}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SubscribeToToneOperation>> CreateResponseAsync(SubscribeToToneOperation subscribeToToneOperationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<SubscribeToToneOperation>(subscribeToToneOperationToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SubscribeToToneOperation.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SubscribeToToneOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<SubscribeToToneOperation>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SubscribeToToneOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SubscribeToToneOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified SubscribeToToneOperation.
        /// </summary>
        /// <returns>The SubscribeToToneOperation.</returns>
        public System.Threading.Tasks.Task<SubscribeToToneOperation> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SubscribeToToneOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SubscribeToToneOperation.</returns>
        public async System.Threading.Tasks.Task<SubscribeToToneOperation> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<SubscribeToToneOperation>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified SubscribeToToneOperation using PATCH.
        /// </summary>
        /// <param name="subscribeToToneOperationToUpdate">The SubscribeToToneOperation to update.</param>
        /// <returns>The updated SubscribeToToneOperation.</returns>
        public System.Threading.Tasks.Task<SubscribeToToneOperation> UpdateAsync(SubscribeToToneOperation subscribeToToneOperationToUpdate)
        {
            return this.UpdateAsync(subscribeToToneOperationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SubscribeToToneOperation using PATCH.
        /// </summary>
        /// <param name="subscribeToToneOperationToUpdate">The SubscribeToToneOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SubscribeToToneOperation.</returns>
        public async System.Threading.Tasks.Task<SubscribeToToneOperation> UpdateAsync(SubscribeToToneOperation subscribeToToneOperationToUpdate, CancellationToken cancellationToken)
        {
			if (subscribeToToneOperationToUpdate.AdditionalData != null)
			{
				if (subscribeToToneOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					subscribeToToneOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, subscribeToToneOperationToUpdate.GetType().Name)
						});
				}
			}
            if (subscribeToToneOperationToUpdate.AdditionalData != null)
            {
                if (subscribeToToneOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    subscribeToToneOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, subscribeToToneOperationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<SubscribeToToneOperation>(subscribeToToneOperationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SubscribeToToneOperation using PATCH and returns a <see cref="GraphResponse{SubscribeToToneOperation}"/> object.
        /// </summary>
        /// <param name="subscribeToToneOperationToUpdate">The SubscribeToToneOperation to update.</param>
        /// <returns>The <see cref="GraphResponse{SubscribeToToneOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SubscribeToToneOperation>> UpdateResponseAsync(SubscribeToToneOperation subscribeToToneOperationToUpdate)
        {
            return this.UpdateResponseAsync(subscribeToToneOperationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SubscribeToToneOperation using PATCH and returns a <see cref="GraphResponse{SubscribeToToneOperation}"/> object.
        /// </summary>
        /// <param name="subscribeToToneOperationToUpdate">The SubscribeToToneOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SubscribeToToneOperation}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SubscribeToToneOperation>> UpdateResponseAsync(SubscribeToToneOperation subscribeToToneOperationToUpdate, CancellationToken cancellationToken)
        {
			if (subscribeToToneOperationToUpdate.AdditionalData != null)
			{
				if (subscribeToToneOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					subscribeToToneOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, subscribeToToneOperationToUpdate.GetType().Name)
						});
				}
			}
            if (subscribeToToneOperationToUpdate.AdditionalData != null)
            {
                if (subscribeToToneOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    subscribeToToneOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, subscribeToToneOperationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<SubscribeToToneOperation>(subscribeToToneOperationToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISubscribeToToneOperationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISubscribeToToneOperationRequest Expand(Expression<Func<SubscribeToToneOperation, object>> expandExpression)
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
        public ISubscribeToToneOperationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISubscribeToToneOperationRequest Select(Expression<Func<SubscribeToToneOperation, object>> selectExpression)
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
        /// <param name="subscribeToToneOperationToInitialize">The <see cref="SubscribeToToneOperation"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SubscribeToToneOperation subscribeToToneOperationToInitialize)
        {

        }
    }
}
