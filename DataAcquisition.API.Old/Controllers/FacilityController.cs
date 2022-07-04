using Microsoft.AspNetCore.Mvc;
using DataAcquisition.API.Filters;
using DataAcquisition.Core.Interfaces.Configuration;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FacilityController : ControllerBase
{
    private readonly IFacilityService _facilityService;
    private readonly IAppConfiguration _appConfiguration;

    public FacilityController(IFacilityService facilityService, IAppConfiguration appConfiguration)
    {
        _facilityService = facilityService ?? throw new ArgumentNullException(nameof(facilityService));
        _appConfiguration = appConfiguration ?? throw new ArgumentNullException(nameof(appConfiguration));
    }

    /// <summary>
    /// Returns Facility by id
    /// </summary>
    /// <param name="id"></param>
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Facility>> GetFacilityInfo(int id)
    {
        return await _facilityService.GetByIdAsync(id);
    }

    /// <summary>
    /// Returns Facility List
    /// </summary>
    [HttpGet("facility-list")]
    public async Task<ActionResult<List<Facility>>> GetFacilityList()
    {
        return (await _facilityService.GetFacilitiesWithWorkStationsAsync()).ToList();
    }

    /// <summary>
    /// Returns Facility with workstations
    /// </summary>
    /// <param name="id"></param>
    [HttpGet("{id:int}/workstations")]
    public async Task<ActionResult<Facility>> GetFacilityWithWorkStations(int id)
    {
        return await _facilityService.GetFacilityWithWorkStationsAsync(id);
    }

    /// <summary>
    /// Add new facility
    /// </summary>
    /// <param name="facility"></param>
    [ValidationFilter]
    [HttpPost("add-facility")]
    public async Task<ActionResult> AddFacility(Facility facility)
    {
        var newFacility = await _facilityService.AddAsync(facility);
        return CreatedAtAction(nameof(GetFacilityInfo), new { id = newFacility.FacilityId }, 
            newFacility);
    }

    /// <summary>
    /// Edits Facility Properties
    /// </summary>
    /// <param name="id"></param>
    /// <param name="facility"></param>
    [ValidationFilter]
    [HttpPut("edit-facility/{id:int}")]
    public ActionResult EditFacility(int id, Facility facility)
    {
        facility.FacilityId = id;
        facility.CompanyName = _appConfiguration.GetCompanyName();

        _facilityService.Update(facility);
        return NoContent();
    }
}