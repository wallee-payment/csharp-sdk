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
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public long? Version { get; set; }

        /// <summary>
        /// Gets or Sets Component
        /// </summary>
        [DataMember(Name="component", EmitDefaultValue=true)]
        public long? Component { get; set; }

        /// <summary>
        /// The description of a component fee describes the fee to the subscriber. The description may be shown in documents or on certain user interfaces.
        /// </summary>
        /// <value>The description of a component fee describes the fee to the subscriber. The description may be shown in documents or on certain user interfaces.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public DatabaseTranslatedStringCreate Description { get; set; }

        /// <summary>
        /// The name of the fee should describe for the subscriber in few words for what the fee is for.
        /// </summary>
        /// <value>The name of the fee should describe for the subscriber in few words for what the fee is for.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public DatabaseTranslatedStringCreate Name { get; set; }

        /// <summary>
        /// When the subscription is changed and the change is considered as a downgrade the amount defined by this property will be credited to the subscriber.
        /// </summary>
        /// <value>When the subscription is changed and the change is considered as a downgrade the amount defined by this property will be credited to the subscriber.</value>
        [DataMember(Name="onDowngradeCreditedAmount", EmitDefaultValue=true)]
        public List<PersistableCurrencyAmountUpdate> OnDowngradeCreditedAmount { get; set; }

        /// <summary>
        /// When the subscription is changed and the change is considered as a upgrade the amount defined by this property will be credited to the subscriber.
        /// </summary>
        /// <value>When the subscription is changed and the change is considered as a upgrade the amount defined by this property will be credited to the subscriber.</value>
        [DataMember(Name="onUpgradeCreditedAmount", EmitDefaultValue=true)]
        public List<PersistableCurrencyAmountUpdate> OnUpgradeCreditedAmount { get; set; }

        /// <summary>
        /// The setup fee is charged when the subscriber subscribes to this component. The setup fee is debited with the first charge for the subscriptions.
        /// </summary>
        /// <value>The setup fee is charged when the subscriber subscribes to this component. The setup fee is debited with the first charge for the subscriptions.</value>
        [DataMember(Name="setupFee", EmitDefaultValue=true)]
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
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
