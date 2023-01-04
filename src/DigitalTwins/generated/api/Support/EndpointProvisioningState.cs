// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support
{

    /// <summary>The provisioning state.</summary>
    public partial struct EndpointProvisioningState :
        System.IEquatable<EndpointProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState Canceled = @"Canceled";

        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState Deleted = @"Deleted";

        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState Disabled = @"Disabled";

        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState Moving = @"Moving";

        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState Provisioning = @"Provisioning";

        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState Restoring = @"Restoring";

        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState Suspending = @"Suspending";

        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState Updating = @"Updating";

        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState Warning = @"Warning";

        /// <summary>the value for an instance of the <see cref="EndpointProvisioningState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to EndpointProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="EndpointProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new EndpointProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="EndpointProvisioningState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private EndpointProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type EndpointProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type EndpointProvisioningState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is EndpointProvisioningState && Equals((EndpointProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum EndpointProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for EndpointProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to EndpointProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="EndpointProvisioningState" />.</param>

        public static implicit operator EndpointProvisioningState(string value)
        {
            return new EndpointProvisioningState(value);
        }

        /// <summary>Implicit operator to convert EndpointProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="EndpointProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum EndpointProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum EndpointProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Support.EndpointProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}