using AspNetCoreApiWebApplication.Models;
using AspNetCoreApiWebApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace AspNetCoreApiWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService service)
        {
            _employeeService = service;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult getAllEmployees()
        {
            try
            {
                var employees = _employeeService.GetEmployeesList();
                if (employees == null) return NotFound();
                return Ok(employees);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
                       
        }

        [HttpGet]
        [Route("[action]/id")]
        public IActionResult GetEmployeesById(int id)
        {
            try
            {
                var employees = _employeeService.GetEmployeeDetailsById(id);
                if (employees == null) return NotFound();
                return Ok(employees);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult SaveEmployees(Employees employeeModel)
        {
            try
            {
                var model = _employeeService.SaveEmployee(employeeModel);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("[action]/id")]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                var model = _employeeService.DeleteEmployee(id);
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
