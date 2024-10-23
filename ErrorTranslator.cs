using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections;
using Pitono.Translator;
using Pitono;

public static class ErrorTranslator
{
    public static string translateError(string line, string langFrom, string langTo)
    {
        LanguageDictionary dict = new LanguageDictionary();
        Dictionary<string, string> languageDict;
        if (langTo == "chinese") {
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
        else if (langTo == "english")
        {
            languageDict = dict.enToEn;
        }
        else
        {
            languageDict = dict.enToEs;
        }



        if (line.Contains(':') && languageDict.ContainsKey(line.Substring(0, line.IndexOf(':'))))
        {
            return languageDict[line.Substring(0, line.IndexOf(':'))] + GoogleTranslate.googleTranslate(line.Substring(line.IndexOf(':')), "en", TwoLetterLanguageDictionary.getAbbr[langTo]);
        }
        else if (line.Contains("Traceback (most recent call last)"))
        {
            return Notices.LocaleString(langTo, "Traceback (most recent call last)");
        }

        string outputLine = "";
        int currentWordLength = 0;
        bool inQuotes = false;
        for (int i = 0; i < line.Length; i++)
        {
            if (inQuotes && line[i] != '"')
            {
                currentWordLength = 0;
                outputLine += line[i];
                continue;
            }

            if ((Char.IsLetter(line[i]) || line[i] == '_' || Char.IsNumber(line[i]) || TwoLetterLanguageDictionary.IsChinese(line[i]) || TwoLetterLanguageDictionary.IsHindi(line[i]) || TwoLetterLanguageDictionary.IsBengali(line[i])) && !inQuotes)
            {
                currentWordLength++;
            }
            else if (line[i] == '"')
            {
                if (!inQuotes)
                {
                    inQuotes = true;
                }
                else
                {
                    inQuotes = false;
                }
                currentWordLength = 0;
                outputLine += line[i];
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
        return outputLine;
    }



    public static string translateEngToEspError(string line)
    {
        LanguageDictionary dict = new LanguageDictionary();
        int currentWordLength = 0;
        string outputLine = "";
        for (int i = 0; i < outputLine.Length; i++)
        {
            if (Char.IsLetter(outputLine[i]))
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
            }
        }
        return "";
    }
    public static string translateEngToEspErrorGoogleTranslate(string line)
    {
        string outputLine = "";
        //int currentWordLength = 0;



        
        string strCmdText;
        strCmdText = "/C C:\\Users\\josym\\OneDrive\\Development\\Pitono\\Pitono\\bin\\Debug\\net6.0\\translator.exe \"" + line + "\" \"en\" \"es\"";
        //Console.WriteLine(strCmdText);
        var proc = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "CMD.exe",
                Arguments = strCmdText,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            }
        };
        proc.Start();
        outputLine = proc.StandardOutput.ReadLine();
        /*outputLine = outputLine.Replace("ß", "á");
        outputLine = outputLine.Replace("Θ", "é");
        outputLine = outputLine.Replace("φ", "í");
        outputLine = outputLine.Replace("≤", "ó");
        outputLine = outputLine.Replace("·", "ú");*/

        /*
        int currentWordLength = 0;
        string newOutputLine = "";
        if (outputLine.IndexOf(":") != -1)
        {
            for (int i = 0; i < outputLine.Length; i++)
            {
                if (Char.IsLetter(outputLine[i]))
                {
                    currentWordLength++;
                }
                else
                {
                    if (currentWordLength > 0)
                    {
                        if (EnglishAndEspanolDictionary.enToEsError.ContainsKey(line.Substring(i - currentWordLength, currentWordLength)))
                        {
                            newOutputLine += EnglishAndEspanolDictionary.enToEsError[line.Substring(i - currentWordLength, currentWordLength)];
                        }
                        else
                        {
                            newOutputLine += line.Substring(i - currentWordLength, currentWordLength);
                        }
                    }
                }
            }
            outputLine = newOutputLine;
        }*/
        /*
         * 
         * For multi line reading
         * 
         * 
        while (!proc.StandardOutput.EndOfStream)
        {
            string thisLine = proc.StandardOutput.ReadLine();
            // do something with line
            outputLine += thisLine;
        }
        while (!proc.StandardError.EndOfStream)
        {
            string thisLine = proc.StandardError.ReadLine();
            // do something with lin
            outputLine += thisLine;
        }
        stopWatch.Stop();
        */



        /*
        for (int i = 0; i < line.Length; i++)
        {
            if (Char.IsLetter(line[i]))
            {
                currentWordLength++;
            }
            else
            {
                if (currentWordLength > 0)
                {
                    if (EnglishAndEspanolDictionary.enToEs.ContainsKey(line.Substring(i - currentWordLength, currentWordLength)))
                    {
                        outputLine += EnglishAndEspanolDictionary.enToEs[line.Substring(i - currentWordLength, currentWordLength)];
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
        */
        return outputLine;
    }
}
