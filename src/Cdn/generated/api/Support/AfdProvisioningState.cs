// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support
{

    /// <summary>Provisioning status</summary>
    public partial struct AfdProvisioningState :
        System.IEquatable<AfdProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState Creating = @"Creating";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState Updating = @"Updating";

        /// <summary>the value for an instance of the <see cref="AfdProvisioningState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AfdProvisioningState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AfdProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AfdProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AfdProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AfdProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AfdProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AfdProvisioningState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AfdProvisioningState && Equals((AfdProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum AfdProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AfdProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AfdProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AfdProvisioningState" />.</param>

        public static implicit operator AfdProvisioningState(string value)
        {
            return new AfdProvisioningState(value);
        }

        /// <summary>Implicit operator to convert AfdProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AfdProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AfdProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AfdProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}