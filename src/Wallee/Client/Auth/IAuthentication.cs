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
using RestSharp;

namespace Wallee.Client.Auth;

/// <summary>
/// Represents the contract for authentication-related operations.
/// </summary>
public interface IAuthentication
{
    /// <summary>
    /// Applies the Bearer Token to the given header parameters.
    /// </summary>
    HeaderParameter GetAuthParam(string path, HttpMethod method, Dictionary<string, string> pathParameters,
        Multimap<string, string> queryParameters);
}