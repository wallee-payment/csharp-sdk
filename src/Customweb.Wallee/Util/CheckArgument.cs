/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;

namespace Customweb.Wallee.Util
{

	/// <summary>
	/// A utility class which helps to conveniently assert characteristics
	/// of method arguments to support a defensive coding style.
	/// </summary>
    public static class CheckArgument
    {
        public static T? NotNull<T>(String label, T? argument) where T : struct
        {
            if (argument == null)
            {
                throw CreateANE(Label(label) + " must not be null");
            }
            return argument;
        }

        public static T NotNull<T>(String label, T argument) where T : class
        {
            if(argument == null)
            {
                throw CreateANE(Label(label) + " must not be null");
            }
            return argument;
        }

        public static String NotNull(String label, String argument)
        {
            if (argument == null)
            {
                throw CreateANE(Label(label) + " must not be null");
            }
            return argument;
        }

        public static String NotEmpty(String label, String argument)
        {
            NotNull(label, argument);
            if(argument.Length == 0)
            {
                throw CreateAE(Label(label) + " must not be empty");
            }
            return argument;
        }

        private static ArgumentNullException CreateANE(String message)
        {
            return new ArgumentNullException(message);
        }

        private static ArgumentException CreateAE(String message)
        {
            return new ArgumentException(message);
        }

        private static String Label(String label)
        {
            return String.IsNullOrEmpty(label) ? "?" : label;
        }
    }
}
