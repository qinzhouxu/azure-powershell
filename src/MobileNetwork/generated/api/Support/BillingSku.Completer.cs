// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support
{

    /// <summary>
    /// The SKU of the packet core control plane resource. The SKU list may change over time when a new SKU gets added or an exiting
    /// SKU gets removed.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.BillingSkuTypeConverter))]
    public partial struct BillingSku :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "G0".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'G0'", "G0", global::System.Management.Automation.CompletionResultType.ParameterValue, "G0");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "G1".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'G1'", "G1", global::System.Management.Automation.CompletionResultType.ParameterValue, "G1");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "G2".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'G2'", "G2", global::System.Management.Automation.CompletionResultType.ParameterValue, "G2");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "G3".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'G3'", "G3", global::System.Management.Automation.CompletionResultType.ParameterValue, "G3");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "G4".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'G4'", "G4", global::System.Management.Automation.CompletionResultType.ParameterValue, "G4");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "G5".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'G5'", "G5", global::System.Management.Automation.CompletionResultType.ParameterValue, "G5");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "G10".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'G10'", "G10", global::System.Management.Automation.CompletionResultType.ParameterValue, "G10");
            }
        }
    }
}