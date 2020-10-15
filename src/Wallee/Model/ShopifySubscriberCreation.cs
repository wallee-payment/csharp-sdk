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
    /// ShopifySubscriberCreation
    /// </summary>
    [DataContract]
    public partial class ShopifySubscriberCreation :  IEquatable<ShopifySubscriberCreation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriberCreation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShopifySubscriberCreation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriberCreation" /> class.
        /// </summary>
        /// <param name="shopifyCustomerId">The customer ID has to correspond to the ID assigned to the customer by Shopify. When the subscriber already exists no new subscriber will be created. (required).</param>
        public ShopifySubscriberCreation(string shopifyCustomerId)
        {
            // to ensure "shopifyCustomerId" is required (not null)
            if (shopifyCustomerId == null)
            {
                throw new InvalidDataException("shopifyCustomerId is a required property for ShopifySubscriberCreation and cannot be null");
            }
            this.ShopifyCustomerId = shopifyCustomerId;
        }

        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="emailAddress", EmitDefaultValue=true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The customer ID has to correspond to the ID assigned to the customer by Shopify. When the subscriber already exists no new subscriber will be created.
        /// </summary>
        /// <value>The customer ID has to correspond to the ID assigned to the customer by Shopify. When the subscriber already exists no new subscriber will be created.</value>
        [DataMember(Name="shopifyCustomerId", EmitDefaultValue=true)]
        public string ShopifyCustomerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShopifySubscriberCreation {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  ShopifyCustomerId: ").Append(ShopifyCustomerId).Append("\n");
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
            return this.Equals(input as ShopifySubscriberCreation);
        }

        /// <summary>
        /// Returns true if ShopifySubscriberCreation instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifySubscriberCreation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifySubscriberCreation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.ShopifyCustomerId == input.ShopifyCustomerId ||
                    (this.ShopifyCustomerId != null &&
                    this.ShopifyCustomerId.Equals(input.ShopifyCustomerId))
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
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.ShopifyCustomerId != null)
                    hashCode = hashCode * 59 + this.ShopifyCustomerId.GetHashCode();
                return hashCode;
            }
        }

    }

}
