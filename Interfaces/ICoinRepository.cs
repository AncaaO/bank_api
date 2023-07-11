using Bank.Entities;

namespace Bank.Interfaces
{
    public interface ICoinRepository
    {
        Coin GetCoinById(int id);
        List<Coin> GetAllCoins();
        Coin GetCoinByName(string name);
        void DeleteCoin(int id);
        Coin EditCoin(Coin coin);
        //get all 
        //get by name, delete, edit
    }


}

