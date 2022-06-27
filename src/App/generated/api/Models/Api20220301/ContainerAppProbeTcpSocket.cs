// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>
    /// TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported.
    /// </summary>
    public partial class ContainerAppProbeTcpSocket :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeTcpSocket,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProbeTcpSocketInternal
    {

        /// <summary>Backing field for <see cref="Host" /> property.</summary>
        private string _host;

        /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string Host { get => this._host; set => this._host = value; }

        /// <summary>Backing field for <see cref="Port" /> property.</summary>
        private int _port;

        /// <summary>
        /// Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public int Port { get => this._port; set => this._port = value; }

        /// <summary>Creates an new <see cref="ContainerAppProbeTcpSocket" /> instance.</summary>
        public ContainerAppProbeTcpSocket()
        {

        }
    }
    /// TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported.
    public partial interface IContainerAppProbeTcpSocket :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Optional: Host name to connect to, defaults to the pod IP.",
        SerializedName = @"host",
        PossibleTypes = new [] { typeof(string) })]
        string Host { get; set; }
        /// <summary>
        /// Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.",
        SerializedName = @"port",
        PossibleTypes = new [] { typeof(int) })]
        int Port { get; set; }

    }
    /// TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported.
    internal partial interface IContainerAppProbeTcpSocketInternal

    {
        /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
        string Host { get; set; }
        /// <summary>
        /// Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
        /// </summary>
        int Port { get; set; }

    }
}