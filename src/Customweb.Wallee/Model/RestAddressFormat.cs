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
    /// Address Format
    /// </summary>
    [DataContract]
    public partial class RestAddressFormat :  IEquatable<RestAddressFormat>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RestAddressFormat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RestAddressFormat()
        {
        }

        /// <summary>
        /// The example post codes allow the user to understand what we expect here.
        /// </summary>
        /// <value>The example post codes allow the user to understand what we expect here.</value>
        [DataMember(Name="postCodeExamples", EmitDefaultValue=false)]
        public List<string> PostCodeExamples { get; private set; }

        /// <summary>
        /// The post code regex is a regular expression which can validates the input of the post code.
        /// </summary>
        /// <value>The post code regex is a regular expression which can validates the input of the post code.</value>
        [DataMember(Name="postCodeRegex", EmitDefaultValue=false)]
        public string PostCodeRegex { get; private set; }

        /// <summary>
        /// The required fields indicate what fields are required within an address to comply with the address format.
        /// </summary>
        /// <value>The required fields indicate what fields are required within an address to comply with the address format.</value>
        [DataMember(Name="requiredFields", EmitDefaultValue=false)]
        public List<RestAddressFormatField> RequiredFields { get; private set; }

        /// <summary>
        /// The used fields indicate what fields are used within this address format.
        /// </summary>
        /// <value>The used fields indicate what fields are used within this address format.</value>
        [DataMember(Name="usedFields", EmitDefaultValue=false)]
        public List<RestAddressFormatField> UsedFields { get; private set; }

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
            return this.Equals(obj as RestAddressFormat);
        }

        /// <summary>
        /// Returns true if RestAddressFormat instances are equal
        /// </summary>
        /// <param name="other">Instance of RestAddressFormat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestAddressFormat other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.PostCodeExamples == other.PostCodeExamples ||
                    this.PostCodeExamples != null &&
                    this.PostCodeExamples.SequenceEqual(other.PostCodeExamples)
                ) && 
                (
                    this.PostCodeRegex == other.PostCodeRegex ||
                    this.PostCodeRegex != null &&
                    this.PostCodeRegex.Equals(other.PostCodeRegex)
                ) && 
                (
                    this.RequiredFields == other.RequiredFields ||
                    this.RequiredFields != null &&
                    this.RequiredFields.SequenceEqual(other.RequiredFields)
                ) && 
                (
                    this.UsedFields == other.UsedFields ||
                    this.UsedFields != null &&
                    this.UsedFields.SequenceEqual(other.UsedFields)
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
                if (this.PostCodeExamples != null)
                {
                    hash = hash * 59 + this.PostCodeExamples.GetHashCode();
                }
                if (this.PostCodeRegex != null)
                {
                    hash = hash * 59 + this.PostCodeRegex.GetHashCode();
                }
                if (this.RequiredFields != null)
                {
                    hash = hash * 59 + this.RequiredFields.GetHashCode();
                }
                if (this.UsedFields != null)
                {
                    hash = hash * 59 + this.UsedFields.GetHashCode();
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
