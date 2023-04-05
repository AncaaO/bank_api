using Microsoft.AspNetCore.Mvc;
using Tokero_wallet.Entities;
using Tokero_wallet.Repository;

namespace Tokero_wallet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TradeOrderController : ControllerBase
    {
        private readonly ILogger<TradeOrderController> _logger;
        private readonly TradeOrderRepository _tradeOrderRepository;

        public TradeOrderController(ILogger<TradeOrderController> logger, TradeOrderRepository tradeOrderRepository)
        {
            _logger = logger;
            _tradeOrderRepository = tradeOrderRepository;
        }

        [HttpGet(Name = "GetTradeOrder")]
        public IEnumerable<TradeOrder> Get(int operationTypeId) => _tradeOrderRepository
                                                                .GetTradeOrderByOperationTypeId(operationTypeId);
        
    }
}