using Microsoft.AspNetCore.Mvc;
using Ristorante.Entity;
using Ristorante.Service;

namespace Ristorante.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlateController : ControllerBase
    {

        private readonly IPlateService plateService;
        private readonly ILoggingService logger;

        public PlateController(IPlateService plateService, ILoggingService logger)
        {
            this.plateService = plateService;
            this.logger = logger;
        }

        [HttpPost("Post")]
        public async Task<IActionResult> Create([FromBody] Plate plate)
        {
            try
            {
                await plateService.CreatePlateAsync(plate);
                return Ok("Plate Created");


            }catch(Exception ex)
            {
                return logger.Log(ex.Message);
            }
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var getPlates= await plateService.GetAllPlate();
                return Ok(getPlates);


            }
            catch (Exception ex)
            {
                return logger.Log(ex.Message);
            }
        }

        [HttpGet("GetAllPlateType")]
        public async Task<IActionResult> GetAllPlateType(string type)
        {
            try
            {
                var getPlates = await plateService.GetAllPlateType(type);
                if (getPlates == null) { NoContent(); }
                return Ok(getPlates);


            }
            catch (Exception ex)
            {
                return logger.Log(ex.Message);
            }
        }

        [HttpGet("GetAllPlateUnder10")]
        public async Task<IActionResult> GetAllPlateUnder10()
        {
            try
            {
                var getPlates = await plateService.GetAllPlateUnder10();
                if(getPlates == null) { NoContent(); }
                return Ok(getPlates);


            }
            catch (Exception ex)
            {
                return logger.Log(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllPlateUnder10(Guid id)
        {
            try
            {
                await plateService.GetById(id);
                
                return Ok();


            }
            catch (Exception ex)
            {
                return logger.Log(ex.Message);
            }
        }

        [HttpPut("Put")]
        public async Task<IActionResult> Edit(Guid id,[FromBody]Plate plate)
        {
            try
            {
                
                var getPlates =  plateService.Update(plate);
                await plateService.GetById(id);
                if (getPlates == null) { NoContent(); }
                return Ok(getPlates);


            }
            catch (Exception ex)
            {
                return logger.Log(ex.Message);
            }
        }
    }
}
