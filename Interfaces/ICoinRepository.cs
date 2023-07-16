using Bank.Entities;

namespace Bank.Interfaces
{
    public interface ICoinRepository
    {
        List<Coin> GetAllCoins();
        List<Coin> GetAllExistingCoins();
        Coin GetCoinById(int id);
        Coin GetCoinByName(string name);
        void DeleteCoin(int id);
        Coin EditCoin(Coin coin);
        
    }


}

