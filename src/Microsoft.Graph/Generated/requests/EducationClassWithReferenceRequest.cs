// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type EducationClassWithReferenceRequest.
    /// </summary>
    public partial class EducationClassWithReferenceRequest : BaseRequest, IEducationClassWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new EducationClassWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EducationClassWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified EducationClass.
        /// </summary>
        /// <returns>The EducationClass.</returns>
        public System.Threading.Tasks.Task<EducationClass> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EducationClass.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationClass.</returns>
        public async System.Threading.Tasks.Task<EducationClass> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<EducationClass>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

		/// <summary>
        /// Creates the specified EducationClass using POST.
        /// </summary>
        /// <param name="educationClassToCreate">The EducationClass to create.</param>
        /// <returns>The created EducationClass.</returns>
        public System.Threading.Tasks.Task<EducationClass> CreateAsync(EducationClass educationClassToCreate)
        {
            return this.CreateAsync(educationClassToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EducationClass using POST.
        /// </summary>
        /// <param name="educationClassToCreate">The EducationClass to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationClass.</returns>
        public async System.Threading.Tasks.Task<EducationClass> CreateAsync(EducationClass educationClassToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<EducationClass>(educationClassToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified EducationClass using POST and returns a <see cref="GraphResponse{EducationClass}"/> object.
        /// </summary>
        /// <param name="educationClassToCreate">The EducationClass to create.</param>
        /// <returns>The <see cref="GraphResponse{EducationClass}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationClass>> CreateResponseAsync(EducationClass educationClassToCreate)
        {
            return this.CreateResponseAsync(educationClassToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EducationClass using POST and returns a <see cref="GraphResponse{EducationClass}"/> object.
        /// </summary>
        /// <param name="educationClassToCreate">The EducationClass to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationClass}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EducationClass>> CreateResponseAsync(EducationClass educationClassToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<EducationClass>(educationClassToCreate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Updates the specified EducationClass using PATCH.
        /// </summary>
        /// <param name="educationClassToUpdate">The EducationClass to update.</param>
        /// <returns>The updated EducationClass.</returns>
        public System.Threading.Tasks.Task<EducationClass> UpdateAsync(EducationClass educationClassToUpdate)
        {
            return this.UpdateAsync(educationClassToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EducationClass using PATCH.
        /// </summary>
        /// <param name="educationClassToUpdate">The EducationClass to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationClass.</returns>
        public async System.Threading.Tasks.Task<EducationClass> UpdateAsync(EducationClass educationClassToUpdate, CancellationToken cancellationToken)
        {
			if (educationClassToUpdate.AdditionalData != null)
			{
				if (educationClassToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					educationClassToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationClassToUpdate.GetType().Name)
						});
				}
			}
            if (educationClassToUpdate.AdditionalData != null)
            {
                if (educationClassToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    educationClassToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationClassToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<EducationClass>(educationClassToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified EducationClass using PATCH and returns a <see cref="GraphResponse{EducationClass}"/> object.
        /// </summary>
        /// <param name="educationClassToUpdate">The EducationClass to update.</param>
        /// <returns>The <see cref="GraphResponse{EducationClass}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationClass>> UpdateResponseAsync(EducationClass educationClassToUpdate)
        {
            return this.UpdateResponseAsync(educationClassToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EducationClass using PATCH and returns a <see cref="GraphResponse{EducationClass}"/> object.
        /// </summary>
        /// <param name="educationClassToUpdate">The EducationClass to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationClass}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EducationClass>> UpdateResponseAsync(EducationClass educationClassToUpdate, CancellationToken cancellationToken)
        {
			if (educationClassToUpdate.AdditionalData != null)
			{
				if (educationClassToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					educationClassToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationClassToUpdate.GetType().Name)
						});
				}
			}
            if (educationClassToUpdate.AdditionalData != null)
            {
                if (educationClassToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    educationClassToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationClassToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<EducationClass>(educationClassToUpdate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified EducationClass.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EducationClass.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<EducationClass>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified EducationClass and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EducationClass and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationClassWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationClassWithReferenceRequest Expand(Expression<Func<EducationClass, object>> expandExpression)
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
        public IEducationClassWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationClassWithReferenceRequest Select(Expression<Func<EducationClass, object>> selectExpression)
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

    }
}
