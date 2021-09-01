using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DataAcquisition.API.Filters;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Models.DTOs;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService _deviceService;
        private readonly IMapper _mapper;

        public DeviceController(IDeviceService deviceService, IMapper mapper)
        {
            _deviceService = deviceService ?? throw new ArgumentNullException(nameof(deviceService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Returns Device Dto by id
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetDeviceInfo(int id)
        {
            var device = await _deviceService.GetByIdAsync(id);
            return Ok(_mapper.Map<DeviceDto>(device));
        }

        /// <summary>
        /// Returns Device List
        /// </summary>
        [HttpGet("device-list")]
        public async Task<IActionResult> GetDeviceList()
        {
            var deviceList = await _deviceService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<DeviceDto>>(deviceList));
        }

        /// <summary>
        /// Edits Device properties
        /// </summary>
        /// <param name="deviceDto"></param>
        [HttpPut("edit-device")]
        public IActionResult EditDevice(DeviceDto deviceDto)
        {
            _deviceService.Update(_mapper.Map<Device>(deviceDto));
            return NoContent();
        }

        /// <summary>
        /// Add new Device
        /// </summary>
        /// <param name="deviceDto"></param>
        [ValidationFilter]
        [HttpPost("add-device")]
        public async Task<IActionResult> AddDevice(DeviceDto deviceDto)
        {
            var newDevice = await _deviceService.AddAsync(_mapper.Map<Device>(deviceDto));
            return Created(string.Empty, _mapper.Map<DeviceDto>(newDevice));
        }

        /// <summary>
        /// Delete Device
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("delete-device/{id:int}")]
        public async Task<IActionResult> DeleteDevice(int id)
        {
            var device = await _deviceService.GetByIdAsync(id);
            _deviceService.Remove(device);

            return NoContent();
        }

        /// <summary>
        /// Calibrate Device
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("calibrate-device/{id:int}")]
        public async Task<IActionResult> CalibrateDevice(int id)
        {
            var device = await _deviceService.GetByIdAsync(id);
            device = _deviceService.CalibrateDevice(device);

            return Ok(_mapper.Map<DeviceDto>(device));
        }
    }
}
