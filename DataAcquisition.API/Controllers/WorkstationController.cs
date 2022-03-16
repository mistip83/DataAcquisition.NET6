using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DataAcquisition.API.Filters;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkstationController : ControllerBase
    {
        private readonly IWorkstationService _workstationService;

        public WorkstationController(IWorkstationService workstationService)
        {
            _workstationService = workstationService ?? throw new ArgumentNullException(nameof(workstationService));
        }

        /// <summary>
        /// Returns Workstation Dto by id
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Workstation>> GetWorkstationInfo(int id)
        {
            return await _workstationService.GetByIdAsync(id);
        }

        /// <summary>
        /// Returns Workstation List
        /// </summary>
        [HttpGet("workstation-list")]
        public async Task<IActionResult> GetWorkstationList()
        {
            var workstationList = await _workstationService.GetAllAsync();
            return Ok(workstationList);
        }

        /// <summary>
        /// Returns Workstation with devices and experiments
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id:int}/devices-experiments")]
        public async Task<ActionResult<Workstation>> GetWorkstationWithDevicesAndExperiments(int id)
        {
            return await _workstationService.GetWorkstationWithDevicesAndExperimentsAsync(id);
        }

        /// <summary>
        /// Edits Workstation properties
        /// </summary>
        /// <param name="id"></param>
        /// <param name="workstationDto"></param>
        [HttpPut("edit-workstation/{id:int}")]
        public IActionResult EditWorkstation(int id, Workstation workstation)
        {
            workstation.WorkstationId = id;

            _workstationService.Update(workstation);
            return NoContent();
        }

        /// <summary>
        /// Adds new workstation
        /// </summary>
        /// <param name="workstationDto"></param>
        [ValidationFilter]
        [HttpPost("add-workstation")]
        public async Task<ActionResult> AddWorkstation(Workstation workstation)
        {
            var newWorkstation = await _workstationService.AddAsync(workstation);
            return CreatedAtAction(nameof(GetWorkstationInfo), new { id = newWorkstation.WorkstationId }, 
                newWorkstation);
        }

        /// <summary>
        /// Deletes Workstation
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("delete-workstation/{id:int}")]
        public async Task<IActionResult> DeleteWorkstation(int id)
        {
            var workstation = await _workstationService.GetByIdAsync(id);
            _workstationService.Remove(workstation);

            return NoContent();
        }
    }
}
