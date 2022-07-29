// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Compute node information related to a AmlCompute.</summary>
    public partial class AmlComputeNodeInformation
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonObject into a new instance of <see cref="AmlComputeNodeInformation" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AmlComputeNodeInformation(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_nodeId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonString>("nodeId"), out var __jsonNodeId) ? (string)__jsonNodeId : (string)NodeId;}
            {_privateIPAddress = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonString>("privateIpAddress"), out var __jsonPrivateIPAddress) ? (string)__jsonPrivateIPAddress : (string)PrivateIPAddress;}
            {_publicIPAddress = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonString>("publicIpAddress"), out var __jsonPublicIPAddress) ? (string)__jsonPublicIPAddress : (string)PublicIPAddress;}
            {_port = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNumber>("port"), out var __jsonPort) ? (int?)__jsonPort : Port;}
            {_nodeState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonString>("nodeState"), out var __jsonNodeState) ? (string)__jsonNodeState : (string)NodeState;}
            {_runId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonString>("runId"), out var __jsonRunId) ? (string)__jsonRunId : (string)RunId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAmlComputeNodeInformation.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAmlComputeNodeInformation.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAmlComputeNodeInformation FromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonObject json ? new AmlComputeNodeInformation(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AmlComputeNodeInformation" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AmlComputeNodeInformation" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._nodeId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonString(this._nodeId.ToString()) : null, "nodeId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._privateIPAddress)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonString(this._privateIPAddress.ToString()) : null, "privateIpAddress" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._publicIPAddress)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonString(this._publicIPAddress.ToString()) : null, "publicIpAddress" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._port ? (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNumber((int)this._port) : null, "port" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._nodeState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonString(this._nodeState.ToString()) : null, "nodeState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._runId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonString(this._runId.ToString()) : null, "runId" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}