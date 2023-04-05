using Tokero_wallet.Entities;

namespace Tokero_wallet.Interfaces
{
    public interface IWithdrawalRepository
    {
        List<Withdrawal> GetWithdrawalByOperationTypeId(int id);

    }
}
