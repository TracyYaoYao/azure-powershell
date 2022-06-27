// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Extensions;

    /// <summary>Collector policy resource.</summary>
    public partial class CollectorPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyInternal,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ProxyResource();

        /// <summary>Emission policies.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IEmissionPoliciesPropertiesFormat[] EmissionPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)Property).EmissionPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)Property).EmissionPolicy = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; }

        /// <summary>Azure resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IProxyResourceInternal)__proxyResource).Id; }

        /// <summary>Ingestion Sources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IIngestionSourcesPropertiesFormat[] IngestionPolicyIngestionSource { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)Property).IngestionPolicyIngestionSource; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)Property).IngestionPolicyIngestionSource = value ?? null /* arrayOf */; }

        /// <summary>The ingestion type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.IngestionType? IngestionPolicyIngestionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)Property).IngestionPolicyIngestionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)Property).IngestionPolicyIngestionType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.IngestionType)""); }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyInternal.Etag { get => this._etag; set { {_etag = value;} } }

        /// <summary>Internal Acessors for IngestionPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IIngestionPolicyPropertiesFormat Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyInternal.IngestionPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)Property).IngestionPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)Property).IngestionPolicy = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormat Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.CollectorPolicyPropertiesFormat()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemData Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IProxyResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IProxyResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IProxyResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IProxyResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IProxyResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IProxyResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IProxyResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IProxyResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IProxyResourceInternal)__proxyResource).Type = value; }

        /// <summary>Azure resource name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IProxyResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormat _property;

        /// <summary>Properties of the Collector Policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormat Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.CollectorPolicyPropertiesFormat()); set => this._property = value; }

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormatInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemData _systemData;

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType)""); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType)""); }

        /// <summary>Azure resource type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IProxyResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="CollectorPolicy" /> instance.</summary>
        public CollectorPolicy()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Collector policy resource.
    public partial interface ICollectorPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IProxyResource
    {
        /// <summary>Emission policies.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Emission policies.",
        SerializedName = @"emissionPolicies",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IEmissionPoliciesPropertiesFormat) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IEmissionPoliciesPropertiesFormat[] EmissionPolicy { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A unique read-only string that changes whenever the resource is updated.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get;  }
        /// <summary>Ingestion Sources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Ingestion Sources.",
        SerializedName = @"ingestionSources",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IIngestionSourcesPropertiesFormat) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IIngestionSourcesPropertiesFormat[] IngestionPolicyIngestionSource { get; set; }
        /// <summary>The ingestion type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ingestion type.",
        SerializedName = @"ingestionType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.IngestionType) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.IngestionType? IngestionPolicyIngestionType { get; set; }
        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }

    }
    /// Collector policy resource.
    internal partial interface ICollectorPolicyInternal :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IProxyResourceInternal
    {
        /// <summary>Emission policies.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IEmissionPoliciesPropertiesFormat[] EmissionPolicy { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        string Etag { get; set; }
        /// <summary>Ingestion policies.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IIngestionPolicyPropertiesFormat IngestionPolicy { get; set; }
        /// <summary>Ingestion Sources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.IIngestionSourcesPropertiesFormat[] IngestionPolicyIngestionSource { get; set; }
        /// <summary>The ingestion type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.IngestionType? IngestionPolicyIngestionType { get; set; }
        /// <summary>Properties of the Collector Policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicyPropertiesFormat Property { get; set; }
        /// <summary>The provisioning state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }

    }
}