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

        public string FilePath 
        { get; }
        public DateTime dateTime = DateTime.Now;
        public FileLogger(string FilePath)
        {
            this.FilePath = FilePath;
        }

        public override void Log(LogLevel? logLevel, string message)
        {
            

            //references:
            //https://docs.microsoft.com/en-us/dotnet/api/system.io.file.create?view=net-6.0
            //https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-text-file-in-C-Sharp/
            

            // * Code Reference: https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-open-and-append-to-a-log-file
            using (StreamWriter w = File.AppendText("file.txt"))
            {
                //$"{DateTime.Now} {F}"
                w.Write(dateTime + "\n");
                //w.Write(Environment.NewLine);
                w.Write(this.ClassName + "\n");
                //w.Write(Environment.NewLine);
                w.Write(logLevel + "\n");
                //w.Write(Environment.NewLine);
                w.Write(message);
                //w.Write(Environment.NewLine);
            }

            //throw new System.NotImplementedException();
        }
    }

}
