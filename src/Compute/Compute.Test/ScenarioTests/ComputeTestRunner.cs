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

using System.Collections.Generic;
using Microsoft.Azure.Commands.TestFx;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Rest;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.Compute.Test.ScenarioTests
{
    public class ComputeTestRunner
    {
        protected readonly ITestRunner TestRunner;

        protected ComputeTestRunner(ITestOutputHelper output)
        {
            TestRunner = TestManager.CreateInstance (output)
                .WithNewPsScriptFilename ($"{GetType().Name}.ps1")
                .WithProjectSubfolderForTests ("ScenarioTests")
                .WithCommonPsScripts (new[]
                {
                    @"Common.ps1",
                    @"ComputeTestCommon.ps1",
                    @"../AzureRM.Resources.ps1",
                    @"../AzureRM.Storage.ps1"
                })
                .WithNewRmModules (helper => new[]
                {
                    helper.RMProfileModule,
                    helper.GetRMModulePath("AzureRM.Compute.psd1"),
                    helper.GetRMModulePath("AzureRM.Network.psd1"),
                    helper.GetRMModulePath("AzureRM.KeyVault.psd1"),
                    //helper.GetRMModulePath(@"Az.ManagedServiceIdentity.psd1"),

                })
                .WithNewRecordMatcherArguments (
                    userAgentsToIgnore: new Dictionary<string, string>
                    {
                        {"Microsoft.Azure.Management.Resources.ResourceManagementClient", "2016-02-01"},
                        {"Microsoft.Azure.Management.ResourceManager.ResourceManagementClient", "2017-05-10"},
                        {"Microsoft.Azure.Management.Internal.Resources.ResourceManagementClient", "2016-09-01"},
                    },
                    resourceProviders: new Dictionary<string, string>
                    {
                        {"Microsoft.Resources", null},
                        {"Microsoft.Features", null},
                        {"Microsoft.Authorization", null},
                        {"Microsoft.Compute", null},
                        {"Microsoft.Network", null},
                        {"Microsoft.KeyVault", null},
                        {"Microsoft.Storage", null},
                    }
                )
                /* This is an attempt to workaorund the Data Plane Operation not allowed issue in our test framework.
                 * 
                 * .WithManagementClients(context =>
                {
                    string environmentConnectionString = Environment.GetEnvironmentVariable("TEST_CSM_ORGID_AUTHENTICATION");
                    string accessToken = "fakefakefake";

                    // When recording, we should have a connection string passed into the code from the environment
                    if (!string.IsNullOrEmpty(environmentConnectionString))
                    {
                        // Gather test client credential information from the environment
                        var connectionInfo = new ConnectionString(Environment.GetEnvironmentVariable("TEST_CSM_ORGID_AUTHENTICATION"));
                        var mode = connectionInfo.GetValue<string>(ConnectionStringKeys.HttpRecorderModeKey);
                        if (mode == HttpRecorderMode.Record.ToString())
                        {
                            string servicePrincipal = connectionInfo.GetValue<string>(ConnectionStringKeys.ServicePrincipalKey);
                            string servicePrincipalSecret = connectionInfo.GetValue<string>(ConnectionStringKeys.ServicePrincipalSecretKey);
                            string aadTenant = connectionInfo.GetValue<string>(ConnectionStringKeys.TenantIdKey);

                            // Create credentials
                            var clientCredentials = new ClientCredential(servicePrincipal, servicePrincipalSecret);
                            var authContext = new AuthenticationContext($"https://login.windows.net/{aadTenant}", TokenCache.DefaultShared);
                            accessToken = authContext.AcquireTokenAsync("https://vault.azure.net", clientCredentials).Result.AccessToken;
                        }
                    }

                    return new KeyVaultClient(new TokenCredentials(accessToken), HttpMockServer.CreateInstance());
                })*/
                .Build();
        }
    }
}
