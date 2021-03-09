using System;
using System.IO;
using DataAcquisition.Interface.FileManager;
using Newtonsoft.Json;
using Serilog;

namespace DataAcquisition.FileManager
{
    public class FileReader<T> : IFileReader<T>
    {
        public T ReadFileData(string filePath)
        {
            try
            {
                var text = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<T>(text);
            }
            catch (Exception e)
            {
                Log.Logger.Information("File could not read from {path}\n{message}", filePath, e.Message);
                throw;
            }
 
        }
    }
}