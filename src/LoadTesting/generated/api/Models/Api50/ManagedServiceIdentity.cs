// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api50
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Extensions;

    /// <summary>Managed service identity (system assigned and/or user assigned identities)</summary>
    public partial class ManagedServiceIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api50.IManagedServiceIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api50.IManagedServiceIdentityInternal
    {

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api50.IManagedServiceIdentityInternal.PrincipalId { get => this._principalId; set { {_principalId = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api50.IManagedServiceIdentityInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.ManagedServiceIdentityType _type;

        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.ManagedServiceIdentityType Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="UserAssignedIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api50.IUserAssignedIdentities _userAssignedIdentity;

        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Origin(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api50.IUserAssignedIdentities UserAssignedIdentity { get => (this._userAssignedIdentity = this._userAssignedIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api50.UserAssignedIdentities()); set => this._userAssignedIdentity = value; }

        /// <summary>Creates an new <see cref="ManagedServiceIdentity" /> instance.</summary>
        public ManagedServiceIdentity()
        {

        }
    }
    /// Managed service identity (system assigned and/or user assigned identities)
    public partial interface IManagedServiceIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }
        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.ManagedServiceIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.ManagedServiceIdentityType Type { get; set; }
        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api50.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api50.IUserAssignedIdentities UserAssignedIdentity { get; set; }

    }
    /// Managed service identity (system assigned and/or user assigned identities)
    internal partial interface IManagedServiceIdentityInternal

    {
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string PrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string TenantId { get; set; }
        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Support.ManagedServiceIdentityType Type { get; set; }
        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.LoadTesting.Models.Api50.IUserAssignedIdentities UserAssignedIdentity { get; set; }

    }
}