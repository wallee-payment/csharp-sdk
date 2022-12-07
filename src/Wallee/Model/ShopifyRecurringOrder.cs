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
    /// ShopifyRecurringOrder
    /// </summary>
    [DataContract]
    public partial class ShopifyRecurringOrder : TransactionAwareEntity,  IEquatable<ShopifyRecurringOrder>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public ShopifyRecurringOrderState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifyRecurringOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ShopifyRecurringOrder()
        {
        }




        /// <summary>
        /// Gets or Sets BilledOn
        /// </summary>
        [DataMember(Name="billedOn", EmitDefaultValue=false)]
        public DateTime? BilledOn { get; private set; }

        /// <summary>
        /// Gets or Sets CheckoutToken
        /// </summary>
        [DataMember(Name="checkoutToken", EmitDefaultValue=false)]
        public string CheckoutToken { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// Gets or Sets FailureReason
        /// </summary>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReason FailureReason { get; private set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public string OrderId { get; private set; }

        /// <summary>
        /// Gets or Sets OrderName
        /// </summary>
        [DataMember(Name="orderName", EmitDefaultValue=false)]
        public string OrderName { get; private set; }

        /// <summary>
        /// Gets or Sets PlannedExecutionDate
        /// </summary>
        [DataMember(Name="plannedExecutionDate", EmitDefaultValue=false)]
        public DateTime? PlannedExecutionDate { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Gets or Sets RecurrenceNumber
        /// </summary>
        [DataMember(Name="recurrenceNumber", EmitDefaultValue=false)]
        public int? RecurrenceNumber { get; private set; }

        /// <summary>
        /// Gets or Sets Shop
        /// </summary>
        [DataMember(Name="shop", EmitDefaultValue=false)]
        public long? Shop { get; private set; }

        /// <summary>
        /// Gets or Sets StartedProcessingOn
        /// </summary>
        [DataMember(Name="startedProcessingOn", EmitDefaultValue=false)]
        public DateTime? StartedProcessingOn { get; private set; }


        /// <summary>
        /// Gets or Sets SubscriptionVersion
        /// </summary>
        [DataMember(Name="subscriptionVersion", EmitDefaultValue=false)]
        public ShopifySubscriptionVersion SubscriptionVersion { get; private set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public ShopifyTransaction Transaction { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShopifyRecurringOrder {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  BilledOn: ").Append(BilledOn).Append("\n");
            sb.Append("  CheckoutToken: ").Append(CheckoutToken).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OrderName: ").Append(OrderName).Append("\n");
            sb.Append("  PlannedExecutionDate: ").Append(PlannedExecutionDate).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  RecurrenceNumber: ").Append(RecurrenceNumber).Append("\n");
            sb.Append("  Shop: ").Append(Shop).Append("\n");
            sb.Append("  StartedProcessingOn: ").Append(StartedProcessingOn).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SubscriptionVersion: ").Append(SubscriptionVersion).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ShopifyRecurringOrder);
        }

        /// <summary>
        /// Returns true if ShopifyRecurringOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifyRecurringOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifyRecurringOrder input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && base.Equals(input) && 
                (
                    this.LinkedTransaction == input.LinkedTransaction ||
                    (this.LinkedTransaction != null &&
                    this.LinkedTransaction.Equals(input.LinkedTransaction))
                ) && base.Equals(input) && 
                (
                    this.BilledOn == input.BilledOn ||
                    (this.BilledOn != null &&
                    this.BilledOn.Equals(input.BilledOn))
                ) && base.Equals(input) && 
                (
                    this.CheckoutToken == input.CheckoutToken ||
                    (this.CheckoutToken != null &&
                    this.CheckoutToken.Equals(input.CheckoutToken))
                ) && base.Equals(input) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && base.Equals(input) && 
                (
                    this.FailureReason == input.FailureReason ||
                    (this.FailureReason != null &&
                    this.FailureReason.Equals(input.FailureReason))
                ) && base.Equals(input) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && base.Equals(input) && 
                (
                    this.OrderName == input.OrderName ||
                    (this.OrderName != null &&
                    this.OrderName.Equals(input.OrderName))
                ) && base.Equals(input) && 
                (
                    this.PlannedExecutionDate == input.PlannedExecutionDate ||
                    (this.PlannedExecutionDate != null &&
                    this.PlannedExecutionDate.Equals(input.PlannedExecutionDate))
                ) && base.Equals(input) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && base.Equals(input) && 
                (
                    this.RecurrenceNumber == input.RecurrenceNumber ||
                    (this.RecurrenceNumber != null &&
                    this.RecurrenceNumber.Equals(input.RecurrenceNumber))
                ) && base.Equals(input) && 
                (
                    this.Shop == input.Shop ||
                    (this.Shop != null &&
                    this.Shop.Equals(input.Shop))
                ) && base.Equals(input) && 
                (
                    this.StartedProcessingOn == input.StartedProcessingOn ||
                    (this.StartedProcessingOn != null &&
                    this.StartedProcessingOn.Equals(input.StartedProcessingOn))
                ) && base.Equals(input) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && base.Equals(input) && 
                (
                    this.SubscriptionVersion == input.SubscriptionVersion ||
                    (this.SubscriptionVersion != null &&
                    this.SubscriptionVersion.Equals(input.SubscriptionVersion))
                ) && base.Equals(input) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
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
                int hashCode = base.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LinkedTransaction != null)
                    hashCode = hashCode * 59 + this.LinkedTransaction.GetHashCode();
                if (this.BilledOn != null)
                    hashCode = hashCode * 59 + this.BilledOn.GetHashCode();
                if (this.CheckoutToken != null)
                    hashCode = hashCode * 59 + this.CheckoutToken.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.FailureReason != null)
                    hashCode = hashCode * 59 + this.FailureReason.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.OrderName != null)
                    hashCode = hashCode * 59 + this.OrderName.GetHashCode();
                if (this.PlannedExecutionDate != null)
                    hashCode = hashCode * 59 + this.PlannedExecutionDate.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.RecurrenceNumber != null)
                    hashCode = hashCode * 59 + this.RecurrenceNumber.GetHashCode();
                if (this.Shop != null)
                    hashCode = hashCode * 59 + this.Shop.GetHashCode();
                if (this.StartedProcessingOn != null)
                    hashCode = hashCode * 59 + this.StartedProcessingOn.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SubscriptionVersion != null)
                    hashCode = hashCode * 59 + this.SubscriptionVersion.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                return hashCode;
            }
        }

    }

}
