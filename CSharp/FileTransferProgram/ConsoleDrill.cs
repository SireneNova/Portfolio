using System;
using System.IO;

namespace ConsoleDrillFileMove
{
    class FileMove
    {
        static void move(string source, string destination)
        {
             string[] fileArray = Directory.GetFiles(source, "*.txt"); //my criteria: get files if ends in .txt
            // Output of fileArray is in file paths rather than names.

            int count = 0;
            foreach (string srcPath in fileArray)
            {
                // Use Path class to manipulate file and directory paths.
                string file = Path.GetFileName(srcPath);
                string dstPath = Path.Combine(destination, file);
                DateTime mtime = File.GetLastWriteTime(srcPath); // Get time modified in local time
                TimeSpan diff = DateTime.Now - mtime;
                double diffSeconds = diff.TotalSeconds;

                if (diffSeconds <= 86400) // Move if modified within 24 h.
                {
                    File.Move(srcPath, dstPath);
                    Console.WriteLine($"Change made to {file} in last 24 hr. File moved from source to destination.");

                    count += 1;
                }
            }

            //Message what's been moved
            string a = "\n*************************( Check Complete )*************************";
            string b = "********************************************************************";
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

        static void Main()
        {
            // my directories, enter yours
            string folderToCheck = @"C:\path to source directory";
            string foldertoSend = @"C:\path to destination directory";
            move(folderToCheck, foldertoSend);            
        }
    }
}
