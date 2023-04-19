using Sliit.MTIT.Customer.Data;
using Sliit.MTIT.Customer.Models;

namespace Sliit.MTIT.Customer.Services
{
    public class CustomerService:ICustomerService
    {
        public List<Models.Customer> GetCustomers()
        { return CustomerMockDataService.Customers; }

        public Models.Customer? GetCustomer(int id) 
        { return CustomerMockDataService.Customers.FirstOrDefault(x => x.Id == id); }

        public Models.Customer? AddCustomer(Models.Customer customer)
        {
            CustomerMockDataService.Customers.Add(customer);
            return customer;
        }

        public Models.Customer UpdateCustomer(Models.Customer customer)
        {
            Models.Customer selectedCustomer = CustomerMockDataService.Customers.FirstOrDefault(x => x.Id == customer.Id);
            if (selectedCustomer != null)
            {
                selectedCustomer.Address = customer.Address;
                selectedCustomer.Age = customer.Age;
                selectedCustomer.Name = customer.Name;
                selectedCustomer.requirment = customer.requirment;
                return selectedCustomer;
            }
            return selectedCustomer;
        }

        public bool? DeleteCustomer(int id)
        {
            Models.Customer selectedCustomer = CustomerMockDataService.Customers.FirstOrDefault(x => x.Id == id);
            if (selectedCustomer != null)
            {
                CustomerMockDataService.Customers.Remove(selectedCustomer);
                return true;
            }
            return false;
        }
    }
}
