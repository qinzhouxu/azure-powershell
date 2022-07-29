// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The URI required to login to the supplemental portal from the Azure portal.</summary>
    public partial class SsoUri :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISsoUri,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISsoUriInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISsoUriInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>The URI used to login to the supplemental portal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string Value { get => this._value; }

        /// <summary>Creates an new <see cref="SsoUri" /> instance.</summary>
        public SsoUri()
        {

        }
    }
    /// The URI required to login to the supplemental portal from the Azure portal.
    public partial interface ISsoUri :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>The URI used to login to the supplemental portal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The URI used to login to the supplemental portal.",
        SerializedName = @"ssoUriValue",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get;  }

    }
    /// The URI required to login to the supplemental portal from the Azure portal.
    internal partial interface ISsoUriInternal

    {
        /// <summary>The URI used to login to the supplemental portal.</summary>
        string Value { get; set; }

    }
}