using Microsoft.EntityFrameworkCore;
using Tokero_wallet.Entities;
using Tokero_wallet.Interfaces;

namespace Tokero_wallet.Repository
{
    public class DepositRepository : IDepositRepository
    {
        private readonly ApplicationDbContext _context;
        public DepositRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Deposit> GetDepositByOperationTypeId(int id) => _context.Operations
                                                                            .Include(dep=>dep.Deposit)
                                                                            .Where(x=>x.OperationTypeId == id)
                                                                            .Select(dep=>dep.Deposit)
                                                                            .ToList();
    }
}
