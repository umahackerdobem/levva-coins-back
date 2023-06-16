using Levva.Newbies.Coins.Domain.Models;

namespace Levva.Newbies.Coins.Data.Interfaces
{
    public interface ICategoryRepository
    {
        Category Create(Category category);
        Category Get(int Id);
        List<Category> GetAll();
        void Update(Category category);
        void Delete(int Id);
    }
}
