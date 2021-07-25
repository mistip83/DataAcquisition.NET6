using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using AutoMapper;
using DataAcquisition.Interface.Services;
using DataAcquisition.Model.DTOs;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkstationController : ControllerBase
    {
        private readonly IWorkstationService _workstationService;
        private readonly IMapper _mapper;

        public WorkstationController(IWorkstationService workstationService, IMapper mapper)
        {
            _workstationService = workstationService;
            _mapper = mapper;
        }

        /// <summary>
        /// Returns Workstation Dto by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetWorkstationInfo(int id)
        {
            var workstation = await _workstationService.GetByIdAsync(id);
            return Ok(_mapper.Map<WorkstationDto>(workstation));
        }

        /// <summary>
        /// Returns Workstation List
        /// </summary>
        /// <returns></returns>
        [HttpGet("workstation-list")]
        public async Task<IActionResult> GetWorkstationList()
        {
            var workstationList = await _workstationService.GetAllAsync();
            return Ok(_mapper.Map<IEquatable<WorkstationDto>>(workstationList));
        }

        /// <summary>
        /// Edits Workstation properties
        /// </summary>
        /// <param name="workstationDto"></param>
        /// <returns></returns>
        [HttpPut("edit-workstation")]
        public IActionResult EditWorkstation(WorkstationDto workstationDto)
        {
            _workstationService.Update(_mapper.Map<Workstation>(workstationDto));
            return NoContent();
        }

        /// <summary>
        /// Add new workstation
        /// </summary>
        /// <param name="workstationDto"></param>
        /// <returns></returns>
        [HttpPost("add-workstation")]
        public async Task<IActionResult> AddWorkstation(WorkstationDto workstationDto)
        {
            var newWorkstation = await _workstationService.AddAsync(_mapper.Map<Workstation>(workstationDto));
            return Created(string.Empty, _mapper.Map<WorkstationDto>(newWorkstation));
        }

        /// <summary>
        /// Delete Workstation
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteWorkstation(int id)
        {
            var workstation = await _workstationService.GetByIdAsync(id);
            _workstationService.Remove(workstation);

            return NoContent();
        }
    }
}
