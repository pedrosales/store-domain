using Store.Domain.Entities;
using Store.Domain.Repositories.Interfaces;

namespace Store.Tests.Repositories
{
    public class FakeCostumerRepository : ICustomerRepository
    {
        public Customer Get(string document)
        {
            if (document == "12345678911")
            {
                return new Customer("Pedro Ivo", "pedroivossantos@gmail.com");
            }

            return null;
        }
    }
}