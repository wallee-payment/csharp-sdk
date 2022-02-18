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
    /// Meta information about a column within a table.
    /// </summary>
    [DataContract]
    public partial class AnalyticsSchemaColumn :  IEquatable<AnalyticsSchemaColumn>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsSchemaColumn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AnalyticsSchemaColumn()
        {
        }

        /// <summary>
        /// The name of the alias defined for the column in the query or null if none is defined.
        /// </summary>
        /// <value>The name of the alias defined for the column in the query or null if none is defined.</value>
        [DataMember(Name="aliasName", EmitDefaultValue=false)]
        public string AliasName { get; private set; }

        /// <summary>
        /// The name of the column in the table or null if this is a synthetic column which is the result of some SQL expression.
        /// </summary>
        /// <value>The name of the column in the table or null if this is a synthetic column which is the result of some SQL expression.</value>
        [DataMember(Name="columnName", EmitDefaultValue=false)]
        public string ColumnName { get; private set; }

        /// <summary>
        /// A human readable description of the property contained in this column or null if this is a synthetic column which is the result of some SQL expression.
        /// </summary>
        /// <value>A human readable description of the property contained in this column or null if this is a synthetic column which is the result of some SQL expression.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// The precision (maximal number of digits) for decimal data types, otherwise 0.
        /// </summary>
        /// <value>The precision (maximal number of digits) for decimal data types, otherwise 0.</value>
        [DataMember(Name="precision", EmitDefaultValue=false)]
        public int? Precision { get; private set; }

        /// <summary>
        /// The name of the referenced table if this column represents a foreign-key relation to the IDs of another table, otherwise null.
        /// </summary>
        /// <value>The name of the referenced table if this column represents a foreign-key relation to the IDs of another table, otherwise null.</value>
        [DataMember(Name="referencedTable", EmitDefaultValue=false)]
        public string ReferencedTable { get; private set; }

        /// <summary>
        /// The scale (maximal number number of digits in the fractional part) in case of a decimal data type, otherwise 0.
        /// </summary>
        /// <value>The scale (maximal number number of digits in the fractional part) in case of a decimal data type, otherwise 0.</value>
        [DataMember(Name="scale", EmitDefaultValue=false)]
        public int? Scale { get; private set; }

        /// <summary>
        /// The name of the table which defines this column.
        /// </summary>
        /// <value>The name of the table which defines this column.</value>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; private set; }

        /// <summary>
        /// The ORC data type of the column value.
        /// </summary>
        /// <value>The ORC data type of the column value.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsSchemaColumn {\n");
            sb.Append("  AliasName: ").Append(AliasName).Append("\n");
            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Precision: ").Append(Precision).Append("\n");
            sb.Append("  ReferencedTable: ").Append(ReferencedTable).Append("\n");
            sb.Append("  Scale: ").Append(Scale).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as AnalyticsSchemaColumn);
        }

        /// <summary>
        /// Returns true if AnalyticsSchemaColumn instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsSchemaColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsSchemaColumn input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AliasName == input.AliasName ||
                    (this.AliasName != null &&
                    this.AliasName.Equals(input.AliasName))
                ) && 
                (
                    this.ColumnName == input.ColumnName ||
                    (this.ColumnName != null &&
                    this.ColumnName.Equals(input.ColumnName))
                ) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.Precision == input.Precision ||
                    (this.Precision != null &&
                    this.Precision.Equals(input.Precision))
                ) && 
                (
                    this.ReferencedTable == input.ReferencedTable ||
                    (this.ReferencedTable != null &&
                    this.ReferencedTable.Equals(input.ReferencedTable))
                ) && 
                (
                    this.Scale == input.Scale ||
                    (this.Scale != null &&
                    this.Scale.Equals(input.Scale))
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.AliasName != null)
                    hashCode = hashCode * 59 + this.AliasName.GetHashCode();
                if (this.ColumnName != null)
                    hashCode = hashCode * 59 + this.ColumnName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Precision != null)
                    hashCode = hashCode * 59 + this.Precision.GetHashCode();
                if (this.ReferencedTable != null)
                    hashCode = hashCode * 59 + this.ReferencedTable.GetHashCode();
                if (this.Scale != null)
                    hashCode = hashCode * 59 + this.Scale.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}
