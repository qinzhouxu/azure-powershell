// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>
    /// Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled.
    /// </summary>
    public partial struct LargeFileSharesState :
        System.IEquatable<LargeFileSharesState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LargeFileSharesState Disabled = @"Disabled";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LargeFileSharesState Enabled = @"Enabled";

        /// <summary>the value for an instance of the <see cref="LargeFileSharesState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to LargeFileSharesState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LargeFileSharesState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new LargeFileSharesState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type LargeFileSharesState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LargeFileSharesState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type LargeFileSharesState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is LargeFileSharesState && Equals((LargeFileSharesState)obj);
        }

        /// <summary>Returns hashCode for enum LargeFileSharesState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="LargeFileSharesState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private LargeFileSharesState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for LargeFileSharesState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to LargeFileSharesState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LargeFileSharesState" />.</param>

        public static implicit operator LargeFileSharesState(string value)
        {
            return new LargeFileSharesState(value);
        }

        /// <summary>Implicit operator to convert LargeFileSharesState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="LargeFileSharesState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LargeFileSharesState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum LargeFileSharesState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LargeFileSharesState e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LargeFileSharesState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum LargeFileSharesState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LargeFileSharesState e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LargeFileSharesState e2)
        {
            return e2.Equals(e1);
        }
    }
}