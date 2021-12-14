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
    /// PaymentTerminalConfigurationVersion
    /// </summary>
    [DataContract]
    public partial class PaymentTerminalConfigurationVersion :  IEquatable<PaymentTerminalConfigurationVersion>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public PaymentTerminalConfigurationVersionState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalConfigurationVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentTerminalConfigurationVersion()
        {
        }

        /// <summary>
        /// Gets or Sets Configuration
        /// </summary>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public PaymentTerminalConfiguration Configuration { get; private set; }

        /// <summary>
        /// Gets or Sets ConnectorConfigurations
        /// </summary>
        [DataMember(Name="connectorConfigurations", EmitDefaultValue=false)]
        public List<long?> ConnectorConfigurations { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public long? CreatedBy { get; private set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The currency is derived by default from the terminal location. By setting a specific currency the derived currency is overridden.
        /// </summary>
        /// <value>The currency is derived by default from the terminal location. By setting a specific currency the derived currency is overridden.</value>
        [DataMember(Name="defaultCurrency", EmitDefaultValue=false)]
        public string DefaultCurrency { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// Gets or Sets MaintenanceWindowDuration
        /// </summary>
        [DataMember(Name="maintenanceWindowDuration", EmitDefaultValue=false)]
        public string MaintenanceWindowDuration { get; private set; }

        /// <summary>
        /// Gets or Sets MaintenanceWindowStart
        /// </summary>
        [DataMember(Name="maintenanceWindowStart", EmitDefaultValue=false)]
        public string MaintenanceWindowStart { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }


        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Gets or Sets VersionAppliedImmediately
        /// </summary>
        [DataMember(Name="versionAppliedImmediately", EmitDefaultValue=false)]
        public bool? VersionAppliedImmediately { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTerminalConfigurationVersion {\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  ConnectorConfigurations: ").Append(ConnectorConfigurations).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  DefaultCurrency: ").Append(DefaultCurrency).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  MaintenanceWindowDuration: ").Append(MaintenanceWindowDuration).Append("\n");
            sb.Append("  MaintenanceWindowStart: ").Append(MaintenanceWindowStart).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  VersionAppliedImmediately: ").Append(VersionAppliedImmediately).Append("\n");
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
            return this.Equals(input as PaymentTerminalConfigurationVersion);
        }

        /// <summary>
        /// Returns true if PaymentTerminalConfigurationVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTerminalConfigurationVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTerminalConfigurationVersion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Configuration == input.Configuration ||
                    (this.Configuration != null &&
                    this.Configuration.Equals(input.Configuration))
                ) && 
                (
                    this.ConnectorConfigurations == input.ConnectorConfigurations ||
                    this.ConnectorConfigurations != null &&
                    input.ConnectorConfigurations != null &&
                    this.ConnectorConfigurations.SequenceEqual(input.ConnectorConfigurations)
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
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
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.MaintenanceWindowDuration == input.MaintenanceWindowDuration ||
                    (this.MaintenanceWindowDuration != null &&
                    this.MaintenanceWindowDuration.Equals(input.MaintenanceWindowDuration))
                ) && 
                (
                    this.MaintenanceWindowStart == input.MaintenanceWindowStart ||
                    (this.MaintenanceWindowStart != null &&
                    this.MaintenanceWindowStart.Equals(input.MaintenanceWindowStart))
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
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.VersionAppliedImmediately == input.VersionAppliedImmediately ||
                    (this.VersionAppliedImmediately != null &&
                    this.VersionAppliedImmediately.Equals(input.VersionAppliedImmediately))
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
                if (this.Configuration != null)
                    hashCode = hashCode * 59 + this.Configuration.GetHashCode();
                if (this.ConnectorConfigurations != null)
                    hashCode = hashCode * 59 + this.ConnectorConfigurations.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.DefaultCurrency != null)
                    hashCode = hashCode * 59 + this.DefaultCurrency.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.MaintenanceWindowDuration != null)
                    hashCode = hashCode * 59 + this.MaintenanceWindowDuration.GetHashCode();
                if (this.MaintenanceWindowStart != null)
                    hashCode = hashCode * 59 + this.MaintenanceWindowStart.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VersionAppliedImmediately != null)
                    hashCode = hashCode * 59 + this.VersionAppliedImmediately.GetHashCode();
                return hashCode;
            }
        }

    }

}
