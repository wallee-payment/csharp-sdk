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
    /// LineItemAttributeCreate
    /// </summary>
    [DataContract]
    public partial class LineItemAttributeCreate :  IEquatable<LineItemAttributeCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemAttributeCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LineItemAttributeCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemAttributeCreate" /> class.
        /// </summary>
        /// <param name="label">label (required).</param>
        /// <param name="value">value (required).</param>
        public LineItemAttributeCreate(string label, string value)
        {
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new InvalidDataException("label is a required property for LineItemAttributeCreate and cannot be null");
            }
            this.Label = label;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for LineItemAttributeCreate and cannot be null");
            }
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItemAttributeCreate {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(input as LineItemAttributeCreate);
        }

        /// <summary>
        /// Returns true if LineItemAttributeCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of LineItemAttributeCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemAttributeCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}
