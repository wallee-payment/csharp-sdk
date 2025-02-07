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
    /// Payment processors handle the connection to third part companies (payment service providers) that technically manage payment transactions and therefore process payments.
    /// </summary>
    [DataContract]
    public partial class PaymentProcessor :  IEquatable<PaymentProcessor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProcessor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentProcessor()
        {
        }

        /// <summary>
        /// The name of the company to which the processor belongs.
        /// </summary>
        /// <value>The name of the company to which the processor belongs.</value>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public Dictionary<string, string> CompanyName { get; private set; }

        /// <summary>
        /// The localized description of the object.
        /// </summary>
        /// <value>The localized description of the object.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// Where the processor&#39;s headquarters are located.
        /// </summary>
        /// <value>Where the processor&#39;s headquarters are located.</value>
        [DataMember(Name="headquartersLocation", EmitDefaultValue=false)]
        public Dictionary<string, string> HeadquartersLocation { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The path to the logo image of the processor.
        /// </summary>
        /// <value>The path to the logo image of the processor.</value>
        [DataMember(Name="logoPath", EmitDefaultValue=false)]
        public string LogoPath { get; private set; }

        /// <summary>
        /// The localized name of the object.
        /// </summary>
        /// <value>The localized name of the object.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; private set; }

        /// <summary>
        /// The name of the processor&#39;s product.
        /// </summary>
        /// <value>The name of the processor&#39;s product.</value>
        [DataMember(Name="productName", EmitDefaultValue=false)]
        public Dictionary<string, string> ProductName { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentProcessor {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HeadquartersLocation: ").Append(HeadquartersLocation).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LogoPath: ").Append(LogoPath).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
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
            return this.Equals(input as PaymentProcessor);
        }

        /// <summary>
        /// Returns true if PaymentProcessor instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentProcessor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentProcessor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompanyName == input.CompanyName ||
                    this.CompanyName != null &&
                    input.CompanyName != null &&
                    this.CompanyName.SequenceEqual(input.CompanyName)
                ) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.HeadquartersLocation == input.HeadquartersLocation ||
                    this.HeadquartersLocation != null &&
                    input.HeadquartersLocation != null &&
                    this.HeadquartersLocation.SequenceEqual(input.HeadquartersLocation)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LogoPath == input.LogoPath ||
                    (this.LogoPath != null &&
                    this.LogoPath.Equals(input.LogoPath))
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.ProductName == input.ProductName ||
                    this.ProductName != null &&
                    input.ProductName != null &&
                    this.ProductName.SequenceEqual(input.ProductName)
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
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.HeadquartersLocation != null)
                    hashCode = hashCode * 59 + this.HeadquartersLocation.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LogoPath != null)
                    hashCode = hashCode * 59 + this.LogoPath.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProductName != null)
                    hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                return hashCode;
            }
        }

    }

}
