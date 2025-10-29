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
    /// The confirmation response provides details about the installation of the web app.
    /// </summary>
    [DataContract(Name = "WebAppConfirmationResponse")]
    public partial class WebAppConfirmationResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebAppConfirmationResponse" /> class.
        /// </summary>
        /// <param name="space">space.</param>
        public WebAppConfirmationResponse(Space space = default(Space))
        {
            this.Space = space;
        }

        /// <summary>
        /// The access code granting permissions to the web service API according to the OAuth standard.
        /// </summary>
        /// <value>The access code granting permissions to the web service API according to the OAuth standard.</value>
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string AccessToken { get; private set; }

        /// <summary>
        /// Returns false as AccessToken should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccessToken()
        {
            return false;
        }
        /// <summary>
        /// The list of the permissions granted to the web app within the space.
        /// </summary>
        /// <value>The list of the permissions granted to the web app within the space.</value>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scope { get; private set; }

        /// <summary>
        /// Returns false as Scope should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeScope()
        {
            return false;
        }
        /// <summary>
        /// The state parameter that was provided in the authorization request.
        /// </summary>
        /// <value>The state parameter that was provided in the authorization request.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; private set; }

        /// <summary>
        /// Returns false as State should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeState()
        {
            return false;
        }
        /// <summary>
        /// The type of the access token that determines the authentication mechanism to use for accessing the web service API.
        /// </summary>
        /// <value>The type of the access token that determines the authentication mechanism to use for accessing the web service API.</value>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public string TokenType { get; private set; }

        /// <summary>
        /// Returns false as TokenType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTokenType()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Space
        /// </summary>
        [DataMember(Name = "space", EmitDefaultValue = false)]
        public Space Space { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebAppConfirmationResponse {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  Space: ").Append(Space).Append("\n");
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
