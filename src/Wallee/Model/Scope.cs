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
    /// Scope
    /// </summary>
    [DataContract]
    public partial class Scope :  IEquatable<Scope>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Scope" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Scope()
        {
        }

        /// <summary>
        /// The domain name to which this scope is mapped to.
        /// </summary>
        /// <value>The domain name to which this scope is mapped to.</value>
        [DataMember(Name="domainName", EmitDefaultValue=true)]
        public string DomainName { get; private set; }

        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name="features", EmitDefaultValue=true)]
        public List<Feature> Features { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets MachineName
        /// </summary>
        [DataMember(Name="machineName", EmitDefaultValue=true)]
        public string MachineName { get; private set; }

        /// <summary>
        /// The name of the scope is shown to the user where the user should select a scope.
        /// </summary>
        /// <value>The name of the scope is shown to the user where the user should select a scope.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=true)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The port number to which this scope is mapped to.
        /// </summary>
        /// <value>The port number to which this scope is mapped to.</value>
        [DataMember(Name="port", EmitDefaultValue=true)]
        public int? Port { get; private set; }

        /// <summary>
        /// Define whether the scope supports SSL.
        /// </summary>
        /// <value>Define whether the scope supports SSL.</value>
        [DataMember(Name="sslActive", EmitDefaultValue=true)]
        public bool? SslActive { get; private set; }


        /// <summary>
        /// The themes determines how the application layout, look and feel is. By providing multiple themes you can fallback to other themes.
        /// </summary>
        /// <value>The themes determines how the application layout, look and feel is. By providing multiple themes you can fallback to other themes.</value>
        [DataMember(Name="themes", EmitDefaultValue=true)]
        public List<string> Themes { get; private set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=true)]
        public string Url { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Scope {\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MachineName: ").Append(MachineName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  SslActive: ").Append(SslActive).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Themes: ").Append(Themes).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as Scope);
        }

        /// <summary>
        /// Returns true if Scope instances are equal
        /// </summary>
        /// <param name="input">Instance of Scope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Scope input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.Features == input.Features ||
                    this.Features != null &&
                    input.Features != null &&
                    this.Features.SequenceEqual(input.Features)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MachineName == input.MachineName ||
                    (this.MachineName != null &&
                    this.MachineName.Equals(input.MachineName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.SslActive == input.SslActive ||
                    (this.SslActive != null &&
                    this.SslActive.Equals(input.SslActive))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Themes == input.Themes ||
                    this.Themes != null &&
                    input.Themes != null &&
                    this.Themes.SequenceEqual(input.Themes)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.Features != null)
                    hashCode = hashCode * 59 + this.Features.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MachineName != null)
                    hashCode = hashCode * 59 + this.MachineName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.SslActive != null)
                    hashCode = hashCode * 59 + this.SslActive.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Themes != null)
                    hashCode = hashCode * 59 + this.Themes.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
