using Microsoft.VisualBasic;
using Pitono;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
public static class Translator
{
    public static (string outputLine, bool inQuotes, char quotationMarkToSearch) translate(string line, bool inQuotes, char quotationMarkToSearch, string langFrom, string langTo)
    {
        LanguageDictionary dict = new LanguageDictionary();
        Dictionary<string, string> languageDict;
        if (langFrom == "english")
        {
            if (langTo == "chinese")
            {
                languageDict = dict.enToZh;
            }
            else if (langTo == "hindi")
            {
                languageDict = dict.enToHi;
            }
            else if (langTo == "spanish")
            {
                languageDict = dict.enToEs;
            }
            else if (langTo == "french")
            {
                languageDict = dict.enToFr;
            }
            else if (langTo == "bengali")
            {
                languageDict = dict.enToBn;
            }
            else if (langTo == "portuguese")
            {
                languageDict = dict.enToPt;
            }
            else if (langTo == "russian")
            {
                languageDict = dict.enToRu;
            }
            else if (langTo == "indonesian")
            {
                languageDict = dict.enToId;
            }
            else if (langTo == "german")
            {
                languageDict = dict.enToDe;
            }
            else if (langTo == "japanese")
            {
                languageDict = dict.enToJa;
            }
            else if (langTo == "dutch")
            {
                languageDict = dict.enToNl;
            }
            else
            {
                languageDict = dict.enToEn;
            }
        }
        else
        {
            if (langFrom == "chinese")
            {
                languageDict = dict.zhToEn;
            }
            else if (langFrom == "hindi")
            {
                languageDict = dict.hiToEn;
            }
            else if (langFrom == "spanish")
            {
                languageDict = dict.esToEn;
            }
            else if (langFrom == "french")
            {
                languageDict = dict.frToEn;
            }
            else if (langFrom == "bengali")
            {
                languageDict = dict.bnToEn;
            }
            else if (langFrom == "portuguese")
            {
                languageDict = dict.ptToEn;
            }
            else if (langFrom == "russian")
            {
                languageDict = dict.ruToEn;
            }
            else if (langFrom == "indonesian")
            {
                languageDict = dict.idToEn;
            }
            else if (langFrom == "german")
            {
                languageDict = dict.deToEn;
            }
            else if (langFrom == "japanese")
            {
                languageDict = dict.jaToEn;
            }
            else if (langFrom == "dutch")
            {
                languageDict = dict.nlToEn;
            }
            else
            {
                languageDict = dict.enToEn;
            }
        }
        string outputLine = "";
        int currentWordLength = 0;
        bool multiLineString = inQuotes;
        bool inBacktickQuotes = false;
        //quotationMarkToSearch = '"';
        for (int i = 0; i < line.Length; i++)
        {
            //account for commented out lines
            if (line[i] == '#')
            {
                break;
            }

            if (line[i] == '"')
            {
                if ((line.Length > i + 2) && (line[i + 1] == '"') && (line[i + 2] == '"'))
                {
                    if (multiLineString && quotationMarkToSearch == '"')
                    {
                        inQuotes = false;
                        multiLineString = false;
                    }
                    else if (!inQuotes && !inBacktickQuotes)
                    {
                        inQuotes = true;
                        multiLineString = true;
                        quotationMarkToSearch = '"';
                    }
                }
                else
                {
                    if (inQuotes && quotationMarkToSearch == '"' && !multiLineString)
                    {
                        inQuotes = false;
                        multiLineString = false;
                    }
                    else if (!inQuotes && !inBacktickQuotes)
                    {
                        inQuotes = true;
                        multiLineString = false;
                        quotationMarkToSearch = '"';
                    }
                }
            }
            else if (line[i] == '\'')
            {
                if ((line.Length > i + 2) && (line[i + 1] == '\'') && (line[i + 2] == '\''))
                {
                    if (multiLineString && quotationMarkToSearch == '\'')
                    {
                        inQuotes = false;
                        multiLineString = false;
                    }
                    else if (!inQuotes && !inBacktickQuotes)
                    {
                        inQuotes = true;
                        multiLineString = true;
                        quotationMarkToSearch = '\'';
                    }
                }
                else
                {
                    if (inQuotes && quotationMarkToSearch == '\'' && !multiLineString)
                    {
                        inQuotes = false;
                        multiLineString = false;
                    }
                    else if (!inQuotes && !inBacktickQuotes)
                    {
                        inQuotes = true;
                        multiLineString = false;
                        quotationMarkToSearch = '\'';
                    }
                }
            }
            else if (line[i] == '`')
            {
                if (inBacktickQuotes && quotationMarkToSearch == '`')
                {
                    inBacktickQuotes = false;
                    multiLineString = false;
                }
                else if (!inBacktickQuotes && !inQuotes)
                {
                    inBacktickQuotes = true;
                    multiLineString = false;
                    quotationMarkToSearch = '`';
                }
            }

            if (inQuotes)
            {
                outputLine += line[i];
            }
            else if (inBacktickQuotes)
            {
                if (line[i] != '`')
                {
                    outputLine += line[i];
                }
            }
            else if (Char.IsLetter(line[i]) || line[i] == '_' || Char.IsNumber(line[i]) || TwoLetterLanguageDictionary.IsChinese(line[i]) || TwoLetterLanguageDictionary.IsHindi(line[i]) || TwoLetterLanguageDictionary.IsBengali(line[i]))
            {
                currentWordLength++;
            }
            else
            {
                if (currentWordLength > 0)
                {
                    if (languageDict.ContainsKey(line.Substring(i - currentWordLength, currentWordLength)))
                    {
                        outputLine += languageDict[line.Substring(i - currentWordLength, currentWordLength)];
                    }
                    else
                    {
                        outputLine += line.Substring(i - currentWordLength, currentWordLength);
                    }
                }
                currentWordLength = 0;
                outputLine += line[i];
            }
        }
        if (currentWordLength > 0)
        {
            if (languageDict.ContainsKey(line.Substring(line.Length - currentWordLength, currentWordLength)))
            {
                outputLine += languageDict[line.Substring(line.Length - currentWordLength, currentWordLength)];
            }
            else
            {
                outputLine += line.Substring(line.Length - currentWordLength, currentWordLength);
            }
        }
        return (outputLine, inQuotes, quotationMarkToSearch);
    }

