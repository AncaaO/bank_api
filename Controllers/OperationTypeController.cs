using Microsoft.AspNetCore.Mvc;
using Tokero_wallet.Entities;
using Tokero_wallet.Repository;

namespace Tokero_wallet.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OperationTypeController : ControllerBase
    {
        private readonly ILogger<OperationTypeController> _logger;
        private readonly OperationTypeRepository _operationTypeRepository;

        public OperationTypeController(ILogger<OperationTypeController> logger, 
                                        OperationTypeRepository operationTypeRepository)
        {
            _logger = logger;
            _operationTypeRepository = operationTypeRepository;
        }

        [HttpGet(Name = "GetOperationType")]
        public IEnumerable<OperationType> GetAll() => _operationTypeRepository.GetAll();
        
    }
}