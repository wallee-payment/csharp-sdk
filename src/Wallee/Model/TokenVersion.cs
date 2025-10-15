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
    /// TokenVersion
    /// </summary>
    [DataContract]
    public partial class TokenVersion :  IEquatable<TokenVersion>
    {
        /// <summary>
        /// The environment in which the token version was created.
        /// </summary>
        /// <value>The environment in which the token version was created.</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public ChargeAttemptEnvironment? Environment { get; private set; }
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public TokenVersionState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TokenVersion()
        {
        }

        /// <summary>
        /// The date and time when the token version was activated.
        /// </summary>
        /// <value>The date and time when the token version was activated.</value>
        [DataMember(Name="activatedOn", EmitDefaultValue=false)]
        public DateTime? ActivatedOn { get; private set; }

        /// <summary>
        /// The billing address to be used for the transaction if no explicit billing address is provided during payment processing.
        /// </summary>
        /// <value>The billing address to be used for the transaction if no explicit billing address is provided during payment processing.</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public Address BillingAddress { get; private set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }


        /// <summary>
        /// The date and time when the token version is set to expire, after which it will be marked as obsolete.
        /// </summary>
        /// <value>The date and time when the token version is set to expire, after which it will be marked as obsolete.</value>
        [DataMember(Name="expiresOn", EmitDefaultValue=false)]
        public DateTime? ExpiresOn { get; private set; }

        /// <summary>
        /// The URL to the token&#39;s icon displayed to the customer.
        /// </summary>
        /// <value>The URL to the token&#39;s icon displayed to the customer.</value>
        [DataMember(Name="iconUrl", EmitDefaultValue=false)]
        public string IconUrl { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The labels providing additional information about the object.
        /// </summary>
        /// <value>The labels providing additional information about the object.</value>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<Label> Labels { get; private set; }

        /// <summary>
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The name used to identify the token.
        /// </summary>
        /// <value>The name used to identify the token.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The date and time when the token version was marked obsolete.
        /// </summary>
        /// <value>The date and time when the token version was marked obsolete.</value>
        [DataMember(Name="obsoletedOn", EmitDefaultValue=false)]
        public DateTime? ObsoletedOn { get; private set; }

        /// <summary>
        /// The payment connector configuration that initialized the token version.
        /// </summary>
        /// <value>The payment connector configuration that initialized the token version.</value>
        [DataMember(Name="paymentConnectorConfiguration", EmitDefaultValue=false)]
        public PaymentConnectorConfiguration PaymentConnectorConfiguration { get; private set; }

        /// <summary>
        /// The hashed payment information that the token version represents.
        /// </summary>
        /// <value>The hashed payment information that the token version represents.</value>
        [DataMember(Name="paymentInformationHashes", EmitDefaultValue=false)]
        public List<PaymentInformationHash> PaymentInformationHashes { get; private set; }

        /// <summary>
        /// The payment method that initialized the token version.
        /// </summary>
        /// <value>The payment method that initialized the token version.</value>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public long? PaymentMethod { get; private set; }

        /// <summary>
        /// The payment method brand that initialized the token version.
        /// </summary>
        /// <value>The payment method brand that initialized the token version.</value>
        [DataMember(Name="paymentMethodBrand", EmitDefaultValue=false)]
        public long? PaymentMethodBrand { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The token name as specified by the processor.
        /// </summary>
        /// <value>The token name as specified by the processor.</value>
        [DataMember(Name="processorToken", EmitDefaultValue=false)]
        public string ProcessorToken { get; private set; }

        /// <summary>
        /// The shipping address to be used for the transaction if no explicit shipping address is provided during payment processing.
        /// </summary>
        /// <value>The shipping address to be used for the transaction if no explicit shipping address is provided during payment processing.</value>
        [DataMember(Name="shippingAddress", EmitDefaultValue=false)]
        public Address ShippingAddress { get; private set; }


        /// <summary>
        /// The token that the token version belongs to.
        /// </summary>
        /// <value>The token that the token version belongs to.</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public Token Token { get; private set; }

        /// <summary>
        /// The type specifies the nature of the token and identifies the payment connector capable of processing it.
        /// </summary>
        /// <value>The type specifies the nature of the token and identifies the payment connector capable of processing it.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TokenVersionType Type { get; private set; }

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
            sb.Append("class TokenVersion {\n");
            sb.Append("  ActivatedOn: ").Append(ActivatedOn).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  ExpiresOn: ").Append(ExpiresOn).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ObsoletedOn: ").Append(ObsoletedOn).Append("\n");
            sb.Append("  PaymentConnectorConfiguration: ").Append(PaymentConnectorConfiguration).Append("\n");
            sb.Append("  PaymentInformationHashes: ").Append(PaymentInformationHashes).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PaymentMethodBrand: ").Append(PaymentMethodBrand).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ProcessorToken: ").Append(ProcessorToken).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as TokenVersion);
        }

        /// <summary>
        /// Returns true if TokenVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenVersion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivatedOn == input.ActivatedOn ||
                    (this.ActivatedOn != null &&
                    this.ActivatedOn.Equals(input.ActivatedOn))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.ExpiresOn == input.ExpiresOn ||
                    (this.ExpiresOn != null &&
                    this.ExpiresOn.Equals(input.ExpiresOn))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
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
                    this.ObsoletedOn == input.ObsoletedOn ||
                    (this.ObsoletedOn != null &&
                    this.ObsoletedOn.Equals(input.ObsoletedOn))
                ) && 
                (
                    this.PaymentConnectorConfiguration == input.PaymentConnectorConfiguration ||
                    (this.PaymentConnectorConfiguration != null &&
                    this.PaymentConnectorConfiguration.Equals(input.PaymentConnectorConfiguration))
                ) && 
                (
                    this.PaymentInformationHashes == input.PaymentInformationHashes ||
                    this.PaymentInformationHashes != null &&
                    input.PaymentInformationHashes != null &&
                    this.PaymentInformationHashes.SequenceEqual(input.PaymentInformationHashes)
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.PaymentMethodBrand == input.PaymentMethodBrand ||
                    (this.PaymentMethodBrand != null &&
                    this.PaymentMethodBrand.Equals(input.PaymentMethodBrand))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.ProcessorToken == input.ProcessorToken ||
                    (this.ProcessorToken != null &&
                    this.ProcessorToken.Equals(input.ProcessorToken))
                ) && 
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.ActivatedOn != null)
                    hashCode = hashCode * 59 + this.ActivatedOn.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.ExpiresOn != null)
                    hashCode = hashCode * 59 + this.ExpiresOn.GetHashCode();
                if (this.IconUrl != null)
                    hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ObsoletedOn != null)
                    hashCode = hashCode * 59 + this.ObsoletedOn.GetHashCode();
                if (this.PaymentConnectorConfiguration != null)
                    hashCode = hashCode * 59 + this.PaymentConnectorConfiguration.GetHashCode();
                if (this.PaymentInformationHashes != null)
                    hashCode = hashCode * 59 + this.PaymentInformationHashes.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.PaymentMethodBrand != null)
                    hashCode = hashCode * 59 + this.PaymentMethodBrand.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.ProcessorToken != null)
                    hashCode = hashCode * 59 + this.ProcessorToken.GetHashCode();
                if (this.ShippingAddress != null)
                    hashCode = hashCode * 59 + this.ShippingAddress.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
