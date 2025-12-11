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
using Wallee.Client;

namespace Wallee.Client
{
    /// <summary>
    /// SDK Local Error Codes
    /// </summary>
    public class SdkExceptionErrorCodes
    {
        // Unknown webhook signature public key
        public static readonly SdkExceptionErrorCodes UNKNOWN_WEBHOOK_ENCRYPTION_PUBLIC_KEY = new("unknown_public_key");
        // General webhook encryption error
        public static readonly SdkExceptionErrorCodes WEBHOOK_ENCRYPTION_GENERAL_ERROR = new("encryption_error");
        // Invalid webhook signature public key
        public static readonly SdkExceptionErrorCodes INVALID_WEBHOOK_ENCRYPTION_PUBLIC_KEY = new("invalid_public_key");
        // Invalid webhook signature header
        public static readonly SdkExceptionErrorCodes INVALID_WEBHOOK_ENCRYPTION_HEADER_FORMAT = new("invalid_webhook_header");
        // Unsupported webhook signature algorithm
        public static readonly SdkExceptionErrorCodes UNSUPPORTED_WEBHOOK_ENCRYPTION_ALGORYTHM = new("unsupported_encryption_algorythm");
        // Unknown webhook encryption provider
        public static readonly SdkExceptionErrorCodes UNKNOWN_WEBHOOK_ENCRYPTION_PROVIDER = new("unknown_encryption_provider");
        // Encryption verifier initialization error
        public static readonly SdkExceptionErrorCodes WEBHOOK_ENCRYPTION_VERIFIER_INIT_ERROR = new("verifier_init_failure");
        // Error during content update in encryption verifier
        public static readonly SdkExceptionErrorCodes WEBHOOK_ENCRYPTION_VERIFIER_CONTENT_UPDATE_ERROR = new("content_update_failure");
        // Encryption signature verification failed
        public static readonly SdkExceptionErrorCodes WEBHOOK_ENCRYPTION_SIGNATURE_VERIFICATION_FAILED = new("signature_verification_failure");
        // Invalid webhook content signature
        public static readonly SdkExceptionErrorCodes INVALID_WEBHOOK_ENCRYPTION_CONTENT_SIGNATURE = new("invalid_content_signature");
        // Missing webhook signature algorithm value
        public static readonly SdkExceptionErrorCodes MISSING_WEBHOOK_ENCRYPTION_ALGORYTHM = new("missing_encryption_algorythm");

        public string Code { get; }

        private SdkExceptionErrorCodes(string code)
        {
            Code = code;
        }

        public bool Matches(WalleeSdkException sdkException)
        {
            return sdkException.Code == this.Code;
        }
    }
}