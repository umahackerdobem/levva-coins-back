using Levva.Newbies.Coins.Domain.Enums;

namespace Levva.Newbies.Coins.Logic.Dtos
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public decimal Value { get; set; }
        public TypeTransactionEnum Type { get; set; }
        public DateTime Date { get; set; }

        public virtual CategoryDto? Category { get; set; }
    }
}
