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
    /// PaymentInitiationAdviceFile
    /// </summary>
    [DataContract]
    public partial class PaymentInitiationAdviceFile :  IEquatable<PaymentInitiationAdviceFile>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public PaymentInitiationAdviceFileState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInitiationAdviceFile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentInitiationAdviceFile()
        {
        }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// Gets or Sets FailureMessage
        /// </summary>
        [DataMember(Name="failureMessage", EmitDefaultValue=false)]
        public string FailureMessage { get; private set; }

        /// <summary>
        /// Gets or Sets FileGeneratedOn
        /// </summary>
        [DataMember(Name="fileGeneratedOn", EmitDefaultValue=false)]
        public DateTime? FileGeneratedOn { get; private set; }

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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets ProcessedOn
        /// </summary>
        [DataMember(Name="processedOn", EmitDefaultValue=false)]
        public DateTime? ProcessedOn { get; private set; }

        /// <summary>
        /// Gets or Sets Processor
        /// </summary>
        [DataMember(Name="processor", EmitDefaultValue=false)]
        public PaymentProcessor Processor { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentInitiationAdviceFile {\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  FailureMessage: ").Append(FailureMessage).Append("\n");
            sb.Append("  FileGeneratedOn: ").Append(FileGeneratedOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProcessedOn: ").Append(ProcessedOn).Append("\n");
            sb.Append("  Processor: ").Append(Processor).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as PaymentInitiationAdviceFile);
        }

        /// <summary>
        /// Returns true if PaymentInitiationAdviceFile instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentInitiationAdviceFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInitiationAdviceFile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.FailureMessage == input.FailureMessage ||
                    (this.FailureMessage != null &&
                    this.FailureMessage.Equals(input.FailureMessage))
                ) && 
                (
                    this.FileGeneratedOn == input.FileGeneratedOn ||
                    (this.FileGeneratedOn != null &&
                    this.FileGeneratedOn.Equals(input.FileGeneratedOn))
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProcessedOn == input.ProcessedOn ||
                    (this.ProcessedOn != null &&
                    this.ProcessedOn.Equals(input.ProcessedOn))
                ) && 
                (
                    this.Processor == input.Processor ||
                    (this.Processor != null &&
                    this.Processor.Equals(input.Processor))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.FailureMessage != null)
                    hashCode = hashCode * 59 + this.FailureMessage.GetHashCode();
                if (this.FileGeneratedOn != null)
                    hashCode = hashCode * 59 + this.FileGeneratedOn.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProcessedOn != null)
                    hashCode = hashCode * 59 + this.ProcessedOn.GetHashCode();
                if (this.Processor != null)
                    hashCode = hashCode * 59 + this.Processor.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }

    }

}
