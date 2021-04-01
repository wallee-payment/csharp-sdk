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
        /// Gets or Sets Environment
        /// </summary>
        [DataMember(Name="environment", EmitDefaultValue=true)]
        public ChargeAttemptEnvironment? Environment { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public TokenVersionState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TokenVersion()
        {
        }

        /// <summary>
        /// Gets or Sets ActivatedOn
        /// </summary>
        [DataMember(Name="activatedOn", EmitDefaultValue=true)]
        public DateTime? ActivatedOn { get; private set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="billingAddress", EmitDefaultValue=true)]
        public Address BillingAddress { get; private set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=true)]
        public DateTime? CreatedOn { get; private set; }


        /// <summary>
        /// The expires on date indicates when token version expires. Once this date is reached the token version is marked as obsolete.
        /// </summary>
        /// <value>The expires on date indicates when token version expires. Once this date is reached the token version is marked as obsolete.</value>
        [DataMember(Name="expiresOn", EmitDefaultValue=true)]
        public DateTime? ExpiresOn { get; private set; }

        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [DataMember(Name="iconUrl", EmitDefaultValue=true)]
        public string IconUrl { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name="labels", EmitDefaultValue=true)]
        public List<Label> Labels { get; private set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=true)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets ObsoletedOn
        /// </summary>
        [DataMember(Name="obsoletedOn", EmitDefaultValue=true)]
        public DateTime? ObsoletedOn { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentConnectorConfiguration
        /// </summary>
        [DataMember(Name="paymentConnectorConfiguration", EmitDefaultValue=true)]
        public PaymentConnectorConfiguration PaymentConnectorConfiguration { get; private set; }

        /// <summary>
        /// The payment information hash set contains hashes of the payment information represented by this token version.
        /// </summary>
        /// <value>The payment information hash set contains hashes of the payment information represented by this token version.</value>
        [DataMember(Name="paymentInformationHashes", EmitDefaultValue=true)]
        public List<PaymentInformationHash> PaymentInformationHashes { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="paymentMethod", EmitDefaultValue=true)]
        public long? PaymentMethod { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentMethodBrand
        /// </summary>
        [DataMember(Name="paymentMethodBrand", EmitDefaultValue=true)]
        public long? PaymentMethodBrand { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=true)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Gets or Sets ProcessorToken
        /// </summary>
        [DataMember(Name="processorToken", EmitDefaultValue=true)]
        public string ProcessorToken { get; private set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name="shippingAddress", EmitDefaultValue=true)]
        public Address ShippingAddress { get; private set; }


        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=true)]
        public Token Token { get; private set; }

        /// <summary>
        /// The token version type determines what kind of token it is and by which payment connector the token can be processed by.
        /// </summary>
        /// <value>The token version type determines what kind of token it is and by which payment connector the token can be processed by.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TokenVersionType Type { get; private set; }

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
