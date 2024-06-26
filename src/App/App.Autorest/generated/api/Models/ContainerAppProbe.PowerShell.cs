// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.PowerShell;

    /// <summary>
    /// Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive
    /// traffic.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ContainerAppProbeTypeConverter))]
    public partial class ContainerAppProbe
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.ContainerAppProbe"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ContainerAppProbe(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("HttpGet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGet = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeHttpGet) content.GetValueForProperty("HttpGet",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGet, Microsoft.Azure.PowerShell.Cmdlets.App.Models.ContainerAppProbeHttpGetTypeConverter.ConvertFrom);
            }
            if (content.Contains("TcpSocket"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TcpSocket = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeTcpSocket) content.GetValueForProperty("TcpSocket",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TcpSocket, Microsoft.Azure.PowerShell.Cmdlets.App.Models.ContainerAppProbeTcpSocketTypeConverter.ConvertFrom);
            }
            if (content.Contains("FailureThreshold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).FailureThreshold = (int?) content.GetValueForProperty("FailureThreshold",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).FailureThreshold, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("InitialDelaySecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).InitialDelaySecond = (int?) content.GetValueForProperty("InitialDelaySecond",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).InitialDelaySecond, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("PeriodSecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).PeriodSecond = (int?) content.GetValueForProperty("PeriodSecond",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).PeriodSecond, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SuccessThreshold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).SuccessThreshold = (int?) content.GetValueForProperty("SuccessThreshold",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).SuccessThreshold, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("TerminationGracePeriodSecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TerminationGracePeriodSecond = (long?) content.GetValueForProperty("TerminationGracePeriodSecond",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TerminationGracePeriodSecond, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TimeoutSecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TimeoutSecond = (int?) content.GetValueForProperty("TimeoutSecond",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TimeoutSecond, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("HttpGetScheme"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetScheme = (string) content.GetValueForProperty("HttpGetScheme",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetScheme, global::System.Convert.ToString);
            }
            if (content.Contains("HttpGetHost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetHost = (string) content.GetValueForProperty("HttpGetHost",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetHost, global::System.Convert.ToString);
            }
            if (content.Contains("HttpGetHttpHeader"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetHttpHeader = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeHttpGetHttpHeadersItem>) content.GetValueForProperty("HttpGetHttpHeader",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetHttpHeader, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeHttpGetHttpHeadersItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.ContainerAppProbeHttpGetHttpHeadersItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("HttpGetPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetPath = (string) content.GetValueForProperty("HttpGetPath",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetPath, global::System.Convert.ToString);
            }
            if (content.Contains("HttpGetPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetPort = (int) content.GetValueForProperty("HttpGetPort",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("TcpSocketHost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TcpSocketHost = (string) content.GetValueForProperty("TcpSocketHost",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TcpSocketHost, global::System.Convert.ToString);
            }
            if (content.Contains("TcpSocketPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TcpSocketPort = (int) content.GetValueForProperty("TcpSocketPort",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TcpSocketPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.ContainerAppProbe"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ContainerAppProbe(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("HttpGet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGet = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeHttpGet) content.GetValueForProperty("HttpGet",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGet, Microsoft.Azure.PowerShell.Cmdlets.App.Models.ContainerAppProbeHttpGetTypeConverter.ConvertFrom);
            }
            if (content.Contains("TcpSocket"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TcpSocket = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeTcpSocket) content.GetValueForProperty("TcpSocket",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TcpSocket, Microsoft.Azure.PowerShell.Cmdlets.App.Models.ContainerAppProbeTcpSocketTypeConverter.ConvertFrom);
            }
            if (content.Contains("FailureThreshold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).FailureThreshold = (int?) content.GetValueForProperty("FailureThreshold",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).FailureThreshold, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("InitialDelaySecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).InitialDelaySecond = (int?) content.GetValueForProperty("InitialDelaySecond",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).InitialDelaySecond, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("PeriodSecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).PeriodSecond = (int?) content.GetValueForProperty("PeriodSecond",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).PeriodSecond, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SuccessThreshold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).SuccessThreshold = (int?) content.GetValueForProperty("SuccessThreshold",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).SuccessThreshold, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("TerminationGracePeriodSecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TerminationGracePeriodSecond = (long?) content.GetValueForProperty("TerminationGracePeriodSecond",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TerminationGracePeriodSecond, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TimeoutSecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TimeoutSecond = (int?) content.GetValueForProperty("TimeoutSecond",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TimeoutSecond, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("HttpGetScheme"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetScheme = (string) content.GetValueForProperty("HttpGetScheme",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetScheme, global::System.Convert.ToString);
            }
            if (content.Contains("HttpGetHost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetHost = (string) content.GetValueForProperty("HttpGetHost",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetHost, global::System.Convert.ToString);
            }
            if (content.Contains("HttpGetHttpHeader"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetHttpHeader = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeHttpGetHttpHeadersItem>) content.GetValueForProperty("HttpGetHttpHeader",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetHttpHeader, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeHttpGetHttpHeadersItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.ContainerAppProbeHttpGetHttpHeadersItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("HttpGetPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetPath = (string) content.GetValueForProperty("HttpGetPath",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetPath, global::System.Convert.ToString);
            }
            if (content.Contains("HttpGetPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetPort = (int) content.GetValueForProperty("HttpGetPort",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).HttpGetPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("TcpSocketHost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TcpSocketHost = (string) content.GetValueForProperty("TcpSocketHost",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TcpSocketHost, global::System.Convert.ToString);
            }
            if (content.Contains("TcpSocketPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TcpSocketPort = (int) content.GetValueForProperty("TcpSocketPort",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbeInternal)this).TcpSocketPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.ContainerAppProbe"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbe" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbe DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ContainerAppProbe(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.ContainerAppProbe"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbe" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbe DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ContainerAppProbe(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ContainerAppProbe" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ContainerAppProbe" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainerAppProbe FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive
    /// traffic.
    [System.ComponentModel.TypeConverter(typeof(ContainerAppProbeTypeConverter))]
    public partial interface IContainerAppProbe

    {

    }
}