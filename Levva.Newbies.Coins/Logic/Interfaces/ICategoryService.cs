using Levva.Newbies.Coins.Logic.Dtos;

namespace Levva.Newbies.Coins.Logic.Interfaces
{
    public interface ICategoryService
    {
        CategoryDto Create(CreateCategoryDto category);
        CategoryDto Get(int Id);
        List<CategoryDto> GetAll();
        void Update(CategoryDto category);
        void Delete(int Id);
    }
}
