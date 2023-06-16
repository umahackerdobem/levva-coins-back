using Levva.Newbies.Coins.Domain.Enums;

namespace Levva.Newbies.Coins.Logic.Dtos
{
    public class CreateTransactionDto
    {
        public string? Description { get; set; }
        public decimal Value { get; set; }
        public TypeTransactionEnum Type { get; set; }
        public int CategoryId { get; set; }

    }
}
