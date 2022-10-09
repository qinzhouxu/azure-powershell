// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Query parameter to get appliance.</summary>
    public partial class ApplianceQueryParameter :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IApplianceQueryParameter,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IApplianceQueryParameterInternal
    {

        /// <summary>Backing field for <see cref="ProviderType" /> property.</summary>
        private string _providerType;

        /// <summary>The providerType to be used for fetching appliance details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ProviderType { get => this._providerType; set => this._providerType = value; }

        /// <summary>Creates an new <see cref="ApplianceQueryParameter" /> instance.</summary>
        public ApplianceQueryParameter()
        {

        }
    }
    /// Query parameter to get appliance.
    public partial interface IApplianceQueryParameter :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The providerType to be used for fetching appliance details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The providerType to be used for fetching appliance details.",
        SerializedName = @"providerType",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderType { get; set; }

    }
    /// Query parameter to get appliance.
    internal partial interface IApplianceQueryParameterInternal

    {
        /// <summary>The providerType to be used for fetching appliance details.</summary>
        string ProviderType { get; set; }

    }
}