using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitono.Translator
{
    public static class Notices
    {
        public static Dictionary<string, int> LangNum = new Dictionary<string, int> {
            {"english", 0},
            {"chinese", 1},
            {"hindi", 2},
            {"spanish", 3},
            {"french", 4},
            {"arabic", 5},
            {"bengali", 6},
            {"portuguese", 7},
            {"russian", 8},
            {"urdu", 9},
            {"indonesian", 10},
            {"german", 11},
            {"japanese", 12},
            {"dutch", 13},
        };
        public static Dictionary<string, List<string>> notices = new Dictionary<string, List<string>> {
            {"No arguments found. ", new List<string> {"No arguments found. ", "没有参数。 ", "कोई पैरामीटर नहीं मिला | ", "No hay parámetros. ", "Il n'y a pas de paramètres. ", "لم يتم العثور على أي معلمات. ", "কোন পরামিতি নেই. ", "Não há parâmetros. ", "Параметры отсутствуют. ", "وئی پیرامیٹرز نہیں ملے۔. ", "Tidak ada parameter. ", "Keine Parameter gefunden. ", "パラメータがありません。 ", "Er zijn geen parameters. " } },
            {"Invalid file path. ", new List<string> { "Invalid file path. ", "文件路径无效。 ", "फ़ाइल पथ अमान्य है | ", "La ruta del archivo no es válida. ", "Le chemin du fichier est invalide. ", "مسار الملف غير صالح. ", "ফাইল পাথ অবৈধ. ", "O caminho do ficheiro é inválido. ", "Путь к файлу недействителен. ", "فائل کا راستہ غلط ہے۔. ", "Jalur file tidak valid. ", "Der Dateipfad ist ungültig. ", "ファイルパスが無効です。 ", "Het bestandspad is ongeldig. " } },
            {"Traceback (most recent call last)", new List<string> { "Traceback (most recent call last)", "回拨（最近的通话出现在最后）", "कॉलबैक (सबसे हालिया कॉल अंत में दिखाई देती है)", "Retrollamada (la llamada más reciente aparece al final)", "Rappel (l'appel le plus récent apparaît à la fin)", "رد الاتصال )تظهر المكالمة الأخيرة في النهاية(", "কলব্যাক (সবচেয়ে সাম্প্রতিক কল শেষে প্রদর্শিত হবে)", "Retorno de chamada (a chamada mais recente aparece no final)", "Обратный вызов (последний вызов отображается в конце)", "کال بیک )آخری کال آخر میں ظاہر ہوتی ہے(", "Panggilan balik (panggilan terakhir muncul di akhir)", "Rückruf (letzter Anruf erscheint am Ende)", "コールバック (最新の通話が最後に表示されます)", "Terugbellen (meest recente oproep verschijnt aan het einde)" } },
        };
        public static string DisplayArabicOrUrdu(string ArabicOrUrduString)
        {
            char[] charArray = ArabicOrUrduString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string LocaleString(string language, string text)
        {
            if (language != "arabic" && language != "urdu" && LangNum.ContainsKey(language))
            {
                return Notices.notices[text][Notices.LangNum[language]];
            }
            else if (language == "arabic" || language == "urdu")
            {
                return DisplayArabicOrUrdu(Notices.notices[text][Notices.LangNum[language]]);
            }
            return text;
        }
    }
}
