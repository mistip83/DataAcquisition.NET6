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

        public bool IsLicenseValid()
        {
            var licenseFile = GetLicenseInfo();

            return licenseFile.UserEmail != string.Empty && DateTime.Now < licenseFile.LicenseEndDate;
        }

        private static string GetLicenseFullPath()
        {
            return Assembly.GetExecutingAssembly().ToString();
        }

        private LicenseFile GetLicenseInfo()
        {
            return _fileReader.ReadFileData(GetLicenseFullPath());
        }

        private static LicenseFile CreateNewLicenseInfo()
        {
            return new LicenseFile
            {
                OsDateTime = DateTime.Now,
                UserEmail = "muratistipliler@gmail.com",
                LicenseBeginDate = DateTime.Now,
                LicenseEndDate = DateTime.Now.AddYears(1),
                MachineId = "2CF05D21E09A"
        };
        }
    }
}