// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Storage.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.PowerShell;

    /// <summary>An access key for the storage account.</summary>
    [System.ComponentModel.TypeConverter(typeof(StorageAccountKeyTypeConverter))]
    public partial class StorageAccountKey
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.StorageAccountKey"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKey" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKey DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new StorageAccountKey(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.StorageAccountKey"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKey" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKey DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new StorageAccountKey(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="StorageAccountKey" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="StorageAccountKey" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKey FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.StorageAccountKey"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal StorageAccountKey(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("KeyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKeyInternal)this).KeyName = (string) content.GetValueForProperty("KeyName",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKeyInternal)this).KeyName, global::System.Convert.ToString);
            }
            if (content.Contains("Value"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKeyInternal)this).Value = (string) content.GetValueForProperty("Value",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKeyInternal)this).Value, global::System.Convert.ToString);
            }
            if (content.Contains("Permission"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKeyInternal)this).Permission = (string) content.GetValueForProperty("Permission",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKeyInternal)this).Permission, global::System.Convert.ToString);
            }
            if (content.Contains("CreationTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKeyInternal)this).CreationTime = (global::System.DateTime?) content.GetValueForProperty("CreationTime",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKeyInternal)this).CreationTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.StorageAccountKey"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal StorageAccountKey(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("KeyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKeyInternal)this).KeyName = (string) content.GetValueForProperty("KeyName",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKeyInternal)this).KeyName, global::System.Convert.ToString);
            }
            if (content.Contains("Value"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKeyInternal)this).Value = (string) content.GetValueForProperty("Value",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKeyInternal)this).Value, global::System.Convert.ToString);
            }
            if (content.Contains("Permission"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKeyInternal)this).Permission = (string) content.GetValueForProperty("Permission",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKeyInternal)this).Permission, global::System.Convert.ToString);
            }
            if (content.Contains("CreationTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKeyInternal)this).CreationTime = (global::System.DateTime?) content.GetValueForProperty("CreationTime",((Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageAccountKeyInternal)this).CreationTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// An access key for the storage account.
    [System.ComponentModel.TypeConverter(typeof(StorageAccountKeyTypeConverter))]
    public partial interface IStorageAccountKey

    {

    }
}