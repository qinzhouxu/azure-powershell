// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Extensions;

    /// <summary>Properties of the managed cluster.</summary>
    public partial class ManagedClusterProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject json ? new ManagedClusterProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject into a new instance of <see cref="ManagedClusterProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ManagedClusterProperties(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_powerState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("powerState"), out var __jsonPowerState) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.PowerState.FromJson(__jsonPowerState) : PowerState;}
            {_linuxProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("linuxProfile"), out var __jsonLinuxProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ContainerServiceLinuxProfile.FromJson(__jsonLinuxProfile) : LinuxProfile;}
            {_windowsProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("windowsProfile"), out var __jsonWindowsProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterWindowsProfile.FromJson(__jsonWindowsProfile) : WindowsProfile;}
            {_servicePrincipalProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("servicePrincipalProfile"), out var __jsonServicePrincipalProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterServicePrincipalProfile.FromJson(__jsonServicePrincipalProfile) : ServicePrincipalProfile;}
            {_podIdentityProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("podIdentityProfile"), out var __jsonPodIdentityProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPodIdentityProfile.FromJson(__jsonPodIdentityProfile) : PodIdentityProfile;}
            {_oidcIssuerProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("oidcIssuerProfile"), out var __jsonOidcIssuerProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterOidcIssuerProfile.FromJson(__jsonOidcIssuerProfile) : OidcIssuerProfile;}
            {_aadProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("aadProfile"), out var __jsonAadProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterAadProfile.FromJson(__jsonAadProfile) : AadProfile;}
            {_autoUpgradeProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("autoUpgradeProfile"), out var __jsonAutoUpgradeProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterAutoUpgradeProfile.FromJson(__jsonAutoUpgradeProfile) : AutoUpgradeProfile;}
            {_autoScalerProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("autoScalerProfile"), out var __jsonAutoScalerProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPropertiesAutoScalerProfile.FromJson(__jsonAutoScalerProfile) : AutoScalerProfile;}
            {_apiServerAccessProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("apiServerAccessProfile"), out var __jsonApiServerAccessProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterApiServerAccessProfile.FromJson(__jsonApiServerAccessProfile) : ApiServerAccessProfile;}
            {_httpProxyConfig = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("httpProxyConfig"), out var __jsonHttpProxyConfig) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterHttpProxyConfig.FromJson(__jsonHttpProxyConfig) : HttpProxyConfig;}
            {_securityProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("securityProfile"), out var __jsonSecurityProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterSecurityProfile.FromJson(__jsonSecurityProfile) : SecurityProfile;}
            {_storageProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("storageProfile"), out var __jsonStorageProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterStorageProfile.FromJson(__jsonStorageProfile) : StorageProfile;}
            {_workloadAutoScalerProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("workloadAutoScalerProfile"), out var __jsonWorkloadAutoScalerProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterWorkloadAutoScalerProfile.FromJson(__jsonWorkloadAutoScalerProfile) : WorkloadAutoScalerProfile;}
            {_azureMonitorProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("azureMonitorProfile"), out var __jsonAzureMonitorProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterAzureMonitorProfile.FromJson(__jsonAzureMonitorProfile) : AzureMonitorProfile;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_maxAgentPool = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber>("maxAgentPools"), out var __jsonMaxAgentPools) ? (int?)__jsonMaxAgentPools : MaxAgentPool;}
            {_kubernetesVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("kubernetesVersion"), out var __jsonKubernetesVersion) ? (string)__jsonKubernetesVersion : (string)KubernetesVersion;}
            {_currentKubernetesVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("currentKubernetesVersion"), out var __jsonCurrentKubernetesVersion) ? (string)__jsonCurrentKubernetesVersion : (string)CurrentKubernetesVersion;}
            {_dnsPrefix = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("dnsPrefix"), out var __jsonDnsPrefix) ? (string)__jsonDnsPrefix : (string)DnsPrefix;}
            {_fqdnSubdomain = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("fqdnSubdomain"), out var __jsonFqdnSubdomain) ? (string)__jsonFqdnSubdomain : (string)FqdnSubdomain;}
            {_fqdn = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("fqdn"), out var __jsonFqdn) ? (string)__jsonFqdn : (string)Fqdn;}
            {_privateFqdn = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("privateFQDN"), out var __jsonPrivateFqdn) ? (string)__jsonPrivateFqdn : (string)PrivateFqdn;}
            {_azurePortalFqdn = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("azurePortalFQDN"), out var __jsonAzurePortalFqdn) ? (string)__jsonAzurePortalFqdn : (string)AzurePortalFqdn;}
            {_agentPoolProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonArray>("agentPoolProfiles"), out var __jsonAgentPoolProfiles) ? If( __jsonAgentPoolProfiles as Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterAgentPoolProfile[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterAgentPoolProfile) (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterAgentPoolProfile.FromJson(__u) )) ))() : null : AgentPoolProfile;}
            {_addonProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("addonProfiles"), out var __jsonAddonProfiles) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPropertiesAddonProfiles.FromJson(__jsonAddonProfiles) : AddonProfile;}
            {_nodeResourceGroup = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("nodeResourceGroup"), out var __jsonNodeResourceGroup) ? (string)__jsonNodeResourceGroup : (string)NodeResourceGroup;}
            {_enableRbac = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonBoolean>("enableRBAC"), out var __jsonEnableRbac) ? (bool?)__jsonEnableRbac : EnableRbac;}
            {_enablePodSecurityPolicy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonBoolean>("enablePodSecurityPolicy"), out var __jsonEnablePodSecurityPolicy) ? (bool?)__jsonEnablePodSecurityPolicy : EnablePodSecurityPolicy;}
            {_diskEncryptionSetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("diskEncryptionSetID"), out var __jsonDiskEncryptionSetId) ? (string)__jsonDiskEncryptionSetId : (string)DiskEncryptionSetId;}
            {_identityProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("identityProfile"), out var __jsonIdentityProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterPropertiesIdentityProfile.FromJson(__jsonIdentityProfile) : IdentityProfile;}
            {_privateLinkResource = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonArray>("privateLinkResources"), out var __jsonPrivateLinkResources) ? If( __jsonPrivateLinkResources as Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IPrivateLinkResource[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IPrivateLinkResource) (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.PrivateLinkResource.FromJson(__p) )) ))() : null : PrivateLinkResource;}
            {_disableLocalAccount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonBoolean>("disableLocalAccounts"), out var __jsonDisableLocalAccounts) ? (bool?)__jsonDisableLocalAccounts : DisableLocalAccount;}
            {_publicNetworkAccess = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString>("publicNetworkAccess"), out var __jsonPublicNetworkAccess) ? (string)__jsonPublicNetworkAccess : (string)PublicNetworkAccess;}
            {_networkProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject>("networkProfile"), out var __jsonNetworkProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ContainerServiceNetworkProfile.FromJson(__jsonNetworkProfile) : NetworkProfile;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ManagedClusterProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ManagedClusterProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._powerState ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._powerState.ToJson(null,serializationMode) : null, "powerState" ,container.Add );
            }
            AddIf( null != this._linuxProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._linuxProfile.ToJson(null,serializationMode) : null, "linuxProfile" ,container.Add );
            AddIf( null != this._windowsProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._windowsProfile.ToJson(null,serializationMode) : null, "windowsProfile" ,container.Add );
            AddIf( null != this._servicePrincipalProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._servicePrincipalProfile.ToJson(null,serializationMode) : null, "servicePrincipalProfile" ,container.Add );
            AddIf( null != this._podIdentityProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._podIdentityProfile.ToJson(null,serializationMode) : null, "podIdentityProfile" ,container.Add );
            AddIf( null != this._oidcIssuerProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._oidcIssuerProfile.ToJson(null,serializationMode) : null, "oidcIssuerProfile" ,container.Add );
            AddIf( null != this._aadProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._aadProfile.ToJson(null,serializationMode) : null, "aadProfile" ,container.Add );
            AddIf( null != this._autoUpgradeProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._autoUpgradeProfile.ToJson(null,serializationMode) : null, "autoUpgradeProfile" ,container.Add );
            AddIf( null != this._autoScalerProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._autoScalerProfile.ToJson(null,serializationMode) : null, "autoScalerProfile" ,container.Add );
            AddIf( null != this._apiServerAccessProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._apiServerAccessProfile.ToJson(null,serializationMode) : null, "apiServerAccessProfile" ,container.Add );
            AddIf( null != this._httpProxyConfig ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._httpProxyConfig.ToJson(null,serializationMode) : null, "httpProxyConfig" ,container.Add );
            AddIf( null != this._securityProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._securityProfile.ToJson(null,serializationMode) : null, "securityProfile" ,container.Add );
            AddIf( null != this._storageProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._storageProfile.ToJson(null,serializationMode) : null, "storageProfile" ,container.Add );
            AddIf( null != this._workloadAutoScalerProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._workloadAutoScalerProfile.ToJson(null,serializationMode) : null, "workloadAutoScalerProfile" ,container.Add );
            AddIf( null != this._azureMonitorProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._azureMonitorProfile.ToJson(null,serializationMode) : null, "azureMonitorProfile" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._maxAgentPool ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNumber((int)this._maxAgentPool) : null, "maxAgentPools" ,container.Add );
            }
            AddIf( null != (((object)this._kubernetesVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._kubernetesVersion.ToString()) : null, "kubernetesVersion" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._currentKubernetesVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._currentKubernetesVersion.ToString()) : null, "currentKubernetesVersion" ,container.Add );
            }
            AddIf( null != (((object)this._dnsPrefix)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._dnsPrefix.ToString()) : null, "dnsPrefix" ,container.Add );
            AddIf( null != (((object)this._fqdnSubdomain)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._fqdnSubdomain.ToString()) : null, "fqdnSubdomain" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._fqdn)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._fqdn.ToString()) : null, "fqdn" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._privateFqdn)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._privateFqdn.ToString()) : null, "privateFQDN" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._azurePortalFqdn)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._azurePortalFqdn.ToString()) : null, "azurePortalFQDN" ,container.Add );
            }
            if (null != this._agentPoolProfile)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.XNodeArray();
                foreach( var __x in this._agentPoolProfile )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("agentPoolProfiles",__w);
            }
            AddIf( null != this._addonProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._addonProfile.ToJson(null,serializationMode) : null, "addonProfiles" ,container.Add );
            AddIf( null != (((object)this._nodeResourceGroup)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._nodeResourceGroup.ToString()) : null, "nodeResourceGroup" ,container.Add );
            AddIf( null != this._enableRbac ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonBoolean((bool)this._enableRbac) : null, "enableRBAC" ,container.Add );
            AddIf( null != this._enablePodSecurityPolicy ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonBoolean((bool)this._enablePodSecurityPolicy) : null, "enablePodSecurityPolicy" ,container.Add );
            AddIf( null != (((object)this._diskEncryptionSetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._diskEncryptionSetId.ToString()) : null, "diskEncryptionSetID" ,container.Add );
            AddIf( null != this._identityProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._identityProfile.ToJson(null,serializationMode) : null, "identityProfile" ,container.Add );
            if (null != this._privateLinkResource)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.XNodeArray();
                foreach( var __s in this._privateLinkResource )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("privateLinkResources",__r);
            }
            AddIf( null != this._disableLocalAccount ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonBoolean((bool)this._disableLocalAccount) : null, "disableLocalAccounts" ,container.Add );
            AddIf( null != (((object)this._publicNetworkAccess)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonString(this._publicNetworkAccess.ToString()) : null, "publicNetworkAccess" ,container.Add );
            AddIf( null != this._networkProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode) this._networkProfile.ToJson(null,serializationMode) : null, "networkProfile" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}