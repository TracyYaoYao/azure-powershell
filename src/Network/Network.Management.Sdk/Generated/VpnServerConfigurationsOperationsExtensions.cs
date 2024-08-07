// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for VpnServerConfigurationsOperations
    /// </summary>
    public static partial class VpnServerConfigurationsOperationsExtensions
    {
        /// <summary>
        /// Retrieves the details of a VpnServerConfiguration.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnServerConfiguration.
        /// </param>
        /// <param name='vpnServerConfigurationName'>
        /// The name of the VpnServerConfiguration being retrieved.
        /// </param>
        public static VpnServerConfiguration Get(this IVpnServerConfigurationsOperations operations, string resourceGroupName, string vpnServerConfigurationName)
        {
                return ((IVpnServerConfigurationsOperations)operations).GetAsync(resourceGroupName, vpnServerConfigurationName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieves the details of a VpnServerConfiguration.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnServerConfiguration.
        /// </param>
        /// <param name='vpnServerConfigurationName'>
        /// The name of the VpnServerConfiguration being retrieved.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<VpnServerConfiguration> GetAsync(this IVpnServerConfigurationsOperations operations, string resourceGroupName, string vpnServerConfigurationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vpnServerConfigurationName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Creates a VpnServerConfiguration resource if it doesn&#39;t exist else updates
        /// the existing VpnServerConfiguration.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnServerConfiguration.
        /// </param>
        /// <param name='vpnServerConfigurationName'>
        /// The name of the VpnServerConfiguration being created or updated.
        /// </param>
        public static VpnServerConfiguration CreateOrUpdate(this IVpnServerConfigurationsOperations operations, string resourceGroupName, string vpnServerConfigurationName, VpnServerConfiguration vpnServerConfigurationParameters)
        {
                return ((IVpnServerConfigurationsOperations)operations).CreateOrUpdateAsync(resourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a VpnServerConfiguration resource if it doesn&#39;t exist else updates
        /// the existing VpnServerConfiguration.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnServerConfiguration.
        /// </param>
        /// <param name='vpnServerConfigurationName'>
        /// The name of the VpnServerConfiguration being created or updated.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<VpnServerConfiguration> CreateOrUpdateAsync(this IVpnServerConfigurationsOperations operations, string resourceGroupName, string vpnServerConfigurationName, VpnServerConfiguration vpnServerConfigurationParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Updates VpnServerConfiguration tags.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnServerConfiguration.
        /// </param>
        /// <param name='vpnServerConfigurationName'>
        /// The name of the VpnServerConfiguration being updated.
        /// </param>
        public static VpnServerConfiguration UpdateTags(this IVpnServerConfigurationsOperations operations, string resourceGroupName, string vpnServerConfigurationName, TagsObject vpnServerConfigurationParameters)
        {
                return ((IVpnServerConfigurationsOperations)operations).UpdateTagsAsync(resourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updates VpnServerConfiguration tags.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnServerConfiguration.
        /// </param>
        /// <param name='vpnServerConfigurationName'>
        /// The name of the VpnServerConfiguration being updated.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<VpnServerConfiguration> UpdateTagsAsync(this IVpnServerConfigurationsOperations operations, string resourceGroupName, string vpnServerConfigurationName, TagsObject vpnServerConfigurationParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.UpdateTagsWithHttpMessagesAsync(resourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Deletes a VpnServerConfiguration.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnServerConfiguration.
        /// </param>
        /// <param name='vpnServerConfigurationName'>
        /// The name of the VpnServerConfiguration being deleted.
        /// </param>
        public static void Delete(this IVpnServerConfigurationsOperations operations, string resourceGroupName, string vpnServerConfigurationName)
        {
                ((IVpnServerConfigurationsOperations)operations).DeleteAsync(resourceGroupName, vpnServerConfigurationName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes a VpnServerConfiguration.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnServerConfiguration.
        /// </param>
        /// <param name='vpnServerConfigurationName'>
        /// The name of the VpnServerConfiguration being deleted.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this IVpnServerConfigurationsOperations operations, string resourceGroupName, string vpnServerConfigurationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vpnServerConfigurationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Lists all the vpnServerConfigurations in a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnServerConfiguration.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<VpnServerConfiguration> ListByResourceGroup(this IVpnServerConfigurationsOperations operations, string resourceGroupName)
        {
                return ((IVpnServerConfigurationsOperations)operations).ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists all the vpnServerConfigurations in a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnServerConfiguration.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<VpnServerConfiguration>> ListByResourceGroupAsync(this IVpnServerConfigurationsOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Lists all the VpnServerConfigurations in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<VpnServerConfiguration> List(this IVpnServerConfigurationsOperations operations)
        {
                return ((IVpnServerConfigurationsOperations)operations).ListAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists all the VpnServerConfigurations in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<VpnServerConfiguration>> ListAsync(this IVpnServerConfigurationsOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Creates a VpnServerConfiguration resource if it doesn&#39;t exist else updates
        /// the existing VpnServerConfiguration.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnServerConfiguration.
        /// </param>
        /// <param name='vpnServerConfigurationName'>
        /// The name of the VpnServerConfiguration being created or updated.
        /// </param>
        public static VpnServerConfiguration BeginCreateOrUpdate(this IVpnServerConfigurationsOperations operations, string resourceGroupName, string vpnServerConfigurationName, VpnServerConfiguration vpnServerConfigurationParameters)
        {
                return ((IVpnServerConfigurationsOperations)operations).BeginCreateOrUpdateAsync(resourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a VpnServerConfiguration resource if it doesn&#39;t exist else updates
        /// the existing VpnServerConfiguration.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnServerConfiguration.
        /// </param>
        /// <param name='vpnServerConfigurationName'>
        /// The name of the VpnServerConfiguration being created or updated.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<VpnServerConfiguration> BeginCreateOrUpdateAsync(this IVpnServerConfigurationsOperations operations, string resourceGroupName, string vpnServerConfigurationName, VpnServerConfiguration vpnServerConfigurationParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Deletes a VpnServerConfiguration.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnServerConfiguration.
        /// </param>
        /// <param name='vpnServerConfigurationName'>
        /// The name of the VpnServerConfiguration being deleted.
        /// </param>
        public static void BeginDelete(this IVpnServerConfigurationsOperations operations, string resourceGroupName, string vpnServerConfigurationName)
        {
                ((IVpnServerConfigurationsOperations)operations).BeginDeleteAsync(resourceGroupName, vpnServerConfigurationName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes a VpnServerConfiguration.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnServerConfiguration.
        /// </param>
        /// <param name='vpnServerConfigurationName'>
        /// The name of the VpnServerConfiguration being deleted.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task BeginDeleteAsync(this IVpnServerConfigurationsOperations operations, string resourceGroupName, string vpnServerConfigurationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, vpnServerConfigurationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Lists all the vpnServerConfigurations in a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<VpnServerConfiguration> ListByResourceGroupNext(this IVpnServerConfigurationsOperations operations, string nextPageLink)
        {
                return ((IVpnServerConfigurationsOperations)operations).ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists all the vpnServerConfigurations in a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<VpnServerConfiguration>> ListByResourceGroupNextAsync(this IVpnServerConfigurationsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Lists all the VpnServerConfigurations in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<VpnServerConfiguration> ListNext(this IVpnServerConfigurationsOperations operations, string nextPageLink)
        {
                return ((IVpnServerConfigurationsOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists all the VpnServerConfigurations in a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<VpnServerConfiguration>> ListNextAsync(this IVpnServerConfigurationsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
