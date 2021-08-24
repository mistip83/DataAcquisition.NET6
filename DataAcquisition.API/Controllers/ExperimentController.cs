using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DataAcquisition.Interface.Services;
using DataAcquisition.Model.DTOs;

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
        /// <returns></returns>
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
        /// <returns></returns>
        [HttpGet("experiment-data/{id:int}")]
        public async Task<IActionResult> GetExperimentData(int id)
        {
            var experimentData = await _experimentService.GetExperimentDataAsync(id);
            return Ok(_mapper.Map<ExperimentDataDto>(experimentData));
        }

        /// <summary>
        /// Returns Experiment List
        /// </summary>
        /// <returns></returns>
        [HttpGet("experiment-list")]
        public async Task<IActionResult> GetExperimentList()
        {
            var experimentList = await _experimentService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ExperimentDto>>(experimentList));
        }

        /// <summary>
        /// Delete Experiment
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("delete-experiment/{id:int}")]
        public async Task<IActionResult> DeleteExperiment(int id)
        {
            var experiment = await _experimentService.GetByIdAsync(id);
            _experimentService.Remove(experiment);

            return NoContent();
        }
    }
}
