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
    /// CustomerAddressCreate
    /// </summary>
    [DataContract]
    public partial class CustomerAddressCreate : AbstractCustomerAddressActive,  IEquatable<CustomerAddressCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAddressCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerAddressCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAddressCreate" /> class.
        /// </summary>
        /// <param name="customer">customer (required).</param>
        public CustomerAddressCreate(long? customer)
        {
            // to ensure "customer" is required (not null)
            if (customer == null)
            {
                throw new InvalidDataException("customer is a required property for CustomerAddressCreate and cannot be null");
            }
            this.Customer = customer;
        }



        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=true)]
        public long? Customer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerAddressCreate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomerAddressCreate);
        }

        /// <summary>
        /// Returns true if CustomerAddressCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerAddressCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerAddressCreate input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && base.Equals(input) && 
                (
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AddressType != null)
                    hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                return hashCode;
            }
        }

    }

}
