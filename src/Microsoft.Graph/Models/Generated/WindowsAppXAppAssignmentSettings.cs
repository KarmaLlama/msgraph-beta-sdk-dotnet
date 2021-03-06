// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type WindowsAppXAppAssignmentSettings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsAppXAppAssignmentSettings : MobileAppAssignmentSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsAppXAppAssignmentSettings"/> class.
        /// </summary>
        public WindowsAppXAppAssignmentSettings()
        {
            this.ODataType = "microsoft.graph.windowsAppXAppAssignmentSettings";
        }

        /// <summary>
        /// Gets or sets useDeviceContext.
        /// Whether or not to use device execution context for Windows AppX mobile app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "useDeviceContext", Required = Newtonsoft.Json.Required.Default)]
        public bool? UseDeviceContext { get; set; }
    
    }
}
