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
    /// AbstractCustomerAddressActive
    /// </summary>
    [DataContract]
    public partial class AbstractCustomerAddressActive :  IEquatable<AbstractCustomerAddressActive>
    {
        /// <summary>
        /// Gets or Sets AddressType
        /// </summary>
        [DataMember(Name="addressType", EmitDefaultValue=false)]
        public CustomerAddressType? AddressType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractCustomerAddressActive" /> class.
        /// </summary>
        public AbstractCustomerAddressActive()
        {
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public CustomerPostalAddressCreate Address { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractCustomerAddressActive {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as AbstractCustomerAddressActive);
        }

        /// <summary>
        /// Returns true if AbstractCustomerAddressActive instances are equal
        /// </summary>
        /// <param name="input">Instance of AbstractCustomerAddressActive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractCustomerAddressActive input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AddressType != null)
                    hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                return hashCode;
            }
        }

    }

}
