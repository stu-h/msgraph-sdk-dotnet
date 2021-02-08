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
    /// The type OnenoteEntityBaseModelRequest.
    /// </summary>
    public partial class OnenoteEntityBaseModelRequest : BaseRequest, IOnenoteEntityBaseModelRequest
    {
        /// <summary>
        /// Constructs a new OnenoteEntityBaseModelRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OnenoteEntityBaseModelRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OnenoteEntityBaseModel using POST.
        /// </summary>
        /// <param name="onenoteEntityBaseModelToCreate">The OnenoteEntityBaseModel to create.</param>
        /// <returns>The created OnenoteEntityBaseModel.</returns>
        public System.Threading.Tasks.Task<OnenoteEntityBaseModel> CreateAsync(OnenoteEntityBaseModel onenoteEntityBaseModelToCreate)
        {
            return this.CreateAsync(onenoteEntityBaseModelToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OnenoteEntityBaseModel using POST.
        /// </summary>
        /// <param name="onenoteEntityBaseModelToCreate">The OnenoteEntityBaseModel to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnenoteEntityBaseModel.</returns>
        public async System.Threading.Tasks.Task<OnenoteEntityBaseModel> CreateAsync(OnenoteEntityBaseModel onenoteEntityBaseModelToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<OnenoteEntityBaseModel>(onenoteEntityBaseModelToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified OnenoteEntityBaseModel using POST and returns a <see cref="GraphResponse{OnenoteEntityBaseModel}"/> object.
        /// </summary>
        /// <param name="onenoteEntityBaseModelToCreate">The OnenoteEntityBaseModel to create.</param>
        /// <returns>The <see cref="GraphResponse{OnenoteEntityBaseModel}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OnenoteEntityBaseModel>> CreateResponseAsync(OnenoteEntityBaseModel onenoteEntityBaseModelToCreate)
        {
            return this.CreateResponseAsync(onenoteEntityBaseModelToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OnenoteEntityBaseModel using POST and returns a <see cref="GraphResponse{OnenoteEntityBaseModel}"/> object.
        /// </summary>
        /// <param name="onenoteEntityBaseModelToCreate">The OnenoteEntityBaseModel to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnenoteEntityBaseModel}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<OnenoteEntityBaseModel>> CreateResponseAsync(OnenoteEntityBaseModel onenoteEntityBaseModelToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<OnenoteEntityBaseModel>(onenoteEntityBaseModelToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OnenoteEntityBaseModel.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OnenoteEntityBaseModel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<OnenoteEntityBaseModel>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OnenoteEntityBaseModel and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OnenoteEntityBaseModel and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified OnenoteEntityBaseModel.
        /// </summary>
        /// <returns>The OnenoteEntityBaseModel.</returns>
        public System.Threading.Tasks.Task<OnenoteEntityBaseModel> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified OnenoteEntityBaseModel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnenoteEntityBaseModel.</returns>
        public async System.Threading.Tasks.Task<OnenoteEntityBaseModel> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<OnenoteEntityBaseModel>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified OnenoteEntityBaseModel using PATCH.
        /// </summary>
        /// <param name="onenoteEntityBaseModelToUpdate">The OnenoteEntityBaseModel to update.</param>
        /// <returns>The updated OnenoteEntityBaseModel.</returns>
        public System.Threading.Tasks.Task<OnenoteEntityBaseModel> UpdateAsync(OnenoteEntityBaseModel onenoteEntityBaseModelToUpdate)
        {
            return this.UpdateAsync(onenoteEntityBaseModelToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified OnenoteEntityBaseModel using PATCH.
        /// </summary>
        /// <param name="onenoteEntityBaseModelToUpdate">The OnenoteEntityBaseModel to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OnenoteEntityBaseModel.</returns>
        public async System.Threading.Tasks.Task<OnenoteEntityBaseModel> UpdateAsync(OnenoteEntityBaseModel onenoteEntityBaseModelToUpdate, CancellationToken cancellationToken)
        {
			if (onenoteEntityBaseModelToUpdate.AdditionalData != null)
			{
				if (onenoteEntityBaseModelToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					onenoteEntityBaseModelToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, onenoteEntityBaseModelToUpdate.GetType().Name)
						});
				}
			}
            if (onenoteEntityBaseModelToUpdate.AdditionalData != null)
            {
                if (onenoteEntityBaseModelToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    onenoteEntityBaseModelToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, onenoteEntityBaseModelToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<OnenoteEntityBaseModel>(onenoteEntityBaseModelToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified OnenoteEntityBaseModel using PATCH and returns a <see cref="GraphResponse{OnenoteEntityBaseModel}"/> object.
        /// </summary>
        /// <param name="onenoteEntityBaseModelToUpdate">The OnenoteEntityBaseModel to update.</param>
        /// <returns>The <see cref="GraphResponse{OnenoteEntityBaseModel}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OnenoteEntityBaseModel>> UpdateResponseAsync(OnenoteEntityBaseModel onenoteEntityBaseModelToUpdate)
        {
            return this.UpdateResponseAsync(onenoteEntityBaseModelToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified OnenoteEntityBaseModel using PATCH and returns a <see cref="GraphResponse{OnenoteEntityBaseModel}"/> object.
        /// </summary>
        /// <param name="onenoteEntityBaseModelToUpdate">The OnenoteEntityBaseModel to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OnenoteEntityBaseModel}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<OnenoteEntityBaseModel>> UpdateResponseAsync(OnenoteEntityBaseModel onenoteEntityBaseModelToUpdate, CancellationToken cancellationToken)
        {
			if (onenoteEntityBaseModelToUpdate.AdditionalData != null)
			{
				if (onenoteEntityBaseModelToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					onenoteEntityBaseModelToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, onenoteEntityBaseModelToUpdate.GetType().Name)
						});
				}
			}
            if (onenoteEntityBaseModelToUpdate.AdditionalData != null)
            {
                if (onenoteEntityBaseModelToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    onenoteEntityBaseModelToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, onenoteEntityBaseModelToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<OnenoteEntityBaseModel>(onenoteEntityBaseModelToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOnenoteEntityBaseModelRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOnenoteEntityBaseModelRequest Expand(Expression<Func<OnenoteEntityBaseModel, object>> expandExpression)
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
        public IOnenoteEntityBaseModelRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOnenoteEntityBaseModelRequest Select(Expression<Func<OnenoteEntityBaseModel, object>> selectExpression)
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
        /// <param name="onenoteEntityBaseModelToInitialize">The <see cref="OnenoteEntityBaseModel"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OnenoteEntityBaseModel onenoteEntityBaseModelToInitialize)
        {

        }
    }
}
