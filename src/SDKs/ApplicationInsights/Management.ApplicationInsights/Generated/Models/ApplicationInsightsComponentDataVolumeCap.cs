// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApplicationInsights.Management.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApplicationInsights;
    using Microsoft.Azure.Management.ApplicationInsights.Management;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An Application Insights component daily data volumne cap
    /// </summary>
    public partial class ApplicationInsightsComponentDataVolumeCap
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationInsightsComponentDataVolumeCap class.
        /// </summary>
        public ApplicationInsightsComponentDataVolumeCap()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationInsightsComponentDataVolumeCap class.
        /// </summary>
        /// <param name="cap">Daily data volume cap in GB.</param>
        /// <param name="resetTime">Daily data volume cap UTC reset
        /// hour.</param>
        /// <param name="warningThreshold">Reserved, not used for now.</param>
        /// <param name="stopSendNotificationWhenHitThreshold">Reserved, not
        /// used for now.</param>
        /// <param name="stopSendNotificationWhenHitCap">Do not send a
        /// notification email when the daily data volume cap is met.</param>
        /// <param name="maxHistoryCap">Maximum daily data volume cap that the
        /// user can set for this component.</param>
        public ApplicationInsightsComponentDataVolumeCap(double? cap = default(double?), int? resetTime = default(int?), int? warningThreshold = default(int?), bool? stopSendNotificationWhenHitThreshold = default(bool?), bool? stopSendNotificationWhenHitCap = default(bool?), double? maxHistoryCap = default(double?))
        {
            Cap = cap;
            ResetTime = resetTime;
            WarningThreshold = warningThreshold;
            StopSendNotificationWhenHitThreshold = stopSendNotificationWhenHitThreshold;
            StopSendNotificationWhenHitCap = stopSendNotificationWhenHitCap;
            MaxHistoryCap = maxHistoryCap;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets daily data volume cap in GB.
        /// </summary>
        [JsonProperty(PropertyName = "Cap")]
        public double? Cap { get; set; }

        /// <summary>
        /// Gets daily data volume cap UTC reset hour.
        /// </summary>
        [JsonProperty(PropertyName = "ResetTime")]
        public int? ResetTime { get; private set; }

        /// <summary>
        /// Gets or sets reserved, not used for now.
        /// </summary>
        [JsonProperty(PropertyName = "WarningThreshold")]
        public int? WarningThreshold { get; set; }

        /// <summary>
        /// Gets or sets reserved, not used for now.
        /// </summary>
        [JsonProperty(PropertyName = "StopSendNotificationWhenHitThreshold")]
        public bool? StopSendNotificationWhenHitThreshold { get; set; }

        /// <summary>
        /// Gets or sets do not send a notification email when the daily data
        /// volume cap is met.
        /// </summary>
        [JsonProperty(PropertyName = "StopSendNotificationWhenHitCap")]
        public bool? StopSendNotificationWhenHitCap { get; set; }

        /// <summary>
        /// Gets maximum daily data volume cap that the user can set for this
        /// component.
        /// </summary>
        [JsonProperty(PropertyName = "MaxHistoryCap")]
        public double? MaxHistoryCap { get; private set; }

    }
}
