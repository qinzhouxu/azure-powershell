// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Extensions;

    /// <summary>Site properties.</summary>
    public partial class SitePropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISitePropertiesFormat,
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISitePropertiesFormatInternal
    {

        /// <summary>Internal Acessors for NetworkFunction</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISubResource[] Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISitePropertiesFormatInternal.NetworkFunction { get => this._networkFunction; set { {_networkFunction = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISitePropertiesFormatInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="NetworkFunction" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISubResource[] _networkFunction;

        /// <summary>
        /// An array of IDs of the network functions deployed in the site. Deleting the site will delete any network functions that
        /// are deployed in the site.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISubResource[] NetworkFunction { get => this._networkFunction; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the site resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="SitePropertiesFormat" /> instance.</summary>
        public SitePropertiesFormat()
        {

        }
    }
    /// Site properties.
    public partial interface ISitePropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IJsonSerializable
    {
        /// <summary>
        /// An array of IDs of the network functions deployed in the site. Deleting the site will delete any network functions that
        /// are deployed in the site.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"An array of IDs of the network functions deployed in the site. Deleting the site will delete any network functions that are deployed in the site.",
        SerializedName = @"networkFunctions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISubResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISubResource[] NetworkFunction { get;  }
        /// <summary>The provisioning state of the site resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the site resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// Site properties.
    internal partial interface ISitePropertiesFormatInternal

    {
        /// <summary>
        /// An array of IDs of the network functions deployed in the site. Deleting the site will delete any network functions that
        /// are deployed in the site.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISubResource[] NetworkFunction { get; set; }
        /// <summary>The provisioning state of the site resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}