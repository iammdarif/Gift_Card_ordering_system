using GiftCardWebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace GiftCardWebAPI.Models.Repositories
{
    public class GiftCardRepository : IGiftCardRepository
    {
        private readonly AppDbContext _context;

        public GiftCardRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<GiftCard?> GetGiftCardById(int id)
        {
            return await _context.GiftCards.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<GiftCard>> GetGiftCards()
        {
            return await _context.GiftCards.ToListAsync();
        }

        public async Task AddGiftCard(GiftCard giftCard)
        {
            int maxId = _context.GiftCards.Max(x => x.Id);
            int id = maxId + 1;

            giftCard.Id = id;

            await _context.GiftCards.AddAsync(giftCard);
            await _context.SaveChangesAsync();
        }
    }
}
