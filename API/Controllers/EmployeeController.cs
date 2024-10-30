using Microsoft.AspNetCore.Mvc;
using API.Model;
using API.ViewModel;

namespace API.Controllers
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        [HttpPost]
        public IActionResult Add(EmployeeViewModel employeeView)
        {
            var employee = new Employee(employeeView.Name, employeeView.Age );
            _employeeRepository.add(employee);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employess = _employeeRepository.get();
            
            return Ok(employess);
        
        }

    }
}
