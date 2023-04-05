using Tokero_wallet.Entities;

namespace Tokero_wallet.Interfaces
{
    public interface IDepositRepository
    {
        List<Deposit> GetDepositByOperationTypeId(int id);
    }
}
