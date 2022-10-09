// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.PowerShell;

    /// <summary>Single item in List or Get Schema Group operation</summary>
    [System.ComponentModel.TypeConverter(typeof(SchemaGroupTypeConverter))]
    public partial class SchemaGroup
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.SchemaGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroup" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroup DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SchemaGroup(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.SchemaGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroup" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroup DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SchemaGroup(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SchemaGroup" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SchemaGroup" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroup FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.SchemaGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SchemaGroup(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupProperties1) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.SchemaGroupProperties1TypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("SchemaCompatibility"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SchemaCompatibility = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.SchemaCompatibility?) content.GetValueForProperty("SchemaCompatibility",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SchemaCompatibility, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.SchemaCompatibility.CreateFrom);
            }
            if (content.Contains("SchemaType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SchemaType = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.SchemaType?) content.GetValueForProperty("SchemaType",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SchemaType, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.SchemaType.CreateFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("UpdatedAtUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).UpdatedAtUtc = (global::System.DateTime?) content.GetValueForProperty("UpdatedAtUtc",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).UpdatedAtUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CreatedAtUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).CreatedAtUtc = (global::System.DateTime?) content.GetValueForProperty("CreatedAtUtc",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).CreatedAtUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).ETag, global::System.Convert.ToString);
            }
            if (content.Contains("GroupProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).GroupProperty = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupProperties) content.GetValueForProperty("GroupProperty",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).GroupProperty, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.SchemaGroupPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.SchemaGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SchemaGroup(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupProperties1) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.SchemaGroupProperties1TypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api10.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20.IProxyResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("SchemaCompatibility"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SchemaCompatibility = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.SchemaCompatibility?) content.GetValueForProperty("SchemaCompatibility",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SchemaCompatibility, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.SchemaCompatibility.CreateFrom);
            }
            if (content.Contains("SchemaType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SchemaType = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.SchemaType?) content.GetValueForProperty("SchemaType",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SchemaType, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.SchemaType.CreateFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("UpdatedAtUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).UpdatedAtUtc = (global::System.DateTime?) content.GetValueForProperty("UpdatedAtUtc",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).UpdatedAtUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CreatedAtUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).CreatedAtUtc = (global::System.DateTime?) content.GetValueForProperty("CreatedAtUtc",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).CreatedAtUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).ETag, global::System.Convert.ToString);
            }
            if (content.Contains("GroupProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).GroupProperty = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupProperties) content.GetValueForProperty("GroupProperty",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).GroupProperty, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.SchemaGroupPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202201Preview.ISchemaGroupInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Single item in List or Get Schema Group operation
    [System.ComponentModel.TypeConverter(typeof(SchemaGroupTypeConverter))]
    public partial interface ISchemaGroup

    {

    }
}