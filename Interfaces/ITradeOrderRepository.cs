using Tokero_wallet.Entities;

namespace Tokero_wallet.Interfaces
{
    public interface ITradeOrderRepository
    {
        List<TradeOrder> GetTradeOrderByOperationTypeId(int id);
    }
}
