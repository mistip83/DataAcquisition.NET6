using Microsoft.AspNetCore.Mvc;
using DataAcquisition.API.Filters;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DeviceController : ControllerBase
{
    private readonly IDeviceService _deviceService;

    public DeviceController(IDeviceService deviceService)
    {
        _deviceService = deviceService ?? throw new ArgumentNullException(nameof(deviceService));
    }

    /// <summary>
    /// Returns Device by id
    /// </summary>
    /// <param name="id"></param>
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Device>> GetDeviceInfo(int id)
    {
        return await _deviceService.GetByIdAsync(id);
    }

    /// <summary>
    /// Returns Device List
    /// </summary>
    [HttpGet("device-list")]
    public async Task<ActionResult<List<Device>>> GetDeviceList()
    {
        return (await _deviceService.GetAllAsync()).ToList();
    }

    /// <summary>
    /// Add new Device
    /// </summary>
    /// <param name="device"></param>
    [ValidationFilter]
    [HttpPost("add-device")]
    public async Task<ActionResult<Device>> AddDevice(Device device)
    {
        var newDevice = await _deviceService.AddAsync(device);
        return CreatedAtAction(nameof(AddDevice), new { id = newDevice.DeviceId }, 
            newDevice);
    }

    /// <summary>
    /// Edits Device properties
    /// </summary>
    /// <param name="id"></param>
    /// <param name="device"></param>
    [HttpPut("edit-device/{id:int}")]
    public IActionResult EditDevice(int id, Device device)
    {
        device.DeviceId = id;
        _deviceService.Update(device);

        return NoContent();
    }

    /// <summary>
    /// Delete Device
    /// </summary>
    /// <param name="id"></param>
    [HttpDelete("delete-device/{id:int}")]
    public async Task<ActionResult> DeleteDevice(int id)
    {
        var device = await _deviceService.GetByIdAsync(id);
        _deviceService.Remove(device);

        return NoContent();
    }
}