
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
public class CategoryRepo : ICategoryRepo
{
    ApplicationDbContext _context;
    public CategoryRepo(ApplicationDbContext context)
    {
        _context = context;
    }
    public void Create(Category category)
    {
       _context.Categories.Add(category);
        _context.SaveChanges();

    }

    public void Delete(int id)
    {
        _context.Remove(id);
        _context.SaveChanges();
    }

    public IEnumerable<Category> GetAll()
    {
      var categories= _context.Categories;
        return categories;
    }

    public Category GetById(int id)
    {
        Category category = _context.Categories.Find(id);

        return category;
    }

    public void Update(Category category)
    {
        _context.Categories.Attach(category);
        _context.Entry(category).State= EntityState.Modified;
        _context.SaveChanges();
    }
}