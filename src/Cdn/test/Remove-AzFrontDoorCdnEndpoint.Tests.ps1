if(($null -eq $TestName) -or ($TestName -contains 'Remove-AzFrontDoorCdnEndpoint'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Remove-AzFrontDoorCdnEndpoint.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Remove-AzFrontDoorCdnEndpoint'  {
    It 'Delete' {
        $endpointName = 'end-' + (RandomString -allChars $false -len 6);
        Write-Host -ForegroundColor Green "Use frontDoorCdnEndpointName : $($endpointName)"
        $endpoint = New-AzFrontDoorCdnEndpoint -EndpointName $endpointName -ProfileName $$env.FrontDoorCdnProfileName -ResourceGroupName $$env.ResourceGroupName -Location Global

        $endpoint.Name | Should -Be $endpointName
        $endpoint.Location | Should -Be "Global"
        
        Remove-AzFrontdoorCdnEndpoint -ResourceGroupName $ResourceGroupName -ProfileName $frontDoorCdnProfileName -EndpointName $endpointName
    }

    It 'DeleteViaIdentity' {
        $PSDefaultParameterValues['Disabled'] = $true

        $endpointName = 'end-' + (RandomString -allChars $false -len 6);
        Write-Host -ForegroundColor Green "Use frontDoorCdnEndpointName : $($endpointName)"
        $endpoint = New-AzFrontDoorCdnEndpoint -EndpointName $endpointName -ProfileName $$env.FrontDoorCdnProfileName -ResourceGroupName $$env.ResourceGroupName -Location Global

        $endpoint.Name | Should -Be $endpointName
        $endpoint.Location | Should -Be "Global"
        Get-AzFrontdoorCdnEndpoint -ResourceGroupName $ResourceGroupName -ProfileName $frontDoorCdnProfileName -EndpointName $endpointName | Remove-AzFrontdoorCdnEndpoint
    }
}
