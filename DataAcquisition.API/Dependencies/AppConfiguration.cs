using System;
using DataAcquisition.Core.Interfaces.Configuration;
using Microsoft.Extensions.Configuration;

namespace DataAcquisition.API.Dependencies
{
    public class AppConfiguration : IAppConfiguration
    {
        private readonly IConfiguration _configuration;

        public AppConfiguration(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public string GetCompanyName()
        {
            return _configuration[AppSettingKeys.CompanyName];
        }
    }
}