/**
 * Wallee AG C# SDK
 *
 * This library allows to interact with the Wallee AG payment service.
 *
 * Copyright owner: Wallee AG
 * Website: https://en.wallee.com
 * Developer email: ecosystem-team@wallee.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Wallee.Client.OpenAPIDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// CustomerAddressCreate
    /// </summary>
    [DataContract(Name = "CustomerAddress.Create")]
    public partial class CustomerAddressCreate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AddressType
        /// </summary>
        [DataMember(Name = "addressType", EmitDefaultValue = false)]
        public CustomerAddressType? AddressType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAddressCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerAddressCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAddressCreate" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="addressType">addressType.</param>
        /// <param name="customer">The customer that the object belongs to. (required).</param>
        public CustomerAddressCreate(CustomerPostalAddressCreate address = default(CustomerPostalAddressCreate), CustomerAddressType? addressType = default(CustomerAddressType?), long customer = default(long))
        {
            this.Customer = customer;
            this.Address = address;
            this.AddressType = addressType;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public CustomerPostalAddressCreate Address { get; set; }

        /// <summary>
        /// The customer that the object belongs to.
        /// </summary>
        /// <value>The customer that the object belongs to.</value>
        [DataMember(Name = "customer", IsRequired = true, EmitDefaultValue = true)]
        public long Customer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerAddressCreate {\n");
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
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
