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
    /// The entity property export request contains the information required to create an export of a list of entities.
    /// </summary>
    [DataContract]
    public partial class EntityExportRequest :  IEquatable<EntityExportRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityExportRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EntityExportRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityExportRequest" /> class.
        /// </summary>
        /// <param name="properties">The properties is a list of property paths which should be exported. (required).</param>
        public EntityExportRequest(List<string> properties)
        {
            // to ensure "properties" is required (not null)
            if (properties == null)
            {
                throw new InvalidDataException("properties is a required property for EntityExportRequest and cannot be null");
            }
            this.Properties = properties;
        }

        /// <summary>
        /// The properties is a list of property paths which should be exported.
        /// </summary>
        /// <value>The properties is a list of property paths which should be exported.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<string> Properties { get; set; }

        /// <summary>
        /// The query limits the returned entries. The query allows to restrict the entries to return and it allows to control the order of them.
        /// </summary>
        /// <value>The query limits the returned entries. The query allows to restrict the entries to return and it allows to control the order of them.</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public EntityQuery Query { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityExportRequest {\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
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
            return this.Equals(input as EntityExportRequest);
        }

        /// <summary>
        /// Returns true if EntityExportRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityExportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityExportRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
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
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                return hashCode;
            }
        }

    }

}
