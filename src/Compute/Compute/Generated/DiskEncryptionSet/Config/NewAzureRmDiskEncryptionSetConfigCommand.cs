//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "DiskEncryptionSetConfig", SupportsShouldProcess = true)]
    [OutputType(typeof(PSDiskEncryptionSet))]
    public partial class NewAzureRmDiskEncryptionSetConfigCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        [LocationCompleter("Microsoft.Compute/diskEncryptionSets")]
        public string Location { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("SystemAssigned")]
        public string IdentityType { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public string SourceVaultId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string KeyUrl { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Use this to set the encryption type of the disk encryption set")]
        [PSArgumentCompleter("EncryptionAtRestWithPlatformAndCustomerKeys", "EncryptionAtRestWithCustomerKey")]
        public string EncryptionType { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Gets or sets set this flag to true to enable auto-updating of this disk encryption")]
        public bool? RotationToLatestKeyVersionEnabled { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Multi-tenant application client id to access key vault in a different tenant.")]
        public string FederatedClientId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The list of user identities associated with the disk encryption set. The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.")]
        public Hashtable UserAssignedIdentity { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("DiskEncryptionSet", "New"))
            {
                Run();
            }
        }

        private void Run()
        {
            // Identity
            EncryptionSetIdentity vIdentity = null;

            // ActiveKey
            KeyVaultAndKeyReference vActiveKey = null;

            if (this.IsParameterBound(c => c.IdentityType))
            {
                if (vIdentity == null)
                {
                    vIdentity = new EncryptionSetIdentity();
                }
                vIdentity.Type = this.IdentityType;
            }

            if (this.IsParameterBound(c => c.SourceVaultId))
            {
                if (vActiveKey == null)
                {
                    vActiveKey = new KeyVaultAndKeyReference();
                }
                if (vActiveKey.SourceVault == null)
                {
                    vActiveKey.SourceVault = new SourceVault();
                }
                vActiveKey.SourceVault.Id = this.SourceVaultId;
            }

            if (this.IsParameterBound(c => c.KeyUrl))
            {
                if (vActiveKey == null)
                {
                    vActiveKey = new KeyVaultAndKeyReference();
                }
                vActiveKey.KeyUrl = this.KeyUrl;
            }

            if (this.IsParameterBound(c => c.UserAssignedIdentity))
            {
                if (vIdentity == null)
                {
                    vIdentity = new EncryptionSetIdentity();
                }
                if (vIdentity.UserAssignedIdentities == null)
                {
                    vIdentity.UserAssignedIdentities = new Dictionary<string, UserAssignedIdentitiesValue>();
                }

                foreach (DictionaryEntry de in this.UserAssignedIdentity)
                {
                    if (((Hashtable)de.Value).Count == 0)
                    {
                        vIdentity.UserAssignedIdentities.Add(de.Key.ToString(), new UserAssignedIdentitiesValue());
                    }
                    else
                    {
                        string principalId = ((Hashtable)de.Value)["principalId"]?.ToString();
                        string clientId = ((Hashtable)de.Value)["clientId"]?.ToString();
                        vIdentity.UserAssignedIdentities.Add(de.Key.ToString(), new UserAssignedIdentitiesValue(principalId, clientId));
                    }
                }
            }

            var vDiskEncryptionSet = new PSDiskEncryptionSet
            {
                Location = this.IsParameterBound(c => c.Location) ? this.Location : null,
                Tags = this.IsParameterBound(c => c.Tag) ? this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value) : null,
                EncryptionType = this.IsParameterBound(c => c.EncryptionType) ? this.EncryptionType : null,
                Identity = vIdentity,
                ActiveKey = vActiveKey,
                RotationToLatestKeyVersionEnabled = this.IsParameterBound(c => c.RotationToLatestKeyVersionEnabled) ? this.RotationToLatestKeyVersionEnabled : null,
                FederatedClientId = this.IsParameterBound(c => c.FederatedClientId) ? this.FederatedClientId : null
            };

            WriteObject(vDiskEncryptionSet);
        }
    }
}
