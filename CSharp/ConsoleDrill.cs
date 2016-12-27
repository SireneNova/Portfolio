using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleDrillFileMove
{
    class FileMove
    {
        static void Main()
        {
            // my directories
            string source = @"C:\path to source directory";
            string destination = @"C:\path to destination directory";             
                        
            string[] fileArray = Directory.GetFiles(source, "*.txt"); //my criteria: get files if ends in .txt
            // Output of fileArray is in file paths rather than names.

            int count = 0;
            string a = "\n*************************( Check Complete )*************************";
            string b = "********************************************************************";

            foreach (string srcPath in fileArray)
            {
                // Use Path class to manipulate file and directory paths.
                string file = Path.GetFileName(srcPath);
                string dstPath = System.IO.Path.Combine(destination, file);
                //Console.WriteLine($"src: {srcPath}");
                //Console.WriteLine($"dst: {dstPath}");
                DateTime mtime = File.GetLastWriteTime(srcPath); // Get time modified in local time
                //Console.WriteLine(mtime);
                TimeSpan diff = DateTime.Now - mtime;
                double diffSeconds = diff.TotalSeconds;
                if (diffSeconds <= 86400) // Move if modified within 24 h.
                {
                    //Console.WriteLine(diffSeconds);
                    System.IO.File.Move(srcPath, dstPath);
                    Console.WriteLine($"Change made to {file} in last 24 hr. File moved from source to destination.");

                    count += 1;
                }
                              
            }
            if (count > 1)
            {
                Console.WriteLine(a);
                Console.WriteLine($"{count} files have been moved into the destination directory.");
                Console.WriteLine(b);
            }

            else if (count == 1)
            {
                Console.WriteLine(a);
                Console.WriteLine("1 file has been moved into the destination directory.");
                Console.WriteLine(b);
            }

            else
            {
                Console.WriteLine(a);
                Console.WriteLine("No files have been moved into the destination directory.");
                Console.WriteLine(b);
            }
            
        }
    }
}
