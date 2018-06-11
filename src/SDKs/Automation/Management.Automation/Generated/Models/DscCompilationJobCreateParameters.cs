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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create compilation job operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DscCompilationJobCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the DscCompilationJobCreateParameters
        /// class.
        /// </summary>
        public DscCompilationJobCreateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DscCompilationJobCreateParameters
        /// class.
        /// </summary>
        /// <param name="configuration">Gets or sets the configuration.</param>
        /// <param name="parameters">Gets or sets the parameters of the
        /// job.</param>
        /// <param name="newNodeConfigurationBuildVersionRequired">If a new
        /// build version of NodeConfiguration is required.</param>
        /// <param name="name">Gets or sets name of the resource.</param>
        /// <param name="location">Gets or sets the location of the
        /// resource.</param>
        /// <param name="tags">Gets or sets the tags attached to the
        /// resource.</param>
        public DscCompilationJobCreateParameters(DscConfigurationAssociationProperty configuration, IDictionary<string, string> parameters = default(IDictionary<string, string>), bool? newNodeConfigurationBuildVersionRequired = default(bool?), string name = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Configuration = configuration;
            Parameters = parameters;
            NewNodeConfigurationBuildVersionRequired = newNodeConfigurationBuildVersionRequired;
            Name = name;
            Location = location;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.configuration")]
        public DscConfigurationAssociationProperty Configuration { get; set; }

        /// <summary>
        /// Gets or sets the parameters of the job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Gets or sets if a new build version of NodeConfiguration is
        /// required.
        /// </summary>
        [JsonProperty(PropertyName = "properties.newNodeConfigurationBuildVersionRequired")]
        public bool? NewNodeConfigurationBuildVersionRequired { get; set; }

        /// <summary>
        /// Gets or sets name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the tags attached to the resource.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Configuration == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Configuration");
            }
        }
    }
}