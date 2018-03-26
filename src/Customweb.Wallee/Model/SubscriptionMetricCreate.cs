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
    /// A metric represents the usage of a resource that can be measured.
    /// </summary>
    [DataContract]
    public partial class SubscriptionMetricCreate : AbstractSubscriptionMetricUpdate,  IEquatable<SubscriptionMetricCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMetricCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionMetricCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMetricCreate" /> class.
        /// </summary>
        /// <param name="Type">Type (required)</param>
        public SubscriptionMetricCreate(DatabaseTranslatedStringCreate Description = default(DatabaseTranslatedStringCreate), long? Type = default(long?), DatabaseTranslatedStringCreate Name = default(DatabaseTranslatedStringCreate))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new ArgumentNullException("Type is a required property for SubscriptionMetricCreate and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Description = Description;
            this.Name = Name;
        }

        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public long? Type { get; set; }

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
        public new string ToJson()
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
            return this.Equals(obj as SubscriptionMetricCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionMetricCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionMetricCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionMetricCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Type != null)
                {
                    hash = hash * 59 + this.Type.GetHashCode();
                }
                if (this.Description != null)
                {
                    hash = hash * 59 + this.Description.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
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
