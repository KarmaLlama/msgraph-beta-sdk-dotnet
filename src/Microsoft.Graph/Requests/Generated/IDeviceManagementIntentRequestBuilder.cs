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
    /// The interface IDeviceManagementIntentRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementIntentRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDeviceManagementIntentRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDeviceManagementIntentRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Settings.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementIntentSettingsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementIntentSettingsCollectionRequestBuilder Settings { get; }

        /// <summary>
        /// Gets the request builder for Categories.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementIntentCategoriesCollectionRequestBuilder"/>.</returns>
        IDeviceManagementIntentCategoriesCollectionRequestBuilder Categories { get; }

        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementIntentAssignmentsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementIntentAssignmentsCollectionRequestBuilder Assignments { get; }

        /// <summary>
        /// Gets the request builder for DeviceSettingStateSummaries.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementIntentDeviceSettingStateSummariesCollectionRequestBuilder"/>.</returns>
        IDeviceManagementIntentDeviceSettingStateSummariesCollectionRequestBuilder DeviceSettingStateSummaries { get; }

        /// <summary>
        /// Gets the request builder for DeviceStates.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementIntentDeviceStatesCollectionRequestBuilder"/>.</returns>
        IDeviceManagementIntentDeviceStatesCollectionRequestBuilder DeviceStates { get; }

        /// <summary>
        /// Gets the request builder for UserStates.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementIntentUserStatesCollectionRequestBuilder"/>.</returns>
        IDeviceManagementIntentUserStatesCollectionRequestBuilder UserStates { get; }

        /// <summary>
        /// Gets the request builder for DeviceStateSummary.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementIntentDeviceStateSummaryRequestBuilder"/>.</returns>
        IDeviceManagementIntentDeviceStateSummaryRequestBuilder DeviceStateSummary { get; }

        /// <summary>
        /// Gets the request builder for UserStateSummary.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementIntentUserStateSummaryRequestBuilder"/>.</returns>
        IDeviceManagementIntentUserStateSummaryRequestBuilder UserStateSummary { get; }
    
        /// <summary>
        /// Gets the request builder for DeviceManagementIntentUpdateSettings.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementIntentUpdateSettingsRequestBuilder"/>.</returns>
        IDeviceManagementIntentUpdateSettingsRequestBuilder UpdateSettings(
            IEnumerable<DeviceManagementSettingInstance> settings = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementIntentAssign.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementIntentAssignRequestBuilder"/>.</returns>
        IDeviceManagementIntentAssignRequestBuilder Assign(
            IEnumerable<DeviceManagementIntentAssignment> assignments = null);
    
    }
}
