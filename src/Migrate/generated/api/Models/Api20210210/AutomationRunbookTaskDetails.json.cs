// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>This class represents the task details for an automation runbook.</summary>
    public partial class AutomationRunbookTaskDetails
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject into a new instance of <see cref="AutomationRunbookTaskDetails" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AutomationRunbookTaskDetails(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __taskTypeDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.TaskTypeDetails(json);
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_cloudServiceName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("cloudServiceName"), out var __jsonCloudServiceName) ? (string)__jsonCloudServiceName : (string)CloudServiceName;}
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)SubscriptionId;}
            {_accountName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("accountName"), out var __jsonAccountName) ? (string)__jsonAccountName : (string)AccountName;}
            {_runbookId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("runbookId"), out var __jsonRunbookId) ? (string)__jsonRunbookId : (string)RunbookId;}
            {_runbookName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("runbookName"), out var __jsonRunbookName) ? (string)__jsonRunbookName : (string)RunbookName;}
            {_jobId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("jobId"), out var __jsonJobId) ? (string)__jsonJobId : (string)JobId;}
            {_jobOutput = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("jobOutput"), out var __jsonJobOutput) ? (string)__jsonJobOutput : (string)JobOutput;}
            {_isPrimarySideScript = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonBoolean>("isPrimarySideScript"), out var __jsonIsPrimarySideScript) ? (bool?)__jsonIsPrimarySideScript : IsPrimarySideScript;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAutomationRunbookTaskDetails.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAutomationRunbookTaskDetails.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAutomationRunbookTaskDetails FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json ? new AutomationRunbookTaskDetails(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AutomationRunbookTaskDetails" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AutomationRunbookTaskDetails" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __taskTypeDetails?.ToJson(container, serializationMode);
            AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._cloudServiceName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._cloudServiceName.ToString()) : null, "cloudServiceName" ,container.Add );
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != (((object)this._accountName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._accountName.ToString()) : null, "accountName" ,container.Add );
            AddIf( null != (((object)this._runbookId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._runbookId.ToString()) : null, "runbookId" ,container.Add );
            AddIf( null != (((object)this._runbookName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._runbookName.ToString()) : null, "runbookName" ,container.Add );
            AddIf( null != (((object)this._jobId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._jobId.ToString()) : null, "jobId" ,container.Add );
            AddIf( null != (((object)this._jobOutput)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._jobOutput.ToString()) : null, "jobOutput" ,container.Add );
            AddIf( null != this._isPrimarySideScript ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonBoolean((bool)this._isPrimarySideScript) : null, "isPrimarySideScript" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}