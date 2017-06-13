
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
    /// Scope model.
    /// </summary>
    [DataContract]
    public partial class Scope :  IEquatable<Scope>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Scope" /> class.
        /// </summary>
        /// <param name="DomainName">The domain name to which this scope is mapped to.</param>
        /// <param name="EmailSenderAddress">EmailSenderAddress</param>
        /// <param name="EmailSenderName">EmailSenderName</param>
        /// <param name="Features">Features</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="Name">The name of the scope is shown to the user where the user should select a scope.</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="Port">The port number to which this scope is mapped to.</param>
        /// <param name="SslActive">Define whether the scope supports SSL.</param>
        /// <param name="State">State</param>
        /// <param name="Themes">The themes determines how the application layout, look and feel is. By providing multiple themes you can fallback to other themes.</param>
        /// <param name="Url">Url</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public Scope(string DomainName = default(string), string EmailSenderAddress = default(string), string EmailSenderName = default(string), List<Feature> Features = default(List<Feature>), long? Id = default(long?), string Name = default(string), DateTime? PlannedPurgeDate = default(DateTime?), int? Port = default(int?), bool? SslActive = default(bool?), CreationEntityState State = default(CreationEntityState), List<string> Themes = default(List<string>), string Url = default(string), int? Version = default(int?))
        {
            this.DomainName = DomainName;
            this.EmailSenderAddress = EmailSenderAddress;
            this.EmailSenderName = EmailSenderName;
            this.Features = Features;
            this.Id = Id;
            this.Name = Name;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.Port = Port;
            this.SslActive = SslActive;
            this.State = State;
            this.Themes = Themes;
            this.Url = Url;
            this.Version = Version;
        }

        /// <summary>
        /// The domain name to which this scope is mapped to.
        /// </summary>
        /// <value>The domain name to which this scope is mapped to.</value>
        [DataMember(Name="domainName", EmitDefaultValue=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// EmailSenderAddress
        /// </summary>
        /// <value>EmailSenderAddress</value>
        [DataMember(Name="emailSenderAddress", EmitDefaultValue=false)]
        public string EmailSenderAddress { get; set; }

        /// <summary>
        /// EmailSenderName
        /// </summary>
        /// <value>EmailSenderName</value>
        [DataMember(Name="emailSenderName", EmitDefaultValue=false)]
        public string EmailSenderName { get; set; }

        /// <summary>
        /// Features
        /// </summary>
        /// <value>Features</value>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public List<Feature> Features { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The name of the scope is shown to the user where the user should select a scope.
        /// </summary>
        /// <value>The name of the scope is shown to the user where the user should select a scope.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; set; }

        /// <summary>
        /// The port number to which this scope is mapped to.
        /// </summary>
        /// <value>The port number to which this scope is mapped to.</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// Define whether the scope supports SSL.
        /// </summary>
        /// <value>Define whether the scope supports SSL.</value>
        [DataMember(Name="sslActive", EmitDefaultValue=false)]
        public bool? SslActive { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState State { get; set; }

        /// <summary>
        /// The themes determines how the application layout, look and feel is. By providing multiple themes you can fallback to other themes.
        /// </summary>
        /// <value>The themes determines how the application layout, look and feel is. By providing multiple themes you can fallback to other themes.</value>
        [DataMember(Name="themes", EmitDefaultValue=false)]
        public List<string> Themes { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        /// <value>Url</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Scope {\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  EmailSenderAddress: ").Append(EmailSenderAddress).Append("\n");
            sb.Append("  EmailSenderName: ").Append(EmailSenderName).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as Scope);
        }

        /// <summary>
        /// Returns true if Scope instances are equal
        /// </summary>
        /// <param name="other">Instance of Scope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Scope other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.DomainName == other.DomainName ||
                    this.DomainName != null &&
                    this.DomainName.Equals(other.DomainName)
                ) && 
                (
                    this.EmailSenderAddress == other.EmailSenderAddress ||
                    this.EmailSenderAddress != null &&
                    this.EmailSenderAddress.Equals(other.EmailSenderAddress)
                ) && 
                (
                    this.EmailSenderName == other.EmailSenderName ||
                    this.EmailSenderName != null &&
                    this.EmailSenderName.Equals(other.EmailSenderName)
                ) && 
                (
                    this.Features == other.Features ||
                    this.Features != null &&
                    this.Features.SequenceEqual(other.Features)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.Port == other.Port ||
                    this.Port != null &&
                    this.Port.Equals(other.Port)
                ) && 
                (
                    this.SslActive == other.SslActive ||
                    this.SslActive != null &&
                    this.SslActive.Equals(other.SslActive)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Themes == other.Themes ||
                    this.Themes != null &&
                    this.Themes.SequenceEqual(other.Themes)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.DomainName != null)
                    hash = hash * 59 + this.DomainName.GetHashCode();
                if (this.EmailSenderAddress != null)
                    hash = hash * 59 + this.EmailSenderAddress.GetHashCode();
                if (this.EmailSenderName != null)
                    hash = hash * 59 + this.EmailSenderName.GetHashCode();
                if (this.Features != null)
                    hash = hash * 59 + this.Features.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.Port != null)
                    hash = hash * 59 + this.Port.GetHashCode();
                if (this.SslActive != null)
                    hash = hash * 59 + this.SslActive.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Themes != null)
                    hash = hash * 59 + this.Themes.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
