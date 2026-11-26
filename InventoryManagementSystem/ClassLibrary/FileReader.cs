using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FileReader
    {
        public List<string> Strings { get; }
        public string FPath { get; set; }
        public FileReader(string path)
        {
            FPath = path;
        }
        public Anser Read()
        {
            Anser result = new Anser();
            if (!File.Exists(FPath))
            {
                result.Text = "Файл не найден!";
                result.Bool = false;
                return result;
            }
            try
            {
                using (StreamReader reader = new StreamReader(FPath))
                {
                    string line;
                    int lineNumber = 1;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!Strings.Contains(line))
                        { Strings.Add(line); }
                        lineNumber++;
                    }
                }
                result.Bool = true;
                result.Text = "Файл прочитан успешно";
                return result;
            }
            catch (IOException ex)
            {
                result.Bool = false;
                result.Text = $"Ошибка чтения: {ex.Message}";
            }
            catch (UnauthorizedAccessException ex)
            {
                result.Bool = false;
                result.Text = $"Нет доступа: {ex.Message}";
            }
            return result;
        }
        public Anser Read(string param)
        {
            Anser result = new Anser();
            if (Strings.Count <= 0)
            {
                result = Read();
                if (result.Bool == false)
                { return result; }
            }







            return result;
        }
    }
}
