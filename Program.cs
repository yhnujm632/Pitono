// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;



string[] extraArgs;
if (args.Length >= 1)
{
    //Console.WriteLine(args[0]);
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
    if (extraArgs.Contains("-E") || extraArgs.Contains("-englishtospanish"))
    {
        convertEngtoEsp(args[0]);
    }
    else
    {
        verifyPathAndRun(args[0]);
    }
}
else
{
    Console.WriteLine("No args found.");
}

void verifyPathAndRun(string path)
{
    if (File.Exists(path) && Path.GetExtension(path) == ".pitón")
    {
        //Console.WriteLine("valid");
        File.WriteAllText(Path.GetFileNameWithoutExtension(path) + ".py", "");
        using (var fileStream = File.OpenRead(path))
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
        {
            String line;
            while ((line = streamReader.ReadLine()) != null)
            {
                File.AppendAllText(Path.GetFileNameWithoutExtension(path) + ".py", translate(line) + Environment.NewLine);
            }
        }
        if (args.Length < 2 || (args[1] != "-T" && args[1] != "-translateonly"))
        {
            string strCmdText;
            strCmdText = "/C py " + Path.GetFileNameWithoutExtension(path) + ".py";
            var process = System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            strCmdText = "/C @echo off";
            process.WaitForExit();
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
//        Console.WriteLine("Press ENTER to close");
        //translate();
    }
    else {
        Console.WriteLine("invalid");
    }
}

void convertEngtoEsp(string path)
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
                File.AppendAllText(Path.GetFileNameWithoutExtension(path) + ".py", translateEngtoEsp(line) + Environment.NewLine);
            }
        }
    }

}
string translate(string line)
{

    string outputLine = "";
    int currentWordLength = 0;
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
                if (LanguageDictionary.esToEn.ContainsKey(line.Substring(i - currentWordLength, currentWordLength)))
                {
                    outputLine += LanguageDictionary.esToEn[line.Substring(i - currentWordLength, currentWordLength)];
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
string translateEngtoEsp(string line)
{

    string outputLine = "";
    int currentWordLength = 0;
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
                if (LanguageDictionary.enToEs.ContainsKey(line.Substring(i - currentWordLength, currentWordLength)))
                {
                    outputLine += LanguageDictionary.enToEs[line.Substring(i - currentWordLength, currentWordLength)];
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