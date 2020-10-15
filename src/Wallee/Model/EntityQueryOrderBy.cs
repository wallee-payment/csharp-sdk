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
    /// The &#39;order by&#39; allows to order the returned entities.
    /// </summary>
    [DataContract]
    public partial class EntityQueryOrderBy :  IEquatable<EntityQueryOrderBy>
    {
        /// <summary>
        /// Gets or Sets Sorting
        /// </summary>
        [DataMember(Name="sorting", EmitDefaultValue=true)]
        public EntityQueryOrderByType Sorting { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityQueryOrderBy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EntityQueryOrderBy() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityQueryOrderBy" /> class.
        /// </summary>
        /// <param name="fieldName">fieldName (required).</param>
        /// <param name="sorting">sorting (required).</param>
        public EntityQueryOrderBy(string fieldName, EntityQueryOrderByType sorting)
        {
            // to ensure "fieldName" is required (not null)
            if (fieldName == null)
            {
                throw new InvalidDataException("fieldName is a required property for EntityQueryOrderBy and cannot be null");
            }
            this.FieldName = fieldName;
            // to ensure "sorting" is required (not null)
            if (sorting == null)
            {
                throw new InvalidDataException("sorting is a required property for EntityQueryOrderBy and cannot be null");
            }
            this.Sorting = sorting;
        }

        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name="fieldName", EmitDefaultValue=true)]
        public string FieldName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityQueryOrderBy {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Sorting: ").Append(Sorting).Append("\n");
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
            return this.Equals(input as EntityQueryOrderBy);
        }

        /// <summary>
        /// Returns true if EntityQueryOrderBy instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityQueryOrderBy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityQueryOrderBy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.Sorting == input.Sorting ||
                    (this.Sorting != null &&
                    this.Sorting.Equals(input.Sorting))
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
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.Sorting != null)
                    hashCode = hashCode * 59 + this.Sorting.GetHashCode();
                return hashCode;
            }
        }

    }

}
