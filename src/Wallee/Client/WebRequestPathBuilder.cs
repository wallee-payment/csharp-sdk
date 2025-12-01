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
using System.Text.RegularExpressions;

namespace Wallee.Client;

/// <summary>
/// A URI builder
/// </summary>
internal class WebRequestPathBuilder(string path)
{
    private string _path = path;
    private string _query = "?";

    // FIXME: Event though the RestSharp is using Uri.EscapeDataString for encoding the url parameters.
    // e.g. the RestSharp is encoding space in query with lower case, while Uri.EscapeDataString with upper case.
    // Also check encoding for cases when * and () is used the query
    private static readonly Regex _percentEncodedRegex = new(@"%[0-9a-fA-F]{2}");

    public void AddPathParameters(Dictionary<string, string> parameters)
    {
        foreach (var parameter in parameters)
        {
            _path = _path.Replace("{" + parameter.Key + "}", LowerEncodedParams(parameter.Value));
        }
    }

    public void AddQueryParameters(Multimap<string, string> parameters)
    {
        foreach (var parameter in parameters)
        {
            foreach (var value in parameter.Value)
            {
                _query = _query + parameter.Key + "=" + EncodedParams(value) + "&";
            }
        }
    }

    private string EncodedParams(string parameter)
    {
        var encodedParam = Uri.EscapeDataString(parameter);
        return encodedParam;
    }

    private string LowerEncodedParams(string parameter)
    {
        var encodedParam = Uri.EscapeDataString(parameter);

        var lowerEncodedParams = _percentEncodedRegex.Replace(encodedParam,
            match => match.Value.ToLowerInvariant());

        return lowerEncodedParams;
    }

    public string GetFullUri()
    {
        return string.Concat(_path, _query.AsSpan(0, _query.Length - 1));
    }
}
