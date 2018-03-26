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
    /// Line Item Attribute . Create
    /// </summary>
    [DataContract]
    public partial class LineItemAttributeCreate :  IEquatable<LineItemAttributeCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemAttributeCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LineItemAttributeCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemAttributeCreate" /> class.
        /// </summary>
        /// <param name="Label">Label (required)</param>
        /// <param name="Value">Value (required)</param>
        public LineItemAttributeCreate(string Label = default(string), string Value = default(string))
        {
            // to ensure "Label" is required (not null)
            if (Label == null)
            {
                throw new ArgumentNullException("Label is a required property for LineItemAttributeCreate and cannot be null");
            }
            else
            {
                this.Label = Label;
            }
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new ArgumentNullException("Value is a required property for LineItemAttributeCreate and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
        }

        /// <summary>
        /// Label
        /// </summary>
        /// <value>Label</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        /// <value>Value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

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
            return this.Equals(obj as LineItemAttributeCreate);
        }

        /// <summary>
        /// Returns true if LineItemAttributeCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of LineItemAttributeCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemAttributeCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
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
                if (this.Label != null)
                {
                    hash = hash * 59 + this.Label.GetHashCode();
                }
                if (this.Value != null)
                {
                    hash = hash * 59 + this.Value.GetHashCode();
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
