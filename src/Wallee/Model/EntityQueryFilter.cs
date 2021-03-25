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
using SwaggerDateConverter = Wallee.Client.SwaggerDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// The query filter allows to restrict the entities which are returned.
    /// </summary>
    [DataContract]
    public partial class EntityQueryFilter :  IEquatable<EntityQueryFilter>
    {
        /// <summary>
        /// The &#39;operator&#39; indicates what kind of filtering on the &#39;fieldName&#39; is executed on. This property is only applicable on filter type &#39;LEAF&#39;.
        /// </summary>
        /// <value>The &#39;operator&#39; indicates what kind of filtering on the &#39;fieldName&#39; is executed on. This property is only applicable on filter type &#39;LEAF&#39;.</value>
        [DataMember(Name="operator", EmitDefaultValue=true)]
        public CriteriaOperator? Operator { get; set; }
        /// <summary>
        /// The filter type controls how the query node is interpreted. I.e. if the node acts as leaf node or as a filter group.
        /// </summary>
        /// <value>The filter type controls how the query node is interpreted. I.e. if the node acts as leaf node or as a filter group.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public EntityQueryFilterType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityQueryFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EntityQueryFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityQueryFilter" /> class.
        /// </summary>
        /// <param name="type">The filter type controls how the query node is interpreted. I.e. if the node acts as leaf node or as a filter group. (required).</param>
        public EntityQueryFilter(EntityQueryFilterType type)
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for EntityQueryFilter and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// The &#39;children&#39; can contain other filter nodes which are applied to the query. This property is only applicable on filter types &#39;OR&#39; and &#39;AND&#39;.
        /// </summary>
        /// <value>The &#39;children&#39; can contain other filter nodes which are applied to the query. This property is only applicable on filter types &#39;OR&#39; and &#39;AND&#39;.</value>
        [DataMember(Name="children", EmitDefaultValue=true)]
        public List<EntityQueryFilter> Children { get; set; }

        /// <summary>
        /// The &#39;fieldName&#39; indicates the property on the entity which should be filtered. This property is only applicable on filter type &#39;LEAF&#39;.
        /// </summary>
        /// <value>The &#39;fieldName&#39; indicates the property on the entity which should be filtered. This property is only applicable on filter type &#39;LEAF&#39;.</value>
        [DataMember(Name="fieldName", EmitDefaultValue=true)]
        public string FieldName { get; set; }



        /// <summary>
        /// The &#39;value&#39; is used to compare with the &#39;fieldName&#39; as defined by the &#39;operator&#39;. This property is only applicable on filter type &#39;LEAF&#39;.
        /// </summary>
        /// <value>The &#39;value&#39; is used to compare with the &#39;fieldName&#39; as defined by the &#39;operator&#39;. This property is only applicable on filter type &#39;LEAF&#39;.</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public Object Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityQueryFilter {\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EntityQueryFilter);
        }

        /// <summary>
        /// Returns true if EntityQueryFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityQueryFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityQueryFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                int hashCode = 41;
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.Operator != null)
                    hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}
