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
    /// The schema of a single table in Analytics.
    /// </summary>
    [DataContract]
    public partial class AnalyticsSchemaTable :  IEquatable<AnalyticsSchemaTable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsSchemaTable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AnalyticsSchemaTable()
        {
        }

        /// <summary>
        /// The schemas of all columns of this table.
        /// </summary>
        /// <value>The schemas of all columns of this table.</value>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<AnalyticsSchemaColumn> Columns { get; private set; }

        /// <summary>
        /// A human readable description of the entity type contained in this table.
        /// </summary>
        /// <value>A human readable description of the entity type contained in this table.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// The name of this table.
        /// </summary>
        /// <value>The name of this table.</value>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsSchemaTable {\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
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
            return this.Equals(input as AnalyticsSchemaTable);
        }

        /// <summary>
        /// Returns true if AnalyticsSchemaTable instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsSchemaTable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsSchemaTable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Columns == input.Columns ||
                    this.Columns != null &&
                    input.Columns != null &&
                    this.Columns.SequenceEqual(input.Columns)
                ) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
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
                if (this.Columns != null)
                    hashCode = hashCode * 59 + this.Columns.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                return hashCode;
            }
        }

    }

}
