using System.Threading.Tasks;

namespace DataAcquisition.Interface.FileManager
{
    public interface IFileReader<T>
    {
        T ReadFileData(string filePath);
    }
}