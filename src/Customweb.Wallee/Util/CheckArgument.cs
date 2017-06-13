using System;

namespace Customweb.Wallee
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
