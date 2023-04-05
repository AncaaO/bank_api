using Microsoft.AspNetCore.Mvc;
using Tokero_wallet.Entities;
using Tokero_wallet.Repository;

namespace Tokero_wallet.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WithdrawalController : ControllerBase
    {
        private readonly ILogger<WithdrawalController> _logger;
        private readonly WithdrawalRepository _withdrawalRepository;

        public WithdrawalController(ILogger<WithdrawalController> logger, 
                                    WithdrawalRepository withdrawalRepository)
        {
            _logger = logger;
            _withdrawalRepository = withdrawalRepository;
        }

        [HttpGet(Name = "GetWithdrawal")]
        public IEnumerable<Withdrawal> Get(int operationTypeId) => 
                                        _withdrawalRepository.GetWithdrawalByOperationTypeId(operationTypeId);
        
    }
}