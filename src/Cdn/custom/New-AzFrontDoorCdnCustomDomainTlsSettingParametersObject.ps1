
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
Create an in-memory object for AFDDomainHttpsParameters.
.Description
Create an in-memory object for AFDDomainHttpsParameters.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20220501Preview.AFDDomainHttpsParameters
.Link
https://docs.microsoft.com/powershell/module/az.Cdn/new-AzFrontDoorCdnCustomDomainTlsSettingParametersObject
#>
function New-AzFrontDoorCdnCustomDomainTlsSettingParametersObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20220501Preview.AFDDomainHttpsParameters')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="Defines the source of the SSL certificate.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdCertificateType])]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdCertificateType]
        $CertificateType,
        [Parameter(HelpMessage="TLS protocol version that will be used for Https.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdMinimumTlsVersion])]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdMinimumTlsVersion]
        $MinimumTlsVersion,
        [Parameter(HelpMessage="Resource reference to the secret. ie. subs/rg/profile/secret.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20220501Preview.IResourceReference]
        $Secret
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20220501Preview.AFDDomainHttpsParameters]::New()

        if ($PSBoundParameters.ContainsKey('CertificateType')) {
            $Object.CertificateType = $CertificateType
        }
        if ($PSBoundParameters.ContainsKey('MinimumTlsVersion')) {
            $Object.MinimumTlsVersion = $MinimumTlsVersion
        }
        if ($PSBoundParameters.ContainsKey('Secret')) {
            $Object.Secret = $Secret
        }
        return $Object
    }
}

