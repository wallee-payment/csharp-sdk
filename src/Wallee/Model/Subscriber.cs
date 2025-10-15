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
    /// A subscriber represents everyone who is subscribed to a product.
    /// </summary>
    [DataContract]
    public partial class Subscriber :  IEquatable<Subscriber>
    {
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscriber" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Subscriber()
        {
        }

        /// <summary>
        /// Allow the subscriber to use these payment methods even if subscription products do not accept them.
        /// </summary>
        /// <value>Allow the subscriber to use these payment methods even if subscription products do not accept them.</value>
        [DataMember(Name="additionalAllowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<long?> AdditionalAllowedPaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// The address associated with the subscriber for invoicing and transaction processing purposes.
        /// </summary>
        /// <value>The address associated with the subscriber for invoicing and transaction processing purposes.</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public Address BillingAddress { get; private set; }

        /// <summary>
        /// The description used to identify the subscriber.
        /// </summary>
        /// <value>The description used to identify the subscriber.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }

        /// <summary>
        /// Prevent the subscriber from using these payment methods even if subscription products do accept them.
        /// </summary>
        /// <value>Prevent the subscriber from using these payment methods even if subscription products do accept them.</value>
        [DataMember(Name="disallowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<long?> DisallowedPaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// The email address that is used to communicate with the subscriber. There can be only one subscriber per space with the same email address.
        /// </summary>
        /// <value>The email address that is used to communicate with the subscriber. There can be only one subscriber per space with the same email address.</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; private set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The language that is used when communicating with the subscriber via emails and documents.
        /// </summary>
        /// <value>The language that is used when communicating with the subscriber via emails and documents.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// Allow to store additional information about the object.
        /// </summary>
        /// <value>Allow to store additional information about the object.</value>
        [DataMember(Name="metaData", EmitDefaultValue=false)]
        public Dictionary<string, string> MetaData { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The merchant&#39;s reference used to identify the subscriber.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the subscriber.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; private set; }

        /// <summary>
        /// The address to where orders will be shipped.
        /// </summary>
        /// <value>The address to where orders will be shipped.</value>
        [DataMember(Name="shippingAddress", EmitDefaultValue=false)]
        public Address ShippingAddress { get; private set; }


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
            sb.Append("class Subscriber {\n");
            sb.Append("  AdditionalAllowedPaymentMethodConfigurations: ").Append(AdditionalAllowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisallowedPaymentMethodConfigurations: ").Append(DisallowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
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
            return this.Equals(input as Subscriber);
        }

        /// <summary>
        /// Returns true if Subscriber instances are equal
        /// </summary>
        /// <param name="input">Instance of Subscriber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subscriber input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalAllowedPaymentMethodConfigurations == input.AdditionalAllowedPaymentMethodConfigurations ||
                    this.AdditionalAllowedPaymentMethodConfigurations != null &&
                    input.AdditionalAllowedPaymentMethodConfigurations != null &&
                    this.AdditionalAllowedPaymentMethodConfigurations.SequenceEqual(input.AdditionalAllowedPaymentMethodConfigurations)
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisallowedPaymentMethodConfigurations == input.DisallowedPaymentMethodConfigurations ||
                    this.DisallowedPaymentMethodConfigurations != null &&
                    input.DisallowedPaymentMethodConfigurations != null &&
                    this.DisallowedPaymentMethodConfigurations.SequenceEqual(input.DisallowedPaymentMethodConfigurations)
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.MetaData == input.MetaData ||
                    this.MetaData != null &&
                    input.MetaData != null &&
                    this.MetaData.SequenceEqual(input.MetaData)
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                if (this.AdditionalAllowedPaymentMethodConfigurations != null)
                    hashCode = hashCode * 59 + this.AdditionalAllowedPaymentMethodConfigurations.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisallowedPaymentMethodConfigurations != null)
                    hashCode = hashCode * 59 + this.DisallowedPaymentMethodConfigurations.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.MetaData != null)
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.ShippingAddress != null)
                    hashCode = hashCode * 59 + this.ShippingAddress.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
