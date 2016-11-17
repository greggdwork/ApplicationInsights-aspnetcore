﻿using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Microsoft.ApplicationInsights.AspNetCore.Extensions
{
    /// <summary>
    /// Application Insights service options defines the custom behavior of the features to add, as opposed to the default selection of featuers obtained from Application Insights.
    /// </summary>
    public class ApplicationInsightsServiceOptions
    {
        /// <summary>
        /// Application Insights service options that controlls the default behavior of application insights features.
        /// </summary>
        public ApplicationInsightsServiceOptions()
        {
            this.EnableQuickPulseMetricStream = true;
            this.EnableAdaptiveSampling = true;
            this.LoggerMinimumLevel = LogLevel.Information;
        }

        /// <summary>
        /// Setting EnableQuickPulseMetricStream to false, will disable the default quick pulse metric stream. As a result, QuickPulseTelemetryModule
        /// and QuickPulseTelemetryProcessor are not registered with the configuration by default.
        /// </summary>
        public bool EnableQuickPulseMetricStream { get; set; }

        /// <summary>
        /// Setting EnableAdaptiveSampling to false, will disable the default adaptive sampling feature. As a result, no telemetry processor 
        /// that controls sampling is added to the service by default.
        /// </summary>
        public bool EnableAdaptiveSampling { get; set; }

        public string InstrumentationKey { get; set; }

        public string Version { get; set; }

        public bool? DeveloperMode { get; set; }

        public string EndpointAddress { get; set; }

        public LogLevel LoggerMinimumLevel { get; set; }
    }
}
