using System;

namespace ExtensionMetods.Extensions
{
    static class StringExtensions
    {
        public static string Cut(this string thisString, int characters)
        {
            if (thisString.Length <= characters)
            {
                return thisString;
            }
            else
            {
                return thisString.Substring(0, characters) + "...";
            }
        }
    }
}
