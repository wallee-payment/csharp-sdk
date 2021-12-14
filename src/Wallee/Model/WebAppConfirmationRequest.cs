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
    /// WebAppConfirmationRequest
    /// </summary>
    [DataContract]
    public partial class WebAppConfirmationRequest :  IEquatable<WebAppConfirmationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebAppConfirmationRequest" /> class.
        /// </summary>
        public WebAppConfirmationRequest()
        {
        }

        /// <summary>
        /// The user returns to the web app after granting the permission. The HTTP request contains the code. Provide it here to confirm the web app installation.
        /// </summary>
        /// <value>The user returns to the web app after granting the permission. The HTTP request contains the code. Provide it here to confirm the web app installation.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebAppConfirmationRequest {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as WebAppConfirmationRequest);
        }

        /// <summary>
        /// Returns true if WebAppConfirmationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WebAppConfirmationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebAppConfirmationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                return hashCode;
            }
        }

    }

}
