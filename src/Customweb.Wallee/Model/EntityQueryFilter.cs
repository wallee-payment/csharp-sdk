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
    /// The query filter allows to restrict the entities which are returned.
    /// </summary>
    [DataContract]
    public partial class EntityQueryFilter :  IEquatable<EntityQueryFilter>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityQueryFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public EntityQueryFilter()
        {
        }

        /// <summary>
        /// The &#39;children&#39; can contain other filter nodes which are applied to the query. This property is only applicable on filter types &#39;OR&#39; and &#39;AND&#39;.
        /// </summary>
        /// <value>The &#39;children&#39; can contain other filter nodes which are applied to the query. This property is only applicable on filter types &#39;OR&#39; and &#39;AND&#39;.</value>
        [DataMember(Name="children", EmitDefaultValue=false)]
        public List<EntityQueryFilter> Children { get; private set; }

        /// <summary>
        /// The &#39;fieldName&#39; indicates the property on the entity which should be filtered. This property is only applicable on filter type &#39;LEAF&#39;.
        /// </summary>
        /// <value>The &#39;fieldName&#39; indicates the property on the entity which should be filtered. This property is only applicable on filter type &#39;LEAF&#39;.</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; private set; }

        /// <summary>
        /// The 'operator' indicates what kind of filtering on the 'fieldName' is executed on. This property is only applicable on filter type 'LEAF'.
        /// </summary>
        /// <value>The 'operator' indicates what kind of filtering on the 'fieldName' is executed on. This property is only applicable on filter type 'LEAF'.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public CriteriaOperator? Operator { get; private set; }

        /// <summary>
        /// The filter type controls how the query node is interpreted. I.e. if the node acts as leaf node or as a filter group.
        /// </summary>
        /// <value>The filter type controls how the query node is interpreted. I.e. if the node acts as leaf node or as a filter group.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public EntityQueryFilterType? Type { get; private set; }

        /// <summary>
        /// The &#39;value&#39; is used to compare with the &#39;fieldName&#39; as defined by the &#39;operator&#39;. This property is only applicable on filter type &#39;LEAF&#39;.
        /// </summary>
        /// <value>The &#39;value&#39; is used to compare with the &#39;fieldName&#39; as defined by the &#39;operator&#39;. This property is only applicable on filter type &#39;LEAF&#39;.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; private set; }

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
            return this.Equals(obj as EntityQueryFilter);
        }

        /// <summary>
        /// Returns true if EntityQueryFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of EntityQueryFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityQueryFilter other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Children == other.Children ||
                    this.Children != null &&
                    this.Children.SequenceEqual(other.Children)
                ) && 
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName)
                ) && 
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Children != null)
                {
                    hash = hash * 59 + this.Children.GetHashCode();
                }
                if (this.FieldName != null)
                {
                    hash = hash * 59 + this.FieldName.GetHashCode();
                }
                if (this.Operator != null)
                {
                    hash = hash * 59 + this.Operator.GetHashCode();
                }
                if (this.Type != null)
                {
                    hash = hash * 59 + this.Type.GetHashCode();
                }
                if (this.Value != null)
                {
                    hash = hash * 59 + this.Value.GetHashCode();
                }
                return hash;
            }
        }

    }

}
