// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The json object that contains properties required to update a security policy</summary>
    public partial class SecurityPolicyUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyPropertiesParameters _parameter;

        /// <summary>object which contains security policy parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyPropertiesParameters Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.SecurityPolicyPropertiesParameters()); set => this._parameter = value; }

        /// <summary>Creates an new <see cref="SecurityPolicyUpdateProperties" /> instance.</summary>
        public SecurityPolicyUpdateProperties()
        {

        }
    }
    /// The json object that contains properties required to update a security policy
    public partial interface ISecurityPolicyUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>object which contains security policy parameters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"object which contains security policy parameters",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyPropertiesParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyPropertiesParameters Parameter { get; set; }

    }
    /// The json object that contains properties required to update a security policy
    internal partial interface ISecurityPolicyUpdatePropertiesInternal

    {
        /// <summary>object which contains security policy parameters</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISecurityPolicyPropertiesParameters Parameter { get; set; }

    }
}