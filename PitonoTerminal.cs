using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class PitonoTerminal
{
    public static void terminal(string language)
    {
        Debug.Print("terminal funcion started");
        string inputText = "";
        string strCmdText;
        //while (!inputText.Equals("exit()"))
        //{
        if (true) {
            Debug.Print("in terminal function");
            strCmdText = "/C py";
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
            
            /*while (!proc.StandardError.EndOfStream)
            {
                string line = proc.StandardError.ReadLine();
                // do something with line
                if (line != null)
                {
                    Console.WriteLine(line);
                    //translateLine += line;
                }
            }*/
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                // do something with line
                if (line != null)
                {
                    Console.WriteLine(line);
                }
            }
            inputText = Console.ReadLine();
            strCmdText = inputText;
            /*
        while (!proc.StandardError.EndOfStream)
        {
            string line = proc.StandardError.ReadLine();
            // do something with line
            if (line != null)
            {
                Console.WriteLine(ErrorTranslator.translateError(line, "en", "es"));
                //translateLine += line;
            }
        }*/
            //return;
        }
    }
    public static void terminal()
    {

    }
}
