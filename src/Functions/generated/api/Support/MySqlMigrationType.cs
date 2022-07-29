// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>The type of migration operation to be done</summary>
    public partial struct MySqlMigrationType :
        System.IEquatable<MySqlMigrationType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MySqlMigrationType LocalToRemote = @"LocalToRemote";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MySqlMigrationType RemoteToLocal = @"RemoteToLocal";

        /// <summary>the value for an instance of the <see cref="MySqlMigrationType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to MySqlMigrationType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MySqlMigrationType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new MySqlMigrationType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type MySqlMigrationType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MySqlMigrationType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type MySqlMigrationType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is MySqlMigrationType && Equals((MySqlMigrationType)obj);
        }

        /// <summary>Returns hashCode for enum MySqlMigrationType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="MySqlMigrationType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private MySqlMigrationType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for MySqlMigrationType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to MySqlMigrationType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MySqlMigrationType" />.</param>

        public static implicit operator MySqlMigrationType(string value)
        {
            return new MySqlMigrationType(value);
        }

        /// <summary>Implicit operator to convert MySqlMigrationType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="MySqlMigrationType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MySqlMigrationType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum MySqlMigrationType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MySqlMigrationType e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MySqlMigrationType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum MySqlMigrationType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MySqlMigrationType e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MySqlMigrationType e2)
        {
            return e2.Equals(e1);
        }
    }
}