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
    /// A batch of the result of a query executed in Analytics.
    /// </summary>
    [DataContract]
    public partial class AnalyticsQueryResultBatch :  IEquatable<AnalyticsQueryResultBatch>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryResultBatch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AnalyticsQueryResultBatch()
        {
        }

        /// <summary>
        /// The schemas of the columns returned by the query (in order). Will be null if the results of the query are not (yet) available.
        /// </summary>
        /// <value>The schemas of the columns returned by the query (in order). Will be null if the results of the query are not (yet) available.</value>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<AnalyticsSchemaColumn> Columns { get; private set; }

        /// <summary>
        /// The token to be provided to fetch the next batch of results. May be null if no more result batches are available.
        /// </summary>
        /// <value>The token to be provided to fetch the next batch of results. May be null if no more result batches are available.</value>
        [DataMember(Name="nextToken", EmitDefaultValue=false)]
        public string NextToken { get; private set; }

        /// <summary>
        /// The query execution which produced the result.
        /// </summary>
        /// <value>The query execution which produced the result.</value>
        [DataMember(Name="queryExecution", EmitDefaultValue=false)]
        public AnalyticsQueryExecution QueryExecution { get; private set; }

        /// <summary>
        /// The rows of the result set contained in this batch where each row is a list of column values (in order of the columns specified in the query). Will be null if the results of the query are not (yet) available.
        /// </summary>
        /// <value>The rows of the result set contained in this batch where each row is a list of column values (in order of the columns specified in the query). Will be null if the results of the query are not (yet) available.</value>
        [DataMember(Name="rows", EmitDefaultValue=false)]
        public List<List<string>> Rows { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsQueryResultBatch {\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
            sb.Append("  QueryExecution: ").Append(QueryExecution).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
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
            return this.Equals(input as AnalyticsQueryResultBatch);
        }

        /// <summary>
        /// Returns true if AnalyticsQueryResultBatch instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsQueryResultBatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsQueryResultBatch input)
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
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
                ) && 
                (
                    this.QueryExecution == input.QueryExecution ||
                    (this.QueryExecution != null &&
                    this.QueryExecution.Equals(input.QueryExecution))
                ) && 
                (
                    this.Rows == input.Rows ||
                    this.Rows != null &&
                    input.Rows != null &&
                    this.Rows.SequenceEqual(input.Rows)
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
                if (this.NextToken != null)
                    hashCode = hashCode * 59 + this.NextToken.GetHashCode();
                if (this.QueryExecution != null)
                    hashCode = hashCode * 59 + this.QueryExecution.GetHashCode();
                if (this.Rows != null)
                    hashCode = hashCode * 59 + this.Rows.GetHashCode();
                return hashCode;
            }
        }

    }

}
