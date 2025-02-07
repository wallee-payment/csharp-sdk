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
    /// ProductSetupFee
    /// </summary>
    [DataContract]
    public partial class ProductSetupFee :  IEquatable<ProductSetupFee>
    {
        /// <summary>
        /// The type of the fee.
        /// </summary>
        /// <value>The type of the fee.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public ProductFeeType? Type { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSetupFee" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ProductSetupFee()
        {
        }

        /// <summary>
        /// The product component that the fee belongs to.
        /// </summary>
        /// <value>The product component that the fee belongs to.</value>
        [DataMember(Name="component", EmitDefaultValue=false)]
        public SubscriptionProductComponent Component { get; private set; }

        /// <summary>
        /// The localized description of the fee that is displayed to the customer.
        /// </summary>
        /// <value>The localized description of the fee that is displayed to the customer.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The localized name of the fee that is displayed to the customer.
        /// </summary>
        /// <value>The localized name of the fee that is displayed to the customer.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; private set; }

        /// <summary>
        /// The amount charged to the customer when a subscription is downgraded.
        /// </summary>
        /// <value>The amount charged to the customer when a subscription is downgraded.</value>
        [DataMember(Name="onDowngradeCreditedAmount", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmount> OnDowngradeCreditedAmount { get; private set; }

        /// <summary>
        /// The amount charged to the customer when a subscription is upgraded.
        /// </summary>
        /// <value>The amount charged to the customer when a subscription is upgraded.</value>
        [DataMember(Name="onUpgradeCreditedAmount", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmount> OnUpgradeCreditedAmount { get; private set; }

        /// <summary>
        /// The amount charged to the customer once when they subscribe to a subscription.
        /// </summary>
        /// <value>The amount charged to the customer once when they subscribe to a subscription.</value>
        [DataMember(Name="setupFee", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmount> SetupFee { get; private set; }


        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductSetupFee {\n");
            sb.Append("  Component: ").Append(Component).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OnDowngradeCreditedAmount: ").Append(OnDowngradeCreditedAmount).Append("\n");
            sb.Append("  OnUpgradeCreditedAmount: ").Append(OnUpgradeCreditedAmount).Append("\n");
            sb.Append("  SetupFee: ").Append(SetupFee).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as ProductSetupFee);
        }

        /// <summary>
        /// Returns true if ProductSetupFee instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductSetupFee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductSetupFee input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
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
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Component != null)
                    hashCode = hashCode * 59 + this.Component.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OnDowngradeCreditedAmount != null)
                    hashCode = hashCode * 59 + this.OnDowngradeCreditedAmount.GetHashCode();
                if (this.OnUpgradeCreditedAmount != null)
                    hashCode = hashCode * 59 + this.OnUpgradeCreditedAmount.GetHashCode();
                if (this.SetupFee != null)
                    hashCode = hashCode * 59 + this.SetupFee.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
