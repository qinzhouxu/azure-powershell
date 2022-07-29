// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.PowerShell;

    /// <summary>AuthConfig resource specific properties</summary>
    [System.ComponentModel.TypeConverter(typeof(AuthConfigPropertiesTypeConverter))]
    public partial class AuthConfigProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.AuthConfigProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AuthConfigProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Platform"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).Platform = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthPlatform) content.GetValueForProperty("Platform",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).Platform, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.AuthPlatformTypeConverter.ConvertFrom);
            }
            if (content.Contains("GlobalValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).GlobalValidation = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IGlobalValidation) content.GetValueForProperty("GlobalValidation",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).GlobalValidation, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.GlobalValidationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Login"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).Login = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ILogin) content.GetValueForProperty("Login",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).Login, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.LoginTypeConverter.ConvertFrom);
            }
            if (content.Contains("HttpSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).HttpSetting = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettings) content.GetValueForProperty("HttpSetting",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).HttpSetting, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.HttpSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityProvider"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).IdentityProvider = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IIdentityProviders) content.GetValueForProperty("IdentityProvider",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).IdentityProvider, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IdentityProvidersTypeConverter.ConvertFrom);
            }
            if (content.Contains("GlobalValidationExcludedPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).GlobalValidationExcludedPath = (string[]) content.GetValueForProperty("GlobalValidationExcludedPath",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).GlobalValidationExcludedPath, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LoginRoute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginRoute = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ILoginRoutes) content.GetValueForProperty("LoginRoute",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginRoute, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.LoginRoutesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LoginCookieExpiration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginCookieExpiration = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICookieExpiration) content.GetValueForProperty("LoginCookieExpiration",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginCookieExpiration, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.CookieExpirationTypeConverter.ConvertFrom);
            }
            if (content.Contains("LoginNonce"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginNonce = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.INonce) content.GetValueForProperty("LoginNonce",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginNonce, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.NonceTypeConverter.ConvertFrom);
            }
            if (content.Contains("HttpSettingRoute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).HttpSettingRoute = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsRoutes) content.GetValueForProperty("HttpSettingRoute",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).HttpSettingRoute, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.HttpSettingsRoutesTypeConverter.ConvertFrom);
            }
            if (content.Contains("HttpSettingForwardProxy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).HttpSettingForwardProxy = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IForwardProxy) content.GetValueForProperty("HttpSettingForwardProxy",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).HttpSettingForwardProxy, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ForwardProxyTypeConverter.ConvertFrom);
            }
            if (content.Contains("PlatformEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).PlatformEnabled = (bool?) content.GetValueForProperty("PlatformEnabled",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).PlatformEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PlatformRuntimeVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).PlatformRuntimeVersion = (string) content.GetValueForProperty("PlatformRuntimeVersion",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).PlatformRuntimeVersion, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalValidationUnauthenticatedClientAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).GlobalValidationUnauthenticatedClientAction = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.UnauthenticatedClientActionV2?) content.GetValueForProperty("GlobalValidationUnauthenticatedClientAction",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).GlobalValidationUnauthenticatedClientAction, Microsoft.Azure.PowerShell.Cmdlets.App.Support.UnauthenticatedClientActionV2.CreateFrom);
            }
            if (content.Contains("GlobalValidationRedirectToProvider"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).GlobalValidationRedirectToProvider = (string) content.GetValueForProperty("GlobalValidationRedirectToProvider",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).GlobalValidationRedirectToProvider, global::System.Convert.ToString);
            }
            if (content.Contains("LoginPreserveUrlFragmentsForLogin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginPreserveUrlFragmentsForLogin = (bool?) content.GetValueForProperty("LoginPreserveUrlFragmentsForLogin",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginPreserveUrlFragmentsForLogin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LoginAllowedExternalRedirectUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginAllowedExternalRedirectUrl = (string[]) content.GetValueForProperty("LoginAllowedExternalRedirectUrl",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginAllowedExternalRedirectUrl, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CookieExpirationConvention"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).CookieExpirationConvention = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.CookieExpirationConvention?) content.GetValueForProperty("CookieExpirationConvention",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).CookieExpirationConvention, Microsoft.Azure.PowerShell.Cmdlets.App.Support.CookieExpirationConvention.CreateFrom);
            }
            if (content.Contains("RouteLogoutEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).RouteLogoutEndpoint = (string) content.GetValueForProperty("RouteLogoutEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).RouteLogoutEndpoint, global::System.Convert.ToString);
            }
            if (content.Contains("HttpSettingRequireHttps"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).HttpSettingRequireHttps = (bool?) content.GetValueForProperty("HttpSettingRequireHttps",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).HttpSettingRequireHttps, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ForwardProxyConvention"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).ForwardProxyConvention = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.ForwardProxyConvention?) content.GetValueForProperty("ForwardProxyConvention",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).ForwardProxyConvention, Microsoft.Azure.PowerShell.Cmdlets.App.Support.ForwardProxyConvention.CreateFrom);
            }
            if (content.Contains("RouteApiPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).RouteApiPrefix = (string) content.GetValueForProperty("RouteApiPrefix",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).RouteApiPrefix, global::System.Convert.ToString);
            }
            if (content.Contains("CookieExpirationTimeToExpiration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).CookieExpirationTimeToExpiration = (string) content.GetValueForProperty("CookieExpirationTimeToExpiration",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).CookieExpirationTimeToExpiration, global::System.Convert.ToString);
            }
            if (content.Contains("NonceValidateNonce"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).NonceValidateNonce = (bool?) content.GetValueForProperty("NonceValidateNonce",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).NonceValidateNonce, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("NonceExpirationInterval"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).NonceExpirationInterval = (string) content.GetValueForProperty("NonceExpirationInterval",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).NonceExpirationInterval, global::System.Convert.ToString);
            }
            if (content.Contains("ForwardProxyCustomHostHeaderName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).ForwardProxyCustomHostHeaderName = (string) content.GetValueForProperty("ForwardProxyCustomHostHeaderName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).ForwardProxyCustomHostHeaderName, global::System.Convert.ToString);
            }
            if (content.Contains("ForwardProxyCustomProtoHeaderName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).ForwardProxyCustomProtoHeaderName = (string) content.GetValueForProperty("ForwardProxyCustomProtoHeaderName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).ForwardProxyCustomProtoHeaderName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.AuthConfigProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AuthConfigProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Platform"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).Platform = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthPlatform) content.GetValueForProperty("Platform",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).Platform, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.AuthPlatformTypeConverter.ConvertFrom);
            }
            if (content.Contains("GlobalValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).GlobalValidation = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IGlobalValidation) content.GetValueForProperty("GlobalValidation",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).GlobalValidation, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.GlobalValidationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Login"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).Login = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ILogin) content.GetValueForProperty("Login",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).Login, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.LoginTypeConverter.ConvertFrom);
            }
            if (content.Contains("HttpSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).HttpSetting = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettings) content.GetValueForProperty("HttpSetting",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).HttpSetting, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.HttpSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityProvider"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).IdentityProvider = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IIdentityProviders) content.GetValueForProperty("IdentityProvider",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).IdentityProvider, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IdentityProvidersTypeConverter.ConvertFrom);
            }
            if (content.Contains("GlobalValidationExcludedPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).GlobalValidationExcludedPath = (string[]) content.GetValueForProperty("GlobalValidationExcludedPath",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).GlobalValidationExcludedPath, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LoginRoute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginRoute = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ILoginRoutes) content.GetValueForProperty("LoginRoute",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginRoute, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.LoginRoutesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LoginCookieExpiration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginCookieExpiration = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICookieExpiration) content.GetValueForProperty("LoginCookieExpiration",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginCookieExpiration, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.CookieExpirationTypeConverter.ConvertFrom);
            }
            if (content.Contains("LoginNonce"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginNonce = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.INonce) content.GetValueForProperty("LoginNonce",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginNonce, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.NonceTypeConverter.ConvertFrom);
            }
            if (content.Contains("HttpSettingRoute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).HttpSettingRoute = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsRoutes) content.GetValueForProperty("HttpSettingRoute",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).HttpSettingRoute, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.HttpSettingsRoutesTypeConverter.ConvertFrom);
            }
            if (content.Contains("HttpSettingForwardProxy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).HttpSettingForwardProxy = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IForwardProxy) content.GetValueForProperty("HttpSettingForwardProxy",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).HttpSettingForwardProxy, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ForwardProxyTypeConverter.ConvertFrom);
            }
            if (content.Contains("PlatformEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).PlatformEnabled = (bool?) content.GetValueForProperty("PlatformEnabled",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).PlatformEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PlatformRuntimeVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).PlatformRuntimeVersion = (string) content.GetValueForProperty("PlatformRuntimeVersion",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).PlatformRuntimeVersion, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalValidationUnauthenticatedClientAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).GlobalValidationUnauthenticatedClientAction = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.UnauthenticatedClientActionV2?) content.GetValueForProperty("GlobalValidationUnauthenticatedClientAction",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).GlobalValidationUnauthenticatedClientAction, Microsoft.Azure.PowerShell.Cmdlets.App.Support.UnauthenticatedClientActionV2.CreateFrom);
            }
            if (content.Contains("GlobalValidationRedirectToProvider"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).GlobalValidationRedirectToProvider = (string) content.GetValueForProperty("GlobalValidationRedirectToProvider",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).GlobalValidationRedirectToProvider, global::System.Convert.ToString);
            }
            if (content.Contains("LoginPreserveUrlFragmentsForLogin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginPreserveUrlFragmentsForLogin = (bool?) content.GetValueForProperty("LoginPreserveUrlFragmentsForLogin",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginPreserveUrlFragmentsForLogin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LoginAllowedExternalRedirectUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginAllowedExternalRedirectUrl = (string[]) content.GetValueForProperty("LoginAllowedExternalRedirectUrl",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).LoginAllowedExternalRedirectUrl, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CookieExpirationConvention"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).CookieExpirationConvention = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.CookieExpirationConvention?) content.GetValueForProperty("CookieExpirationConvention",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).CookieExpirationConvention, Microsoft.Azure.PowerShell.Cmdlets.App.Support.CookieExpirationConvention.CreateFrom);
            }
            if (content.Contains("RouteLogoutEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).RouteLogoutEndpoint = (string) content.GetValueForProperty("RouteLogoutEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).RouteLogoutEndpoint, global::System.Convert.ToString);
            }
            if (content.Contains("HttpSettingRequireHttps"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).HttpSettingRequireHttps = (bool?) content.GetValueForProperty("HttpSettingRequireHttps",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).HttpSettingRequireHttps, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ForwardProxyConvention"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).ForwardProxyConvention = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.ForwardProxyConvention?) content.GetValueForProperty("ForwardProxyConvention",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).ForwardProxyConvention, Microsoft.Azure.PowerShell.Cmdlets.App.Support.ForwardProxyConvention.CreateFrom);
            }
            if (content.Contains("RouteApiPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).RouteApiPrefix = (string) content.GetValueForProperty("RouteApiPrefix",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).RouteApiPrefix, global::System.Convert.ToString);
            }
            if (content.Contains("CookieExpirationTimeToExpiration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).CookieExpirationTimeToExpiration = (string) content.GetValueForProperty("CookieExpirationTimeToExpiration",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).CookieExpirationTimeToExpiration, global::System.Convert.ToString);
            }
            if (content.Contains("NonceValidateNonce"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).NonceValidateNonce = (bool?) content.GetValueForProperty("NonceValidateNonce",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).NonceValidateNonce, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("NonceExpirationInterval"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).NonceExpirationInterval = (string) content.GetValueForProperty("NonceExpirationInterval",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).NonceExpirationInterval, global::System.Convert.ToString);
            }
            if (content.Contains("ForwardProxyCustomHostHeaderName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).ForwardProxyCustomHostHeaderName = (string) content.GetValueForProperty("ForwardProxyCustomHostHeaderName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).ForwardProxyCustomHostHeaderName, global::System.Convert.ToString);
            }
            if (content.Contains("ForwardProxyCustomProtoHeaderName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).ForwardProxyCustomProtoHeaderName = (string) content.GetValueForProperty("ForwardProxyCustomProtoHeaderName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigPropertiesInternal)this).ForwardProxyCustomProtoHeaderName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.AuthConfigProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AuthConfigProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.AuthConfigProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AuthConfigProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AuthConfigProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AuthConfigProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthConfigProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// AuthConfig resource specific properties
    [System.ComponentModel.TypeConverter(typeof(AuthConfigPropertiesTypeConverter))]
    public partial interface IAuthConfigProperties

    {

    }
}