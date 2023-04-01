using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.Json;

namespace LogicLayer.Service
{
    public static class JSONService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="content"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool ConvertJSONToObject<T>(string content, out T result)
        {
            result = JsonSerializer.Deserialize<T>(content)!;

            if (result == null) return false;
            return true;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool ConvertObjectToJSON(object content, out string result)
        {
            try
            {
                result = JsonSerializer.Serialize(content);
                return true;
            } catch (NotSupportedException)
            {
                result = null!;
                return false;
            }
        }
    }
}
