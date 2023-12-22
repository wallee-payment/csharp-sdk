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
    /// PaymentConnector
    /// </summary>
    [DataContract]
    public partial class PaymentConnector :  IEquatable<PaymentConnector>
    {
        /// <summary>
        /// Gets or Sets DataCollectionType
        /// </summary>
        [DataMember(Name="dataCollectionType", EmitDefaultValue=false)]
        public DataCollectionType? DataCollectionType { get; private set; }
        /// <summary>
        /// Gets or Sets PrimaryRiskTaker
        /// </summary>
        [DataMember(Name="primaryRiskTaker", EmitDefaultValue=false)]
        public PaymentPrimaryRiskTaker? PrimaryRiskTaker { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentConnector" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentConnector()
        {
        }


        /// <summary>
        /// Gets or Sets Deprecated
        /// </summary>
        [DataMember(Name="deprecated", EmitDefaultValue=false)]
        public bool? Deprecated { get; private set; }

        /// <summary>
        /// Gets or Sets DeprecationReason
        /// </summary>
        [DataMember(Name="deprecationReason", EmitDefaultValue=false)]
        public Dictionary<string, string> DeprecationReason { get; private set; }

        /// <summary>
        /// The localized description of the object.
        /// </summary>
        /// <value>The localized description of the object.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// Gets or Sets Feature
        /// </summary>
        [DataMember(Name="feature", EmitDefaultValue=false)]
        public Feature Feature { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The localized name of the object.
        /// </summary>
        /// <value>The localized name of the object.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public long? PaymentMethod { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentMethodBrand
        /// </summary>
        [DataMember(Name="paymentMethodBrand", EmitDefaultValue=false)]
        public PaymentMethodBrand PaymentMethodBrand { get; private set; }


        /// <summary>
        /// Gets or Sets Processor
        /// </summary>
        [DataMember(Name="processor", EmitDefaultValue=false)]
        public long? Processor { get; private set; }

        /// <summary>
        /// Gets or Sets SupportedCurrencies
        /// </summary>
        [DataMember(Name="supportedCurrencies", EmitDefaultValue=false)]
        public List<string> SupportedCurrencies { get; private set; }

        /// <summary>
        /// Gets or Sets SupportedCustomersPresences
        /// </summary>
        [DataMember(Name="supportedCustomersPresences", EmitDefaultValue=false)]
        public List<CustomersPresence> SupportedCustomersPresences { get; private set; }

        /// <summary>
        /// Gets or Sets SupportedFeatures
        /// </summary>
        [DataMember(Name="supportedFeatures", EmitDefaultValue=false)]
        public List<long?> SupportedFeatures { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentConnector {\n");
            sb.Append("  DataCollectionType: ").Append(DataCollectionType).Append("\n");
            sb.Append("  Deprecated: ").Append(Deprecated).Append("\n");
            sb.Append("  DeprecationReason: ").Append(DeprecationReason).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Feature: ").Append(Feature).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PaymentMethodBrand: ").Append(PaymentMethodBrand).Append("\n");
            sb.Append("  PrimaryRiskTaker: ").Append(PrimaryRiskTaker).Append("\n");
            sb.Append("  Processor: ").Append(Processor).Append("\n");
            sb.Append("  SupportedCurrencies: ").Append(SupportedCurrencies).Append("\n");
            sb.Append("  SupportedCustomersPresences: ").Append(SupportedCustomersPresences).Append("\n");
            sb.Append("  SupportedFeatures: ").Append(SupportedFeatures).Append("\n");
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
            return this.Equals(input as PaymentConnector);
        }

        /// <summary>
        /// Returns true if PaymentConnector instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentConnector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentConnector input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataCollectionType == input.DataCollectionType ||
                    (this.DataCollectionType != null &&
                    this.DataCollectionType.Equals(input.DataCollectionType))
                ) && 
                (
                    this.Deprecated == input.Deprecated ||
                    (this.Deprecated != null &&
                    this.Deprecated.Equals(input.Deprecated))
                ) && 
                (
                    this.DeprecationReason == input.DeprecationReason ||
                    this.DeprecationReason != null &&
                    input.DeprecationReason != null &&
                    this.DeprecationReason.SequenceEqual(input.DeprecationReason)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.PaymentMethodBrand == input.PaymentMethodBrand ||
                    (this.PaymentMethodBrand != null &&
                    this.PaymentMethodBrand.Equals(input.PaymentMethodBrand))
                ) && 
                (
                    this.PrimaryRiskTaker == input.PrimaryRiskTaker ||
                    (this.PrimaryRiskTaker != null &&
                    this.PrimaryRiskTaker.Equals(input.PrimaryRiskTaker))
                ) && 
                (
                    this.Processor == input.Processor ||
                    (this.Processor != null &&
                    this.Processor.Equals(input.Processor))
                ) && 
                (
                    this.SupportedCurrencies == input.SupportedCurrencies ||
                    this.SupportedCurrencies != null &&
                    input.SupportedCurrencies != null &&
                    this.SupportedCurrencies.SequenceEqual(input.SupportedCurrencies)
                ) && 
                (
                    this.SupportedCustomersPresences == input.SupportedCustomersPresences ||
                    this.SupportedCustomersPresences != null &&
                    input.SupportedCustomersPresences != null &&
                    this.SupportedCustomersPresences.SequenceEqual(input.SupportedCustomersPresences)
                ) && 
                (
                    this.SupportedFeatures == input.SupportedFeatures ||
                    this.SupportedFeatures != null &&
                    input.SupportedFeatures != null &&
                    this.SupportedFeatures.SequenceEqual(input.SupportedFeatures)
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
                if (this.DataCollectionType != null)
                    hashCode = hashCode * 59 + this.DataCollectionType.GetHashCode();
                if (this.Deprecated != null)
                    hashCode = hashCode * 59 + this.Deprecated.GetHashCode();
                if (this.DeprecationReason != null)
                    hashCode = hashCode * 59 + this.DeprecationReason.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Feature != null)
                    hashCode = hashCode * 59 + this.Feature.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.PaymentMethodBrand != null)
                    hashCode = hashCode * 59 + this.PaymentMethodBrand.GetHashCode();
                if (this.PrimaryRiskTaker != null)
                    hashCode = hashCode * 59 + this.PrimaryRiskTaker.GetHashCode();
                if (this.Processor != null)
                    hashCode = hashCode * 59 + this.Processor.GetHashCode();
                if (this.SupportedCurrencies != null)
                    hashCode = hashCode * 59 + this.SupportedCurrencies.GetHashCode();
                if (this.SupportedCustomersPresences != null)
                    hashCode = hashCode * 59 + this.SupportedCustomersPresences.GetHashCode();
                if (this.SupportedFeatures != null)
                    hashCode = hashCode * 59 + this.SupportedFeatures.GetHashCode();
                return hashCode;
            }
        }

    }

}
