using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Sliit.MTIT.Customer.Services;
using Sliit.MTIT.Customer.Models;
using Sliit.MTIT.Customer.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService) 
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }

        //get all customer
        // GET: api/<StudentController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_customerService.GetCustomers());
        }

        //get customer bu ID
        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _customerService.GetCustomer(id) != null ? Ok(_customerService.GetCustomer(id)) : NoContent();
        }

        //add customer
        // POST api/<CustomerController>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Customer customer)
        {
            return Ok(_customerService.AddCustomer(customer));
        }

        //update customer
        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Models.Customer customer)
        {
            return Ok(_customerService.UpdateCustomer(customer));
        }

        //delete customer with the passed ID
        // DELETE api/<customerController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _customerService.DeleteCustomer(id);

            return result.HasValue & result == true ? Ok($"customer with ID:{id} got deleted successfully.") : BadRequest($"Unable to delete the customer with the ID:{id}.");
        }
    }
}
