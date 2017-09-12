// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details about the execution of a <see cref="CloudJob.JobPreparationTask">Job Preparation task</see> on a compute 
    /// node.
    /// </summary>
    public partial class JobPreparationTaskExecutionInformation : IPropertyMetadata
    {
        private readonly TaskContainerExecutionInformation containerInformation;
        private readonly DateTime? endTime;
        private readonly int? exitCode;
        private readonly TaskFailureInformation failureInformation;
        private readonly DateTime? lastRetryTime;
        private readonly Common.TaskExecutionResult? result;
        private readonly int retryCount;
        private readonly DateTime startTime;
        private readonly Common.JobPreparationTaskState state;
        private readonly string taskRootDirectory;
        private readonly string taskRootDirectoryUrl;

        #region Constructors

        internal JobPreparationTaskExecutionInformation(Models.JobPreparationTaskExecutionInformation protocolObject)
        {
            this.containerInformation = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ContainerInfo, o => new TaskContainerExecutionInformation(o).Freeze());
            this.endTime = protocolObject.EndTime;
            this.exitCode = protocolObject.ExitCode;
            this.failureInformation = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.FailureInfo, o => new TaskFailureInformation(o).Freeze());
            this.lastRetryTime = protocolObject.LastRetryTime;
            this.result = UtilitiesInternal.MapNullableEnum<Models.TaskExecutionResult, Common.TaskExecutionResult>(protocolObject.Result);
            this.retryCount = protocolObject.RetryCount;
            this.startTime = protocolObject.StartTime;
            this.state = UtilitiesInternal.MapEnum<Models.JobPreparationTaskState, Common.JobPreparationTaskState>(protocolObject.State);
            this.taskRootDirectory = protocolObject.TaskRootDirectory;
            this.taskRootDirectoryUrl = protocolObject.TaskRootDirectoryUrl;
        }

        #endregion Constructors

        #region JobPreparationTaskExecutionInformation

        /// <summary>
        /// Gets information about the container under which the task is executing.
        /// </summary>
        /// <remarks>
        /// This property is set only if the task runs in a container context.
        /// </remarks>
        public TaskContainerExecutionInformation ContainerInformation
        {
            get { return this.containerInformation; }
        }

        /// <summary>
        /// Gets the time at which the task completed.
        /// </summary>
        /// <remarks>
        /// This property is only returned if the task is in the <see cref="Common.JobPreparationTaskState.Completed"/> state.
        /// </remarks>
        public DateTime? EndTime
        {
            get { return this.endTime; }
        }

        /// <summary>
        /// Gets the exit code of the program specified on the task command line.
        /// </summary>
        /// <remarks>
        /// This property is only returned if the task is in the <see cref="Common.JobPreparationTaskState.Completed"/> state. 
        /// The exit code for a process reflects the specific convention implemented by the application developer for that 
        /// process. If you use the exit code value to make decisions in your code, be sure that you know the exit code convention 
        /// used by the application process. Note that the exit code may also be generated by the compute node operating 
        /// system, such as when a process is forcibly terminated.
        /// </remarks>
        public int? ExitCode
        {
            get { return this.exitCode; }
        }

        /// <summary>
        /// Gets information describing the task failure, if any.
        /// </summary>
        /// <remarks>
        /// This property is set only if the task is in the <see cref="Common.JobPreparationTaskState.Completed"/> state 
        /// and encountered a failure.
        /// </remarks>
        public TaskFailureInformation FailureInformation
        {
            get { return this.failureInformation; }
        }

        /// <summary>
        /// Gets the most recent time at which this task's execution was retried by the Batch service.
        /// </summary>
        /// <remarks>
        /// This is only returned if the <see cref="RetryCount"/> is not 0.
        /// </remarks>
        public DateTime? LastRetryTime
        {
            get { return this.lastRetryTime; }
        }

        /// <summary>
        /// Gets the result of the task execution.
        /// </summary>
        /// <remarks>
        /// If the value is <see cref="Common.TaskExecutionResult.Failure" />, then the details of the failure can be found 
        /// in the <see cref="FailureInformation" /> property.
        /// </remarks>
        public Common.TaskExecutionResult? Result
        {
            get { return this.result; }
        }

        /// <summary>
        /// Gets the number of times the task has been retried by the Batch service. Every time the task exits with a non-zero 
        /// exit code, it is deemed a task failure. The Batch service will retry the task up to the limit specified by the 
        /// <see cref="JobPreparationTask.Constraints"/>.
        /// </summary>
        public int RetryCount
        {
            get { return this.retryCount; }
        }

        /// <summary>
        /// Gets the time at which the task started running. Note that every time the task is restarted, this value is updated.
        /// </summary>
        public DateTime StartTime
        {
            get { return this.startTime; }
        }

        /// <summary>
        /// Gets the current state of the task.
        /// </summary>
        /// <remarks>
        /// Running means the task is currently running. Completed means the task has completed. The Completed state includes 
        /// the case where the task exits successfully with exit code 0 and the cases where the system fails to start the 
        /// task process due to scheduling errors or the retry limit has reached after numerous task failures.
        /// </remarks>
        public Common.JobPreparationTaskState State
        {
            get { return this.state; }
        }

        /// <summary>
        /// Gets the root directory of the Job Preparation task on the compute node. You can use this path to retrieve files 
        /// created by the task, such as log files.
        /// </summary>
        public string TaskRootDirectory
        {
            get { return this.taskRootDirectory; }
        }

        /// <summary>
        /// Gets the URL to the root directory of the Job Preparation task on the compute node.
        /// </summary>
        public string TaskRootDirectoryUrl
        {
            get { return this.taskRootDirectoryUrl; }
        }

        #endregion // JobPreparationTaskExecutionInformation

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}