// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearningCompute
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// These APIs allow end users to operate on Azure Machine Learning Compute
    /// resources. They support the following
    /// operations:&lt;ul&gt;&lt;li&gt;Create or update a
    /// cluster&lt;/li&gt;&lt;li&gt;Get a cluster&lt;/li&gt;&lt;li&gt;Patch a
    /// cluster&lt;/li&gt;&lt;li&gt;Delete a cluster&lt;/li&gt;&lt;li&gt;Get
    /// keys for a cluster&lt;/li&gt;&lt;li&gt;Check if updates are available
    /// for system services in a cluster&lt;/li&gt;&lt;li&gt;Update system
    /// services in a cluster&lt;/li&gt;&lt;li&gt;Get all clusters in a
    /// resource group&lt;/li&gt;&lt;li&gt;Get all clusters in a
    /// subscription&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    public partial interface IMachineLearningComputeManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// The Azure subscription ID.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The version of the Microsoft.MachineLearningCompute resource
        /// provider API to use.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated
        /// and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IOperationalizationClustersOperations.
        /// </summary>
        IOperationalizationClustersOperations OperationalizationClusters { get; }

        /// <summary>
        /// Gets the IMachineLearningComputeOperations.
        /// </summary>
        IMachineLearningComputeOperations MachineLearningCompute { get; }

    }
}
