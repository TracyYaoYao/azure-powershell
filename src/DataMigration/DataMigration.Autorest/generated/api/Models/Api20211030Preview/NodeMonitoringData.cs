// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Extensions;

    public partial class NodeMonitoringData :
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringData,
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringDataInternal
    {

        /// <summary>Backing field for <see cref="AdditionalProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringDataAdditionalProperties _additionalProperty;

        /// <summary>Unmatched properties from the message are deserialized in this collection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringDataAdditionalProperties AdditionalProperty { get => (this._additionalProperty = this._additionalProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.NodeMonitoringDataAdditionalProperties()); }

        /// <summary>Backing field for <see cref="AvailableMemoryInMb" /> property.</summary>
        private int? _availableMemoryInMb;

        /// <summary>Available memory (MB) on the integration runtime node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        public int? AvailableMemoryInMb { get => this._availableMemoryInMb; }

        /// <summary>Backing field for <see cref="ConcurrentJobsLimit" /> property.</summary>
        private int? _concurrentJobsLimit;

        /// <summary>Maximum concurrent jobs on the integration runtime node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        public int? ConcurrentJobsLimit { get => this._concurrentJobsLimit; }

        /// <summary>Backing field for <see cref="ConcurrentJobsRunning" /> property.</summary>
        private int? _concurrentJobsRunning;

        /// <summary>The number of jobs currently running on the integration runtime node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        public int? ConcurrentJobsRunning { get => this._concurrentJobsRunning; }

        /// <summary>Backing field for <see cref="CpuUtilization" /> property.</summary>
        private int? _cpuUtilization;

        /// <summary>CPU percentage on the integration runtime node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        public int? CpuUtilization { get => this._cpuUtilization; }

        /// <summary>Backing field for <see cref="MaxConcurrentJob" /> property.</summary>
        private int? _maxConcurrentJob;

        /// <summary>The maximum concurrent jobs in this integration runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        public int? MaxConcurrentJob { get => this._maxConcurrentJob; }

        /// <summary>Internal Acessors for AdditionalProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringDataAdditionalProperties Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringDataInternal.AdditionalProperty { get => (this._additionalProperty = this._additionalProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.NodeMonitoringDataAdditionalProperties()); set { {_additionalProperty = value;} } }

        /// <summary>Internal Acessors for AvailableMemoryInMb</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringDataInternal.AvailableMemoryInMb { get => this._availableMemoryInMb; set { {_availableMemoryInMb = value;} } }

        /// <summary>Internal Acessors for ConcurrentJobsLimit</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringDataInternal.ConcurrentJobsLimit { get => this._concurrentJobsLimit; set { {_concurrentJobsLimit = value;} } }

        /// <summary>Internal Acessors for ConcurrentJobsRunning</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringDataInternal.ConcurrentJobsRunning { get => this._concurrentJobsRunning; set { {_concurrentJobsRunning = value;} } }

        /// <summary>Internal Acessors for CpuUtilization</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringDataInternal.CpuUtilization { get => this._cpuUtilization; set { {_cpuUtilization = value;} } }

        /// <summary>Internal Acessors for MaxConcurrentJob</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringDataInternal.MaxConcurrentJob { get => this._maxConcurrentJob; set { {_maxConcurrentJob = value;} } }

        /// <summary>Internal Acessors for NodeName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringDataInternal.NodeName { get => this._nodeName; set { {_nodeName = value;} } }

        /// <summary>Internal Acessors for ReceivedByte</summary>
        double? Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringDataInternal.ReceivedByte { get => this._receivedByte; set { {_receivedByte = value;} } }

        /// <summary>Internal Acessors for SentByte</summary>
        double? Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringDataInternal.SentByte { get => this._sentByte; set { {_sentByte = value;} } }

        /// <summary>Backing field for <see cref="NodeName" /> property.</summary>
        private string _nodeName;

        /// <summary>Name of the integration runtime node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        public string NodeName { get => this._nodeName; }

        /// <summary>Backing field for <see cref="ReceivedByte" /> property.</summary>
        private double? _receivedByte;

        /// <summary>Received bytes on the integration runtime node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        public double? ReceivedByte { get => this._receivedByte; }

        /// <summary>Backing field for <see cref="SentByte" /> property.</summary>
        private double? _sentByte;

        /// <summary>Sent bytes on the integration runtime node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        public double? SentByte { get => this._sentByte; }

        /// <summary>Creates an new <see cref="NodeMonitoringData" /> instance.</summary>
        public NodeMonitoringData()
        {

        }
    }
    public partial interface INodeMonitoringData :
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.IJsonSerializable
    {
        /// <summary>Unmatched properties from the message are deserialized in this collection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @" Unmatched properties from the message are deserialized in this collection.",
        SerializedName = @"additionalProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringDataAdditionalProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringDataAdditionalProperties AdditionalProperty { get;  }
        /// <summary>Available memory (MB) on the integration runtime node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Available memory (MB) on the integration runtime node.",
        SerializedName = @"availableMemoryInMB",
        PossibleTypes = new [] { typeof(int) })]
        int? AvailableMemoryInMb { get;  }
        /// <summary>Maximum concurrent jobs on the integration runtime node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Maximum concurrent jobs on the integration runtime node.",
        SerializedName = @"concurrentJobsLimit",
        PossibleTypes = new [] { typeof(int) })]
        int? ConcurrentJobsLimit { get;  }
        /// <summary>The number of jobs currently running on the integration runtime node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The number of jobs currently running on the integration runtime node.",
        SerializedName = @"concurrentJobsRunning",
        PossibleTypes = new [] { typeof(int) })]
        int? ConcurrentJobsRunning { get;  }
        /// <summary>CPU percentage on the integration runtime node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"CPU percentage on the integration runtime node.",
        SerializedName = @"cpuUtilization",
        PossibleTypes = new [] { typeof(int) })]
        int? CpuUtilization { get;  }
        /// <summary>The maximum concurrent jobs in this integration runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The maximum concurrent jobs in this integration runtime.",
        SerializedName = @"maxConcurrentJobs",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxConcurrentJob { get;  }
        /// <summary>Name of the integration runtime node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Name of the integration runtime node.",
        SerializedName = @"nodeName",
        PossibleTypes = new [] { typeof(string) })]
        string NodeName { get;  }
        /// <summary>Received bytes on the integration runtime node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Received bytes on the integration runtime node.",
        SerializedName = @"receivedBytes",
        PossibleTypes = new [] { typeof(double) })]
        double? ReceivedByte { get;  }
        /// <summary>Sent bytes on the integration runtime node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Sent bytes on the integration runtime node.",
        SerializedName = @"sentBytes",
        PossibleTypes = new [] { typeof(double) })]
        double? SentByte { get;  }

    }
    internal partial interface INodeMonitoringDataInternal

    {
        /// <summary>Unmatched properties from the message are deserialized in this collection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.INodeMonitoringDataAdditionalProperties AdditionalProperty { get; set; }
        /// <summary>Available memory (MB) on the integration runtime node.</summary>
        int? AvailableMemoryInMb { get; set; }
        /// <summary>Maximum concurrent jobs on the integration runtime node.</summary>
        int? ConcurrentJobsLimit { get; set; }
        /// <summary>The number of jobs currently running on the integration runtime node.</summary>
        int? ConcurrentJobsRunning { get; set; }
        /// <summary>CPU percentage on the integration runtime node.</summary>
        int? CpuUtilization { get; set; }
        /// <summary>The maximum concurrent jobs in this integration runtime.</summary>
        int? MaxConcurrentJob { get; set; }
        /// <summary>Name of the integration runtime node.</summary>
        string NodeName { get; set; }
        /// <summary>Received bytes on the integration runtime node.</summary>
        double? ReceivedByte { get; set; }
        /// <summary>Sent bytes on the integration runtime node.</summary>
        double? SentByte { get; set; }

    }
}