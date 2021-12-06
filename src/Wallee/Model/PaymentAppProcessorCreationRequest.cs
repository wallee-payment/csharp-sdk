using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Wallee.Client.SwaggerDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// PaymentAppProcessorCreationRequest
    /// </summary>
    [DataContract]
    public partial class PaymentAppProcessorCreationRequest :  IEquatable<PaymentAppProcessorCreationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppProcessorCreationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentAppProcessorCreationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppProcessorCreationRequest" /> class.
        /// </summary>
        /// <param name="documentationUrl">The documentation URL has to point to a description of how to configure and use the processor. (required).</param>
        /// <param name="externalId">The external ID identifies the processor within the external system. It has to be unique per space and for any subsequent update the same ID must be sent. (required).</param>
        /// <param name="name">The name of the processor will be displayed within the user interfaces that the merchant is interacting with. (required).</param>
        /// <param name="svgIcon">The SVG icon will be displayed to the user to represent this processor. (required).</param>
        public PaymentAppProcessorCreationRequest(string documentationUrl, string externalId, string name, string svgIcon)
        {
            // to ensure "documentationUrl" is required (not null)
            if (documentationUrl == null)
            {
                throw new InvalidDataException("documentationUrl is a required property for PaymentAppProcessorCreationRequest and cannot be null");
            }
            this.DocumentationUrl = documentationUrl;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new InvalidDataException("externalId is a required property for PaymentAppProcessorCreationRequest and cannot be null");
            }
            this.ExternalId = externalId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PaymentAppProcessorCreationRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "svgIcon" is required (not null)
            if (svgIcon == null)
            {
                throw new InvalidDataException("svgIcon is a required property for PaymentAppProcessorCreationRequest and cannot be null");
            }
            this.SvgIcon = svgIcon;
        }

        /// <summary>
        /// The documentation URL has to point to a description of how to configure and use the processor.
        /// </summary>
        /// <value>The documentation URL has to point to a description of how to configure and use the processor.</value>
        [DataMember(Name="documentationUrl", EmitDefaultValue=true)]
        public string DocumentationUrl { get; set; }

        /// <summary>
        /// The external ID identifies the processor within the external system. It has to be unique per space and for any subsequent update the same ID must be sent.
        /// </summary>
        /// <value>The external ID identifies the processor within the external system. It has to be unique per space and for any subsequent update the same ID must be sent.</value>
        [DataMember(Name="externalId", EmitDefaultValue=true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The name of the processor will be displayed within the user interfaces that the merchant is interacting with.
        /// </summary>
        /// <value>The name of the processor will be displayed within the user interfaces that the merchant is interacting with.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// The production mode URL has to point to a site on which the merchant can set up the production mode for the processor.
        /// </summary>
        /// <value>The production mode URL has to point to a site on which the merchant can set up the production mode for the processor.</value>
        [DataMember(Name="productionModeUrl", EmitDefaultValue=true)]
        public string ProductionModeUrl { get; set; }

        /// <summary>
        /// The SVG icon will be displayed to the user to represent this processor.
        /// </summary>
        /// <value>The SVG icon will be displayed to the user to represent this processor.</value>
        [DataMember(Name="svgIcon", EmitDefaultValue=true)]
        public string SvgIcon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentAppProcessorCreationRequest {\n");
            sb.Append("  DocumentationUrl: ").Append(DocumentationUrl).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProductionModeUrl: ").Append(ProductionModeUrl).Append("\n");
            sb.Append("  SvgIcon: ").Append(SvgIcon).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentAppProcessorCreationRequest);
        }

        /// <summary>
        /// Returns true if PaymentAppProcessorCreationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAppProcessorCreationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAppProcessorCreationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentationUrl == input.DocumentationUrl ||
                    (this.DocumentationUrl != null &&
                    this.DocumentationUrl.Equals(input.DocumentationUrl))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProductionModeUrl == input.ProductionModeUrl ||
                    (this.ProductionModeUrl != null &&
                    this.ProductionModeUrl.Equals(input.ProductionModeUrl))
                ) && 
                (
                    this.SvgIcon == input.SvgIcon ||
                    (this.SvgIcon != null &&
                    this.SvgIcon.Equals(input.SvgIcon))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DocumentationUrl != null)
                    hashCode = hashCode * 59 + this.DocumentationUrl.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProductionModeUrl != null)
                    hashCode = hashCode * 59 + this.ProductionModeUrl.GetHashCode();
                if (this.SvgIcon != null)
                    hashCode = hashCode * 59 + this.SvgIcon.GetHashCode();
                return hashCode;
            }
        }

    }

}
