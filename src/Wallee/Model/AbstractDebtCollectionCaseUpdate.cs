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
        /// The environment in which this case will be processed. There must be a debt collector configuration present which supports the chosen environment.
        /// </summary>
        /// <value>The environment in which this case will be processed. There must be a debt collector configuration present which supports the chosen environment.</value>
        [DataMember(Name="environment", EmitDefaultValue=true)]
        public DebtCollectionEnvironment? Environment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractDebtCollectionCaseUpdate" /> class.
        /// </summary>
        public AbstractDebtCollectionCaseUpdate()
        {
        }

        /// <summary>
        /// The billing address of the case identifies the debtor.
        /// </summary>
        /// <value>The billing address of the case identifies the debtor.</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=true)]
        public AddressCreate BillingAddress { get; set; }

        /// <summary>
        /// The contract date is the date on which the contract with the debtor was signed on.
        /// </summary>
        /// <value>The contract date is the date on which the contract with the debtor was signed on.</value>
        [DataMember(Name="contractDate", EmitDefaultValue=true)]
        public DateTime? ContractDate { get; set; }

        /// <summary>
        /// The currency defines the billing currency of the debt collection case.
        /// </summary>
        /// <value>The currency defines the billing currency of the debt collection case.</value>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; set; }

        /// <summary>
        /// The due date indicates the date on which the amount receivable was due. This date has to be always in the past.
        /// </summary>
        /// <value>The due date indicates the date on which the amount receivable was due. This date has to be always in the past.</value>
        [DataMember(Name="dueDate", EmitDefaultValue=true)]
        public DateTime? DueDate { get; set; }


        /// <summary>
        /// The language indicates the language to be used in the communication with the debtor.
        /// </summary>
        /// <value>The language indicates the language to be used in the communication with the debtor.</value>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; set; }

        /// <summary>
        /// The line items of the debt collection case will be shown on documents sent to the debtor and the total of them makes up total amount to collect.
        /// </summary>
        /// <value>The line items of the debt collection case will be shown on documents sent to the debtor and the total of them makes up total amount to collect.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=true)]
        public List<LineItemCreate> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets SpaceViewId
        /// </summary>
        [DataMember(Name="spaceViewId", EmitDefaultValue=true)]
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
