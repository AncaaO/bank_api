using Microsoft.EntityFrameworkCore;
using Bank.Entities;
using Bank.Interfaces;

namespace Bank.Repository
{
    public class CoinRepository : ICoinRepository
    {
        private readonly ApplicationDbContext _context;
        public CoinRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void CreateCoin(Coin coin)
        {
            coin.When = DateTime.Now;
            coin.Deleted = false;

            _context.Coins.Add(coin);
            _context.SaveChanges();
        }
        public List<Coin> GetAllCoins()
        {
            List<Coin> coins = _context.Coins.ToList();
            return coins;
        }
        public Coin GetCoinById(int coinId)
        {
            var coin = _context.Coins.Where(c => c.Id == coinId).FirstOrDefault();
            return coin;
        }
        public Coin GetCoinByName(string coinName)
        {
            Coin coin = _context.Coins.Where(c => c.Name == coinName).FirstOrDefault();
            return coin;
        }
        public void DeleteCoin(int coinId)
        {
            var coin = _context.Coins.Where(c => c.Id == coinId).FirstOrDefault();
            coin.Deleted = true;
            _context.SaveChanges();
        }
        public Coin EditCoin(Coin coin)
        {
            var thiscoin = _context.Coins.Where(c => c.Id == coin.Id).FirstOrDefault();

            thiscoin.Description = coin.Description;
            thiscoin.Name = coin.Name;
            thiscoin.Updated = DateTime.Now;
            thiscoin.Deleted = false;

            _context.SaveChanges();
            return thiscoin;
        }
    }
}

