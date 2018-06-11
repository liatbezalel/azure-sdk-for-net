// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of the dsc node configuration.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DscNodeConfiguration : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the DscNodeConfiguration class.
        /// </summary>
        public DscNodeConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DscNodeConfiguration class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the
        /// resource</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="lastModifiedTime">Gets or sets the last modified
        /// time.</param>
        /// <param name="creationTime">Gets or sets creation time.</param>
        /// <param name="configuration">Gets or sets the configuration of the
        /// node.</param>
        /// <param name="source">Source of node configuration.</param>
        /// <param name="nodeCount">Number of nodes with this nodeconfiguration
        /// assigned</param>
        /// <param name="incrementNodeConfigurationBuild">If a new build
        /// version of NodeConfiguration is required.</param>
        public DscNodeConfiguration(string id = default(string), string name = default(string), string type = default(string), System.DateTimeOffset lastModifiedTime = default(System.DateTimeOffset), System.DateTimeOffset creationTime = default(System.DateTimeOffset), DscConfigurationAssociationProperty configuration = default(DscConfigurationAssociationProperty), string source = default(string), long? nodeCount = default(long?), bool? incrementNodeConfigurationBuild = default(bool?))
            : base(id, name, type)
        {
            LastModifiedTime = lastModifiedTime;
            CreationTime = creationTime;
            Configuration = configuration;
            Source = source;
            NodeCount = nodeCount;
            IncrementNodeConfigurationBuild = incrementNodeConfigurationBuild;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the last modified time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTimeOffset LastModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets creation time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTimeOffset CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the configuration of the node.
        /// </summary>
        [JsonProperty(PropertyName = "properties.configuration")]
        public DscConfigurationAssociationProperty Configuration { get; set; }

        /// <summary>
        /// Gets or sets source of node configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets number of nodes with this nodeconfiguration assigned
        /// </summary>
        [JsonProperty(PropertyName = "properties.nodeCount")]
        public long? NodeCount { get; set; }

        /// <summary>
        /// Gets or sets if a new build version of NodeConfiguration is
        /// required.
        /// </summary>
        [JsonProperty(PropertyName = "properties.incrementNodeConfigurationBuild")]
        public bool? IncrementNodeConfigurationBuild { get; set; }

    }
}