using Tokero_wallet.Entities;
using Tokero_wallet.Interfaces;

namespace Tokero_wallet.Repository
{
    public class OperationTypeRepository : IOperationTypeRepository
    {
        private readonly ApplicationDbContext _context;
        public OperationTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<OperationType> GetAll() => _context.OperationTypes.ToList(); 
    }
}
