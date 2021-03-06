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
    /// PaymentTerminal
    /// </summary>
    [DataContract]
    public partial class PaymentTerminal :  IEquatable<PaymentTerminal>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public PaymentTerminalState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentTerminal()
        {
        }

        /// <summary>
        /// Gets or Sets ConfigurationVersion
        /// </summary>
        [DataMember(Name="configurationVersion", EmitDefaultValue=true)]
        public PaymentTerminalConfigurationVersion ConfigurationVersion { get; private set; }

        /// <summary>
        /// Gets or Sets DefaultCurrency
        /// </summary>
        [DataMember(Name="defaultCurrency", EmitDefaultValue=true)]
        public string DefaultCurrency { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// The identifier uniquely identifies the terminal. Normally it is visible on the device or in the display of the device.
        /// </summary>
        /// <value>The identifier uniquely identifies the terminal. Normally it is visible on the device or in the display of the device.</value>
        [DataMember(Name="identifier", EmitDefaultValue=true)]
        public string Identifier { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=true)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// Gets or Sets LocationVersion
        /// </summary>
        [DataMember(Name="locationVersion", EmitDefaultValue=true)]
        public PaymentTerminalLocationVersion LocationVersion { get; private set; }

        /// <summary>
        /// The terminal name is used internally to identify the terminal in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The terminal name is used internally to identify the terminal in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=true)]
        public DateTime? PlannedPurgeDate { get; private set; }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public PaymentTerminalType Type { get; private set; }

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
            sb.Append("class PaymentTerminal {\n");
            sb.Append("  ConfigurationVersion: ").Append(ConfigurationVersion).Append("\n");
            sb.Append("  DefaultCurrency: ").Append(DefaultCurrency).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LocationVersion: ").Append(LocationVersion).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as PaymentTerminal);
        }

        /// <summary>
        /// Returns true if PaymentTerminal instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTerminal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTerminal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigurationVersion == input.ConfigurationVersion ||
                    (this.ConfigurationVersion != null &&
                    this.ConfigurationVersion.Equals(input.ConfigurationVersion))
                ) && 
                (
                    this.DefaultCurrency == input.DefaultCurrency ||
                    (this.DefaultCurrency != null &&
                    this.DefaultCurrency.Equals(input.DefaultCurrency))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.LocationVersion == input.LocationVersion ||
                    (this.LocationVersion != null &&
                    this.LocationVersion.Equals(input.LocationVersion))
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
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ConfigurationVersion != null)
                    hashCode = hashCode * 59 + this.ConfigurationVersion.GetHashCode();
                if (this.DefaultCurrency != null)
                    hashCode = hashCode * 59 + this.DefaultCurrency.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LocationVersion != null)
                    hashCode = hashCode * 59 + this.LocationVersion.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
