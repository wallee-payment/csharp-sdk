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
    /// SubscriptionSuspensionCreate
    /// </summary>
    [DataContract]
    public partial class SubscriptionSuspensionCreate :  IEquatable<SubscriptionSuspensionCreate>
    {
        /// <summary>
        /// When the suspension reaches the planned end date the end action will be carried out. This action is only executed when the suspension is ended automatically based on the end date.
        /// </summary>
        /// <value>When the suspension reaches the planned end date the end action will be carried out. This action is only executed when the suspension is ended automatically based on the end date.</value>
        [DataMember(Name="endAction", EmitDefaultValue=true)]
        public SubscriptionSuspensionAction EndAction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionSuspensionCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionSuspensionCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionSuspensionCreate" /> class.
        /// </summary>
        /// <param name="endAction">When the suspension reaches the planned end date the end action will be carried out. This action is only executed when the suspension is ended automatically based on the end date. (required).</param>
        /// <param name="plannedEndDate">The planned end date of the suspension identifies the date on which the suspension will be ended automatically. (required).</param>
        /// <param name="subscription">subscription (required).</param>
        public SubscriptionSuspensionCreate(SubscriptionSuspensionAction endAction, DateTime? plannedEndDate, long? subscription)
        {
            // to ensure "endAction" is required (not null)
            if (endAction == null)
            {
                throw new InvalidDataException("endAction is a required property for SubscriptionSuspensionCreate and cannot be null");
            }
            this.EndAction = endAction;
            // to ensure "plannedEndDate" is required (not null)
            if (plannedEndDate == null)
            {
                throw new InvalidDataException("plannedEndDate is a required property for SubscriptionSuspensionCreate and cannot be null");
            }
            this.PlannedEndDate = plannedEndDate;
            // to ensure "subscription" is required (not null)
            if (subscription == null)
            {
                throw new InvalidDataException("subscription is a required property for SubscriptionSuspensionCreate and cannot be null");
            }
            this.Subscription = subscription;
        }


        /// <summary>
        /// The note may contain some internal information for the suspension. The note will not be disclosed to the subscriber.
        /// </summary>
        /// <value>The note may contain some internal information for the suspension. The note will not be disclosed to the subscriber.</value>
        [DataMember(Name="note", EmitDefaultValue=true)]
        public string Note { get; set; }

        /// <summary>
        /// The planned end date of the suspension identifies the date on which the suspension will be ended automatically.
        /// </summary>
        /// <value>The planned end date of the suspension identifies the date on which the suspension will be ended automatically.</value>
        [DataMember(Name="plannedEndDate", EmitDefaultValue=true)]
        public DateTime? PlannedEndDate { get; set; }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name="subscription", EmitDefaultValue=true)]
        public long? Subscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionSuspensionCreate {\n");
            sb.Append("  EndAction: ").Append(EndAction).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  PlannedEndDate: ").Append(PlannedEndDate).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
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
            return this.Equals(input as SubscriptionSuspensionCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionSuspensionCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionSuspensionCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionSuspensionCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndAction == input.EndAction ||
                    (this.EndAction != null &&
                    this.EndAction.Equals(input.EndAction))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.PlannedEndDate == input.PlannedEndDate ||
                    (this.PlannedEndDate != null &&
                    this.PlannedEndDate.Equals(input.PlannedEndDate))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
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
                if (this.EndAction != null)
                    hashCode = hashCode * 59 + this.EndAction.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.PlannedEndDate != null)
                    hashCode = hashCode * 59 + this.PlannedEndDate.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                return hashCode;
            }
        }

    }

}
