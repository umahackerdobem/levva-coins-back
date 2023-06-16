using AutoMapper;
using Levva.Newbies.Coins.Data.Interfaces;
using Levva.Newbies.Coins.Domain.Models;
using Levva.Newbies.Coins.Logic.Dtos;
using Levva.Newbies.Coins.Logic.Interfaces;

namespace Levva.Newbies.Coins.Logic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CategoryDto Create(CreateCategoryDto category)
        {
            var _category = _mapper.Map<Category>(category);
            var categorCreated = _repository.Create(_category);

            return _mapper.Map<CategoryDto>(categorCreated);
        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public CategoryDto Get(int Id)
        {
            var category = _mapper.Map<CategoryDto>(_repository.Get(Id));
            return category;
        }

        public List<CategoryDto> GetAll()
        {
            var categories = _mapper.Map<List<CategoryDto>>(_repository.GetAll());
            return categories;
        }

        public void Update(CategoryDto category)
        {
            var _category = _mapper.Map<Category>(category);
            _repository.Update(_category);
        }
    }
}
