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
    /// ShopifySubscriptionEditModelTaxLine
    /// </summary>
    [DataContract]
    public partial class ShopifySubscriptionEditModelTaxLine :  IEquatable<ShopifySubscriptionEditModelTaxLine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriptionEditModelTaxLine" /> class.
        /// </summary>
        public ShopifySubscriptionEditModelTaxLine()
        {
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
            sb.Append("class ShopifySubscriptionEditModelTaxLine {\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShopifySubscriptionEditModelTaxLine);
        }

        /// <summary>
        /// Returns true if ShopifySubscriptionEditModelTaxLine instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifySubscriptionEditModelTaxLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifySubscriptionEditModelTaxLine input)
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
