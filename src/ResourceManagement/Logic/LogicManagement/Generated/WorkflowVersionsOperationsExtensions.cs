// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is

namespace Microsoft.Azure.Management.Logic
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq.Expressions;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class WorkflowVersionsOperationsExtensions
    {
            /// <summary>
            /// Gets a workflow version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='versionId'>
            /// The workflow versionId.
            /// </param>
            public static WorkflowVersion Get(this IWorkflowVersionsOperations operations, string resourceGroupName, string workflowName, string versionId)
            {
                return Task.Factory.StartNew(s => ((IWorkflowVersionsOperations)s).GetAsync(resourceGroupName, workflowName, versionId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a workflow version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='versionId'>
            /// The workflow versionId.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<WorkflowVersion> GetAsync( this IWorkflowVersionsOperations operations, string resourceGroupName, string workflowName, string versionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<WorkflowVersion> result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workflowName, versionId, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
