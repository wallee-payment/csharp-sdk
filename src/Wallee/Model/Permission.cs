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
    /// Permission
    /// </summary>
    [DataContract]
    public partial class Permission :  IEquatable<Permission>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Permission()
        {
        }

        /// <summary>
        /// The description of the object translated into different languages.
        /// </summary>
        /// <value>The description of the object translated into different languages.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// Gets or Sets Feature
        /// </summary>
        [DataMember(Name="feature", EmitDefaultValue=false)]
        public long? Feature { get; private set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public bool? Group { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Leaf
        /// </summary>
        [DataMember(Name="leaf", EmitDefaultValue=false)]
        public bool? Leaf { get; private set; }

        /// <summary>
        /// The name of the object translated into different languages.
        /// </summary>
        /// <value>The name of the object translated into different languages.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; private set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public long? Parent { get; private set; }

        /// <summary>
        /// Gets or Sets PathToRoot
        /// </summary>
        [DataMember(Name="pathToRoot", EmitDefaultValue=false)]
        public List<long?> PathToRoot { get; private set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public Dictionary<string, string> Title { get; private set; }

        /// <summary>
        /// Gets or Sets TwoFactorRequired
        /// </summary>
        [DataMember(Name="twoFactorRequired", EmitDefaultValue=false)]
        public bool? TwoFactorRequired { get; private set; }

        /// <summary>
        /// Gets or Sets WebAppEnabled
        /// </summary>
        [DataMember(Name="webAppEnabled", EmitDefaultValue=false)]
        public bool? WebAppEnabled { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Permission {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Feature: ").Append(Feature).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Leaf: ").Append(Leaf).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  PathToRoot: ").Append(PathToRoot).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TwoFactorRequired: ").Append(TwoFactorRequired).Append("\n");
            sb.Append("  WebAppEnabled: ").Append(WebAppEnabled).Append("\n");
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
            return this.Equals(input as Permission);
        }

        /// <summary>
        /// Returns true if Permission instances are equal
        /// </summary>
        /// <param name="input">Instance of Permission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Permission input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Leaf == input.Leaf ||
                    (this.Leaf != null &&
                    this.Leaf.Equals(input.Leaf))
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && 
                (
                    this.PathToRoot == input.PathToRoot ||
                    this.PathToRoot != null &&
                    input.PathToRoot != null &&
                    this.PathToRoot.SequenceEqual(input.PathToRoot)
                ) && 
                (
                    this.Title == input.Title ||
                    this.Title != null &&
                    input.Title != null &&
                    this.Title.SequenceEqual(input.Title)
                ) && 
                (
                    this.TwoFactorRequired == input.TwoFactorRequired ||
                    (this.TwoFactorRequired != null &&
                    this.TwoFactorRequired.Equals(input.TwoFactorRequired))
                ) && 
                (
                    this.WebAppEnabled == input.WebAppEnabled ||
                    (this.WebAppEnabled != null &&
                    this.WebAppEnabled.Equals(input.WebAppEnabled))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Feature != null)
                    hashCode = hashCode * 59 + this.Feature.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Leaf != null)
                    hashCode = hashCode * 59 + this.Leaf.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Parent != null)
                    hashCode = hashCode * 59 + this.Parent.GetHashCode();
                if (this.PathToRoot != null)
                    hashCode = hashCode * 59 + this.PathToRoot.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.TwoFactorRequired != null)
                    hashCode = hashCode * 59 + this.TwoFactorRequired.GetHashCode();
                if (this.WebAppEnabled != null)
                    hashCode = hashCode * 59 + this.WebAppEnabled.GetHashCode();
                return hashCode;
            }
        }

    }

}
