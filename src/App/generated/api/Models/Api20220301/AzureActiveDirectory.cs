// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>The configuration settings of the Azure Active directory provider.</summary>
    public partial class AzureActiveDirectory :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectory,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryInternal
    {

        /// <summary>The list of the allowed groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string[] AllowedPrincipalGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).AllowedPrincipalGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).AllowedPrincipalGroup = value ?? null /* arrayOf */; }

        /// <summary>The list of the allowed identities.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string[] AllowedPrincipalIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).AllowedPrincipalIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).AllowedPrincipalIdentity = value ?? null /* arrayOf */; }

        /// <summary>The configuration settings of the Azure Active Directory allowed applications.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string[] DefaultAuthorizationPolicyAllowedApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).DefaultAuthorizationPolicyAllowedApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).DefaultAuthorizationPolicyAllowedApplication = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>
        /// <code>false</code> if the Azure Active Directory provider should not be enabled despite the set registration; otherwise,
        /// <code>true</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="IsAutoProvisioned" /> property.</summary>
        private bool? _isAutoProvisioned;

        /// <summary>
        /// Gets a value indicating whether the Azure AD configuration was auto-provisioned using 1st party tooling.
        /// This is an internal flag primarily intended to support the Azure Management Portal. Users should not
        /// read or write to this property.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public bool? IsAutoProvisioned { get => this._isAutoProvisioned; set => this._isAutoProvisioned = value; }

        /// <summary>The list of the allowed client applications.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string[] JwtClaimCheckAllowedClientApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).JwtClaimCheckAllowedClientApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).JwtClaimCheckAllowedClientApplication = value ?? null /* arrayOf */; }

        /// <summary>The list of the allowed groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string[] JwtClaimCheckAllowedGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).JwtClaimCheckAllowedGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).JwtClaimCheckAllowedGroup = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Login" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryLogin _login;

        /// <summary>The configuration settings of the Azure Active Directory login flow.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryLogin Login { get => (this._login = this._login ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.AzureActiveDirectoryLogin()); set => this._login = value; }

        /// <summary>
        /// <code>true</code> if the www-authenticate provider should be omitted from the request; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public bool? LoginDisableWwwAuthenticate { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryLoginInternal)Login).DisableWwwAuthenticate; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryLoginInternal)Login).DisableWwwAuthenticate = value ?? default(bool); }

        /// <summary>
        /// Login parameters to send to the OpenID Connect authorization endpoint when
        /// a user logs in. Each parameter must be in the form "key=value".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string[] LoginParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryLoginInternal)Login).LoginParameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryLoginInternal)Login).LoginParameter = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DefaultAuthorizationPolicyAllowedPrincipal</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAllowedPrincipals Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryInternal.DefaultAuthorizationPolicyAllowedPrincipal { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).DefaultAuthorizationPolicyAllowedPrincipal; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).DefaultAuthorizationPolicyAllowedPrincipal = value; }

        /// <summary>Internal Acessors for Login</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryLogin Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryInternal.Login { get => (this._login = this._login ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.AzureActiveDirectoryLogin()); set { {_login = value;} } }

        /// <summary>Internal Acessors for Registration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryRegistration Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryInternal.Registration { get => (this._registration = this._registration ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.AzureActiveDirectoryRegistration()); set { {_registration = value;} } }

        /// <summary>Internal Acessors for Validation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidation Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryInternal.Validation { get => (this._validation = this._validation ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.AzureActiveDirectoryValidation()); set { {_validation = value;} } }

        /// <summary>Internal Acessors for ValidationDefaultAuthorizationPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultAuthorizationPolicy Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryInternal.ValidationDefaultAuthorizationPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).DefaultAuthorizationPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).DefaultAuthorizationPolicy = value; }

        /// <summary>Internal Acessors for ValidationJwtClaimCheck</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IJwtClaimChecks Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryInternal.ValidationJwtClaimCheck { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).JwtClaimCheck; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).JwtClaimCheck = value; }

        /// <summary>Backing field for <see cref="Registration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryRegistration _registration;

        /// <summary>The configuration settings of the Azure Active Directory app registration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryRegistration Registration { get => (this._registration = this._registration ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.AzureActiveDirectoryRegistration()); set => this._registration = value; }

        /// <summary>
        /// The Client ID of this relying party application, known as the client_id.
        /// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string RegistrationClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryRegistrationInternal)Registration).ClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryRegistrationInternal)Registration).ClientId = value ?? null; }

        /// <summary>
        /// An alternative to the client secret thumbprint, that is the issuer of a certificate used for signing purposes. This property
        /// acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string RegistrationClientSecretCertificateIssuer { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryRegistrationInternal)Registration).ClientSecretCertificateIssuer; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryRegistrationInternal)Registration).ClientSecretCertificateIssuer = value ?? null; }

        /// <summary>
        /// An alternative to the client secret thumbprint, that is the subject alternative name of a certificate used for signing
        /// purposes. This property acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string RegistrationClientSecretCertificateSubjectAlternativeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryRegistrationInternal)Registration).ClientSecretCertificateSubjectAlternativeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryRegistrationInternal)Registration).ClientSecretCertificateSubjectAlternativeName = value ?? null; }

        /// <summary>
        /// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property
        /// acts as
        /// a replacement for the Client Secret. It is also optional.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string RegistrationClientSecretCertificateThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryRegistrationInternal)Registration).ClientSecretCertificateThumbprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryRegistrationInternal)Registration).ClientSecretCertificateThumbprint = value ?? null; }

        /// <summary>
        /// The app setting name that contains the client secret of the relying party application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string RegistrationClientSecretSettingName { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryRegistrationInternal)Registration).ClientSecretSettingName; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryRegistrationInternal)Registration).ClientSecretSettingName = value ?? null; }

        /// <summary>
        /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://login.microsoftonline.com/v2.0/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string RegistrationOpenIdIssuer { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryRegistrationInternal)Registration).OpenIdIssuer; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryRegistrationInternal)Registration).OpenIdIssuer = value ?? null; }

        /// <summary>Backing field for <see cref="Validation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidation _validation;

        /// <summary>The configuration settings of the Azure Active Directory token validation flow.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidation Validation { get => (this._validation = this._validation ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.AzureActiveDirectoryValidation()); set => this._validation = value; }

        /// <summary>
        /// The list of audiences that can make successful authentication/authorization requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string[] ValidationAllowedAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).AllowedAudience; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal)Validation).AllowedAudience = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="AzureActiveDirectory" /> instance.</summary>
        public AzureActiveDirectory()
        {

        }
    }
    /// The configuration settings of the Azure Active directory provider.
    public partial interface IAzureActiveDirectory :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>The list of the allowed groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of the allowed groups.",
        SerializedName = @"groups",
        PossibleTypes = new [] { typeof(string) })]
        string[] AllowedPrincipalGroup { get; set; }
        /// <summary>The list of the allowed identities.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of the allowed identities.",
        SerializedName = @"identities",
        PossibleTypes = new [] { typeof(string) })]
        string[] AllowedPrincipalIdentity { get; set; }
        /// <summary>The configuration settings of the Azure Active Directory allowed applications.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The configuration settings of the Azure Active Directory allowed applications.",
        SerializedName = @"allowedApplications",
        PossibleTypes = new [] { typeof(string) })]
        string[] DefaultAuthorizationPolicyAllowedApplication { get; set; }
        /// <summary>
        /// <code>false</code> if the Azure Active Directory provider should not be enabled despite the set registration; otherwise,
        /// <code>true</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"<code>false</code> if the Azure Active Directory provider should not be enabled despite the set registration; otherwise, <code>true</code>.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>
        /// Gets a value indicating whether the Azure AD configuration was auto-provisioned using 1st party tooling.
        /// This is an internal flag primarily intended to support the Azure Management Portal. Users should not
        /// read or write to this property.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets a value indicating whether the Azure AD configuration was auto-provisioned using 1st party tooling.
        This is an internal flag primarily intended to support the Azure Management Portal. Users should not
        read or write to this property.",
        SerializedName = @"isAutoProvisioned",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsAutoProvisioned { get; set; }
        /// <summary>The list of the allowed client applications.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of the allowed client applications.",
        SerializedName = @"allowedClientApplications",
        PossibleTypes = new [] { typeof(string) })]
        string[] JwtClaimCheckAllowedClientApplication { get; set; }
        /// <summary>The list of the allowed groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of the allowed groups.",
        SerializedName = @"allowedGroups",
        PossibleTypes = new [] { typeof(string) })]
        string[] JwtClaimCheckAllowedGroup { get; set; }
        /// <summary>
        /// <code>true</code> if the www-authenticate provider should be omitted from the request; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"<code>true</code> if the www-authenticate provider should be omitted from the request; otherwise, <code>false</code>.",
        SerializedName = @"disableWWWAuthenticate",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LoginDisableWwwAuthenticate { get; set; }
        /// <summary>
        /// Login parameters to send to the OpenID Connect authorization endpoint when
        /// a user logs in. Each parameter must be in the form "key=value".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Login parameters to send to the OpenID Connect authorization endpoint when
        a user logs in. Each parameter must be in the form ""key=value"".",
        SerializedName = @"loginParameters",
        PossibleTypes = new [] { typeof(string) })]
        string[] LoginParameter { get; set; }
        /// <summary>
        /// The Client ID of this relying party application, known as the client_id.
        /// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Client ID of this relying party application, known as the client_id.
        This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
        other 3rd party OpenID Connect providers.
        More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationClientId { get; set; }
        /// <summary>
        /// An alternative to the client secret thumbprint, that is the issuer of a certificate used for signing purposes. This property
        /// acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An alternative to the client secret thumbprint, that is the issuer of a certificate used for signing purposes. This property acts as
        a replacement for the Client Secret Certificate Thumbprint. It is also optional.",
        SerializedName = @"clientSecretCertificateIssuer",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationClientSecretCertificateIssuer { get; set; }
        /// <summary>
        /// An alternative to the client secret thumbprint, that is the subject alternative name of a certificate used for signing
        /// purposes. This property acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An alternative to the client secret thumbprint, that is the subject alternative name of a certificate used for signing purposes. This property acts as
        a replacement for the Client Secret Certificate Thumbprint. It is also optional.",
        SerializedName = @"clientSecretCertificateSubjectAlternativeName",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationClientSecretCertificateSubjectAlternativeName { get; set; }
        /// <summary>
        /// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property
        /// acts as
        /// a replacement for the Client Secret. It is also optional.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property acts as
        a replacement for the Client Secret. It is also optional.",
        SerializedName = @"clientSecretCertificateThumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationClientSecretCertificateThumbprint { get; set; }
        /// <summary>
        /// The app setting name that contains the client secret of the relying party application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The app setting name that contains the client secret of the relying party application.",
        SerializedName = @"clientSecretSettingName",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationClientSecretSettingName { get; set; }
        /// <summary>
        /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://login.microsoftonline.com/v2.0/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://login.microsoftonline.com/v2.0/{tenant-guid}/.
        This URI is a case-sensitive identifier for the token issuer.
        More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html",
        SerializedName = @"openIdIssuer",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationOpenIdIssuer { get; set; }
        /// <summary>
        /// The list of audiences that can make successful authentication/authorization requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of audiences that can make successful authentication/authorization requests.",
        SerializedName = @"allowedAudiences",
        PossibleTypes = new [] { typeof(string) })]
        string[] ValidationAllowedAudience { get; set; }

    }
    /// The configuration settings of the Azure Active directory provider.
    internal partial interface IAzureActiveDirectoryInternal

    {
        /// <summary>The list of the allowed groups.</summary>
        string[] AllowedPrincipalGroup { get; set; }
        /// <summary>The list of the allowed identities.</summary>
        string[] AllowedPrincipalIdentity { get; set; }
        /// <summary>The configuration settings of the Azure Active Directory allowed applications.</summary>
        string[] DefaultAuthorizationPolicyAllowedApplication { get; set; }
        /// <summary>The configuration settings of the Azure Active Directory allowed principals.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAllowedPrincipals DefaultAuthorizationPolicyAllowedPrincipal { get; set; }
        /// <summary>
        /// <code>false</code> if the Azure Active Directory provider should not be enabled despite the set registration; otherwise,
        /// <code>true</code>.
        /// </summary>
        bool? Enabled { get; set; }
        /// <summary>
        /// Gets a value indicating whether the Azure AD configuration was auto-provisioned using 1st party tooling.
        /// This is an internal flag primarily intended to support the Azure Management Portal. Users should not
        /// read or write to this property.
        /// </summary>
        bool? IsAutoProvisioned { get; set; }
        /// <summary>The list of the allowed client applications.</summary>
        string[] JwtClaimCheckAllowedClientApplication { get; set; }
        /// <summary>The list of the allowed groups.</summary>
        string[] JwtClaimCheckAllowedGroup { get; set; }
        /// <summary>The configuration settings of the Azure Active Directory login flow.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryLogin Login { get; set; }
        /// <summary>
        /// <code>true</code> if the www-authenticate provider should be omitted from the request; otherwise, <code>false</code>.
        /// </summary>
        bool? LoginDisableWwwAuthenticate { get; set; }
        /// <summary>
        /// Login parameters to send to the OpenID Connect authorization endpoint when
        /// a user logs in. Each parameter must be in the form "key=value".
        /// </summary>
        string[] LoginParameter { get; set; }
        /// <summary>The configuration settings of the Azure Active Directory app registration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryRegistration Registration { get; set; }
        /// <summary>
        /// The Client ID of this relying party application, known as the client_id.
        /// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        string RegistrationClientId { get; set; }
        /// <summary>
        /// An alternative to the client secret thumbprint, that is the issuer of a certificate used for signing purposes. This property
        /// acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </summary>
        string RegistrationClientSecretCertificateIssuer { get; set; }
        /// <summary>
        /// An alternative to the client secret thumbprint, that is the subject alternative name of a certificate used for signing
        /// purposes. This property acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </summary>
        string RegistrationClientSecretCertificateSubjectAlternativeName { get; set; }
        /// <summary>
        /// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property
        /// acts as
        /// a replacement for the Client Secret. It is also optional.
        /// </summary>
        string RegistrationClientSecretCertificateThumbprint { get; set; }
        /// <summary>
        /// The app setting name that contains the client secret of the relying party application.
        /// </summary>
        string RegistrationClientSecretSettingName { get; set; }
        /// <summary>
        /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://login.microsoftonline.com/v2.0/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </summary>
        string RegistrationOpenIdIssuer { get; set; }
        /// <summary>The configuration settings of the Azure Active Directory token validation flow.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidation Validation { get; set; }
        /// <summary>
        /// The list of audiences that can make successful authentication/authorization requests.
        /// </summary>
        string[] ValidationAllowedAudience { get; set; }
        /// <summary>The configuration settings of the default authorization policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultAuthorizationPolicy ValidationDefaultAuthorizationPolicy { get; set; }
        /// <summary>
        /// The configuration settings of the checks that should be made while validating the JWT Claims.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IJwtClaimChecks ValidationJwtClaimCheck { get; set; }

    }
}