
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
    /// Feature model.
    /// </summary>
    [DataContract]
    public partial class Feature :  IEquatable<Feature>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Feature" /> class.
        /// </summary>
        /// <param name="Beta">Beta</param>
        /// <param name="Description">Description</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="LogoPath">LogoPath</param>
        /// <param name="Name">Name</param>
        /// <param name="RequiredFeatures">RequiredFeatures</param>
        /// <param name="SortOrder">SortOrder</param>
        /// <param name="Visible">Visible</param>
        public Feature(bool? Beta = default(bool?), Dictionary<string, string> Description = default(Dictionary<string, string>), long? Id = default(long?), string LogoPath = default(string), Dictionary<string, string> Name = default(Dictionary<string, string>), List<long?> RequiredFeatures = default(List<long?>), int? SortOrder = default(int?), bool? Visible = default(bool?))
        {
            this.Beta = Beta;
            this.Description = Description;
            this.Id = Id;
            this.LogoPath = LogoPath;
            this.Name = Name;
            this.RequiredFeatures = RequiredFeatures;
            this.SortOrder = SortOrder;
            this.Visible = Visible;
        }

        /// <summary>
        /// Beta
        /// </summary>
        /// <value>Beta</value>
        [DataMember(Name="beta", EmitDefaultValue=false)]
        public bool? Beta { get; set; }

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
        /// LogoPath
        /// </summary>
        /// <value>LogoPath</value>
        [DataMember(Name="logoPath", EmitDefaultValue=false)]
        public string LogoPath { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// RequiredFeatures
        /// </summary>
        /// <value>RequiredFeatures</value>
        [DataMember(Name="requiredFeatures", EmitDefaultValue=false)]
        public List<long?> RequiredFeatures { get; set; }

        /// <summary>
        /// SortOrder
        /// </summary>
        /// <value>SortOrder</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Visible
        /// </summary>
        /// <value>Visible</value>
        [DataMember(Name="visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }

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
            return this.Equals(obj as Feature);
        }

        /// <summary>
        /// Returns true if Feature instances are equal
        /// </summary>
        /// <param name="other">Instance of Feature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Feature other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Beta == other.Beta ||
                    this.Beta != null &&
                    this.Beta.Equals(other.Beta)
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
                    this.RequiredFeatures == other.RequiredFeatures ||
                    this.RequiredFeatures != null &&
                    this.RequiredFeatures.SequenceEqual(other.RequiredFeatures)
                ) && 
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
                ) && 
                (
                    this.Visible == other.Visible ||
                    this.Visible != null &&
                    this.Visible.Equals(other.Visible)
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
                if (this.Beta != null)
                    hash = hash * 59 + this.Beta.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LogoPath != null)
                    hash = hash * 59 + this.LogoPath.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.RequiredFeatures != null)
                    hash = hash * 59 + this.RequiredFeatures.GetHashCode();
                if (this.SortOrder != null)
                    hash = hash * 59 + this.SortOrder.GetHashCode();
                if (this.Visible != null)
                    hash = hash * 59 + this.Visible.GetHashCode();
                return hash;
            }
        }

    }

}
