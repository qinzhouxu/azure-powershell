// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301
{
    using Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.PowerShell;

    /// <summary>List of Spacecraft Resource Properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(SpacecraftsPropertiesTypeConverter))]
    public partial class SpacecraftsProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.SpacecraftsProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SpacecraftsProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.SpacecraftsProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SpacecraftsProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SpacecraftsProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SpacecraftsProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.SpacecraftsProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SpacecraftsProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("NoradId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).NoradId = (string) content.GetValueForProperty("NoradId",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).NoradId, global::System.Convert.ToString);
            }
            if (content.Contains("TitleLine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).TitleLine = (string) content.GetValueForProperty("TitleLine",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).TitleLine, global::System.Convert.ToString);
            }
            if (content.Contains("TleLine1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).TleLine1 = (string) content.GetValueForProperty("TleLine1",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).TleLine1, global::System.Convert.ToString);
            }
            if (content.Contains("TleLine2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).TleLine2 = (string) content.GetValueForProperty("TleLine2",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).TleLine2, global::System.Convert.ToString);
            }
            if (content.Contains("Link"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).Link = (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftLink[]) content.GetValueForProperty("Link",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).Link, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftLink>(__y, Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.SpacecraftLinkTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.SpacecraftsProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SpacecraftsProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("NoradId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).NoradId = (string) content.GetValueForProperty("NoradId",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).NoradId, global::System.Convert.ToString);
            }
            if (content.Contains("TitleLine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).TitleLine = (string) content.GetValueForProperty("TitleLine",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).TitleLine, global::System.Convert.ToString);
            }
            if (content.Contains("TleLine1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).TleLine1 = (string) content.GetValueForProperty("TleLine1",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).TleLine1, global::System.Convert.ToString);
            }
            if (content.Contains("TleLine2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).TleLine2 = (string) content.GetValueForProperty("TleLine2",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).TleLine2, global::System.Convert.ToString);
            }
            if (content.Contains("Link"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).Link = (Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftLink[]) content.GetValueForProperty("Link",((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftsPropertiesInternal)this).Link, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.ISpacecraftLink>(__y, Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20220301.SpacecraftLinkTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// List of Spacecraft Resource Properties.
    [System.ComponentModel.TypeConverter(typeof(SpacecraftsPropertiesTypeConverter))]
    public partial interface ISpacecraftsProperties

    {

    }
}