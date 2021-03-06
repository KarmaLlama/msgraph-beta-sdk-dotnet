// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type CommsApplicationRequest.
    /// </summary>
    public partial class CommsApplicationRequest : BaseRequest, ICommsApplicationRequest
    {
        /// <summary>
        /// Constructs a new CommsApplicationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public CommsApplicationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified CommsApplication using POST.
        /// </summary>
        /// <param name="commsApplicationToCreate">The CommsApplication to create.</param>
        /// <returns>The created CommsApplication.</returns>
        public System.Threading.Tasks.Task<CommsApplication> CreateAsync(CommsApplication commsApplicationToCreate)
        {
            return this.CreateAsync(commsApplicationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified CommsApplication using POST.
        /// </summary>
        /// <param name="commsApplicationToCreate">The CommsApplication to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CommsApplication.</returns>
        public async System.Threading.Tasks.Task<CommsApplication> CreateAsync(CommsApplication commsApplicationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<CommsApplication>(commsApplicationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified CommsApplication.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified CommsApplication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<CommsApplication>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified CommsApplication.
        /// </summary>
        /// <returns>The CommsApplication.</returns>
        public System.Threading.Tasks.Task<CommsApplication> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified CommsApplication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CommsApplication.</returns>
        public async System.Threading.Tasks.Task<CommsApplication> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<CommsApplication>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified CommsApplication using PATCH.
        /// </summary>
        /// <param name="commsApplicationToUpdate">The CommsApplication to update.</param>
        /// <returns>The updated CommsApplication.</returns>
        public System.Threading.Tasks.Task<CommsApplication> UpdateAsync(CommsApplication commsApplicationToUpdate)
        {
            return this.UpdateAsync(commsApplicationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified CommsApplication using PATCH.
        /// </summary>
        /// <param name="commsApplicationToUpdate">The CommsApplication to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CommsApplication.</returns>
        public async System.Threading.Tasks.Task<CommsApplication> UpdateAsync(CommsApplication commsApplicationToUpdate, CancellationToken cancellationToken)
        {
			if (commsApplicationToUpdate.AdditionalData != null)
			{
				if (commsApplicationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					commsApplicationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, commsApplicationToUpdate.GetType().Name)
						});
				}
			}
            if (commsApplicationToUpdate.AdditionalData != null)
            {
                if (commsApplicationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    commsApplicationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, commsApplicationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<CommsApplication>(commsApplicationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICommsApplicationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICommsApplicationRequest Expand(Expression<Func<CommsApplication, object>> expandExpression)
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
        public ICommsApplicationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ICommsApplicationRequest Select(Expression<Func<CommsApplication, object>> selectExpression)
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
        /// <param name="commsApplicationToInitialize">The <see cref="CommsApplication"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(CommsApplication commsApplicationToInitialize)
        {

            if (commsApplicationToInitialize != null && commsApplicationToInitialize.AdditionalData != null)
            {

                if (commsApplicationToInitialize.Calls != null && commsApplicationToInitialize.Calls.CurrentPage != null)
                {
                    commsApplicationToInitialize.Calls.AdditionalData = commsApplicationToInitialize.AdditionalData;

                    object nextPageLink;
                    commsApplicationToInitialize.AdditionalData.TryGetValue("calls@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        commsApplicationToInitialize.Calls.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (commsApplicationToInitialize.OnlineMeetings != null && commsApplicationToInitialize.OnlineMeetings.CurrentPage != null)
                {
                    commsApplicationToInitialize.OnlineMeetings.AdditionalData = commsApplicationToInitialize.AdditionalData;

                    object nextPageLink;
                    commsApplicationToInitialize.AdditionalData.TryGetValue("onlineMeetings@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        commsApplicationToInitialize.OnlineMeetings.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
