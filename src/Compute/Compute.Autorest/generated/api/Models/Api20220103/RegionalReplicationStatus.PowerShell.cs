// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103
{
    using Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.PowerShell;

    /// <summary>This is the regional replication status.</summary>
    [System.ComponentModel.TypeConverter(typeof(RegionalReplicationStatusTypeConverter))]
    public partial class RegionalReplicationStatus
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.RegionalReplicationStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatus" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatus DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RegionalReplicationStatus(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.RegionalReplicationStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatus" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatus DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RegionalReplicationStatus(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RegionalReplicationStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="RegionalReplicationStatus" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatus FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.RegionalReplicationStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RegionalReplicationStatus(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Region"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatusInternal)this).Region = (string) content.GetValueForProperty("Region",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatusInternal)this).Region, global::System.Convert.ToString);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatusInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatusInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationState.CreateFrom);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatusInternal)this).Detail = (string) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatusInternal)this).Detail, global::System.Convert.ToString);
            }
            if (content.Contains("Progress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatusInternal)this).Progress = (int?) content.GetValueForProperty("Progress",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatusInternal)this).Progress, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.RegionalReplicationStatus"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RegionalReplicationStatus(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Region"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatusInternal)this).Region = (string) content.GetValueForProperty("Region",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatusInternal)this).Region, global::System.Convert.ToString);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatusInternal)this).State = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationState?) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatusInternal)this).State, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ReplicationState.CreateFrom);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatusInternal)this).Detail = (string) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatusInternal)this).Detail, global::System.Convert.ToString);
            }
            if (content.Contains("Progress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatusInternal)this).Progress = (int?) content.GetValueForProperty("Progress",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20220103.IRegionalReplicationStatusInternal)this).Progress, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// This is the regional replication status.
    [System.ComponentModel.TypeConverter(typeof(RegionalReplicationStatusTypeConverter))]
    public partial interface IRegionalReplicationStatus

    {

    }
}