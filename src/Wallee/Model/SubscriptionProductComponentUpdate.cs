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
    /// SubscriptionProductComponentUpdate
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductComponentUpdate :  IEquatable<SubscriptionProductComponentUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductComponentUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionProductComponentUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductComponentUpdate" /> class.
        /// </summary>
        /// <param name="id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required).</param>
        /// <param name="version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public SubscriptionProductComponentUpdate(long? id, long? version)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SubscriptionProductComponentUpdate and cannot be null");
            }
            this.Id = id;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for SubscriptionProductComponentUpdate and cannot be null");
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
        /// If a product component changes from one with a lower product component tier (e.g. 1) to one with a higher product component tier (e.g. 3), it is considered an upgrade and a one-time fee could be applied.
        /// </summary>
        /// <value>If a product component changes from one with a lower product component tier (e.g. 1) to one with a higher product component tier (e.g. 3), it is considered an upgrade and a one-time fee could be applied.</value>
        [DataMember(Name="componentChangeWeight", EmitDefaultValue=false)]
        public int? ComponentChangeWeight { get; set; }

        /// <summary>
        /// Gets or Sets ComponentGroup
        /// </summary>
        [DataMember(Name="componentGroup", EmitDefaultValue=false)]
        public long? ComponentGroup { get; set; }

        /// <summary>
        /// When a component is marked as a &#39;default&#39; component it is used as the default component in its group and will be preselected in the product configuration.
        /// </summary>
        /// <value>When a component is marked as a &#39;default&#39; component it is used as the default component in its group and will be preselected in the product configuration.</value>
        [DataMember(Name="defaultComponent", EmitDefaultValue=false)]
        public bool? DefaultComponent { get; set; }

        /// <summary>
        /// The component description may contain a longer description which gives the subscriber a better understanding of what the component contains.
        /// </summary>
        /// <value>The component description may contain a longer description which gives the subscriber a better understanding of what the component contains.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; set; }

        /// <summary>
        /// The maximum quantity defines the maximum value which must be entered for the quantity.
        /// </summary>
        /// <value>The maximum quantity defines the maximum value which must be entered for the quantity.</value>
        [DataMember(Name="maximalQuantity", EmitDefaultValue=false)]
        public decimal? MaximalQuantity { get; set; }

        /// <summary>
        /// The minimal quantity defines the minimum value which must be entered for the quantity.
        /// </summary>
        /// <value>The minimal quantity defines the minimum value which must be entered for the quantity.</value>
        [DataMember(Name="minimalQuantity", EmitDefaultValue=false)]
        public decimal? MinimalQuantity { get; set; }

        /// <summary>
        /// The component name is shown to the subscriber. It should describe in few words what the component does contain.
        /// </summary>
        /// <value>The component name is shown to the subscriber. It should describe in few words what the component does contain.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// The quantity step defines at which interval the quantity can be increased.
        /// </summary>
        /// <value>The quantity step defines at which interval the quantity can be increased.</value>
        [DataMember(Name="quantityStep", EmitDefaultValue=false)]
        public decimal? QuantityStep { get; set; }

        /// <summary>
        /// The component reference is used to identify the component by external systems and it marks components to represent the same component within different product versions.
        /// </summary>
        /// <value>The component reference is used to identify the component by external systems and it marks components to represent the same component within different product versions.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public long? Reference { get; set; }

        /// <summary>
        /// The sort order controls in which order the component is listed. The sort order is used to order the components in ascending order.
        /// </summary>
        /// <value>The sort order controls in which order the component is listed. The sort order is used to order the components in ascending order.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; set; }

        /// <summary>
        /// The tax class of the component determines the taxes which are applicable on all fees linked with the component.
        /// </summary>
        /// <value>The tax class of the component determines the taxes which are applicable on all fees linked with the component.</value>
        [DataMember(Name="taxClass", EmitDefaultValue=false)]
        public long? TaxClass { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionProductComponentUpdate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ComponentChangeWeight: ").Append(ComponentChangeWeight).Append("\n");
            sb.Append("  ComponentGroup: ").Append(ComponentGroup).Append("\n");
            sb.Append("  DefaultComponent: ").Append(DefaultComponent).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MaximalQuantity: ").Append(MaximalQuantity).Append("\n");
            sb.Append("  MinimalQuantity: ").Append(MinimalQuantity).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  QuantityStep: ").Append(QuantityStep).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  TaxClass: ").Append(TaxClass).Append("\n");
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
            return this.Equals(input as SubscriptionProductComponentUpdate);
        }

        /// <summary>
        /// Returns true if SubscriptionProductComponentUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionProductComponentUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductComponentUpdate input)
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
                if (this.ComponentChangeWeight != null)
                    hashCode = hashCode * 59 + this.ComponentChangeWeight.GetHashCode();
                if (this.ComponentGroup != null)
                    hashCode = hashCode * 59 + this.ComponentGroup.GetHashCode();
                if (this.DefaultComponent != null)
                    hashCode = hashCode * 59 + this.DefaultComponent.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
                return hashCode;
            }
        }

    }

}
