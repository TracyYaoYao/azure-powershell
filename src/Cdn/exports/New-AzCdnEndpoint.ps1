
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
Creates a new CDN endpoint with the specified endpoint name under the specified subscription, resource group and profile.
.Description
Creates a new CDN endpoint with the specified endpoint name under the specified subscription, resource group and profile.
.Example
$origin = @{
    Name = "origin1"
    HostName = "host1.hello.com"
};
New-AzCdnEndpoint -ResourceGroupName testps-rg-da16jm -ProfileName cdn001 -Name endptest001 -Location westus -Origin $origin             

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IEndpoint
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

DELIVERYPOLICYRULE <IDeliveryRule[]>: A list of the delivery rules.
  Action <IDeliveryRuleAction1[]>: A list of actions that are executed when all the conditions of a rule are satisfied.
    Name <DeliveryRuleAction>: The name of the action for the delivery rule.
  Order <Int32>: The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition and actions listed in it will always be applied.
  [Condition <IDeliveryRuleCondition[]>]: A list of conditions that must be matched for the actions to be executed
    Name <MatchVariable>: The name of the condition for the delivery rule.
  [Name <String>]: Name of the rule

GEOFILTER <IGeoFilter[]>: List of rules defining the user's geo access within a CDN endpoint. Each geo filter defines an access rule to a specified path or content, e.g. block APAC for path /pictures/
  Action <GeoFilterActions>: Action of the geo filter, i.e. allow or block access.
  CountryCode <String[]>: Two letter country or region codes defining user country or region access in a geo filter, e.g. AU, MX, US.
  RelativePath <String>: Relative path applicable to geo filter. (e.g. '/mypictures', '/mypicture/kitty.jpg', and etc.)

ORIGIN <IDeepCreatedOrigin[]>: The source of the content being delivered via CDN.
  Name <String>: Origin name which must be unique within the endpoint. 
  [Enabled <Boolean?>]: Origin is enabled for load balancing or not. By default, origin is always enabled.
  [HostName <String>]: The address of the origin. It can be a domain name, IPv4 address, or IPv6 address. This should be unique across all origins in an endpoint.
  [HttpPort <Int32?>]: The value of the HTTP port. Must be between 1 and 65535.
  [HttpsPort <Int32?>]: The value of the HTTPS port. Must be between 1 and 65535.
  [OriginHostHeader <String>]: The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default.
  [Priority <Int32?>]: Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if any lower priority origin is healthy.Must be between 1 and 5.
  [PrivateLinkAlias <String>]: The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'
  [PrivateLinkApprovalMessage <String>]: A custom message to be included in the approval request to connect to the Private Link.
  [PrivateLinkLocation <String>]: The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated
  [PrivateLinkResourceId <String>]: The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'
  [Weight <Int32?>]: Weight of the origin in given origin group for load balancing. Must be between 1 and 1000

ORIGINGROUP <IDeepCreatedOriginGroup[]>: The origin groups comprising of origins that are used for load balancing the traffic based on availability.
  Name <String>: Origin group name which must be unique within the endpoint.
  [HealthProbeSetting <IHealthProbeParameters>]: Health probe settings to the origin that is used to determine the health of the origin.
    [ProbeIntervalInSecond <Int32?>]: The number of seconds between health probes.Default is 240sec.
    [ProbePath <String>]: The path relative to the origin that is used to determine the health of the origin.
    [ProbeProtocol <ProbeProtocol?>]: Protocol to use for health probe.
    [ProbeRequestType <HealthProbeRequestType?>]: The type of health probe request that is made.
  [Origin <IResourceReference[]>]: The source of the content being delivered via CDN within given origin group.
    [Id <String>]: Resource ID.
  [ResponseBasedOriginErrorDetectionSetting <IResponseBasedOriginErrorDetectionParameters>]: The JSON object that contains the properties to determine origin health using real requests/responses.This property is currently not supported.
    [HttpErrorRange <IHttpErrorRangeParameters[]>]: The list of Http status code ranges that are considered as server errors for origin and it is marked as unhealthy.
      [Begin <Int32?>]: The inclusive start of the http status code range.
      [End <Int32?>]: The inclusive end of the http status code range.
    [ResponseBasedDetectedErrorType <ResponseBasedDetectedErrorTypes?>]: Type of response errors for real user requests for which origin will be deemed unhealthy
    [ResponseBasedFailoverThresholdPercentage <Int32?>]: The percentage of failed requests in the sample where failover should trigger.
  [TrafficRestorationTimeToHealedOrNewEndpointsInMinute <Int32?>]: Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not supported.

