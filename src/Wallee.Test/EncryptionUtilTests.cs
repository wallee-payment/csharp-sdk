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
using NUnit.Framework;
using System.IO;
using Wallee.Util;
using Wallee.Client;

namespace Wallee.Test;

/// <summary>
/// Class for testing EncryptionUtil
/// </summary>
[TestFixture]
public class EncryptionUtilTests
{
    private const string SIGNATURE_ALGORITHM = "SHA256withECDSA";

    private const string VALID_CONTENT_TO_VERIFY =
    "{\"entityId\":11,\"eventId\":35,\"listenerEntityId\":1472041829003,\"listenerEntityTechnicalName\":\"Transaction\",\"spaceId\":1,\"state\":\"PROCESSING\",\"timestamp\":\"2023-12-19T13:43:35+0000\",\"webhookListenerId\":2}";

    private const string VALID_CONTENT_SIGNATURE =
    "MEYCIQCTzbMrMsOAC6T57T9kQTb1iGZVg2R7n6pY9A4ML4P31gIhAIOoav8cG8x0jpRWQztqSJIC8gXWKq+4DuENEySvmMYf";

    private const string VALID_PUBLIC_KEY =
    "MFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAEdWq7ZBGsjUzhBO3e6mzUBLpjpV3TQw1bL1rk3ocjn5C5qne7TY0OBBhiWgaPtWlvUcqASz903vtfeSTQma+SBA==";

    [Test]
    public void ValidationShouldPassForValidContentSignatureAndKey()
    {
        bool result = EncryptionUtil.IsContentValid(
            VALID_CONTENT_TO_VERIFY,
            VALID_CONTENT_SIGNATURE,
            VALID_PUBLIC_KEY,
            SIGNATURE_ALGORITHM
        );

        Assert.That(result == true, "Valid public key, signature and content must fit each other");
    }

    [Test]
    public void ValidationShouldFailForBadContent()
    {
        bool result = EncryptionUtil.IsContentValid(
            "ModifiedContent",
            VALID_CONTENT_SIGNATURE,
            VALID_PUBLIC_KEY,
            SIGNATURE_ALGORITHM
        );

        Assert.That(result == false, "Invalid content should fail validation");
    }

    [Test]
    public void ValidationShouldFailForBadSignatureFormat()
    {

        bool result = EncryptionUtil.IsContentValid(
            VALID_CONTENT_TO_VERIFY,
            "InvalidModifiedSignature",
            VALID_PUBLIC_KEY,
            SIGNATURE_ALGORITHM
        );

        Assert.That(result == false, "Invalid modified signature should fail validation");

    }

    [Test]
    public void ValidationShouldFailForBadSignatureBase64Format()
    {
        Assert.Throws<WalleeSdkException>(() =>
        {
            EncryptionUtil.IsContentValid(
                VALID_CONTENT_TO_VERIFY,
                "MEYCIQCTzbMrMsOAC6T57T9kQTb1iGZVg2R7n6pY9A4ML4P31gIhAIOoav8cG8x0jpRWQztqSJIC8gXWKq",
                VALID_PUBLIC_KEY,
                SIGNATURE_ALGORITHM
            );
        });
    }

    [Test]
    public void ValidationShouldFailForBadPublicKeyFormat()
    {
        Assert.Throws<WalleeSdkException>(() =>
        {
            EncryptionUtil.IsContentValid(
                VALID_CONTENT_TO_VERIFY,
                VALID_CONTENT_SIGNATURE,
                "InvalidModifiedPublicKey",
                SIGNATURE_ALGORITHM
            );
        });
    }

    [Test]
    public void ValidationShouldFailForBadPublicKeyBase64Format()
    {
        Assert.Throws<WalleeSdkException>(() =>
        {
            EncryptionUtil.IsContentValid(
                VALID_CONTENT_TO_VERIFY,
                VALID_CONTENT_SIGNATURE,
                "MFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAEdWq7ZBGsjUzhBO3e6mzUBLpjpV3TQw1bL1rk3ocjn5C5qne7TY0OBBhiWgaPtWlvUcqASz903vtfeSTQm",
                SIGNATURE_ALGORITHM
            );
        });
    }
}