using Microsoft.EntityFrameworkCore;
using Tokero_wallet.Entities;
using Tokero_wallet.Interfaces;

namespace Tokero_wallet.Repository
{
    public class WithdrawalRepository : IWithdrawalRepository
    {
        private readonly ApplicationDbContext _context;
        public WithdrawalRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Withdrawal> GetWithdrawalByOperationTypeId(int id) =>
                                _context.Operations
                                        .Include(w => w.Withdrawal)
                                        .Where(x => x.OperationTypeId == id)
                                        .Select(w => w.Withdrawal)
                                        .ToList();
    }
}
