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
    /// RestAddressFormat
    /// </summary>
    [DataContract]
    public partial class RestAddressFormat :  IEquatable<RestAddressFormat>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestAddressFormat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RestAddressFormat()
        {
        }

        /// <summary>
        /// A list of sample post codes.
        /// </summary>
        /// <value>A list of sample post codes.</value>
        [DataMember(Name="postCodeExamples", EmitDefaultValue=false)]
        public List<string> PostCodeExamples { get; private set; }

        /// <summary>
        /// The regular expression to validate post codes.
        /// </summary>
        /// <value>The regular expression to validate post codes.</value>
        [DataMember(Name="postCodeRegex", EmitDefaultValue=false)]
        public string PostCodeRegex { get; private set; }

        /// <summary>
        /// The fields that are required in the address format.
        /// </summary>
        /// <value>The fields that are required in the address format.</value>
        [DataMember(Name="requiredFields", EmitDefaultValue=false)]
        public List<RestAddressFormatField> RequiredFields { get; private set; }

        /// <summary>
        /// The fields that are used in the address format.
        /// </summary>
        /// <value>The fields that are used in the address format.</value>
        [DataMember(Name="usedFields", EmitDefaultValue=false)]
        public List<RestAddressFormatField> UsedFields { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestAddressFormat {\n");
            sb.Append("  PostCodeExamples: ").Append(PostCodeExamples).Append("\n");
            sb.Append("  PostCodeRegex: ").Append(PostCodeRegex).Append("\n");
            sb.Append("  RequiredFields: ").Append(RequiredFields).Append("\n");
            sb.Append("  UsedFields: ").Append(UsedFields).Append("\n");
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
            return this.Equals(input as RestAddressFormat);
        }

        /// <summary>
        /// Returns true if RestAddressFormat instances are equal
        /// </summary>
        /// <param name="input">Instance of RestAddressFormat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestAddressFormat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PostCodeExamples == input.PostCodeExamples ||
                    this.PostCodeExamples != null &&
                    input.PostCodeExamples != null &&
                    this.PostCodeExamples.SequenceEqual(input.PostCodeExamples)
                ) && 
                (
                    this.PostCodeRegex == input.PostCodeRegex ||
                    (this.PostCodeRegex != null &&
                    this.PostCodeRegex.Equals(input.PostCodeRegex))
                ) && 
                (
                    this.RequiredFields == input.RequiredFields ||
                    this.RequiredFields != null &&
                    input.RequiredFields != null &&
                    this.RequiredFields.SequenceEqual(input.RequiredFields)
                ) && 
                (
                    this.UsedFields == input.UsedFields ||
                    this.UsedFields != null &&
                    input.UsedFields != null &&
                    this.UsedFields.SequenceEqual(input.UsedFields)
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
                if (this.PostCodeExamples != null)
                    hashCode = hashCode * 59 + this.PostCodeExamples.GetHashCode();
                if (this.PostCodeRegex != null)
                    hashCode = hashCode * 59 + this.PostCodeRegex.GetHashCode();
                if (this.RequiredFields != null)
                    hashCode = hashCode * 59 + this.RequiredFields.GetHashCode();
                if (this.UsedFields != null)
                    hashCode = hashCode * 59 + this.UsedFields.GetHashCode();
                return hashCode;
            }
        }

    }

}
