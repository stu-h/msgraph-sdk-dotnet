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
    /// The type WorkbookRangeFillRequest.
    /// </summary>
    public partial class WorkbookRangeFillRequest : BaseRequest, IWorkbookRangeFillRequest
    {
        /// <summary>
        /// Constructs a new WorkbookRangeFillRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookRangeFillRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookRangeFill using POST.
        /// </summary>
        /// <param name="workbookRangeFillToCreate">The WorkbookRangeFill to create.</param>
        /// <returns>The created WorkbookRangeFill.</returns>
        public System.Threading.Tasks.Task<WorkbookRangeFill> CreateAsync(WorkbookRangeFill workbookRangeFillToCreate)
        {
            return this.CreateAsync(workbookRangeFillToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookRangeFill using POST.
        /// </summary>
        /// <param name="workbookRangeFillToCreate">The WorkbookRangeFill to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookRangeFill.</returns>
        public async System.Threading.Tasks.Task<WorkbookRangeFill> CreateAsync(WorkbookRangeFill workbookRangeFillToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookRangeFill>(workbookRangeFillToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WorkbookRangeFill using POST and returns a <see cref="GraphResponse{WorkbookRangeFill}"/> object.
        /// </summary>
        /// <param name="workbookRangeFillToCreate">The WorkbookRangeFill to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFill}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFill>> CreateResponseAsync(WorkbookRangeFill workbookRangeFillToCreate)
        {
            return this.CreateResponseAsync(workbookRangeFillToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookRangeFill using POST and returns a <see cref="GraphResponse{WorkbookRangeFill}"/> object.
        /// </summary>
        /// <param name="workbookRangeFillToCreate">The WorkbookRangeFill to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFill}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFill>> CreateResponseAsync(WorkbookRangeFill workbookRangeFillToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<WorkbookRangeFill>(workbookRangeFillToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookRangeFill.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookRangeFill.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookRangeFill>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookRangeFill and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookRangeFill and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookRangeFill.
        /// </summary>
        /// <returns>The WorkbookRangeFill.</returns>
        public System.Threading.Tasks.Task<WorkbookRangeFill> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookRangeFill.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookRangeFill.</returns>
        public async System.Threading.Tasks.Task<WorkbookRangeFill> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookRangeFill>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookRangeFill using PATCH.
        /// </summary>
        /// <param name="workbookRangeFillToUpdate">The WorkbookRangeFill to update.</param>
        /// <returns>The updated WorkbookRangeFill.</returns>
        public System.Threading.Tasks.Task<WorkbookRangeFill> UpdateAsync(WorkbookRangeFill workbookRangeFillToUpdate)
        {
            return this.UpdateAsync(workbookRangeFillToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookRangeFill using PATCH.
        /// </summary>
        /// <param name="workbookRangeFillToUpdate">The WorkbookRangeFill to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookRangeFill.</returns>
        public async System.Threading.Tasks.Task<WorkbookRangeFill> UpdateAsync(WorkbookRangeFill workbookRangeFillToUpdate, CancellationToken cancellationToken)
        {
			if (workbookRangeFillToUpdate.AdditionalData != null)
			{
				if (workbookRangeFillToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookRangeFillToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookRangeFillToUpdate.GetType().Name)
						});
				}
			}
            if (workbookRangeFillToUpdate.AdditionalData != null)
            {
                if (workbookRangeFillToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookRangeFillToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookRangeFillToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookRangeFill>(workbookRangeFillToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookRangeFill using PATCH and returns a <see cref="GraphResponse{WorkbookRangeFill}"/> object.
        /// </summary>
        /// <param name="workbookRangeFillToUpdate">The WorkbookRangeFill to update.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFill}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFill>> UpdateResponseAsync(WorkbookRangeFill workbookRangeFillToUpdate)
        {
            return this.UpdateResponseAsync(workbookRangeFillToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookRangeFill using PATCH and returns a <see cref="GraphResponse{WorkbookRangeFill}"/> object.
        /// </summary>
        /// <param name="workbookRangeFillToUpdate">The WorkbookRangeFill to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFill}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFill>> UpdateResponseAsync(WorkbookRangeFill workbookRangeFillToUpdate, CancellationToken cancellationToken)
        {
			if (workbookRangeFillToUpdate.AdditionalData != null)
			{
				if (workbookRangeFillToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookRangeFillToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookRangeFillToUpdate.GetType().Name)
						});
				}
			}
            if (workbookRangeFillToUpdate.AdditionalData != null)
            {
                if (workbookRangeFillToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookRangeFillToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookRangeFillToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<WorkbookRangeFill>(workbookRangeFillToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRangeFillRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRangeFillRequest Expand(Expression<Func<WorkbookRangeFill, object>> expandExpression)
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
        public IWorkbookRangeFillRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRangeFillRequest Select(Expression<Func<WorkbookRangeFill, object>> selectExpression)
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
        /// <param name="workbookRangeFillToInitialize">The <see cref="WorkbookRangeFill"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookRangeFill workbookRangeFillToInitialize)
        {

        }
    }
}
