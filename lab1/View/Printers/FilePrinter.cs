using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.View.Printers
{
    public class FilePrinter : IPrinter
    {
        private string _filePath;

        public FilePrinter(string filePath)
        {
            _filePath = filePath;
        }

        public void Print(string data)
        {
            try
            {
                File.AppendAllText(_filePath, data + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Log.Information($"Ошибка при записи в файл: {ex.Message}");
            }
        }
    }
}
