// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support
{

    /// <summary>Aggregate state of Arc Extensions across the nodes in this HCI cluster.</summary>
    public partial struct ExtensionAggregateState :
        System.IEquatable<ExtensionAggregateState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState Canceled = @"Canceled";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState Connected = @"Connected";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState Creating = @"Creating";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState Deleted = @"Deleted";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState Disconnected = @"Disconnected";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState Error = @"Error";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState InProgress = @"InProgress";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState Moving = @"Moving";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState NotSpecified = @"NotSpecified";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState PartiallyConnected = @"PartiallyConnected";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState PartiallySucceeded = @"PartiallySucceeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState Updating = @"Updating";

        /// <summary>the value for an instance of the <see cref="ExtensionAggregateState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ExtensionAggregateState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ExtensionAggregateState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ExtensionAggregateState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ExtensionAggregateState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ExtensionAggregateState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ExtensionAggregateState && Equals((ExtensionAggregateState)obj);
        }

        /// <summary>Creates an instance of the <see cref="ExtensionAggregateState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ExtensionAggregateState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum ExtensionAggregateState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ExtensionAggregateState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ExtensionAggregateState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ExtensionAggregateState" />.</param>

        public static implicit operator ExtensionAggregateState(string value)
        {
            return new ExtensionAggregateState(value);
        }

        /// <summary>Implicit operator to convert ExtensionAggregateState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ExtensionAggregateState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ExtensionAggregateState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState e1, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ExtensionAggregateState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState e1, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState e2)
        {
            return e2.Equals(e1);
        }
    }
}