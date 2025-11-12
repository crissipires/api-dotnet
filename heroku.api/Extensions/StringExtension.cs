using System;
using System.Globalization;

namespace heroku.api.Extensions
{
    public static class StringExtension
    {
        public static int? ToNullableInt32(this string value)
        {
            value = ReplaceNullString(value);
            return string.IsNullOrEmpty(value) ? default(int?) : Convert.ToInt32(value, CultureInfo.CurrentCulture);
        }

        public static DateTime? ToNullableDateTime(this string value)
        {
            value = ReplaceNullString(value);
            if (string.IsNullOrEmpty(value))
                return default;
            
            var dataConvertida = Convert.ToDateTime(value,CultureInfo.CurrentCulture).ToString("G", CultureInfo.CurrentCulture);
            
            return Convert.ToDateTime(dataConvertida, CultureInfo.CurrentCulture);
        }
        
        private static string ReplaceNullString(string value) =>
            value?.Replace("null", string.Empty);
    }
}