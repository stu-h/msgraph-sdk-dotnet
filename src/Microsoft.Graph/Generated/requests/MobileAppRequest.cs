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
    /// The type MobileAppRequest.
    /// </summary>
    public partial class MobileAppRequest : BaseRequest, IMobileAppRequest
    {
        /// <summary>
        /// Constructs a new MobileAppRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MobileAppRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MobileApp using POST.
        /// </summary>
        /// <param name="mobileAppToCreate">The MobileApp to create.</param>
        /// <returns>The created MobileApp.</returns>
        public System.Threading.Tasks.Task<MobileApp> CreateAsync(MobileApp mobileAppToCreate)
        {
            return this.CreateAsync(mobileAppToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MobileApp using POST.
        /// </summary>
        /// <param name="mobileAppToCreate">The MobileApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileApp.</returns>
        public async System.Threading.Tasks.Task<MobileApp> CreateAsync(MobileApp mobileAppToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MobileApp>(mobileAppToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MobileApp using POST and returns a <see cref="GraphResponse{MobileApp}"/> object.
        /// </summary>
        /// <param name="mobileAppToCreate">The MobileApp to create.</param>
        /// <returns>The <see cref="GraphResponse{MobileApp}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MobileApp>> CreateResponseAsync(MobileApp mobileAppToCreate)
        {
            return this.CreateResponseAsync(mobileAppToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MobileApp using POST and returns a <see cref="GraphResponse{MobileApp}"/> object.
        /// </summary>
        /// <param name="mobileAppToCreate">The MobileApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileApp}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MobileApp>> CreateResponseAsync(MobileApp mobileAppToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<MobileApp>(mobileAppToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MobileApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MobileApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MobileApp>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MobileApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MobileApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MobileApp.
        /// </summary>
        /// <returns>The MobileApp.</returns>
        public System.Threading.Tasks.Task<MobileApp> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MobileApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MobileApp.</returns>
        public async System.Threading.Tasks.Task<MobileApp> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MobileApp>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified MobileApp using PATCH.
        /// </summary>
        /// <param name="mobileAppToUpdate">The MobileApp to update.</param>
        /// <returns>The updated MobileApp.</returns>
        public System.Threading.Tasks.Task<MobileApp> UpdateAsync(MobileApp mobileAppToUpdate)
        {
            return this.UpdateAsync(mobileAppToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MobileApp using PATCH.
        /// </summary>
        /// <param name="mobileAppToUpdate">The MobileApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MobileApp.</returns>
        public async System.Threading.Tasks.Task<MobileApp> UpdateAsync(MobileApp mobileAppToUpdate, CancellationToken cancellationToken)
        {
			if (mobileAppToUpdate.AdditionalData != null)
			{
				if (mobileAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					mobileAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mobileAppToUpdate.GetType().Name)
						});
				}
			}
            if (mobileAppToUpdate.AdditionalData != null)
            {
                if (mobileAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    mobileAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mobileAppToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MobileApp>(mobileAppToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MobileApp using PATCH and returns a <see cref="GraphResponse{MobileApp}"/> object.
        /// </summary>
        /// <param name="mobileAppToUpdate">The MobileApp to update.</param>
        /// <returns>The <see cref="GraphResponse{MobileApp}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MobileApp>> UpdateResponseAsync(MobileApp mobileAppToUpdate)
        {
            return this.UpdateResponseAsync(mobileAppToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MobileApp using PATCH and returns a <see cref="GraphResponse{MobileApp}"/> object.
        /// </summary>
        /// <param name="mobileAppToUpdate">The MobileApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MobileApp}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MobileApp>> UpdateResponseAsync(MobileApp mobileAppToUpdate, CancellationToken cancellationToken)
        {
			if (mobileAppToUpdate.AdditionalData != null)
			{
				if (mobileAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					mobileAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mobileAppToUpdate.GetType().Name)
						});
				}
			}
            if (mobileAppToUpdate.AdditionalData != null)
            {
                if (mobileAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    mobileAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, mobileAppToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<MobileApp>(mobileAppToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileAppRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileAppRequest Expand(Expression<Func<MobileApp, object>> expandExpression)
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
        public IMobileAppRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileAppRequest Select(Expression<Func<MobileApp, object>> selectExpression)
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
        /// <param name="mobileAppToInitialize">The <see cref="MobileApp"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MobileApp mobileAppToInitialize)
        {

            if (mobileAppToInitialize != null && mobileAppToInitialize.AdditionalData != null)
            {

                if (mobileAppToInitialize.Assignments != null && mobileAppToInitialize.Assignments.CurrentPage != null)
                {
                    mobileAppToInitialize.Assignments.AdditionalData = mobileAppToInitialize.AdditionalData;

                    object nextPageLink;
                    mobileAppToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        mobileAppToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (mobileAppToInitialize.Categories != null && mobileAppToInitialize.Categories.CurrentPage != null)
                {
                    mobileAppToInitialize.Categories.AdditionalData = mobileAppToInitialize.AdditionalData;

                    object nextPageLink;
                    mobileAppToInitialize.AdditionalData.TryGetValue("categories@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        mobileAppToInitialize.Categories.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
