
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for Kubernetes.
.Description
Create an in-memory object for Kubernetes.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Models.Api20220501.Kubernetes
.Link
https://docs.microsoft.com/powershell/module/az.MLWorkspace/new-AzMLWorkspaceKubernetesObject
#>
function New-AzMLWorkspaceKubernetesObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Models.Api20220501.Kubernetes')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="The description of the Machine Learning compute.")]
        [string]
        $Description,
        [Parameter(HelpMessage="Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for authentication.")]
        [bool]
        $DisableLocalAuth,
        [Parameter(HelpMessage="ARM resource id of the underlying compute.")]
        [string]
        $ResourceId,
        [Parameter(HelpMessage="Default instance type.")]
        [string]
        $DefaultInstanceType,
        [Parameter(HelpMessage="Extension instance release train.")]
        [string]
        $ExtensionInstanceReleaseTrain,
        [Parameter(HelpMessage="Extension principal-id.")]
        [string]
        $ExtensionPrincipalId,
        # [Parameter(HelpMessage="Instance Type Schema.")]
        # [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Models.Api20220501.IKubernetesPropertiesInstanceTypes]
        # $InstanceType,
        [Parameter(HelpMessage="Node Selector.")]
        [hashtable]
        $InstanceNodeSelector,
        [Parameter(HelpMessage="Resource limits for this instance type.")]
        [hashtable]
        $InstanceLimit,
        [Parameter(HelpMessage="Resource requests for this instance type.")]
        [hashtable]
        $InstanceRequest,
        [Parameter(HelpMessage="Compute namespace.")]
        [string]
        $Namespace,
        [Parameter(HelpMessage="Relay connection string.")]
        [string]
        $RelayConnectionString,
        [Parameter(HelpMessage="ServiceBus connection string.")]
        [string]
        $ServiceBusConnectionString,
        [Parameter(HelpMessage="VC name.")]
        [string]
        $VcName
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Models.Api20220501.Kubernetes]::New()
        $Object.Type = 'Kubernetes'

        if ($PSBoundParameters.ContainsKey('Description')) {
            $Object.Description = $Description
        }
        if ($PSBoundParameters.ContainsKey('DisableLocalAuth')) {
            $Object.DisableLocalAuth = $DisableLocalAuth
        }
        if ($PSBoundParameters.ContainsKey('ResourceId')) {
            $Object.ResourceId = $ResourceId
        }
        if ($PSBoundParameters.ContainsKey('DefaultInstanceType')) {
            $Object.DefaultInstanceType = $DefaultInstanceType
        }
        if ($PSBoundParameters.ContainsKey('ExtensionInstanceReleaseTrain')) {
            $Object.ExtensionInstanceReleaseTrain = $ExtensionInstanceReleaseTrain
        }
        if ($PSBoundParameters.ContainsKey('ExtensionPrincipalId')) {
            $Object.ExtensionPrincipalId = $ExtensionPrincipalId
        }
        # if ($PSBoundParameters.ContainsKey('InstanceType')) {
        #     $Object.InstanceType = $InstanceType
        # }
        if ($PSBoundParameters.ContainsKey('InstanceNodeSelector'))
        {
            $NodeSelectorObj = [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Models.Api20220501.InstanceTypeSchemaNodeSelector]::New()
            $NodeSelectorObj.CopyFrom($InstanceNodeSelector)
        }
        if ($PSBoundParameters.ContainsKey('InstanceLimit'))
        {
            $ResourceLimitObj = [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Models.Api20220501.InstanceResourceSchema]::New()
            $ResourceLimitObj.CopyFrom($InstanceLimit)
        }
        if ($PSBoundParameters.ContainsKey('InstanceRequest'))
        {
            $ResourceRequestObj = [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Models.Api20220501.InstanceResourceSchema]::New()
            $ResourceRequestObj.CopyFrom($InstanceRequest)
        }
        if ($PSBoundParameters.ContainsKey('InstanceNodeSelector') -or $PSBoundParameters.ContainsKey('InstanceLimit') -or $PSBoundParameters.ContainsKey('InstanceRequest'))
        {
            $InstanceType = [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Models.Api20220501.InstanceTypeSchema]::New() 
            $KubInstance = [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Models.Api20220501.KubernetesPropertiesInstanceTypes]::New()
            $InstanceType.NodeSelector = $NodeSelectorObj
            $InstanceType.ResourceLimit = $ResourceLimitObj
            $InstanceType.ResourceRequest = $ResourceRequestObj
            if ($PSBoundParameters.ContainsKey('DefaultInstanceType'))
            {
                $KubInstanceHash = @{$DefaultInstanceType = $InstanceType; }
            }
            else 
            {
                $KubInstanceHash = @{'defaultInstanceType' = $InstanceType; }
            }
            $KubInstance.CopyFrom($KubInstanceHash);
            $Object.InstanceType = $KubInstance
        }
        if ($PSBoundParameters.ContainsKey('Namespace')) {
            $Object.Namespace = $Namespace
        }
        if ($PSBoundParameters.ContainsKey('RelayConnectionString')) {
            $Object.RelayConnectionString = $RelayConnectionString
        }
        if ($PSBoundParameters.ContainsKey('ServiceBusConnectionString')) {
            $Object.ServiceBusConnectionString = $ServiceBusConnectionString
        }
        if ($PSBoundParameters.ContainsKey('VcName')) {
            $Object.VcName = $VcName
        }
        return $Object
    }
}

