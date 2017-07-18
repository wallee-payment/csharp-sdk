/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
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

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Product Version Retirement
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductVersionRetirement :  IEquatable<SubscriptionProductVersionRetirement>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductVersionRetirement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SubscriptionProductVersionRetirement()
        {
        }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// ProductVersion
        /// </summary>
        /// <value>ProductVersion</value>
        [DataMember(Name="productVersion", EmitDefaultValue=false)]
        public SubscriptionProductVersion ProductVersion { get; private set; }

        /// <summary>
        /// RespectTerminiationPeriodsEnabled
        /// </summary>
        /// <value>RespectTerminiationPeriodsEnabled</value>
        [DataMember(Name="respectTerminiationPeriodsEnabled", EmitDefaultValue=false)]
        public bool? RespectTerminiationPeriodsEnabled { get; private set; }

        /// <summary>
        /// TargetProduct
        /// </summary>
        /// <value>TargetProduct</value>
        [DataMember(Name="targetProduct", EmitDefaultValue=false)]
        public SubscriptionProduct TargetProduct { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as SubscriptionProductVersionRetirement);
        }

        /// <summary>
        /// Returns true if SubscriptionProductVersionRetirement instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionProductVersionRetirement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductVersionRetirement other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.ProductVersion == other.ProductVersion ||
                    this.ProductVersion != null &&
                    this.ProductVersion.Equals(other.ProductVersion)
                ) && 
                (
                    this.RespectTerminiationPeriodsEnabled == other.RespectTerminiationPeriodsEnabled ||
                    this.RespectTerminiationPeriodsEnabled != null &&
                    this.RespectTerminiationPeriodsEnabled.Equals(other.RespectTerminiationPeriodsEnabled)
                ) && 
                (
                    this.TargetProduct == other.TargetProduct ||
                    this.TargetProduct != null &&
                    this.TargetProduct.Equals(other.TargetProduct)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                int hash = 41;
                if (this.CreatedOn != null)
                {
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.ProductVersion != null)
                {
                    hash = hash * 59 + this.ProductVersion.GetHashCode();
                }
                if (this.RespectTerminiationPeriodsEnabled != null)
                {
                    hash = hash * 59 + this.RespectTerminiationPeriodsEnabled.GetHashCode();
                }
                if (this.TargetProduct != null)
                {
                    hash = hash * 59 + this.TargetProduct.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                return hash;
            }
        }

    }

}
