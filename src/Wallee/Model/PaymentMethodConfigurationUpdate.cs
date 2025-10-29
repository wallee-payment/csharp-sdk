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
    /// PaymentMethodConfigurationUpdate
    /// </summary>
    [DataContract(Name = "PaymentMethodConfiguration.Update")]
    public partial class PaymentMethodConfigurationUpdate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets OneClickPaymentMode
        /// </summary>
        [DataMember(Name = "oneClickPaymentMode", EmitDefaultValue = false)]
        public OneClickPaymentMode? OneClickPaymentMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodConfigurationUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethodConfigurationUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodConfigurationUpdate" /> class.
        /// </summary>
        /// <param name="imageResourcePath">The resource path to a custom image for the payment method, displayed to the customer for visual identification..</param>
        /// <param name="sortOrder">When listing payment methods, they can be sorted by this number..</param>
        /// <param name="name">The name used to identify the payment method configuration..</param>
        /// <param name="description">A customer-facing custom description for the payment method..</param>
        /// <param name="oneClickPaymentMode">oneClickPaymentMode.</param>
        /// <param name="title">A customer-facing custom title for the payment method..</param>
        /// <param name="varVersion">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public PaymentMethodConfigurationUpdate(string imageResourcePath = default(string), int sortOrder = default(int), string name = default(string), Dictionary<string, string> description = default(Dictionary<string, string>), OneClickPaymentMode? oneClickPaymentMode = default(OneClickPaymentMode?), Dictionary<string, string> title = default(Dictionary<string, string>), int varVersion = default(int))
        {
            this.VarVersion = varVersion;
            this.ImageResourcePath = imageResourcePath;
            this.SortOrder = sortOrder;
            this.Name = name;
            this.Description = description;
            this.OneClickPaymentMode = oneClickPaymentMode;
            this.Title = title;
        }

        /// <summary>
        /// The resource path to a custom image for the payment method, displayed to the customer for visual identification.
        /// </summary>
        /// <value>The resource path to a custom image for the payment method, displayed to the customer for visual identification.</value>
        [DataMember(Name = "imageResourcePath", EmitDefaultValue = false)]
        public string ImageResourcePath { get; set; }

        /// <summary>
        /// When listing payment methods, they can be sorted by this number.
        /// </summary>
        /// <value>When listing payment methods, they can be sorted by this number.</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        public int SortOrder { get; set; }

        /// <summary>
        /// The name used to identify the payment method configuration.
        /// </summary>
        /// <value>The name used to identify the payment method configuration.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A customer-facing custom description for the payment method.
        /// </summary>
        /// <value>A customer-facing custom description for the payment method.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public Dictionary<string, string> Description { get; set; }

        /// <summary>
        /// A customer-facing custom title for the payment method.
        /// </summary>
        /// <value>A customer-facing custom title for the payment method.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public Dictionary<string, string> Title { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodConfigurationUpdate {\n");
            sb.Append("  ImageResourcePath: ").Append(ImageResourcePath).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  OneClickPaymentMode: ").Append(OneClickPaymentMode).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            yield break;
        }
    }

}
