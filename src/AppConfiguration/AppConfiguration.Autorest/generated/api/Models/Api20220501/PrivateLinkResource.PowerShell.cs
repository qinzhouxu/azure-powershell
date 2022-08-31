// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.PowerShell;

    /// <summary>A resource that supports private link capabilities.</summary>
    [System.ComponentModel.TypeConverter(typeof(PrivateLinkResourceTypeConverter))]
    public partial class PrivateLinkResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.PrivateLinkResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PrivateLinkResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.PrivateLinkResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PrivateLinkResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PrivateLinkResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PrivateLinkResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.PrivateLinkResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PrivateLinkResource(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.PrivateLinkResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("GroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).GroupId = (string) content.GetValueForProperty("GroupId",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).GroupId, global::System.Convert.ToString);
            }
            if (content.Contains("RequiredMember"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).RequiredMember = (string[]) content.GetValueForProperty("RequiredMember",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).RequiredMember, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RequiredZoneName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).RequiredZoneName = (string[]) content.GetValueForProperty("RequiredZoneName",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).RequiredZoneName, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.PrivateLinkResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PrivateLinkResource(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.PrivateLinkResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("GroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).GroupId = (string) content.GetValueForProperty("GroupId",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).GroupId, global::System.Convert.ToString);
            }
            if (content.Contains("RequiredMember"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).RequiredMember = (string[]) content.GetValueForProperty("RequiredMember",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).RequiredMember, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RequiredZoneName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).RequiredZoneName = (string[]) content.GetValueForProperty("RequiredZoneName",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IPrivateLinkResourceInternal)this).RequiredZoneName, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// A resource that supports private link capabilities.
    [System.ComponentModel.TypeConverter(typeof(PrivateLinkResourceTypeConverter))]
    public partial interface IPrivateLinkResource

    {

    }
}