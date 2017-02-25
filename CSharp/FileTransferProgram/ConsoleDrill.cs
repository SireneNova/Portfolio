using System;
using System.IO;

namespace ConsoleDrillFileMove
{
    class FileMove
    {
        static void move(string source, string destination)
        {   
            string[] fileArray = Directory.GetFiles(source, "*.txt"); //my criteria: get files if ends in .txt
            // Output of fileArray is array of file paths rather than file names. There's no equivalent command that gets just names.

            int count = 0;
            foreach (string srcPath in fileArray)
            {
                // Use Path class to manipulate file and directory paths.
                string file = Path.GetFileName(srcPath); //file name for each path in fileArray
                string dstPath = Path.Combine(destination, file); //new path
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
       
        static string getFolderToCheck()
        {
            //my directory, enter yours between the quotes:
            string s = @"path to default source directory"; // @ needed before paths
            Console.Write("Would you like to change source directory (y/n)? ");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.Write("Enter source directory file path: ");
                s = @Console.ReadLine();
                return s;
            }
            else
            {
                return s;
            }
        }

        static string getFolderToSend()
        {
            //my directory, enter yours between the quotes:
            string d = @"path to default destination directory";
            Console.Write("Would you like to change destination directory (y/n)? ");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.Write("Enter destination directory file path: ");
                d = @Console.ReadLine();
                return d;
            }
            else
            {
                return d;
            }
        }
             
        static void Main()
        {
            move(getFolderToCheck(), getFolderToSend());            
        }
    }
}
