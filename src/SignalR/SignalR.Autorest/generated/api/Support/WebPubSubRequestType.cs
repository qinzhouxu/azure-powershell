// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support
{

    /// <summary>The incoming request type to the service</summary>
    public partial struct WebPubSubRequestType :
        System.IEquatable<WebPubSubRequestType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType ClientConnection = @"ClientConnection";

        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType Restapi = @"RESTAPI";

        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType ServerConnection = @"ServerConnection";

        public static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType Trace = @"Trace";

        /// <summary>the value for an instance of the <see cref="WebPubSubRequestType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to WebPubSubRequestType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WebPubSubRequestType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new WebPubSubRequestType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type WebPubSubRequestType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type WebPubSubRequestType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is WebPubSubRequestType && Equals((WebPubSubRequestType)obj);
        }

        /// <summary>Returns hashCode for enum WebPubSubRequestType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for WebPubSubRequestType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="WebPubSubRequestType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private WebPubSubRequestType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to WebPubSubRequestType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WebPubSubRequestType" />.</param>

        public static implicit operator WebPubSubRequestType(string value)
        {
            return new WebPubSubRequestType(value);
        }

        /// <summary>Implicit operator to convert WebPubSubRequestType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="WebPubSubRequestType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum WebPubSubRequestType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType e1, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum WebPubSubRequestType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType e1, Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.WebPubSubRequestType e2)
        {
            return e2.Equals(e1);
        }
    }
}