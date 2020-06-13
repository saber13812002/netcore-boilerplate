using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HappyCode.NetCoreBoilerplate.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace HappyCode.NetCoreBoilerplate.Core.Repositories
{
    public interface IShippingExpressRepository
    {
        Task<List<Express>> GetAllAsync(CancellationToken token);
    }

    public class ShippingExpressRepository : IShippingExpressRepository
    {
        private readonly ShippingExpressContext _dbContext;

        public ShippingExpressRepository(ShippingExpressContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Express>> GetAllAsync(CancellationToken token)
        {
            return _dbContext.Express
                .AsNoTracking()
                .ToListAsync(token);
        }
    }
}
