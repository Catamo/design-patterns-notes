using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace DesignPatterns.Test.TestUtilities
{
    public class ConsoleOutput : IDisposable
    {
        private StringWriter stringWriter;
        private TextWriter originalOutput;

        public ConsoleOutput()
        {
            stringWriter = new StringWriter();
            originalOutput = Console.Out;
            Console.SetOut(stringWriter);
        }

        //Regex code based on
        //https://stackoverflow.com/questions/4140723/how-to-remove-new-line-characters-from-a-string
        public string GetOuput(bool removeNewSpaces = true)
        {
            return Regex.Replace(stringWriter.ToString(), removeNewSpaces ? @"\t|\n|\r" : @"\t|\r", "");
        }

        public void Dispose()
        {
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }
}
