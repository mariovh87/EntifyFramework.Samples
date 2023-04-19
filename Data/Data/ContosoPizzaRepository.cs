using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Samples.Data.Models.ContosoPizza;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityFramework.Samples.Data.Data
{
    public class ContosoPizzaRepository
    {
        private readonly ContosoPizzaContext _context;
        
        public ContosoPizzaRepository(ContosoPizzaContext context)        
        {
            _context = context;
        }

        /// <summary>
        /// AsNoTraking to snapshot the data in memory
        /// Use in readonly scenarios
        /// Eager -> Include, related orders in same query as customers
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Customer>> GetCustomersEager()
        {
            return await _context.Customers
                .Include(c=>c.Orders)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// AsNoTraking not compatible with lazy loading
        /// Lazy loading -> related orders in separate query
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Customer>> GetCustomersLazy()
        {
            return await _context.Customers
                .ToListAsync();
        }

        /// <summary>
        /// Cartesian explosion
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Customer>> GetCustomers()
        {
            return await _context.Customers
                .Include(c => c.Orders)
                .ThenInclude(c => c.OrderDetails)
                .ThenInclude(c => c.Product)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<IList<Customer>> GetCustomersSplitQuery()
        {
            return await _context.Customers
                .Include(c => c.Orders)
                .ThenInclude(c => c.OrderDetails)
                .ThenInclude(c => c.Product)
                .AsSplitQuery()
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Customer?> FindCustomerById()
        {
            return await _context.Customers.FirstOrDefaultAsync(c => c != null && c.CustomerId == 1);
        }

        /// <summary>
        /// Search in the snapshot first before accesing to the database
        /// </summary>
        /// <returns></returns>
        public async Task<Customer?> FindFromInMemorySnapshotCustomerById()
        {
            return await _context.Customers.FindAsync(1);
        }
    }
}
