using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TebReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please, use following command: ");
                Console.WriteLine("TabReplacer.exe PATH_TO_YOUR_SOLUTION");
                return;
            }


            if (Directory.Exists(args[0]))
            {
                ScanFolder(path);
            }
            else
            {
                Console.WriteLine("Cannot open the directory. Possible path is wrong.");
            }
        }


        static void ScanFolder(string path)
        {
            ProcessFolder(path);

            string[] subdirs = Directory.GetDirectories(path);

            foreach(var dir in subdirs)
            {
                ScanFolder(dir);
                ProcessFolder(dir);
            }
        }

        static void ProcessFolder(string path)
        {
            var files = Directory.GetFiles(path, "*.cs");
            Path.GetFileName
            foreach(var file in files)
            {
                Console.WriteLine("Updating file: {0}", Path.GetFileName(file));
                ProcessFile(file);
            }
        }

        static void ProcessFile(string path)
        {
            string fileData = File.ReadAllText(path);

            string clearedData = fileData.Replace("	", "    ");

            File.Delete(path);

            File.WriteAllText(path, clearedData);
        }
    }
}
