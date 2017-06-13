
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
    /// The entity query allows to search for specific entities by providing filters. This is similar to a SQL query.
    /// </summary>
    [DataContract]
    public partial class EntityQuery :  IEquatable<EntityQuery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityQuery" /> class.
        /// </summary>
        /// <param name="Filter">The filter node defines the root filter node of the query. The root node may contain multiple sub nodes with different filters in it.</param>
        /// <param name="Language">The language is applied to the ordering of the entities returned. Some entity fields are language dependent and hence the language is required to order them.</param>
        /// <param name="NumberOfEntities">The number of entities defines how many entities should be returned. There is a maximum of 500 entities.</param>
        /// <param name="OrderBys">The order bys allows to define the ordering of the entities returned by the search.</param>
        /// <param name="StartingEntity">The &#39;starting entity&#39; defines the entity number at which the returned result should start. The entity number is the consecutive number of the entity as returned and it is not the entity id.</param>
        public EntityQuery(EntityQueryFilter Filter = default(EntityQueryFilter), string Language = default(string), int? NumberOfEntities = default(int?), List<EntityQueryOrderBy> OrderBys = default(List<EntityQueryOrderBy>), int? StartingEntity = default(int?))
        {
            this.Filter = Filter;
            this.Language = Language;
            this.NumberOfEntities = NumberOfEntities;
            this.OrderBys = OrderBys;
            this.StartingEntity = StartingEntity;
        }

        /// <summary>
        /// The filter node defines the root filter node of the query. The root node may contain multiple sub nodes with different filters in it.
        /// </summary>
        /// <value>The filter node defines the root filter node of the query. The root node may contain multiple sub nodes with different filters in it.</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public EntityQueryFilter Filter { get; set; }

        /// <summary>
        /// The language is applied to the ordering of the entities returned. Some entity fields are language dependent and hence the language is required to order them.
        /// </summary>
        /// <value>The language is applied to the ordering of the entities returned. Some entity fields are language dependent and hence the language is required to order them.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The number of entities defines how many entities should be returned. There is a maximum of 500 entities.
        /// </summary>
        /// <value>The number of entities defines how many entities should be returned. There is a maximum of 500 entities.</value>
        [DataMember(Name="numberOfEntities", EmitDefaultValue=false)]
        public int? NumberOfEntities { get; set; }

        /// <summary>
        /// The order bys allows to define the ordering of the entities returned by the search.
        /// </summary>
        /// <value>The order bys allows to define the ordering of the entities returned by the search.</value>
        [DataMember(Name="orderBys", EmitDefaultValue=false)]
        public List<EntityQueryOrderBy> OrderBys { get; set; }

        /// <summary>
        /// The &#39;starting entity&#39; defines the entity number at which the returned result should start. The entity number is the consecutive number of the entity as returned and it is not the entity id.
        /// </summary>
        /// <value>The &#39;starting entity&#39; defines the entity number at which the returned result should start. The entity number is the consecutive number of the entity as returned and it is not the entity id.</value>
        [DataMember(Name="startingEntity", EmitDefaultValue=false)]
        public int? StartingEntity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityQuery {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  NumberOfEntities: ").Append(NumberOfEntities).Append("\n");
            sb.Append("  OrderBys: ").Append(OrderBys).Append("\n");
            sb.Append("  StartingEntity: ").Append(StartingEntity).Append("\n");
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
            return this.Equals(obj as EntityQuery);
        }

        /// <summary>
        /// Returns true if EntityQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of EntityQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityQuery other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.NumberOfEntities == other.NumberOfEntities ||
                    this.NumberOfEntities != null &&
                    this.NumberOfEntities.Equals(other.NumberOfEntities)
                ) && 
                (
                    this.OrderBys == other.OrderBys ||
                    this.OrderBys != null &&
                    this.OrderBys.SequenceEqual(other.OrderBys)
                ) && 
                (
                    this.StartingEntity == other.StartingEntity ||
                    this.StartingEntity != null &&
                    this.StartingEntity.Equals(other.StartingEntity)
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
                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.NumberOfEntities != null)
                    hash = hash * 59 + this.NumberOfEntities.GetHashCode();
                if (this.OrderBys != null)
                    hash = hash * 59 + this.OrderBys.GetHashCode();
                if (this.StartingEntity != null)
                    hash = hash * 59 + this.StartingEntity.GetHashCode();
                return hash;
            }
        }

    }

}
