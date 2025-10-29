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
    /// SpaceAddressCreate
    /// </summary>
    [DataContract(Name = "SpaceAddress.Create")]
    public partial class SpaceAddressCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceAddressCreate" /> class.
        /// </summary>
        /// <param name="country">The two-letter country code (ISO 3166 format)..</param>
        /// <param name="mobilePhoneNumber">The phone number of a mobile phone..</param>
        /// <param name="organizationName">The organization&#39;s name..</param>
        /// <param name="city">The city, town or village..</param>
        /// <param name="givenName">The given or first name..</param>
        /// <param name="postcode">The postal code, also known as ZIP, postcode, etc..</param>
        /// <param name="salesTaxNumber">The sales tax number of the organization..</param>
        /// <param name="dependentLocality">The dependent locality which is a sub-division of the state..</param>
        /// <param name="emailAddress">The email address used for communication with clients..</param>
        /// <param name="phoneNumber">The phone number..</param>
        /// <param name="sortingCode">The sorting code identifying the post office where the PO Box is located..</param>
        /// <param name="street">The street or PO Box..</param>
        /// <param name="familyName">The family or last name..</param>
        /// <param name="postalState">The name of the region, typically a state, county, province or prefecture..</param>
        /// <param name="salutation">The salutation e.g. Mrs, Mr, Dr..</param>
        public SpaceAddressCreate(string country = default(string), string mobilePhoneNumber = default(string), string organizationName = default(string), string city = default(string), string givenName = default(string), string postcode = default(string), string salesTaxNumber = default(string), string dependentLocality = default(string), string emailAddress = default(string), string phoneNumber = default(string), string sortingCode = default(string), string street = default(string), string familyName = default(string), string postalState = default(string), string salutation = default(string))
        {
            this.Country = country;
            this.MobilePhoneNumber = mobilePhoneNumber;
            this.OrganizationName = organizationName;
            this.City = city;
            this.GivenName = givenName;
            this.Postcode = postcode;
            this.SalesTaxNumber = salesTaxNumber;
            this.DependentLocality = dependentLocality;
            this.EmailAddress = emailAddress;
            this.PhoneNumber = phoneNumber;
            this.SortingCode = sortingCode;
            this.Street = street;
            this.FamilyName = familyName;
            this.PostalState = postalState;
            this.Salutation = salutation;
        }

        /// <summary>
        /// The two-letter country code (ISO 3166 format).
        /// </summary>
        /// <value>The two-letter country code (ISO 3166 format).</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// The phone number of a mobile phone.
        /// </summary>
        /// <value>The phone number of a mobile phone.</value>
        [DataMember(Name = "mobilePhoneNumber", EmitDefaultValue = false)]
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// The organization&#39;s name.
        /// </summary>
        /// <value>The organization&#39;s name.</value>
        [DataMember(Name = "organizationName", EmitDefaultValue = false)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// The city, town or village.
        /// </summary>
        /// <value>The city, town or village.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The given or first name.
        /// </summary>
        /// <value>The given or first name.</value>
        [DataMember(Name = "givenName", EmitDefaultValue = false)]
        public string GivenName { get; set; }

        /// <summary>
        /// The postal code, also known as ZIP, postcode, etc.
        /// </summary>
        /// <value>The postal code, also known as ZIP, postcode, etc.</value>
        [DataMember(Name = "postcode", EmitDefaultValue = false)]
        public string Postcode { get; set; }

        /// <summary>
        /// The sales tax number of the organization.
        /// </summary>
        /// <value>The sales tax number of the organization.</value>
        [DataMember(Name = "salesTaxNumber", EmitDefaultValue = false)]
        public string SalesTaxNumber { get; set; }

        /// <summary>
        /// The dependent locality which is a sub-division of the state.
        /// </summary>
        /// <value>The dependent locality which is a sub-division of the state.</value>
        [DataMember(Name = "dependentLocality", EmitDefaultValue = false)]
        public string DependentLocality { get; set; }

        /// <summary>
        /// The email address used for communication with clients.
        /// </summary>
        /// <value>The email address used for communication with clients.</value>
        [DataMember(Name = "emailAddress", EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        /// <value>The phone number.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The sorting code identifying the post office where the PO Box is located.
        /// </summary>
        /// <value>The sorting code identifying the post office where the PO Box is located.</value>
        [DataMember(Name = "sortingCode", EmitDefaultValue = false)]
        public string SortingCode { get; set; }

        /// <summary>
        /// The street or PO Box.
        /// </summary>
        /// <value>The street or PO Box.</value>
        [DataMember(Name = "street", EmitDefaultValue = false)]
        public string Street { get; set; }

        /// <summary>
        /// The family or last name.
        /// </summary>
        /// <value>The family or last name.</value>
        [DataMember(Name = "familyName", EmitDefaultValue = false)]
        public string FamilyName { get; set; }

        /// <summary>
        /// The name of the region, typically a state, county, province or prefecture.
        /// </summary>
        /// <value>The name of the region, typically a state, county, province or prefecture.</value>
        [DataMember(Name = "postalState", EmitDefaultValue = false)]
        public string PostalState { get; set; }

        /// <summary>
        /// The salutation e.g. Mrs, Mr, Dr.
        /// </summary>
        /// <value>The salutation e.g. Mrs, Mr, Dr.</value>
        [DataMember(Name = "salutation", EmitDefaultValue = false)]
        public string Salutation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SpaceAddressCreate {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  MobilePhoneNumber: ").Append(MobilePhoneNumber).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  SalesTaxNumber: ").Append(SalesTaxNumber).Append("\n");
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

            // GivenName (string) maxLength
            if (this.GivenName != null && this.GivenName.Length > 100)
            {
                yield return new ValidationResult("Invalid value for GivenName, length must be less than 100.", new [] { "GivenName" });
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
