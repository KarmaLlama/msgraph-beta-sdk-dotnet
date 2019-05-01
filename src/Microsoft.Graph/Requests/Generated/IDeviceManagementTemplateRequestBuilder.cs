// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IDeviceManagementTemplateRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementTemplateRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDeviceManagementTemplateRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDeviceManagementTemplateRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Settings.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementTemplateSettingsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementTemplateSettingsCollectionRequestBuilder Settings { get; }

        /// <summary>
        /// Gets the request builder for Categories.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementTemplateCategoriesCollectionRequestBuilder"/>.</returns>
        IDeviceManagementTemplateCategoriesCollectionRequestBuilder Categories { get; }
    
        /// <summary>
        /// Gets the request builder for DeviceManagementTemplateCreateInstance.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementTemplateCreateInstanceRequestBuilder"/>.</returns>
        IDeviceManagementTemplateCreateInstanceRequestBuilder CreateInstance(
            string displayName = null,
            string description = null,
            IEnumerable<DeviceManagementSettingInstance> settingsDelta = null);
    
    }
}
