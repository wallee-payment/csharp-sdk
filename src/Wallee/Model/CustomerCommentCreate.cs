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
    /// CustomerCommentCreate
    /// </summary>
    [DataContract]
    public partial class CustomerCommentCreate : AbstractCustomerCommentActive,  IEquatable<CustomerCommentCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCommentCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerCommentCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCommentCreate" /> class.
        /// </summary>
        /// <param name="customer">The customer that the object belongs to. (required).</param>
        public CustomerCommentCreate(long? customer)
        {
            // to ensure "customer" is required (not null)
            if (customer == null)
            {
                throw new InvalidDataException("customer is a required property for CustomerCommentCreate and cannot be null");
            }
            this.Customer = customer;
        }


        /// <summary>
        /// The customer that the object belongs to.
        /// </summary>
        /// <value>The customer that the object belongs to.</value>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public long? Customer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerCommentCreate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
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
            return this.Equals(input as CustomerCommentCreate);
        }

        /// <summary>
        /// Returns true if CustomerCommentCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerCommentCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerCommentCreate input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && base.Equals(input) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                return hashCode;
            }
        }

    }

}
