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
    /// The type ConditionalAccessSessionControls.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ConditionalAccessSessionControls
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalAccessSessionControls"/> class.
        /// </summary>
        public ConditionalAccessSessionControls()
        {
            this.ODataType = "microsoft.graph.conditionalAccessSessionControls";
        }

        /// <summary>
        /// Gets or sets applicationEnforcedRestrictions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicationEnforcedRestrictions", Required = Newtonsoft.Json.Required.Default)]
        public ApplicationEnforcedRestrictionsSessionControl ApplicationEnforcedRestrictions { get; set; }
    
        /// <summary>
        /// Gets or sets cloudAppSecurity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cloudAppSecurity", Required = Newtonsoft.Json.Required.Default)]
        public CloudAppSecuritySessionControl CloudAppSecurity { get; set; }
    
        /// <summary>
        /// Gets or sets signInFrequency.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "signInFrequency", Required = Newtonsoft.Json.Required.Default)]
        public SignInFrequencySessionControl SignInFrequency { get; set; }
    
        /// <summary>
        /// Gets or sets persistentBrowser.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "persistentBrowser", Required = Newtonsoft.Json.Required.Default)]
        public PersistentBrowserSessionControl PersistentBrowser { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
