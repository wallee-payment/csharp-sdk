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
    /// PaymentMethod
    /// </summary>
    [DataContract(Name = "PaymentMethod")]
    public partial class PaymentMethod : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentMethod()
        {
        }

        /// <summary>
        /// The currencies that the payment method supports.
        /// </summary>
        /// <value>The currencies that the payment method supports.</value>
        [DataMember(Name = "supportedCurrencies", EmitDefaultValue = false)]
        public List<string> SupportedCurrencies { get; private set; }

        /// <summary>
        /// Returns false as SupportedCurrencies should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSupportedCurrencies()
        {
            return false;
        }
        /// <summary>
        /// The data collection types that payment method supports.
        /// </summary>
        /// <value>The data collection types that payment method supports.</value>
        [DataMember(Name = "dataCollectionTypes", EmitDefaultValue = false)]
        public List<DataCollectionType> DataCollectionTypes { get; private set; }

        /// <summary>
        /// Returns false as DataCollectionTypes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDataCollectionTypes()
        {
            return false;
        }
        /// <summary>
        /// The path to the payment method&#39;s image.
        /// </summary>
        /// <value>The path to the payment method&#39;s image.</value>
        [DataMember(Name = "imagePath", EmitDefaultValue = false)]
        public string ImagePath { get; private set; }

        /// <summary>
        /// Returns false as ImagePath should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeImagePath()
        {
            return false;
        }
        /// <summary>
        /// The localized name of the object.
        /// </summary>
        /// <value>The localized name of the object.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public Dictionary<string, string> Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// The localized description of the object.
        /// </summary>
        /// <value>The localized description of the object.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// Returns false as Description should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDescription()
        {
            return false;
        }
        /// <summary>
        /// A merchant-focused, localized description of the payment method, providing its purpose and details.
        /// </summary>
        /// <value>A merchant-focused, localized description of the payment method, providing its purpose and details.</value>
        [DataMember(Name = "merchantDescription", EmitDefaultValue = false)]
        public Dictionary<string, string> MerchantDescription { get; private set; }

        /// <summary>
        /// Returns false as MerchantDescription should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMerchantDescription()
        {
            return false;
        }
        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethod {\n");
            sb.Append("  SupportedCurrencies: ").Append(SupportedCurrencies).Append("\n");
            sb.Append("  DataCollectionTypes: ").Append(DataCollectionTypes).Append("\n");
            sb.Append("  ImagePath: ").Append(ImagePath).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MerchantDescription: ").Append(MerchantDescription).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
