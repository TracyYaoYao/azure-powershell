// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>ApiKVReference resource specific properties</summary>
    [System.ComponentModel.TypeConverter(typeof(ApiKvReferencePropertiesTypeConverter))]
    public partial class ApiKvReferenceProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ApiKvReferenceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ApiKvReferenceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IManagedServiceIdentity) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Reference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).Reference = (string) content.GetValueForProperty("Reference",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).Reference, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ResolveStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ResolveStatus.CreateFrom);
            }
            if (content.Contains("VaultName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).VaultName = (string) content.GetValueForProperty("VaultName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).VaultName, global::System.Convert.ToString);
            }
            if (content.Contains("SecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).SecretName = (string) content.GetValueForProperty("SecretName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).SecretName, global::System.Convert.ToString);
            }
            if (content.Contains("SecretVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).SecretVersion = (string) content.GetValueForProperty("SecretVersion",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).SecretVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).Detail = (string) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).Detail, global::System.Convert.ToString);
            }
            if (content.Contains("Source"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ConfigReferenceSource?) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ConfigReferenceSource.CreateFrom);
            }
            if (content.Contains("ActiveVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).ActiveVersion = (string) content.GetValueForProperty("ActiveVersion",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).ActiveVersion, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTypeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityTypeType = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ManagedServiceIdentityType?) content.GetValueForProperty("IdentityTypeType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityTypeType, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ManagedServiceIdentityType.CreateFrom);
            }
            if (content.Contains("IdentityTypeTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityTypeTenantId = (string) content.GetValueForProperty("IdentityTypeTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityTypeTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTypePrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityTypePrincipalId = (string) content.GetValueForProperty("IdentityTypePrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityTypePrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTypeUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityTypeUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IManagedServiceIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityTypeUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityTypeUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ManagedServiceIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ApiKvReferenceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ApiKvReferenceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IManagedServiceIdentity) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Reference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).Reference = (string) content.GetValueForProperty("Reference",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).Reference, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ResolveStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ResolveStatus.CreateFrom);
            }
            if (content.Contains("VaultName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).VaultName = (string) content.GetValueForProperty("VaultName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).VaultName, global::System.Convert.ToString);
            }
            if (content.Contains("SecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).SecretName = (string) content.GetValueForProperty("SecretName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).SecretName, global::System.Convert.ToString);
            }
            if (content.Contains("SecretVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).SecretVersion = (string) content.GetValueForProperty("SecretVersion",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).SecretVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).Detail = (string) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).Detail, global::System.Convert.ToString);
            }
            if (content.Contains("Source"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).Source = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ConfigReferenceSource?) content.GetValueForProperty("Source",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).Source, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ConfigReferenceSource.CreateFrom);
            }
            if (content.Contains("ActiveVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).ActiveVersion = (string) content.GetValueForProperty("ActiveVersion",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).ActiveVersion, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTypeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityTypeType = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ManagedServiceIdentityType?) content.GetValueForProperty("IdentityTypeType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityTypeType, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ManagedServiceIdentityType.CreateFrom);
            }
            if (content.Contains("IdentityTypeTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityTypeTenantId = (string) content.GetValueForProperty("IdentityTypeTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityTypeTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTypePrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityTypePrincipalId = (string) content.GetValueForProperty("IdentityTypePrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityTypePrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTypeUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityTypeUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IManagedServiceIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityTypeUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferencePropertiesInternal)this).IdentityTypeUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ManagedServiceIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ApiKvReferenceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferenceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferenceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ApiKvReferenceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ApiKvReferenceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferenceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferenceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ApiKvReferenceProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ApiKvReferenceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ApiKvReferenceProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IApiKvReferenceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// ApiKVReference resource specific properties
    [System.ComponentModel.TypeConverter(typeof(ApiKvReferencePropertiesTypeConverter))]
    public partial interface IApiKvReferenceProperties

    {

    }
}