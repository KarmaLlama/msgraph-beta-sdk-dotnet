// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Windows10Compliance Policy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Windows10CompliancePolicy : DeviceCompliancePolicy
    {
    
        /// <summary>
        /// Gets or sets password required.
        /// Require a password to unlock Windows device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordRequired { get; set; }
    
        /// <summary>
        /// Gets or sets password block simple.
        /// Indicates whether or not to block simple password.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockSimple", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockSimple { get; set; }
    
        /// <summary>
        /// Gets or sets password required to unlock from idle.
        /// Require a password to unlock an idle device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequiredToUnlockFromIdle", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordRequiredToUnlockFromIdle { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before lock.
        /// Minutes of inactivity before a password is required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeLock", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinutesOfInactivityBeforeLock { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// The password expiration in days.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// The minimum password length.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum character set count.
        /// The number of character sets required in the password.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumCharacterSetCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumCharacterSetCount { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// The required password type. Possible values are: deviceDefault, alphanumeric, numeric.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequiredType", Required = Newtonsoft.Json.Required.Default)]
        public RequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// The number of previous passwords to prevent re-use of.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPreviousPasswordBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets require healthy device report.
        /// Require devices to be reported as healthy by Windows Device Health Attestation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requireHealthyDeviceReport", Required = Newtonsoft.Json.Required.Default)]
        public bool? RequireHealthyDeviceReport { get; set; }
    
        /// <summary>
        /// Gets or sets os minimum version.
        /// Minimum Windows 10 version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osMinimumVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsMinimumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets os maximum version.
        /// Maximum Windows 10 version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osMaximumVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsMaximumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets mobile os minimum version.
        /// Minimum Windows Phone version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobileOsMinimumVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MobileOsMinimumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets mobile os maximum version.
        /// Maximum Windows Phone version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobileOsMaximumVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MobileOsMaximumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets early launch anti malware driver enabled.
        /// Require devices to be reported as healthy by Windows Device Health Attestation - early launch antimalware driver is enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "earlyLaunchAntiMalwareDriverEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? EarlyLaunchAntiMalwareDriverEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets bit locker enabled.
        /// Require devices to be reported healthy by Windows Device Health Attestation - bit locker is enabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bitLockerEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? BitLockerEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets secure boot enabled.
        /// Require devices to be reported as healthy by Windows Device Health Attestation - secure boot is enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "secureBootEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecureBootEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets code integrity enabled.
        /// Require devices to be reported as healthy by Windows Device Health Attestation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "codeIntegrityEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? CodeIntegrityEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets storage require encryption.
        /// Require encryption on windows devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageRequireEncryption", Required = Newtonsoft.Json.Required.Default)]
        public bool? StorageRequireEncryption { get; set; }
    
        /// <summary>
        /// Gets or sets active firewall required.
        /// Require active firewall on Windows devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activeFirewallRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? ActiveFirewallRequired { get; set; }
    
        /// <summary>
        /// Gets or sets defender enabled.
        /// Require Windows Defender Antimalware on Windows devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defenderEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? DefenderEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets defender version.
        /// Require Windows Defender Antimalware minimum version on Windows devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defenderVersion", Required = Newtonsoft.Json.Required.Default)]
        public string DefenderVersion { get; set; }
    
        /// <summary>
        /// Gets or sets signature out of date.
        /// Require Windows Defender Antimalware Signature to be up to date on Windows devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "signatureOutOfDate", Required = Newtonsoft.Json.Required.Default)]
        public bool? SignatureOutOfDate { get; set; }
    
        /// <summary>
        /// Gets or sets rtp enabled.
        /// Require Windows Defender Antimalware Real-Time Protection on Windows devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rtpEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? RtpEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets antivirus required.
        /// Require any Antivirus solution registered with Windows Decurity Center to be on and monitoring (e.g. Symantec, Windows Defender).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "antivirusRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? AntivirusRequired { get; set; }
    
        /// <summary>
        /// Gets or sets anti spyware required.
        /// Require any AntiSpyware solution registered with Windows Decurity Center to be on and monitoring (e.g. Symantec, Windows Defender).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "antiSpywareRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? AntiSpywareRequired { get; set; }
    
        /// <summary>
        /// Gets or sets valid operating system build ranges.
        /// The valid operating system build ranges on Windows devices. This collection can contain a maximum of 10000 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "validOperatingSystemBuildRanges", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<OperatingSystemVersionRange> ValidOperatingSystemBuildRanges { get; set; }
    
        /// <summary>
        /// Gets or sets device threat protection enabled.
        /// Require that devices have enabled device threat protection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceThreatProtectionEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? DeviceThreatProtectionEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets device threat protection required security level.
        /// Require Device Threat Protection minimum risk level to report noncompliance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceThreatProtectionRequiredSecurityLevel", Required = Newtonsoft.Json.Required.Default)]
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets configuration manager compliance required.
        /// Require to consider SCCM Compliance state into consideration for Intune Compliance State.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "configurationManagerComplianceRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? ConfigurationManagerComplianceRequired { get; set; }
    
    }
}

