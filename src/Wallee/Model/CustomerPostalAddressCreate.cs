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
    /// CustomerPostalAddressCreate
    /// </summary>
    [DataContract]
    public partial class CustomerPostalAddressCreate :  IEquatable<CustomerPostalAddressCreate>
    {
        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name="gender", EmitDefaultValue=true)]
        public Gender? Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPostalAddressCreate" /> class.
        /// </summary>
        public CustomerPostalAddressCreate()
        {
        }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets CommercialRegisterNumber
        /// </summary>
        [DataMember(Name="commercialRegisterNumber", EmitDefaultValue=true)]
        public string CommercialRegisterNumber { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=true)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=true)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets DependentLocality
        /// </summary>
        [DataMember(Name="dependentLocality", EmitDefaultValue=true)]
        public string DependentLocality { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="emailAddress", EmitDefaultValue=true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets FamilyName
        /// </summary>
        [DataMember(Name="familyName", EmitDefaultValue=true)]
        public string FamilyName { get; set; }


        /// <summary>
        /// Gets or Sets GivenName
        /// </summary>
        [DataMember(Name="givenName", EmitDefaultValue=true)]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or Sets LegalOrganizationForm
        /// </summary>
        [DataMember(Name="legalOrganizationForm", EmitDefaultValue=true)]
        public long? LegalOrganizationForm { get; set; }

        /// <summary>
        /// Gets or Sets MobilePhoneNumber
        /// </summary>
        [DataMember(Name="mobilePhoneNumber", EmitDefaultValue=true)]
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationName
        /// </summary>
        [DataMember(Name="organizationName", EmitDefaultValue=true)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets PostalState
        /// </summary>
        [DataMember(Name="postalState", EmitDefaultValue=true)]
        public string PostalState { get; set; }

        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        [DataMember(Name="postcode", EmitDefaultValue=true)]
        public string Postcode { get; set; }

        /// <summary>
        /// Gets or Sets SalesTaxNumber
        /// </summary>
        [DataMember(Name="salesTaxNumber", EmitDefaultValue=true)]
        public string SalesTaxNumber { get; set; }

        /// <summary>
        /// Gets or Sets Salutation
        /// </summary>
        [DataMember(Name="salutation", EmitDefaultValue=true)]
        public string Salutation { get; set; }

        /// <summary>
        /// Gets or Sets SocialSecurityNumber
        /// </summary>
        [DataMember(Name="socialSecurityNumber", EmitDefaultValue=true)]
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// The sorting code identifies the post office at which the post box is located in.
        /// </summary>
        /// <value>The sorting code identifies the post office at which the post box is located in.</value>
        [DataMember(Name="sortingCode", EmitDefaultValue=true)]
        public string SortingCode { get; set; }

        /// <summary>
        /// Gets or Sets Street
        /// </summary>
        [DataMember(Name="street", EmitDefaultValue=true)]
        public string Street { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerPostalAddressCreate {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CommercialRegisterNumber: ").Append(CommercialRegisterNumber).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  DependentLocality: ").Append(DependentLocality).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  LegalOrganizationForm: ").Append(LegalOrganizationForm).Append("\n");
            sb.Append("  MobilePhoneNumber: ").Append(MobilePhoneNumber).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PostalState: ").Append(PostalState).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  SalesTaxNumber: ").Append(SalesTaxNumber).Append("\n");
            sb.Append("  Salutation: ").Append(Salutation).Append("\n");
            sb.Append("  SocialSecurityNumber: ").Append(SocialSecurityNumber).Append("\n");
            sb.Append("  SortingCode: ").Append(SortingCode).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
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
            return this.Equals(input as CustomerPostalAddressCreate);
        }

        /// <summary>
        /// Returns true if CustomerPostalAddressCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerPostalAddressCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerPostalAddressCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CommercialRegisterNumber == input.CommercialRegisterNumber ||
                    (this.CommercialRegisterNumber != null &&
                    this.CommercialRegisterNumber.Equals(input.CommercialRegisterNumber))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.DependentLocality == input.DependentLocality ||
                    (this.DependentLocality != null &&
                    this.DependentLocality.Equals(input.DependentLocality))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.FamilyName == input.FamilyName ||
                    (this.FamilyName != null &&
                    this.FamilyName.Equals(input.FamilyName))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.GivenName == input.GivenName ||
                    (this.GivenName != null &&
                    this.GivenName.Equals(input.GivenName))
                ) && 
                (
                    this.LegalOrganizationForm == input.LegalOrganizationForm ||
                    (this.LegalOrganizationForm != null &&
                    this.LegalOrganizationForm.Equals(input.LegalOrganizationForm))
                ) && 
                (
                    this.MobilePhoneNumber == input.MobilePhoneNumber ||
                    (this.MobilePhoneNumber != null &&
                    this.MobilePhoneNumber.Equals(input.MobilePhoneNumber))
                ) && 
                (
                    this.OrganizationName == input.OrganizationName ||
                    (this.OrganizationName != null &&
                    this.OrganizationName.Equals(input.OrganizationName))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PostalState == input.PostalState ||
                    (this.PostalState != null &&
                    this.PostalState.Equals(input.PostalState))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.SalesTaxNumber == input.SalesTaxNumber ||
                    (this.SalesTaxNumber != null &&
                    this.SalesTaxNumber.Equals(input.SalesTaxNumber))
                ) && 
                (
                    this.Salutation == input.Salutation ||
                    (this.Salutation != null &&
                    this.Salutation.Equals(input.Salutation))
                ) && 
                (
                    this.SocialSecurityNumber == input.SocialSecurityNumber ||
                    (this.SocialSecurityNumber != null &&
                    this.SocialSecurityNumber.Equals(input.SocialSecurityNumber))
                ) && 
                (
                    this.SortingCode == input.SortingCode ||
                    (this.SortingCode != null &&
                    this.SortingCode.Equals(input.SortingCode))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
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
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.CommercialRegisterNumber != null)
                    hashCode = hashCode * 59 + this.CommercialRegisterNumber.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.DependentLocality != null)
                    hashCode = hashCode * 59 + this.DependentLocality.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.FamilyName != null)
                    hashCode = hashCode * 59 + this.FamilyName.GetHashCode();
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.GivenName != null)
                    hashCode = hashCode * 59 + this.GivenName.GetHashCode();
                if (this.LegalOrganizationForm != null)
                    hashCode = hashCode * 59 + this.LegalOrganizationForm.GetHashCode();
                if (this.MobilePhoneNumber != null)
                    hashCode = hashCode * 59 + this.MobilePhoneNumber.GetHashCode();
                if (this.OrganizationName != null)
                    hashCode = hashCode * 59 + this.OrganizationName.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.PostalState != null)
                    hashCode = hashCode * 59 + this.PostalState.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.SalesTaxNumber != null)
                    hashCode = hashCode * 59 + this.SalesTaxNumber.GetHashCode();
                if (this.Salutation != null)
                    hashCode = hashCode * 59 + this.Salutation.GetHashCode();
                if (this.SocialSecurityNumber != null)
                    hashCode = hashCode * 59 + this.SocialSecurityNumber.GetHashCode();
                if (this.SortingCode != null)
                    hashCode = hashCode * 59 + this.SortingCode.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                return hashCode;
            }
        }

    }

}
