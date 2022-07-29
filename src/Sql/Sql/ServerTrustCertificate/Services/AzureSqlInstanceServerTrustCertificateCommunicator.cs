﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Management.Sql;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Azure.Commands.Sql.ServerTrustCertificate.Services
{
    /// <summary>
    /// This class is responsible for all the REST communication with the server trust certificate REST endpoints
    /// </summary>
    public class AzureSqlInstanceServerTrustCertificateCommunicator
    {
        /// <summary>
        /// The Sql client to be used by this end points communicator
        /// </summary>
        private static SqlManagementClient SqlClient { get; set; }

        /// <summary>
        /// Gets or set the Azure subscription
        /// </summary>
        private static IAzureSubscription Subscription { get; set; }

        /// <summary>
        /// Gets or sets the Azure profile
        /// </summary>
        public IAzureContext Context { get; set; }

        /// <summary>
        /// Creates a communicator for Azure Sql Instance Server Trust Certificate
        /// </summary>
        /// <param name="context">The current azure context</param>
        public AzureSqlInstanceServerTrustCertificateCommunicator(IAzureContext context)
        {
            Context = context;
            if (context?.Subscription != Subscription)
            {
                Subscription = context?.Subscription;
                SqlClient = null;
            }
        }

        /// <summary>
        /// Creates or updates a server trust certificate
        /// </summary>
        public Management.Sql.Models.ServerTrustCertificate CreateOrUpdate(string resourceGroupName, string instanceName, string certificateName, Management.Sql.Models.ServerTrustCertificate parameters)
        {
            return GetCurrentSqlClient().ServerTrustCertificates.CreateOrUpdate(resourceGroupName, instanceName, certificateName, parameters);
        }
        /// <summary>
        /// Gets the server trust certificate
        /// </summary>
        public Management.Sql.Models.ServerTrustCertificate Get(string resourceGroupName, string instanceName, string certificateName)
        {
            return GetCurrentSqlClient().ServerTrustCertificates.Get(resourceGroupName, instanceName, certificateName);
        }

        /// <summary>
        /// Lists server trust certificate on a managed instance
        /// </summary>
        public IList<Management.Sql.Models.ServerTrustCertificate> List(string resourceGroupName, string instanceName)
        {
            return GetCurrentSqlClient().ServerTrustCertificates.ListByInstance(resourceGroupName, instanceName).ToList();
        }

        /// <summary>
        /// Deletes a user certificate from managed instance
        /// </summary>
        public void Remove(string resourceGroupName, string instanceName, string certificateName)
        {
            GetCurrentSqlClient().ServerTrustCertificates.Delete(resourceGroupName, instanceName, certificateName);
        }

        /// <summary>
        /// Retrieve the SQL Management client for the currently selected subscription, adding the session and request
        /// id tracing headers for the current cmdlet invocation.
        /// </summary>
        /// <returns>The SQL Management client for the currently selected subscription.</returns>
        private SqlManagementClient GetCurrentSqlClient()
        {
            // Get the SQL management client for the current subscription
            if (SqlClient == null)
            {
                SqlClient = AzureSession.Instance.ClientFactory.CreateArmClient<SqlManagementClient>(Context, AzureEnvironment.Endpoint.ResourceManager);
            }
            return SqlClient;
        }
    }
}
