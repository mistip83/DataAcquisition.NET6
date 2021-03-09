using System;
using System.IO;
using DataAcquisition.Interface.FileManager;
using Newtonsoft.Json;
using Serilog;

namespace DataAcquisition.FileManager
{
    public class FileWriter : IFileWriter
    {
        public FileWriter()
        {

        }

        public void WriteFile(string filePath, object data)
        {
            try
            {
                var fileInfo = new FileInfo(filePath);
                if (fileInfo.Exists && fileInfo.IsReadOnly)
                {
                    fileInfo.IsReadOnly = false;
                }

                // Deserialize object
                var jsonString =
                    JsonConvert.DeserializeObject(JsonConvert.SerializeObject(data, Formatting.Indented))?.ToString();

                if (jsonString == string.Empty)
                {
                    Console.WriteLine("JSON object is null");
                }
                else
                {
                    File.WriteAllText(filePath, jsonString);
                }
            }
            catch (Exception e)
            {
                Log.Logger.Information("File could not write to {path}\n{message}", filePath, e.Message);
                throw;
            }
        }
    }
}