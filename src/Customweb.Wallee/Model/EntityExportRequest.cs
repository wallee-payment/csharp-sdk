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
    /// The entity property export request contains the information required to create an export of a list of entities.
    /// </summary>
    [DataContract]
    public partial class EntityExportRequest :  IEquatable<EntityExportRequest>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityExportRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EntityExportRequest() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityExportRequest" /> class.
        /// </summary>
        /// <param name="Properties">The properties is a list of property paths which should be exported. (required)</param>
        /// <param name="Query">The query limits the returned entries. The query allows to restrict the entries to return and it allows to control the order of them.</param>
        public EntityExportRequest(List<string> Properties = default(List<string>), EntityQuery Query = default(EntityQuery))
        {
            // to ensure "Properties" is required (not null)
            if (Properties == null)
            {
                throw new ArgumentNullException("Properties is a required property for EntityExportRequest and cannot be null");
            }
            else
            {
                this.Properties = Properties;
            }
            this.Query = Query;
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
            return this.Equals(obj as EntityExportRequest);
        }

        /// <summary>
        /// Returns true if EntityExportRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of EntityExportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityExportRequest other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
                ) && 
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
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
                if (this.Properties != null)
                {
                    hash = hash * 59 + this.Properties.GetHashCode();
                }
                if (this.Query != null)
                {
                    hash = hash * 59 + this.Query.GetHashCode();
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
