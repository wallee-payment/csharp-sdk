/**
 * Wallee AG C# SDK
 *
 * This library allows to interact with the Wallee AG payment service.
 *
 * Copyright owner: Wallee AG
 * Website: https://en.wallee.com
 * Developer email: ecosystem-team@wallee.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Wallee.Client.OpenAPIDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// Address
    /// </summary>
    [DataContract(Name = "Address")]
    public partial class Address : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        public Gender? Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="gender">gender.</param>
        /// <param name="legalOrganizationForm">legalOrganizationForm.</param>
        public Address(Gender? gender = default, LegalOrganizationForm legalOrganizationForm = default)
        {
            this.Gender = gender;
            this.LegalOrganizationForm = legalOrganizationForm;
        }

        /// <summary>
        /// The two-letter country code (ISO 3166 format).
        /// </summary>
        /// <value>The two-letter country code (ISO 3166 format).</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; private set; }

        /// <summary>
        /// Returns false as Country should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCountry()
        {
            return false;
        }
        /// <summary>
        /// The phone number of a mobile phone.
        /// </summary>
        /// <value>The phone number of a mobile phone.</value>
        [DataMember(Name = "mobilePhoneNumber", EmitDefaultValue = false)]
        public string MobilePhoneNumber { get; private set; }

        /// <summary>
        /// Returns false as MobilePhoneNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMobilePhoneNumber()
        {
            return false;
        }
        /// <summary>
        /// The organization&#39;s name.
        /// </summary>
        /// <value>The organization&#39;s name.</value>
        [DataMember(Name = "organizationName", EmitDefaultValue = false)]
        public string OrganizationName { get; private set; }

        /// <summary>
        /// Returns false as OrganizationName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOrganizationName()
        {
            return false;
        }
        /// <summary>
        /// The city, town or village.
        /// </summary>
        /// <value>The city, town or village.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; private set; }

        /// <summary>
        /// Returns false as City should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCity()
        {
            return false;
        }
        /// <summary>
        /// The commercial registration number of the organization.
        /// </summary>
        /// <value>The commercial registration number of the organization.</value>
        [DataMember(Name = "commercialRegisterNumber", EmitDefaultValue = false)]
        public string CommercialRegisterNumber { get; private set; }

        /// <summary>
        /// Returns false as CommercialRegisterNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCommercialRegisterNumber()
        {
            return false;
        }
        /// <summary>
        /// The social security number.
        /// </summary>
        /// <value>The social security number.</value>
        [DataMember(Name = "socialSecurityNumber", EmitDefaultValue = false)]
        public string SocialSecurityNumber { get; private set; }

        /// <summary>
        /// Returns false as SocialSecurityNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSocialSecurityNumber()
        {
            return false;
        }
        /// <summary>
        /// The given or first name.
        /// </summary>
        /// <value>The given or first name.</value>
        [DataMember(Name = "givenName", EmitDefaultValue = false)]
        public string GivenName { get; private set; }

        /// <summary>
        /// Returns false as GivenName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGivenName()
        {
            return false;
        }
        /// <summary>
        /// The postal code, also known as ZIP, postcode, etc.
        /// </summary>
        /// <value>The postal code, also known as ZIP, postcode, etc.</value>
        [DataMember(Name = "postcode", EmitDefaultValue = false)]
        public string Postcode { get; private set; }

        /// <summary>
        /// Returns false as Postcode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePostcode()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LegalOrganizationForm
        /// </summary>
        [DataMember(Name = "legalOrganizationForm", EmitDefaultValue = false)]
        public LegalOrganizationForm LegalOrganizationForm { get; set; }

        /// <summary>
        /// The sales tax number of the organization.
        /// </summary>
        /// <value>The sales tax number of the organization.</value>
        [DataMember(Name = "salesTaxNumber", EmitDefaultValue = false)]
        public string SalesTaxNumber { get; private set; }

        /// <summary>
        /// Returns false as SalesTaxNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSalesTaxNumber()
        {
            return false;
        }
        /// <summary>
        /// The date of birth.
        /// </summary>
        /// <value>The date of birth.</value>
        [DataMember(Name = "dateOfBirth", EmitDefaultValue = false)]
        public DateOnly DateOfBirth { get; private set; }

        /// <summary>
        /// Returns false as DateOfBirth should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDateOfBirth()
        {
            return false;
        }
        /// <summary>
        /// The dependent locality which is a sub-division of the state.
        /// </summary>
        /// <value>The dependent locality which is a sub-division of the state.</value>
        [DataMember(Name = "dependentLocality", EmitDefaultValue = false)]
        public string DependentLocality { get; private set; }

        /// <summary>
        /// Returns false as DependentLocality should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDependentLocality()
        {
            return false;
        }
        /// <summary>
        /// The email address.
        /// </summary>
        /// <value>The email address.</value>
        [DataMember(Name = "emailAddress", EmitDefaultValue = false)]
        public string EmailAddress { get; private set; }

        /// <summary>
        /// Returns false as EmailAddress should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmailAddress()
        {
            return false;
        }
        /// <summary>
        /// The phone number.
        /// </summary>
        /// <value>The phone number.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; private set; }

        /// <summary>
        /// Returns false as PhoneNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePhoneNumber()
        {
            return false;
        }
        /// <summary>
        /// The sorting code identifying the post office where the PO Box is located.
        /// </summary>
        /// <value>The sorting code identifying the post office where the PO Box is located.</value>
        [DataMember(Name = "sortingCode", EmitDefaultValue = false)]
        public string SortingCode { get; private set; }

        /// <summary>
        /// Returns false as SortingCode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSortingCode()
        {
            return false;
        }
        /// <summary>
        /// The street or PO Box.
        /// </summary>
        /// <value>The street or PO Box.</value>
        [DataMember(Name = "street", EmitDefaultValue = false)]
        public string Street { get; private set; }

        /// <summary>
        /// Returns false as Street should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStreet()
        {
            return false;
        }
        /// <summary>
        /// The family or last name.
        /// </summary>
        /// <value>The family or last name.</value>
        [DataMember(Name = "familyName", EmitDefaultValue = false)]
        public string FamilyName { get; private set; }

        /// <summary>
        /// Returns false as FamilyName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFamilyName()
        {
            return false;
        }
        /// <summary>
        /// The name of the region, typically a state, county, province or prefecture.
        /// </summary>
        /// <value>The name of the region, typically a state, county, province or prefecture.</value>
        [DataMember(Name = "postalState", EmitDefaultValue = false)]
        public string PostalState { get; private set; }

        /// <summary>
        /// Returns false as PostalState should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePostalState()
        {
            return false;
        }
        /// <summary>
        /// The salutation e.g. Mrs, Mr, Dr.
        /// </summary>
        /// <value>The salutation e.g. Mrs, Mr, Dr.</value>
        [DataMember(Name = "salutation", EmitDefaultValue = false)]
        public string Salutation { get; private set; }

        /// <summary>
        /// Returns false as Salutation should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSalutation()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  MobilePhoneNumber: ").Append(MobilePhoneNumber).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CommercialRegisterNumber: ").Append(CommercialRegisterNumber).Append("\n");
            sb.Append("  SocialSecurityNumber: ").Append(SocialSecurityNumber).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  LegalOrganizationForm: ").Append(LegalOrganizationForm).Append("\n");
            sb.Append("  SalesTaxNumber: ").Append(SalesTaxNumber).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  DependentLocality: ").Append(DependentLocality).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  SortingCode: ").Append(SortingCode).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  PostalState: ").Append(PostalState).Append("\n");
            sb.Append("  Salutation: ").Append(Salutation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // MobilePhoneNumber (string) maxLength
            if (this.MobilePhoneNumber != null && this.MobilePhoneNumber.Length > 100)
            {
                yield return new ValidationResult("Invalid value for MobilePhoneNumber, length must be less than 100.", new [] { "MobilePhoneNumber" });
            }

            // OrganizationName (string) maxLength
            if (this.OrganizationName != null && this.OrganizationName.Length > 100)
            {
                yield return new ValidationResult("Invalid value for OrganizationName, length must be less than 100.", new [] { "OrganizationName" });
            }

            // City (string) maxLength
            if (this.City != null && this.City.Length > 100)
            {
                yield return new ValidationResult("Invalid value for City, length must be less than 100.", new [] { "City" });
            }

            // CommercialRegisterNumber (string) maxLength
            if (this.CommercialRegisterNumber != null && this.CommercialRegisterNumber.Length > 100)
            {
                yield return new ValidationResult("Invalid value for CommercialRegisterNumber, length must be less than 100.", new [] { "CommercialRegisterNumber" });
            }

            // SocialSecurityNumber (string) maxLength
            if (this.SocialSecurityNumber != null && this.SocialSecurityNumber.Length > 100)
            {
                yield return new ValidationResult("Invalid value for SocialSecurityNumber, length must be less than 100.", new [] { "SocialSecurityNumber" });
            }

            // GivenName (string) maxLength
            if (this.GivenName != null && this.GivenName.Length > 100)
            {
                yield return new ValidationResult("Invalid value for GivenName, length must be less than 100.", new [] { "GivenName" });
            }

            // Postcode (string) maxLength
            if (this.Postcode != null && this.Postcode.Length > 40)
            {
                yield return new ValidationResult("Invalid value for Postcode, length must be less than 40.", new [] { "Postcode" });
            }

            // SalesTaxNumber (string) maxLength
            if (this.SalesTaxNumber != null && this.SalesTaxNumber.Length > 100)
            {
                yield return new ValidationResult("Invalid value for SalesTaxNumber, length must be less than 100.", new [] { "SalesTaxNumber" });
            }

            // DependentLocality (string) maxLength
            if (this.DependentLocality != null && this.DependentLocality.Length > 100)
            {
                yield return new ValidationResult("Invalid value for DependentLocality, length must be less than 100.", new [] { "DependentLocality" });
            }

            // EmailAddress (string) maxLength
            if (this.EmailAddress != null && this.EmailAddress.Length > 254)
            {
                yield return new ValidationResult("Invalid value for EmailAddress, length must be less than 254.", new [] { "EmailAddress" });
            }

            // PhoneNumber (string) maxLength
            if (this.PhoneNumber != null && this.PhoneNumber.Length > 100)
            {
                yield return new ValidationResult("Invalid value for PhoneNumber, length must be less than 100.", new [] { "PhoneNumber" });
            }

            // SortingCode (string) maxLength
            if (this.SortingCode != null && this.SortingCode.Length > 100)
            {
                yield return new ValidationResult("Invalid value for SortingCode, length must be less than 100.", new [] { "SortingCode" });
            }

            // Street (string) maxLength
            if (this.Street != null && this.Street.Length > 300)
            {
                yield return new ValidationResult("Invalid value for Street, length must be less than 300.", new [] { "Street" });
            }

            // FamilyName (string) maxLength
            if (this.FamilyName != null && this.FamilyName.Length > 100)
            {
                yield return new ValidationResult("Invalid value for FamilyName, length must be less than 100.", new [] { "FamilyName" });
            }

            // Salutation (string) maxLength
            if (this.Salutation != null && this.Salutation.Length > 20)
            {
                yield return new ValidationResult("Invalid value for Salutation, length must be less than 20.", new [] { "Salutation" });
            }

            yield break;
        }
    }

}
