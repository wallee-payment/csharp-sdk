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
    /// ApiException Error Codes
    /// </summary>
    public class ApiExceptionErrorCodes
    {
        /*
         * This class represents possible HTTP error codes which can be sent by the API.
         * This list corresponds to https://app-wallee.com/en-us/doc/api/web-service#_errors
         */
        public static readonly ApiExceptionErrorCodes BAD_REQUEST = new(400);
        public static readonly ApiExceptionErrorCodes UNAUTHORIZED = new(401);
        public static readonly ApiExceptionErrorCodes FORBIDDEN = new(403);
        public static readonly ApiExceptionErrorCodes NOT_FOUND = new(404);
        public static readonly ApiExceptionErrorCodes NOT_ACCEPTABLE = new(406);
        public static readonly ApiExceptionErrorCodes CONFLICT = new(409);
        public static readonly ApiExceptionErrorCodes PAYLOAD_TOO_LARGE = new(413);
        public static readonly ApiExceptionErrorCodes UNSUPPORTED_MEDIA_TYPE = new(415);
        public static readonly ApiExceptionErrorCodes RANGE_NOT_SATISFIABLE = new(416);
        public static readonly ApiExceptionErrorCodes UNPROCESSABLE_ENTITY = new(422);
        public static readonly ApiExceptionErrorCodes TOO_MANY_REQUESTS = new(429);
        public static readonly ApiExceptionErrorCodes INTERNAL_SERVER_ERROR = new(500);

        public int HttpCode { get; }

        private ApiExceptionErrorCodes(int httpCode)
        {
            HttpCode = httpCode;
        }

        public bool Matches(ApiException apiException)
        {
            return apiException.ErrorCode == this.HttpCode;
        }
    }
}