// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DefaultAction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DefaultAction
    {
        [EnumMember(Value = "Allow")]
        Allow,
        [EnumMember(Value = "Deny")]
        Deny
    }
    internal static class DefaultActionEnumExtension
    {
        internal static string ToSerializedValue(this DefaultAction? value)
        {
            return value == null ? null : ((DefaultAction)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DefaultAction value)
        {
            switch( value )
            {
                case DefaultAction.Allow:
                    return "Allow";
                case DefaultAction.Deny:
                    return "Deny";
            }
            return null;
        }

        internal static DefaultAction? ParseDefaultAction(this string value)
        {
            switch( value )
            {
                case "Allow":
                    return DefaultAction.Allow;
                case "Deny":
                    return DefaultAction.Deny;
            }
            return null;
        }
    }
}
