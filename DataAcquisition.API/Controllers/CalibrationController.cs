using AutoMapper;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DataAcquisition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalibrationController : ControllerBase
    {
        private readonly ICalibrationService _calibrationService;
        private readonly IDeviceService _deviceService;
        private readonly IMapper _mapper;

        public CalibrationController(ICalibrationService calibrationService, 
            IDeviceService deviceService, IMapper mapper)
        {
            _calibrationService = calibrationService ?? throw new ArgumentNullException(nameof(calibrationService));
            _deviceService = deviceService ?? throw new ArgumentNullException(nameof(deviceService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Calibrate Device
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> CalibrateDevice(int id)
        {
            var device = await _deviceService.GetByIdAsync(id);
            device = _calibrationService.CalibrateDevice(device);

            return Ok(_mapper.Map<DeviceDto>(device));
        }
    }
}
