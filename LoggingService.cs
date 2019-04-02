using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LoggingService
    {
        
        /// <summary>
        /// Soll einen Eintrag in die log.txt anhängen.
        /// </summary>
        /// <param name="tolog"></param>
        public void Log(string tolog)
        {
            var path = (string)Environment.GetEnvironmentVariables()["APPDATA"];
            var folder = Path.Combine(path, "myapp");
            Directory.CreateDirectory(folder);
            var logfile = Path.Combine(folder, "log.txt");
            using (var sw = new StreamWriter(logfile, append: true))
            {
                sw.WriteLine(tolog);
            }
        }

    }
}
