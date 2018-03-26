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
    /// Space Address
    /// </summary>
    [DataContract]
    public partial class SpaceAddressCreate :  IEquatable<SpaceAddressCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceAddressCreate" /> class.
        /// </summary>
        /// <param name="City">City</param>
        /// <param name="Country">Country</param>
        /// <param name="DependentLocality">DependentLocality</param>
        /// <param name="EmailAddress">The email address is used within emails and as reply to address.</param>
        /// <param name="FamilyName">FamilyName</param>
        /// <param name="GivenName">GivenName</param>
        /// <param name="OrganizationName">OrganizationName</param>
        /// <param name="PostCode">PostCode</param>
        /// <param name="PostalState">PostalState</param>
        /// <param name="SalesTaxNumber">SalesTaxNumber</param>
        /// <param name="Salutation">Salutation</param>
        /// <param name="SortingCode">The sorting code identifies the post office at which the post box is located in.</param>
        /// <param name="Street">Street</param>
        public SpaceAddressCreate(string Salutation = default(string), string PostCode = default(string), string Street = default(string), string GivenName = default(string), string FamilyName = default(string), string OrganizationName = default(string), string SortingCode = default(string), string City = default(string), string Country = default(string), string PostalState = default(string), string DependentLocality = default(string), string SalesTaxNumber = default(string), string EmailAddress = default(string))
        {
            this.City = City;
            this.Country = Country;
            this.DependentLocality = DependentLocality;
            this.EmailAddress = EmailAddress;
            this.FamilyName = FamilyName;
            this.GivenName = GivenName;
            this.OrganizationName = OrganizationName;
            this.PostCode = PostCode;
            this.PostalState = PostalState;
            this.SalesTaxNumber = SalesTaxNumber;
            this.Salutation = Salutation;
            this.SortingCode = SortingCode;
            this.Street = Street;
        }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        /// <value>Country</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// DependentLocality
        /// </summary>
        /// <value>DependentLocality</value>
        [DataMember(Name="dependentLocality", EmitDefaultValue=false)]
        public string DependentLocality { get; set; }

        /// <summary>
        /// The email address is used within emails and as reply to address.
        /// </summary>
        /// <value>The email address is used within emails and as reply to address.</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// FamilyName
        /// </summary>
        /// <value>FamilyName</value>
        [DataMember(Name="familyName", EmitDefaultValue=false)]
        public string FamilyName { get; set; }

        /// <summary>
        /// GivenName
        /// </summary>
        /// <value>GivenName</value>
        [DataMember(Name="givenName", EmitDefaultValue=false)]
        public string GivenName { get; set; }

        /// <summary>
        /// OrganizationName
        /// </summary>
        /// <value>OrganizationName</value>
        [DataMember(Name="organizationName", EmitDefaultValue=false)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// PostCode
        /// </summary>
        /// <value>PostCode</value>
        [DataMember(Name="postCode", EmitDefaultValue=false)]
        public string PostCode { get; set; }

        /// <summary>
        /// PostalState
        /// </summary>
        /// <value>PostalState</value>
        [DataMember(Name="postalState", EmitDefaultValue=false)]
        public string PostalState { get; set; }

        /// <summary>
        /// SalesTaxNumber
        /// </summary>
        /// <value>SalesTaxNumber</value>
        [DataMember(Name="salesTaxNumber", EmitDefaultValue=false)]
        public string SalesTaxNumber { get; set; }

        /// <summary>
        /// Salutation
        /// </summary>
        /// <value>Salutation</value>
        [DataMember(Name="salutation", EmitDefaultValue=false)]
        public string Salutation { get; set; }

        /// <summary>
        /// The sorting code identifies the post office at which the post box is located in.
        /// </summary>
        /// <value>The sorting code identifies the post office at which the post box is located in.</value>
        [DataMember(Name="sortingCode", EmitDefaultValue=false)]
        public string SortingCode { get; set; }

        /// <summary>
        /// Street
        /// </summary>
        /// <value>Street</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }

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
            return this.Equals(obj as SpaceAddressCreate);
        }

        /// <summary>
        /// Returns true if SpaceAddressCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of SpaceAddressCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpaceAddressCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.DependentLocality == other.DependentLocality ||
                    this.DependentLocality != null &&
                    this.DependentLocality.Equals(other.DependentLocality)
                ) && 
                (
                    this.EmailAddress == other.EmailAddress ||
                    this.EmailAddress != null &&
                    this.EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    this.FamilyName == other.FamilyName ||
                    this.FamilyName != null &&
                    this.FamilyName.Equals(other.FamilyName)
                ) && 
                (
                    this.GivenName == other.GivenName ||
                    this.GivenName != null &&
                    this.GivenName.Equals(other.GivenName)
                ) && 
                (
                    this.OrganizationName == other.OrganizationName ||
                    this.OrganizationName != null &&
                    this.OrganizationName.Equals(other.OrganizationName)
                ) && 
                (
                    this.PostCode == other.PostCode ||
                    this.PostCode != null &&
                    this.PostCode.Equals(other.PostCode)
                ) && 
                (
                    this.PostalState == other.PostalState ||
                    this.PostalState != null &&
                    this.PostalState.Equals(other.PostalState)
                ) && 
                (
                    this.SalesTaxNumber == other.SalesTaxNumber ||
                    this.SalesTaxNumber != null &&
                    this.SalesTaxNumber.Equals(other.SalesTaxNumber)
                ) && 
                (
                    this.Salutation == other.Salutation ||
                    this.Salutation != null &&
                    this.Salutation.Equals(other.Salutation)
                ) && 
                (
                    this.SortingCode == other.SortingCode ||
                    this.SortingCode != null &&
                    this.SortingCode.Equals(other.SortingCode)
                ) && 
                (
                    this.Street == other.Street ||
                    this.Street != null &&
                    this.Street.Equals(other.Street)
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
                if (this.City != null)
                {
                    hash = hash * 59 + this.City.GetHashCode();
                }
                if (this.Country != null)
                {
                    hash = hash * 59 + this.Country.GetHashCode();
                }
                if (this.DependentLocality != null)
                {
                    hash = hash * 59 + this.DependentLocality.GetHashCode();
                }
                if (this.EmailAddress != null)
                {
                    hash = hash * 59 + this.EmailAddress.GetHashCode();
                }
                if (this.FamilyName != null)
                {
                    hash = hash * 59 + this.FamilyName.GetHashCode();
                }
                if (this.GivenName != null)
                {
                    hash = hash * 59 + this.GivenName.GetHashCode();
                }
                if (this.OrganizationName != null)
                {
                    hash = hash * 59 + this.OrganizationName.GetHashCode();
                }
                if (this.PostCode != null)
                {
                    hash = hash * 59 + this.PostCode.GetHashCode();
                }
                if (this.PostalState != null)
                {
                    hash = hash * 59 + this.PostalState.GetHashCode();
                }
                if (this.SalesTaxNumber != null)
                {
                    hash = hash * 59 + this.SalesTaxNumber.GetHashCode();
                }
                if (this.Salutation != null)
                {
                    hash = hash * 59 + this.Salutation.GetHashCode();
                }
                if (this.SortingCode != null)
                {
                    hash = hash * 59 + this.SortingCode.GetHashCode();
                }
                if (this.Street != null)
                {
                    hash = hash * 59 + this.Street.GetHashCode();
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
