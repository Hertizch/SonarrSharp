using System.Collections.Generic;

namespace SonarrSharp.Helpers
{
    internal class ParameterHelper
    {
        /// <summary>
        /// Builds the parameter string.
        /// </summary>
        /// <param name="keyValuePairs">The key value pairs.</param>
        /// <returns></returns>
        internal static string BuildParameterString(Dictionary<string, object> keyValuePairs)
        {
            if (keyValuePairs.Count == 0) return null;

            string output = null;
            bool firstParam = true;

            foreach (var keyValue in keyValuePairs)
            {
                if (firstParam)
                {
                    output += $"?{keyValue.Key}={keyValue.Value.ToString()}";
                    firstParam = false;
                    continue;
                }

                output += $"&{keyValue.Key}={keyValue.Value.ToString()}";
            }

            return output;
        }
    }
}
