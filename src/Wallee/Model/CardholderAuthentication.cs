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
    /// CardholderAuthentication
    /// </summary>
    [DataContract(Name = "CardholderAuthentication")]
    public partial class CardholderAuthentication : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AuthenticationResponse
        /// </summary>
        [DataMember(Name = "authenticationResponse", EmitDefaultValue = false)]
        public CardAuthenticationResponse? AuthenticationResponse { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public CardAuthenticationVersion? VarVersion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardholderAuthentication" /> class.
        /// </summary>
        /// <param name="authenticationResponse">authenticationResponse.</param>
        /// <param name="varVersion">varVersion.</param>
        public CardholderAuthentication(CardAuthenticationResponse? authenticationResponse = default, CardAuthenticationVersion? varVersion = default)
        {
            this.AuthenticationResponse = authenticationResponse;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// The identifier (e.g., XID or DSTransactionID) assigned by the authentication system for tracking and verification.
        /// </summary>
        /// <value>The identifier (e.g., XID or DSTransactionID) assigned by the authentication system for tracking and verification.</value>
        [DataMember(Name = "authenticationIdentifier", EmitDefaultValue = false)]
        public string AuthenticationIdentifier { get; private set; }

        /// <summary>
        /// Returns false as AuthenticationIdentifier should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAuthenticationIdentifier()
        {
            return false;
        }
        /// <summary>
        /// The Electronic Commerce Indicator (ECI) represents the authentication level and indicates liability shift during online or card-not-present transactions.
        /// </summary>
        /// <value>The Electronic Commerce Indicator (ECI) represents the authentication level and indicates liability shift during online or card-not-present transactions.</value>
        [DataMember(Name = "electronicCommerceIndicator", EmitDefaultValue = false)]
        public string ElectronicCommerceIndicator { get; private set; }

        /// <summary>
        /// Returns false as ElectronicCommerceIndicator should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeElectronicCommerceIndicator()
        {
            return false;
        }
        /// <summary>
        /// The cryptographic token (CAVV/AAV) generated during the authentication process to validate the cardholder&#39;s identity.
        /// </summary>
        /// <value>The cryptographic token (CAVV/AAV) generated during the authentication process to validate the cardholder&#39;s identity.</value>
        [DataMember(Name = "authenticationValue", EmitDefaultValue = false)]
        public string AuthenticationValue { get; private set; }

        /// <summary>
        /// Returns false as AuthenticationValue should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAuthenticationValue()
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
            sb.Append("class CardholderAuthentication {\n");
            sb.Append("  AuthenticationIdentifier: ").Append(AuthenticationIdentifier).Append("\n");
            sb.Append("  AuthenticationResponse: ").Append(AuthenticationResponse).Append("\n");
            sb.Append("  ElectronicCommerceIndicator: ").Append(ElectronicCommerceIndicator).Append("\n");
            sb.Append("  AuthenticationValue: ").Append(AuthenticationValue).Append("\n");
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
            yield break;
        }
    }

}
