/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
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
    /// Address in Create State
    /// </summary>
    [DataContract]
    public partial class AddressCreate :  IEquatable<AddressCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressCreate" /> class.
        /// </summary>
        /// <param name="City">City</param>
        /// <param name="CommercialRegisterNumber">CommercialRegisterNumber</param>
        /// <param name="Country">Country</param>
        /// <param name="DateOfBirth">DateOfBirth</param>
        /// <param name="DependentLocality">DependentLocality</param>
        /// <param name="EmailAddress">EmailAddress</param>
        /// <param name="FamilyName">FamilyName</param>
        /// <param name="Gender">Gender</param>
        /// <param name="GivenName">GivenName</param>
        /// <param name="LegalOrganizationForm">LegalOrganizationForm</param>
        /// <param name="MobilePhoneNumber">MobilePhoneNumber</param>
        /// <param name="OrganizationName">OrganizationName</param>
        /// <param name="PhoneNumber">PhoneNumber</param>
        /// <param name="PostCode">PostCode</param>
        /// <param name="PostalState">PostalState</param>
        /// <param name="SalesTaxNumber">SalesTaxNumber</param>
        /// <param name="Salutation">Salutation</param>
        /// <param name="SocialSecurityNumber">SocialSecurityNumber</param>
        /// <param name="SortingCode">The sorting code identifies the post office at which the post box is located in.</param>
        /// <param name="Street">Street</param>
        public AddressCreate(string Salutation = default(string), string PostCode = default(string), string Street = default(string), string GivenName = default(string), string FamilyName = default(string), DateTime? DateOfBirth = default(DateTime?), string MobilePhoneNumber = default(string), Gender? Gender = default(Gender?), long? LegalOrganizationForm = default(long?), string OrganizationName = default(string), string SortingCode = default(string), string City = default(string), string PhoneNumber = default(string), string Country = default(string), string PostalState = default(string), string CommercialRegisterNumber = default(string), string DependentLocality = default(string), string SalesTaxNumber = default(string), string EmailAddress = default(string), string SocialSecurityNumber = default(string))
        {
            this.City = City;
            this.CommercialRegisterNumber = CommercialRegisterNumber;
            this.Country = Country;
            this.DateOfBirth = DateOfBirth;
            this.DependentLocality = DependentLocality;
            this.EmailAddress = EmailAddress;
            this.FamilyName = FamilyName;
            this.Gender = Gender;
            this.GivenName = GivenName;
            this.LegalOrganizationForm = LegalOrganizationForm;
            this.MobilePhoneNumber = MobilePhoneNumber;
            this.OrganizationName = OrganizationName;
            this.PhoneNumber = PhoneNumber;
            this.PostCode = PostCode;
            this.PostalState = PostalState;
            this.SalesTaxNumber = SalesTaxNumber;
            this.Salutation = Salutation;
            this.SocialSecurityNumber = SocialSecurityNumber;
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
        /// CommercialRegisterNumber
        /// </summary>
        /// <value>CommercialRegisterNumber</value>
        [DataMember(Name="commercialRegisterNumber", EmitDefaultValue=false)]
        public string CommercialRegisterNumber { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        /// <value>Country</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// DateOfBirth
        /// </summary>
        /// <value>DateOfBirth</value>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// DependentLocality
        /// </summary>
        /// <value>DependentLocality</value>
        [DataMember(Name="dependentLocality", EmitDefaultValue=false)]
        public string DependentLocality { get; set; }

        /// <summary>
        /// EmailAddress
        /// </summary>
        /// <value>EmailAddress</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// FamilyName
        /// </summary>
        /// <value>FamilyName</value>
        [DataMember(Name="familyName", EmitDefaultValue=false)]
        public string FamilyName { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        /// <value>Gender</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public Gender? Gender { get; set; }

        /// <summary>
        /// GivenName
        /// </summary>
        /// <value>GivenName</value>
        [DataMember(Name="givenName", EmitDefaultValue=false)]
        public string GivenName { get; set; }

        /// <summary>
        /// LegalOrganizationForm
        /// </summary>
        /// <value>LegalOrganizationForm</value>
        [DataMember(Name="legalOrganizationForm", EmitDefaultValue=false)]
        public long? LegalOrganizationForm { get; set; }

        /// <summary>
        /// MobilePhoneNumber
        /// </summary>
        /// <value>MobilePhoneNumber</value>
        [DataMember(Name="mobilePhoneNumber", EmitDefaultValue=false)]
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// OrganizationName
        /// </summary>
        /// <value>OrganizationName</value>
        [DataMember(Name="organizationName", EmitDefaultValue=false)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// PhoneNumber
        /// </summary>
        /// <value>PhoneNumber</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

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
        /// SocialSecurityNumber
        /// </summary>
        /// <value>SocialSecurityNumber</value>
        [DataMember(Name="socialSecurityNumber", EmitDefaultValue=false)]
        public string SocialSecurityNumber { get; set; }

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
            return this.Equals(obj as AddressCreate);
        }

        /// <summary>
        /// Returns true if AddressCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of AddressCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressCreate other)
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
                    this.CommercialRegisterNumber == other.CommercialRegisterNumber ||
                    this.CommercialRegisterNumber != null &&
                    this.CommercialRegisterNumber.Equals(other.CommercialRegisterNumber)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.DateOfBirth == other.DateOfBirth ||
                    this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(other.DateOfBirth)
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
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) && 
                (
                    this.GivenName == other.GivenName ||
                    this.GivenName != null &&
                    this.GivenName.Equals(other.GivenName)
                ) && 
                (
                    this.LegalOrganizationForm == other.LegalOrganizationForm ||
                    this.LegalOrganizationForm != null &&
                    this.LegalOrganizationForm.Equals(other.LegalOrganizationForm)
                ) && 
                (
                    this.MobilePhoneNumber == other.MobilePhoneNumber ||
                    this.MobilePhoneNumber != null &&
                    this.MobilePhoneNumber.Equals(other.MobilePhoneNumber)
                ) && 
                (
                    this.OrganizationName == other.OrganizationName ||
                    this.OrganizationName != null &&
                    this.OrganizationName.Equals(other.OrganizationName)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
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
                    this.SocialSecurityNumber == other.SocialSecurityNumber ||
                    this.SocialSecurityNumber != null &&
                    this.SocialSecurityNumber.Equals(other.SocialSecurityNumber)
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
                if (this.CommercialRegisterNumber != null)
                {
                    hash = hash * 59 + this.CommercialRegisterNumber.GetHashCode();
                }
                if (this.Country != null)
                {
                    hash = hash * 59 + this.Country.GetHashCode();
                }
                if (this.DateOfBirth != null)
                {
                    hash = hash * 59 + this.DateOfBirth.GetHashCode();
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
                if (this.Gender != null)
                {
                    hash = hash * 59 + this.Gender.GetHashCode();
                }
                if (this.GivenName != null)
                {
                    hash = hash * 59 + this.GivenName.GetHashCode();
                }
                if (this.LegalOrganizationForm != null)
                {
                    hash = hash * 59 + this.LegalOrganizationForm.GetHashCode();
                }
                if (this.MobilePhoneNumber != null)
                {
                    hash = hash * 59 + this.MobilePhoneNumber.GetHashCode();
                }
                if (this.OrganizationName != null)
                {
                    hash = hash * 59 + this.OrganizationName.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
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
                if (this.SocialSecurityNumber != null)
                {
                    hash = hash * 59 + this.SocialSecurityNumber.GetHashCode();
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
