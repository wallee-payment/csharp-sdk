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
    /// RestCountryState
    /// </summary>
    [DataContract]
    public partial class RestCountryState :  IEquatable<RestCountryState>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestCountryState" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RestCountryState()
        {
        }

        /// <summary>
        /// The code of the state identifies the state. The code is typically used within addresses. Some countries may not provide a code. For those the field is null.
        /// </summary>
        /// <value>The code of the state identifies the state. The code is typically used within addresses. Some countries may not provide a code. For those the field is null.</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; private set; }

        /// <summary>
        /// The country code in ISO two letter format (e.g. UK, DE, CH, US).
        /// </summary>
        /// <value>The country code in ISO two letter format (e.g. UK, DE, CH, US).</value>
        [DataMember(Name="countryCode", EmitDefaultValue=true)]
        public string CountryCode { get; private set; }

        /// <summary>
        /// The ID of the state corresponds to the subdivision identifier defined in ISO 3166-2. The format consists of the country code followed by a dash and a subdivision identifier.
        /// </summary>
        /// <value>The ID of the state corresponds to the subdivision identifier defined in ISO 3166-2. The format consists of the country code followed by a dash and a subdivision identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; private set; }

        /// <summary>
        /// The name is a human readable label of the state in the language of the region.
        /// </summary>
        /// <value>The name is a human readable label of the state in the language of the region.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestCountryState {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as RestCountryState);
        }

        /// <summary>
        /// Returns true if RestCountryState instances are equal
        /// </summary>
        /// <param name="input">Instance of RestCountryState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestCountryState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}
