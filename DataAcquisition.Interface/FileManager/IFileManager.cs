namespace DataAcquisition.Interface.FileManager
{
    public interface IFileManager
    {
        void WriteFile(string filePath, object data);
    }
}