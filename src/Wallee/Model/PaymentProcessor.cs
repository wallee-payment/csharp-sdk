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
    /// PaymentProcessor
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
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="companyName", EmitDefaultValue=true)]
        public Dictionary<string, string> CompanyName { get; private set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// Gets or Sets Feature
        /// </summary>
        [DataMember(Name="feature", EmitDefaultValue=true)]
        public long? Feature { get; private set; }

        /// <summary>
        /// Gets or Sets HeadquartersLocation
        /// </summary>
        [DataMember(Name="headquartersLocation", EmitDefaultValue=true)]
        public Dictionary<string, string> HeadquartersLocation { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets LogoPath
        /// </summary>
        [DataMember(Name="logoPath", EmitDefaultValue=true)]
        public string LogoPath { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public Dictionary<string, string> Name { get; private set; }

        /// <summary>
        /// Gets or Sets ProductName
        /// </summary>
        [DataMember(Name="productName", EmitDefaultValue=true)]
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
            sb.Append("  Feature: ").Append(Feature).Append("\n");
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
                    this.Feature == input.Feature ||
                    (this.Feature != null &&
                    this.Feature.Equals(input.Feature))
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
                if (this.Feature != null)
                    hashCode = hashCode * 59 + this.Feature.GetHashCode();
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