    public static (string outputLine, bool inQuotes, char quotationMarkToSearch) translateArabicOrUrdu(string line, bool inQuotes, char quotationMarkToSearch, string langFrom, string langTo)
    {

        LanguageDictionary dict = new LanguageDictionary();
        Dictionary<string, string> languageDict;
        if (langFrom == "english")
        {
            if (langTo == "arabic")
            {
                languageDict = dict.enToAr;
            }
            else if (langTo == "urdu")
            {
                languageDict = dict.enToUr;
            }
            else
            {
                languageDict = dict.enToEn;
            }
        }
        else
        {
            if (langFrom == "arabic")
            {
                languageDict = dict.arToEn;
            }
            else if (langFrom == "urdu")
            {
                languageDict = dict.urToEn;
            }
            else
            {
                languageDict = dict.enToEn;
            }
        }

        
        string outputLine = "";
        int currentWordLength = 0;
        bool multiLineString = inQuotes;
        bool inBacktickQuotes = false;
        //quotationMarkToSearch = '"';
        for (int i = line.Length - 1; i >= 0; i--)
        {
            //account for commented out lines
            if (line[i] == '#')
            {
                break;
            }

            if (line[i] == '"')
            {
                if ((i - 2 >= 0) && (line[i - 1] == '"') && (line[i - 2] == '"'))
                {
                    if (multiLineString && quotationMarkToSearch == '"')
                    {
                        inQuotes = false;
                        multiLineString = false;
                    }
                    else if (!inQuotes && !inBacktickQuotes)
                    {
                        inQuotes = true;
                        multiLineString = true;
                        quotationMarkToSearch = '"';
                    }
                }
                else
                {
                    if (inQuotes && quotationMarkToSearch == '"' && !multiLineString)
                    {
                        inQuotes = false;
                        multiLineString = false;
                    }
                    else if (!inQuotes && !inBacktickQuotes)
                    {
                        inQuotes = true;
                        multiLineString = false;
                        quotationMarkToSearch = '"';
                    }
                }
            }
            else if (line[i] == '\'')
            {
                if ((i - 2 >= 0) && (line[i - 1] == '\'') && (line[i - 2] == '\''))
                {
                    if (multiLineString && quotationMarkToSearch == '\'')
                    {
                        inQuotes = false;
                        multiLineString = false;
                    }
                    else if (!inQuotes && !inBacktickQuotes)
                    {
                        inQuotes = true;
                        multiLineString = true;
                        quotationMarkToSearch = '\'';
                    }
                }
                else
                {
                    if (inQuotes && quotationMarkToSearch == '\'' && !multiLineString)
                    {
                        inQuotes = false;
                        multiLineString = false;
                    }
                    else if (!inQuotes && !inBacktickQuotes)
                    {
                        inQuotes = true;
                        multiLineString = false;
                        quotationMarkToSearch = '\'';
                    }
                }
            }
            else if (line[i] == '`')
            {
                if (inBacktickQuotes && quotationMarkToSearch == '`')
                {
                    inBacktickQuotes = false;
                    multiLineString = false;
                }
                else if (!inBacktickQuotes && !inQuotes)
                {
                    inBacktickQuotes = true;
                    multiLineString = false;
                    quotationMarkToSearch = '`';
                }
            }

            if (inQuotes)
            {
                outputLine += line[i];
            }
            else if (inBacktickQuotes)
            {
                if (line[i] != '`')
                {
                    outputLine += line[i];
                }
            }
            else if (Char.IsLetter(line[i]) || line[i] == '_' || Char.IsNumber(line[i]))
            {
                currentWordLength++;
            }
            else
            {
                if (currentWordLength > 0)
                {
                    if (languageDict.ContainsKey(line.Substring(i, i + currentWordLength)))
                    {
                        outputLine += languageDict[line.Substring(i, i + currentWordLength)];
                    }
                    else
                    {
                        outputLine += line.Substring(i, i + currentWordLength);
                    }
                }
                currentWordLength = 0;
                outputLine += line[i];
            }
        }
        if (currentWordLength > 0)
        {
            if (languageDict.ContainsKey(line.Substring(0, currentWordLength)))
            {
                outputLine += languageDict[line.Substring(0, currentWordLength)];
            }
            else
            {
                outputLine += line.Substring(0, currentWordLength);
            }
        }
        return (outputLine, inQuotes, quotationMarkToSearch);


    }

