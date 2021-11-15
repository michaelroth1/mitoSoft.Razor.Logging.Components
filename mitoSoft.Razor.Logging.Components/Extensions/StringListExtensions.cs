using System.Collections.Generic;

namespace mitoSoft.Razor.Logging.Components.Extensions
{
    internal static class StringListExtensions
    {
        public static List<string> Trim(this List<string> values)
        {
            var result = new List<string>();
            foreach (var value in values)
            {
                result.Add(value.Trim());
            }
            return result;
        }
    }
}