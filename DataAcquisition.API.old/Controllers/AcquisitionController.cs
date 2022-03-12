using System;
using System.Threading.Tasks;
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
        public async Task<IActionResult> StartDataAcquisition(AcquisitionConfig config)
        {
            await _acquisitionService.StartDataAcquisition(config);
            return NoContent();
        }

    }
}
