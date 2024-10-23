using Pitono;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

public class LanguageDictionary
{
    //SPANISH

    // English to Spanish
    public Dictionary<string, string> enToEs = Spanish.spanish;
    // Spanish to English
    public Dictionary<string, string> esToEn;

    //CHINESE (SIMPLIFIED)

    // English to Chinese
    public Dictionary<string, string> enToZh = Chinese.chinese;
    // Chinese to English
    public Dictionary<string, string> zhToEn;

    //HINDI

    // English to Hindi
    public Dictionary<string, string> enToHi = Hindi.hindi;
    // Hindi to English
    public Dictionary<string, string> hiToEn;

    //FRENCH

    // English to French
    public Dictionary<string, string> enToFr = French.french;
    // French to English
    public Dictionary<string, string> frToEn;

    //BENGALI

    // English to Bengali
    public Dictionary<string, string> enToBn = Bengali.bengali;
    // Bengali to English
    public Dictionary<string, string> bnToEn;

    //PORTUGUESE

    //English to Portuguese
    public Dictionary<string, string> enToPt = Portuguese.portuguese;
    //Portuguese to English
    public Dictionary<string, string> ptToEn;

    //RUSSIAN

    // English to Russian
    public Dictionary<string, string> enToRu = Russian.russian;
    // Russian to English
    public Dictionary<string, string> ruToEn;

    //INDONESIAN

    // English to Indonesian
    public Dictionary<string, string> enToId = Indonesian.indonesian;
    // Indonesian to English
    public Dictionary<string, string> idToEn;

    //GERMAN

    // English to German
    public Dictionary<string, string> enToDe = German.german;
    // German to English
    public Dictionary<string, string> deToEn;

    //JAPANESE

    // English to Japanese
    public Dictionary<string, string> enToJa = Japanese.japanese;
    // Japanese to English
    public Dictionary<string, string> jaToEn;

    //DUTCH

    // English to Dutch
    public Dictionary<string, string> enToNl = Dutch.dutch;
    // Dutch to English
    public Dictionary<string, string> nlToEn;

    //ENGLISH

    // English to English
    public Dictionary<string, string> enToEn = English.english;

    //ARABIC

    // English to Arabic
    public Dictionary<string, string> enToAr = English.english;
    // Arabic to English
    public Dictionary<string, string> arToEn = English.english;

    //URDU

    // English to Urdu
    public Dictionary<string, string> enToUr = English.english;
    // Urdu to English
    public Dictionary<string, string> urToEn = English.english;

    public LanguageDictionary()
    {
        zhToEn = enToZh.ToDictionary(x => x.Value, x => x.Key);
        hiToEn = enToHi.ToDictionary(x => x.Value, x => x.Key);
        esToEn = enToEs.ToDictionary(x => x.Value, x => x.Key);
        frToEn = enToFr.ToDictionary(x => x.Value, x => x.Key);
        bnToEn = enToBn.ToDictionary(x => x.Value, x => x.Key);
        ptToEn = enToPt.ToDictionary(x => x.Value, x => x.Key);
        ruToEn = enToRu.ToDictionary(x => x.Value, x => x.Key);
        idToEn = enToId.ToDictionary(x => x.Value, x => x.Key);
        deToEn = enToDe.ToDictionary(x => x.Value, x => x.Key);
        jaToEn = enToJa.ToDictionary(x => x.Value, x => x.Key);
        nlToEn = enToNl.ToDictionary(x => x.Value, x => x.Key);


        foreach (var mc in enToEn)
        {
            enToEn[mc.Key] = mc.Key;
        }
    }

    public void printDictionary()
    {
        foreach (var res in esToEn)
        {
            Console.WriteLine("Key: {0} || Value: {1}", res.Key, res.Value);
        }
    }
}