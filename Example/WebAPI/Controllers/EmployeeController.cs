using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    //[Authorize]
    public class EmployeeController : Controller
    {
        private readonly TrainingDbContext trainingDbContext;
        public EmployeeController(TrainingDbContext trainingDbContext)
        {
            this.trainingDbContext = trainingDbContext;
        }

        public CancellationToken EmpId { get; private set; }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var employee = await trainingDbContext.Employees.ToListAsync();
            return Ok(employee);
        }

        [HttpGet]
        [Route("get-employee-by-EmpId")]
        public async Task<IActionResult> GetEmployeeByEmpIdAsync(int EmpId)
        {
            var employee = await trainingDbContext.Employees.FindAsync(EmpId);
            return Ok(employee);
        }
        [HttpPost]
        [Route("Insert - Employee")]
        public async Task<IActionResult> PostAsync(Employee employee)
        {
            trainingDbContext.Employees.Add(employee);
            await trainingDbContext.SaveChangesAsync();
            return Created($"/get-employee-by-EmpId?EmpId={employee.EmpId}", employee);
        }
        [HttpPut]
        [Route("UPdate - Employee")]
        public async Task<IActionResult> PutAsync(Employee employee)
        {
            trainingDbContext.Employees.Update(employee);
            await trainingDbContext.SaveChangesAsync();
            return NoContent();
        }



        [Route("{EmpId} Delete - Employee")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(long EmpId)
        {

            var employee = await trainingDbContext.Employees.FindAsync(EmpId);
            if (employee == null)
            {
                return NotFound();
            }
            trainingDbContext.Employees.Remove(employee);
            await trainingDbContext.SaveChangesAsync();
            return NoContent();
        }
       /* [HttpGet]
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await trainingDbContext.Employees.ToListAsync();
            return Ok(response);
        }
        [HttpGet("{EmpId}")]
        public async Task<IActionResult> GetById(int EmpId)
        {
            var employee = await trainingDbContext.Employees.Where(a => a.EmpId == EmpId).FirstOrDefaultAsync();
            return Ok(new Response<Employees>(employee));
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await trainingDbContext.Employees.ToListAsync();
            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var response = await trainingDbContext.Employees.ToListAsync();
            return Ok(response);
        }*/

    }
}
