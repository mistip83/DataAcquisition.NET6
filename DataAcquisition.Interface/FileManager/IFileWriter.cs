namespace DataAcquisition.Interface.FileManager
{
    public interface IFileWriter
    {
        void WriteFile(string filePath, object data);
    }
}