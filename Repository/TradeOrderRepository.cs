using Microsoft.EntityFrameworkCore;
using Tokero_wallet.Entities;
using Tokero_wallet.Interfaces;

namespace Tokero_wallet.Repository
{
    public class TradeOrderRepository : ITradeOrderRepository
    {
        private readonly ApplicationDbContext _context;
        public TradeOrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<TradeOrder> GetTradeOrderByOperationTypeId(int id) => _context.Operations
                                                                                    .Include(to => to.TradeOrder)
                                                                                    .ThenInclude(tot => tot.TradeOrderType)
                                                                                    .Where(x => x.OperationTypeId == id)
                                                                                    .Select(to => to.TradeOrder)
                                                                                    .ToList();


    }
}
