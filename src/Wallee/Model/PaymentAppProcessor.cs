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
    /// PaymentAppProcessor
    /// </summary>
    [DataContract]
    public partial class PaymentAppProcessor :  IEquatable<PaymentAppProcessor>
    {
        /// <summary>
        /// Gets or Sets ConfiguredEnvironment
        /// </summary>
        [DataMember(Name="configuredEnvironment", EmitDefaultValue=true)]
        public ChargeAttemptEnvironment? ConfiguredEnvironment { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public PaymentAppProcessorState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppProcessor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentAppProcessor()
        {
        }


        /// <summary>
        /// The created on date is the date when this processor has been added.
        /// </summary>
        /// <value>The created on date is the date when this processor has been added.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=true)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The documentation URL points to a web site that describes how to configure and use the processor.
        /// </summary>
        /// <value>The documentation URL points to a web site that describes how to configure and use the processor.</value>
        [DataMember(Name="documentationUrl", EmitDefaultValue=true)]
        public string DocumentationUrl { get; private set; }

        /// <summary>
        /// The external ID corresponds to the ID that was provided during creation of the processor.
        /// </summary>
        /// <value>The external ID corresponds to the ID that was provided during creation of the processor.</value>
        [DataMember(Name="externalId", EmitDefaultValue=true)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// The installation ID identifies the Web App installation.
        /// </summary>
        /// <value>The installation ID identifies the Web App installation.</value>
        [DataMember(Name="installationId", EmitDefaultValue=true)]
        public long? InstallationId { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=true)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The name of the processor will be displayed within the user interfaces that the merchant is interacting with.
        /// </summary>
        /// <value>The name of the processor will be displayed within the user interfaces that the merchant is interacting with.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; private set; }

        /// <summary>
        /// This processor configuration is created as part of the app processor. Any transaction created with the processor is linked with this processor configuration.
        /// </summary>
        /// <value>This processor configuration is created as part of the app processor. Any transaction created with the processor is linked with this processor configuration.</value>
        [DataMember(Name="processorConfiguration", EmitDefaultValue=true)]
        public PaymentProcessorConfiguration ProcessorConfiguration { get; private set; }

        /// <summary>
        /// When the user sets the processor into the production mode the user will be forwarded to this URL to configure the production environment. When no URL is provided no redirection will happen.
        /// </summary>
        /// <value>When the user sets the processor into the production mode the user will be forwarded to this URL to configure the production environment. When no URL is provided no redirection will happen.</value>
        [DataMember(Name="productionModeUrl", EmitDefaultValue=true)]
        public string ProductionModeUrl { get; private set; }


        /// <summary>
        /// Gets or Sets SvgIcon
        /// </summary>
        [DataMember(Name="svgIcon", EmitDefaultValue=true)]
        public string SvgIcon { get; private set; }

        /// <summary>
        /// The updated on date indicates when the last update on the processor occurred.
        /// </summary>
        /// <value>The updated on date indicates when the last update on the processor occurred.</value>
        [DataMember(Name="updatedOn", EmitDefaultValue=true)]
        public DateTime? UpdatedOn { get; private set; }

        /// <summary>
        /// When the processor is ready to be used for transactions in the production environment this flag is set to true.
        /// </summary>
        /// <value>When the processor is ready to be used for transactions in the production environment this flag is set to true.</value>
        [DataMember(Name="usableInProduction", EmitDefaultValue=true)]
        public bool? UsableInProduction { get; private set; }

        /// <summary>
        /// Gets or Sets UsableInProductionSince
        /// </summary>
        [DataMember(Name="usableInProductionSince", EmitDefaultValue=true)]
        public DateTime? UsableInProductionSince { get; private set; }

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
            sb.Append("class PaymentAppProcessor {\n");
            sb.Append("  ConfiguredEnvironment: ").Append(ConfiguredEnvironment).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  DocumentationUrl: ").Append(DocumentationUrl).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InstallationId: ").Append(InstallationId).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProcessorConfiguration: ").Append(ProcessorConfiguration).Append("\n");
            sb.Append("  ProductionModeUrl: ").Append(ProductionModeUrl).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SvgIcon: ").Append(SvgIcon).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  UsableInProduction: ").Append(UsableInProduction).Append("\n");
            sb.Append("  UsableInProductionSince: ").Append(UsableInProductionSince).Append("\n");
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
            return this.Equals(input as PaymentAppProcessor);
        }

        /// <summary>
        /// Returns true if PaymentAppProcessor instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAppProcessor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAppProcessor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfiguredEnvironment == input.ConfiguredEnvironment ||
                    (this.ConfiguredEnvironment != null &&
                    this.ConfiguredEnvironment.Equals(input.ConfiguredEnvironment))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.DocumentationUrl == input.DocumentationUrl ||
                    (this.DocumentationUrl != null &&
                    this.DocumentationUrl.Equals(input.DocumentationUrl))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InstallationId == input.InstallationId ||
                    (this.InstallationId != null &&
                    this.InstallationId.Equals(input.InstallationId))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProcessorConfiguration == input.ProcessorConfiguration ||
                    (this.ProcessorConfiguration != null &&
                    this.ProcessorConfiguration.Equals(input.ProcessorConfiguration))
                ) && 
                (
                    this.ProductionModeUrl == input.ProductionModeUrl ||
                    (this.ProductionModeUrl != null &&
                    this.ProductionModeUrl.Equals(input.ProductionModeUrl))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.SvgIcon == input.SvgIcon ||
                    (this.SvgIcon != null &&
                    this.SvgIcon.Equals(input.SvgIcon))
                ) && 
                (
                    this.UpdatedOn == input.UpdatedOn ||
                    (this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(input.UpdatedOn))
                ) && 
                (
                    this.UsableInProduction == input.UsableInProduction ||
                    (this.UsableInProduction != null &&
                    this.UsableInProduction.Equals(input.UsableInProduction))
                ) && 
                (
                    this.UsableInProductionSince == input.UsableInProductionSince ||
                    (this.UsableInProductionSince != null &&
                    this.UsableInProductionSince.Equals(input.UsableInProductionSince))
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
                if (this.ConfiguredEnvironment != null)
                    hashCode = hashCode * 59 + this.ConfiguredEnvironment.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.DocumentationUrl != null)
                    hashCode = hashCode * 59 + this.DocumentationUrl.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstallationId != null)
                    hashCode = hashCode * 59 + this.InstallationId.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProcessorConfiguration != null)
                    hashCode = hashCode * 59 + this.ProcessorConfiguration.GetHashCode();
                if (this.ProductionModeUrl != null)
                    hashCode = hashCode * 59 + this.ProductionModeUrl.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SvgIcon != null)
                    hashCode = hashCode * 59 + this.SvgIcon.GetHashCode();
                if (this.UpdatedOn != null)
                    hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.UsableInProduction != null)
                    hashCode = hashCode * 59 + this.UsableInProduction.GetHashCode();
                if (this.UsableInProductionSince != null)
                    hashCode = hashCode * 59 + this.UsableInProductionSince.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
