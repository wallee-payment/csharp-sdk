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
    /// The debt collection case represents a try to collect the money from the debtor.
    /// </summary>
    [DataContract]
    public partial class DebtCollectionCaseCreate : AbstractDebtCollectionCaseUpdate,  IEquatable<DebtCollectionCaseCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectionCaseCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DebtCollectionCaseCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectionCaseCreate" /> class.
        /// </summary>
        /// <param name="externalId">A client generated nonce which identifies the entity to be created. Subsequent creation requests with the same external ID will not create new entities but return the initially created entity instead. (required).</param>
        /// <param name="reference">The case reference is used in the communication with the debtor. It should be unique and it should be linkable with the source of the debt collection case. (required).</param>
        public DebtCollectionCaseCreate(string externalId, string reference)
        {
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new InvalidDataException("externalId is a required property for DebtCollectionCaseCreate and cannot be null");
            }
            this.ExternalId = externalId;
            // to ensure "reference" is required (not null)
            if (reference == null)
            {
                throw new InvalidDataException("reference is a required property for DebtCollectionCaseCreate and cannot be null");
            }
            this.Reference = reference;
        }









        /// <summary>
        /// The collector configuration determines how the debt collection case is processed.
        /// </summary>
        /// <value>The collector configuration determines how the debt collection case is processed.</value>
        [DataMember(Name="collectorConfiguration", EmitDefaultValue=false)]
        public long? CollectorConfiguration { get; set; }

        /// <summary>
        /// A client generated nonce which identifies the entity to be created. Subsequent creation requests with the same external ID will not create new entities but return the initially created entity instead.
        /// </summary>
        /// <value>A client generated nonce which identifies the entity to be created. Subsequent creation requests with the same external ID will not create new entities but return the initially created entity instead.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The case reference is used in the communication with the debtor. It should be unique and it should be linkable with the source of the debt collection case.
        /// </summary>
        /// <value>The case reference is used in the communication with the debtor. It should be unique and it should be linkable with the source of the debt collection case.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DebtCollectionCaseCreate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ContractDate: ").Append(ContractDate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  CollectorConfiguration: ").Append(CollectorConfiguration).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as DebtCollectionCaseCreate);
        }

        /// <summary>
        /// Returns true if DebtCollectionCaseCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of DebtCollectionCaseCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebtCollectionCaseCreate input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && base.Equals(input) && 
                (
                    this.ContractDate == input.ContractDate ||
                    (this.ContractDate != null &&
                    this.ContractDate.Equals(input.ContractDate))
                ) && base.Equals(input) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && base.Equals(input) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && base.Equals(input) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && base.Equals(input) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && base.Equals(input) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && base.Equals(input) && 
                (
                    this.SpaceViewId == input.SpaceViewId ||
                    (this.SpaceViewId != null &&
                    this.SpaceViewId.Equals(input.SpaceViewId))
                ) && base.Equals(input) && 
                (
                    this.CollectorConfiguration == input.CollectorConfiguration ||
                    (this.CollectorConfiguration != null &&
                    this.CollectorConfiguration.Equals(input.CollectorConfiguration))
                ) && base.Equals(input) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && base.Equals(input) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                int hashCode = base.GetHashCode();
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
                if (this.CollectorConfiguration != null)
                    hashCode = hashCode * 59 + this.CollectorConfiguration.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                return hashCode;
            }
        }

    }

}
