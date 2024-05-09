using GiftCardWebAPI.Data;
using GiftCardWebAPI.Models;
using GiftCardWebAPI.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GiftCardWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IGiftCardRepository _giftCardRepository;

        public OrdersController(IGiftCardRepository giftCardRepository)
        {
            _giftCardRepository = giftCardRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<GiftCard?>> GetGiftCards()
        {
            return await _giftCardRepository.GetGiftCards();
        }
        
        [HttpGet("{id:int}")]
        public async Task<GiftCard?> GetGiftCardById(int id)
        {
            return await _giftCardRepository.GetGiftCardById(id);
        }

        [HttpPost]
        public async Task PostGiftCard([FromBody] GiftCard giftCard)
        {
            await _giftCardRepository.AddGiftCard(giftCard);        
        }
    }
}
