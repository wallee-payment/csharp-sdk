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
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public PaymentTerminalConfigurationVersionState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalConfigurationVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentTerminalConfigurationVersion()
        {
        }

        /// <summary>
        /// The payment terminal configuration that the version belongs to.
        /// </summary>
        /// <value>The payment terminal configuration that the version belongs to.</value>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public PaymentTerminalConfiguration Configuration { get; private set; }

        /// <summary>
        /// The payment connector configurations that are available on the payment terminal.
        /// </summary>
        /// <value>The payment connector configurations that are available on the payment terminal.</value>
        [DataMember(Name="connectorConfigurations", EmitDefaultValue=false)]
        public List<long?> ConnectorConfigurations { get; private set; }

        /// <summary>
        /// The ID of the user the payment terminal configuration version was created by.
        /// </summary>
        /// <value>The ID of the user the payment terminal configuration version was created by.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public long? CreatedBy { get; private set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The default currency that is used if none is set on the payment terminal itself. If it is empty, the currency is derived from the location of the terminal.
        /// </summary>
        /// <value>The default currency that is used if none is set on the payment terminal itself. If it is empty, the currency is derived from the location of the terminal.</value>
        [DataMember(Name="defaultCurrency", EmitDefaultValue=false)]
        public string DefaultCurrency { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The permitted duration of the terminal&#39;s maintenance window.
        /// </summary>
        /// <value>The permitted duration of the terminal&#39;s maintenance window.</value>
        [DataMember(Name="maintenanceWindowDuration", EmitDefaultValue=false)]
        public string MaintenanceWindowDuration { get; private set; }

        /// <summary>
        /// The start time of the terminal&#39;s maintenance window.
        /// </summary>
        /// <value>The start time of the terminal&#39;s maintenance window.</value>
        [DataMember(Name="maintenanceWindowStart", EmitDefaultValue=false)]
        public string MaintenanceWindowStart { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }


        /// <summary>
        /// The time zone of the payment terminal used to determine the maintenance window.
        /// </summary>
        /// <value>The time zone of the payment terminal used to determine the maintenance window.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; private set; }

        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Whether payment terminals are immediately updated to this configuration version. If not, it will be applied during the maintenance window.
        /// </summary>
        /// <value>Whether payment terminals are immediately updated to this configuration version. If not, it will be applied during the maintenance window.</value>
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
