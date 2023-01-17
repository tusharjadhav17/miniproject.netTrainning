using Amazon.S3.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
//using WebAPI.Response;
using WebAPI.Model;
using WebAPI.Controllers;

namespace WebAPI.Model.Controllers
{
    public class ApiController : Controller
    {
        private readonly TrainingDbContext context;
        public ApiController(TrainingDbContext trainingDbContext)
        {

            this.context = trainingDbContext;
        }


        [HttpGet]
        [Route("Pagging")]
        public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter)
        {
           
            var res = context.Employees.OrderBy(c => c.EmpId).Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize).ToList();         
            var Total = await context.Employees.CountAsync();

            /*var Data = (from p in Employees
                        orderby p.EmpId descending
                         select p).Skip(filter.PageNumber).Take(filter.PageSize).ToList(); 
            var count = Data.Count();*/
            // var promotionInfo = source.Skip(filter.PageNumber).Take(filter.PageSize).ToList();


            return Ok(new PagedResponse<List<Employee>>(res, filter.PageNumber, filter.PageSize));

            // Ok(new PagedResponse<List<Employee>>(source,source.PageNumber, source.PageSize, count));
        }
        

    }
}