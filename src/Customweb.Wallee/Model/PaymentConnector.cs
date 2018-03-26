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
    /// Payment Connector
    /// </summary>
    [DataContract]
    public partial class PaymentConnector :  IEquatable<PaymentConnector>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentConnector" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentConnector()
        {
        }

        /// <summary>
        /// DataCollectionType
        /// </summary>
        /// <value>DataCollectionType</value>
        [DataMember(Name="dataCollectionType", EmitDefaultValue=false)]
        public DataCollectionType? DataCollectionType { get; private set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        /// <value>Deprecated</value>
        [DataMember(Name="deprecated", EmitDefaultValue=false)]
        public bool? Deprecated { get; private set; }

        /// <summary>
        /// DeprecationReason
        /// </summary>
        /// <value>DeprecationReason</value>
        [DataMember(Name="deprecationReason", EmitDefaultValue=false)]
        public Dictionary<string, string> DeprecationReason { get; private set; }

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
        public Feature Feature { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

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
        /// PaymentMethodBrand
        /// </summary>
        /// <value>PaymentMethodBrand</value>
        [DataMember(Name="paymentMethodBrand", EmitDefaultValue=false)]
        public PaymentMethodBrand PaymentMethodBrand { get; private set; }

        /// <summary>
        /// PrimaryRiskTaker
        /// </summary>
        /// <value>PrimaryRiskTaker</value>
        [DataMember(Name="primaryRiskTaker", EmitDefaultValue=false)]
        public PaymentPrimaryRiskTaker? PrimaryRiskTaker { get; private set; }

        /// <summary>
        /// Processor
        /// </summary>
        /// <value>Processor</value>
        [DataMember(Name="processor", EmitDefaultValue=false)]
        public long? Processor { get; private set; }

        /// <summary>
        /// SupportedCustomersPresences
        /// </summary>
        /// <value>SupportedCustomersPresences</value>
        [DataMember(Name="supportedCustomersPresences", EmitDefaultValue=false)]
        public List<CustomersPresence> SupportedCustomersPresences { get; private set; }

        /// <summary>
        /// SupportedFeatures
        /// </summary>
        /// <value>SupportedFeatures</value>
        [DataMember(Name="supportedFeatures", EmitDefaultValue=false)]
        public List<long?> SupportedFeatures { get; private set; }

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
            return this.Equals(obj as PaymentConnector);
        }

        /// <summary>
        /// Returns true if PaymentConnector instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentConnector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentConnector other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.DataCollectionType == other.DataCollectionType ||
                    this.DataCollectionType != null &&
                    this.DataCollectionType.Equals(other.DataCollectionType)
                ) && 
                (
                    this.Deprecated == other.Deprecated ||
                    this.Deprecated != null &&
                    this.Deprecated.Equals(other.Deprecated)
                ) && 
                (
                    this.DeprecationReason == other.DeprecationReason ||
                    this.DeprecationReason != null &&
                    this.DeprecationReason.SequenceEqual(other.DeprecationReason)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                ) && 
                (
                    this.PaymentMethodBrand == other.PaymentMethodBrand ||
                    this.PaymentMethodBrand != null &&
                    this.PaymentMethodBrand.Equals(other.PaymentMethodBrand)
                ) && 
                (
                    this.PrimaryRiskTaker == other.PrimaryRiskTaker ||
                    this.PrimaryRiskTaker != null &&
                    this.PrimaryRiskTaker.Equals(other.PrimaryRiskTaker)
                ) && 
                (
                    this.Processor == other.Processor ||
                    this.Processor != null &&
                    this.Processor.Equals(other.Processor)
                ) && 
                (
                    this.SupportedCustomersPresences == other.SupportedCustomersPresences ||
                    this.SupportedCustomersPresences != null &&
                    this.SupportedCustomersPresences.SequenceEqual(other.SupportedCustomersPresences)
                ) && 
                (
                    this.SupportedFeatures == other.SupportedFeatures ||
                    this.SupportedFeatures != null &&
                    this.SupportedFeatures.SequenceEqual(other.SupportedFeatures)
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
                if (this.DataCollectionType != null)
                {
                    hash = hash * 59 + this.DataCollectionType.GetHashCode();
                }
                if (this.Deprecated != null)
                {
                    hash = hash * 59 + this.Deprecated.GetHashCode();
                }
                if (this.DeprecationReason != null)
                {
                    hash = hash * 59 + this.DeprecationReason.GetHashCode();
                }
                if (this.Description != null)
                {
                    hash = hash * 59 + this.Description.GetHashCode();
                }
                if (this.Feature != null)
                {
                    hash = hash * 59 + this.Feature.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.PaymentMethod != null)
                {
                    hash = hash * 59 + this.PaymentMethod.GetHashCode();
                }
                if (this.PaymentMethodBrand != null)
                {
                    hash = hash * 59 + this.PaymentMethodBrand.GetHashCode();
                }
                if (this.PrimaryRiskTaker != null)
                {
                    hash = hash * 59 + this.PrimaryRiskTaker.GetHashCode();
                }
                if (this.Processor != null)
                {
                    hash = hash * 59 + this.Processor.GetHashCode();
                }
                if (this.SupportedCustomersPresences != null)
                {
                    hash = hash * 59 + this.SupportedCustomersPresences.GetHashCode();
                }
                if (this.SupportedFeatures != null)
                {
                    hash = hash * 59 + this.SupportedFeatures.GetHashCode();
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
