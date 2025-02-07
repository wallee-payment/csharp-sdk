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
    /// InvoiceReimbursement
    /// </summary>
    [DataContract]
    public partial class InvoiceReimbursement :  IEquatable<InvoiceReimbursement>
    {
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public InvoiceReimbursementState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceReimbursement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public InvoiceReimbursement()
        {
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; private set; }

        /// <summary>
        /// Gets or Sets DiscardedBy
        /// </summary>
        [DataMember(Name="discardedBy", EmitDefaultValue=false)]
        public long? DiscardedBy { get; private set; }

        /// <summary>
        /// Gets or Sets DiscardedOn
        /// </summary>
        [DataMember(Name="discardedOn", EmitDefaultValue=false)]
        public DateTime? DiscardedOn { get; private set; }

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
        /// Gets or Sets PaymentConnectorConfiguration
        /// </summary>
        [DataMember(Name="paymentConnectorConfiguration", EmitDefaultValue=false)]
        public PaymentConnectorConfiguration PaymentConnectorConfiguration { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentInitiationAdviceFile
        /// </summary>
        [DataMember(Name="paymentInitiationAdviceFile", EmitDefaultValue=false)]
        public PaymentInitiationAdviceFile PaymentInitiationAdviceFile { get; private set; }

        /// <summary>
        /// Gets or Sets ProcessedBy
        /// </summary>
        [DataMember(Name="processedBy", EmitDefaultValue=false)]
        public long? ProcessedBy { get; private set; }

        /// <summary>
        /// Gets or Sets ProcessedOn
        /// </summary>
        [DataMember(Name="processedOn", EmitDefaultValue=false)]
        public DateTime? ProcessedOn { get; private set; }

        /// <summary>
        /// Gets or Sets RecipientCity
        /// </summary>
        [DataMember(Name="recipientCity", EmitDefaultValue=false)]
        public string RecipientCity { get; private set; }

        /// <summary>
        /// Gets or Sets RecipientCountry
        /// </summary>
        [DataMember(Name="recipientCountry", EmitDefaultValue=false)]
        public string RecipientCountry { get; private set; }

        /// <summary>
        /// Gets or Sets RecipientFamilyName
        /// </summary>
        [DataMember(Name="recipientFamilyName", EmitDefaultValue=false)]
        public string RecipientFamilyName { get; private set; }

        /// <summary>
        /// Gets or Sets RecipientGivenName
        /// </summary>
        [DataMember(Name="recipientGivenName", EmitDefaultValue=false)]
        public string RecipientGivenName { get; private set; }

        /// <summary>
        /// Gets or Sets RecipientIban
        /// </summary>
        [DataMember(Name="recipientIban", EmitDefaultValue=false)]
        public string RecipientIban { get; private set; }

        /// <summary>
        /// Gets or Sets RecipientOrganizationName
        /// </summary>
        [DataMember(Name="recipientOrganizationName", EmitDefaultValue=false)]
        public string RecipientOrganizationName { get; private set; }

        /// <summary>
        /// Gets or Sets RecipientPostcode
        /// </summary>
        [DataMember(Name="recipientPostcode", EmitDefaultValue=false)]
        public string RecipientPostcode { get; private set; }

        /// <summary>
        /// Gets or Sets RecipientStreet
        /// </summary>
        [DataMember(Name="recipientStreet", EmitDefaultValue=false)]
        public string RecipientStreet { get; private set; }

        /// <summary>
        /// Gets or Sets SenderIban
        /// </summary>
        [DataMember(Name="senderIban", EmitDefaultValue=false)]
        public string SenderIban { get; private set; }


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
            sb.Append("class InvoiceReimbursement {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DiscardedBy: ").Append(DiscardedBy).Append("\n");
            sb.Append("  DiscardedOn: ").Append(DiscardedOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  PaymentConnectorConfiguration: ").Append(PaymentConnectorConfiguration).Append("\n");
            sb.Append("  PaymentInitiationAdviceFile: ").Append(PaymentInitiationAdviceFile).Append("\n");
            sb.Append("  ProcessedBy: ").Append(ProcessedBy).Append("\n");
            sb.Append("  ProcessedOn: ").Append(ProcessedOn).Append("\n");
            sb.Append("  RecipientCity: ").Append(RecipientCity).Append("\n");
            sb.Append("  RecipientCountry: ").Append(RecipientCountry).Append("\n");
            sb.Append("  RecipientFamilyName: ").Append(RecipientFamilyName).Append("\n");
            sb.Append("  RecipientGivenName: ").Append(RecipientGivenName).Append("\n");
            sb.Append("  RecipientIban: ").Append(RecipientIban).Append("\n");
            sb.Append("  RecipientOrganizationName: ").Append(RecipientOrganizationName).Append("\n");
            sb.Append("  RecipientPostcode: ").Append(RecipientPostcode).Append("\n");
            sb.Append("  RecipientStreet: ").Append(RecipientStreet).Append("\n");
            sb.Append("  SenderIban: ").Append(SenderIban).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as InvoiceReimbursement);
        }

        /// <summary>
        /// Returns true if InvoiceReimbursement instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceReimbursement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceReimbursement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.DiscardedBy == input.DiscardedBy ||
                    (this.DiscardedBy != null &&
                    this.DiscardedBy.Equals(input.DiscardedBy))
                ) && 
                (
                    this.DiscardedOn == input.DiscardedOn ||
                    (this.DiscardedOn != null &&
                    this.DiscardedOn.Equals(input.DiscardedOn))
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
                    this.PaymentConnectorConfiguration == input.PaymentConnectorConfiguration ||
                    (this.PaymentConnectorConfiguration != null &&
                    this.PaymentConnectorConfiguration.Equals(input.PaymentConnectorConfiguration))
                ) && 
                (
                    this.PaymentInitiationAdviceFile == input.PaymentInitiationAdviceFile ||
                    (this.PaymentInitiationAdviceFile != null &&
                    this.PaymentInitiationAdviceFile.Equals(input.PaymentInitiationAdviceFile))
                ) && 
                (
                    this.ProcessedBy == input.ProcessedBy ||
                    (this.ProcessedBy != null &&
                    this.ProcessedBy.Equals(input.ProcessedBy))
                ) && 
                (
                    this.ProcessedOn == input.ProcessedOn ||
                    (this.ProcessedOn != null &&
                    this.ProcessedOn.Equals(input.ProcessedOn))
                ) && 
                (
                    this.RecipientCity == input.RecipientCity ||
                    (this.RecipientCity != null &&
                    this.RecipientCity.Equals(input.RecipientCity))
                ) && 
                (
                    this.RecipientCountry == input.RecipientCountry ||
                    (this.RecipientCountry != null &&
                    this.RecipientCountry.Equals(input.RecipientCountry))
                ) && 
                (
                    this.RecipientFamilyName == input.RecipientFamilyName ||
                    (this.RecipientFamilyName != null &&
                    this.RecipientFamilyName.Equals(input.RecipientFamilyName))
                ) && 
                (
                    this.RecipientGivenName == input.RecipientGivenName ||
                    (this.RecipientGivenName != null &&
                    this.RecipientGivenName.Equals(input.RecipientGivenName))
                ) && 
                (
                    this.RecipientIban == input.RecipientIban ||
                    (this.RecipientIban != null &&
                    this.RecipientIban.Equals(input.RecipientIban))
                ) && 
                (
                    this.RecipientOrganizationName == input.RecipientOrganizationName ||
                    (this.RecipientOrganizationName != null &&
                    this.RecipientOrganizationName.Equals(input.RecipientOrganizationName))
                ) && 
                (
                    this.RecipientPostcode == input.RecipientPostcode ||
                    (this.RecipientPostcode != null &&
                    this.RecipientPostcode.Equals(input.RecipientPostcode))
                ) && 
                (
                    this.RecipientStreet == input.RecipientStreet ||
                    (this.RecipientStreet != null &&
                    this.RecipientStreet.Equals(input.RecipientStreet))
                ) && 
                (
                    this.SenderIban == input.SenderIban ||
                    (this.SenderIban != null &&
                    this.SenderIban.Equals(input.SenderIban))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.DiscardedBy != null)
                    hashCode = hashCode * 59 + this.DiscardedBy.GetHashCode();
                if (this.DiscardedOn != null)
                    hashCode = hashCode * 59 + this.DiscardedOn.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.PaymentConnectorConfiguration != null)
                    hashCode = hashCode * 59 + this.PaymentConnectorConfiguration.GetHashCode();
                if (this.PaymentInitiationAdviceFile != null)
                    hashCode = hashCode * 59 + this.PaymentInitiationAdviceFile.GetHashCode();
                if (this.ProcessedBy != null)
                    hashCode = hashCode * 59 + this.ProcessedBy.GetHashCode();
                if (this.ProcessedOn != null)
                    hashCode = hashCode * 59 + this.ProcessedOn.GetHashCode();
                if (this.RecipientCity != null)
                    hashCode = hashCode * 59 + this.RecipientCity.GetHashCode();
                if (this.RecipientCountry != null)
                    hashCode = hashCode * 59 + this.RecipientCountry.GetHashCode();
                if (this.RecipientFamilyName != null)
                    hashCode = hashCode * 59 + this.RecipientFamilyName.GetHashCode();
                if (this.RecipientGivenName != null)
                    hashCode = hashCode * 59 + this.RecipientGivenName.GetHashCode();
                if (this.RecipientIban != null)
                    hashCode = hashCode * 59 + this.RecipientIban.GetHashCode();
                if (this.RecipientOrganizationName != null)
                    hashCode = hashCode * 59 + this.RecipientOrganizationName.GetHashCode();
                if (this.RecipientPostcode != null)
                    hashCode = hashCode * 59 + this.RecipientPostcode.GetHashCode();
                if (this.RecipientStreet != null)
                    hashCode = hashCode * 59 + this.RecipientStreet.GetHashCode();
                if (this.SenderIban != null)
                    hashCode = hashCode * 59 + this.SenderIban.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
