// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Runtime.Extensions;

    public partial class TestLinesDeleteAcceptedResponseHeaders :
        Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.ITestLinesDeleteAcceptedResponseHeaders,
        Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.ITestLinesDeleteAcceptedResponseHeadersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Models.ITestLinesDeleteAcceptedResponseHeadersInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader0) is string __headerRetryAfterHeader0 ? int.TryParse( __headerRetryAfterHeader0, out int __headerRetryAfterHeader0Value ) ? __headerRetryAfterHeader0Value : default(int?) : default(int?);
            }
        }

        /// <summary>Creates an new <see cref="TestLinesDeleteAcceptedResponseHeaders" /> instance.</summary>
        public TestLinesDeleteAcceptedResponseHeaders()
        {

        }
    }
    public partial interface ITestLinesDeleteAcceptedResponseHeaders

    {
        [Microsoft.Azure.PowerShell.Cmdlets.VoiceServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }

    }
    internal partial interface ITestLinesDeleteAcceptedResponseHeadersInternal

    {
        int? RetryAfter { get; set; }

    }
}