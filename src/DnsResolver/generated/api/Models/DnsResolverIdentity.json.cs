// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Extensions;

    public partial class DnsResolverIdentity
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonObject into a new instance of <see cref="DnsResolverIdentity" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal DnsResolverIdentity(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)SubscriptionId;}
            {_resourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString>("resourceGroupName"), out var __jsonResourceGroupName) ? (string)__jsonResourceGroupName : (string)ResourceGroupName;}
            {_dnsResolverName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString>("dnsResolverName"), out var __jsonDnsResolverName) ? (string)__jsonDnsResolverName : (string)DnsResolverName;}
            {_virtualNetworkName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString>("virtualNetworkName"), out var __jsonVirtualNetworkName) ? (string)__jsonVirtualNetworkName : (string)VirtualNetworkName;}
            {_inboundEndpointName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString>("inboundEndpointName"), out var __jsonInboundEndpointName) ? (string)__jsonInboundEndpointName : (string)InboundEndpointName;}
            {_outboundEndpointName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString>("outboundEndpointName"), out var __jsonOutboundEndpointName) ? (string)__jsonOutboundEndpointName : (string)OutboundEndpointName;}
            {_dnsForwardingRulesetName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString>("dnsForwardingRulesetName"), out var __jsonDnsForwardingRulesetName) ? (string)__jsonDnsForwardingRulesetName : (string)DnsForwardingRulesetName;}
            {_forwardingRuleName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString>("forwardingRuleName"), out var __jsonForwardingRuleName) ? (string)__jsonForwardingRuleName : (string)ForwardingRuleName;}
            {_virtualNetworkLinkName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString>("virtualNetworkLinkName"), out var __jsonVirtualNetworkLinkName) ? (string)__jsonVirtualNetworkLinkName : (string)VirtualNetworkLinkName;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.IDnsResolverIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.IDnsResolverIdentity.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.IDnsResolverIdentity FromJson(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonObject json ? new DnsResolverIdentity(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="DnsResolverIdentity" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DnsResolverIdentity" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != (((object)this._resourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString(this._resourceGroupName.ToString()) : null, "resourceGroupName" ,container.Add );
            AddIf( null != (((object)this._dnsResolverName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString(this._dnsResolverName.ToString()) : null, "dnsResolverName" ,container.Add );
            AddIf( null != (((object)this._virtualNetworkName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString(this._virtualNetworkName.ToString()) : null, "virtualNetworkName" ,container.Add );
            AddIf( null != (((object)this._inboundEndpointName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString(this._inboundEndpointName.ToString()) : null, "inboundEndpointName" ,container.Add );
            AddIf( null != (((object)this._outboundEndpointName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString(this._outboundEndpointName.ToString()) : null, "outboundEndpointName" ,container.Add );
            AddIf( null != (((object)this._dnsForwardingRulesetName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString(this._dnsForwardingRulesetName.ToString()) : null, "dnsForwardingRulesetName" ,container.Add );
            AddIf( null != (((object)this._forwardingRuleName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString(this._forwardingRuleName.ToString()) : null, "forwardingRuleName" ,container.Add );
            AddIf( null != (((object)this._virtualNetworkLinkName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString(this._virtualNetworkLinkName.ToString()) : null, "virtualNetworkLinkName" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}