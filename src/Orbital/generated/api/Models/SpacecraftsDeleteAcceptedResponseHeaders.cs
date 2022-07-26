// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Extensions;

    public partial class SpacecraftsDeleteAcceptedResponseHeaders :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.ISpacecraftsDeleteAcceptedResponseHeaders,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.ISpacecraftsDeleteAcceptedResponseHeadersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Location", out var __locationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.ISpacecraftsDeleteAcceptedResponseHeadersInternal)this).Location = System.Linq.Enumerable.FirstOrDefault(__locationHeader0) is string __headerLocationHeader0 ? __headerLocationHeader0 : (string)null;
            }
        }

        /// <summary>
        /// Creates an new <see cref="SpacecraftsDeleteAcceptedResponseHeaders" /> instance.
        /// </summary>
        public SpacecraftsDeleteAcceptedResponseHeaders()
        {

        }
    }
    public partial interface ISpacecraftsDeleteAcceptedResponseHeaders

    {
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }

    }
    internal partial interface ISpacecraftsDeleteAcceptedResponseHeadersInternal

    {
        string Location { get; set; }

    }
}