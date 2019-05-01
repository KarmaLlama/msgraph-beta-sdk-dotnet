// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ChatMessageHostedImagesCollectionRequestBuilder.
    /// </summary>
    public partial class ChatMessageHostedImagesCollectionRequestBuilder : BaseRequestBuilder, IChatMessageHostedImagesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ChatMessageHostedImagesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ChatMessageHostedImagesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IChatMessageHostedImagesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IChatMessageHostedImagesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ChatMessageHostedImagesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IChatMessageHostedImageRequestBuilder"/> for the specified ChatMessageChatMessageHostedImage.
        /// </summary>
        /// <param name="id">The ID for the ChatMessageChatMessageHostedImage.</param>
        /// <returns>The <see cref="IChatMessageHostedImageRequestBuilder"/>.</returns>
        public IChatMessageHostedImageRequestBuilder this[string id]
        {
            get
            {
                return new ChatMessageHostedImageRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
