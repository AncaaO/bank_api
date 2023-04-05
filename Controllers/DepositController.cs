using Microsoft.AspNetCore.Mvc;
using Tokero_wallet.Entities;
using Tokero_wallet.Repository;

namespace Tokero_wallet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepositController : ControllerBase
    {
        private readonly ILogger<DepositController> _logger;
        private readonly DepositRepository _depositRepository;

        public DepositController(ILogger<DepositController> logger, DepositRepository depositRepository)
        {
            _logger = logger;
            _depositRepository = depositRepository;
        }

        [HttpGet(Name = "GetDeposit")]
        public IEnumerable<Deposit> Get(int operationTypeId) => _depositRepository
                                                                .GetDepositByOperationTypeId(operationTypeId);
        
    }
}