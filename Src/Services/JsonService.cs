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
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T JsonToObject<T>(string json)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.AllowTrailingCommas = true;

            T result = JsonSerializer.Deserialize<T>(json, options)!;
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ObjectToJson(object value)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.AllowTrailingCommas = true;

            string result = JsonSerializer.Serialize(value, options);
            return result;
        }
    }
}
