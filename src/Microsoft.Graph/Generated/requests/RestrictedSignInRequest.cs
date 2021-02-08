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
    /// The type RestrictedSignInRequest.
    /// </summary>
    public partial class RestrictedSignInRequest : BaseRequest, IRestrictedSignInRequest
    {
        /// <summary>
        /// Constructs a new RestrictedSignInRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public RestrictedSignInRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified RestrictedSignIn using POST.
        /// </summary>
        /// <param name="restrictedSignInToCreate">The RestrictedSignIn to create.</param>
        /// <returns>The created RestrictedSignIn.</returns>
        public System.Threading.Tasks.Task<RestrictedSignIn> CreateAsync(RestrictedSignIn restrictedSignInToCreate)
        {
            return this.CreateAsync(restrictedSignInToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified RestrictedSignIn using POST.
        /// </summary>
        /// <param name="restrictedSignInToCreate">The RestrictedSignIn to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RestrictedSignIn.</returns>
        public async System.Threading.Tasks.Task<RestrictedSignIn> CreateAsync(RestrictedSignIn restrictedSignInToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<RestrictedSignIn>(restrictedSignInToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified RestrictedSignIn using POST and returns a <see cref="GraphResponse{RestrictedSignIn}"/> object.
        /// </summary>
        /// <param name="restrictedSignInToCreate">The RestrictedSignIn to create.</param>
        /// <returns>The <see cref="GraphResponse{RestrictedSignIn}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RestrictedSignIn>> CreateResponseAsync(RestrictedSignIn restrictedSignInToCreate)
        {
            return this.CreateResponseAsync(restrictedSignInToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified RestrictedSignIn using POST and returns a <see cref="GraphResponse{RestrictedSignIn}"/> object.
        /// </summary>
        /// <param name="restrictedSignInToCreate">The RestrictedSignIn to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RestrictedSignIn}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<RestrictedSignIn>> CreateResponseAsync(RestrictedSignIn restrictedSignInToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<RestrictedSignIn>(restrictedSignInToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified RestrictedSignIn.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified RestrictedSignIn.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<RestrictedSignIn>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified RestrictedSignIn and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified RestrictedSignIn and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified RestrictedSignIn.
        /// </summary>
        /// <returns>The RestrictedSignIn.</returns>
        public System.Threading.Tasks.Task<RestrictedSignIn> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified RestrictedSignIn.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RestrictedSignIn.</returns>
        public async System.Threading.Tasks.Task<RestrictedSignIn> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<RestrictedSignIn>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified RestrictedSignIn using PATCH.
        /// </summary>
        /// <param name="restrictedSignInToUpdate">The RestrictedSignIn to update.</param>
        /// <returns>The updated RestrictedSignIn.</returns>
        public System.Threading.Tasks.Task<RestrictedSignIn> UpdateAsync(RestrictedSignIn restrictedSignInToUpdate)
        {
            return this.UpdateAsync(restrictedSignInToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified RestrictedSignIn using PATCH.
        /// </summary>
        /// <param name="restrictedSignInToUpdate">The RestrictedSignIn to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RestrictedSignIn.</returns>
        public async System.Threading.Tasks.Task<RestrictedSignIn> UpdateAsync(RestrictedSignIn restrictedSignInToUpdate, CancellationToken cancellationToken)
        {
			if (restrictedSignInToUpdate.AdditionalData != null)
			{
				if (restrictedSignInToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					restrictedSignInToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, restrictedSignInToUpdate.GetType().Name)
						});
				}
			}
            if (restrictedSignInToUpdate.AdditionalData != null)
            {
                if (restrictedSignInToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    restrictedSignInToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, restrictedSignInToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<RestrictedSignIn>(restrictedSignInToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified RestrictedSignIn using PATCH and returns a <see cref="GraphResponse{RestrictedSignIn}"/> object.
        /// </summary>
        /// <param name="restrictedSignInToUpdate">The RestrictedSignIn to update.</param>
        /// <returns>The <see cref="GraphResponse{RestrictedSignIn}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RestrictedSignIn>> UpdateResponseAsync(RestrictedSignIn restrictedSignInToUpdate)
        {
            return this.UpdateResponseAsync(restrictedSignInToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified RestrictedSignIn using PATCH and returns a <see cref="GraphResponse{RestrictedSignIn}"/> object.
        /// </summary>
        /// <param name="restrictedSignInToUpdate">The RestrictedSignIn to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{RestrictedSignIn}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<RestrictedSignIn>> UpdateResponseAsync(RestrictedSignIn restrictedSignInToUpdate, CancellationToken cancellationToken)
        {
			if (restrictedSignInToUpdate.AdditionalData != null)
			{
				if (restrictedSignInToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					restrictedSignInToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, restrictedSignInToUpdate.GetType().Name)
						});
				}
			}
            if (restrictedSignInToUpdate.AdditionalData != null)
            {
                if (restrictedSignInToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    restrictedSignInToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, restrictedSignInToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<RestrictedSignIn>(restrictedSignInToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRestrictedSignInRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRestrictedSignInRequest Expand(Expression<Func<RestrictedSignIn, object>> expandExpression)
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
        public IRestrictedSignInRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IRestrictedSignInRequest Select(Expression<Func<RestrictedSignIn, object>> selectExpression)
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
        /// <param name="restrictedSignInToInitialize">The <see cref="RestrictedSignIn"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(RestrictedSignIn restrictedSignInToInitialize)
        {

        }
    }
}
