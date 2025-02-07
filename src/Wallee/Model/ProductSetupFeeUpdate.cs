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
    /// ProductSetupFeeUpdate
    /// </summary>
    [DataContract]
    public partial class ProductSetupFeeUpdate :  IEquatable<ProductSetupFeeUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSetupFeeUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductSetupFeeUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSetupFeeUpdate" /> class.
        /// </summary>
        /// <param name="id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required).</param>
        /// <param name="version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public ProductSetupFeeUpdate(long? id, long? version)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ProductSetupFeeUpdate and cannot be null");
            }
            this.Id = id;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for ProductSetupFeeUpdate and cannot be null");
            }
            this.Version = version;
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
        /// The product component that the fee belongs to.
        /// </summary>
        /// <value>The product component that the fee belongs to.</value>
        [DataMember(Name="component", EmitDefaultValue=false)]
        public long? Component { get; set; }

        /// <summary>
        /// The localized description of the fee that is displayed to the customer.
        /// </summary>
        /// <value>The localized description of the fee that is displayed to the customer.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; set; }

        /// <summary>
        /// The localized name of the fee that is displayed to the customer.
        /// </summary>
        /// <value>The localized name of the fee that is displayed to the customer.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// The amount charged to the customer when a subscription is downgraded.
        /// </summary>
        /// <value>The amount charged to the customer when a subscription is downgraded.</value>
        [DataMember(Name="onDowngradeCreditedAmount", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmountUpdate> OnDowngradeCreditedAmount { get; set; }

        /// <summary>
        /// The amount charged to the customer when a subscription is upgraded.
        /// </summary>
        /// <value>The amount charged to the customer when a subscription is upgraded.</value>
        [DataMember(Name="onUpgradeCreditedAmount", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmountUpdate> OnUpgradeCreditedAmount { get; set; }

        /// <summary>
        /// The amount charged to the customer once when they subscribe to a subscription.
        /// </summary>
        /// <value>The amount charged to the customer once when they subscribe to a subscription.</value>
        [DataMember(Name="setupFee", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmountUpdate> SetupFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductSetupFeeUpdate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Component: ").Append(Component).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OnDowngradeCreditedAmount: ").Append(OnDowngradeCreditedAmount).Append("\n");
            sb.Append("  OnUpgradeCreditedAmount: ").Append(OnUpgradeCreditedAmount).Append("\n");
            sb.Append("  SetupFee: ").Append(SetupFee).Append("\n");
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
            return this.Equals(input as ProductSetupFeeUpdate);
        }

        /// <summary>
        /// Returns true if ProductSetupFeeUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductSetupFeeUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductSetupFeeUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Component == input.Component ||
                    (this.Component != null &&
                    this.Component.Equals(input.Component))
                ) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.OnDowngradeCreditedAmount == input.OnDowngradeCreditedAmount ||
                    this.OnDowngradeCreditedAmount != null &&
                    input.OnDowngradeCreditedAmount != null &&
                    this.OnDowngradeCreditedAmount.SequenceEqual(input.OnDowngradeCreditedAmount)
                ) && 
                (
                    this.OnUpgradeCreditedAmount == input.OnUpgradeCreditedAmount ||
                    this.OnUpgradeCreditedAmount != null &&
                    input.OnUpgradeCreditedAmount != null &&
                    this.OnUpgradeCreditedAmount.SequenceEqual(input.OnUpgradeCreditedAmount)
                ) && 
                (
                    this.SetupFee == input.SetupFee ||
                    this.SetupFee != null &&
                    input.SetupFee != null &&
                    this.SetupFee.SequenceEqual(input.SetupFee)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Component != null)
                    hashCode = hashCode * 59 + this.Component.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OnDowngradeCreditedAmount != null)
                    hashCode = hashCode * 59 + this.OnDowngradeCreditedAmount.GetHashCode();
                if (this.OnUpgradeCreditedAmount != null)
                    hashCode = hashCode * 59 + this.OnUpgradeCreditedAmount.GetHashCode();
                if (this.SetupFee != null)
                    hashCode = hashCode * 59 + this.SetupFee.GetHashCode();
                return hashCode;
            }
        }

    }

}
