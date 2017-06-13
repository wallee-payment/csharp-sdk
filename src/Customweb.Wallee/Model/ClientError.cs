
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
    /// An error that is returned as the result of a bad user request or a misconfiguration.
    /// </summary>
    [DataContract]
    public partial class ClientError :  IEquatable<ClientError>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientError" /> class.
        /// </summary>
        /// <param name="Date">Date when an error has occurred.</param>
        /// <param name="DefaultMessage">The error message which is translated into the default language (i.e. English).</param>
        /// <param name="Id">Unique identifier of an error.</param>
        /// <param name="Message">The error message which is translated in into the language of the client.</param>
        /// <param name="Type">The type of the client error.</param>
        public ClientError(string Date = default(string), string DefaultMessage = default(string), string Id = default(string), string Message = default(string), ClientErrorType Type = default(ClientErrorType))
        {
            this.Date = Date;
            this.DefaultMessage = DefaultMessage;
            this.Id = Id;
            this.Message = Message;
            this.Type = Type;
        }

        /// <summary>
        /// Date when an error has occurred.
        /// </summary>
        /// <value>Date when an error has occurred.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// The error message which is translated into the default language (i.e. English).
        /// </summary>
        /// <value>The error message which is translated into the default language (i.e. English).</value>
        [DataMember(Name="defaultMessage", EmitDefaultValue=false)]
        public string DefaultMessage { get; set; }

        /// <summary>
        /// Unique identifier of an error.
        /// </summary>
        /// <value>Unique identifier of an error.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The error message which is translated in into the language of the client.
        /// </summary>
        /// <value>The error message which is translated in into the language of the client.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// The type of the client error.
        /// </summary>
        /// <value>The type of the client error.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public ClientErrorType Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientError {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DefaultMessage: ").Append(DefaultMessage).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as ClientError);
        }

        /// <summary>
        /// Returns true if ClientError instances are equal
        /// </summary>
        /// <param name="other">Instance of ClientError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientError other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.DefaultMessage == other.DefaultMessage ||
                    this.DefaultMessage != null &&
                    this.DefaultMessage.Equals(other.DefaultMessage)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.DefaultMessage != null)
                    hash = hash * 59 + this.DefaultMessage.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

    }

}
