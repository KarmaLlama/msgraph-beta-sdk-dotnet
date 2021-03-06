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
    /// The interface IDeviceManagementExchangeOnPremisesPolicyRequest.
    /// </summary>
    public partial interface IDeviceManagementExchangeOnPremisesPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementExchangeOnPremisesPolicy using POST.
        /// </summary>
        /// <param name="deviceManagementExchangeOnPremisesPolicyToCreate">The DeviceManagementExchangeOnPremisesPolicy to create.</param>
        /// <returns>The created DeviceManagementExchangeOnPremisesPolicy.</returns>
        System.Threading.Tasks.Task<DeviceManagementExchangeOnPremisesPolicy> CreateAsync(DeviceManagementExchangeOnPremisesPolicy deviceManagementExchangeOnPremisesPolicyToCreate);        /// <summary>
        /// Creates the specified DeviceManagementExchangeOnPremisesPolicy using POST.
        /// </summary>
        /// <param name="deviceManagementExchangeOnPremisesPolicyToCreate">The DeviceManagementExchangeOnPremisesPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementExchangeOnPremisesPolicy.</returns>
        System.Threading.Tasks.Task<DeviceManagementExchangeOnPremisesPolicy> CreateAsync(DeviceManagementExchangeOnPremisesPolicy deviceManagementExchangeOnPremisesPolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementExchangeOnPremisesPolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementExchangeOnPremisesPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementExchangeOnPremisesPolicy.
        /// </summary>
        /// <returns>The DeviceManagementExchangeOnPremisesPolicy.</returns>
        System.Threading.Tasks.Task<DeviceManagementExchangeOnPremisesPolicy> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementExchangeOnPremisesPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementExchangeOnPremisesPolicy.</returns>
        System.Threading.Tasks.Task<DeviceManagementExchangeOnPremisesPolicy> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementExchangeOnPremisesPolicy using PATCH.
        /// </summary>
        /// <param name="deviceManagementExchangeOnPremisesPolicyToUpdate">The DeviceManagementExchangeOnPremisesPolicy to update.</param>
        /// <returns>The updated DeviceManagementExchangeOnPremisesPolicy.</returns>
        System.Threading.Tasks.Task<DeviceManagementExchangeOnPremisesPolicy> UpdateAsync(DeviceManagementExchangeOnPremisesPolicy deviceManagementExchangeOnPremisesPolicyToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementExchangeOnPremisesPolicy using PATCH.
        /// </summary>
        /// <param name="deviceManagementExchangeOnPremisesPolicyToUpdate">The DeviceManagementExchangeOnPremisesPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementExchangeOnPremisesPolicy.</returns>
        System.Threading.Tasks.Task<DeviceManagementExchangeOnPremisesPolicy> UpdateAsync(DeviceManagementExchangeOnPremisesPolicy deviceManagementExchangeOnPremisesPolicyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementExchangeOnPremisesPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementExchangeOnPremisesPolicyRequest Expand(Expression<Func<DeviceManagementExchangeOnPremisesPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementExchangeOnPremisesPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementExchangeOnPremisesPolicyRequest Select(Expression<Func<DeviceManagementExchangeOnPremisesPolicy, object>> selectExpression);

    }
}
