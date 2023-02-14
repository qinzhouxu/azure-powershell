// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101
{
    using Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.PowerShell;

    /// <summary>Savings plan order properties</summary>
    [System.ComponentModel.TypeConverter(typeof(SavingsPlanOrderModelPropertiesTypeConverter))]
    public partial class SavingsPlanOrderModelProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.SavingsPlanOrderModelProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SavingsPlanOrderModelProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.SavingsPlanOrderModelProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SavingsPlanOrderModelProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SavingsPlanOrderModelProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SavingsPlanOrderModelProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.SavingsPlanOrderModelProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SavingsPlanOrderModelProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PlanInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformation = (Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformation) content.GetValueForProperty("PlanInformation",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformation, Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.BillingPlanInformationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtendedStatusInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ExtendedStatusInfo = (Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IExtendedStatusInfo) content.GetValueForProperty("ExtendedStatusInfo",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ExtendedStatusInfo, Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ExtendedStatusInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("BillingScopeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BillingScopeId = (string) content.GetValueForProperty("BillingScopeId",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BillingScopeId, global::System.Convert.ToString);
            }
            if (content.Contains("BillingProfileId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BillingProfileId = (string) content.GetValueForProperty("BillingProfileId",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BillingProfileId, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).CustomerId = (string) content.GetValueForProperty("CustomerId",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).CustomerId, global::System.Convert.ToString);
            }
            if (content.Contains("BillingAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BillingAccountId = (string) content.GetValueForProperty("BillingAccountId",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BillingAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("Term"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).Term = (Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term?) content.GetValueForProperty("Term",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).Term, Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term.CreateFrom);
            }
            if (content.Contains("BillingPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BillingPlan = (Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan?) content.GetValueForProperty("BillingPlan",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BillingPlan, Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan.CreateFrom);
            }
            if (content.Contains("ExpiryDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ExpiryDateTime = (global::System.DateTime?) content.GetValueForProperty("ExpiryDateTime",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ExpiryDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("BenefitStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BenefitStartTime = (global::System.DateTime?) content.GetValueForProperty("BenefitStartTime",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BenefitStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SavingsPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).SavingsPlan = (string[]) content.GetValueForProperty("SavingsPlan",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).SavingsPlan, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ExtendedStatusInfoStatusCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ExtendedStatusInfoStatusCode = (string) content.GetValueForProperty("ExtendedStatusInfoStatusCode",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ExtendedStatusInfoStatusCode, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedStatusInfoMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ExtendedStatusInfoMessage = (string) content.GetValueForProperty("ExtendedStatusInfoMessage",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ExtendedStatusInfoMessage, global::System.Convert.ToString);
            }
            if (content.Contains("PlanInformationPricingCurrencyTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformationPricingCurrencyTotal = (Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPrice) content.GetValueForProperty("PlanInformationPricingCurrencyTotal",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformationPricingCurrencyTotal, Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("PlanInformationStartDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformationStartDate = (global::System.DateTime?) content.GetValueForProperty("PlanInformationStartDate",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformationStartDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PlanInformationNextPaymentDueDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformationNextPaymentDueDate = (global::System.DateTime?) content.GetValueForProperty("PlanInformationNextPaymentDueDate",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformationNextPaymentDueDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PlanInformationTransaction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformationTransaction = (Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPaymentDetail[]) content.GetValueForProperty("PlanInformationTransaction",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformationTransaction, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPaymentDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.PaymentDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("PricingCurrencyTotalCurrencyCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PricingCurrencyTotalCurrencyCode = (string) content.GetValueForProperty("PricingCurrencyTotalCurrencyCode",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PricingCurrencyTotalCurrencyCode, global::System.Convert.ToString);
            }
            if (content.Contains("PricingCurrencyTotalAmount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PricingCurrencyTotalAmount = (double?) content.GetValueForProperty("PricingCurrencyTotalAmount",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PricingCurrencyTotalAmount, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.SavingsPlanOrderModelProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SavingsPlanOrderModelProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PlanInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformation = (Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IBillingPlanInformation) content.GetValueForProperty("PlanInformation",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformation, Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.BillingPlanInformationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtendedStatusInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ExtendedStatusInfo = (Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IExtendedStatusInfo) content.GetValueForProperty("ExtendedStatusInfo",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ExtendedStatusInfo, Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ExtendedStatusInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("BillingScopeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BillingScopeId = (string) content.GetValueForProperty("BillingScopeId",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BillingScopeId, global::System.Convert.ToString);
            }
            if (content.Contains("BillingProfileId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BillingProfileId = (string) content.GetValueForProperty("BillingProfileId",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BillingProfileId, global::System.Convert.ToString);
            }
            if (content.Contains("CustomerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).CustomerId = (string) content.GetValueForProperty("CustomerId",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).CustomerId, global::System.Convert.ToString);
            }
            if (content.Contains("BillingAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BillingAccountId = (string) content.GetValueForProperty("BillingAccountId",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BillingAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("Term"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).Term = (Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term?) content.GetValueForProperty("Term",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).Term, Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.Term.CreateFrom);
            }
            if (content.Contains("BillingPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BillingPlan = (Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan?) content.GetValueForProperty("BillingPlan",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BillingPlan, Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Support.BillingPlan.CreateFrom);
            }
            if (content.Contains("ExpiryDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ExpiryDateTime = (global::System.DateTime?) content.GetValueForProperty("ExpiryDateTime",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ExpiryDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("BenefitStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BenefitStartTime = (global::System.DateTime?) content.GetValueForProperty("BenefitStartTime",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).BenefitStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SavingsPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).SavingsPlan = (string[]) content.GetValueForProperty("SavingsPlan",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).SavingsPlan, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ExtendedStatusInfoStatusCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ExtendedStatusInfoStatusCode = (string) content.GetValueForProperty("ExtendedStatusInfoStatusCode",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ExtendedStatusInfoStatusCode, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedStatusInfoMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ExtendedStatusInfoMessage = (string) content.GetValueForProperty("ExtendedStatusInfoMessage",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).ExtendedStatusInfoMessage, global::System.Convert.ToString);
            }
            if (content.Contains("PlanInformationPricingCurrencyTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformationPricingCurrencyTotal = (Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPrice) content.GetValueForProperty("PlanInformationPricingCurrencyTotal",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformationPricingCurrencyTotal, Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("PlanInformationStartDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformationStartDate = (global::System.DateTime?) content.GetValueForProperty("PlanInformationStartDate",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformationStartDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PlanInformationNextPaymentDueDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformationNextPaymentDueDate = (global::System.DateTime?) content.GetValueForProperty("PlanInformationNextPaymentDueDate",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformationNextPaymentDueDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PlanInformationTransaction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformationTransaction = (Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPaymentDetail[]) content.GetValueForProperty("PlanInformationTransaction",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PlanInformationTransaction, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IPaymentDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.PaymentDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("PricingCurrencyTotalCurrencyCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PricingCurrencyTotalCurrencyCode = (string) content.GetValueForProperty("PricingCurrencyTotalCurrencyCode",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PricingCurrencyTotalCurrencyCode, global::System.Convert.ToString);
            }
            if (content.Contains("PricingCurrencyTotalAmount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PricingCurrencyTotalAmount = (double?) content.GetValueForProperty("PricingCurrencyTotalAmount",((Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.ISavingsPlanOrderModelPropertiesInternal)this).PricingCurrencyTotalAmount, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Savings plan order properties
    [System.ComponentModel.TypeConverter(typeof(SavingsPlanOrderModelPropertiesTypeConverter))]
    public partial interface ISavingsPlanOrderModelProperties

    {

    }
}