using System;
using Microsoft.AspNetCore.Mvc;
using DataAcquisition.API.Filters;
using DataAcquisition.Core.Interfaces.DataAcquisition;
using DataAcquisition.Core.Models.Acquisition;

namespace DataAcquisition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataAcquisitionController : Controller
    {
        private readonly IDataAcquisitionService _acquisitionService;

        public DataAcquisitionController(IDataAcquisitionService acquisitionService)
        {
            _acquisitionService = acquisitionService ?? throw new ArgumentNullException(nameof(acquisitionService));
        }

        /// <summary>
        /// Start data acquisition
        /// </summary>
        /// <param name="config"></param>
        [ValidationFilter]
        [HttpPost("start-acquisition")]
        public IActionResult StartDataAcquisition(AcquisitionConfig config)
        {
            
            _acquisitionService.StartDataAcquisition(config);
            return NoContent();
        }

    }
}