URLSIGNINGKEY <IUrlSigningKey[]>: List of keys used to validate the signed URL hashes.
  KeyId <String>: Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form the hash.
  KeySourceParameterResourceGroupName <String>: Resource group of the user's Key Vault containing the secret
  KeySourceParameterSecretName <String>: The name of secret in Key Vault.
  KeySourceParameterSecretVersion <String>: The version(GUID) of secret in Key Vault.
  KeySourceParameterSubscriptionId <String>: Subscription Id of the user's Key Vault containing the secret
  KeySourceParameterVaultName <String>: The name of the user's Key Vault containing the secret
.Link
https://docs.microsoft.com/powershell/module/az.cdn/new-azcdnendpoint
#>
function New-AzCdnEndpoint {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IEndpoint])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded1', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('EndpointName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
    [System.String]
    # Name of the endpoint under the profile which is unique globally.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
    [System.String]
    # Name of the CDN profile which is unique within the resource group.
    ${ProfileName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
    [System.String]
    # Name of the Resource group within the Azure subscription.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Azure Subscription ID.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.String]
    # Resource location.
    ${Location},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.String[]]
    # List of content types on which compression applies.
    # The value should be a valid MIME type.
    ${ContentTypesToCompress},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.String]
    # Resource ID.
    ${DefaultOriginGroupId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.String]
    # User-friendly description of the policy.
    ${DeliveryPolicyDescription},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRule[]]
    # A list of the delivery rules.
    # To construct, see NOTES section for DELIVERYPOLICYRULE properties and create a hash table.
    ${DeliveryPolicyRule},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IGeoFilter[]]
    # List of rules defining the user's geo access within a CDN endpoint.
    # Each geo filter defines an access rule to a specified path or content, e.g.
    # block APAC for path /pictures/
    # To construct, see NOTES section for GEOFILTER properties and create a hash table.
    ${GeoFilter},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether content compression is enabled on CDN.
    # Default value is false.
    # If compression is enabled, content will be served as compressed if user requests for a compressed version.
    # Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.
    ${IsCompressionEnabled},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether HTTP traffic is allowed on the endpoint.
    # Default value is true.
    # At least one protocol (HTTP or HTTPS) must be allowed.
    ${IsHttpAllowed},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether HTTPS traffic is allowed on the endpoint.
    # Default value is true.
    # At least one protocol (HTTP or HTTPS) must be allowed.
    ${IsHttpsAllowed},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OptimizationType])]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OptimizationType]
    # Specifies what scenario the customer wants this CDN endpoint to optimize for, e.g.
    # Download, Media services.
    # With this information, CDN can apply scenario driven optimization.
    ${OptimizationType},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeepCreatedOrigin[]]
    # The source of the content being delivered via CDN.
    # To construct, see NOTES section for ORIGIN properties and create a hash table.
    ${Origin},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeepCreatedOriginGroup[]]
    # The origin groups comprising of origins that are used for load balancing the traffic based on availability.
    # To construct, see NOTES section for ORIGINGROUP properties and create a hash table.
    ${OriginGroup},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.String]
    # The host header value sent to the origin with each request.
    # This property at Endpoint is only allowed when endpoint uses single origin and can be overridden by the same property specified at origin.If you leave this blank, the request hostname determines this value.
    # Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default.
    ${OriginHostHeader},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.String]
    # A directory path on the origin that CDN can use to retrieve content from, e.g.
    # contoso.cloudapp.net/originpath.
    ${OriginPath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.String]
    # Path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN.
    # This is relative to the origin path.
    # This property is only relevant when using a single origin.
    ${ProbePath},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringCachingBehavior])]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringCachingBehavior]
    # Defines how CDN caches requests that include query strings.
    # You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL.
    ${QueryStringCachingBehavior},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningKey[]]
    # List of keys used to validate the signed URL hashes.
    # To construct, see NOTES section for URLSIGNINGKEY properties and create a hash table.
    ${UrlSigningKey},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.String]
    # Resource ID.
    ${WebApplicationFirewallPolicyLinkId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $Host.Version.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.Cdn.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            CreateExpanded1 = 'Az.Cdn.private\New-AzCdnEndpoint_CreateExpanded1';
        }
        if (('CreateExpanded1') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.Cdn.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
