// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20230131
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.Extensions;

    /// <summary>Describes a federated identity credential.</summary>
    public partial class FederatedIdentityCredential :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20230131.IFederatedIdentityCredential,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20230131.IFederatedIdentityCredentialInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.Resource();

        /// <summary>The list of audiences that can appear in the issued token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.FormatTable(Index = 3)]
        public string[] Audience { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialPropertiesInternal)Property).Audience; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialPropertiesInternal)Property).Audience = value ?? null /* arrayOf */; }

        /// <summary>
        /// Fully qualified resource ID for the resource. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).Id; }

        /// <summary>The URL of the issuer to be trusted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.FormatTable(Index = 1)]
        public string Issuer { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialPropertiesInternal)Property).Issuer; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialPropertiesInternal)Property).Issuer = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialProperties Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20230131.IFederatedIdentityCredentialInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.FederatedIdentityCredentialProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.ISystemData Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialProperties _property;

        /// <summary>The properties associated with the federated identity credential.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.FederatedIdentityCredentialProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.DoNotFormat]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The identifier of the external identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.FormatTable(Index = 2)]
        public string Subject { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialPropertiesInternal)Property).Subject; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialPropertiesInternal)Property).Subject = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="FederatedIdentityCredential" /> instance.</summary>
        public FederatedIdentityCredential()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Describes a federated identity credential.
    public partial interface IFederatedIdentityCredential :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResource
    {
        /// <summary>The list of audiences that can appear in the issued token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of audiences that can appear in the issued token.",
        SerializedName = @"audiences",
        PossibleTypes = new [] { typeof(string) })]
        string[] Audience { get; set; }
        /// <summary>The URL of the issuer to be trusted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL of the issuer to be trusted.",
        SerializedName = @"issuer",
        PossibleTypes = new [] { typeof(string) })]
        string Issuer { get; set; }
        /// <summary>The identifier of the external identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identifier of the external identity.",
        SerializedName = @"subject",
        PossibleTypes = new [] { typeof(string) })]
        string Subject { get; set; }

    }
    /// Describes a federated identity credential.
    internal partial interface IFederatedIdentityCredentialInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api40.IResourceInternal
    {
        /// <summary>The list of audiences that can appear in the issued token.</summary>
        string[] Audience { get; set; }
        /// <summary>The URL of the issuer to be trusted.</summary>
        string Issuer { get; set; }
        /// <summary>The properties associated with the federated identity credential.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServiceIdentity.Models.Api20220131Preview.IFederatedIdentityCredentialProperties Property { get; set; }
        /// <summary>The identifier of the external identity.</summary>
        string Subject { get; set; }

    }
}