// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties required to create or update an endpoint.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class EndpointUpdateParameters : IResource
    {
        /// <summary>
        /// Initializes a new instance of the EndpointUpdateParameters class.
        /// </summary>
        public EndpointUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EndpointUpdateParameters class.
        /// </summary>
        /// <param name="tags">Endpoint tags.</param>
        /// <param name="originHostHeader">The host header value sent to the
        /// origin with each request. If you leave this blank, the request
        /// hostname determines this value. Azure CDN origins, such as Web
        /// Apps, Blob Storage, and Cloud Services require this host header
        /// value to match the origin hostname by default.</param>
        /// <param name="originPath">A directory path on the origin that CDN
        /// can use to retreive content from, e.g.
        /// contoso.cloudapp.net/originpath.</param>
        /// <param name="contentTypesToCompress">List of content types on which
        /// compression applies. The value should be a valid MIME type.</param>
        /// <param name="isCompressionEnabled">Indicates whether content
        /// compression is enabled on CDN. Default value is false. If
        /// compression is enabled, content will be served as compressed if
        /// user requests for a compressed version. Content won't be compressed
        /// on CDN when requested content is smaller than 1 byte or larger than
        /// 1 MB.</param>
        /// <param name="isHttpAllowed">Indicates whether HTTP traffic is
        /// allowed on the endpoint. Default value is true. At least one
        /// protocol (HTTP or HTTPS) must be allowed.</param>
        /// <param name="isHttpsAllowed">Indicates whether HTTPS traffic is
        /// allowed on the endpoint. Default value is true. At least one
        /// protocol (HTTP or HTTPS) must be allowed.</param>
        /// <param name="queryStringCachingBehavior">Defines how CDN caches
        /// requests that include query strings. You can ignore any query
        /// strings when caching, bypass caching to prevent requests that
        /// contain query strings from being cached, or cache every request
        /// with a unique URL. Possible values include: 'IgnoreQueryString',
        /// 'BypassCaching', 'UseQueryString', 'NotSet'</param>
        /// <param name="optimizationType">Specifies what scenario the customer
        /// wants this CDN endpoint to optimize for, e.g. Download, Media
        /// services. With this information, CDN can apply scenario driven
        /// optimization. Possible values include: 'GeneralWebDelivery',
        /// 'GeneralMediaStreaming', 'VideoOnDemandMediaStreaming',
        /// 'LargeFileDownload', 'DynamicSiteAcceleration'</param>
        /// <param name="probePath">Path to a file hosted on the origin which
        /// helps accelerate delivery of the dynamic content and calculate the
        /// most optimal routes for the CDN. This is relative to the origin
        /// path.</param>
        /// <param name="geoFilters">List of rules defining the user's geo
        /// access within a CDN endpoint. Each geo filter defines an acess rule
        /// to a specified path or content, e.g. block APAC for path
        /// /pictures/</param>
        /// <param name="deliveryPolicy">A policy that specifies the delivery
        /// rules to be used for an endpoint.</param>
        public EndpointUpdateParameters(IDictionary<string, string> tags = default(IDictionary<string, string>), string originHostHeader = default(string), string originPath = default(string), IList<string> contentTypesToCompress = default(IList<string>), bool? isCompressionEnabled = default(bool?), bool? isHttpAllowed = default(bool?), bool? isHttpsAllowed = default(bool?), QueryStringCachingBehavior? queryStringCachingBehavior = default(QueryStringCachingBehavior?), string optimizationType = default(string), string probePath = default(string), IList<GeoFilter> geoFilters = default(IList<GeoFilter>), EndpointPropertiesUpdateParametersDeliveryPolicy deliveryPolicy = default(EndpointPropertiesUpdateParametersDeliveryPolicy))
        {
            Tags = tags;
            OriginHostHeader = originHostHeader;
            OriginPath = originPath;
            ContentTypesToCompress = contentTypesToCompress;
            IsCompressionEnabled = isCompressionEnabled;
            IsHttpAllowed = isHttpAllowed;
            IsHttpsAllowed = isHttpsAllowed;
            QueryStringCachingBehavior = queryStringCachingBehavior;
            OptimizationType = optimizationType;
            ProbePath = probePath;
            GeoFilters = geoFilters;
            DeliveryPolicy = deliveryPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets endpoint tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the host header value sent to the origin with each
        /// request. If you leave this blank, the request hostname determines
        /// this value. Azure CDN origins, such as Web Apps, Blob Storage, and
        /// Cloud Services require this host header value to match the origin
        /// hostname by default.
        /// </summary>
        [JsonProperty(PropertyName = "properties.originHostHeader")]
        public string OriginHostHeader { get; set; }

        /// <summary>
        /// Gets or sets a directory path on the origin that CDN can use to
        /// retreive content from, e.g. contoso.cloudapp.net/originpath.
        /// </summary>
        [JsonProperty(PropertyName = "properties.originPath")]
        public string OriginPath { get; set; }

        /// <summary>
        /// Gets or sets list of content types on which compression applies.
        /// The value should be a valid MIME type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentTypesToCompress")]
        public IList<string> ContentTypesToCompress { get; set; }

        /// <summary>
        /// Gets or sets indicates whether content compression is enabled on
        /// CDN. Default value is false. If compression is enabled, content
        /// will be served as compressed if user requests for a compressed
        /// version. Content won't be compressed on CDN when requested content
        /// is smaller than 1 byte or larger than 1 MB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isCompressionEnabled")]
        public bool? IsCompressionEnabled { get; set; }

        /// <summary>
        /// Gets or sets indicates whether HTTP traffic is allowed on the
        /// endpoint. Default value is true. At least one protocol (HTTP or
        /// HTTPS) must be allowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isHttpAllowed")]
        public bool? IsHttpAllowed { get; set; }

        /// <summary>
        /// Gets or sets indicates whether HTTPS traffic is allowed on the
        /// endpoint. Default value is true. At least one protocol (HTTP or
        /// HTTPS) must be allowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isHttpsAllowed")]
        public bool? IsHttpsAllowed { get; set; }

        /// <summary>
        /// Gets or sets defines how CDN caches requests that include query
        /// strings. You can ignore any query strings when caching, bypass
        /// caching to prevent requests that contain query strings from being
        /// cached, or cache every request with a unique URL. Possible values
        /// include: 'IgnoreQueryString', 'BypassCaching', 'UseQueryString',
        /// 'NotSet'
        /// </summary>
        [JsonProperty(PropertyName = "properties.queryStringCachingBehavior")]
        public QueryStringCachingBehavior? QueryStringCachingBehavior { get; set; }

        /// <summary>
        /// Gets or sets specifies what scenario the customer wants this CDN
        /// endpoint to optimize for, e.g. Download, Media services. With this
        /// information, CDN can apply scenario driven optimization. Possible
        /// values include: 'GeneralWebDelivery', 'GeneralMediaStreaming',
        /// 'VideoOnDemandMediaStreaming', 'LargeFileDownload',
        /// 'DynamicSiteAcceleration'
        /// </summary>
        [JsonProperty(PropertyName = "properties.optimizationType")]
        public string OptimizationType { get; set; }

        /// <summary>
        /// Gets or sets path to a file hosted on the origin which helps
        /// accelerate delivery of the dynamic content and calculate the most
        /// optimal routes for the CDN. This is relative to the origin path.
        /// </summary>
        [JsonProperty(PropertyName = "properties.probePath")]
        public string ProbePath { get; set; }

        /// <summary>
        /// Gets or sets list of rules defining the user's geo access within a
        /// CDN endpoint. Each geo filter defines an acess rule to a specified
        /// path or content, e.g. block APAC for path /pictures/
        /// </summary>
        [JsonProperty(PropertyName = "properties.geoFilters")]
        public IList<GeoFilter> GeoFilters { get; set; }

        /// <summary>
        /// Gets or sets a policy that specifies the delivery rules to be used
        /// for an endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deliveryPolicy")]
        public EndpointPropertiesUpdateParametersDeliveryPolicy DeliveryPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (GeoFilters != null)
            {
                foreach (var element in GeoFilters)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (DeliveryPolicy != null)
            {
                DeliveryPolicy.Validate();
            }
        }
    }
}