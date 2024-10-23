// See https://aka.ms/new-console-template for more information
using Pitono;
using Pitono.Translator;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;


string language;
if (File.Exists("C:\\Users\\josym\\OneDrive\\Development\\Pitono\\Pitono\\bin\\Debug\\net6.0\\language.txt"))
{
    using (StreamReader streamReader = new StreamReader("C:\\Users\\josym\\OneDrive\\Development\\Pitono\\Pitono\\bin\\Debug\\net6.0\\language.txt", Encoding.UTF8))
    {
        language = streamReader.ReadToEnd();
    }
}
else
{
    language = "english";
}
string[] extraArgs;
if (args.Length >= 1)
{
    if (args.Length > 1)
    {
        extraArgs = new string[args.Length - 1];
        for (int i = 1; i < args.Length; i++)
        {
            extraArgs[i - 1] = args[i];
        }
    }
    else
    {
        extraArgs = new string[0];
    }
    if (false)//extraArgs.Contains("-EN") || extraArgs.Contains("-englishtospanish"))
    {
        convToEng(args[0]);
    }
    else
    {
        string flag = "english";
        if (extraArgs.Contains("-en") || extraArgs.Contains("-zh") || extraArgs.Contains("-hi") || extraArgs.Contains("-es") || extraArgs.Contains("-fr") || extraArgs.Contains("-ar") || extraArgs.Contains("-bn") || extraArgs.Contains("-pt") || extraArgs.Contains("-ru") || extraArgs.Contains("-ur") || extraArgs.Contains("-id") || extraArgs.Contains("-de") || extraArgs.Contains("-ja") || extraArgs.Contains("-nl"))
        {
            for (int i = 0; i < extraArgs.Length; i++)
            {
                if (extraArgs[i] == "-en" || extraArgs[i] == "-hi" || extraArgs[i] == "-es" || extraArgs[i] == "-fr" || extraArgs[i] == "-ar" || extraArgs[i] == "-bn" || extraArgs[i] == "-pt" || extraArgs[i] == "-ru" || extraArgs[i] == "-ur" || extraArgs[i] == "-id" || extraArgs[i] == "-de" || extraArgs[i] == "-ja" || extraArgs[i] == "-nl")
                {
                    flag = TwoLetterLanguageDictionary.getFullName[extraArgs[i].Substring(1)];
                    break;
                }
                else if (extraArgs[i] == "-zh")
                {
                    flag = "chinese";
                    break;
                }
            }
        }
        verifyPathAndRun(args[0], flag);
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(Notices.LocaleString(language, "No arguments found. "));// If you are looking to enter the interactive terminal, enter \"Pitono.exe -T\"
    Console.ForegroundColor = ConsoleColor.Gray;
}

void verifyPathAndRun(string path, string langTo)
{
    string langFrom = "";
    if (TwoLetterLanguageDictionary.getExtension.Values.Contains(Path.GetExtension(path)))
    {
        langFrom = TwoLetterLanguageDictionary.getFullNameFromExtension[Path.GetExtension(path)];
    }
    if (File.Exists(path) && langFrom != "")
    {
        if (langTo == "english" && langFrom != "arabic" && langFrom != "urdu")
        {
            using (var fileStream = File.OpenRead(path))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
            {
                File.WriteAllText(Path.GetFileNameWithoutExtension(path) + ".py", "");
                String line = streamReader.ReadLine();
                bool inQuotes = false;
                char quotationMarkToSearch = '"';
                while ((line) != null)
                {
                    (string, bool, char) translatedLine = Translator.translate(line, inQuotes, quotationMarkToSearch, langFrom, langTo);
                    File.AppendAllText(Path.GetFileNameWithoutExtension(path) + ".py", translatedLine.Item1 + Environment.NewLine);
                    inQuotes = translatedLine.Item2;
                    quotationMarkToSearch = translatedLine.Item3;
                    line = streamReader.ReadLine();
                }
            }
        }
        else if (langTo == "english")
        {
            using (var fileStream = File.OpenRead(path))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
            {
                File.WriteAllText(Path.GetFileNameWithoutExtension(path) + ".py", "");
                String line = streamReader.ReadLine();
                bool inQuotes = false;
                char quotationMarkToSearch = '"';
                while ((line) != null)
                {
                    (string, bool, char) translatedLine = Translator.translateArabicOrUrdu(line, inQuotes, quotationMarkToSearch, langFrom, langTo);
                    File.AppendAllText(Path.GetFileNameWithoutExtension(path) + ".py", translatedLine.Item1 + Environment.NewLine);
                    inQuotes = translatedLine.Item2;
                    quotationMarkToSearch = translatedLine.Item3;
                    line = streamReader.ReadLine();
                }
            }
        }
        else if (langFrom != "english")
        {
            using (var fileStream = File.OpenRead(path))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
            {
                File.WriteAllText(Path.GetFileNameWithoutExtension(path) + TwoLetterLanguageDictionary.getExtension[langTo], "");
                String translatedToEnglish = "";
                String line = streamReader.ReadLine();
                bool inQuotes = false;
                char quotationMarkToSearch = '"';
                while ((line) != null)
                {
                    (string, bool, char) translatedLine = Translator.translate(line, inQuotes, quotationMarkToSearch, langFrom, "english");
                    translatedToEnglish += translatedLine.Item1;
                    translatedToEnglish += Environment.NewLine;
                    inQuotes = translatedLine.Item2;
                    quotationMarkToSearch = translatedLine.Item3;
                    line = streamReader.ReadLine();
                }
                string[] translatedLines = Regex.Split(translatedToEnglish, "\r\n|\r|\n");
                for (int i = 0; i < translatedLines.Length; i++)
                {
                    (string, bool, char) translatedLine = Translator.translate(translatedLines[i], inQuotes, quotationMarkToSearch, "english", langTo);
                    //Console.WriteLine(translatedLine.Item1);
                    File.AppendAllText(Path.GetFileNameWithoutExtension(path) + TwoLetterLanguageDictionary.getExtension[langTo], translatedLine.Item1 + Environment.NewLine);
                    inQuotes = translatedLine.Item2;
                    quotationMarkToSearch = translatedLine.Item3;
                }
            }
        }
        else
        {
            using (var fileStream = File.OpenRead(path))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
            {
                File.WriteAllText(Path.GetFileNameWithoutExtension(path) + TwoLetterLanguageDictionary.getExtension[langTo], "");
                String line = streamReader.ReadLine();
                bool inQuotes = false;
                char quotationMarkToSearch = '"';
                while ((line) != null)
                {
                    (string, bool, char) translatedLine = Translator.translate(line, inQuotes, quotationMarkToSearch, langFrom, langTo);
                    File.AppendAllText(Path.GetFileNameWithoutExtension(path) + TwoLetterLanguageDictionary.getExtension[langTo], translatedLine.Item1 + Environment.NewLine);
                    inQuotes = translatedLine.Item2;
                    quotationMarkToSearch = translatedLine.Item3;
                    line = streamReader.ReadLine();
                }
            }
        }
        if (langTo == "english" && !extraArgs.Contains("-T") && !extraArgs.Contains("-translateonly"))
        {
            runCompiledPythonFile(path);
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Notices.LocaleString(language, "Invalid file path. "));
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}

void runCompiledPythonFile(string path)
{
        //https://stackoverflow.com/questions/1469764/run-command-prompt-commands
        //Run process
        var proc = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "CMD.exe",
                Arguments = "/C py " + Path.GetFileNameWithoutExtension(path) + ".py",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            }
        };
        proc.Start();

        //Print out the standard Python output
        while (!proc.StandardOutput.EndOfStream)
        {
            string line = proc.StandardOutput.ReadLine();
            if (line != null)
            {
                Console.WriteLine(line);
            }
            /*foreach (ProcessThread thread in proc.Threads) {
                if (thread.ThreadState == System.Diagnostics.ThreadState.Wait && thread.WaitReason == ThreadWaitReason.UserRequest)
                {
                    string input = Console.ReadLine();
                    proc.StandardInput.WriteLine(input);
                }
            }*/
        }

        //Print out the standard Python error (if there is any error)
        while (!proc.StandardError.EndOfStream)
        {
            string line = proc.StandardError.ReadLine();
            if (line != null)
            {
                Console.WriteLine(ErrorTranslator.translateError(line, "english", language));
            }
        }
}

void convToEng(string path)
{
    if (File.Exists(path) && Path.GetExtension(path) == ".py")
    {
        File.WriteAllText(Path.GetFileNameWithoutExtension(path) + ".pitón", "");
        using (var fileStream = File.OpenRead(path))
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
        {
            String line;
            while ((line = streamReader.ReadLine()) != null)
            {
                File.AppendAllText(Path.GetFileNameWithoutExtension(path) + ".py", Translator.translateEngtoEsp(line) + Environment.NewLine);
            }
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Notices.LocaleString(language, "Invalid file path. "));
        Console.ForegroundColor = ConsoleColor.Gray;
    }

}

