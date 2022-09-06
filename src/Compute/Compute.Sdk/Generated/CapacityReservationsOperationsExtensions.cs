// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CapacityReservationsOperations.
    /// </summary>
    public static partial class CapacityReservationsOperationsExtensions
    {
            /// <summary>
            /// The operation to create or update a capacity reservation. Please note some
            /// properties can be set only during capacity reservation creation. Please
            /// refer to https://aka.ms/CapacityReservation for more details.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='capacityReservationName'>
            /// The name of the capacity reservation.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create capacity reservation.
            /// </param>
            public static CapacityReservation CreateOrUpdate(this ICapacityReservationsOperations operations, string resourceGroupName, string capacityReservationGroupName, string capacityReservationName, CapacityReservation parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, capacityReservationGroupName, capacityReservationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create or update a capacity reservation. Please note some
            /// properties can be set only during capacity reservation creation. Please
            /// refer to https://aka.ms/CapacityReservation for more details.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='capacityReservationName'>
            /// The name of the capacity reservation.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create capacity reservation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CapacityReservation> CreateOrUpdateAsync(this ICapacityReservationsOperations operations, string resourceGroupName, string capacityReservationGroupName, string capacityReservationName, CapacityReservation parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, capacityReservationGroupName, capacityReservationName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to update a capacity reservation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='capacityReservationName'>
            /// The name of the capacity reservation.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update capacity reservation operation.
            /// </param>
            public static CapacityReservation Update(this ICapacityReservationsOperations operations, string resourceGroupName, string capacityReservationGroupName, string capacityReservationName, CapacityReservationUpdate parameters)
            {
                return operations.UpdateAsync(resourceGroupName, capacityReservationGroupName, capacityReservationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to update a capacity reservation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='capacityReservationName'>
            /// The name of the capacity reservation.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update capacity reservation operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CapacityReservation> UpdateAsync(this ICapacityReservationsOperations operations, string resourceGroupName, string capacityReservationGroupName, string capacityReservationName, CapacityReservationUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, capacityReservationGroupName, capacityReservationName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to delete a capacity reservation. This operation is allowed
            /// only when all the associated resources are disassociated from the capacity
            /// reservation. Please refer to https://aka.ms/CapacityReservation for more
            /// details.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='capacityReservationName'>
            /// The name of the capacity reservation.
            /// </param>
            public static void Delete(this ICapacityReservationsOperations operations, string resourceGroupName, string capacityReservationGroupName, string capacityReservationName)
            {
                operations.DeleteAsync(resourceGroupName, capacityReservationGroupName, capacityReservationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete a capacity reservation. This operation is allowed
            /// only when all the associated resources are disassociated from the capacity
            /// reservation. Please refer to https://aka.ms/CapacityReservation for more
            /// details.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='capacityReservationName'>
            /// The name of the capacity reservation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ICapacityReservationsOperations operations, string resourceGroupName, string capacityReservationGroupName, string capacityReservationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, capacityReservationGroupName, capacityReservationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The operation that retrieves information about the capacity reservation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='capacityReservationName'>
            /// The name of the capacity reservation.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. 'InstanceView' retrieves a
            /// snapshot of the runtime properties of the capacity reservation that is
            /// managed by the platform and can change outside of control plane operations.
            /// Possible values include: 'instanceView'
            /// </param>
            public static CapacityReservation Get(this ICapacityReservationsOperations operations, string resourceGroupName, string capacityReservationGroupName, string capacityReservationName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, capacityReservationGroupName, capacityReservationName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation that retrieves information about the capacity reservation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='capacityReservationName'>
            /// The name of the capacity reservation.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. 'InstanceView' retrieves a
            /// snapshot of the runtime properties of the capacity reservation that is
            /// managed by the platform and can change outside of control plane operations.
            /// Possible values include: 'instanceView'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CapacityReservation> GetAsync(this ICapacityReservationsOperations operations, string resourceGroupName, string capacityReservationGroupName, string capacityReservationName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, capacityReservationGroupName, capacityReservationName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the capacity reservations in the specified capacity
            /// reservation group. Use the nextLink property in the response to get the
            /// next page of capacity reservations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            public static IPage<CapacityReservation> ListByCapacityReservationGroup(this ICapacityReservationsOperations operations, string resourceGroupName, string capacityReservationGroupName)
            {
                return operations.ListByCapacityReservationGroupAsync(resourceGroupName, capacityReservationGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the capacity reservations in the specified capacity
            /// reservation group. Use the nextLink property in the response to get the
            /// next page of capacity reservations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CapacityReservation>> ListByCapacityReservationGroupAsync(this ICapacityReservationsOperations operations, string resourceGroupName, string capacityReservationGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByCapacityReservationGroupWithHttpMessagesAsync(resourceGroupName, capacityReservationGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create or update a capacity reservation. Please note some
            /// properties can be set only during capacity reservation creation. Please
            /// refer to https://aka.ms/CapacityReservation for more details.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='capacityReservationName'>
            /// The name of the capacity reservation.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create capacity reservation.
            /// </param>
            public static CapacityReservation BeginCreateOrUpdate(this ICapacityReservationsOperations operations, string resourceGroupName, string capacityReservationGroupName, string capacityReservationName, CapacityReservation parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, capacityReservationGroupName, capacityReservationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create or update a capacity reservation. Please note some
            /// properties can be set only during capacity reservation creation. Please
            /// refer to https://aka.ms/CapacityReservation for more details.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='capacityReservationName'>
            /// The name of the capacity reservation.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create capacity reservation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CapacityReservation> BeginCreateOrUpdateAsync(this ICapacityReservationsOperations operations, string resourceGroupName, string capacityReservationGroupName, string capacityReservationName, CapacityReservation parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, capacityReservationGroupName, capacityReservationName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to update a capacity reservation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='capacityReservationName'>
            /// The name of the capacity reservation.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update capacity reservation operation.
            /// </param>
            public static CapacityReservation BeginUpdate(this ICapacityReservationsOperations operations, string resourceGroupName, string capacityReservationGroupName, string capacityReservationName, CapacityReservationUpdate parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, capacityReservationGroupName, capacityReservationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to update a capacity reservation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='capacityReservationName'>
            /// The name of the capacity reservation.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update capacity reservation operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CapacityReservation> BeginUpdateAsync(this ICapacityReservationsOperations operations, string resourceGroupName, string capacityReservationGroupName, string capacityReservationName, CapacityReservationUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, capacityReservationGroupName, capacityReservationName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to delete a capacity reservation. This operation is allowed
            /// only when all the associated resources are disassociated from the capacity
            /// reservation. Please refer to https://aka.ms/CapacityReservation for more
            /// details.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='capacityReservationName'>
            /// The name of the capacity reservation.
            /// </param>
            public static void BeginDelete(this ICapacityReservationsOperations operations, string resourceGroupName, string capacityReservationGroupName, string capacityReservationName)
            {
                operations.BeginDeleteAsync(resourceGroupName, capacityReservationGroupName, capacityReservationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete a capacity reservation. This operation is allowed
            /// only when all the associated resources are disassociated from the capacity
            /// reservation. Please refer to https://aka.ms/CapacityReservation for more
            /// details.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='capacityReservationGroupName'>
            /// The name of the capacity reservation group.
            /// </param>
            /// <param name='capacityReservationName'>
            /// The name of the capacity reservation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ICapacityReservationsOperations operations, string resourceGroupName, string capacityReservationGroupName, string capacityReservationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, capacityReservationGroupName, capacityReservationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all of the capacity reservations in the specified capacity
            /// reservation group. Use the nextLink property in the response to get the
            /// next page of capacity reservations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CapacityReservation> ListByCapacityReservationGroupNext(this ICapacityReservationsOperations operations, string nextPageLink)
            {
                return operations.ListByCapacityReservationGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the capacity reservations in the specified capacity
            /// reservation group. Use the nextLink property in the response to get the
            /// next page of capacity reservations.
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
            public static async Task<IPage<CapacityReservation>> ListByCapacityReservationGroupNextAsync(this ICapacityReservationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByCapacityReservationGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
