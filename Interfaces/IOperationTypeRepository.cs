using Tokero_wallet.Entities;

namespace Tokero_wallet.Interfaces
{
    public interface IOperationTypeRepository
    {
        List<OperationType> GetAll();

    }
}
