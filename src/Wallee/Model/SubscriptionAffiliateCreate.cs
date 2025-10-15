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
    /// SubscriptionAffiliateCreate
    /// </summary>
    [DataContract]
    public partial class SubscriptionAffiliateCreate : AbstractSubscriptionAffiliateUpdate,  IEquatable<SubscriptionAffiliateCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionAffiliateCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionAffiliateCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionAffiliateCreate" /> class.
        /// </summary>
        /// <param name="reference">The reference used to identify the affiliate. (required).</param>
        /// <param name="externalId">A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result. (required).</param>
        public SubscriptionAffiliateCreate(string reference, string externalId)
        {
            // to ensure "reference" is required (not null)
            if (reference == null)
            {
                throw new InvalidDataException("reference is a required property for SubscriptionAffiliateCreate and cannot be null");
            }
            this.Reference = reference;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new InvalidDataException("externalId is a required property for SubscriptionAffiliateCreate and cannot be null");
            }
            this.ExternalId = externalId;
        }





        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The reference used to identify the affiliate.
        /// </summary>
        /// <value>The reference used to identify the affiliate.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionAffiliateCreate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as SubscriptionAffiliateCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionAffiliateCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionAffiliateCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionAffiliateCreate input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && base.Equals(input) && 
                (
                    this.MetaData == input.MetaData ||
                    this.MetaData != null &&
                    input.MetaData != null &&
                    this.MetaData.SequenceEqual(input.MetaData)
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && base.Equals(input) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && base.Equals(input) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                int hashCode = base.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.MetaData != null)
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                return hashCode;
            }
        }

    }

}
