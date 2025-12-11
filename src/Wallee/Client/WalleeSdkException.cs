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

namespace Wallee.Client
{
    /// <summary>
    /// Exception thrown when an internal SDK error occurs.
    /// </summary>
    public class WalleeSdkException : Exception
    {
        /// <summary>
        /// SDK error code.
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="code">SDK error code</param>
        /// <param name="message">Exception message details</param>
        public WalleeSdkException(string code, string message)
            : base($"Error code: {code}. {message}")
        {
            this.Code = code;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="code">SdkExceptionErrorCodes error code</param>
        /// <param name="message">Exception message details</param>
        public WalleeSdkException(SdkExceptionErrorCodes code, string message)
            : base($"Error code: {code.Code}. {message}")
        {
            this.Code = code.Code;
        }
    }
}