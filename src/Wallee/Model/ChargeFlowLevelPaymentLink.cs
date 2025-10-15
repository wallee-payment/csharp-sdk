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
    /// ChargeFlowLevelPaymentLink
    /// </summary>
    [DataContract]
    public partial class ChargeFlowLevelPaymentLink :  IEquatable<ChargeFlowLevelPaymentLink>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeFlowLevelPaymentLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ChargeFlowLevelPaymentLink()
        {
        }

        /// <summary>
        /// The charge flow level that the payment link belongs to.
        /// </summary>
        /// <value>The charge flow level that the payment link belongs to.</value>
        [DataMember(Name="chargeFlowLevel", EmitDefaultValue=false)]
        public ChargeFlowLevel ChargeFlowLevel { get; private set; }

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
        /// The URL provided to the customer for entering their payment details and completing the transaction.
        /// </summary>
        /// <value>The URL provided to the customer for entering their payment details and completing the transaction.</value>
        [DataMember(Name="paymentLink", EmitDefaultValue=false)]
        public string PaymentLink { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargeFlowLevelPaymentLink {\n");
            sb.Append("  ChargeFlowLevel: ").Append(ChargeFlowLevel).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  PaymentLink: ").Append(PaymentLink).Append("\n");
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
            return this.Equals(input as ChargeFlowLevelPaymentLink);
        }

        /// <summary>
        /// Returns true if ChargeFlowLevelPaymentLink instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeFlowLevelPaymentLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeFlowLevelPaymentLink input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChargeFlowLevel == input.ChargeFlowLevel ||
                    (this.ChargeFlowLevel != null &&
                    this.ChargeFlowLevel.Equals(input.ChargeFlowLevel))
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
                    this.PaymentLink == input.PaymentLink ||
                    (this.PaymentLink != null &&
                    this.PaymentLink.Equals(input.PaymentLink))
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
                if (this.ChargeFlowLevel != null)
                    hashCode = hashCode * 59 + this.ChargeFlowLevel.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.PaymentLink != null)
                    hashCode = hashCode * 59 + this.PaymentLink.GetHashCode();
                return hashCode;
            }
        }

    }

}
