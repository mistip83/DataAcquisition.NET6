using System;
using Microsoft.AspNetCore.Mvc;
using DataAcquisition.API.Filters;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Models.Acquisition;

namespace DataAcquisition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcquisitionController : Controller
    {
        private readonly IAcquisitionService _acquisitionService;

        public AcquisitionController(IAcquisitionService acquisitionService)
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
