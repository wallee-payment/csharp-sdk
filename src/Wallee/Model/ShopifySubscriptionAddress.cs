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
    /// ShopifySubscriptionAddress
    /// </summary>
    [DataContract]
    public partial class ShopifySubscriptionAddress : Address,  IEquatable<ShopifySubscriptionAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriptionAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ShopifySubscriptionAddress()
        {
        }





















        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShopifySubscriptionAddress {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
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
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShopifySubscriptionAddress);
        }

        /// <summary>
        /// Returns true if ShopifySubscriptionAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifySubscriptionAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifySubscriptionAddress input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && base.Equals(input) && 
                (
                    this.CommercialRegisterNumber == input.CommercialRegisterNumber ||
                    (this.CommercialRegisterNumber != null &&
                    this.CommercialRegisterNumber.Equals(input.CommercialRegisterNumber))
                ) && base.Equals(input) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && base.Equals(input) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && base.Equals(input) && 
                (
                    this.DependentLocality == input.DependentLocality ||
                    (this.DependentLocality != null &&
                    this.DependentLocality.Equals(input.DependentLocality))
                ) && base.Equals(input) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && base.Equals(input) && 
                (
                    this.FamilyName == input.FamilyName ||
                    (this.FamilyName != null &&
                    this.FamilyName.Equals(input.FamilyName))
                ) && base.Equals(input) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && base.Equals(input) && 
                (
                    this.GivenName == input.GivenName ||
                    (this.GivenName != null &&
                    this.GivenName.Equals(input.GivenName))
                ) && base.Equals(input) && 
                (
                    this.LegalOrganizationForm == input.LegalOrganizationForm ||
                    (this.LegalOrganizationForm != null &&
                    this.LegalOrganizationForm.Equals(input.LegalOrganizationForm))
                ) && base.Equals(input) && 
                (
                    this.MobilePhoneNumber == input.MobilePhoneNumber ||
                    (this.MobilePhoneNumber != null &&
                    this.MobilePhoneNumber.Equals(input.MobilePhoneNumber))
                ) && base.Equals(input) && 
                (
                    this.OrganizationName == input.OrganizationName ||
                    (this.OrganizationName != null &&
                    this.OrganizationName.Equals(input.OrganizationName))
                ) && base.Equals(input) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && base.Equals(input) && 
                (
                    this.PostalState == input.PostalState ||
                    (this.PostalState != null &&
                    this.PostalState.Equals(input.PostalState))
                ) && base.Equals(input) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && base.Equals(input) && 
                (
                    this.SalesTaxNumber == input.SalesTaxNumber ||
                    (this.SalesTaxNumber != null &&
                    this.SalesTaxNumber.Equals(input.SalesTaxNumber))
                ) && base.Equals(input) && 
                (
                    this.Salutation == input.Salutation ||
                    (this.Salutation != null &&
                    this.Salutation.Equals(input.Salutation))
                ) && base.Equals(input) && 
                (
                    this.SocialSecurityNumber == input.SocialSecurityNumber ||
                    (this.SocialSecurityNumber != null &&
                    this.SocialSecurityNumber.Equals(input.SocialSecurityNumber))
                ) && base.Equals(input) && 
                (
                    this.SortingCode == input.SortingCode ||
                    (this.SortingCode != null &&
                    this.SortingCode.Equals(input.SortingCode))
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
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
