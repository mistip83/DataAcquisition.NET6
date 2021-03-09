using System;
using System.Reflection;
using DataAcquisition.Interface.FileManager;
using DataAcquisition.Interface.LicenseManager;
using DataAcquisition.Model.License;

namespace DataAcquisition.LicenseManager
{
    public class LicenseManager : ILicenseManager
    {
        private readonly IFileReader<LicenseFile> _fileReader;
        private readonly IFileWriter _fileWriter;
        public LicenseManager(IFileReader<LicenseFile> fileReader, IFileWriter fileWriter)
        {
            _fileReader = fileReader;
            _fileWriter = fileWriter;
        }

        public void Initialize()
        {
            var licenseFile = _fileReader.ReadFileData(GetLicenseFullPath());
            licenseFile.OsDateTime = DateTime.Now;
        }

        private string GetLicenseFullPath()
        {
            return Assembly.GetExecutingAssembly().ToString();
        }
    }
}