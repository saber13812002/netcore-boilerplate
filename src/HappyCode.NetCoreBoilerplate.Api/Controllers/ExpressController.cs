using System.Threading;
using System.Threading.Tasks;
using HappyCode.NetCoreBoilerplate.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HappyCode.NetCoreBoilerplate.Api.Controllers
{
    [Route("api/express")]
    public class ExpressController : ApiControllerBase
    {
        private readonly IShippingExpressRepository _shippingExpressRepository;

        public ExpressController(IShippingExpressRepository shippingExpressRepository)
        {
            _shippingExpressRepository = shippingExpressRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(
            CancellationToken cancellationToken = default)
        {
            var result = await _shippingExpressRepository.GetAllAsync(cancellationToken);
            return Ok(result);
        }
    }
}
