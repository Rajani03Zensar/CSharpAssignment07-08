using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace MultiThreadingDemo
{
    class FileClassDemo

    {
        FileStream fs;

        static void Main()
        {
            //FileStream fs = File.Create("fileNew.txt");
            Console.WriteLine("New File is created");
            File.WriteAllText("fileText.txt", "This is the demo of Write ALl Text");
            Console.WriteLine("Text is appended");
            File.AppendAllText("fileText.txt", "Now I have appended the text to the existing text file");
            Console.WriteLine("All text has been read");
            File.ReadAllText("fileText.txt");
            Console.WriteLine("copying text from 'filetext' to 'fileText2'");
            //File.Copy("fileText.txt", "fileText2.txt");
            Console.WriteLine("fileText1 id deleted");
            File.Delete("fileText1.txt");

        }
    }
}
