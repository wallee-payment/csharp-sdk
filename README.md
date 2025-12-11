# Wallee C# SDK

- API version: 2.0

The Wallee C# SDK is used to interact with Wallee's REST API.

## Requirements

Building the API client library requires:

1. .NET 8.0 or later

## Installation

#### Package Manager
```shell
Install-Package Wallee -Version 1.0.0
```
#### .NET CLI
```shell
dotnet add package Wallee --version 1.0.0
```
#### Paket CLI
```shell
paket add Wallee --version 1.0.0
```
#### PackageReference
```
<PackageReference Include="Wallee" Version="1.0.0" />
```

## Getting Started

Please follow the [installation](#installation) instructions and execute the following C# code:

```csharp
using System;
using System.Collections.Generic;
using Wallee.Client;
using Wallee.Model;
using Wallee.Service;

public class Program
{
    public static void Main()
    {
        long applicationUserId = 512;
        string authenticationKey = "FKrO76r5VwJtBrqZawBspljbBNOxp5veKQQkOnZxucQ=";

        var config = new Configuration(applicationUserId, authenticationKey);
        var transactionsApi = new TransactionsService(config);

        try
        {
            long transactionId = 367155626;
            long spaceId = 405;
            var expandList = new List<string> { "group" };

            var transaction = transactionsApi.GetPaymentTransactionsId(transactionId, spaceId, expandList);

            Console.WriteLine("Transaction: " + transaction);
        }
        catch (ApiException e)
        {
            Console.Error.WriteLine("Exception when calling api: ");
            Console.Error.WriteLine("Status code: " + e.ErrorCode);
            Console.Error.WriteLine("Reason: " + e.Message);
            Console.Error.WriteLine("Stack Trace: " + e.StackTrace);
        }
    }
}
```

## Documentation for API Endpoints

Additional API services documentation: [*link*](https://app-wallee.com/en-us/doc/api/web-service#_services)<br>
Web API client: [*link*](https://app-wallee.com//api/client)<br>
<details>
  <summary>Click here to see full list of services</summary>
  <br>All URIs are relative to https://app-wallee.com/<br>

  <p><strong>API Services:</strong></p>

- <strong>AccountsService</strong><br>
  &nbsp;&nbsp;* <code>DeleteAccountsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /accounts/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete an account
  <br><br>
- <strong>AccountsService</strong><br>
  &nbsp;&nbsp;* <code>GetAccounts</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /accounts
  &nbsp;&nbsp;&nbsp;&nbsp;List all accounts
  <br><br>
- <strong>AccountsService</strong><br>
  &nbsp;&nbsp;* <code>GetAccountsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /accounts/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve an account
  <br><br>
- <strong>AccountsService</strong><br>
  &nbsp;&nbsp;* <code>GetAccountsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /accounts/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search accounts
  <br><br>
- <strong>AccountsService</strong><br>
  &nbsp;&nbsp;* <code>PatchAccountsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /accounts/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update an account
  <br><br>
- <strong>AccountsService</strong><br>
  &nbsp;&nbsp;* <code>PostAccounts</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /accounts
  &nbsp;&nbsp;&nbsp;&nbsp;Create an account
  <br><br>
- <strong>AccountsService</strong><br>
  &nbsp;&nbsp;* <code>PostAccountsIdActivate</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /accounts/{id}/activate
  &nbsp;&nbsp;&nbsp;&nbsp;Activate an account
  <br><br>
- <strong>AccountsService</strong><br>
  &nbsp;&nbsp;* <code>PostAccountsIdDeactivate</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /accounts/{id}/deactivate
  &nbsp;&nbsp;&nbsp;&nbsp;Deactivate an account
  <br><br>
- <strong>AnalyticsQueriesService</strong><br>
  &nbsp;&nbsp;* <code>DeleteAnalyticsQueriesQueryExternalIdQueryExternalId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /analytics/queries/queryExternalId/{queryExternalId}
  &nbsp;&nbsp;&nbsp;&nbsp;Cancel a query execution, identifying it by its external id.
  <br><br>
- <strong>AnalyticsQueriesService</strong><br>
  &nbsp;&nbsp;* <code>DeleteAnalyticsQueriesQueryTokenQueryToken</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /analytics/queries/queryToken/{queryToken}
  &nbsp;&nbsp;&nbsp;&nbsp;Cancel a query execution, identifying it by its query token.
  <br><br>
- <strong>AnalyticsQueriesService</strong><br>
  &nbsp;&nbsp;* <code>GetAnalyticsQueries</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /analytics/queries
  &nbsp;&nbsp;&nbsp;&nbsp;Get portion of query executions for account
  <br><br>
- <strong>AnalyticsQueriesService</strong><br>
  &nbsp;&nbsp;* <code>GetAnalyticsQueriesQueryExternalIdQueryExternalId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /analytics/queries/queryExternalId/{queryExternalId}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a query execution information by its external id
  <br><br>
- <strong>AnalyticsQueriesService</strong><br>
  &nbsp;&nbsp;* <code>GetAnalyticsQueriesQueryExternalIdQueryExternalIdResult</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /analytics/queries/queryExternalId/{queryExternalId}/result
  &nbsp;&nbsp;&nbsp;&nbsp;Generate a temporary URL to download the query result. It retrieves the query by its external id
  <br><br>
- <strong>AnalyticsQueriesService</strong><br>
  &nbsp;&nbsp;* <code>GetAnalyticsQueriesQueryTokenQueryToken</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /analytics/queries/queryToken/{queryToken}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a query execution information by its query token
  <br><br>
- <strong>AnalyticsQueriesService</strong><br>
  &nbsp;&nbsp;* <code>GetAnalyticsQueriesQueryTokenQueryTokenResult</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /analytics/queries/queryToken/{queryToken}/result
  &nbsp;&nbsp;&nbsp;&nbsp;Generate a temporary URL to download the query result. It retrieves the query by its query token
  <br><br>
- <strong>AnalyticsQueriesService</strong><br>
  &nbsp;&nbsp;* <code>PostAnalyticsQueriesSubmit</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /analytics/queries/submit
  &nbsp;&nbsp;&nbsp;&nbsp;Submit a query execution
  <br><br>
- <strong>ApplicationUsersService</strong><br>
  &nbsp;&nbsp;* <code>DeleteApplicationUsersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /application-users/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete an application user
  <br><br>
- <strong>ApplicationUsersService</strong><br>
  &nbsp;&nbsp;* <code>DeleteApplicationUsersUserIdKeysId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /application-users/{userId}/keys/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Deactivate an authentication key
  <br><br>
- <strong>ApplicationUsersService</strong><br>
  &nbsp;&nbsp;* <code>GetApplicationUsers</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /application-users
  &nbsp;&nbsp;&nbsp;&nbsp;List all application users
  <br><br>
- <strong>ApplicationUsersService</strong><br>
  &nbsp;&nbsp;* <code>GetApplicationUsersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /application-users/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve an application user
  <br><br>
- <strong>ApplicationUsersService</strong><br>
  &nbsp;&nbsp;* <code>GetApplicationUsersSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /application-users/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search application users
  <br><br>
- <strong>ApplicationUsersService</strong><br>
  &nbsp;&nbsp;* <code>GetApplicationUsersUserIdKeys</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /application-users/{userId}/keys
  &nbsp;&nbsp;&nbsp;&nbsp;List a user&#39;s authentication keys
  <br><br>
- <strong>ApplicationUsersService</strong><br>
  &nbsp;&nbsp;* <code>PatchApplicationUsersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /application-users/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update an application user
  <br><br>
- <strong>ApplicationUsersService</strong><br>
  &nbsp;&nbsp;* <code>PostApplicationUsers</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /application-users
  &nbsp;&nbsp;&nbsp;&nbsp;Create an application user
  <br><br>
- <strong>ApplicationUsersService</strong><br>
  &nbsp;&nbsp;* <code>PostApplicationUsersUserIdKeys</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /application-users/{userId}/keys
  &nbsp;&nbsp;&nbsp;&nbsp;Generate a new authentication key
  <br><br>
- <strong>ApplicationUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>DeleteApplicationUsersUserIdAccountRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /application-users/{userId}/account-roles
  &nbsp;&nbsp;&nbsp;&nbsp;Unassign a role from an application user for an account
  <br><br>
- <strong>ApplicationUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>DeleteApplicationUsersUserIdSpaceRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /application-users/{userId}/space-roles
  &nbsp;&nbsp;&nbsp;&nbsp;Unassign a role from an application user for a space
  <br><br>
- <strong>ApplicationUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>GetApplicationUsersUserIdAccountRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /application-users/{userId}/account-roles
  &nbsp;&nbsp;&nbsp;&nbsp;List all roles of an application user for an account
  <br><br>
- <strong>ApplicationUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>GetApplicationUsersUserIdSpaceRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /application-users/{userId}/space-roles
  &nbsp;&nbsp;&nbsp;&nbsp;List all roles of an application user for a space
  <br><br>
- <strong>ApplicationUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>PostApplicationUsersUserIdAccountRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /application-users/{userId}/account-roles
  &nbsp;&nbsp;&nbsp;&nbsp;Assign a role to an application user for an account
  <br><br>
- <strong>ApplicationUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>PostApplicationUsersUserIdSpaceRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /application-users/{userId}/space-roles
  &nbsp;&nbsp;&nbsp;&nbsp;Assign a role to an application user for a space
  <br><br>
- <strong>BankAccountsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankAccounts</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-accounts
  &nbsp;&nbsp;&nbsp;&nbsp;List all bank accounts
  <br><br>
- <strong>BankAccountsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankAccountsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-accounts/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a bank account
  <br><br>
- <strong>BankAccountsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankAccountsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-accounts/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search bank accounts
  <br><br>
- <strong>BankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactions</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions
  &nbsp;&nbsp;&nbsp;&nbsp;List all bank transactions
  <br><br>
- <strong>BankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a bank transaction
  <br><br>
- <strong>BankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search bank transactions
  <br><br>
- <strong>ChargeAttemptsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentChargeAttempts</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/charge-attempts
  &nbsp;&nbsp;&nbsp;&nbsp;List all charge attempts
  <br><br>
- <strong>ChargeAttemptsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentChargeAttemptsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/charge-attempts/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a charge attempt
  <br><br>
- <strong>ChargeAttemptsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentChargeAttemptsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/charge-attempts/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search charge attempts
  <br><br>
- <strong>ChargeBankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsCharges</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/charges
  &nbsp;&nbsp;&nbsp;&nbsp;List all charge bank transactions
  <br><br>
- <strong>ChargeBankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsChargesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/charges/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a charge bank transaction
  <br><br>
- <strong>ChargeBankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsChargesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/charges/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search charge bank transactions
  <br><br>
- <strong>ChargeFlowLevelsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentChargeFlowsLevels</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/charge-flows/levels
  &nbsp;&nbsp;&nbsp;&nbsp;List all charge flow levels
  <br><br>
- <strong>ChargeFlowLevelsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentChargeFlowsLevelsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/charge-flows/levels/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a charge flow level
  <br><br>
- <strong>ChargeFlowLevelsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentChargeFlowsLevelsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/charge-flows/levels/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search charge flow levels
  <br><br>
- <strong>ChargeFlowLevelsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentChargeFlowsLevelsIdSendMessage</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/charge-flows/levels/{id}/send-message
  &nbsp;&nbsp;&nbsp;&nbsp;Send a payment link
  <br><br>
- <strong>ChargeFlowsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentChargeFlows</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/charge-flows
  &nbsp;&nbsp;&nbsp;&nbsp;List all charge flows
  <br><br>
- <strong>ChargeFlowsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentChargeFlowsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/charge-flows/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a charge flow
  <br><br>
- <strong>ChargeFlowsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentChargeFlowsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/charge-flows/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search charge flows
  <br><br>
- <strong>ChargeFlowsLevelPaymentLinksService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentChargeFlowsLevelsPaymentLinks</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/charge-flows/levels/payment-links
  &nbsp;&nbsp;&nbsp;&nbsp;List all charge flow payment links
  <br><br>
- <strong>ChargeFlowsLevelPaymentLinksService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentChargeFlowsLevelsPaymentLinksId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/charge-flows/levels/payment-links/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a charge flow payment link
  <br><br>
- <strong>ChargeFlowsLevelPaymentLinksService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentChargeFlowsLevelsPaymentLinksSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/charge-flows/levels/payment-links/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search charge flow payment links
  <br><br>
- <strong>ConditionTypesService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentConditionTypes</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/condition-types
  &nbsp;&nbsp;&nbsp;&nbsp;List all condition types.
  <br><br>
- <strong>ConditionTypesService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentConditionTypesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/condition-types/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a condition type.
  <br><br>
- <strong>ConditionTypesService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentConditionTypesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/condition-types/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search condition types.
  <br><br>
- <strong>ConsumedResourcesService</strong><br>
  &nbsp;&nbsp;* <code>GetSpacesConsumedResources</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /spaces/consumed-resources
  &nbsp;&nbsp;&nbsp;&nbsp;List consumed resources
  <br><br>
- <strong>CountriesService</strong><br>
  &nbsp;&nbsp;* <code>GetCountries</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /countries
  &nbsp;&nbsp;&nbsp;&nbsp;List all countries
  <br><br>
- <strong>CountriesService</strong><br>
  &nbsp;&nbsp;* <code>GetCountriesCode</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /countries/{code}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a country
  <br><br>
- <strong>CountriesService</strong><br>
  &nbsp;&nbsp;* <code>GetCountriesCountryCodeStates</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /countries/{countryCode}/states
  &nbsp;&nbsp;&nbsp;&nbsp;List all states for a country
  <br><br>
- <strong>CountriesService</strong><br>
  &nbsp;&nbsp;* <code>GetCountriesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /countries/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search countries
  <br><br>
- <strong>CountriesService</strong><br>
  &nbsp;&nbsp;* <code>GetCountriesStates</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /countries/states
  &nbsp;&nbsp;&nbsp;&nbsp;List all country states
  <br><br>
- <strong>CountriesService</strong><br>
  &nbsp;&nbsp;* <code>GetCountriesStatesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /countries/states/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a country state
  <br><br>
- <strong>CurrenciesService</strong><br>
  &nbsp;&nbsp;* <code>GetCurrencies</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /currencies
  &nbsp;&nbsp;&nbsp;&nbsp;List all currencies
  <br><br>
- <strong>CurrenciesService</strong><br>
  &nbsp;&nbsp;* <code>GetCurrenciesCode</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /currencies/{code}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a currency
  <br><br>
- <strong>CurrenciesService</strong><br>
  &nbsp;&nbsp;* <code>GetCurrenciesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /currencies/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search currencies
  <br><br>
- <strong>CurrencyBankAccountsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentCurrencyBankAccounts</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/currency-bank-accounts
  &nbsp;&nbsp;&nbsp;&nbsp;List all currency bank accounts
  <br><br>
- <strong>CurrencyBankAccountsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentCurrencyBankAccountsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/currency-bank-accounts/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a currency bank account
  <br><br>
- <strong>CurrencyBankAccountsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentCurrencyBankAccountsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/currency-bank-accounts/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search currency bank accounts
  <br><br>
- <strong>CustomerAddressesService</strong><br>
  &nbsp;&nbsp;* <code>DeleteCustomersCustomerIdAddressesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /customers/{customerId}/addresses/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a customer address
  <br><br>
- <strong>CustomerAddressesService</strong><br>
  &nbsp;&nbsp;* <code>GetCustomersCustomerIdAddresses</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /customers/{customerId}/addresses
  &nbsp;&nbsp;&nbsp;&nbsp;List all customer addresses
  <br><br>
- <strong>CustomerAddressesService</strong><br>
  &nbsp;&nbsp;* <code>GetCustomersCustomerIdAddressesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /customers/{customerId}/addresses/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a customer address
  <br><br>
- <strong>CustomerAddressesService</strong><br>
  &nbsp;&nbsp;* <code>GetCustomersCustomerIdAddressesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /customers/{customerId}/addresses/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search customer addresses
  <br><br>
- <strong>CustomerAddressesService</strong><br>
  &nbsp;&nbsp;* <code>PatchCustomersCustomerIdAddressesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /customers/{customerId}/addresses/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a customer address
  <br><br>
- <strong>CustomerAddressesService</strong><br>
  &nbsp;&nbsp;* <code>PostCustomersCustomerIdAddresses</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /customers/{customerId}/addresses
  &nbsp;&nbsp;&nbsp;&nbsp;Create a customer address
  <br><br>
- <strong>CustomerAddressesService</strong><br>
  &nbsp;&nbsp;* <code>PostCustomersCustomerIdAddressesIdDefault</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /customers/{customerId}/addresses/{id}/default
  &nbsp;&nbsp;&nbsp;&nbsp;Set the default address for a customer
  <br><br>
- <strong>CustomerCommentsService</strong><br>
  &nbsp;&nbsp;* <code>DeleteCustomersCustomerIdCommentsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /customers/{customerId}/comments/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a customer comment
  <br><br>
- <strong>CustomerCommentsService</strong><br>
  &nbsp;&nbsp;* <code>GetCustomersCustomerIdComments</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /customers/{customerId}/comments
  &nbsp;&nbsp;&nbsp;&nbsp;List all customer comments
  <br><br>
- <strong>CustomerCommentsService</strong><br>
  &nbsp;&nbsp;* <code>GetCustomersCustomerIdCommentsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /customers/{customerId}/comments/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a customer comment
  <br><br>
- <strong>CustomerCommentsService</strong><br>
  &nbsp;&nbsp;* <code>GetCustomersCustomerIdCommentsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /customers/{customerId}/comments/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search customer comments
  <br><br>
- <strong>CustomerCommentsService</strong><br>
  &nbsp;&nbsp;* <code>PatchCustomersCustomerIdCommentsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /customers/{customerId}/comments/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a customer comment
  <br><br>
- <strong>CustomerCommentsService</strong><br>
  &nbsp;&nbsp;* <code>PostCustomersCustomerIdComments</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /customers/{customerId}/comments
  &nbsp;&nbsp;&nbsp;&nbsp;Create a customer comment
  <br><br>
- <strong>CustomerCommentsService</strong><br>
  &nbsp;&nbsp;* <code>PostCustomersCustomerIdCommentsIdPin</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /customers/{customerId}/comments/{id}/pin
  &nbsp;&nbsp;&nbsp;&nbsp;Pin a comment to the top
  <br><br>
- <strong>CustomerCommentsService</strong><br>
  &nbsp;&nbsp;* <code>PostCustomersCustomerIdCommentsIdUnpin</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /customers/{customerId}/comments/{id}/unpin
  &nbsp;&nbsp;&nbsp;&nbsp;Remove a pinned comment from the top
  <br><br>
- <strong>CustomersService</strong><br>
  &nbsp;&nbsp;* <code>DeleteCustomersBulk</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /customers/bulk
  &nbsp;&nbsp;&nbsp;&nbsp;Delete multiple customers
  <br><br>
- <strong>CustomersService</strong><br>
  &nbsp;&nbsp;* <code>DeleteCustomersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /customers/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a customer
  <br><br>
- <strong>CustomersService</strong><br>
  &nbsp;&nbsp;* <code>GetCustomers</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /customers
  &nbsp;&nbsp;&nbsp;&nbsp;List all customers
  <br><br>
- <strong>CustomersService</strong><br>
  &nbsp;&nbsp;* <code>GetCustomersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /customers/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a customer
  <br><br>
- <strong>CustomersService</strong><br>
  &nbsp;&nbsp;* <code>GetCustomersIdEmailAddresses</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /customers/{id}/email-addresses
  &nbsp;&nbsp;&nbsp;&nbsp;List a customer&#39;s email addresses
  <br><br>
- <strong>CustomersService</strong><br>
  &nbsp;&nbsp;* <code>GetCustomersSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /customers/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search customers
  <br><br>
- <strong>CustomersService</strong><br>
  &nbsp;&nbsp;* <code>PatchCustomersBulk</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /customers/bulk
  &nbsp;&nbsp;&nbsp;&nbsp;Update multiple customers
  <br><br>
- <strong>CustomersService</strong><br>
  &nbsp;&nbsp;* <code>PatchCustomersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /customers/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a customer
  <br><br>
- <strong>CustomersService</strong><br>
  &nbsp;&nbsp;* <code>PostCustomers</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /customers
  &nbsp;&nbsp;&nbsp;&nbsp;Create a customer
  <br><br>
- <strong>CustomersService</strong><br>
  &nbsp;&nbsp;* <code>PostCustomersBulk</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /customers/bulk
  &nbsp;&nbsp;&nbsp;&nbsp;Create multiple customers
  <br><br>
- <strong>CustomersService</strong><br>
  &nbsp;&nbsp;* <code>PostCustomersIdMergeOther</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /customers/{id}/merge/{other}
  &nbsp;&nbsp;&nbsp;&nbsp;Merge two customers
  <br><br>
- <strong>DebtCollectionCasesService</strong><br>
  &nbsp;&nbsp;* <code>DeleteDebtCollectionCasesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /debt-collection/cases/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a debt collection case
  <br><br>
- <strong>DebtCollectionCasesService</strong><br>
  &nbsp;&nbsp;* <code>GetDebtCollectionCases</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /debt-collection/cases
  &nbsp;&nbsp;&nbsp;&nbsp;List all debt collection cases
  <br><br>
- <strong>DebtCollectionCasesService</strong><br>
  &nbsp;&nbsp;* <code>GetDebtCollectionCasesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /debt-collection/cases/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a debt collection case
  <br><br>
- <strong>DebtCollectionCasesService</strong><br>
  &nbsp;&nbsp;* <code>GetDebtCollectionCasesIdDocuments</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /debt-collection/cases/{id}/documents
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve all documents of a debt collection case
  <br><br>
- <strong>DebtCollectionCasesService</strong><br>
  &nbsp;&nbsp;* <code>GetDebtCollectionCasesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /debt-collection/cases/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search debt collection cases
  <br><br>
- <strong>DebtCollectionCasesService</strong><br>
  &nbsp;&nbsp;* <code>PatchDebtCollectionCasesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /debt-collection/cases/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a debt collection case
  <br><br>
- <strong>DebtCollectionCasesService</strong><br>
  &nbsp;&nbsp;* <code>PostDebtCollectionCases</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /debt-collection/cases
  &nbsp;&nbsp;&nbsp;&nbsp;Create a debt collection case
  <br><br>
- <strong>DebtCollectionCasesService</strong><br>
  &nbsp;&nbsp;* <code>PostDebtCollectionCasesIdClose</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /debt-collection/cases/{id}/close
  &nbsp;&nbsp;&nbsp;&nbsp;Close a debt collection case
  <br><br>
- <strong>DebtCollectionCasesService</strong><br>
  &nbsp;&nbsp;* <code>PostDebtCollectionCasesIdDocuments</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /debt-collection/cases/{id}/documents
  &nbsp;&nbsp;&nbsp;&nbsp;Attach a document to a debt collection case
  <br><br>
- <strong>DebtCollectionCasesService</strong><br>
  &nbsp;&nbsp;* <code>PostDebtCollectionCasesIdMarkPrepared</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /debt-collection/cases/{id}/mark-prepared
  &nbsp;&nbsp;&nbsp;&nbsp;Mark a debt collection case as prepared
  <br><br>
- <strong>DebtCollectionCasesService</strong><br>
  &nbsp;&nbsp;* <code>PostDebtCollectionCasesIdMarkReviewed</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /debt-collection/cases/{id}/mark-reviewed
  &nbsp;&nbsp;&nbsp;&nbsp;Mark a debt collection case as reviewed
  <br><br>
- <strong>DebtCollectionCasesService</strong><br>
  &nbsp;&nbsp;* <code>PostDebtCollectionCasesIdPaymentReceipts</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /debt-collection/cases/{id}/payment-receipts
  &nbsp;&nbsp;&nbsp;&nbsp;Create a payment receipt for a debt collection case
  <br><br>
- <strong>DebtCollectorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>DeleteDebtCollectionConfigurationsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /debt-collection/configurations/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a debt collector configuration
  <br><br>
- <strong>DebtCollectorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>GetDebtCollectionConfigurations</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /debt-collection/configurations
  &nbsp;&nbsp;&nbsp;&nbsp;List all debt collector configurations
  <br><br>
- <strong>DebtCollectorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>GetDebtCollectionConfigurationsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /debt-collection/configurations/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a debt collector configuration
  <br><br>
- <strong>DebtCollectorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>GetDebtCollectionConfigurationsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /debt-collection/configurations/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search debt collector configurations
  <br><br>
- <strong>DebtCollectorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>PatchDebtCollectionConfigurationsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /debt-collection/configurations/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a debt collector configuration
  <br><br>
- <strong>DebtCollectorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>PostDebtCollectionConfigurations</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /debt-collection/configurations
  &nbsp;&nbsp;&nbsp;&nbsp;Create a debt collector configuration
  <br><br>
- <strong>DebtCollectorsService</strong><br>
  &nbsp;&nbsp;* <code>GetDebtCollectionCollectors</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /debt-collection/collectors
  &nbsp;&nbsp;&nbsp;&nbsp;List all debt collectors
  <br><br>
- <strong>DebtCollectorsService</strong><br>
  &nbsp;&nbsp;* <code>GetDebtCollectionCollectorsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /debt-collection/collectors/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a debt collector
  <br><br>
- <strong>DebtCollectorsService</strong><br>
  &nbsp;&nbsp;* <code>GetDebtCollectionCollectorsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /debt-collection/collectors/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search debt collectors
  <br><br>
- <strong>DeliveryIndicationsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentDeliveryIndications</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/delivery-indications
  &nbsp;&nbsp;&nbsp;&nbsp;List all delivery indications
  <br><br>
- <strong>DeliveryIndicationsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentDeliveryIndicationsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/delivery-indications/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a delivery indication
  <br><br>
- <strong>DeliveryIndicationsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentDeliveryIndicationsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/delivery-indications/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search delivery indications
  <br><br>
- <strong>DeliveryIndicationsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentDeliveryIndicationsIdMarkNotSuitable</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/delivery-indications/{id}/mark-not-suitable
  &nbsp;&nbsp;&nbsp;&nbsp;Mark a delivery indication as not suitable.
  <br><br>
- <strong>DeliveryIndicationsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentDeliveryIndicationsIdMarkSuitable</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/delivery-indications/{id}/mark-suitable
  &nbsp;&nbsp;&nbsp;&nbsp;Mark a delivery indication as suitable.
  <br><br>
- <strong>DocumentTemplateTypesService</strong><br>
  &nbsp;&nbsp;* <code>GetDocumentTemplatesTypes</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /document-templates/types
  &nbsp;&nbsp;&nbsp;&nbsp;List all document template types
  <br><br>
- <strong>DocumentTemplateTypesService</strong><br>
  &nbsp;&nbsp;* <code>GetDocumentTemplatesTypesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /document-templates/types/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a document template type
  <br><br>
- <strong>DocumentTemplateTypesService</strong><br>
  &nbsp;&nbsp;* <code>GetDocumentTemplatesTypesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /document-templates/types/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search document template types
  <br><br>
- <strong>DocumentTemplatesService</strong><br>
  &nbsp;&nbsp;* <code>GetDocumentTemplates</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /document-templates
  &nbsp;&nbsp;&nbsp;&nbsp;List all document templates
  <br><br>
- <strong>DocumentTemplatesService</strong><br>
  &nbsp;&nbsp;* <code>GetDocumentTemplatesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /document-templates/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a document template
  <br><br>
- <strong>DocumentTemplatesService</strong><br>
  &nbsp;&nbsp;* <code>GetDocumentTemplatesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /document-templates/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search document templates
  <br><br>
- <strong>DunningCasesService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentDunningCases</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/dunning-cases
  &nbsp;&nbsp;&nbsp;&nbsp;List all dunning cases
  <br><br>
- <strong>DunningCasesService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentDunningCasesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/dunning-cases/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a dunning case
  <br><br>
- <strong>DunningCasesService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentDunningCasesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/dunning-cases/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search dunning cases
  <br><br>
- <strong>DunningCasesService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentDunningCasesIdSuspend</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/dunning-cases/{id}/suspend
  &nbsp;&nbsp;&nbsp;&nbsp;Suspend a dunning case
  <br><br>
- <strong>DunningCasesService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentDunningCasesInvoiceInvoiceId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/dunning-cases/invoice/{invoiceId}
  &nbsp;&nbsp;&nbsp;&nbsp;Create a dunning case for an invoice
  <br><br>
- <strong>DunningFlowLevelsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentDunningFlowsLevels</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/dunning-flows/levels
  &nbsp;&nbsp;&nbsp;&nbsp;List all dunning flow levels
  <br><br>
- <strong>DunningFlowLevelsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentDunningFlowsLevelsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/dunning-flows/levels/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a dunning flow level
  <br><br>
- <strong>DunningFlowLevelsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentDunningFlowsLevelsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/dunning-flows/levels/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search dunning flow levels
  <br><br>
- <strong>DunningFlowsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentDunningFlows</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/dunning-flows
  &nbsp;&nbsp;&nbsp;&nbsp;List all dunning flows
  <br><br>
- <strong>DunningFlowsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentDunningFlowsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/dunning-flows/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a dunning flow
  <br><br>
- <strong>DunningFlowsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentDunningFlowsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/dunning-flows/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search dunning flows
  <br><br>
- <strong>ExpressCheckoutService</strong><br>
  &nbsp;&nbsp;* <code>PostExpressCheckoutCreateSession</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /express-checkout/create-session
  &nbsp;&nbsp;&nbsp;&nbsp;Create a new Express Checkout Session
  <br><br>
- <strong>ExternalTransferBankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsExternalTransfers</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/external-transfers
  &nbsp;&nbsp;&nbsp;&nbsp;List all external transfer bank transactions
  <br><br>
- <strong>ExternalTransferBankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsExternalTransfersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/external-transfers/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve an external transfer bank transaction
  <br><br>
- <strong>ExternalTransferBankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsExternalTransfersSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/external-transfers/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search external transfer bank transactions
  <br><br>
- <strong>HumanUsersService</strong><br>
  &nbsp;&nbsp;* <code>DeleteHumanUsersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /human-users/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a human user
  <br><br>
- <strong>HumanUsersService</strong><br>
  &nbsp;&nbsp;* <code>GetHumanUsers</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /human-users
  &nbsp;&nbsp;&nbsp;&nbsp;List all human users
  <br><br>
- <strong>HumanUsersService</strong><br>
  &nbsp;&nbsp;* <code>GetHumanUsersExport</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /human-users/export
  &nbsp;&nbsp;&nbsp;&nbsp;Export human users
  <br><br>
- <strong>HumanUsersService</strong><br>
  &nbsp;&nbsp;* <code>GetHumanUsersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /human-users/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a human user
  <br><br>
- <strong>HumanUsersService</strong><br>
  &nbsp;&nbsp;* <code>GetHumanUsersSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /human-users/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search human users
  <br><br>
- <strong>HumanUsersService</strong><br>
  &nbsp;&nbsp;* <code>PatchHumanUsersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /human-users/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a human user
  <br><br>
- <strong>HumanUsersService</strong><br>
  &nbsp;&nbsp;* <code>PostHumanUsers</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /human-users
  &nbsp;&nbsp;&nbsp;&nbsp;Create a human user
  <br><br>
- <strong>HumanUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>DeleteHumanUsersUserIdAccountRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /human-users/{userId}/account-roles
  &nbsp;&nbsp;&nbsp;&nbsp;Unassign a role from a human user for an account
  <br><br>
- <strong>HumanUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>DeleteHumanUsersUserIdSpaceRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /human-users/{userId}/space-roles
  &nbsp;&nbsp;&nbsp;&nbsp;Unassign a role from a human user for a space
  <br><br>
- <strong>HumanUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>GetHumanUsersUserIdAccountRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /human-users/{userId}/account-roles
  &nbsp;&nbsp;&nbsp;&nbsp;List all roles of a human user for an account
  <br><br>
- <strong>HumanUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>GetHumanUsersUserIdSpaceRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /human-users/{userId}/space-roles
  &nbsp;&nbsp;&nbsp;&nbsp;List all roles of a human user for a space
  <br><br>
- <strong>HumanUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>PostHumanUsersUserIdAccountRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /human-users/{userId}/account-roles
  &nbsp;&nbsp;&nbsp;&nbsp;Assign a role to a human user for an account
  <br><br>
- <strong>HumanUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>PostHumanUsersUserIdSpaceRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /human-users/{userId}/space-roles
  &nbsp;&nbsp;&nbsp;&nbsp;Assign a role to a human user for a space
  <br><br>
- <strong>InternalTransferBankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsInternalTransfers</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/internal-transfers
  &nbsp;&nbsp;&nbsp;&nbsp;List all internal transfer bank transactions
  <br><br>
- <strong>InternalTransferBankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsInternalTransfersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/internal-transfers/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve an internal transfer bank transaction
  <br><br>
- <strong>InternalTransferBankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsInternalTransfersSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/internal-transfers/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search internal transfer bank transactions
  <br><br>
- <strong>LabelDescriptorsService</strong><br>
  &nbsp;&nbsp;* <code>GetLabelDescriptors</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /label-descriptors
  &nbsp;&nbsp;&nbsp;&nbsp;List all label descriptors
  <br><br>
- <strong>LabelDescriptorsService</strong><br>
  &nbsp;&nbsp;* <code>GetLabelDescriptorsGroups</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /label-descriptors/groups
  &nbsp;&nbsp;&nbsp;&nbsp;List all label descriptor groups
  <br><br>
- <strong>LabelDescriptorsService</strong><br>
  &nbsp;&nbsp;* <code>GetLabelDescriptorsGroupsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /label-descriptors/groups/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a label descriptor group
  <br><br>
- <strong>LabelDescriptorsService</strong><br>
  &nbsp;&nbsp;* <code>GetLabelDescriptorsGroupsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /label-descriptors/groups/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search label descriptor groups
  <br><br>
- <strong>LabelDescriptorsService</strong><br>
  &nbsp;&nbsp;* <code>GetLabelDescriptorsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /label-descriptors/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a label descriptor
  <br><br>
- <strong>LabelDescriptorsService</strong><br>
  &nbsp;&nbsp;* <code>GetLabelDescriptorsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /label-descriptors/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search label descriptors
  <br><br>
- <strong>LanguagesService</strong><br>
  &nbsp;&nbsp;* <code>GetLanguages</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /languages
  &nbsp;&nbsp;&nbsp;&nbsp;List all languages
  <br><br>
- <strong>LanguagesService</strong><br>
  &nbsp;&nbsp;* <code>GetLanguagesCode</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /languages/{code}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a language
  <br><br>
- <strong>LanguagesService</strong><br>
  &nbsp;&nbsp;* <code>GetLanguagesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /languages/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search languages
  <br><br>
- <strong>LegalOrganizationFormsService</strong><br>
  &nbsp;&nbsp;* <code>GetLegalOrganizationForms</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /legal-organization-forms
  &nbsp;&nbsp;&nbsp;&nbsp;List all legal organization forms
  <br><br>
- <strong>LegalOrganizationFormsService</strong><br>
  &nbsp;&nbsp;* <code>GetLegalOrganizationFormsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /legal-organization-forms/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a legal organization form
  <br><br>
- <strong>LegalOrganizationFormsService</strong><br>
  &nbsp;&nbsp;* <code>GetLegalOrganizationFormsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /legal-organization-forms/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search legal organization forms
  <br><br>
- <strong>ManualTasksService</strong><br>
  &nbsp;&nbsp;* <code>GetManualTasks</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /manual-tasks
  &nbsp;&nbsp;&nbsp;&nbsp;List all manual tasks
  <br><br>
- <strong>ManualTasksService</strong><br>
  &nbsp;&nbsp;* <code>GetManualTasksId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /manual-tasks/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a manual task
  <br><br>
- <strong>ManualTasksService</strong><br>
  &nbsp;&nbsp;* <code>GetManualTasksIdNotification</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /manual-tasks/{id}/notification
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a manual task&#39;s notification message
  <br><br>
- <strong>ManualTasksService</strong><br>
  &nbsp;&nbsp;* <code>GetManualTasksSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /manual-tasks/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search manual tasks
  <br><br>
- <strong>ManualTasksService</strong><br>
  &nbsp;&nbsp;* <code>PostManualTasksIdActionActionId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /manual-tasks/{id}/action/{actionId}
  &nbsp;&nbsp;&nbsp;&nbsp;Process a manual task&#39;s action
  <br><br>
- <strong>PaymentConnectorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>DeletePaymentConnectorConfigurationsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /payment/connector-configurations/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a payment connector configuration
  <br><br>
- <strong>PaymentConnectorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentConnectorConfigurations</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/connector-configurations
  &nbsp;&nbsp;&nbsp;&nbsp;List all payment connector configurations
  <br><br>
- <strong>PaymentConnectorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentConnectorConfigurationsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/connector-configurations/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a payment connector configuration
  <br><br>
- <strong>PaymentConnectorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentConnectorConfigurationsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/connector-configurations/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search payment connector configurations
  <br><br>
- <strong>PaymentConnectorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>PatchPaymentConnectorConfigurationsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /payment/connector-configurations/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a payment connector configuration
  <br><br>
- <strong>PaymentConnectorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentConnectorConfigurations</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/connector-configurations
  &nbsp;&nbsp;&nbsp;&nbsp;Create a payment connector configuration
  <br><br>
- <strong>PaymentConnectorsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentConnectors</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/connectors
  &nbsp;&nbsp;&nbsp;&nbsp;List all payment connectors.
  <br><br>
- <strong>PaymentConnectorsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentConnectorsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/connectors/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a payment connector.
  <br><br>
- <strong>PaymentConnectorsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentConnectorsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/connectors/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search payment connectors.
  <br><br>
- <strong>PaymentLinksService</strong><br>
  &nbsp;&nbsp;* <code>DeletePaymentLinksId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /payment/links/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a payment link
  <br><br>
- <strong>PaymentLinksService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentLinks</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/links
  &nbsp;&nbsp;&nbsp;&nbsp;List all payment links
  <br><br>
- <strong>PaymentLinksService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentLinksId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/links/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a payment link
  <br><br>
- <strong>PaymentLinksService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentLinksSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/links/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search payment links
  <br><br>
- <strong>PaymentLinksService</strong><br>
  &nbsp;&nbsp;* <code>PatchPaymentLinksId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /payment/links/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a payment link
  <br><br>
- <strong>PaymentLinksService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentLinks</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/links
  &nbsp;&nbsp;&nbsp;&nbsp;Create a payment link
  <br><br>
- <strong>PaymentMethodBrandsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentMethodBrands</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/method-brands
  &nbsp;&nbsp;&nbsp;&nbsp;List all payment method brands.
  <br><br>
- <strong>PaymentMethodBrandsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentMethodBrandsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/method-brands/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a payment method brand.
  <br><br>
- <strong>PaymentMethodBrandsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentMethodBrandsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/method-brands/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search payment method brands.
  <br><br>
- <strong>PaymentMethodConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>DeletePaymentMethodConfigurationsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /payment/method-configurations/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a payment method configuration
  <br><br>
- <strong>PaymentMethodConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentMethodConfigurations</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/method-configurations
  &nbsp;&nbsp;&nbsp;&nbsp;List all payment method configurations
  <br><br>
- <strong>PaymentMethodConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentMethodConfigurationsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/method-configurations/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a payment method configuration
  <br><br>
- <strong>PaymentMethodConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentMethodConfigurationsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/method-configurations/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search payment method configurations
  <br><br>
- <strong>PaymentMethodConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>PatchPaymentMethodConfigurationsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /payment/method-configurations/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a payment method configuration
  <br><br>
- <strong>PaymentMethodConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentMethodConfigurations</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/method-configurations
  &nbsp;&nbsp;&nbsp;&nbsp;Create a payment method configuration
  <br><br>
- <strong>PaymentMethodsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentMethods</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/methods
  &nbsp;&nbsp;&nbsp;&nbsp;List all payment methods.
  <br><br>
- <strong>PaymentMethodsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentMethodsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/methods/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a payment method.
  <br><br>
- <strong>PaymentMethodsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentMethodsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/methods/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search payment methods.
  <br><br>
- <strong>PaymentProcessorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>DeletePaymentProcessorConfigurationsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /payment/processor-configurations/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a payment processor configuration
  <br><br>
- <strong>PaymentProcessorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentProcessorConfigurations</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/processor-configurations
  &nbsp;&nbsp;&nbsp;&nbsp;List all payment processor configurations
  <br><br>
- <strong>PaymentProcessorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentProcessorConfigurationsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/processor-configurations/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a payment processor configuration
  <br><br>
- <strong>PaymentProcessorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentProcessorConfigurationsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/processor-configurations/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search payment processor configurations
  <br><br>
- <strong>PaymentProcessorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>PatchPaymentProcessorConfigurationsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /payment/processor-configurations/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a payment processor configuration
  <br><br>
- <strong>PaymentProcessorConfigurationsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentProcessorConfigurations</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/processor-configurations
  &nbsp;&nbsp;&nbsp;&nbsp;Create a payment processor configuration
  <br><br>
- <strong>PaymentProcessorsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentProcessors</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/processors
  &nbsp;&nbsp;&nbsp;&nbsp;List all payment processors.
  <br><br>
- <strong>PaymentProcessorsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentProcessorsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/processors/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a payment processor.
  <br><br>
- <strong>PaymentProcessorsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentProcessorsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/processors/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search payment processors.
  <br><br>
- <strong>PaymentSalesChannelsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentSalesChannels</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/sales-channels
  &nbsp;&nbsp;&nbsp;&nbsp;List all payment sales channels.
  <br><br>
- <strong>PaymentSalesChannelsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentSalesChannelsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/sales-channels/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a payment sales channel.
  <br><br>
- <strong>PaymentSalesChannelsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentSalesChannelsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/sales-channels/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search payment sales channels.
  <br><br>
- <strong>PaymentTerminalTransactionSummariesService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTerminalsTransactionSummaries</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/terminals/transaction-summaries
  &nbsp;&nbsp;&nbsp;&nbsp;List all summaries
  <br><br>
- <strong>PaymentTerminalTransactionSummariesService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTerminalsTransactionSummariesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/terminals/transaction-summaries/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a summary
  <br><br>
- <strong>PaymentTerminalTransactionSummariesService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTerminalsTransactionSummariesIdReceipt</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/terminals/transaction-summaries/{id}/receipt
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a rendered summary receipt
  <br><br>
- <strong>PaymentTerminalTransactionSummariesService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTerminalsTransactionSummariesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/terminals/transaction-summaries/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search summaries
  <br><br>
- <strong>PaymentTerminalsService</strong><br>
  &nbsp;&nbsp;* <code>DeletePaymentTerminalsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /payment/terminals/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a payment terminal
  <br><br>
- <strong>PaymentTerminalsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTerminals</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/terminals
  &nbsp;&nbsp;&nbsp;&nbsp;List all payment terminals
  <br><br>
- <strong>PaymentTerminalsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTerminalsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/terminals/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a payment terminal
  <br><br>
- <strong>PaymentTerminalsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTerminalsIdTillConnectionCredentials</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/terminals/{id}/till-connection-credentials
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve till connection credentials
  <br><br>
- <strong>PaymentTerminalsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTerminalsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/terminals/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search payment terminals
  <br><br>
- <strong>PaymentTerminalsService</strong><br>
  &nbsp;&nbsp;* <code>PatchPaymentTerminalsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /payment/terminals/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a payment terminal
  <br><br>
- <strong>PaymentTerminalsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTerminals</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/terminals
  &nbsp;&nbsp;&nbsp;&nbsp;Create a payment terminal
  <br><br>
- <strong>PaymentTerminalsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTerminalsByIdentifierIdentifierPerformTransaction</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/terminals/by-identifier/{identifier}/perform-transaction
  &nbsp;&nbsp;&nbsp;&nbsp;Perform a payment terminal transaction by identifier
  <br><br>
- <strong>PaymentTerminalsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTerminalsByIdentifierIdentifierTriggerFinalBalance</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/terminals/by-identifier/{identifier}/trigger-final-balance
  &nbsp;&nbsp;&nbsp;&nbsp;Remotely trigger the final balance by identifier
  <br><br>
- <strong>PaymentTerminalsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTerminalsIdLink</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/terminals/{id}/link
  &nbsp;&nbsp;&nbsp;&nbsp;Link a device with a payment terminal
  <br><br>
- <strong>PaymentTerminalsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTerminalsIdPerformTransaction</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/terminals/{id}/perform-transaction
  &nbsp;&nbsp;&nbsp;&nbsp;Perform a payment terminal transaction
  <br><br>
- <strong>PaymentTerminalsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTerminalsIdTriggerFinalBalance</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/terminals/{id}/trigger-final-balance
  &nbsp;&nbsp;&nbsp;&nbsp;Remotely trigger the final balance
  <br><br>
- <strong>PaymentTerminalsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTerminalsIdUnlink</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/terminals/{id}/unlink
  &nbsp;&nbsp;&nbsp;&nbsp;Unlink any device from a payment terminal
  <br><br>
- <strong>PaymentWebAppsService</strong><br>
  &nbsp;&nbsp;* <code>DeletePaymentWebAppsConnectorsConnectorExternalId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /payment/web-apps/connectors/{connectorExternalId}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a connector
  <br><br>
- <strong>PaymentWebAppsService</strong><br>
  &nbsp;&nbsp;* <code>DeletePaymentWebAppsProcessorsExternalId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /payment/web-apps/processors/{externalId}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a processor
  <br><br>
- <strong>PaymentWebAppsService</strong><br>
  &nbsp;&nbsp;* <code>PatchPaymentWebAppsChargeAttemptsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /payment/web-apps/charge-attempts/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a charge attempt
  <br><br>
- <strong>PaymentWebAppsService</strong><br>
  &nbsp;&nbsp;* <code>PatchPaymentWebAppsCompletionsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /payment/web-apps/completions/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a completion
  <br><br>
- <strong>PaymentWebAppsService</strong><br>
  &nbsp;&nbsp;* <code>PatchPaymentWebAppsConnectorsConnectorExternalId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /payment/web-apps/connectors/{connectorExternalId}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a connector
  <br><br>
- <strong>PaymentWebAppsService</strong><br>
  &nbsp;&nbsp;* <code>PatchPaymentWebAppsProcessorsExternalId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /payment/web-apps/processors/{externalId}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a processor
  <br><br>
- <strong>PaymentWebAppsService</strong><br>
  &nbsp;&nbsp;* <code>PatchPaymentWebAppsRefundsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /payment/web-apps/refunds/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a refund
  <br><br>
- <strong>PaymentWebAppsService</strong><br>
  &nbsp;&nbsp;* <code>PatchPaymentWebAppsVoidsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /payment/web-apps/voids/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a void
  <br><br>
- <strong>PaymentWebAppsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentWebAppsProcessors</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/web-apps/processors
  &nbsp;&nbsp;&nbsp;&nbsp;Create a processor
  <br><br>
- <strong>PaymentWebAppsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentWebAppsProcessorsExternalIdActivateForProduction</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/web-apps/processors/{externalId}/activate-for-production
  &nbsp;&nbsp;&nbsp;&nbsp;Activate a processor for production
  <br><br>
- <strong>PaymentWebAppsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentWebAppsProcessorsExternalIdConnectors</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/web-apps/processors/{externalId}/connectors
  &nbsp;&nbsp;&nbsp;&nbsp;Create a connector
  <br><br>
- <strong>PermissionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPermissions</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /permissions
  &nbsp;&nbsp;&nbsp;&nbsp;List all permissions
  <br><br>
- <strong>PermissionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPermissionsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /permissions/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a permission
  <br><br>
- <strong>PermissionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPermissionsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /permissions/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search permissions
  <br><br>
- <strong>RefundBankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsRefunds</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/refunds
  &nbsp;&nbsp;&nbsp;&nbsp;List all refund bank transactions
  <br><br>
- <strong>RefundBankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsRefundsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/refunds/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a refund bank transaction
  <br><br>
- <strong>RefundBankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsRefundsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/refunds/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search refund bank transactions
  <br><br>
- <strong>RefundCommentsService</strong><br>
  &nbsp;&nbsp;* <code>DeletePaymentRefundsRefundIdCommentsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /payment/refunds/{refundId}/comments/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a refund comment
  <br><br>
- <strong>RefundCommentsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentRefundsRefundIdComments</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/refunds/{refundId}/comments
  &nbsp;&nbsp;&nbsp;&nbsp;List all refund comments
  <br><br>
- <strong>RefundCommentsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentRefundsRefundIdCommentsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/refunds/{refundId}/comments/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a refund comment
  <br><br>
- <strong>RefundCommentsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentRefundsRefundIdCommentsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/refunds/{refundId}/comments/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search refund comments
  <br><br>
- <strong>RefundCommentsService</strong><br>
  &nbsp;&nbsp;* <code>PatchPaymentRefundsRefundIdCommentsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /payment/refunds/{refundId}/comments/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a refund comment
  <br><br>
- <strong>RefundCommentsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentRefundsRefundIdComments</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/refunds/{refundId}/comments
  &nbsp;&nbsp;&nbsp;&nbsp;Create a refund comment
  <br><br>
- <strong>RefundCommentsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentRefundsRefundIdCommentsIdPin</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/refunds/{refundId}/comments/{id}/pin
  &nbsp;&nbsp;&nbsp;&nbsp;Pin a comment to the top
  <br><br>
- <strong>RefundCommentsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentRefundsRefundIdCommentsIdUnpin</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/refunds/{refundId}/comments/{id}/unpin
  &nbsp;&nbsp;&nbsp;&nbsp;Remove the pinned comment from the top
  <br><br>
- <strong>RefundRecoveryBankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsRefundRecoveries</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/refund-recoveries
  &nbsp;&nbsp;&nbsp;&nbsp;List all refund recovery bank transactions
  <br><br>
- <strong>RefundRecoveryBankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsRefundRecoveriesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/refund-recoveries/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a refund recovery bank transaction
  <br><br>
- <strong>RefundRecoveryBankTransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentBankTransactionsRefundRecoveriesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/bank-transactions/refund-recoveries/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search refund recovery bank transactions
  <br><br>
- <strong>RefundsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentRefunds</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/refunds
  &nbsp;&nbsp;&nbsp;&nbsp;List all refunds
  <br><br>
- <strong>RefundsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentRefundsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/refunds/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a refund
  <br><br>
- <strong>RefundsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentRefundsIdDocument</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/refunds/{id}/document
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a refund document
  <br><br>
- <strong>RefundsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentRefundsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/refunds/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search refunds
  <br><br>
- <strong>RefundsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentRefunds</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/refunds
  &nbsp;&nbsp;&nbsp;&nbsp;Create a refund
  <br><br>
- <strong>RefundsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentRefundsIdMarkFailed</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/refunds/{id}/mark-failed
  &nbsp;&nbsp;&nbsp;&nbsp;Mark a refund as failed
  <br><br>
- <strong>RefundsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentRefundsIdMarkSucceeded</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/refunds/{id}/mark-succeeded
  &nbsp;&nbsp;&nbsp;&nbsp;Mark a refund as successful
  <br><br>
- <strong>RolesService</strong><br>
  &nbsp;&nbsp;* <code>DeleteRolesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /roles/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a role
  <br><br>
- <strong>RolesService</strong><br>
  &nbsp;&nbsp;* <code>GetRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /roles
  &nbsp;&nbsp;&nbsp;&nbsp;List all roles
  <br><br>
- <strong>RolesService</strong><br>
  &nbsp;&nbsp;* <code>GetRolesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /roles/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a role
  <br><br>
- <strong>RolesService</strong><br>
  &nbsp;&nbsp;* <code>GetRolesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /roles/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search roles
  <br><br>
- <strong>RolesService</strong><br>
  &nbsp;&nbsp;* <code>PatchRolesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /roles/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a role
  <br><br>
- <strong>RolesService</strong><br>
  &nbsp;&nbsp;* <code>PostRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /roles
  &nbsp;&nbsp;&nbsp;&nbsp;Create a role
  <br><br>
- <strong>SingleSignOnUsersService</strong><br>
  &nbsp;&nbsp;* <code>DeleteSingleSignOnUsersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /single-sign-on-users/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a single sign-on user
  <br><br>
- <strong>SingleSignOnUsersService</strong><br>
  &nbsp;&nbsp;* <code>GetSingleSignOnUsers</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /single-sign-on-users
  &nbsp;&nbsp;&nbsp;&nbsp;List all single sign-on users
  <br><br>
- <strong>SingleSignOnUsersService</strong><br>
  &nbsp;&nbsp;* <code>GetSingleSignOnUsersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /single-sign-on-users/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a single sign-on user
  <br><br>
- <strong>SingleSignOnUsersService</strong><br>
  &nbsp;&nbsp;* <code>GetSingleSignOnUsersSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /single-sign-on-users/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search single sign-on users
  <br><br>
- <strong>SingleSignOnUsersService</strong><br>
  &nbsp;&nbsp;* <code>PatchSingleSignOnUsersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /single-sign-on-users/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a single sign-on user
  <br><br>
- <strong>SingleSignOnUsersService</strong><br>
  &nbsp;&nbsp;* <code>PostSingleSignOnUsers</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /single-sign-on-users
  &nbsp;&nbsp;&nbsp;&nbsp;Create a single sign-on user
  <br><br>
- <strong>SingleSignOnUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>DeleteSingleSignOnUsersUserIdAccountRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /single-sign-on-users/{userId}/account-roles
  &nbsp;&nbsp;&nbsp;&nbsp;Unassign a role from a single sign-on user for an account
  <br><br>
- <strong>SingleSignOnUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>DeleteSingleSignOnUsersUserIdSpaceRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /single-sign-on-users/{userId}/space-roles
  &nbsp;&nbsp;&nbsp;&nbsp;Unassign a role from a single sign-on user for a space
  <br><br>
- <strong>SingleSignOnUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>GetSingleSignOnUsersUserIdAccountRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /single-sign-on-users/{userId}/account-roles
  &nbsp;&nbsp;&nbsp;&nbsp;List all roles of a single sign-on user for an account
  <br><br>
- <strong>SingleSignOnUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>GetSingleSignOnUsersUserIdSpaceRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /single-sign-on-users/{userId}/space-roles
  &nbsp;&nbsp;&nbsp;&nbsp;List all roles of a single sign-on user for a space
  <br><br>
- <strong>SingleSignOnUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>PostSingleSignOnUsersUserIdAccountRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /single-sign-on-users/{userId}/account-roles
  &nbsp;&nbsp;&nbsp;&nbsp;Assign a role to a single sign-on user for an account
  <br><br>
- <strong>SingleSignOnUsersRolesService</strong><br>
  &nbsp;&nbsp;* <code>PostSingleSignOnUsersUserIdSpaceRoles</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /single-sign-on-users/{userId}/space-roles
  &nbsp;&nbsp;&nbsp;&nbsp;Assign a role to a single sign-on user for a space
  <br><br>
- <strong>SpacesService</strong><br>
  &nbsp;&nbsp;* <code>DeleteSpacesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /spaces/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a space
  <br><br>
- <strong>SpacesService</strong><br>
  &nbsp;&nbsp;* <code>GetSpaces</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /spaces
  &nbsp;&nbsp;&nbsp;&nbsp;List all spaces
  <br><br>
- <strong>SpacesService</strong><br>
  &nbsp;&nbsp;* <code>GetSpacesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /spaces/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a space
  <br><br>
- <strong>SpacesService</strong><br>
  &nbsp;&nbsp;* <code>GetSpacesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /spaces/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search spaces
  <br><br>
- <strong>SpacesService</strong><br>
  &nbsp;&nbsp;* <code>PatchSpacesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /spaces/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a space
  <br><br>
- <strong>SpacesService</strong><br>
  &nbsp;&nbsp;* <code>PostSpaces</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /spaces
  &nbsp;&nbsp;&nbsp;&nbsp;Create a space
  <br><br>
- <strong>StaticValuesService</strong><br>
  &nbsp;&nbsp;* <code>GetStaticValues</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /static-values
  &nbsp;&nbsp;&nbsp;&nbsp;List all static values
  <br><br>
- <strong>StaticValuesService</strong><br>
  &nbsp;&nbsp;* <code>GetStaticValuesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /static-values/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a static value
  <br><br>
- <strong>StaticValuesService</strong><br>
  &nbsp;&nbsp;* <code>GetStaticValuesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /static-values/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search static values
  <br><br>
- <strong>SubscribersService</strong><br>
  &nbsp;&nbsp;* <code>DeleteSubscriptionsSubscribersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /subscriptions/subscribers/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a subscriber
  <br><br>
- <strong>SubscribersService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsSubscribers</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/subscribers
  &nbsp;&nbsp;&nbsp;&nbsp;List all subscribers
  <br><br>
- <strong>SubscribersService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsSubscribersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/subscribers/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a subscriber
  <br><br>
- <strong>SubscribersService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsSubscribersSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/subscribers/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search subscribers
  <br><br>
- <strong>SubscribersService</strong><br>
  &nbsp;&nbsp;* <code>PatchSubscriptionsSubscribersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /subscriptions/subscribers/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a subscriber
  <br><br>
- <strong>SubscribersService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsSubscribers</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/subscribers
  &nbsp;&nbsp;&nbsp;&nbsp;Create a subscriber
  <br><br>
- <strong>SubscriptionAffiliatesService</strong><br>
  &nbsp;&nbsp;* <code>DeleteSubscriptionsAffiliatesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /subscriptions/affiliates/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete an affiliate
  <br><br>
- <strong>SubscriptionAffiliatesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsAffiliates</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/affiliates
  &nbsp;&nbsp;&nbsp;&nbsp;List all affiliates
  <br><br>
- <strong>SubscriptionAffiliatesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsAffiliatesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/affiliates/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve an affiliate
  <br><br>
- <strong>SubscriptionAffiliatesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsAffiliatesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/affiliates/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search affiliates
  <br><br>
- <strong>SubscriptionAffiliatesService</strong><br>
  &nbsp;&nbsp;* <code>PatchSubscriptionsAffiliatesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /subscriptions/affiliates/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update an affiliate
  <br><br>
- <strong>SubscriptionAffiliatesService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsAffiliates</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/affiliates
  &nbsp;&nbsp;&nbsp;&nbsp;Create an affiliate
  <br><br>
- <strong>SubscriptionChargesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsCharges</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/charges
  &nbsp;&nbsp;&nbsp;&nbsp;List all charges
  <br><br>
- <strong>SubscriptionChargesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsChargesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/charges/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a charge
  <br><br>
- <strong>SubscriptionChargesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsChargesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/charges/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search charges
  <br><br>
- <strong>SubscriptionChargesService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsCharges</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/charges
  &nbsp;&nbsp;&nbsp;&nbsp;Create a charge
  <br><br>
- <strong>SubscriptionChargesService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsChargesIdDiscard</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/charges/{id}/discard
  &nbsp;&nbsp;&nbsp;&nbsp;Discard a charge
  <br><br>
- <strong>SubscriptionLedgerEntriesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsLedgerEntries</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/ledger-entries
  &nbsp;&nbsp;&nbsp;&nbsp;List all ledger entries
  <br><br>
- <strong>SubscriptionLedgerEntriesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsLedgerEntriesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/ledger-entries/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a ledger entry
  <br><br>
- <strong>SubscriptionLedgerEntriesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsLedgerEntriesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/ledger-entries/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search ledger entries
  <br><br>
- <strong>SubscriptionLedgerEntriesService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsLedgerEntries</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/ledger-entries
  &nbsp;&nbsp;&nbsp;&nbsp;Create a ledger entry
  <br><br>
- <strong>SubscriptionMetricUsageReportsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsMetricUsageReports</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/metric-usage-reports
  &nbsp;&nbsp;&nbsp;&nbsp;List all metric usage reports
  <br><br>
- <strong>SubscriptionMetricUsageReportsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsMetricUsageReportsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/metric-usage-reports/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a metric usage report
  <br><br>
- <strong>SubscriptionMetricUsageReportsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsMetricUsageReportsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/metric-usage-reports/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search metric usage reports
  <br><br>
- <strong>SubscriptionMetricUsageReportsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsMetricUsageReports</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/metric-usage-reports
  &nbsp;&nbsp;&nbsp;&nbsp;Create a metric usage report
  <br><br>
- <strong>SubscriptionMetricsService</strong><br>
  &nbsp;&nbsp;* <code>DeleteSubscriptionsMetricsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /subscriptions/metrics/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a metric
  <br><br>
- <strong>SubscriptionMetricsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsMetrics</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/metrics
  &nbsp;&nbsp;&nbsp;&nbsp;List all metrics
  <br><br>
- <strong>SubscriptionMetricsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsMetricsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/metrics/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a metric
  <br><br>
- <strong>SubscriptionMetricsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsMetricsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/metrics/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search metrics
  <br><br>
- <strong>SubscriptionMetricsService</strong><br>
  &nbsp;&nbsp;* <code>PatchSubscriptionsMetricsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /subscriptions/metrics/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a metric
  <br><br>
- <strong>SubscriptionMetricsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsMetrics</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/metrics
  &nbsp;&nbsp;&nbsp;&nbsp;Create a metric
  <br><br>
- <strong>SubscriptionPeriodBillsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsPeriodBills</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/period-bills
  &nbsp;&nbsp;&nbsp;&nbsp;List all subscription period bills
  <br><br>
- <strong>SubscriptionPeriodBillsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsPeriodBillsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/period-bills/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a subscription period bill
  <br><br>
- <strong>SubscriptionPeriodBillsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsPeriodBillsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/period-bills/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search subscription period bills
  <br><br>
- <strong>SubscriptionPeriodBillsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsPeriodBillsIdClose</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/period-bills/{id}/close
  &nbsp;&nbsp;&nbsp;&nbsp;Close a subscription period bill
  <br><br>
- <strong>SubscriptionProductComponentGroupsService</strong><br>
  &nbsp;&nbsp;* <code>DeleteSubscriptionsProductsComponentGroupsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /subscriptions/products/component-groups/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a component group
  <br><br>
- <strong>SubscriptionProductComponentGroupsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsComponentGroups</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/component-groups
  &nbsp;&nbsp;&nbsp;&nbsp;List all component groups
  <br><br>
- <strong>SubscriptionProductComponentGroupsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsComponentGroupsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/component-groups/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a component group
  <br><br>
- <strong>SubscriptionProductComponentGroupsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsComponentGroupsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/component-groups/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search component groups
  <br><br>
- <strong>SubscriptionProductComponentGroupsService</strong><br>
  &nbsp;&nbsp;* <code>PatchSubscriptionsProductsComponentGroupsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /subscriptions/products/component-groups/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a component group
  <br><br>
- <strong>SubscriptionProductComponentGroupsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsProductsComponentGroups</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/products/component-groups
  &nbsp;&nbsp;&nbsp;&nbsp;Create a component group
  <br><br>
- <strong>SubscriptionProductComponentsService</strong><br>
  &nbsp;&nbsp;* <code>DeleteSubscriptionsProductsComponentsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /subscriptions/products/components/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a component
  <br><br>
- <strong>SubscriptionProductComponentsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsComponents</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/components
  &nbsp;&nbsp;&nbsp;&nbsp;List all components
  <br><br>
- <strong>SubscriptionProductComponentsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsComponentsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/components/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a component
  <br><br>
- <strong>SubscriptionProductComponentsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsComponentsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/components/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search components
  <br><br>
- <strong>SubscriptionProductComponentsService</strong><br>
  &nbsp;&nbsp;* <code>PatchSubscriptionsProductsComponentsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /subscriptions/products/components/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a component
  <br><br>
- <strong>SubscriptionProductComponentsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsProductsComponents</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/products/components
  &nbsp;&nbsp;&nbsp;&nbsp;Create a component
  <br><br>
- <strong>SubscriptionProductMeteredFeeTiersService</strong><br>
  &nbsp;&nbsp;* <code>DeleteSubscriptionsProductsMeteredFeesFeeIdTiersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /subscriptions/products/metered-fees/{feeId}/tiers/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a metered fee tier
  <br><br>
- <strong>SubscriptionProductMeteredFeeTiersService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsMeteredFeesFeeIdTiers</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/metered-fees/{feeId}/tiers
  &nbsp;&nbsp;&nbsp;&nbsp;List all metered fee tiers
  <br><br>
- <strong>SubscriptionProductMeteredFeeTiersService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsMeteredFeesFeeIdTiersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/metered-fees/{feeId}/tiers/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a metered fee tier
  <br><br>
- <strong>SubscriptionProductMeteredFeeTiersService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsMeteredFeesFeeIdTiersSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/metered-fees/{feeId}/tiers/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search metered fee tiers
  <br><br>
- <strong>SubscriptionProductMeteredFeeTiersService</strong><br>
  &nbsp;&nbsp;* <code>PatchSubscriptionsProductsMeteredFeesFeeIdTiersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /subscriptions/products/metered-fees/{feeId}/tiers/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a metered fee tier
  <br><br>
- <strong>SubscriptionProductMeteredFeeTiersService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsProductsMeteredFeesFeeIdTiers</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/products/metered-fees/{feeId}/tiers
  &nbsp;&nbsp;&nbsp;&nbsp;Create a metered fee tier
  <br><br>
- <strong>SubscriptionProductMeteredFeesService</strong><br>
  &nbsp;&nbsp;* <code>DeleteSubscriptionsProductsMeteredFeesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /subscriptions/products/metered-fees/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a metered fee
  <br><br>
- <strong>SubscriptionProductMeteredFeesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsMeteredFees</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/metered-fees
  &nbsp;&nbsp;&nbsp;&nbsp;List all metered fees
  <br><br>
- <strong>SubscriptionProductMeteredFeesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsMeteredFeesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/metered-fees/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a metered fee
  <br><br>
- <strong>SubscriptionProductMeteredFeesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsMeteredFeesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/metered-fees/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search metered fees
  <br><br>
- <strong>SubscriptionProductMeteredFeesService</strong><br>
  &nbsp;&nbsp;* <code>PatchSubscriptionsProductsMeteredFeesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /subscriptions/products/metered-fees/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a metered fee
  <br><br>
- <strong>SubscriptionProductMeteredFeesService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsProductsMeteredFees</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/products/metered-fees
  &nbsp;&nbsp;&nbsp;&nbsp;Create a metered fee
  <br><br>
- <strong>SubscriptionProductPeriodFeesService</strong><br>
  &nbsp;&nbsp;* <code>DeleteSubscriptionsProductsPeriodFeesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /subscriptions/products/period-fees/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a period fee
  <br><br>
- <strong>SubscriptionProductPeriodFeesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsPeriodFees</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/period-fees
  &nbsp;&nbsp;&nbsp;&nbsp;List all period fees
  <br><br>
- <strong>SubscriptionProductPeriodFeesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsPeriodFeesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/period-fees/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a period fee
  <br><br>
- <strong>SubscriptionProductPeriodFeesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsPeriodFeesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/period-fees/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search period fees
  <br><br>
- <strong>SubscriptionProductPeriodFeesService</strong><br>
  &nbsp;&nbsp;* <code>PatchSubscriptionsProductsPeriodFeesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /subscriptions/products/period-fees/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a period fee
  <br><br>
- <strong>SubscriptionProductPeriodFeesService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsProductsPeriodFees</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/products/period-fees
  &nbsp;&nbsp;&nbsp;&nbsp;Create a period fee
  <br><br>
- <strong>SubscriptionProductRetirementsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsRetirements</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/retirements
  &nbsp;&nbsp;&nbsp;&nbsp;List all product retirements
  <br><br>
- <strong>SubscriptionProductRetirementsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsRetirementsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/retirements/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a product retirement
  <br><br>
- <strong>SubscriptionProductRetirementsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsRetirementsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/retirements/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search product retirements
  <br><br>
- <strong>SubscriptionProductSetupFeesService</strong><br>
  &nbsp;&nbsp;* <code>DeleteSubscriptionsProductsSetupFeesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /subscriptions/products/setup-fees/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a setup fee
  <br><br>
- <strong>SubscriptionProductSetupFeesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsSetupFees</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/setup-fees
  &nbsp;&nbsp;&nbsp;&nbsp;List all setup fees
  <br><br>
- <strong>SubscriptionProductSetupFeesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsSetupFeesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/setup-fees/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a setup fee
  <br><br>
- <strong>SubscriptionProductSetupFeesService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsSetupFeesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/setup-fees/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search setup fees
  <br><br>
- <strong>SubscriptionProductSetupFeesService</strong><br>
  &nbsp;&nbsp;* <code>PatchSubscriptionsProductsSetupFeesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /subscriptions/products/setup-fees/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a setup fee
  <br><br>
- <strong>SubscriptionProductSetupFeesService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsProductsSetupFees</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/products/setup-fees
  &nbsp;&nbsp;&nbsp;&nbsp;Create a setup fee
  <br><br>
- <strong>SubscriptionProductVersionRetirementsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsVersionsRetirements</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/versions/retirements
  &nbsp;&nbsp;&nbsp;&nbsp;List all product version retirements
  <br><br>
- <strong>SubscriptionProductVersionRetirementsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsVersionsRetirementsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/versions/retirements/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a product version retirement
  <br><br>
- <strong>SubscriptionProductVersionRetirementsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsVersionsRetirementsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/versions/retirements/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search product version retirements
  <br><br>
- <strong>SubscriptionProductVersionsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsVersions</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/versions
  &nbsp;&nbsp;&nbsp;&nbsp;List all product versions
  <br><br>
- <strong>SubscriptionProductVersionsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsVersionsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/versions/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a product version
  <br><br>
- <strong>SubscriptionProductVersionsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsVersionsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/versions/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search product versions
  <br><br>
- <strong>SubscriptionProductVersionsService</strong><br>
  &nbsp;&nbsp;* <code>PatchSubscriptionsProductsVersionsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /subscriptions/products/versions/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a product version
  <br><br>
- <strong>SubscriptionProductVersionsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsProductsVersions</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/products/versions
  &nbsp;&nbsp;&nbsp;&nbsp;Create a product version
  <br><br>
- <strong>SubscriptionProductVersionsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsProductsVersionsIdActivate</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/products/versions/{id}/activate
  &nbsp;&nbsp;&nbsp;&nbsp;Activate a product version
  <br><br>
- <strong>SubscriptionProductVersionsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsProductsVersionsIdRetire</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/products/versions/{id}/retire
  &nbsp;&nbsp;&nbsp;&nbsp;Retire a product version
  <br><br>
- <strong>SubscriptionProductsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProducts</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products
  &nbsp;&nbsp;&nbsp;&nbsp;List all products
  <br><br>
- <strong>SubscriptionProductsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a product
  <br><br>
- <strong>SubscriptionProductsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsProductsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/products/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search products
  <br><br>
- <strong>SubscriptionProductsService</strong><br>
  &nbsp;&nbsp;* <code>PatchSubscriptionsProductsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /subscriptions/products/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a product
  <br><br>
- <strong>SubscriptionProductsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsProducts</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/products
  &nbsp;&nbsp;&nbsp;&nbsp;Create a product
  <br><br>
- <strong>SubscriptionProductsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsProductsIdRetire</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/products/{id}/retire
  &nbsp;&nbsp;&nbsp;&nbsp;Retire a product
  <br><br>
- <strong>SubscriptionSuspensionsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsSuspensions</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/suspensions
  &nbsp;&nbsp;&nbsp;&nbsp;List all suspensions
  <br><br>
- <strong>SubscriptionSuspensionsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsSuspensionsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/suspensions/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a suspension
  <br><br>
- <strong>SubscriptionSuspensionsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsSuspensionsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/suspensions/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search suspensions
  <br><br>
- <strong>SubscriptionVersionsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsVersions</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/versions
  &nbsp;&nbsp;&nbsp;&nbsp;List all subscription versions
  <br><br>
- <strong>SubscriptionVersionsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsVersionsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/versions/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a subscription version
  <br><br>
- <strong>SubscriptionVersionsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsVersionsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/versions/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search subscription versions
  <br><br>
- <strong>SubscriptionsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptions</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions
  &nbsp;&nbsp;&nbsp;&nbsp;List all subscriptions
  <br><br>
- <strong>SubscriptionsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a subscription
  <br><br>
- <strong>SubscriptionsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsIdInvoices</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/{id}/invoices
  &nbsp;&nbsp;&nbsp;&nbsp;Search subscription invoices
  <br><br>
- <strong>SubscriptionsService</strong><br>
  &nbsp;&nbsp;* <code>GetSubscriptionsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /subscriptions/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search subscriptions
  <br><br>
- <strong>SubscriptionsService</strong><br>
  &nbsp;&nbsp;* <code>PatchSubscriptionsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /subscriptions/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a subscription
  <br><br>
- <strong>SubscriptionsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptions</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions
  &nbsp;&nbsp;&nbsp;&nbsp;Create a subscription
  <br><br>
- <strong>SubscriptionsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsIdApplyChanges</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/{id}/apply-changes
  &nbsp;&nbsp;&nbsp;&nbsp;Apply changes to a subscription
  <br><br>
- <strong>SubscriptionsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsIdInitialize</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/{id}/initialize
  &nbsp;&nbsp;&nbsp;&nbsp;Initialize a subscription
  <br><br>
- <strong>SubscriptionsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsIdInitializeSubscriberPresent</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/{id}/initialize-subscriber-present
  &nbsp;&nbsp;&nbsp;&nbsp;Initialize a subscription with the subscriber present
  <br><br>
- <strong>SubscriptionsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsIdReactivate</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/{id}/reactivate
  &nbsp;&nbsp;&nbsp;&nbsp;Reactivate a suspended subscription
  <br><br>
- <strong>SubscriptionsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsIdSuspend</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/{id}/suspend
  &nbsp;&nbsp;&nbsp;&nbsp;Suspend a subscription
  <br><br>
- <strong>SubscriptionsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsIdTerminate</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/{id}/terminate
  &nbsp;&nbsp;&nbsp;&nbsp;Terminate a subscription
  <br><br>
- <strong>SubscriptionsService</strong><br>
  &nbsp;&nbsp;* <code>PostSubscriptionsIdUpgradeProduct</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /subscriptions/{id}/upgrade-product
  &nbsp;&nbsp;&nbsp;&nbsp;Upgrade a subscription&#39;s product
  <br><br>
- <strong>TokenVersionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTokenVersions</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/token-versions
  &nbsp;&nbsp;&nbsp;&nbsp;List all token versions
  <br><br>
- <strong>TokenVersionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTokenVersionsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/token-versions/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a token version
  <br><br>
- <strong>TokenVersionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTokenVersionsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/token-versions/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search token token versions
  <br><br>
- <strong>TokensService</strong><br>
  &nbsp;&nbsp;* <code>DeletePaymentTokensId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /payment/tokens/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a token
  <br><br>
- <strong>TokensService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTokens</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/tokens
  &nbsp;&nbsp;&nbsp;&nbsp;List all tokens
  <br><br>
- <strong>TokensService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTokensId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/tokens/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a token
  <br><br>
- <strong>TokensService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTokensIdActiveVersion</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/tokens/{id}/active-version
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve the active token version
  <br><br>
- <strong>TokensService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTokensSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/tokens/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search tokens
  <br><br>
- <strong>TokensService</strong><br>
  &nbsp;&nbsp;* <code>PatchPaymentTokensId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /payment/tokens/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a token
  <br><br>
- <strong>TokensService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTokens</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/tokens
  &nbsp;&nbsp;&nbsp;&nbsp;Create a token
  <br><br>
- <strong>TokensService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTokensIdCreateTransactionForTokenUpdate</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/tokens/{id}/create-transaction-for-token-update
  &nbsp;&nbsp;&nbsp;&nbsp;Create a transaction for token update
  <br><br>
- <strong>TransactionClientPlatformsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionClientPlatforms</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transaction/client-platforms
  &nbsp;&nbsp;&nbsp;&nbsp;List all client platforms
  <br><br>
- <strong>TransactionClientPlatformsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionClientPlatformsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transaction/client-platforms/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve the client platform based on id
  <br><br>
- <strong>TransactionClientPlatformsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionClientPlatformsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transaction/client-platforms/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search client platforms
  <br><br>
- <strong>TransactionCommentsService</strong><br>
  &nbsp;&nbsp;* <code>DeletePaymentTransactionsTransactionIdCommentsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /payment/transactions/{transactionId}/comments/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a transaction comment
  <br><br>
- <strong>TransactionCommentsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsTransactionIdComments</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/{transactionId}/comments
  &nbsp;&nbsp;&nbsp;&nbsp;List all transaction comments
  <br><br>
- <strong>TransactionCommentsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsTransactionIdCommentsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/{transactionId}/comments/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a transaction comment
  <br><br>
- <strong>TransactionCommentsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsTransactionIdCommentsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/{transactionId}/comments/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search transaction comments
  <br><br>
- <strong>TransactionCommentsService</strong><br>
  &nbsp;&nbsp;* <code>PatchPaymentTransactionsTransactionIdCommentsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /payment/transactions/{transactionId}/comments/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a transaction comment
  <br><br>
- <strong>TransactionCommentsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsTransactionIdComments</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{transactionId}/comments
  &nbsp;&nbsp;&nbsp;&nbsp;Create a transaction comment
  <br><br>
- <strong>TransactionCommentsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsTransactionIdCommentsIdPin</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{transactionId}/comments/{id}/pin
  &nbsp;&nbsp;&nbsp;&nbsp;Pin a comment to the top
  <br><br>
- <strong>TransactionCommentsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsTransactionIdCommentsIdUnpin</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{transactionId}/comments/{id}/unpin
  &nbsp;&nbsp;&nbsp;&nbsp;Remove the pinned comment from the top
  <br><br>
- <strong>TransactionCompletionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsCompletions</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/completions
  &nbsp;&nbsp;&nbsp;&nbsp;List all transaction completions
  <br><br>
- <strong>TransactionCompletionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsCompletionsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/completions/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a transaction completion
  <br><br>
- <strong>TransactionCompletionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsCompletionsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/completions/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search transaction completions
  <br><br>
- <strong>TransactionInvoiceCommentsService</strong><br>
  &nbsp;&nbsp;* <code>DeletePaymentTransactionsInvoicesInvoiceIdCommentsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /payment/transactions/invoices/{invoiceId}/comments/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a transaction comment
  <br><br>
- <strong>TransactionInvoiceCommentsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsInvoicesInvoiceIdComments</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/invoices/{invoiceId}/comments
  &nbsp;&nbsp;&nbsp;&nbsp;List all transaction invoice comments
  <br><br>
- <strong>TransactionInvoiceCommentsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsInvoicesInvoiceIdCommentsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/invoices/{invoiceId}/comments/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a transaction invoice comment
  <br><br>
- <strong>TransactionInvoiceCommentsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsInvoicesInvoiceIdCommentsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/invoices/{invoiceId}/comments/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search transaction invoice comments
  <br><br>
- <strong>TransactionInvoiceCommentsService</strong><br>
  &nbsp;&nbsp;* <code>PatchPaymentTransactionsInvoicesInvoiceIdCommentsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /payment/transactions/invoices/{invoiceId}/comments/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a transaction comment
  <br><br>
- <strong>TransactionInvoiceCommentsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsInvoicesInvoiceIdComments</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/invoices/{invoiceId}/comments
  &nbsp;&nbsp;&nbsp;&nbsp;Create a transaction invoice comment
  <br><br>
- <strong>TransactionInvoiceCommentsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsInvoicesInvoiceIdCommentsIdPin</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/invoices/{invoiceId}/comments/{id}/pin
  &nbsp;&nbsp;&nbsp;&nbsp;Pin a comment to the top
  <br><br>
- <strong>TransactionInvoiceCommentsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsInvoicesInvoiceIdCommentsIdUnpin</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/invoices/{invoiceId}/comments/{id}/unpin
  &nbsp;&nbsp;&nbsp;&nbsp;Remove the pinned comment from the top
  <br><br>
- <strong>TransactionInvoicesService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsInvoices</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/invoices
  &nbsp;&nbsp;&nbsp;&nbsp;List all transaction invoices
  <br><br>
- <strong>TransactionInvoicesService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsInvoicesId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/invoices/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a transaction invoice
  <br><br>
- <strong>TransactionInvoicesService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsInvoicesIdCheckReplacementPossible</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/invoices/{id}/check-replacement-possible
  &nbsp;&nbsp;&nbsp;&nbsp;Check if a transaction invoice can be replaced
  <br><br>
- <strong>TransactionInvoicesService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsInvoicesIdDocument</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/invoices/{id}/document
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve an invoice document
  <br><br>
- <strong>TransactionInvoicesService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsInvoicesSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/invoices/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search transaction invoices
  <br><br>
- <strong>TransactionInvoicesService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsInvoicesIdDerecognize</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/invoices/{id}/derecognize
  &nbsp;&nbsp;&nbsp;&nbsp;Derecognize a transaction invoice
  <br><br>
- <strong>TransactionInvoicesService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsInvoicesIdMarkPaid</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/invoices/{id}/mark-paid
  &nbsp;&nbsp;&nbsp;&nbsp;Mark a transaction invoice as paid
  <br><br>
- <strong>TransactionInvoicesService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsInvoicesIdReplace</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/invoices/{id}/replace
  &nbsp;&nbsp;&nbsp;&nbsp;Replace a transaction invoice
  <br><br>
- <strong>TransactionLineItemVersionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsLineItemVersions</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/line-item-versions
  &nbsp;&nbsp;&nbsp;&nbsp;List all transaction line item versions
  <br><br>
- <strong>TransactionLineItemVersionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsLineItemVersionsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/line-item-versions/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a transaction line item version
  <br><br>
- <strong>TransactionLineItemVersionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsLineItemVersionsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/line-item-versions/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search transaction line item versions
  <br><br>
- <strong>TransactionLineItemVersionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsLineItemVersions</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/line-item-versions
  &nbsp;&nbsp;&nbsp;&nbsp;Create a transaction line item version
  <br><br>
- <strong>TransactionVoidsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsVoids</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/voids
  &nbsp;&nbsp;&nbsp;&nbsp;List all transaction voids
  <br><br>
- <strong>TransactionVoidsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsVoidsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/voids/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a transaction void
  <br><br>
- <strong>TransactionVoidsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsVoidsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/voids/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search transaction voids
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>DeletePaymentTransactionsByCredentialsCredentialsOneClickTokensId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /payment/transactions/by-credentials/{credentials}/one-click-tokens/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a one-click token by credentials
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactions</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions
  &nbsp;&nbsp;&nbsp;&nbsp;List all transactions
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsByCredentialsCredentials</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/by-credentials/{credentials}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a transaction by credentials
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsByCredentialsCredentialsMobileSdkUrl</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/by-credentials/{credentials}/mobile-sdk-url
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a Mobile SDK URL by credentials
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsByCredentialsCredentialsOneClickTokens</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/by-credentials/{credentials}/one-click-tokens
  &nbsp;&nbsp;&nbsp;&nbsp;List one-click tokens by credentials
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsByCredentialsCredentialsPaymentMethodConfigurations</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/by-credentials/{credentials}/payment-method-configurations
  &nbsp;&nbsp;&nbsp;&nbsp;List available payment method configurations by credentials
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsExport</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/export
  &nbsp;&nbsp;&nbsp;&nbsp;Export transactions
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a transaction
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsIdChargeFlowPaymentPageUrl</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/{id}/charge-flow/payment-page-url
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a charge flow payment page URL
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsIdCheckTokenCreationPossible</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/{id}/check-token-creation-possible
  &nbsp;&nbsp;&nbsp;&nbsp;Check if token can be created
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsIdCredentials</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/{id}/credentials
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve transaction credentials
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsIdIframeJavascriptUrl</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/{id}/iframe-javascript-url
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve an iFrame JavaScript URL
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsIdInvoiceDocument</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/{id}/invoice-document
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve an invoice document
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsIdLatestLineItemVersion</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/{id}/latest-line-item-version
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve the latest line item version
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsIdLightboxJavascriptUrl</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/{id}/lightbox-javascript-url
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a Lightbox JavaScript URL
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsIdPackingSlipDocument</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/{id}/packing-slip-document
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a packing slip document
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsIdPaymentMethodConfigurations</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/{id}/payment-method-configurations
  &nbsp;&nbsp;&nbsp;&nbsp;List available payment method configurations
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsIdPaymentPageUrl</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/{id}/payment-page-url
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a payment page URL
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsIdTerminalReceipts</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/{id}/terminal-receipts
  &nbsp;&nbsp;&nbsp;&nbsp;List terminal receipts
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>GetPaymentTransactionsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /payment/transactions/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search transactions
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PatchPaymentTransactionsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /payment/transactions/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a transaction
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactions</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions
  &nbsp;&nbsp;&nbsp;&nbsp;Create a transaction
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsByCredentialsCredentialsOneClickTokensIdProcess</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/by-credentials/{credentials}/one-click-tokens/{id}/process
  &nbsp;&nbsp;&nbsp;&nbsp;Process via one-click token by credentials
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsIdChargeFlowApply</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{id}/charge-flow/apply
  &nbsp;&nbsp;&nbsp;&nbsp;Process a transaction via charge flow
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsIdChargeFlowCancel</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{id}/charge-flow/cancel
  &nbsp;&nbsp;&nbsp;&nbsp;Cancel a charge flow
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsIdChargeFlowUpdateRecipient</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{id}/charge-flow/update-recipient
  &nbsp;&nbsp;&nbsp;&nbsp;Update a charge flow recipient
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsIdCompleteOffline</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{id}/complete-offline
  &nbsp;&nbsp;&nbsp;&nbsp;Complete a transaction offline
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsIdCompleteOnline</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{id}/complete-online
  &nbsp;&nbsp;&nbsp;&nbsp;Complete a transaction online
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsIdCompletePartiallyOffline</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{id}/complete-partially-offline
  &nbsp;&nbsp;&nbsp;&nbsp;Complete a transaction offline partially
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsIdCompletePartiallyOnline</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{id}/complete-partially-online
  &nbsp;&nbsp;&nbsp;&nbsp;Complete a transaction online partially
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsIdConfirm</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{id}/confirm
  &nbsp;&nbsp;&nbsp;&nbsp;Confirm a transaction
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsIdProcessCardDetails</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{id}/process-card-details
  &nbsp;&nbsp;&nbsp;&nbsp;Process a card transaction
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsIdProcessCardDetailsThreed</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{id}/process-card-details-threed
  &nbsp;&nbsp;&nbsp;&nbsp;Process a card transaction with 3-D Secure
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsIdProcessWithToken</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{id}/process-with-token
  &nbsp;&nbsp;&nbsp;&nbsp;Process a transaction via token
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsIdProcessWithoutInteraction</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{id}/process-without-interaction
  &nbsp;&nbsp;&nbsp;&nbsp;Process a transaction without user-interaction
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsIdVoidOffline</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{id}/void-offline
  &nbsp;&nbsp;&nbsp;&nbsp;Void a transaction offline
  <br><br>
- <strong>TransactionsService</strong><br>
  &nbsp;&nbsp;* <code>PostPaymentTransactionsIdVoidOnline</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /payment/transactions/{id}/void-online
  &nbsp;&nbsp;&nbsp;&nbsp;Void a transaction online
  <br><br>
- <strong>WebAppsService</strong><br>
  &nbsp;&nbsp;* <code>GetWebAppsInstalled</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /web-apps/installed
  &nbsp;&nbsp;&nbsp;&nbsp;Check whether the web app is installed
  <br><br>
- <strong>WebAppsService</strong><br>
  &nbsp;&nbsp;* <code>PostWebAppsConfirmCode</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /web-apps/confirm/{code}
  &nbsp;&nbsp;&nbsp;&nbsp;Confirm a web app installation
  <br><br>
- <strong>WebAppsService</strong><br>
  &nbsp;&nbsp;* <code>PostWebAppsUninstall</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /web-apps/uninstall
  &nbsp;&nbsp;&nbsp;&nbsp;Uninstall a web app
  <br><br>
- <strong>WebhookEncryptionKeysService</strong><br>
  &nbsp;&nbsp;* <code>GetWebhooksEncryptionKeysId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /webhooks/encryption-keys/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a webhook encryption key
  <br><br>
- <strong>WebhookListenersService</strong><br>
  &nbsp;&nbsp;* <code>DeleteWebhooksListenersBulk</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /webhooks/listeners/bulk
  &nbsp;&nbsp;&nbsp;&nbsp;Delete multiple webhook listeners
  <br><br>
- <strong>WebhookListenersService</strong><br>
  &nbsp;&nbsp;* <code>DeleteWebhooksListenersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /webhooks/listeners/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a webhook listener
  <br><br>
- <strong>WebhookListenersService</strong><br>
  &nbsp;&nbsp;* <code>GetWebhooksListeners</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /webhooks/listeners
  &nbsp;&nbsp;&nbsp;&nbsp;List all webhook listeners
  <br><br>
- <strong>WebhookListenersService</strong><br>
  &nbsp;&nbsp;* <code>GetWebhooksListenersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /webhooks/listeners/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a webhook listener
  <br><br>
- <strong>WebhookListenersService</strong><br>
  &nbsp;&nbsp;* <code>GetWebhooksListenersSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /webhooks/listeners/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search webhook listeners
  <br><br>
- <strong>WebhookListenersService</strong><br>
  &nbsp;&nbsp;* <code>PatchWebhooksListenersBulk</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /webhooks/listeners/bulk
  &nbsp;&nbsp;&nbsp;&nbsp;Update multiple webhook listeners
  <br><br>
- <strong>WebhookListenersService</strong><br>
  &nbsp;&nbsp;* <code>PatchWebhooksListenersId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /webhooks/listeners/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a webhook listener
  <br><br>
- <strong>WebhookListenersService</strong><br>
  &nbsp;&nbsp;* <code>PostWebhooksListeners</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /webhooks/listeners
  &nbsp;&nbsp;&nbsp;&nbsp;Create a webhook listener
  <br><br>
- <strong>WebhookListenersService</strong><br>
  &nbsp;&nbsp;* <code>PostWebhooksListenersBulk</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /webhooks/listeners/bulk
  &nbsp;&nbsp;&nbsp;&nbsp;Create multiple webhook listeners
  <br><br>
- <strong>WebhookURLsService</strong><br>
  &nbsp;&nbsp;* <code>DeleteWebhooksUrlsBulk</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /webhooks/urls/bulk
  &nbsp;&nbsp;&nbsp;&nbsp;Delete multiple webhook URLs
  <br><br>
- <strong>WebhookURLsService</strong><br>
  &nbsp;&nbsp;* <code>DeleteWebhooksUrlsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>DELETE</strong> /webhooks/urls/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Delete a webhook URL
  <br><br>
- <strong>WebhookURLsService</strong><br>
  &nbsp;&nbsp;* <code>GetWebhooksUrls</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /webhooks/urls
  &nbsp;&nbsp;&nbsp;&nbsp;List all webhook URLs
  <br><br>
- <strong>WebhookURLsService</strong><br>
  &nbsp;&nbsp;* <code>GetWebhooksUrlsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /webhooks/urls/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Retrieve a webhook URL
  <br><br>
- <strong>WebhookURLsService</strong><br>
  &nbsp;&nbsp;* <code>GetWebhooksUrlsSearch</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>GET</strong> /webhooks/urls/search
  &nbsp;&nbsp;&nbsp;&nbsp;Search webhook URLs
  <br><br>
- <strong>WebhookURLsService</strong><br>
  &nbsp;&nbsp;* <code>PatchWebhooksUrlsBulk</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /webhooks/urls/bulk
  &nbsp;&nbsp;&nbsp;&nbsp;Update multiple webhook URLs
  <br><br>
- <strong>WebhookURLsService</strong><br>
  &nbsp;&nbsp;* <code>PatchWebhooksUrlsId</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>PATCH</strong> /webhooks/urls/{id}
  &nbsp;&nbsp;&nbsp;&nbsp;Update a webhook URL
  <br><br>
- <strong>WebhookURLsService</strong><br>
  &nbsp;&nbsp;* <code>PostWebhooksUrls</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /webhooks/urls
  &nbsp;&nbsp;&nbsp;&nbsp;Create a webhook URL
  <br><br>
- <strong>WebhookURLsService</strong><br>
  &nbsp;&nbsp;* <code>PostWebhooksUrlsBulk</code>
  &nbsp;&nbsp;&nbsp;&nbsp;<strong>POST</strong> /webhooks/urls/bulk
  &nbsp;&nbsp;&nbsp;&nbsp;Create multiple webhook URLs
  <br><br>

</details>

## Documentation for Models

Additional API models documentation: [*link*](https://app-wallee.com/en-us/doc/api/web-service#_models)<br>
<details>
<summary>Click here to see full list of models</summary>

<p><strong>Models:</strong></p>

* <strong>AbstractAccountUpdate</strong>
* <strong>AbstractApplicationUserUpdate</strong>
* <strong>AbstractCustomerActive</strong>
* <strong>AbstractCustomerAddressActive</strong>
* <strong>AbstractCustomerCommentActive</strong>
* <strong>AbstractDebtCollectionCaseUpdate</strong>
* <strong>AbstractDebtCollectorConfigurationUpdate</strong>
* <strong>AbstractHumanUserUpdate</strong>
* <strong>AbstractPaymentConnectorConfigurationUpdate</strong>
* <strong>AbstractPaymentLinkUpdate</strong>
* <strong>AbstractPaymentMethodConfigurationUpdate</strong>
* <strong>AbstractPaymentProcessorConfigurationActive</strong>
* <strong>AbstractPaymentTerminalUpdate</strong>
* <strong>AbstractRefundCommentActive</strong>
* <strong>AbstractRoleUpdate</strong>
* <strong>AbstractSingleSignOnUserUpdate</strong>
* <strong>AbstractSpaceUpdate</strong>
* <strong>AbstractSubscriberUpdate</strong>
* <strong>AbstractSubscriptionAffiliateUpdate</strong>
* <strong>AbstractSubscriptionMetricUpdate</strong>
* <strong>AbstractSubscriptionProductActive</strong>
* <strong>AbstractTokenUpdate</strong>
* <strong>AbstractTransactionCommentActive</strong>
* <strong>AbstractTransactionInvoiceCommentActive</strong>
* <strong>AbstractTransactionPending</strong>
* <strong>AbstractWebhookListenerUpdate</strong>
* <strong>AbstractWebhookUrlUpdate</strong>
* <strong>Account</strong>
* <strong>AccountCreate</strong>
* <strong>AccountListResponse</strong>
* <strong>AccountSearchResponse</strong>
* <strong>AccountState</strong>
* <strong>AccountType</strong>
* <strong>AccountUpdate</strong>
* <strong>Address</strong>
* <strong>AddressCreate</strong>
* <strong>AnalyticsQueryExecutionRequest</strong>
* <strong>AnalyticsQueryExecutionResponse</strong>
* <strong>ApplicationKeyState</strong>
* <strong>ApplicationUser</strong>
* <strong>ApplicationUserCreate</strong>
* <strong>ApplicationUserCreateWithMacKey</strong>
* <strong>ApplicationUserListResponse</strong>
* <strong>ApplicationUserSearchResponse</strong>
* <strong>ApplicationUserUpdate</strong>
* <strong>AuthenticatedCardData</strong>
* <strong>AuthenticatedCardDataCreate</strong>
* <strong>AuthenticatedCardRequest</strong>
* <strong>BankAccount</strong>
* <strong>BankAccountEnvironment</strong>
* <strong>BankAccountListResponse</strong>
* <strong>BankAccountSearchResponse</strong>
* <strong>BankAccountState</strong>
* <strong>BankAccountType</strong>
* <strong>BankTransaction</strong>
* <strong>BankTransactionFlowDirection</strong>
* <strong>BankTransactionListResponse</strong>
* <strong>BankTransactionSearchResponse</strong>
* <strong>BankTransactionSource</strong>
* <strong>BankTransactionState</strong>
* <strong>BankTransactionType</strong>
* <strong>BillingCycleModel</strong>
* <strong>BillingCycleType</strong>
* <strong>BillingDayCustomization</strong>
* <strong>CardAuthenticationResponse</strong>
* <strong>CardAuthenticationVersion</strong>
* <strong>CardCryptogram</strong>
* <strong>CardCryptogramCreate</strong>
* <strong>CardholderAuthentication</strong>
* <strong>CardholderAuthenticationCreate</strong>
* <strong>Charge</strong>
* <strong>ChargeAttempt</strong>
* <strong>ChargeAttemptEnvironment</strong>
* <strong>ChargeAttemptListResponse</strong>
* <strong>ChargeAttemptSearchResponse</strong>
* <strong>ChargeAttemptState</strong>
* <strong>ChargeBankTransaction</strong>
* <strong>ChargeBankTransactionListResponse</strong>
* <strong>ChargeBankTransactionSearchResponse</strong>
* <strong>ChargeFlow</strong>
* <strong>ChargeFlowLevel</strong>
* <strong>ChargeFlowLevelConfiguration</strong>
* <strong>ChargeFlowLevelConfigurationType</strong>
* <strong>ChargeFlowLevelListResponse</strong>
* <strong>ChargeFlowLevelPaymentLink</strong>
* <strong>ChargeFlowLevelPaymentLinkListResponse</strong>
* <strong>ChargeFlowLevelPaymentLinkSearchResponse</strong>
* <strong>ChargeFlowLevelSearchResponse</strong>
* <strong>ChargeFlowLevelState</strong>
* <strong>ChargeFlowListResponse</strong>
* <strong>ChargeFlowSearchResponse</strong>
* <strong>ChargeState</strong>
* <strong>ChargeType</strong>
* <strong>ClientPlatformInformationListResponse</strong>
* <strong>ClientPlatformInformationSearchResponse</strong>
* <strong>CompletionLineItem</strong>
* <strong>CompletionLineItemCreate</strong>
* <strong>CompletionListResponse</strong>
* <strong>CompletionSearchResponse</strong>
* <strong>Condition</strong>
* <strong>ConditionType</strong>
* <strong>ConditionTypeListResponse</strong>
* <strong>ConditionTypeSearchResponse</strong>
* <strong>ConnectorInvocation</strong>
* <strong>ConnectorInvocationStage</strong>
* <strong>CountryListResponse</strong>
* <strong>CountrySearchResponse</strong>
* <strong>CreationEntityState</strong>
* <strong>CurrencyBankAccount</strong>
* <strong>CurrencyBankAccountListResponse</strong>
* <strong>CurrencyBankAccountSearchResponse</strong>
* <strong>CurrencyListResponse</strong>
* <strong>CurrencySearchResponse</strong>
* <strong>Customer</strong>
* <strong>CustomerActive</strong>
* <strong>CustomerAddress</strong>
* <strong>CustomerAddressActive</strong>
* <strong>CustomerAddressCreate</strong>
* <strong>CustomerAddressListResponse</strong>
* <strong>CustomerAddressSearchResponse</strong>
* <strong>CustomerAddressType</strong>
* <strong>CustomerComment</strong>
* <strong>CustomerCommentActive</strong>
* <strong>CustomerCommentCreate</strong>
* <strong>CustomerCommentListResponse</strong>
* <strong>CustomerCommentSearchResponse</strong>
* <strong>CustomerCreate</strong>
* <strong>CustomerEmailAddressListResponse</strong>
* <strong>CustomerListResponse</strong>
* <strong>CustomerPostalAddress</strong>
* <strong>CustomerPostalAddressCreate</strong>
* <strong>CustomerSearchResponse</strong>
* <strong>CustomersPresence</strong>
* <strong>DataCollectionType</strong>
* <strong>DebtCollectionCase</strong>
* <strong>DebtCollectionCaseCreate</strong>
* <strong>DebtCollectionCaseDocument</strong>
* <strong>DebtCollectionCaseDocumentListResponse</strong>
* <strong>DebtCollectionCaseListResponse</strong>
* <strong>DebtCollectionCaseSearchResponse</strong>
* <strong>DebtCollectionCaseSource</strong>
* <strong>DebtCollectionCaseState</strong>
* <strong>DebtCollectionCaseUpdate</strong>
* <strong>DebtCollectionEnvironment</strong>
* <strong>DebtCollectionReceipt</strong>
* <strong>DebtCollectionReceiptSource</strong>
* <strong>DebtCollector</strong>
* <strong>DebtCollectorCondition</strong>
* <strong>DebtCollectorConditionType</strong>
* <strong>DebtCollectorConfiguration</strong>
* <strong>DebtCollectorConfigurationCreate</strong>
* <strong>DebtCollectorConfigurationListResponse</strong>
* <strong>DebtCollectorConfigurationSearchResponse</strong>
* <strong>DebtCollectorConfigurationUpdate</strong>
* <strong>DebtCollectorListResponse</strong>
* <strong>DebtCollectorSearchResponse</strong>
* <strong>DeliveryIndication</strong>
* <strong>DeliveryIndicationDecisionReason</strong>
* <strong>DeliveryIndicationListResponse</strong>
* <strong>DeliveryIndicationSearchResponse</strong>
* <strong>DeliveryIndicationState</strong>
* <strong>DisplayableDayOfWeek</strong>
* <strong>DisplayableMonth</strong>
* <strong>DocumentTemplate</strong>
* <strong>DocumentTemplateListResponse</strong>
* <strong>DocumentTemplateSearchResponse</strong>
* <strong>DocumentTemplateType</strong>
* <strong>DocumentTemplateTypeGroup</strong>
* <strong>DocumentTemplateTypeListResponse</strong>
* <strong>DocumentTemplateTypeSearchResponse</strong>
* <strong>DunningCase</strong>
* <strong>DunningCaseListResponse</strong>
* <strong>DunningCaseSearchResponse</strong>
* <strong>DunningCaseState</strong>
* <strong>DunningCondition</strong>
* <strong>DunningConditionType</strong>
* <strong>DunningFlow</strong>
* <strong>DunningFlowLevel</strong>
* <strong>DunningFlowLevelListResponse</strong>
* <strong>DunningFlowLevelProcessor</strong>
* <strong>DunningFlowLevelSearchResponse</strong>
* <strong>DunningFlowListResponse</strong>
* <strong>DunningFlowSearchResponse</strong>
* <strong>DunningFlowType</strong>
* <strong>ExpressCheckoutCreateResponse</strong>
* <strong>ExpressCheckoutSession</strong>
* <strong>ExpressCheckoutSessionCreate</strong>
* <strong>ExpressCheckoutSessionState</strong>
* <strong>ExpressCheckoutShippingOption</strong>
* <strong>ExpressCheckoutWalletType</strong>
* <strong>ExternalTransferBankTransaction</strong>
* <strong>ExternalTransferBankTransactionListResponse</strong>
* <strong>ExternalTransferBankTransactionSearchResponse</strong>
* <strong>FacadeUserFriendlyQueryStatusModel</strong>
* <strong>FailureCategory</strong>
* <strong>FailureReason</strong>
* <strong>Feature</strong>
* <strong>FeatureCategory</strong>
* <strong>Gender</strong>
* <strong>HumanUser</strong>
* <strong>HumanUserCreate</strong>
* <strong>HumanUserListResponse</strong>
* <strong>HumanUserSearchResponse</strong>
* <strong>HumanUserUpdate</strong>
* <strong>InternalTransferBankTransaction</strong>
* <strong>InternalTransferBankTransactionListResponse</strong>
* <strong>InternalTransferBankTransactionSearchResponse</strong>
* <strong>InvoiceCommentListResponse</strong>
* <strong>InvoiceCommentSearchResponse</strong>
* <strong>InvoiceListResponse</strong>
* <strong>InvoiceSearchResponse</strong>
* <strong>Label</strong>
* <strong>LabelDescriptor</strong>
* <strong>LabelDescriptorCategory</strong>
* <strong>LabelDescriptorGroup</strong>
* <strong>LabelDescriptorGroupListResponse</strong>
* <strong>LabelDescriptorGroupSearchResponse</strong>
* <strong>LabelDescriptorListResponse</strong>
* <strong>LabelDescriptorSearchResponse</strong>
* <strong>LabelDescriptorType</strong>
* <strong>LanguageListResponse</strong>
* <strong>LanguageSearchResponse</strong>
* <strong>LegalOrganizationForm</strong>
* <strong>LegalOrganizationFormListResponse</strong>
* <strong>LegalOrganizationFormSearchResponse</strong>
* <strong>LineItem</strong>
* <strong>LineItemAttribute</strong>
* <strong>LineItemAttributeCreate</strong>
* <strong>LineItemCreate</strong>
* <strong>LineItemReduction</strong>
* <strong>LineItemReductionCreate</strong>
* <strong>LineItemType</strong>
* <strong>LineItemVersionListResponse</strong>
* <strong>LineItemVersionSearchResponse</strong>
* <strong>LocalizedString</strong>
* <strong>ManualTask</strong>
* <strong>ManualTaskAction</strong>
* <strong>ManualTaskActionStyle</strong>
* <strong>ManualTaskListResponse</strong>
* <strong>ManualTaskSearchResponse</strong>
* <strong>ManualTaskState</strong>
* <strong>ManualTaskType</strong>
* <strong>MetricListResponse</strong>
* <strong>MetricSearchResponse</strong>
* <strong>MetricUsage</strong>
* <strong>MetricUsageListResponse</strong>
* <strong>MetricUsageReportListResponse</strong>
* <strong>MetricUsageReportSearchResponse</strong>
* <strong>ModelEnvironment</strong>
* <strong>OneClickPaymentMode</strong>
* <strong>PanType</strong>
* <strong>PaymentAdjustment</strong>
* <strong>PaymentAdjustmentType</strong>
* <strong>PaymentAppChargeAttemptTargetState</strong>
* <strong>PaymentAppChargeAttemptUpdate</strong>
* <strong>PaymentAppCompletionConfiguration</strong>
* <strong>PaymentAppCompletionConfigurationCreate</strong>
* <strong>PaymentAppCompletionTargetState</strong>
* <strong>PaymentAppCompletionUpdate</strong>
* <strong>PaymentAppConnector</strong>
* <strong>PaymentAppConnectorDetails</strong>
* <strong>PaymentAppConnectorDetailsCreate</strong>
* <strong>PaymentAppConnectorState</strong>
* <strong>PaymentAppProcessor</strong>
* <strong>PaymentAppProcessorDetails</strong>
* <strong>PaymentAppProcessorDetailsCreate</strong>
* <strong>PaymentAppProcessorState</strong>
* <strong>PaymentAppRefundConfiguration</strong>
* <strong>PaymentAppRefundConfigurationCreate</strong>
* <strong>PaymentAppRefundTargetState</strong>
* <strong>PaymentAppRefundUpdate</strong>
* <strong>PaymentAppVoidTargetState</strong>
* <strong>PaymentAppVoidUpdate</strong>
* <strong>PaymentConnector</strong>
* <strong>PaymentConnectorConfiguration</strong>
* <strong>PaymentConnectorConfigurationCreate</strong>
* <strong>PaymentConnectorConfigurationListResponse</strong>
* <strong>PaymentConnectorConfigurationSearchResponse</strong>
* <strong>PaymentConnectorConfigurationUpdate</strong>
* <strong>PaymentConnectorFeature</strong>
* <strong>PaymentConnectorListResponse</strong>
* <strong>PaymentConnectorSearchResponse</strong>
* <strong>PaymentContract</strong>
* <strong>PaymentContractState</strong>
* <strong>PaymentContractType</strong>
* <strong>PaymentInformationHash</strong>
* <strong>PaymentInformationHashType</strong>
* <strong>PaymentLink</strong>
* <strong>PaymentLinkActive</strong>
* <strong>PaymentLinkAddressHandlingMode</strong>
* <strong>PaymentLinkCreate</strong>
* <strong>PaymentLinkListResponse</strong>
* <strong>PaymentLinkProtectionMode</strong>
* <strong>PaymentLinkSearchResponse</strong>
* <strong>PaymentLinkUpdate</strong>
* <strong>PaymentMethod</strong>
* <strong>PaymentMethodBrand</strong>
* <strong>PaymentMethodBrandListResponse</strong>
* <strong>PaymentMethodBrandSearchResponse</strong>
* <strong>PaymentMethodConfiguration</strong>
* <strong>PaymentMethodConfigurationActive</strong>
* <strong>PaymentMethodConfigurationCreate</strong>
* <strong>PaymentMethodConfigurationListResponse</strong>
* <strong>PaymentMethodConfigurationSearchResponse</strong>
* <strong>PaymentMethodConfigurationUpdate</strong>
* <strong>PaymentMethodListResponse</strong>
* <strong>PaymentMethodSearchResponse</strong>
* <strong>PaymentPrimaryRiskTaker</strong>
* <strong>PaymentProcessor</strong>
* <strong>PaymentProcessorConfiguration</strong>
* <strong>PaymentProcessorConfigurationActive</strong>
* <strong>PaymentProcessorConfigurationCreate</strong>
* <strong>PaymentProcessorConfigurationListResponse</strong>
* <strong>PaymentProcessorConfigurationSearchResponse</strong>
* <strong>PaymentProcessorListResponse</strong>
* <strong>PaymentProcessorSearchResponse</strong>
* <strong>PaymentTerminal</strong>
* <strong>PaymentTerminalAddress</strong>
* <strong>PaymentTerminalConfiguration</strong>
* <strong>PaymentTerminalConfigurationState</strong>
* <strong>PaymentTerminalConfigurationVersion</strong>
* <strong>PaymentTerminalConfigurationVersionState</strong>
* <strong>PaymentTerminalCreate</strong>
* <strong>PaymentTerminalDccTransactionSum</strong>
* <strong>PaymentTerminalLocation</strong>
* <strong>PaymentTerminalLocationState</strong>
* <strong>PaymentTerminalLocationVersion</strong>
* <strong>PaymentTerminalLocationVersionState</strong>
* <strong>PaymentTerminalPreparing</strong>
* <strong>PaymentTerminalReceiptType</strong>
* <strong>PaymentTerminalState</strong>
* <strong>PaymentTerminalTransactionSum</strong>
* <strong>PaymentTerminalTransactionSummary</strong>
* <strong>PaymentTerminalTransactionSummaryReference</strong>
* <strong>PaymentTerminalType</strong>
* <strong>PaymentTerminalUpdate</strong>
* <strong>Permission</strong>
* <strong>PermissionListResponse</strong>
* <strong>PermissionSearchResponse</strong>
* <strong>PersistableCurrencyAmount</strong>
* <strong>PersistableCurrencyAmountUpdate</strong>
* <strong>ProductComponentGroupListResponse</strong>
* <strong>ProductComponentGroupSearchResponse</strong>
* <strong>ProductComponentListResponse</strong>
* <strong>ProductComponentSearchResponse</strong>
* <strong>ProductFeeType</strong>
* <strong>ProductListResponse</strong>
* <strong>ProductMeteredFee</strong>
* <strong>ProductMeteredFeeListResponse</strong>
* <strong>ProductMeteredFeeSearchResponse</strong>
* <strong>ProductMeteredFeeTierListResponse</strong>
* <strong>ProductMeteredFeeTierSearchResponse</strong>
* <strong>ProductMeteredFeeUpdate</strong>
* <strong>ProductMeteredTierFee</strong>
* <strong>ProductMeteredTierFeeUpdate</strong>
* <strong>ProductMeteredTierPricing</strong>
* <strong>ProductPeriodFee</strong>
* <strong>ProductPeriodFeeListResponse</strong>
* <strong>ProductPeriodFeeSearchResponse</strong>
* <strong>ProductPeriodFeeUpdate</strong>
* <strong>ProductRetirementListResponse</strong>
* <strong>ProductRetirementSearchResponse</strong>
* <strong>ProductSearchResponse</strong>
* <strong>ProductSetupFee</strong>
* <strong>ProductSetupFeeListResponse</strong>
* <strong>ProductSetupFeeSearchResponse</strong>
* <strong>ProductSetupFeeUpdate</strong>
* <strong>ProductVersionListResponse</strong>
* <strong>ProductVersionRetirementListResponse</strong>
* <strong>ProductVersionRetirementSearchResponse</strong>
* <strong>ProductVersionSearchResponse</strong>
* <strong>RecurringIndicator</strong>
* <strong>Refund</strong>
* <strong>RefundBankTransaction</strong>
* <strong>RefundBankTransactionListResponse</strong>
* <strong>RefundBankTransactionSearchResponse</strong>
* <strong>RefundComment</strong>
* <strong>RefundCommentActive</strong>
* <strong>RefundCommentCreate</strong>
* <strong>RefundCommentListResponse</strong>
* <strong>RefundCommentSearchResponse</strong>
* <strong>RefundCreate</strong>
* <strong>RefundListResponse</strong>
* <strong>RefundRecoveryBankTransaction</strong>
* <strong>RefundRecoveryBankTransactionListResponse</strong>
* <strong>RefundRecoveryBankTransactionSearchResponse</strong>
* <strong>RefundSearchResponse</strong>
* <strong>RefundState</strong>
* <strong>RefundType</strong>
* <strong>RenderedDocument</strong>
* <strong>RenderedTerminalReceipt</strong>
* <strong>RenderedTerminalReceiptListResponse</strong>
* <strong>RenderedTerminalTransactionSummary</strong>
* <strong>RestAddressFormat</strong>
* <strong>RestAddressFormatField</strong>
* <strong>RestApiBulkOperationResult</strong>
* <strong>RestApiErrorResponse</strong>
* <strong>RestApplicationUserMacKey</strong>
* <strong>RestApplicationUserMacKeyCreated</strong>
* <strong>RestCountry</strong>
* <strong>RestCountryState</strong>
* <strong>RestCurrency</strong>
* <strong>RestCustomerEmailAddress</strong>
* <strong>RestLanguage</strong>
* <strong>ResultPortionModel</strong>
* <strong>Role</strong>
* <strong>RoleCreate</strong>
* <strong>RoleListResponse</strong>
* <strong>RoleSearchResponse</strong>
* <strong>RoleState</strong>
* <strong>RoleUpdate</strong>
* <strong>SalesChannel</strong>
* <strong>SalesChannelListResponse</strong>
* <strong>SalesChannelSearchResponse</strong>
* <strong>Scope</strong>
* <strong>ScopeSingleSignOnProvider</strong>
* <strong>SingleSignOnUser</strong>
* <strong>SingleSignOnUserCreate</strong>
* <strong>SingleSignOnUserListResponse</strong>
* <strong>SingleSignOnUserSearchResponse</strong>
* <strong>SingleSignOnUserUpdate</strong>
* <strong>SortingOrder</strong>
* <strong>Space</strong>
* <strong>SpaceAddress</strong>
* <strong>SpaceAddressCreate</strong>
* <strong>SpaceCreate</strong>
* <strong>SpaceListResponse</strong>
* <strong>SpaceSearchResponse</strong>
* <strong>SpaceUpdate</strong>
* <strong>SpaceView</strong>
* <strong>StaticValue</strong>
* <strong>StaticValueListResponse</strong>
* <strong>StaticValueSearchResponse</strong>
* <strong>SubmittedAnalyticsQueryExecution</strong>
* <strong>Subscriber</strong>
* <strong>SubscriberActive</strong>
* <strong>SubscriberCreate</strong>
* <strong>SubscriberListResponse</strong>
* <strong>SubscriberSearchResponse</strong>
* <strong>SubscriberUpdate</strong>
* <strong>Subscription</strong>
* <strong>SubscriptionAffiliate</strong>
* <strong>SubscriptionAffiliateCreate</strong>
* <strong>SubscriptionAffiliateDeleted</strong>
* <strong>SubscriptionAffiliateDeleting</strong>
* <strong>SubscriptionAffiliateInactive</strong>
* <strong>SubscriptionAffiliateListResponse</strong>
* <strong>SubscriptionAffiliateSearchResponse</strong>
* <strong>SubscriptionAffiliateUpdate</strong>
* <strong>SubscriptionCharge</strong>
* <strong>SubscriptionChargeCreate</strong>
* <strong>SubscriptionChargeListResponse</strong>
* <strong>SubscriptionChargeProcessingType</strong>
* <strong>SubscriptionChargeSearchResponse</strong>
* <strong>SubscriptionChargeState</strong>
* <strong>SubscriptionChargeType</strong>
* <strong>SubscriptionComponentConfiguration</strong>
* <strong>SubscriptionComponentReferenceConfiguration</strong>
* <strong>SubscriptionCreateRequest</strong>
* <strong>SubscriptionInitializeSubscriberPresentRequest</strong>
* <strong>SubscriptionLedgerEntry</strong>
* <strong>SubscriptionLedgerEntryCreate</strong>
* <strong>SubscriptionLedgerEntryListResponse</strong>
* <strong>SubscriptionLedgerEntrySearchResponse</strong>
* <strong>SubscriptionLedgerEntryState</strong>
* <strong>SubscriptionListResponse</strong>
* <strong>SubscriptionMetric</strong>
* <strong>SubscriptionMetricActive</strong>
* <strong>SubscriptionMetricCreate</strong>
* <strong>SubscriptionMetricType</strong>
* <strong>SubscriptionMetricUpdate</strong>
* <strong>SubscriptionMetricUsageReport</strong>
* <strong>SubscriptionMetricUsageReportCreate</strong>
* <strong>SubscriptionPending</strong>
* <strong>SubscriptionPeriodBill</strong>
* <strong>SubscriptionPeriodBillListResponse</strong>
* <strong>SubscriptionPeriodBillSearchResponse</strong>
* <strong>SubscriptionPeriodBillState</strong>
* <strong>SubscriptionProduct</strong>
* <strong>SubscriptionProductActive</strong>
* <strong>SubscriptionProductComponent</strong>
* <strong>SubscriptionProductComponentGroup</strong>
* <strong>SubscriptionProductComponentGroupUpdate</strong>
* <strong>SubscriptionProductComponentReference</strong>
* <strong>SubscriptionProductComponentReferenceState</strong>
* <strong>SubscriptionProductComponentUpdate</strong>
* <strong>SubscriptionProductCreate</strong>
* <strong>SubscriptionProductRetirement</strong>
* <strong>SubscriptionProductRetirementRequest</strong>
* <strong>SubscriptionProductState</strong>
* <strong>SubscriptionProductVersion</strong>
* <strong>SubscriptionProductVersionPending</strong>
* <strong>SubscriptionProductVersionRetirement</strong>
* <strong>SubscriptionProductVersionRetirementRequest</strong>
* <strong>SubscriptionProductVersionState</strong>
* <strong>SubscriptionSearchResponse</strong>
* <strong>SubscriptionState</strong>
* <strong>SubscriptionSuspension</strong>
* <strong>SubscriptionSuspensionAction</strong>
* <strong>SubscriptionSuspensionReason</strong>
* <strong>SubscriptionSuspensionState</strong>
* <strong>SubscriptionUpdate</strong>
* <strong>SubscriptionUpdateRequest</strong>
* <strong>SubscriptionVersion</strong>
* <strong>SubscriptionVersionListResponse</strong>
* <strong>SubscriptionVersionSearchResponse</strong>
* <strong>SubscriptionVersionState</strong>
* <strong>SuspensionCreationRequest</strong>
* <strong>SuspensionListResponse</strong>
* <strong>SuspensionSearchResponse</strong>
* <strong>Tax</strong>
* <strong>TaxCalculation</strong>
* <strong>TaxClass</strong>
* <strong>TaxCreate</strong>
* <strong>TenantDatabase</strong>
* <strong>TerminalListResponse</strong>
* <strong>TerminalReceiptFormat</strong>
* <strong>TerminalSearchResponse</strong>
* <strong>TerminalTransactionSummaryListResponse</strong>
* <strong>TerminalTransactionSummarySearchResponse</strong>
* <strong>Token</strong>
* <strong>TokenCreate</strong>
* <strong>TokenListResponse</strong>
* <strong>TokenSearchResponse</strong>
* <strong>TokenUpdate</strong>
* <strong>TokenVersion</strong>
* <strong>TokenVersionListResponse</strong>
* <strong>TokenVersionRetryStrategy</strong>
* <strong>TokenVersionSearchResponse</strong>
* <strong>TokenVersionState</strong>
* <strong>TokenVersionType</strong>
* <strong>TokenizationMode</strong>
* <strong>TokenizedCardData</strong>
* <strong>TokenizedCardDataCreate</strong>
* <strong>TokenizedCardRequest</strong>
* <strong>Transaction</strong>
* <strong>TransactionClientPlatformInformation</strong>
* <strong>TransactionComment</strong>
* <strong>TransactionCommentActive</strong>
* <strong>TransactionCommentCreate</strong>
* <strong>TransactionCommentListResponse</strong>
* <strong>TransactionCommentSearchResponse</strong>
* <strong>TransactionCompletion</strong>
* <strong>TransactionCompletionBehavior</strong>
* <strong>TransactionCompletionDetails</strong>
* <strong>TransactionCompletionMode</strong>
* <strong>TransactionCompletionState</strong>
* <strong>TransactionCreate</strong>
* <strong>TransactionEnvironmentSelectionStrategy</strong>
* <strong>TransactionGroup</strong>
* <strong>TransactionGroupState</strong>
* <strong>TransactionInvoice</strong>
* <strong>TransactionInvoiceComment</strong>
* <strong>TransactionInvoiceCommentActive</strong>
* <strong>TransactionInvoiceCommentCreate</strong>
* <strong>TransactionInvoiceReplacement</strong>
* <strong>TransactionInvoiceState</strong>
* <strong>TransactionLineItemVersion</strong>
* <strong>TransactionLineItemVersionCreate</strong>
* <strong>TransactionLineItemVersionState</strong>
* <strong>TransactionListResponse</strong>
* <strong>TransactionPending</strong>
* <strong>TransactionSearchResponse</strong>
* <strong>TransactionState</strong>
* <strong>TransactionUserInterfaceType</strong>
* <strong>TransactionVoid</strong>
* <strong>TransactionVoidListResponse</strong>
* <strong>TransactionVoidMode</strong>
* <strong>TransactionVoidSearchResponse</strong>
* <strong>TransactionVoidState</strong>
* <strong>TwoFactorAuthenticationType</strong>
* <strong>User</strong>
* <strong>UserAccountRole</strong>
* <strong>UserAccountRoleListResponse</strong>
* <strong>UserSpaceRole</strong>
* <strong>UserSpaceRoleListResponse</strong>
* <strong>UserType</strong>
* <strong>WalletType</strong>
* <strong>WebAppConfirmationResponse</strong>
* <strong>WebhookIdentity</strong>
* <strong>WebhookListener</strong>
* <strong>WebhookListenerCreate</strong>
* <strong>WebhookListenerEntity</strong>
* <strong>WebhookListenerListResponse</strong>
* <strong>WebhookListenerSearchResponse</strong>
* <strong>WebhookListenerUpdate</strong>
* <strong>WebhookURLListResponse</strong>
* <strong>WebhookURLSearchResponse</strong>
* <strong>WebhookUrl</strong>
* <strong>WebhookUrlCreate</strong>
* <strong>WebhookUrlUpdate</strong>

</details>

## Documentation for Error Codes

While working with webhooks, the `WalleeSdkException` may throw various error codes to help identify and troubleshoot issues.

### Error Code Categories

| **Exception**              | **Description**                                                                       |
|----------------------------|---------------------------------------------------------------------------------------|
| **ApiExceptionErrorCodes** | Lists the possible HTTP error codes an `ApiException` can generate                    |
| **SdkExceptionErrorCodes** | Lists the possible error codes a `WalleeSdkException` can generate |

### Usage Example
```csharp
try
{
    // Operation which can throw ApiException
}
catch (ApiException e)
{
    if (ApiExceptionErrorCodes.CONFLICT.Matches(ex))
    {
        // Retry
    }
    else
    {
        // Other handling
    }
}
```

## Recommendation

It's recommended to create an instance of `Configuration` per thread in a multithreaded environment to avoid any potential issues.

## Author

- Wallee Ecosystem Team<br><br>

*Automatically generated by the [OpenAPI Generator](https://openapi-generator.tech)*
<br>Generator version: 7.13.0

## License

Please see the [license file](https://github.com/wallee-payment/csharp-sdk/blob/master/LICENSE) for more information.
