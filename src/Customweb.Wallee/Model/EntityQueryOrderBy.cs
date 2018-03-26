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
    /// The &#39;order by&#39; allows to order the returned entities.
    /// </summary>
    [DataContract]
    public partial class EntityQueryOrderBy :  IEquatable<EntityQueryOrderBy>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityQueryOrderBy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EntityQueryOrderBy() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityQueryOrderBy" /> class.
        /// </summary>
        /// <param name="FieldName">FieldName (required)</param>
        /// <param name="Sorting">Sorting (required)</param>
        public EntityQueryOrderBy(string FieldName = default(string), EntityQueryOrderByType? Sorting = default(EntityQueryOrderByType?))
        {
            // to ensure "FieldName" is required (not null)
            if (FieldName == null)
            {
                throw new ArgumentNullException("FieldName is a required property for EntityQueryOrderBy and cannot be null");
            }
            else
            {
                this.FieldName = FieldName;
            }
            // to ensure "Sorting" is required (not null)
            if (Sorting == null)
            {
                throw new ArgumentNullException("Sorting is a required property for EntityQueryOrderBy and cannot be null");
            }
            else
            {
                this.Sorting = Sorting;
            }
        }

        /// <summary>
        /// FieldName
        /// </summary>
        /// <value>FieldName</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// Sorting
        /// </summary>
        /// <value>Sorting</value>
        [DataMember(Name="sorting", EmitDefaultValue=false)]
        public EntityQueryOrderByType? Sorting { get; set; }

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
            return this.Equals(obj as EntityQueryOrderBy);
        }

        /// <summary>
        /// Returns true if EntityQueryOrderBy instances are equal
        /// </summary>
        /// <param name="other">Instance of EntityQueryOrderBy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityQueryOrderBy other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName)
                ) && 
                (
                    this.Sorting == other.Sorting ||
                    this.Sorting != null &&
                    this.Sorting.Equals(other.Sorting)
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
                if (this.FieldName != null)
                {
                    hash = hash * 59 + this.FieldName.GetHashCode();
                }
                if (this.Sorting != null)
                {
                    hash = hash * 59 + this.Sorting.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
