
namespace GiftCardWebAPI.Models.Repositories
{
    public interface IGiftCardRepository
    {
        Task AddGiftCard(GiftCard giftCard);
        Task<GiftCard?> GetGiftCardById(int id);
        Task<IEnumerable<GiftCard>> GetGiftCards();
    }
}