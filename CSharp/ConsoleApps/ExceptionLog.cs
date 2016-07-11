using System;
using System.IO;
using System.Text;

namespace ExceptionLog
{
    class LogEx
    {

        public static void Main(string[] args)
        {
            Exception e = new Exception();
            LogException("Test", "Testing", e.ToString());
        }

        public static void LogException(string strFileName, string strFunctionName, string strContent)
        {
            StreamWriter writer = null;
            StringBuilder strBuilder = null;
            string dir = "C:\\LogError\\";
            //check folder exists
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string path = Path.Combine(dir, strFileName + ".log");
            strBuilder = new StringBuilder("Log : ");
            strBuilder.Append(strFunctionName + " | ");
            strBuilder.Append(strContent);

            writer = new StreamWriter(path, true);
            writer.Write(strBuilder);
            writer.Close();

            strBuilder.Append("********************" + " Error Log - " + DateTime.Now + "*********************");
            strBuilder.Append(Environment.NewLine);
            strBuilder.Append(Environment.NewLine);
                        
        }      
    }
}

//source: https://www.youtube.com/watch?v=CLsA3LEBGv4