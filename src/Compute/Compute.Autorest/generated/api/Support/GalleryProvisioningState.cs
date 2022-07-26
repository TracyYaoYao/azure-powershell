// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Support
{

    /// <summary>The provisioning state, which only appears in the response.</summary>
    public partial struct GalleryProvisioningState :
        System.IEquatable<GalleryProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryProvisioningState Creating = @"Creating";

        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryProvisioningState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryProvisioningState Migrating = @"Migrating";

        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryProvisioningState Updating = @"Updating";

        /// <summary>the value for an instance of the <see cref="GalleryProvisioningState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to GalleryProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="GalleryProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new GalleryProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type GalleryProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type GalleryProvisioningState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is GalleryProvisioningState && Equals((GalleryProvisioningState)obj);
        }

        /// <summary>Creates an instance of the <see cref="GalleryProvisioningState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private GalleryProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum GalleryProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for GalleryProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to GalleryProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="GalleryProvisioningState" />.</param>

        public static implicit operator GalleryProvisioningState(string value)
        {
            return new GalleryProvisioningState(value);
        }

        /// <summary>Implicit operator to convert GalleryProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="GalleryProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum GalleryProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum GalleryProvisioningState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GalleryProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}