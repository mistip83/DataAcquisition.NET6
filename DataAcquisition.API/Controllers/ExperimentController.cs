using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Models.DTOs;
using DataAcquisition.API.Filters;
using DataAcquisition.Core.Models.Acquisition;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperimentController : ControllerBase
    {
        private readonly IExperimentService _experimentService;
        private readonly IMapper _mapper;

        public ExperimentController(IExperimentService experimentService, IMapper mapper)
        {
            _experimentService = experimentService ?? throw new ArgumentNullException(nameof(experimentService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Returns Experiment details by id
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetExperiment(int id)
        {
            var experiment = await _experimentService.GetByIdAsync(id);
            return Ok(_mapper.Map<ExperimentDto>(experiment));
        }

        /// <summary>
        /// Returns Experiment data by id
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("experiment-data/{id:int}")]
        public async Task<IActionResult> GetExperimentData(int id)
        {
            var experimentData = await _experimentService.GetExperimentDataAsync(id);
            return Ok(_mapper.Map<AcquisitionData>(experimentData));
        }

        /// <summary>
        /// Returns Experiment List
        /// </summary>
        [HttpGet("experiment-list")]
        public async Task<IActionResult> GetExperimentList()
        {
            var experimentList = await _experimentService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ExperimentDto>>(experimentList));
        }

        /// <summary>
        /// Create new experiment
        /// </summary>
        /// <param name="experimentDto"></param>
        [ValidationFilter]
        [HttpPost("create-experiment")]
        public async Task<IActionResult> CreateExperiment(ExperimentDto experimentDto)
        {
            var newExperiment = await _experimentService.AddAsync(_mapper.Map<Experiment>(experimentDto));
            return CreatedAtAction(nameof(GetExperiment), new { id = newExperiment.ExperimentId }, 
                _mapper.Map<ExperimentDto>(newExperiment));
        }

        /// <summary>
        /// Start data acquisition
        /// </summary>
        /// <param name="config"></param>
        [ValidationFilter]
        [HttpPost("start-experiment")]
        public async Task<IActionResult> StartExperiment(AcquisitionConfig config)
        {
            await _experimentService.StartNewExperiment(config);
            return NoContent();
        }

        /// <summary>
        /// Delete Experiment
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("delete-experiment/{id:int}")]
        public async Task<IActionResult> DeleteExperiment(int id)
        {
            var experiment = await _experimentService.GetByIdAsync(id);
            _experimentService.Remove(experiment);

            return NoContent();
        }
    }
}
