// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501
{
    using Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.PowerShell;

    /// <summary>An Application Insights component daily data volume cap status</summary>
    [System.ComponentModel.TypeConverter(typeof(ApplicationInsightsComponentFeatureTypeConverter))]
    public partial class ApplicationInsightsComponentFeature
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.ApplicationInsightsComponentFeature"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ApplicationInsightsComponentFeature(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("FeatureName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).FeatureName = (string) content.GetValueForProperty("FeatureName",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).FeatureName, global::System.Convert.ToString);
            }
            if (content.Contains("MeterId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).MeterId = (string) content.GetValueForProperty("MeterId",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).MeterId, global::System.Convert.ToString);
            }
            if (content.Contains("MeterRateFrequency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).MeterRateFrequency = (string) content.GetValueForProperty("MeterRateFrequency",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).MeterRateFrequency, global::System.Convert.ToString);
            }
            if (content.Contains("ResouceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).ResouceId = (string) content.GetValueForProperty("ResouceId",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).ResouceId, global::System.Convert.ToString);
            }
            if (content.Contains("IsHidden"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).IsHidden = (bool?) content.GetValueForProperty("IsHidden",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).IsHidden, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Capability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).Capability = (Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapability[]) content.GetValueForProperty("Capability",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).Capability, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapability>(__y, Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.ApplicationInsightsComponentFeatureCapabilityTypeConverter.ConvertFrom));
            }
            if (content.Contains("Title"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).Title = (string) content.GetValueForProperty("Title",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).Title, global::System.Convert.ToString);
            }
            if (content.Contains("IsMainFeature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).IsMainFeature = (bool?) content.GetValueForProperty("IsMainFeature",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).IsMainFeature, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SupportedAddonFeature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).SupportedAddonFeature = (string) content.GetValueForProperty("SupportedAddonFeature",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).SupportedAddonFeature, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.ApplicationInsightsComponentFeature"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ApplicationInsightsComponentFeature(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("FeatureName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).FeatureName = (string) content.GetValueForProperty("FeatureName",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).FeatureName, global::System.Convert.ToString);
            }
            if (content.Contains("MeterId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).MeterId = (string) content.GetValueForProperty("MeterId",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).MeterId, global::System.Convert.ToString);
            }
            if (content.Contains("MeterRateFrequency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).MeterRateFrequency = (string) content.GetValueForProperty("MeterRateFrequency",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).MeterRateFrequency, global::System.Convert.ToString);
            }
            if (content.Contains("ResouceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).ResouceId = (string) content.GetValueForProperty("ResouceId",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).ResouceId, global::System.Convert.ToString);
            }
            if (content.Contains("IsHidden"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).IsHidden = (bool?) content.GetValueForProperty("IsHidden",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).IsHidden, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Capability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).Capability = (Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapability[]) content.GetValueForProperty("Capability",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).Capability, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureCapability>(__y, Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.ApplicationInsightsComponentFeatureCapabilityTypeConverter.ConvertFrom));
            }
            if (content.Contains("Title"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).Title = (string) content.GetValueForProperty("Title",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).Title, global::System.Convert.ToString);
            }
            if (content.Contains("IsMainFeature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).IsMainFeature = (bool?) content.GetValueForProperty("IsMainFeature",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).IsMainFeature, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SupportedAddonFeature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).SupportedAddonFeature = (string) content.GetValueForProperty("SupportedAddonFeature",((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeatureInternal)this).SupportedAddonFeature, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.ApplicationInsightsComponentFeature"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeature"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeature DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ApplicationInsightsComponentFeature(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.ApplicationInsightsComponentFeature"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeature"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeature DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ApplicationInsightsComponentFeature(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ApplicationInsightsComponentFeature" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="ApplicationInsightsComponentFeature" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20150501.IApplicationInsightsComponentFeature FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// An Application Insights component daily data volume cap status
    [System.ComponentModel.TypeConverter(typeof(ApplicationInsightsComponentFeatureTypeConverter))]
    public partial interface IApplicationInsightsComponentFeature

    {

    }
}