namespace Sliit.MTIT.Customer.Data
{
    public static class CustomerMockDataService
    {
        public static List<Models.Customer> Customers = new List<Models.Customer>()
        {
            new Models.Customer { Id = 1, Name = "Mr.Kalum", Address = "123 Main St", Age = 35, requirment = "Need to create High level desgin logos"},
            new Models.Customer { Id = 2, Name = "Ms.Henrry", Address = "456 Second Ave", Age = 55, requirment = "Need to create Banners"},
            new Models.Customer { Id = 3, Name = "Mr.Sadruwan", Address = "789 Third St", Age = 21, requirment = "Cahnge the previos logos to new one"},
            new Models.Customer { Id = 4, Name = "Ms.Nadeesha", Address = "321 Fourth Ave", Age = 24, requirment = "Need to create facebook campaign"},
            new Models.Customer { Id = 5, Name = "Mr.Kasun", Address = "654 Fifth St", Age = 39, requirment = "Need to create High level desgin logos"},
        };
            
    }
}
