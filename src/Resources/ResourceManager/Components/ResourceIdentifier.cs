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

using System;
using System.Collections.Generic;
using System.Text;
using ProjectResources = Microsoft.Azure.Commands.ResourceManager.Cmdlets.Properties.Resources;

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.Components
{
    public class ResourceIdentifier
    {
        public string ResourceType { get; set; }

        public string ResourceGroupName { get; set; }

        public string ResourceName { get; set; }

        public string ParentResource { get; set; }

        public string Subscription { get; set; }

        public string ManagementGroupName { get; set; }

        public ResourceIdentifier() { }

        public ResourceIdentifier(string idFromServer)
        {
            if (!string.IsNullOrEmpty(idFromServer))
            {
                string[] tokens = idFromServer.Split(new[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length < 8)
                {
                    throw new ArgumentException(ProjectResources.InvalidFormatOfResourceId, "idFromServer");
                }
                Subscription = tokens[1];
                ResourceGroupName = tokens[3];
                ResourceName = tokens[tokens.Length - 1];

                List<string> resourceTypeBuilder = new List<string>();
                resourceTypeBuilder.Add(tokens[5]);
                
                List<string> parentResourceBuilder = new List<string>();
                for (int i = 6; i <= tokens.Length - 3; i++)
                {
                    parentResourceBuilder.Add(tokens[i]);
                    // Add every other token to type
                    if (i%2 == 0)
                    {
                        resourceTypeBuilder.Add(tokens[i]);
                    }
                }
                resourceTypeBuilder.Add(tokens[tokens.Length - 2]);

                if (parentResourceBuilder.Count > 0)
                {
                    ParentResource = string.Join("/", parentResourceBuilder);
                }
                if (resourceTypeBuilder.Count > 0)
                {
                    ResourceType = string.Join("/", resourceTypeBuilder);
                }
            }
        }

        public static ResourceIdentifier FromResourceGroupIdentifier(string resourceGroupId)
        {
            if (!string.IsNullOrEmpty(resourceGroupId))
            {
                string[] tokens = resourceGroupId.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length != 4)
                {
                    throw new ArgumentException(ProjectResources.InvalidFormatOfResourceGroupId, "resourceGroupId");
                }
                return new ResourceIdentifier
                {
                    Subscription = tokens[1],
                    ResourceGroupName = tokens[3],
                };
            }

            return new ResourceIdentifier();
        }

        public static string GetProviderFromResourceType(string resourceType)
        {
            if (resourceType == null)
            {
                return null;
            }

            int indexOfSlash = resourceType.IndexOf('/');
            if (indexOfSlash < 0)
            {
                return string.Empty;
            }
            else
            {
                return resourceType.Substring(0, indexOfSlash);
            }
        }

        public static string GetTypeFromResourceType(string resourceType)
        {
            if (resourceType == null)
            {
                return null;
            }

            int lastIndexOfSlash = resourceType.LastIndexOf('/');
            if (lastIndexOfSlash < 0)
            {
                return string.Empty;
            }
            else
            {
                return resourceType.Substring(lastIndexOfSlash + 1);
            }
        }

        public override string ToString()
        {
            string provider = GetProviderFromResourceType(ResourceType);
            string type = GetTypeFromResourceType(ResourceType);
            string parentAndType = string.IsNullOrEmpty(ParentResource) ? type : ParentResource + "/" + type;
            StringBuilder resourceId = new StringBuilder();

            AppendIfNotNull(resourceId, "/subscriptions/{0}", Subscription);
            AppendIfNotNull(resourceId, "/resourceGroups/{0}", ResourceGroupName);
            AppendIfNotNull(resourceId, "/providers/{0}", provider);
            AppendIfNotNull(resourceId, "/{0}", parentAndType);
            AppendIfNotNull(resourceId, "/{0}", ResourceName);

            return resourceId.ToString();
        }

        private void AppendIfNotNull(StringBuilder resourceId, string format, string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                resourceId.AppendFormat(format, value);
            }
        }
    }
}
