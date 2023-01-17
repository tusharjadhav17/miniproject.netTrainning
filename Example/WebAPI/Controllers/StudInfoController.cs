/*using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class StudInfoController : Controller
    {
        private readonly TrainingDbContext trainingDbContext;
        public StudInfoController(TrainingDbContext trainingDbContext)
        {
            this.trainingDbContext = trainingDbContext;
        }

       // public CancellationToken EmpId { get; private set; }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            List<Employee> employee = await trainingDbContext.Employees.ToListAsync();
            return Ok(employee);
        }

        [HttpGet]
        [Route("get-employee-by-EmpId")]
        public async Task<IActionResult> GetEmployeeByEmpIdAsync(int EmpId)
        {
            var employee = await trainingDbContext.Employees.FindAsync( EmpId);
            return Ok(employee);
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(Employee employee)
        {
            trainingDbContext.Employees.Add(employee);
            await trainingDbContext.SaveChangesAsync();
            return Created($"/get-employee-by-EmpId?EmpId={employee.EmpId}", employee);
        }
    }
}

*/