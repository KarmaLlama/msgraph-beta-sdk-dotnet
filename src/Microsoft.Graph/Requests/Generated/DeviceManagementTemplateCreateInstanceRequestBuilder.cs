// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DeviceManagementTemplateCreateInstanceRequestBuilder.
    /// </summary>
    public partial class DeviceManagementTemplateCreateInstanceRequestBuilder : BaseActionMethodRequestBuilder<IDeviceManagementTemplateCreateInstanceRequest>, IDeviceManagementTemplateCreateInstanceRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="DeviceManagementTemplateCreateInstanceRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="displayName">A displayName parameter for the OData method call.</param>
        /// <param name="description">A description parameter for the OData method call.</param>
        /// <param name="settingsDelta">A settingsDelta parameter for the OData method call.</param>
        public DeviceManagementTemplateCreateInstanceRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string displayName,
            string description,
            IEnumerable<DeviceManagementSettingInstance> settingsDelta)
            : base(requestUrl, client)
        {
            this.SetParameter("displayName", displayName, true);
            this.SetParameter("description", description, true);
            this.SetParameter("settingsDelta", settingsDelta, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IDeviceManagementTemplateCreateInstanceRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new DeviceManagementTemplateCreateInstanceRequest(functionUrl, this.Client, options);

            if (this.HasParameter("displayName"))
            {
                request.RequestBody.DisplayName = this.GetParameter<string>("displayName");
            }

            if (this.HasParameter("description"))
            {
                request.RequestBody.Description = this.GetParameter<string>("description");
            }

            if (this.HasParameter("settingsDelta"))
            {
                request.RequestBody.SettingsDelta = this.GetParameter<IEnumerable<DeviceManagementSettingInstance>>("settingsDelta");
            }

            return request;
        }
    }
}
