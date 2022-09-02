//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Commands.Compute.Automation.Models
{
    public partial class PSProximityPlacementGroup
    {
        // Gets or sets the property of 'ResourceGroupName'
        public string ResourceGroupName
        {
            get
            {
                if (string.IsNullOrEmpty(Id)) return null;
                Regex r = new Regex(@"(.*?)/resourcegroups/(?<rgname>\S+)/providers/(.*?)", RegexOptions.IgnoreCase);
                Match m = r.Match(Id);
                return m.Success ? m.Groups["rgname"].Value : null;
            }
        }

        public string ProximityPlacementGroupType { get; set; }
        public IList<SubResourceWithColocationStatus> VirtualMachines { get; set; }
        public IList<SubResourceWithColocationStatus> VirtualMachineScaleSets { get; set; }
        public IList<SubResourceWithColocationStatus> AvailabilitySets { get; set; }
        public InstanceViewStatus ColocationStatus { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public IDictionary<string, string> Tags { get; set; }
        
        //
        // Summary:
        //     Gets or sets specifies the user intent of the proximity placement group.
        public ProximityPlacementGroupPropertiesIntent Intent { get; set; }

        //
        // Summary:
        //     Gets or sets specifies the Availability Zone where virtual machine, virtual machine
        //     scale set or availability set associated with the proximity placement group can
        //     be created.
        public IList<string> Zones { get; set; }

    }
}
