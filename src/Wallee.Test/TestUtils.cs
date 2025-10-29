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

using System.Collections.Generic;
using Wallee.Model;

namespace Wallee.Test;

public abstract class TestUtils
{
    public static TransactionCreate GetTransactionCreatePayload()
    {
        var lineItem = new LineItemCreate(
            name: "Red T-Shirt",
            uniqueId: "5412",
            type: LineItemType.PRODUCT,
            quantity: 1m,
            amountIncludingTax: 29.95m,
            sku: "red-t-shirt-789"
        );

        string email = "test@domain.com";

        var address = new AddressCreate(
            city: "Winterthur",
            country: "CH",
            emailAddress: email,
            familyName: "Customer",
            givenName: "Good",
            postcode: "8400",
            postalState: "ZH",
            organizationName: "Test GmbH",
            mobilePhoneNumber: "+41791234567",
            salutation: "Ms"
        );

        var transactionCreate = new TransactionCreate(
            autoConfirmationEnabled: true,
            currency: "CHF",
            language: "en-US",
            customerId: "1234",
            customerEmailAddress: email,
            billingAddress: address,
            shippingAddress: address,
            lineItems: new List<LineItemCreate> { lineItem }
        );

        return transactionCreate;
    }
}