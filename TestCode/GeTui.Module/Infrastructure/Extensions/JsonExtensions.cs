using Newtonsoft.Json;

namespace GeTui.Module.Infrastructure.Extensions
{
    internal static class JsonExtensions
    {
        /// <summary>
        /// 将Json反序列化为对象
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json字段</param>
        public static T ToObject<T>(this string json) where T : class
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// 将字符串反序列化为指定类型的对象
        /// </summary>
        /// <param name="str">String.</param>
        /// <param name="settings">Json Settings.</param>
        /// <typeparam name="T">要反序列化的的对象类型</typeparam>
        public static T AsObject<T>(this string str, JsonSerializerSettings settings = null)
        {
            if (string.IsNullOrWhiteSpace(str))
                return default(T);

            try
            {
                return JsonConvert.DeserializeObject<T>(str, settings ?? new JsonSerializerSettings());
            }
            catch
            {
                return default(T);
            }
        }
    }
}