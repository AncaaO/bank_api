using Azure;

namespace Tokero_wallet.Entities
{
    public class Deposit
    {
        public int Id { get; set; }
        public int OperationId { get; set; }
        public decimal Amount { get; set; }
        public string FromAddress { get; set; }

        public Operation Operation { get; set; }
    }
}
