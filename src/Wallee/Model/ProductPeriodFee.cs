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
    /// ProductPeriodFee
    /// </summary>
    [DataContract]
    public partial class ProductPeriodFee :  IEquatable<ProductPeriodFee>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public ProductFeeType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPeriodFee" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ProductPeriodFee()
        {
        }

        /// <summary>
        /// Gets or Sets Component
        /// </summary>
        [DataMember(Name="component", EmitDefaultValue=true)]
        public SubscriptionProductComponent Component { get; private set; }

        /// <summary>
        /// The description of a component fee describes the fee to the subscriber. The description may be shown in documents or on certain user interfaces.
        /// </summary>
        /// <value>The description of a component fee describes the fee to the subscriber. The description may be shown in documents or on certain user interfaces.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public DatabaseTranslatedString Description { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// The ledger entry title will be used for the title in the ledger entry and in the invoice.
        /// </summary>
        /// <value>The ledger entry title will be used for the title in the ledger entry and in the invoice.</value>
        [DataMember(Name="ledgerEntryTitle", EmitDefaultValue=true)]
        public DatabaseTranslatedString LedgerEntryTitle { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=true)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The name of the fee should describe for the subscriber in few words for what the fee is for.
        /// </summary>
        /// <value>The name of the fee should describe for the subscriber in few words for what the fee is for.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public DatabaseTranslatedString Name { get; private set; }

        /// <summary>
        /// The number of free trial periods specify how many periods are free of charge at the begining of the subscription.
        /// </summary>
        /// <value>The number of free trial periods specify how many periods are free of charge at the begining of the subscription.</value>
        [DataMember(Name="numberOfFreeTrialPeriods", EmitDefaultValue=true)]
        public int? NumberOfFreeTrialPeriods { get; private set; }

        /// <summary>
        /// The period fee is charged for every period of the subscription except for those periods which are trial periods.
        /// </summary>
        /// <value>The period fee is charged for every period of the subscription except for those periods which are trial periods.</value>
        [DataMember(Name="periodFee", EmitDefaultValue=true)]
        public List<PersistableCurrencyAmount> PeriodFee { get; private set; }


        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductPeriodFee {\n");
            sb.Append("  Component: ").Append(Component).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LedgerEntryTitle: ").Append(LedgerEntryTitle).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumberOfFreeTrialPeriods: ").Append(NumberOfFreeTrialPeriods).Append("\n");
            sb.Append("  PeriodFee: ").Append(PeriodFee).Append("\n");
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
            return this.Equals(input as ProductPeriodFee);
        }

        /// <summary>
        /// Returns true if ProductPeriodFee instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductPeriodFee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductPeriodFee input)
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
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LedgerEntryTitle == input.LedgerEntryTitle ||
                    (this.LedgerEntryTitle != null &&
                    this.LedgerEntryTitle.Equals(input.LedgerEntryTitle))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NumberOfFreeTrialPeriods == input.NumberOfFreeTrialPeriods ||
                    (this.NumberOfFreeTrialPeriods != null &&
                    this.NumberOfFreeTrialPeriods.Equals(input.NumberOfFreeTrialPeriods))
                ) && 
                (
                    this.PeriodFee == input.PeriodFee ||
                    this.PeriodFee != null &&
                    input.PeriodFee != null &&
                    this.PeriodFee.SequenceEqual(input.PeriodFee)
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
                if (this.LedgerEntryTitle != null)
                    hashCode = hashCode * 59 + this.LedgerEntryTitle.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NumberOfFreeTrialPeriods != null)
                    hashCode = hashCode * 59 + this.NumberOfFreeTrialPeriods.GetHashCode();
                if (this.PeriodFee != null)
                    hashCode = hashCode * 59 + this.PeriodFee.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
