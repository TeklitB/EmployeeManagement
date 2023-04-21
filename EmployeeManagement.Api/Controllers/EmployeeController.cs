using EmployeeManagement.Api.DataAccess;
using EmployeeManagement.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeDbContext context;

        public EmployeeController(EmployeeDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Employee>> GetAll()
            => await context.Employees.ToArrayAsync();

        [HttpPost]
        public async Task<Employee> Add([FromBody] Employee c)
        {
            context.Employees.Add(c);
            await context.SaveChangesAsync();
            return c;
        }
    }
}
