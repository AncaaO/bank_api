using Bank.Entities;
using Bank.Interfaces;
using Bank.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CoinController : ControllerBase
    {
        private readonly ILogger<CoinController> _logger;
        private readonly CoinRepository _coinRepository;

        public CoinController(ILogger<CoinController> logger, CoinRepository coinRepository)
        {
            _logger = logger;
            _coinRepository = coinRepository;
        }

        [HttpGet(Name = "GetAllCoins")]
        public IEnumerable<Coin> GetAll() => _coinRepository.GetAllCoins();

        [HttpGet(Name = "GetAllExistingCoins")]
        public IEnumerable<Coin> GetAllExisting() => _coinRepository.GetAllExistingCoins();

        [HttpGet(Name = "GetCoinById")]
        public Coin GetById(int coinId) => _coinRepository.GetCoinById(coinId);
        
        [HttpDelete(Name = "DeleteCoin")]
        public void Delete(int coinId) => _coinRepository.DeleteCoin(coinId);
        
        [HttpPut(Name = "EditCoin")]
        public Coin Edit(Coin coin) => _coinRepository.EditCoin(coin);
        
        [HttpPost(Name = "CreateCoin")]
        public void Create(Coin coin) => _coinRepository.CreateCoin(coin);
        
    }
}
