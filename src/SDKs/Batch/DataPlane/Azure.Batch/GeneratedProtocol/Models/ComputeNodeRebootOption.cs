// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ComputeNodeRebootOption.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComputeNodeRebootOption
    {
        [EnumMember(Value = "requeue")]
        Requeue,
        [EnumMember(Value = "terminate")]
        Terminate,
        [EnumMember(Value = "taskCompletion")]
        TaskCompletion,
        [EnumMember(Value = "retainedData")]
        RetainedData
    }
    internal static class ComputeNodeRebootOptionEnumExtension
    {
        internal static string ToSerializedValue(this ComputeNodeRebootOption? value)
        {
            return value == null ? null : ((ComputeNodeRebootOption)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ComputeNodeRebootOption value)
        {
            switch( value )
            {
                case ComputeNodeRebootOption.Requeue:
                    return "requeue";
                case ComputeNodeRebootOption.Terminate:
                    return "terminate";
                case ComputeNodeRebootOption.TaskCompletion:
                    return "taskCompletion";
                case ComputeNodeRebootOption.RetainedData:
                    return "retainedData";
            }
            return null;
        }

        internal static ComputeNodeRebootOption? ParseComputeNodeRebootOption(this string value)
        {
            switch( value )
            {
                case "requeue":
                    return ComputeNodeRebootOption.Requeue;
                case "terminate":
                    return ComputeNodeRebootOption.Terminate;
                case "taskCompletion":
                    return ComputeNodeRebootOption.TaskCompletion;
                case "retainedData":
                    return ComputeNodeRebootOption.RetainedData;
            }
            return null;
        }
    }
}
