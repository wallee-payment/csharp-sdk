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
    /// OAuthClientCreate
    /// </summary>
    [DataContract(Name = "OAuthClient.Create")]
    public partial class OAuthClientCreate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthClientCreate" /> class.
        /// </summary>
        /// <param name="lastUpdatedBy">lastUpdatedBy.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="oauthScopes">oauthScopes.</param>
        /// <param name="state">state.</param>
        /// <param name="confirmationRequired">Whether write requests sent through this client have to be confirmed by the user before they are executed..</param>
        /// <param name="redirectUrls">redirectUrls.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="createdBy">createdBy.</param>
        public OAuthClientCreate(long lastUpdatedBy = default, string name = default, string description = default, List<Permission> oauthScopes = default, CreationEntityState? state = default, bool confirmationRequired = default, List<string> redirectUrls = default, string clientId = default, long createdBy = default)
        {
            this.LastUpdatedBy = lastUpdatedBy;
            this.Name = name;
            this.Description = description;
            this.OauthScopes = oauthScopes;
            this.State = state;
            this.ConfirmationRequired = confirmationRequired;
            this.RedirectUrls = redirectUrls;
            this.ClientId = clientId;
            this.CreatedBy = createdBy;
        }

        /// <summary>
        /// Gets or Sets LastUpdatedBy
        /// </summary>
        [DataMember(Name = "lastUpdatedBy", EmitDefaultValue = false)]
        public long LastUpdatedBy { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets OauthScopes
        /// </summary>
        [DataMember(Name = "oauthScopes", EmitDefaultValue = false)]
        public List<Permission> OauthScopes { get; set; }

        /// <summary>
        /// Whether write requests sent through this client have to be confirmed by the user before they are executed.
        /// </summary>
        /// <value>Whether write requests sent through this client have to be confirmed by the user before they are executed.</value>
        [DataMember(Name = "confirmationRequired", EmitDefaultValue = true)]
        public bool ConfirmationRequired { get; set; }

        /// <summary>
        /// Gets or Sets RedirectUrls
        /// </summary>
        [DataMember(Name = "redirectUrls", EmitDefaultValue = false)]
        public List<string> RedirectUrls { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name = "clientId", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public long CreatedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OAuthClientCreate {\n");
            sb.Append("  LastUpdatedBy: ").Append(LastUpdatedBy).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  OauthScopes: ").Append(OauthScopes).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ConfirmationRequired: ").Append(ConfirmationRequired).Append("\n");
            sb.Append("  RedirectUrls: ").Append(RedirectUrls).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
