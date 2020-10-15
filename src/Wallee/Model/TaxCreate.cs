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
    /// TaxCreate
    /// </summary>
    [DataContract]
    public partial class TaxCreate :  IEquatable<TaxCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaxCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxCreate" /> class.
        /// </summary>
        /// <param name="rate">rate (required).</param>
        /// <param name="title">title (required).</param>
        public TaxCreate(decimal? rate, string title)
        {
            // to ensure "rate" is required (not null)
            if (rate == null)
            {
                throw new InvalidDataException("rate is a required property for TaxCreate and cannot be null");
            }
            this.Rate = rate;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for TaxCreate and cannot be null");
            }
            this.Title = title;
        }

        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        [DataMember(Name="rate", EmitDefaultValue=true)]
        public decimal? Rate { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxCreate {\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as TaxCreate);
        }

        /// <summary>
        /// Returns true if TaxCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                return hashCode;
            }
        }

    }

}
