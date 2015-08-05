// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class WorkflowRunTrigger
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the inputs.
        /// </summary>
        [JsonProperty(PropertyName = "inputs")]
        public object Inputs { get; private set; }

        /// <summary>
        /// Gets the link to inputs.
        /// </summary>
        [JsonProperty(PropertyName = "inputsLink")]
        public ContentLink InputsLink { get; private set; }

        /// <summary>
        /// Gets the outputs.
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public object Outputs { get; private set; }

        /// <summary>
        /// Gets the link to outputs.
        /// </summary>
        [JsonProperty(PropertyName = "outputsLink")]
        public ContentLink OutputsLink { get; private set; }

        /// <summary>
        /// Gets the start time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets the end time.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets the trackingId.
        /// </summary>
        [JsonProperty(PropertyName = "trackingId")]
        public string TrackingId { get; private set; }

        /// <summary>
        /// Gets the code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the status. Possible values for this property include:
        /// 'NotSpecified', 'Paused', 'Running', 'Waiting', 'Succeeded',
        /// 'Skipped', 'Suspended', 'Cancelled', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public WorkflowStatus? Status { get; private set; }

        /// <summary>
        /// Gets the error.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public object Error { get; private set; }

    }
}
