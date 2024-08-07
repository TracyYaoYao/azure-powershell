// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support
{

    /// <summary>
    /// The status of the cluster provisioning. The three terminal states are: Succeeded, Failed and Canceled
    /// </summary>
    public partial struct ClusterProvisioningState :
        System.IEquatable<ClusterProvisioningState>
    {
        /// <summary>The cluster provisioning was canceled.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ClusterProvisioningState Canceled = @"Canceled";

        /// <summary>The cluster provisioning failed.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ClusterProvisioningState Failed = @"Failed";

        /// <summary>The cluster provisioning was inprogress.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ClusterProvisioningState InProgress = @"InProgress";

        /// <summary>The cluster provisioning succeeded.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ClusterProvisioningState Succeeded = @"Succeeded";

        /// <summary>the value for an instance of the <see cref="ClusterProvisioningState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="ClusterProvisioningState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ClusterProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ClusterProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ClusterProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ClusterProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ClusterProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ClusterProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ClusterProvisioningState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ClusterProvisioningState && Equals((ClusterProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum ClusterProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ClusterProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ClusterProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ClusterProvisioningState" />.</param>

        public static implicit operator ClusterProvisioningState(string value)
        {
            return new ClusterProvisioningState(value);
        }

        /// <summary>Implicit operator to convert ClusterProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ClusterProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ClusterProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ClusterProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ClusterProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ClusterProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ClusterProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ClusterProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.ClusterProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}