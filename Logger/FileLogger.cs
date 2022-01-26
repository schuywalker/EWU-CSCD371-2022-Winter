using System;
//using System.IO.Path;
//using System.IO.File;
using System.IO;

using System.Text;

namespace Logger
{ 
    //References for research
    //https://stackoverflow.com/questions/20185015/how-to-write-log-file-in-c
    //https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-open-and-append-to-a-log-file

    public class FileLogger : BaseLogger
    {

        private string? FilePath 
        { get; set; }
        public FileLogger(string className, string FilePath)
        {
            this.ClassName = className;
            this.FilePath = FilePath;
        }

        public override void Log(LogLevel logLevel, string message)
        {
            DateTime dateTime = DateTime.Now;

            //references:
            //https://docs.microsoft.com/en-us/dotnet/api/system.io.file.create?view=net-6.0
            //https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-text-file-in-C-Sharp/
            string fileName = "file.txt";
            string? path = FilePath;
             
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }


                using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes("Whitney and Schuyler's Project.");
                        fs.Write(info, 0, info.Length);
                    };
            

            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // * Code Reference: https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-open-and-append-to-a-log-file
            using (StreamWriter w = File.AppendText("file.txt"))
            {
                w.Write(dateTime);
                w.Write(Environment.NewLine);
                w.Write("LogFactory");
                w.Write(Environment.NewLine);
                w.Write(logLevel);
                w.Write(Environment.NewLine);
                w.Write(message);
                w.Write(Environment.NewLine);
            }

            throw new System.NotImplementedException();
        }
    }

}