    public static (string outputLine, bool inQuotes, char quotationMarkToSearch) translate(string line, string langFrom, string langTo)
    {
        bool inQuotes = false;
        char quotationMarkToSearch = '"';
        return translate(line, inQuotes, quotationMarkToSearch, langFrom, langTo);
    }

    public static (string outputLine, bool inQuotes, char quotationMarkToSearch) translate(string line, bool inQuotes, string langFrom, string langTo)
    {
        char quotationMarkToSearch = '"';
        return translate(line, inQuotes, quotationMarkToSearch, langFrom, langTo);
    }

    public static (string outputLine, bool inQuotes, char quotationMarkToSearch) translate(string line, char quotationMarkToSearch, string langFrom, string langTo)
    {
        bool inQuotes = true;
        return translate(line, inQuotes, quotationMarkToSearch, langFrom, langTo);
    }



    public static string translateEngtoEsp(string line)
    {
        LanguageDictionary dict = new LanguageDictionary();
        string outputLine = "";
        int currentWordLength = 0;
        for (int i = 0; i < line.Length; i++)
        {
            if (Char.IsLetter(line[i]) || line[i] == '_')
            {
                currentWordLength++;
            }
            else
            {
                if (currentWordLength > 0)
                {
                    if (dict.enToEs.ContainsKey(line.Substring(i - currentWordLength, currentWordLength)))
                    {
                        outputLine += dict.enToEs[line.Substring(i - currentWordLength, currentWordLength)];
                    }
                    else
                    {
                        outputLine += line.Substring(i - currentWordLength, currentWordLength);
                    }
                }
                currentWordLength = 0;
                outputLine += line[i];
            }
        }
        return outputLine;
    }
}
