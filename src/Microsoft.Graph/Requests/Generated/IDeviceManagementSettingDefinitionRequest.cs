// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceManagementSettingDefinitionRequest.
    /// </summary>
    public partial interface IDeviceManagementSettingDefinitionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementSettingDefinition using PUT.
        /// </summary>
        /// <param name="deviceManagementSettingDefinitionToCreate">The DeviceManagementSettingDefinition to create.</param>
        /// <returns>The created DeviceManagementSettingDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementSettingDefinition> CreateAsync(DeviceManagementSettingDefinition deviceManagementSettingDefinitionToCreate);        /// <summary>
        /// Creates the specified DeviceManagementSettingDefinition using PUT.
        /// </summary>
        /// <param name="deviceManagementSettingDefinitionToCreate">The DeviceManagementSettingDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementSettingDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementSettingDefinition> CreateAsync(DeviceManagementSettingDefinition deviceManagementSettingDefinitionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementSettingDefinition.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementSettingDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementSettingDefinition.
        /// </summary>
        /// <returns>The DeviceManagementSettingDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementSettingDefinition> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementSettingDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementSettingDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementSettingDefinition> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementSettingDefinition using PATCH.
        /// </summary>
        /// <param name="deviceManagementSettingDefinitionToUpdate">The DeviceManagementSettingDefinition to update.</param>
        /// <returns>The updated DeviceManagementSettingDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementSettingDefinition> UpdateAsync(DeviceManagementSettingDefinition deviceManagementSettingDefinitionToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementSettingDefinition using PATCH.
        /// </summary>
        /// <param name="deviceManagementSettingDefinitionToUpdate">The DeviceManagementSettingDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DeviceManagementSettingDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementSettingDefinition> UpdateAsync(DeviceManagementSettingDefinition deviceManagementSettingDefinitionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementSettingDefinitionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementSettingDefinitionRequest Expand(Expression<Func<DeviceManagementSettingDefinition, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementSettingDefinitionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementSettingDefinitionRequest Select(Expression<Func<DeviceManagementSettingDefinition, object>> selectExpression);

    }
}
