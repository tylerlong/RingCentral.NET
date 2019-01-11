using System.Linq;
using Newtonsoft.Json;

namespace RingCentral
{
    public static class ExtensionMethods
    {
        private static readonly JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        public static string ToJsonString(this object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.None, jsonSerializerSettings);
        }
        public static string ToQueryString(this object obj)
        {
            var fields = obj.GetType().GetFields()
                .Where(f => f.GetValue(obj) != null)
                .Select(f => $"{f.Name}={f.GetValue(obj)}")
                .ToArray();
            return string.Join("&", fields);
        }
    }
}