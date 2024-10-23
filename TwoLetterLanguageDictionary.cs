using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pitono
{
    public static class TwoLetterLanguageDictionary
    {
        public static Dictionary<string, string> getFullName = new Dictionary<string, string>() {
            {"en", "english"},
            {"zh-CN", "chinese"},
            {"hi", "hindi"},
            {"es", "spanish"},
            {"fr", "french"},
            {"ar", "arabic"},
            {"bn", "bengali"},
            {"pt", "portuguese"},
            {"ru", "russian"},
            {"ur", "urdu"},
            {"id", "indonesian"},
            {"de", "german"},
            {"ja", "japanese"},
            {"nl", "dutch"},
        };
        public static Dictionary<string, string> getAbbr = new Dictionary<string, string>() {
            {"english", "en"},
            {"chinese", "zh-CN"},
            {"hindi", "hi"},
            {"spanish", "es"},
            {"french", "fr"},
            {"arabic", "ar"},
            {"bengali", "bn"},
            {"portuguese", "pt"},
            {"russian", "ru"},
            {"urdu", "ur"},
            {"indonesian", "id"},
            {"german", "de"},
            {"japanese", "ja"},
            {"dutch", "nl"},
        };
        public static Dictionary<string, string> getExtension = new Dictionary<string, string>() {
            {"english", ".py"},
            {"chinese", ".蟒"},
            {"hindi", ".अजगर"},
            {"spanish", ".pitón"},
            {"french", ".lepython"},
            {"arabic", ".بايثون"},
            {"bengali", ".পাইথন"},
            {"portuguese", ".pitão"},
            {"russian", ".питон"},
            {"urdu", ".ازگر"},
            {"indonesian", ".ularpiton"},
            {"german", ".riesenschlange"},
            {"japanese", ".パイソン"},
            {"dutch", ".depython"},
        };
        public static Dictionary<string, string> getFullNameFromExtension = new Dictionary<string, string>() {
            {".py", "english"},
            {".蟒", "chinese"},
            {".अजगर" , "hindi"},
            {".pitón" , "spanish"},
            {".lepython" , "french"},
            {".بايثون" , "arabic"},
            {".পাইথন" , "bengali"},
            {".pitão" , "portuguese"},
            {".питон" , "russian"},
            {".ازگر" , "urdu"},
            {".ularpiton" , "indonesian"},
            {".riesenschlange" , "german"},
            {".パイソン" , "japanese"},
            {".depython" , "dutch"},
        };

        private static readonly Regex cjkCharRegex = new Regex(@"\p{IsCJKUnifiedIdeographs}");
        public static bool IsChinese(this char c)
        {
            return cjkCharRegex.IsMatch(c.ToString());
        }

        private static readonly Regex devanagariCharRegex = new Regex(@"\p{IsDevanagari}");
        public static bool IsHindi(this char c)
        {
            return devanagariCharRegex.IsMatch(c.ToString());
        }

        private static readonly Regex bengaliCharRegex = new Regex(@"\p{IsBengali}");
        public static bool IsBengali(this char c)
        {
            return devanagariCharRegex.IsMatch(c.ToString());
        }

    }
}
