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

namespace Wallee.Client
{
    /// <summary>
    /// Represents potential error codes that may be thrown by the Wallee SDK.
    ///
    /// <para><b>Error Code Ranges:</b></para>
    /// <list type="bullet">
    ///   <item><b>1000–1999:</b> Client-side errors - typically due to invalid input (e.g., malformed headers, bad keys).</item>
    ///   <item><b>2000–2999:</b> Server-side errors - typically due to incorrect data provided by the server.</item>
    ///   <item><b>404:</b> Not Found — used when endpoint returns an empty result.</item>
    /// </list>
    /// </summary>
    public class ErrorCode
    {
        // 404
        public static readonly ErrorCode UNKNOWN_WEBHOOK_ENCRYPTION_PUBLIC_KEY = new ErrorCode(404, "Unknown webhook signature public key");

        // 1000-1999
        public static readonly ErrorCode WEBHOOK_ENCRYPTION_GENERAL_ERROR = new ErrorCode(1000, "General webhook encryption error");
        public static readonly ErrorCode INVALID_WEBHOOK_ENCRYPTION_PUBLIC_KEY = new ErrorCode(1001, "Invalid webhook signature public key");
        public static readonly ErrorCode INVALID_WEBHOOK_ENCRYPTION_HEADER_FORMAT = new ErrorCode(1002, "Invalid webhook signature header");
        public static readonly ErrorCode UNKNOWN_WEBHOOK_ENCRYPTION_PROVIDER = new ErrorCode(1004, "Unknown webhook encryption provider");
        public static readonly ErrorCode UNSUPPORTED_WEBHOOK_ENCRYPTION_ALGORYTHM = new ErrorCode(1003, "Unsupported webhook signature algorithm");
        public static readonly ErrorCode WEBHOOK_ENCRYPTION_SIGNATURE_VERIFICATION_FAILED = new ErrorCode(1007, "Encryption signature verification failed");
        public static readonly ErrorCode INVALID_WEBHOOK_ENCRYPTION_CONTENT_SIGNATURE = new ErrorCode(1008, "Invalid webhook content signature");

        // 2000-2999
        public static readonly ErrorCode MISSING_WEBHOOK_ENCRYPTION_ALGORYTHM = new ErrorCode(2000, "Missing webhook signature algorithm value");

        public int Code { get; }
        public string Description { get; }

        private ErrorCode(int code, string description)
        {
            this.Code = code;
            this.Description = description;
        }

        public override string ToString()
        {
            return $"{Code}: {Description}";
        }
    }
}
