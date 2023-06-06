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
    /// LocalizedString
    /// </summary>
    [DataContract]
    public partial class LocalizedString :  IEquatable<LocalizedString>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedString" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public LocalizedString()
        {
        }

        /// <summary>
        /// The term&#39;s language.
        /// </summary>
        /// <value>The term&#39;s language.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The localized term.
        /// </summary>
        /// <value>The localized term.</value>
        [DataMember(Name="string", EmitDefaultValue=false)]
        public string String { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocalizedString {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  String: ").Append(String).Append("\n");
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
            return this.Equals(input as LocalizedString);
        }

        /// <summary>
        /// Returns true if LocalizedString instances are equal
        /// </summary>
        /// <param name="input">Instance of LocalizedString to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocalizedString input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.String == input.String ||
                    (this.String != null &&
                    this.String.Equals(input.String))
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
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.String != null)
                    hashCode = hashCode * 59 + this.String.GetHashCode();
                return hashCode;
            }
        }

    }

}
