using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class GoogleTranslate
{
        public static string googleTranslate(string line, string langFrom, string langTo)
        {
            string outputLine;
            string strCmdText;// ↓↓↓↓↓↓ THIS STRING CHANGES FROM USER TO USER!!! MUST BE ALTERED!
            strCmdText = $"/C C:\\Users\\josym\\OneDrive\\Development\\Pitono\\Pitono\\bin\\Debug\\net6.0\\translator.exe \"{line}\" \"{langFrom}\" \"{langTo}\"";
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
            outputLine = proc.StandardOutput.ReadLine();/*
            outputLine = outputLine.Replace("ß", "á");
            outputLine = outputLine.Replace("Θ", "é");
            outputLine = outputLine.Replace("φ", "í");
            outputLine = outputLine.Replace("≤", "ó");
            outputLine = outputLine.Replace("·", "ú");*/
            return outputLine;
         
            //return "null";
        }
}
