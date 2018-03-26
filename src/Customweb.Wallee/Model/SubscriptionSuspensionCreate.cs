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
    /// Suspension
    /// </summary>
    [DataContract]
    public partial class SubscriptionSuspensionCreate :  IEquatable<SubscriptionSuspensionCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionSuspensionCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionSuspensionCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionSuspensionCreate" /> class.
        /// </summary>
        /// <param name="EndAction">When the suspension reaches the planned end date the end action will be carried out. This action is only executed when the suspension is ended automatically based on the end date. (required)</param>
        /// <param name="Note">The note may contain some internal information for the suspension. The note will not be disclosed to the subscriber.</param>
        /// <param name="PlannedEndDate">The planned end date of the suspension identifies the date on which the suspension will be ended automatically. (required)</param>
        /// <param name="Subscription">Subscription (required)</param>
        public SubscriptionSuspensionCreate(SubscriptionSuspensionAction? EndAction = default(SubscriptionSuspensionAction?), string Note = default(string), long? Subscription = default(long?), DateTime? PlannedEndDate = default(DateTime?))
        {
            // to ensure "EndAction" is required (not null)
            if (EndAction == null)
            {
                throw new ArgumentNullException("EndAction is a required property for SubscriptionSuspensionCreate and cannot be null");
            }
            else
            {
                this.EndAction = EndAction;
            }
            // to ensure "PlannedEndDate" is required (not null)
            if (PlannedEndDate == null)
            {
                throw new ArgumentNullException("PlannedEndDate is a required property for SubscriptionSuspensionCreate and cannot be null");
            }
            else
            {
                this.PlannedEndDate = PlannedEndDate;
            }
            // to ensure "Subscription" is required (not null)
            if (Subscription == null)
            {
                throw new ArgumentNullException("Subscription is a required property for SubscriptionSuspensionCreate and cannot be null");
            }
            else
            {
                this.Subscription = Subscription;
            }
            this.Note = Note;
        }

        /// <summary>
        /// When the suspension reaches the planned end date the end action will be carried out. This action is only executed when the suspension is ended automatically based on the end date.
        /// </summary>
        /// <value>When the suspension reaches the planned end date the end action will be carried out. This action is only executed when the suspension is ended automatically based on the end date.</value>
        [DataMember(Name="endAction", EmitDefaultValue=false)]
        public SubscriptionSuspensionAction? EndAction { get; set; }

        /// <summary>
        /// The note may contain some internal information for the suspension. The note will not be disclosed to the subscriber.
        /// </summary>
        /// <value>The note may contain some internal information for the suspension. The note will not be disclosed to the subscriber.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// The planned end date of the suspension identifies the date on which the suspension will be ended automatically.
        /// </summary>
        /// <value>The planned end date of the suspension identifies the date on which the suspension will be ended automatically.</value>
        [DataMember(Name="plannedEndDate", EmitDefaultValue=false)]
        public DateTime? PlannedEndDate { get; set; }

        /// <summary>
        /// Subscription
        /// </summary>
        /// <value>Subscription</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public long? Subscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
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
            return this.Equals(obj as SubscriptionSuspensionCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionSuspensionCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionSuspensionCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionSuspensionCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.EndAction == other.EndAction ||
                    this.EndAction != null &&
                    this.EndAction.Equals(other.EndAction)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.PlannedEndDate == other.PlannedEndDate ||
                    this.PlannedEndDate != null &&
                    this.PlannedEndDate.Equals(other.PlannedEndDate)
                ) && 
                (
                    this.Subscription == other.Subscription ||
                    this.Subscription != null &&
                    this.Subscription.Equals(other.Subscription)
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
                if (this.EndAction != null)
                {
                    hash = hash * 59 + this.EndAction.GetHashCode();
                }
                if (this.Note != null)
                {
                    hash = hash * 59 + this.Note.GetHashCode();
                }
                if (this.PlannedEndDate != null)
                {
                    hash = hash * 59 + this.PlannedEndDate.GetHashCode();
                }
                if (this.Subscription != null)
                {
                    hash = hash * 59 + this.Subscription.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
