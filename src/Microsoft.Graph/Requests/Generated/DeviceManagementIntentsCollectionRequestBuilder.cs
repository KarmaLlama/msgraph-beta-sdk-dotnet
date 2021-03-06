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
    /// The type DeviceManagementIntentsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementIntentsCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementIntentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementIntentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementIntentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementIntentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementIntentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementIntentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceManagementIntentRequestBuilder"/> for the specified DeviceManagementDeviceManagementIntent.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementDeviceManagementIntent.</param>
        /// <returns>The <see cref="IDeviceManagementIntentRequestBuilder"/>.</returns>
        public IDeviceManagementIntentRequestBuilder this[string id]
        {
            get
            {
                return new DeviceManagementIntentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
