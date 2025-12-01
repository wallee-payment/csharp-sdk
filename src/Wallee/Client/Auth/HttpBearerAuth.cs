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
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using RestSharp;

namespace Wallee.Client.Auth
{
    /// <summary>
    /// An authenticator for JWT Bearer authentication flow
    /// </summary>
    public class HttpBearerAuth : IAuthentication
    {
        private const string ApiPrefix = "/api/v2.0";
        private readonly long _applicationUserId;
        private readonly string _authenticationKey;

        /// <summary>
        /// Initialize the Bearer Authenticator
        /// </summary>
        public HttpBearerAuth(long applicationUserId, string authenticationKey)
        {
            _applicationUserId = applicationUserId;
            _authenticationKey = authenticationKey;
        }

        /// <summary>
        /// Creates an authorization parameter with the JWT bearer token.
        /// </summary>
        /// <returns>An authentication parameter.</returns>
        public HeaderParameter GetAuthParam(string path, HttpMethod method, Dictionary<string, string> pathParameters,
            Multimap<string, string> queryParameters)
        {
            return new HeaderParameter(KnownHeaders.Authorization,
                GetBearerToken(path, method, pathParameters, queryParameters));
        }

        /// <summary>
        /// Generate the JWT token.
        /// </summary>
        /// <returns>An authentication token.</returns>
        private string GetBearerToken(string path, HttpMethod method, Dictionary<string, string> pathParameters,
            Multimap<string, string> queryParameters)
        {
            var key = new SymmetricSecurityKey(Convert.FromBase64String(_authenticationKey));
            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, _applicationUserId.ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.Now.ToUnixTimeSeconds().ToString(),
                    ClaimValueTypes.Integer64),
                new Claim("requestPath", GetFullUri(path, pathParameters, queryParameters)),
                new Claim("requestMethod", method.ToString().ToUpper())
            };

            var header = new JwtHeader(signingCredentials)
            {
                { "ver", "1" }
            };

            var bearerToken = new JwtSecurityToken(header, new JwtPayload(claims));
            var tokenString = new JwtSecurityTokenHandler().WriteToken(bearerToken);
            return $"Bearer {tokenString}";
        }

        private string GetFullUri(string path, Dictionary<string, string> pathParameters,
            Multimap<string, string> queryParameters)
        {
            var webRequestPathBuilder = new WebRequestPathBuilder(path);
            webRequestPathBuilder.AddPathParameters(pathParameters);
            webRequestPathBuilder.AddQueryParameters(queryParameters);
            return $"{ApiPrefix}{webRequestPathBuilder.GetFullUri()}";
        }
    }
}