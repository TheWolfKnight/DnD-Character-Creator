using System;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;
using Microsoft.VisualBasic;

namespace DnD_Charactor_Creator.Src.Services
{
    public static class JsonService
    {

        /// <summary>
        /// Converts a <b>JSON</b> string to a object in memory.
        /// </summary>
        /// <typeparam name="T"> The type that the <paramref name="json"/> string shall be converted to </typeparam>
        /// <param name="json"> The string that will be converted into a object </param>
        /// <returns> An instance of <typeparamref name="T"/> with the values from <paramref name="json"/> </returns>
        public static T JsonToObject<T>(string json)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.AllowTrailingCommas = true;

            T result = JsonSerializer.Deserialize<T>(json, options)!;
            return result;
        }

        /// <summary>
        /// Converts an object into a <b>JSON</b> string
        /// </summary>
        /// <param name="value"> The object to be converted into a <b>JSON</b> string </param>
        /// <returns> A string in <b>JSON</b> format, containing the information of the <paramref name="value"/> object </returns>
        public static string ObjectToJson(object value)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.AllowTrailingCommas = true;

            string result = JsonSerializer.Serialize(value, options);
            return result;
        }
    }
}
