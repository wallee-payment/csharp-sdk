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
    /// Payment Processor
    /// </summary>
    [DataContract]
    public partial class PaymentProcessor :  IEquatable<PaymentProcessor>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProcessor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentProcessor()
        {
        }

        /// <summary>
        /// CompanyName
        /// </summary>
        /// <value>CompanyName</value>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public Dictionary<string, string> CompanyName { get; private set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// Feature
        /// </summary>
        /// <value>Feature</value>
        [DataMember(Name="feature", EmitDefaultValue=false)]
        public long? Feature { get; private set; }

        /// <summary>
        /// HeadquartersLocation
        /// </summary>
        /// <value>HeadquartersLocation</value>
        [DataMember(Name="headquartersLocation", EmitDefaultValue=false)]
        public Dictionary<string, string> HeadquartersLocation { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// LogoPath
        /// </summary>
        /// <value>LogoPath</value>
        [DataMember(Name="logoPath", EmitDefaultValue=false)]
        public string LogoPath { get; private set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; private set; }

        /// <summary>
        /// ProductName
        /// </summary>
        /// <value>ProductName</value>
        [DataMember(Name="productName", EmitDefaultValue=false)]
        public Dictionary<string, string> ProductName { get; private set; }

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
            return this.Equals(obj as PaymentProcessor);
        }

        /// <summary>
        /// Returns true if PaymentProcessor instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentProcessor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentProcessor other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.SequenceEqual(other.CompanyName)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.SequenceEqual(other.Description)
                ) && 
                (
                    this.Feature == other.Feature ||
                    this.Feature != null &&
                    this.Feature.Equals(other.Feature)
                ) && 
                (
                    this.HeadquartersLocation == other.HeadquartersLocation ||
                    this.HeadquartersLocation != null &&
                    this.HeadquartersLocation.SequenceEqual(other.HeadquartersLocation)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LogoPath == other.LogoPath ||
                    this.LogoPath != null &&
                    this.LogoPath.Equals(other.LogoPath)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.SequenceEqual(other.Name)
                ) && 
                (
                    this.ProductName == other.ProductName ||
                    this.ProductName != null &&
                    this.ProductName.SequenceEqual(other.ProductName)
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
                if (this.CompanyName != null)
                {
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hash = hash * 59 + this.Description.GetHashCode();
                }
                if (this.Feature != null)
                {
                    hash = hash * 59 + this.Feature.GetHashCode();
                }
                if (this.HeadquartersLocation != null)
                {
                    hash = hash * 59 + this.HeadquartersLocation.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.LogoPath != null)
                {
                    hash = hash * 59 + this.LogoPath.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.ProductName != null)
                {
                    hash = hash * 59 + this.ProductName.GetHashCode();
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
