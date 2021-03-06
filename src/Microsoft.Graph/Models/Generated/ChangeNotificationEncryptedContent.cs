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
    /// The type ChangeNotificationEncryptedContent.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ChangeNotificationEncryptedContent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeNotificationEncryptedContent"/> class.
        /// </summary>
        public ChangeNotificationEncryptedContent()
        {
            this.ODataType = "microsoft.graph.changeNotificationEncryptedContent";
        }

        /// <summary>
        /// Gets or sets data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "data", Required = Newtonsoft.Json.Required.Default)]
        public string Data { get; set; }
    
        /// <summary>
        /// Gets or sets dataSignature.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dataSignature", Required = Newtonsoft.Json.Required.Default)]
        public string DataSignature { get; set; }
    
        /// <summary>
        /// Gets or sets dataKey.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dataKey", Required = Newtonsoft.Json.Required.Default)]
        public string DataKey { get; set; }
    
        /// <summary>
        /// Gets or sets encryptionCertificateId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encryptionCertificateId", Required = Newtonsoft.Json.Required.Default)]
        public string EncryptionCertificateId { get; set; }
    
        /// <summary>
        /// Gets or sets encryptionCertificateThumbprint.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encryptionCertificateThumbprint", Required = Newtonsoft.Json.Required.Default)]
        public string EncryptionCertificateThumbprint { get; set; }
    
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
