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
    /// Feature
    /// </summary>
    [DataContract]
    public partial class Feature :  IEquatable<Feature>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Feature" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Feature()
        {
        }

        /// <summary>
        /// Gets or Sets Beta
        /// </summary>
        [DataMember(Name="beta", EmitDefaultValue=false)]
        public bool? Beta { get; private set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets LogoPath
        /// </summary>
        [DataMember(Name="logoPath", EmitDefaultValue=false)]
        public string LogoPath { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; private set; }

        /// <summary>
        /// Gets or Sets RequiredFeatures
        /// </summary>
        [DataMember(Name="requiredFeatures", EmitDefaultValue=false)]
        public List<long?> RequiredFeatures { get; private set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; private set; }

        /// <summary>
        /// Gets or Sets Visible
        /// </summary>
        [DataMember(Name="visible", EmitDefaultValue=false)]
        public bool? Visible { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Feature {\n");
            sb.Append("  Beta: ").Append(Beta).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LogoPath: ").Append(LogoPath).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RequiredFeatures: ").Append(RequiredFeatures).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
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
            return this.Equals(input as Feature);
        }

        /// <summary>
        /// Returns true if Feature instances are equal
        /// </summary>
        /// <param name="input">Instance of Feature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Feature input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Beta == input.Beta ||
                    (this.Beta != null &&
                    this.Beta.Equals(input.Beta))
                ) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    this.Description.SequenceEqual(input.Description)
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
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.RequiredFeatures == input.RequiredFeatures ||
                    this.RequiredFeatures != null &&
                    this.RequiredFeatures.SequenceEqual(input.RequiredFeatures)
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.Visible == input.Visible ||
                    (this.Visible != null &&
                    this.Visible.Equals(input.Visible))
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
                if (this.Beta != null)
                    hashCode = hashCode * 59 + this.Beta.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LogoPath != null)
                    hashCode = hashCode * 59 + this.LogoPath.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RequiredFeatures != null)
                    hashCode = hashCode * 59 + this.RequiredFeatures.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.Visible != null)
                    hashCode = hashCode * 59 + this.Visible.GetHashCode();
                return hashCode;
            }
        }

    }

}
