// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Extensions;

    /// <summary>Key-value pairs that allow grouping/filtering individual tests.</summary>
    public partial class PrecheckResultTags :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IPrecheckResultTags,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IPrecheckResultTagsInternal
    {

        /// <summary>Backing field for <see cref="Key" /> property.</summary>
        private string _key;

        /// <summary>Key that allow grouping/filtering individual tests.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public string Key { get => this._key; set => this._key = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>Value of the key that allow grouping/filtering individual tests.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PrecheckResultTags" /> instance.</summary>
        public PrecheckResultTags()
        {

        }
    }
    /// Key-value pairs that allow grouping/filtering individual tests.
    public partial interface IPrecheckResultTags :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.IJsonSerializable
    {
        /// <summary>Key that allow grouping/filtering individual tests.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Key that allow grouping/filtering individual tests.",
        SerializedName = @"key",
        PossibleTypes = new [] { typeof(string) })]
        string Key { get; set; }
        /// <summary>Value of the key that allow grouping/filtering individual tests.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value of the key that allow grouping/filtering individual tests.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// Key-value pairs that allow grouping/filtering individual tests.
    internal partial interface IPrecheckResultTagsInternal

    {
        /// <summary>Key that allow grouping/filtering individual tests.</summary>
        string Key { get; set; }
        /// <summary>Value of the key that allow grouping/filtering individual tests.</summary>
        string Value { get; set; }

    }
}