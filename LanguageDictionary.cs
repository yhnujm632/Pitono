using System.Globalization;

public static class LanguageDictionary
{
    public static Dictionary<string, string> enToEs = new Dictionary<string, string>
    {
        {"if", "si"},
        {"elif", "otsi"},
        {"else", "otro"},
        {"print", "imprimir"},
        {"float", "float"},
        {"input", "entrada"},
        {"str", "cad"},
        {"string", "cadena"},
    };
    public static Dictionary<string, string> esToEn = enToEs.ToDictionary(x => x.Value, x=> x.Key);
}