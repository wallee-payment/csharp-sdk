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
    /// Payment Method Brand
    /// </summary>
    [DataContract]
    public partial class PaymentMethodBrand :  IEquatable<PaymentMethodBrand>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodBrand" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentMethodBrand()
        {
        }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// GrayImagePath
        /// </summary>
        /// <value>GrayImagePath</value>
        [DataMember(Name="grayImagePath", EmitDefaultValue=false)]
        public string GrayImagePath { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// ImagePath
        /// </summary>
        /// <value>ImagePath</value>
        [DataMember(Name="imagePath", EmitDefaultValue=false)]
        public string ImagePath { get; private set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; private set; }

        /// <summary>
        /// PaymentMethod
        /// </summary>
        /// <value>PaymentMethod</value>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public long? PaymentMethod { get; private set; }

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
            return this.Equals(obj as PaymentMethodBrand);
        }

        /// <summary>
        /// Returns true if PaymentMethodBrand instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentMethodBrand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodBrand other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.SequenceEqual(other.Description)
                ) && 
                (
                    this.GrayImagePath == other.GrayImagePath ||
                    this.GrayImagePath != null &&
                    this.GrayImagePath.Equals(other.GrayImagePath)
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
                    this.PaymentMethod == other.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(other.PaymentMethod)
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
                if (this.Description != null)
                {
                    hash = hash * 59 + this.Description.GetHashCode();
                }
                if (this.GrayImagePath != null)
                {
                    hash = hash * 59 + this.GrayImagePath.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.ImagePath != null)
                {
                    hash = hash * 59 + this.ImagePath.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.PaymentMethod != null)
                {
                    hash = hash * 59 + this.PaymentMethod.GetHashCode();
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
