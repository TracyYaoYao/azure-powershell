// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>
    /// Defines an early termination policy based on running averages of the primary metric of all runs
    /// </summary>
    public partial class MedianStoppingPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMedianStoppingPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMedianStoppingPolicyInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IEarlyTerminationPolicy"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IEarlyTerminationPolicy __earlyTerminationPolicy = new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.EarlyTerminationPolicy();

        /// <summary>Number of intervals by which to delay the first evaluation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public int? DelayEvaluation { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IEarlyTerminationPolicyInternal)__earlyTerminationPolicy).DelayEvaluation; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IEarlyTerminationPolicyInternal)__earlyTerminationPolicy).DelayEvaluation = value ?? default(int); }

        /// <summary>Interval (number of runs) between policy evaluations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public int? EvaluationInterval { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IEarlyTerminationPolicyInternal)__earlyTerminationPolicy).EvaluationInterval; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IEarlyTerminationPolicyInternal)__earlyTerminationPolicy).EvaluationInterval = value ?? default(int); }

        /// <summary>[Required] Name of policy configuration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EarlyTerminationPolicyType PolicyType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IEarlyTerminationPolicyInternal)__earlyTerminationPolicy).PolicyType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IEarlyTerminationPolicyInternal)__earlyTerminationPolicy).PolicyType = value ; }

        /// <summary>Creates an new <see cref="MedianStoppingPolicy" /> instance.</summary>
        public MedianStoppingPolicy()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__earlyTerminationPolicy), __earlyTerminationPolicy);
            await eventListener.AssertObjectIsValid(nameof(__earlyTerminationPolicy), __earlyTerminationPolicy);
        }
    }
    /// Defines an early termination policy based on running averages of the primary metric of all runs
    public partial interface IMedianStoppingPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IEarlyTerminationPolicy
    {

    }
    /// Defines an early termination policy based on running averages of the primary metric of all runs
    internal partial interface IMedianStoppingPolicyInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IEarlyTerminationPolicyInternal
    {

    }
}