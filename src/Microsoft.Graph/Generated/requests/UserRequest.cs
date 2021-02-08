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
    /// The type UserRequest.
    /// </summary>
    public partial class UserRequest : BaseRequest, IUserRequest
    {
        /// <summary>
        /// Constructs a new UserRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UserRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified User using POST.
        /// </summary>
        /// <param name="userToCreate">The User to create.</param>
        /// <returns>The created User.</returns>
        public System.Threading.Tasks.Task<User> CreateAsync(User userToCreate)
        {
            return this.CreateAsync(userToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified User using POST.
        /// </summary>
        /// <param name="userToCreate">The User to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created User.</returns>
        public async System.Threading.Tasks.Task<User> CreateAsync(User userToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<User>(userToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified User using POST and returns a <see cref="GraphResponse{User}"/> object.
        /// </summary>
        /// <param name="userToCreate">The User to create.</param>
        /// <returns>The <see cref="GraphResponse{User}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<User>> CreateResponseAsync(User userToCreate)
        {
            return this.CreateResponseAsync(userToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified User using POST and returns a <see cref="GraphResponse{User}"/> object.
        /// </summary>
        /// <param name="userToCreate">The User to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{User}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<User>> CreateResponseAsync(User userToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<User>(userToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified User.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified User.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<User>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified User and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified User and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified User.
        /// </summary>
        /// <returns>The User.</returns>
        public System.Threading.Tasks.Task<User> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified User.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The User.</returns>
        public async System.Threading.Tasks.Task<User> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<User>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified User using PATCH.
        /// </summary>
        /// <param name="userToUpdate">The User to update.</param>
        /// <returns>The updated User.</returns>
        public System.Threading.Tasks.Task<User> UpdateAsync(User userToUpdate)
        {
            return this.UpdateAsync(userToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified User using PATCH.
        /// </summary>
        /// <param name="userToUpdate">The User to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated User.</returns>
        public async System.Threading.Tasks.Task<User> UpdateAsync(User userToUpdate, CancellationToken cancellationToken)
        {
			if (userToUpdate.AdditionalData != null)
			{
				if (userToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					userToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, userToUpdate.GetType().Name)
						});
				}
			}
            if (userToUpdate.AdditionalData != null)
            {
                if (userToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    userToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, userToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<User>(userToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified User using PATCH and returns a <see cref="GraphResponse{User}"/> object.
        /// </summary>
        /// <param name="userToUpdate">The User to update.</param>
        /// <returns>The <see cref="GraphResponse{User}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<User>> UpdateResponseAsync(User userToUpdate)
        {
            return this.UpdateResponseAsync(userToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified User using PATCH and returns a <see cref="GraphResponse{User}"/> object.
        /// </summary>
        /// <param name="userToUpdate">The User to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{User}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<User>> UpdateResponseAsync(User userToUpdate, CancellationToken cancellationToken)
        {
			if (userToUpdate.AdditionalData != null)
			{
				if (userToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					userToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, userToUpdate.GetType().Name)
						});
				}
			}
            if (userToUpdate.AdditionalData != null)
            {
                if (userToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    userToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, userToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<User>(userToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserRequest Expand(Expression<Func<User, object>> expandExpression)
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
        public IUserRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserRequest Select(Expression<Func<User, object>> selectExpression)
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
        /// <param name="userToInitialize">The <see cref="User"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(User userToInitialize)
        {

            if (userToInitialize != null && userToInitialize.AdditionalData != null)
            {

                if (userToInitialize.AppRoleAssignments != null && userToInitialize.AppRoleAssignments.CurrentPage != null)
                {
                    userToInitialize.AppRoleAssignments.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("appRoleAssignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.AppRoleAssignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.CreatedObjects != null && userToInitialize.CreatedObjects.CurrentPage != null)
                {
                    userToInitialize.CreatedObjects.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("createdObjects@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.CreatedObjects.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.DirectReports != null && userToInitialize.DirectReports.CurrentPage != null)
                {
                    userToInitialize.DirectReports.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("directReports@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.DirectReports.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.LicenseDetails != null && userToInitialize.LicenseDetails.CurrentPage != null)
                {
                    userToInitialize.LicenseDetails.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("licenseDetails@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.LicenseDetails.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.MemberOf != null && userToInitialize.MemberOf.CurrentPage != null)
                {
                    userToInitialize.MemberOf.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("memberOf@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.MemberOf.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.Oauth2PermissionGrants != null && userToInitialize.Oauth2PermissionGrants.CurrentPage != null)
                {
                    userToInitialize.Oauth2PermissionGrants.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("oauth2PermissionGrants@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.Oauth2PermissionGrants.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.OwnedDevices != null && userToInitialize.OwnedDevices.CurrentPage != null)
                {
                    userToInitialize.OwnedDevices.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("ownedDevices@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.OwnedDevices.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.OwnedObjects != null && userToInitialize.OwnedObjects.CurrentPage != null)
                {
                    userToInitialize.OwnedObjects.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("ownedObjects@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.OwnedObjects.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.RegisteredDevices != null && userToInitialize.RegisteredDevices.CurrentPage != null)
                {
                    userToInitialize.RegisteredDevices.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("registeredDevices@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.RegisteredDevices.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.ScopedRoleMemberOf != null && userToInitialize.ScopedRoleMemberOf.CurrentPage != null)
                {
                    userToInitialize.ScopedRoleMemberOf.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("scopedRoleMemberOf@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.ScopedRoleMemberOf.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.TransitiveMemberOf != null && userToInitialize.TransitiveMemberOf.CurrentPage != null)
                {
                    userToInitialize.TransitiveMemberOf.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("transitiveMemberOf@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.TransitiveMemberOf.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.CalendarGroups != null && userToInitialize.CalendarGroups.CurrentPage != null)
                {
                    userToInitialize.CalendarGroups.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("calendarGroups@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.CalendarGroups.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.Calendars != null && userToInitialize.Calendars.CurrentPage != null)
                {
                    userToInitialize.Calendars.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("calendars@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.Calendars.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.CalendarView != null && userToInitialize.CalendarView.CurrentPage != null)
                {
                    userToInitialize.CalendarView.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("calendarView@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.CalendarView.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.ContactFolders != null && userToInitialize.ContactFolders.CurrentPage != null)
                {
                    userToInitialize.ContactFolders.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("contactFolders@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.ContactFolders.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.Contacts != null && userToInitialize.Contacts.CurrentPage != null)
                {
                    userToInitialize.Contacts.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("contacts@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.Contacts.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.Events != null && userToInitialize.Events.CurrentPage != null)
                {
                    userToInitialize.Events.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("events@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.Events.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.MailFolders != null && userToInitialize.MailFolders.CurrentPage != null)
                {
                    userToInitialize.MailFolders.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("mailFolders@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.MailFolders.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.Messages != null && userToInitialize.Messages.CurrentPage != null)
                {
                    userToInitialize.Messages.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("messages@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.Messages.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.People != null && userToInitialize.People.CurrentPage != null)
                {
                    userToInitialize.People.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("people@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.People.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.Photos != null && userToInitialize.Photos.CurrentPage != null)
                {
                    userToInitialize.Photos.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("photos@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.Photos.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.Drives != null && userToInitialize.Drives.CurrentPage != null)
                {
                    userToInitialize.Drives.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("drives@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.Drives.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.FollowedSites != null && userToInitialize.FollowedSites.CurrentPage != null)
                {
                    userToInitialize.FollowedSites.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("followedSites@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.FollowedSites.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.Extensions != null && userToInitialize.Extensions.CurrentPage != null)
                {
                    userToInitialize.Extensions.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("extensions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.Extensions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.ManagedDevices != null && userToInitialize.ManagedDevices.CurrentPage != null)
                {
                    userToInitialize.ManagedDevices.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("managedDevices@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.ManagedDevices.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.ManagedAppRegistrations != null && userToInitialize.ManagedAppRegistrations.CurrentPage != null)
                {
                    userToInitialize.ManagedAppRegistrations.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("managedAppRegistrations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.ManagedAppRegistrations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.DeviceManagementTroubleshootingEvents != null && userToInitialize.DeviceManagementTroubleshootingEvents.CurrentPage != null)
                {
                    userToInitialize.DeviceManagementTroubleshootingEvents.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("deviceManagementTroubleshootingEvents@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.DeviceManagementTroubleshootingEvents.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.Activities != null && userToInitialize.Activities.CurrentPage != null)
                {
                    userToInitialize.Activities.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("activities@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.Activities.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.OnlineMeetings != null && userToInitialize.OnlineMeetings.CurrentPage != null)
                {
                    userToInitialize.OnlineMeetings.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("onlineMeetings@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.OnlineMeetings.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (userToInitialize.JoinedTeams != null && userToInitialize.JoinedTeams.CurrentPage != null)
                {
                    userToInitialize.JoinedTeams.AdditionalData = userToInitialize.AdditionalData;

                    object nextPageLink;
                    userToInitialize.AdditionalData.TryGetValue("joinedTeams@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        userToInitialize.JoinedTeams.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
