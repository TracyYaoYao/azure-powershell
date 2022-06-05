if(($null -eq $TestName) -or ($TestName -contains 'New-AzMLWorkspaceComponentVersion'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'New-AzMLWorkspaceComponentVersion.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-AzMLWorkspaceComponentVersion' {
    It 'CreateExpanded' -skip {
        $componentJson = "{
            `"name`": `"train_data_component`",
            `"version`": `"1`",
            `"display_name`": `"train_data`",
            `"is_deterministic`": `"True`",
            `"type`": `"command`",
            `"inputs`": {
              `"training_data`": {
                `"type`": `"uri_folder`",
                `"optional`": `"False`"
              },
              `"max_epocs`": {
                `"type`": `"integer`",
                `"optional`": `"False`"
              },
              `"learning_rate`": {
                `"type`": `"number`",
                `"optional`": `"False`",
                `"default`": `"0.01`"
              },
              `"learning_rate_schedule`": {
                `"type`": `"string`",
                `"optional`": `"False`",
                `"default`": `"time-based`"
              }
            },
            `"outputs`": {
              `"model_output`": {
                `"type`": `"uri_folder`"
              }
            },
            `"code`": `"azureml:/subscriptions/9e223dbe-3399-4e19-88eb-0975f02ac87f/resourceGroups/ml-rg-test/providers/Microsoft.MachineLearningServices/workspaces/mlworkspace-cli01/codes/e08a4be4-66c4-477b-acd7-9579fdd0a3f1/versions/1`",
            `"environment`": `"azureml:/subscriptions/9e223dbe-3399-4e19-88eb-0975f02ac87f/resourceGroups/ml-rg-test/providers/Microsoft.MachineLearningServices/workspaces/mlworkspace-cli01/environments/AzureML-sklearn-0.24-ubuntu18.04-py37-cpu/versions/1`",
            `"resources`": {
              `"instance_count`": `"1`"
            },
            `"command`": `"python train.py`"
          }"
      New-AzMLWorkspaceComponentVersion -ResourceGroupName ml-rg-test -WorkspaceName mlworkspace-cli01 -Name componentpwsh01 -Version 1 -ComponentSpec $componentJson
      Remove-AzMLWorkspaceComponentVersion -ResourceGroupName ml-rg-test -WorkspaceName mlworkspace-cli01 -Name componentpwsh01 -Version 1
    }
}
