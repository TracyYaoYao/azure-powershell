// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Response for ApplicationGatewayAvailableWafRuleSets API service call.
    /// </summary>
    public partial class ApplicationGatewayAvailableWafRuleSetsResult
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayAvailableWafRuleSetsResult class.
        /// </summary>
        public ApplicationGatewayAvailableWafRuleSetsResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayAvailableWafRuleSetsResult class.
        /// </summary>

        /// <param name="value">The list of application gateway rule sets.
        /// </param>
        public ApplicationGatewayAvailableWafRuleSetsResult(System.Collections.Generic.IList<ApplicationGatewayFirewallRuleSet> value = default(System.Collections.Generic.IList<ApplicationGatewayFirewallRuleSet>))

        {
            this.Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the list of application gateway rule sets.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<ApplicationGatewayFirewallRuleSet> Value {get; set; }
    }
}