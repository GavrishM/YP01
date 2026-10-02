using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DBConnection
{
    public class DBConnection
    {
        private readonly string connectionString_;
        public string GetConnectionString()
        {
            return connectionString_;
        }
        public DBConnection()
        {
            string filePath = "Config.txt";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string[] connectionLine = new string[2];
                    connectionLine[0] = "DBConnection";
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        connectionLine = line.Split('=');
                        if (connectionLine[0] == "DBConnection")
                        { connectionString_ = connectionLine[1]; }
                    }
                }
            }
            catch (IOException e)
            {
                string errorFilePath = "Errors.txt";
                using (StreamWriter writer = new StreamWriter(errorFilePath, true))
                {
                    writer.WriteLine("Не удалось получить строку соединение с БД");
                    writer.WriteLine(e);
                }
            }
        }
    }
}
