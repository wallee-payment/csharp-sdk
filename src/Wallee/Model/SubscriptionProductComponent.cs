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
    /// SubscriptionProductComponent
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductComponent :  IEquatable<SubscriptionProductComponent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductComponent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SubscriptionProductComponent()
        {
        }

        /// <summary>
        /// If switching from a component with a lower tier to a component with a higher one, this is considered an upgrade and a fee may be applied.
        /// </summary>
        /// <value>If switching from a component with a lower tier to a component with a higher one, this is considered an upgrade and a fee may be applied.</value>
        [DataMember(Name="componentChangeWeight", EmitDefaultValue=false)]
        public int? ComponentChangeWeight { get; private set; }

        /// <summary>
        /// The group that the component belongs to.
        /// </summary>
        /// <value>The group that the component belongs to.</value>
        [DataMember(Name="componentGroup", EmitDefaultValue=false)]
        public SubscriptionProductComponentGroup ComponentGroup { get; private set; }

        /// <summary>
        /// Whether this is the default component in its group and preselected.
        /// </summary>
        /// <value>Whether this is the default component in its group and preselected.</value>
        [DataMember(Name="defaultComponent", EmitDefaultValue=false)]
        public bool? DefaultComponent { get; private set; }

        /// <summary>
        /// The localized description of the component that is displayed to the customer.
        /// </summary>
        /// <value>The localized description of the component that is displayed to the customer.</value>
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
        /// A maximum of the defined quantity can be selected for this component.
        /// </summary>
        /// <value>A maximum of the defined quantity can be selected for this component.</value>
        [DataMember(Name="maximalQuantity", EmitDefaultValue=false)]
        public decimal? MaximalQuantity { get; private set; }

        /// <summary>
        /// A minimum of the defined quantity must be selected for this component.
        /// </summary>
        /// <value>A minimum of the defined quantity must be selected for this component.</value>
        [DataMember(Name="minimalQuantity", EmitDefaultValue=false)]
        public decimal? MinimalQuantity { get; private set; }

        /// <summary>
        /// The localized name of the component that is displayed to the customer.
        /// </summary>
        /// <value>The localized name of the component that is displayed to the customer.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; private set; }

        /// <summary>
        /// The quantity step determines the interval in which the quantity can be increased.
        /// </summary>
        /// <value>The quantity step determines the interval in which the quantity can be increased.</value>
        [DataMember(Name="quantityStep", EmitDefaultValue=false)]
        public decimal? QuantityStep { get; private set; }

        /// <summary>
        /// The reference is used to link components across different product versions.
        /// </summary>
        /// <value>The reference is used to link components across different product versions.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public SubscriptionProductComponentReference Reference { get; private set; }

        /// <summary>
        /// When listing components, they can be sorted by this number.
        /// </summary>
        /// <value>When listing components, they can be sorted by this number.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; private set; }

        /// <summary>
        /// The tax class to be applied to fees.
        /// </summary>
        /// <value>The tax class to be applied to fees.</value>
        [DataMember(Name="taxClass", EmitDefaultValue=false)]
        public TaxClass TaxClass { get; private set; }

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
            sb.Append("class SubscriptionProductComponent {\n");
            sb.Append("  ComponentChangeWeight: ").Append(ComponentChangeWeight).Append("\n");
            sb.Append("  ComponentGroup: ").Append(ComponentGroup).Append("\n");
            sb.Append("  DefaultComponent: ").Append(DefaultComponent).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  MaximalQuantity: ").Append(MaximalQuantity).Append("\n");
            sb.Append("  MinimalQuantity: ").Append(MinimalQuantity).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  QuantityStep: ").Append(QuantityStep).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  TaxClass: ").Append(TaxClass).Append("\n");
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
            return this.Equals(input as SubscriptionProductComponent);
        }

        /// <summary>
        /// Returns true if SubscriptionProductComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionProductComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ComponentChangeWeight == input.ComponentChangeWeight ||
                    (this.ComponentChangeWeight != null &&
                    this.ComponentChangeWeight.Equals(input.ComponentChangeWeight))
                ) && 
                (
                    this.ComponentGroup == input.ComponentGroup ||
                    (this.ComponentGroup != null &&
                    this.ComponentGroup.Equals(input.ComponentGroup))
                ) && 
                (
                    this.DefaultComponent == input.DefaultComponent ||
                    (this.DefaultComponent != null &&
                    this.DefaultComponent.Equals(input.DefaultComponent))
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
                    this.MaximalQuantity == input.MaximalQuantity ||
                    (this.MaximalQuantity != null &&
                    this.MaximalQuantity.Equals(input.MaximalQuantity))
                ) && 
                (
                    this.MinimalQuantity == input.MinimalQuantity ||
                    (this.MinimalQuantity != null &&
                    this.MinimalQuantity.Equals(input.MinimalQuantity))
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.QuantityStep == input.QuantityStep ||
                    (this.QuantityStep != null &&
                    this.QuantityStep.Equals(input.QuantityStep))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.TaxClass == input.TaxClass ||
                    (this.TaxClass != null &&
                    this.TaxClass.Equals(input.TaxClass))
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
                if (this.ComponentChangeWeight != null)
                    hashCode = hashCode * 59 + this.ComponentChangeWeight.GetHashCode();
                if (this.ComponentGroup != null)
                    hashCode = hashCode * 59 + this.ComponentGroup.GetHashCode();
                if (this.DefaultComponent != null)
                    hashCode = hashCode * 59 + this.DefaultComponent.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.MaximalQuantity != null)
                    hashCode = hashCode * 59 + this.MaximalQuantity.GetHashCode();
                if (this.MinimalQuantity != null)
                    hashCode = hashCode * 59 + this.MinimalQuantity.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.QuantityStep != null)
                    hashCode = hashCode * 59 + this.QuantityStep.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.TaxClass != null)
                    hashCode = hashCode * 59 + this.TaxClass.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
