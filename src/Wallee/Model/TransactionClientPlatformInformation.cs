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
    /// TransactionClientPlatformInformation
    /// </summary>
    [DataContract(Name = "TransactionClientPlatformInformation")]
    public partial class TransactionClientPlatformInformation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionClientPlatformInformation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TransactionClientPlatformInformation()
        {
        }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name = "spaceId", EmitDefaultValue = false)]
        public long SpaceId { get; private set; }

        /// <summary>
        /// Returns false as SpaceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSpaceId()
        {
            return false;
        }
        /// <summary>
        /// The type of integration that was used to collect the payment information.
        /// </summary>
        /// <value>The type of integration that was used to collect the payment information.</value>
        [DataMember(Name = "integrationType", EmitDefaultValue = false)]
        public string IntegrationType { get; private set; }

        /// <summary>
        /// Returns false as IntegrationType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIntegrationType()
        {
            return false;
        }
        /// <summary>
        /// The version of the operating system that was used to collect the payment information.
        /// </summary>
        /// <value>The version of the operating system that was used to collect the payment information.</value>
        [DataMember(Name = "osVersion", EmitDefaultValue = false)]
        public string OsVersion { get; private set; }

        /// <summary>
        /// Returns false as OsVersion should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOsVersion()
        {
            return false;
        }
        /// <summary>
        /// The type of platform that was used to collect the payment information, e.g. Android or iOS.
        /// </summary>
        /// <value>The type of platform that was used to collect the payment information, e.g. Android or iOS.</value>
        [DataMember(Name = "platformType", EmitDefaultValue = false)]
        public string PlatformType { get; private set; }

        /// <summary>
        /// Returns false as PlatformType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePlatformType()
        {
            return false;
        }
        /// <summary>
        /// The type of the SDK that was used to collect the payment information.
        /// </summary>
        /// <value>The type of the SDK that was used to collect the payment information.</value>
        [DataMember(Name = "sdkVersion", EmitDefaultValue = false)]
        public string SdkVersion { get; private set; }

        /// <summary>
        /// Returns false as SdkVersion should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSdkVersion()
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
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; private set; }

        /// <summary>
        /// Returns false as VarVersion should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarVersion()
        {
            return false;
        }
        /// <summary>
        /// The transaction that is associated with the client platform information.
        /// </summary>
        /// <value>The transaction that is associated with the client platform information.</value>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public long Transaction { get; private set; }

        /// <summary>
        /// Returns false as Transaction should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransaction()
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
            sb.Append("class TransactionClientPlatformInformation {\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  IntegrationType: ").Append(IntegrationType).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
            sb.Append("  SdkVersion: ").Append(SdkVersion).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
