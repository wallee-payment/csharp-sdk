
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
    /// PaymentMethod model.
    /// </summary>
    [DataContract]
    public partial class PaymentMethod :  IEquatable<PaymentMethod>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod" /> class.
        /// </summary>
        /// <param name="DataCollectionTypes">DataCollectionTypes</param>
        /// <param name="Description">Description</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="ImagePath">ImagePath</param>
        /// <param name="Name">Name</param>
        /// <param name="SupportedCurrencies">SupportedCurrencies</param>
        public PaymentMethod(List<DataCollectionType> DataCollectionTypes = default(List<DataCollectionType>), Dictionary<string, string> Description = default(Dictionary<string, string>), long? Id = default(long?), string ImagePath = default(string), Dictionary<string, string> Name = default(Dictionary<string, string>), List<string> SupportedCurrencies = default(List<string>))
        {
            this.DataCollectionTypes = DataCollectionTypes;
            this.Description = Description;
            this.Id = Id;
            this.ImagePath = ImagePath;
            this.Name = Name;
            this.SupportedCurrencies = SupportedCurrencies;
        }

        /// <summary>
        /// DataCollectionTypes
        /// </summary>
        /// <value>DataCollectionTypes</value>
        [DataMember(Name="dataCollectionTypes", EmitDefaultValue=false)]
        public List<DataCollectionType> DataCollectionTypes { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// ImagePath
        /// </summary>
        /// <value>ImagePath</value>
        [DataMember(Name="imagePath", EmitDefaultValue=false)]
        public string ImagePath { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// SupportedCurrencies
        /// </summary>
        /// <value>SupportedCurrencies</value>
        [DataMember(Name="supportedCurrencies", EmitDefaultValue=false)]
        public List<string> SupportedCurrencies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethod {\n");
            sb.Append("  DataCollectionTypes: ").Append(DataCollectionTypes).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImagePath: ").Append(ImagePath).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SupportedCurrencies: ").Append(SupportedCurrencies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(obj as PaymentMethod);
        }

        /// <summary>
        /// Returns true if PaymentMethod instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethod other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.DataCollectionTypes == other.DataCollectionTypes ||
                    this.DataCollectionTypes != null &&
                    this.DataCollectionTypes.SequenceEqual(other.DataCollectionTypes)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.SequenceEqual(other.Description)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ImagePath == other.ImagePath ||
                    this.ImagePath != null &&
                    this.ImagePath.Equals(other.ImagePath)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.SequenceEqual(other.Name)
                ) && 
                (
                    this.SupportedCurrencies == other.SupportedCurrencies ||
                    this.SupportedCurrencies != null &&
                    this.SupportedCurrencies.SequenceEqual(other.SupportedCurrencies)
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
                // Suitable nullity checks etc, of course :)
                if (this.DataCollectionTypes != null)
                    hash = hash * 59 + this.DataCollectionTypes.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ImagePath != null)
                    hash = hash * 59 + this.ImagePath.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.SupportedCurrencies != null)
                    hash = hash * 59 + this.SupportedCurrencies.GetHashCode();
                return hash;
            }
        }

    }

}
