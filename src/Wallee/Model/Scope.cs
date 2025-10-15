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
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Scope" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Scope()
        {
        }

        /// <summary>
        /// The domain name that belongs to the scope.
        /// </summary>
        /// <value>The domain name that belongs to the scope.</value>
        [DataMember(Name="domainName", EmitDefaultValue=false)]
        public string DomainName { get; private set; }

        /// <summary>
        /// The list of features that are active in the scope.
        /// </summary>
        /// <value>The list of features that are active in the scope.</value>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public List<Feature> Features { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The name identifying the scope in e.g. URLs.
        /// </summary>
        /// <value>The name identifying the scope in e.g. URLs.</value>
        [DataMember(Name="machineName", EmitDefaultValue=false)]
        public string MachineName { get; private set; }

        /// <summary>
        /// The name used to identify the scope.
        /// </summary>
        /// <value>The name used to identify the scope.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The port where the scope can be accessed.
        /// </summary>
        /// <value>The port where the scope can be accessed.</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; private set; }

        /// <summary>
        /// The preprod domain name that belongs to the scope.
        /// </summary>
        /// <value>The preprod domain name that belongs to the scope.</value>
        [DataMember(Name="preprodDomainName", EmitDefaultValue=false)]
        public string PreprodDomainName { get; private set; }

        /// <summary>
        /// The sandbox domain name that belongs to the scope.
        /// </summary>
        /// <value>The sandbox domain name that belongs to the scope.</value>
        [DataMember(Name="sandboxDomainName", EmitDefaultValue=false)]
        public string SandboxDomainName { get; private set; }

        /// <summary>
        /// Whether the scope supports SSL.
        /// </summary>
        /// <value>Whether the scope supports SSL.</value>
        [DataMember(Name="sslActive", EmitDefaultValue=false)]
        public bool? SslActive { get; private set; }


        /// <summary>
        /// The themes that determine the look and feel of the scope&#39;s user interface. A fall-through strategy is applied when building the actual theme.
        /// </summary>
        /// <value>The themes that determine the look and feel of the scope&#39;s user interface. A fall-through strategy is applied when building the actual theme.</value>
        [DataMember(Name="themes", EmitDefaultValue=false)]
        public List<string> Themes { get; private set; }

        /// <summary>
        /// The URL where the scope can be accessed.
        /// </summary>
        /// <value>The URL where the scope can be accessed.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }

        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
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
            sb.Append("  PreprodDomainName: ").Append(PreprodDomainName).Append("\n");
            sb.Append("  SandboxDomainName: ").Append(SandboxDomainName).Append("\n");
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
                    this.PreprodDomainName == input.PreprodDomainName ||
                    (this.PreprodDomainName != null &&
                    this.PreprodDomainName.Equals(input.PreprodDomainName))
                ) && 
                (
                    this.SandboxDomainName == input.SandboxDomainName ||
                    (this.SandboxDomainName != null &&
                    this.SandboxDomainName.Equals(input.SandboxDomainName))
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
                if (this.PreprodDomainName != null)
                    hashCode = hashCode * 59 + this.PreprodDomainName.GetHashCode();
                if (this.SandboxDomainName != null)
                    hashCode = hashCode * 59 + this.SandboxDomainName.GetHashCode();
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
