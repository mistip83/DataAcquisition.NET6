using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DataAcquisition.Interface.Services;
using DataAcquisition.Model.DTOs;
using DataAcquisition.Model.Entities;

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
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GeDeviceInfo(int id)
        {
            var device = await _deviceService.GetByIdAsync(id);
            return Ok(_mapper.Map<DeviceDto>(device));
        }

        /// <summary>
        /// Returns Device List
        /// </summary>
        /// <returns></returns>
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
        /// <returns></returns>
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
        /// <returns></returns>
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
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteDevice(int id)
        {
            var device = await _deviceService.GetByIdAsync(id);
            _deviceService.Remove(device);

            return NoContent();
        }
    }
}
