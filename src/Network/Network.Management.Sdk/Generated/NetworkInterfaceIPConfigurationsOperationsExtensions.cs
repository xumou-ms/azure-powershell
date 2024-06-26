// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for NetworkInterfaceIPConfigurationsOperations
    /// </summary>
    public static partial class NetworkInterfaceIPConfigurationsOperationsExtensions
    {
        /// <summary>
        /// Get all ip configurations in a network interface.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkInterfaceName'>
        /// The name of the network interface.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<NetworkInterfaceIPConfiguration> List(this INetworkInterfaceIPConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName)
        {
                return ((INetworkInterfaceIPConfigurationsOperations)operations).ListAsync(resourceGroupName, networkInterfaceName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get all ip configurations in a network interface.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkInterfaceName'>
        /// The name of the network interface.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<NetworkInterfaceIPConfiguration>> ListAsync(this INetworkInterfaceIPConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets the specified network interface ip configuration.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkInterfaceName'>
        /// The name of the network interface.
        /// </param>
        /// <param name='ipConfigurationName'>
        /// The name of the ip configuration name.
        /// </param>
        public static NetworkInterfaceIPConfiguration Get(this INetworkInterfaceIPConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, string ipConfigurationName)
        {
                return ((INetworkInterfaceIPConfigurationsOperations)operations).GetAsync(resourceGroupName, networkInterfaceName, ipConfigurationName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the specified network interface ip configuration.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkInterfaceName'>
        /// The name of the network interface.
        /// </param>
        /// <param name='ipConfigurationName'>
        /// The name of the ip configuration name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<NetworkInterfaceIPConfiguration> GetAsync(this INetworkInterfaceIPConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, string ipConfigurationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, ipConfigurationName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Get all ip configurations in a network interface.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<NetworkInterfaceIPConfiguration> ListNext(this INetworkInterfaceIPConfigurationsOperations operations, string nextPageLink)
        {
                return ((INetworkInterfaceIPConfigurationsOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get all ip configurations in a network interface.
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
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<NetworkInterfaceIPConfiguration>> ListNextAsync(this INetworkInterfaceIPConfigurationsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
