using FluentValidation;
using GlobalErrorHandling.Exceptions;
using GlobalErrorHandling.Models;
using GlobalErrorHandling.Validators;
using Microsoft.AspNetCore.Mvc;

namespace GlobalErrorHandling.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Customer Get(int id)
        {
            if (id == 1)
            {
                return new Customer
                {
                    Id = 1,
                    Name = "John",
                    Surname = "Doe",
                    Email = "john.doe@test.com"
                };
            }

            throw new CustomerNotFoundException(id);
        }

        [HttpPost]
        public void Add(Customer customer)
        {
            var customerValidator = new CustomerValidator();
            customerValidator.ValidateAndThrow(customer);
        }
    }
}
