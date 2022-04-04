using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.API.Filters;
using DataAcquisition.Core.Models.Acquisition;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperimentController : ControllerBase
    {
        private readonly IAcquisitionService _acquisitionService;
        private readonly IExperimentService _experimentService;

        public ExperimentController(IAcquisitionService acquisitionService,
            IExperimentService experimentService)
        {
            _acquisitionService = acquisitionService ?? throw new ArgumentNullException(nameof(acquisitionService));
            _experimentService = experimentService ?? throw new ArgumentNullException(nameof(experimentService));
        }

        /// <summary>
        /// Returns Experiment details by id
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Experiment>> GetExperiment(int id)
        {
            return await _experimentService.GetByIdAsync(id);
        }

        /// <summary>
        /// Returns Experiment data by id
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("experiment-data/{id:int}")]
        public async Task<ActionResult<ExperimentData>> GetExperimentData(int id)
        {
            return await _acquisitionService.GetByIdAsync(id);
        }

        /// <summary>
        /// Returns Experiment List
        /// </summary>
        [HttpGet("experiment-list")]
        public async Task<IActionResult> GetExperimentList()
        {
            var experimentList = await _experimentService.GetAllAsync();
            return Ok(experimentList);
        }

        /// <summary>
        /// Create new experiment
        /// </summary>
        /// <param name="experiment"></param>
        [ValidationFilter]
        [HttpPost("create-experiment")]
        public async Task<ActionResult> CreateExperiment(Experiment experiment)
        {
            var newExperiment = await _experimentService.AddAsync(experiment);
            return CreatedAtAction(nameof(CreateExperiment), new { id = newExperiment.ExperimentId },
                newExperiment);
        }

        /// <summary>
        /// Delete Experiment
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("delete-experiment/{id:int}")]
        public async Task<ActionResult> DeleteExperiment(int id)
        {
            var experiment = await _experimentService.GetByIdAsync(id);
            _experimentService.Remove(experiment);

            return NoContent();
        }
    }
}
