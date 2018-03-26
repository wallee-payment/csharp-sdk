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

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Product Metered Fee
    /// </summary>
    [DataContract]
    public partial class ProductMeteredFeeUpdate :  IEquatable<ProductMeteredFeeUpdate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductMeteredFeeUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductMeteredFeeUpdate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductMeteredFeeUpdate" /> class.
        /// </summary>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required)</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required)</param>
        /// <param name="Component">Component</param>
        /// <param name="Description">The description of a component fee describes the fee to the subscriber. The description may be shown in documents or on certain user interfaces.</param>
        /// <param name="Metric">Metric</param>
        /// <param name="Name">The name of the fee should describe for the subscriber in few words for what the fee is for.</param>
        /// <param name="TierPricing">The tier pricing determines the calculation method of the tiers. The prices of the different tiers can be applied in different ways. The tier pricing controls this calculation.</param>
        public ProductMeteredFeeUpdate(ProductMeteredTierPricing? TierPricing = default(ProductMeteredTierPricing?), long? Id = default(long?), DatabaseTranslatedStringCreate Name = default(DatabaseTranslatedStringCreate), DatabaseTranslatedStringCreate Description = default(DatabaseTranslatedStringCreate), long? Version = default(long?), long? Metric = default(long?), long? Component = default(long?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new ArgumentNullException("Id is a required property for ProductMeteredFeeUpdate and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new ArgumentNullException("Version is a required property for ProductMeteredFeeUpdate and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
            this.Component = Component;
            this.Description = Description;
            this.Metric = Metric;
            this.Name = Name;
            this.TierPricing = TierPricing;
        }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

        /// <summary>
        /// Component
        /// </summary>
        /// <value>Component</value>
        [DataMember(Name="component", EmitDefaultValue=false)]
        public long? Component { get; set; }

        /// <summary>
        /// The description of a component fee describes the fee to the subscriber. The description may be shown in documents or on certain user interfaces.
        /// </summary>
        /// <value>The description of a component fee describes the fee to the subscriber. The description may be shown in documents or on certain user interfaces.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public DatabaseTranslatedStringCreate Description { get; set; }

        /// <summary>
        /// Metric
        /// </summary>
        /// <value>Metric</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public long? Metric { get; set; }

        /// <summary>
        /// The name of the fee should describe for the subscriber in few words for what the fee is for.
        /// </summary>
        /// <value>The name of the fee should describe for the subscriber in few words for what the fee is for.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public DatabaseTranslatedStringCreate Name { get; set; }

        /// <summary>
        /// The tier pricing determines the calculation method of the tiers. The prices of the different tiers can be applied in different ways. The tier pricing controls this calculation.
        /// </summary>
        /// <value>The tier pricing determines the calculation method of the tiers. The prices of the different tiers can be applied in different ways. The tier pricing controls this calculation.</value>
        [DataMember(Name="tierPricing", EmitDefaultValue=false)]
        public ProductMeteredTierPricing? TierPricing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as ProductMeteredFeeUpdate);
        }

        /// <summary>
        /// Returns true if ProductMeteredFeeUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductMeteredFeeUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductMeteredFeeUpdate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Component == other.Component ||
                    this.Component != null &&
                    this.Component.Equals(other.Component)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.TierPricing == other.TierPricing ||
                    this.TierPricing != null &&
                    this.TierPricing.Equals(other.TierPricing)
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
                int hash = 41;
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                if (this.Component != null)
                {
                    hash = hash * 59 + this.Component.GetHashCode();
                }
                if (this.Description != null)
                {
                    hash = hash * 59 + this.Description.GetHashCode();
                }
                if (this.Metric != null)
                {
                    hash = hash * 59 + this.Metric.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.TierPricing != null)
                {
                    hash = hash * 59 + this.TierPricing.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
