using Microsoft.AspNetCore.Mvc;
using ProjectRegistration.Models;
using ProjectRegistration.Service;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeRegistationController : Controller
    {
        private readonly ITimeRegistrationService _timeRegistrationService;

        public TimeRegistationController(ITimeRegistrationService timeRegistrationService)
        {
            _timeRegistrationService = timeRegistrationService;
        }

        // GET
        // /timeregistration

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = _timeRegistrationService.List();
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return base.StatusCode(500, ex);
            }

        }

        // GET
        // /timeregistration/5


        [HttpGet, Route("{id}")]
        public IActionResult Single([FromRoute] int id)
        {
            try
            {
                var result = _timeRegistrationService.Single(id);
                if(result == null)
                {
                    return NotFound(id);
                }
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return base.StatusCode(500, ex);
            }

        }


        // POST
        // /timeregistration
        // Body skal have object

        [HttpPost]
        public IActionResult Create([FromBody] TimeRegistration dto)
        {
            try
            {
                 _timeRegistrationService.Create(dto);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return base.StatusCode(500, ex);
            }

        }

        // Put
        // /timeregistration/5
        // Body skal have object

        [HttpPut, Route("{id}")]
        public IActionResult Update([FromRoute] int id ,[FromBody] TimeRegistration dto)
        {
            try
            {
                var result = _timeRegistrationService.Single(id);
                if (result == null)
                {
                    return NotFound(id);
                }
                _timeRegistrationService.Update(id, dto);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return base.StatusCode(500, ex);
            }

        }

        // Delete
        // /timeregistration/5

        [HttpDelete, Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                var result = _timeRegistrationService.Single(id);
                if (result == null)
                {
                    return NotFound(id);
                }
                _timeRegistrationService.Delete(id);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return base.StatusCode(500, ex);
            }

        }
    }
}
