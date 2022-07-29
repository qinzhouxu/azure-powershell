// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>
    /// The ImmutabilityPolicy state of a blob container, possible values include: Locked and Unlocked.
    /// </summary>
    public partial struct ImmutabilityPolicyState :
        System.IEquatable<ImmutabilityPolicyState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState Locked = @"Locked";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState Unlocked = @"Unlocked";

        /// <summary>the value for an instance of the <see cref="ImmutabilityPolicyState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ImmutabilityPolicyState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ImmutabilityPolicyState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ImmutabilityPolicyState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ImmutabilityPolicyState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ImmutabilityPolicyState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ImmutabilityPolicyState && Equals((ImmutabilityPolicyState)obj);
        }

        /// <summary>Returns hashCode for enum ImmutabilityPolicyState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ImmutabilityPolicyState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ImmutabilityPolicyState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ImmutabilityPolicyState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ImmutabilityPolicyState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ImmutabilityPolicyState" />.</param>

        public static implicit operator ImmutabilityPolicyState(string value)
        {
            return new ImmutabilityPolicyState(value);
        }

        /// <summary>Implicit operator to convert ImmutabilityPolicyState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ImmutabilityPolicyState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ImmutabilityPolicyState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ImmutabilityPolicyState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyState e2)
        {
            return e2.Equals(e1);
        }
    }
}