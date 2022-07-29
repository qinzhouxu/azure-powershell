// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.PowerShell;

    /// <summary>Defines the parameters for the url redirect action.</summary>
    [System.ComponentModel.TypeConverter(typeof(UrlRedirectActionParametersTypeConverter))]
    public partial class UrlRedirectActionParameters
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.UrlRedirectActionParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParameters" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UrlRedirectActionParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.UrlRedirectActionParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParameters" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UrlRedirectActionParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UrlRedirectActionParameters" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="UrlRedirectActionParameters" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode.IncludeAll)?.ToString();

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.UrlRedirectActionParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UrlRedirectActionParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TypeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).TypeName = (string) content.GetValueForProperty("TypeName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).TypeName, global::System.Convert.ToString);
            }
            if (content.Contains("RedirectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).RedirectType = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RedirectType) content.GetValueForProperty("RedirectType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).RedirectType, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RedirectType.CreateFrom);
            }
            if (content.Contains("DestinationProtocol"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).DestinationProtocol = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DestinationProtocol?) content.GetValueForProperty("DestinationProtocol",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).DestinationProtocol, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DestinationProtocol.CreateFrom);
            }
            if (content.Contains("CustomPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).CustomPath = (string) content.GetValueForProperty("CustomPath",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).CustomPath, global::System.Convert.ToString);
            }
            if (content.Contains("CustomHostname"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).CustomHostname = (string) content.GetValueForProperty("CustomHostname",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).CustomHostname, global::System.Convert.ToString);
            }
            if (content.Contains("CustomQueryString"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).CustomQueryString = (string) content.GetValueForProperty("CustomQueryString",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).CustomQueryString, global::System.Convert.ToString);
            }
            if (content.Contains("CustomFragment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).CustomFragment = (string) content.GetValueForProperty("CustomFragment",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).CustomFragment, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.UrlRedirectActionParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UrlRedirectActionParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TypeName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).TypeName = (string) content.GetValueForProperty("TypeName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).TypeName, global::System.Convert.ToString);
            }
            if (content.Contains("RedirectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).RedirectType = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RedirectType) content.GetValueForProperty("RedirectType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).RedirectType, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RedirectType.CreateFrom);
            }
            if (content.Contains("DestinationProtocol"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).DestinationProtocol = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DestinationProtocol?) content.GetValueForProperty("DestinationProtocol",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).DestinationProtocol, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DestinationProtocol.CreateFrom);
            }
            if (content.Contains("CustomPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).CustomPath = (string) content.GetValueForProperty("CustomPath",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).CustomPath, global::System.Convert.ToString);
            }
            if (content.Contains("CustomHostname"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).CustomHostname = (string) content.GetValueForProperty("CustomHostname",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).CustomHostname, global::System.Convert.ToString);
            }
            if (content.Contains("CustomQueryString"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).CustomQueryString = (string) content.GetValueForProperty("CustomQueryString",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).CustomQueryString, global::System.Convert.ToString);
            }
            if (content.Contains("CustomFragment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).CustomFragment = (string) content.GetValueForProperty("CustomFragment",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal)this).CustomFragment, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Defines the parameters for the url redirect action.
    [System.ComponentModel.TypeConverter(typeof(UrlRedirectActionParametersTypeConverter))]
    public partial interface IUrlRedirectActionParameters

    {

    }
}