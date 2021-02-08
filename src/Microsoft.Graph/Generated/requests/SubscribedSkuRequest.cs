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
    /// The type SubscribedSkuRequest.
    /// </summary>
    public partial class SubscribedSkuRequest : BaseRequest, ISubscribedSkuRequest
    {
        /// <summary>
        /// Constructs a new SubscribedSkuRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SubscribedSkuRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SubscribedSku using POST.
        /// </summary>
        /// <param name="subscribedSkuToCreate">The SubscribedSku to create.</param>
        /// <returns>The created SubscribedSku.</returns>
        public System.Threading.Tasks.Task<SubscribedSku> CreateAsync(SubscribedSku subscribedSkuToCreate)
        {
            return this.CreateAsync(subscribedSkuToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SubscribedSku using POST.
        /// </summary>
        /// <param name="subscribedSkuToCreate">The SubscribedSku to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SubscribedSku.</returns>
        public async System.Threading.Tasks.Task<SubscribedSku> CreateAsync(SubscribedSku subscribedSkuToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<SubscribedSku>(subscribedSkuToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SubscribedSku using POST and returns a <see cref="GraphResponse{SubscribedSku}"/> object.
        /// </summary>
        /// <param name="subscribedSkuToCreate">The SubscribedSku to create.</param>
        /// <returns>The <see cref="GraphResponse{SubscribedSku}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SubscribedSku>> CreateResponseAsync(SubscribedSku subscribedSkuToCreate)
        {
            return this.CreateResponseAsync(subscribedSkuToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SubscribedSku using POST and returns a <see cref="GraphResponse{SubscribedSku}"/> object.
        /// </summary>
        /// <param name="subscribedSkuToCreate">The SubscribedSku to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SubscribedSku}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SubscribedSku>> CreateResponseAsync(SubscribedSku subscribedSkuToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<SubscribedSku>(subscribedSkuToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SubscribedSku.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SubscribedSku.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<SubscribedSku>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SubscribedSku and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SubscribedSku and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified SubscribedSku.
        /// </summary>
        /// <returns>The SubscribedSku.</returns>
        public System.Threading.Tasks.Task<SubscribedSku> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SubscribedSku.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SubscribedSku.</returns>
        public async System.Threading.Tasks.Task<SubscribedSku> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<SubscribedSku>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified SubscribedSku using PATCH.
        /// </summary>
        /// <param name="subscribedSkuToUpdate">The SubscribedSku to update.</param>
        /// <returns>The updated SubscribedSku.</returns>
        public System.Threading.Tasks.Task<SubscribedSku> UpdateAsync(SubscribedSku subscribedSkuToUpdate)
        {
            return this.UpdateAsync(subscribedSkuToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SubscribedSku using PATCH.
        /// </summary>
        /// <param name="subscribedSkuToUpdate">The SubscribedSku to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SubscribedSku.</returns>
        public async System.Threading.Tasks.Task<SubscribedSku> UpdateAsync(SubscribedSku subscribedSkuToUpdate, CancellationToken cancellationToken)
        {
			if (subscribedSkuToUpdate.AdditionalData != null)
			{
				if (subscribedSkuToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					subscribedSkuToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, subscribedSkuToUpdate.GetType().Name)
						});
				}
			}
            if (subscribedSkuToUpdate.AdditionalData != null)
            {
                if (subscribedSkuToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    subscribedSkuToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, subscribedSkuToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<SubscribedSku>(subscribedSkuToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SubscribedSku using PATCH and returns a <see cref="GraphResponse{SubscribedSku}"/> object.
        /// </summary>
        /// <param name="subscribedSkuToUpdate">The SubscribedSku to update.</param>
        /// <returns>The <see cref="GraphResponse{SubscribedSku}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SubscribedSku>> UpdateResponseAsync(SubscribedSku subscribedSkuToUpdate)
        {
            return this.UpdateResponseAsync(subscribedSkuToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SubscribedSku using PATCH and returns a <see cref="GraphResponse{SubscribedSku}"/> object.
        /// </summary>
        /// <param name="subscribedSkuToUpdate">The SubscribedSku to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SubscribedSku}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<SubscribedSku>> UpdateResponseAsync(SubscribedSku subscribedSkuToUpdate, CancellationToken cancellationToken)
        {
			if (subscribedSkuToUpdate.AdditionalData != null)
			{
				if (subscribedSkuToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					subscribedSkuToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, subscribedSkuToUpdate.GetType().Name)
						});
				}
			}
            if (subscribedSkuToUpdate.AdditionalData != null)
            {
                if (subscribedSkuToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    subscribedSkuToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, subscribedSkuToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<SubscribedSku>(subscribedSkuToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISubscribedSkuRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISubscribedSkuRequest Expand(Expression<Func<SubscribedSku, object>> expandExpression)
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
        public ISubscribedSkuRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISubscribedSkuRequest Select(Expression<Func<SubscribedSku, object>> selectExpression)
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
        /// <param name="subscribedSkuToInitialize">The <see cref="SubscribedSku"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SubscribedSku subscribedSkuToInitialize)
        {

        }
    }
}
