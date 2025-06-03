
using Microsoft.EntityFrameworkCore.ChangeTracking;

public class CategoryService : ICategoryService
{
    ICategoryRepo _categoryRepo;
    public CategoryService(ICategoryRepo categoryRepo)
    {
        _categoryRepo = categoryRepo;
    }
    public void Create(Category category)
    {
       _categoryRepo.Create(category);
    }

    public void Delete(int id)
    {
       _categoryRepo.Delete(id);
    }

    public IEnumerable<Category> GetAll()
    {
       var categories=_categoryRepo.GetAll();
        return categories;
    }

    public Category GetById(int id)
    {
        Category cat = _categoryRepo.GetById(id);

        return cat;
    }

    public void Update(Category category)
    {
        _categoryRepo.Update(category);
    }
}