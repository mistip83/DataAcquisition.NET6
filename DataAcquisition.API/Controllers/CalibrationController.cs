using DataAcquisition.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalibrationController : ControllerBase
    {
        private readonly ICalibrationService _calibrationService;
        private readonly IDeviceService _deviceService;

        public CalibrationController(ICalibrationService calibrationService, 
            IDeviceService deviceService)
        {
            _calibrationService = calibrationService ?? throw new ArgumentNullException(nameof(calibrationService));
            _deviceService = deviceService ?? throw new ArgumentNullException(nameof(deviceService));
        }

        /// <summary>
        /// Calibrate Device
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Device>> CalibrateDevice(int id)
        {
            var device = await _deviceService.GetByIdAsync(id);
            return _calibrationService.CalibrateDevice(device);
        }
    }
}
