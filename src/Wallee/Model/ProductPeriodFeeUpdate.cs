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
    /// ProductPeriodFeeUpdate
    /// </summary>
    [DataContract]
    public partial class ProductPeriodFeeUpdate :  IEquatable<ProductPeriodFeeUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPeriodFeeUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductPeriodFeeUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPeriodFeeUpdate" /> class.
        /// </summary>
        /// <param name="id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required).</param>
        /// <param name="version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public ProductPeriodFeeUpdate(long? id, long? version)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ProductPeriodFeeUpdate and cannot be null");
            }
            this.Id = id;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for ProductPeriodFeeUpdate and cannot be null");
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
        /// Gets or Sets Component
        /// </summary>
        [DataMember(Name="component", EmitDefaultValue=false)]
        public long? Component { get; set; }

        /// <summary>
        /// The description of a component fee describes the fee to the subscriber. The description may be shown in documents or on certain user interfaces.
        /// </summary>
        /// <value>The description of a component fee describes the fee to the subscriber. The description may be shown in documents or on certain user interfaces.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public DatabaseTranslatedStringCreate Description { get; set; }

        /// <summary>
        /// The ledger entry title will be used for the title in the ledger entry and in the invoice.
        /// </summary>
        /// <value>The ledger entry title will be used for the title in the ledger entry and in the invoice.</value>
        [DataMember(Name="ledgerEntryTitle", EmitDefaultValue=false)]
        public DatabaseTranslatedStringCreate LedgerEntryTitle { get; set; }

        /// <summary>
        /// The name of the fee should describe for the subscriber in few words for what the fee is for.
        /// </summary>
        /// <value>The name of the fee should describe for the subscriber in few words for what the fee is for.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public DatabaseTranslatedStringCreate Name { get; set; }

        /// <summary>
        /// The number of free trial periods specify how many periods are free of charge at the begining of the subscription.
        /// </summary>
        /// <value>The number of free trial periods specify how many periods are free of charge at the begining of the subscription.</value>
        [DataMember(Name="numberOfFreeTrialPeriods", EmitDefaultValue=false)]
        public int? NumberOfFreeTrialPeriods { get; set; }

        /// <summary>
        /// The period fee is charged for every period of the subscription except for those periods which are trial periods.
        /// </summary>
        /// <value>The period fee is charged for every period of the subscription except for those periods which are trial periods.</value>
        [DataMember(Name="periodFee", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmountUpdate> PeriodFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductPeriodFeeUpdate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Component: ").Append(Component).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LedgerEntryTitle: ").Append(LedgerEntryTitle).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumberOfFreeTrialPeriods: ").Append(NumberOfFreeTrialPeriods).Append("\n");
            sb.Append("  PeriodFee: ").Append(PeriodFee).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductPeriodFeeUpdate);
        }

        /// <summary>
        /// Returns true if ProductPeriodFeeUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductPeriodFeeUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductPeriodFeeUpdate input)
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
                    this.LedgerEntryTitle == input.LedgerEntryTitle ||
                    (this.LedgerEntryTitle != null &&
                    this.LedgerEntryTitle.Equals(input.LedgerEntryTitle))
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
                    this.PeriodFee.SequenceEqual(input.PeriodFee)
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
                if (this.LedgerEntryTitle != null)
                    hashCode = hashCode * 59 + this.LedgerEntryTitle.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NumberOfFreeTrialPeriods != null)
                    hashCode = hashCode * 59 + this.NumberOfFreeTrialPeriods.GetHashCode();
                if (this.PeriodFee != null)
                    hashCode = hashCode * 59 + this.PeriodFee.GetHashCode();
                return hashCode;
            }
        }

    }

}
