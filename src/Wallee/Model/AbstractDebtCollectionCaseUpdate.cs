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
    /// AbstractDebtCollectionCaseUpdate
    /// </summary>
    [DataContract]
    public partial class AbstractDebtCollectionCaseUpdate :  IEquatable<AbstractDebtCollectionCaseUpdate>
    {
        /// <summary>
        /// The environment in which the case is processed.
        /// </summary>
        /// <value>The environment in which the case is processed.</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public DebtCollectionEnvironment? Environment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractDebtCollectionCaseUpdate" /> class.
        /// </summary>
        public AbstractDebtCollectionCaseUpdate()
        {
        }

        /// <summary>
        /// The billing address that identifies the debtor.
        /// </summary>
        /// <value>The billing address that identifies the debtor.</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public AddressCreate BillingAddress { get; set; }

        /// <summary>
        /// The date and time when the contract with the debtor was signed.
        /// </summary>
        /// <value>The date and time when the contract with the debtor was signed.</value>
        [DataMember(Name="contractDate", EmitDefaultValue=false)]
        public DateTime? ContractDate { get; set; }

        /// <summary>
        /// The three-letter code (ISO 4217 format) of the case&#39;s currency.
        /// </summary>
        /// <value>The three-letter code (ISO 4217 format) of the case&#39;s currency.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The date and time when the claim was due.
        /// </summary>
        /// <value>The date and time when the claim was due.</value>
        [DataMember(Name="dueDate", EmitDefaultValue=false)]
        public DateTime? DueDate { get; set; }


        /// <summary>
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The line items that are subject of this debt collection case.
        /// </summary>
        /// <value>The line items that are subject of this debt collection case.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItemCreate> LineItems { get; set; }

        /// <summary>
        /// The ID of the space view this object is linked to.
        /// </summary>
        /// <value>The ID of the space view this object is linked to.</value>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractDebtCollectionCaseUpdate {\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ContractDate: ").Append(ContractDate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
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
            return this.Equals(input as AbstractDebtCollectionCaseUpdate);
        }

        /// <summary>
        /// Returns true if AbstractDebtCollectionCaseUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of AbstractDebtCollectionCaseUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractDebtCollectionCaseUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.ContractDate == input.ContractDate ||
                    (this.ContractDate != null &&
                    this.ContractDate.Equals(input.ContractDate))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.SpaceViewId == input.SpaceViewId ||
                    (this.SpaceViewId != null &&
                    this.SpaceViewId.Equals(input.SpaceViewId))
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
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.ContractDate != null)
                    hashCode = hashCode * 59 + this.ContractDate.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.SpaceViewId != null)
                    hashCode = hashCode * 59 + this.SpaceViewId.GetHashCode();
                return hashCode;
            }
        }

    }

}
