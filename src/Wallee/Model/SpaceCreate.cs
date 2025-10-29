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
    /// SpaceCreate
    /// </summary>
    [DataContract(Name = "Space.Create")]
    public partial class SpaceCreate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpaceCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceCreate" /> class.
        /// </summary>
        /// <param name="requestLimit">The maximum number of API requests that are accepted within two minutes. This limit can only be changed with special privileges..</param>
        /// <param name="postalAddress">postalAddress.</param>
        /// <param name="name">The name used to identify the space..</param>
        /// <param name="technicalContactAddresses">The email address that will receive messages about technical issues and errors that occur in the space..</param>
        /// <param name="varTimeZone">The time zone that is used to schedule and run background processes. This does not affect the formatting of dates in the user interface..</param>
        /// <param name="state">state.</param>
        /// <param name="primaryCurrency">The currency that is used to display aggregated amounts in the space..</param>
        /// <param name="database">The database the space is connected to and that holds the space&#39;s data..</param>
        /// <param name="account">The account that the space belongs to. (required).</param>
        public SpaceCreate(long requestLimit = default(long), SpaceAddressCreate postalAddress = default(SpaceAddressCreate), string name = default(string), List<string> technicalContactAddresses = default(List<string>), string varTimeZone = default(string), CreationEntityState? state = default(CreationEntityState?), string primaryCurrency = default(string), long database = default(long), long account = default(long))
        {
            this.Account = account;
            this.RequestLimit = requestLimit;
            this.PostalAddress = postalAddress;
            this.Name = name;
            this.TechnicalContactAddresses = technicalContactAddresses;
            this.VarTimeZone = varTimeZone;
            this.State = state;
            this.PrimaryCurrency = primaryCurrency;
            this.Database = database;
        }

        /// <summary>
        /// The maximum number of API requests that are accepted within two minutes. This limit can only be changed with special privileges.
        /// </summary>
        /// <value>The maximum number of API requests that are accepted within two minutes. This limit can only be changed with special privileges.</value>
        [DataMember(Name = "requestLimit", EmitDefaultValue = false)]
        public long RequestLimit { get; set; }

        /// <summary>
        /// Gets or Sets PostalAddress
        /// </summary>
        [DataMember(Name = "postalAddress", EmitDefaultValue = false)]
        public SpaceAddressCreate PostalAddress { get; set; }

        /// <summary>
        /// The name used to identify the space.
        /// </summary>
        /// <value>The name used to identify the space.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The email address that will receive messages about technical issues and errors that occur in the space.
        /// </summary>
        /// <value>The email address that will receive messages about technical issues and errors that occur in the space.</value>
        [DataMember(Name = "technicalContactAddresses", EmitDefaultValue = false)]
        public List<string> TechnicalContactAddresses { get; set; }

        /// <summary>
        /// The time zone that is used to schedule and run background processes. This does not affect the formatting of dates in the user interface.
        /// </summary>
        /// <value>The time zone that is used to schedule and run background processes. This does not affect the formatting of dates in the user interface.</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string VarTimeZone { get; set; }

        /// <summary>
        /// The currency that is used to display aggregated amounts in the space.
        /// </summary>
        /// <value>The currency that is used to display aggregated amounts in the space.</value>
        [DataMember(Name = "primaryCurrency", EmitDefaultValue = false)]
        public string PrimaryCurrency { get; set; }

        /// <summary>
        /// The database the space is connected to and that holds the space&#39;s data.
        /// </summary>
        /// <value>The database the space is connected to and that holds the space&#39;s data.</value>
        [DataMember(Name = "database", EmitDefaultValue = false)]
        public long Database { get; set; }

        /// <summary>
        /// The account that the space belongs to.
        /// </summary>
        /// <value>The account that the space belongs to.</value>
        [DataMember(Name = "account", IsRequired = true, EmitDefaultValue = true)]
        public long Account { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SpaceCreate {\n");
            sb.Append("  RequestLimit: ").Append(RequestLimit).Append("\n");
            sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TechnicalContactAddresses: ").Append(TechnicalContactAddresses).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PrimaryCurrency: ").Append(PrimaryCurrency).Append("\n");
            sb.Append("  Database: ").Append(Database).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
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
            if (this.Name != null && this.Name.Length > 200)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 200.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 3)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 3.", new [] { "Name" });
            }

            yield break;
        }
    }

}
