using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CRUDOperation.Models
{
    public class CategoryDal : ICategoryDAl
    {
        ProductDbContext db;
        public CategoryDal(ProductDbContext context)
        {
            this.db = context;
        }

        public List<Category> GetAllCategories()
        {
            //ProductDbContext db = new ProductDbContext();
            var categories = db.Categories.ToList();
            return categories;
        }

        public Category GetCategoryById(int id)
        {
            //ProductDbContext db = new ProductDbContext();
            Category category = db.Categories.Find(id);
            return category;

        }

        public void Create(Category category)
        {
            //ProductDbContext db = new ProductDbContext();
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Update(Category category)
        {
            //ProductDbContext db = new ProductDbContext();
            db.Entry<Category>(category).State= EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            //ProductDbContext db = new ProductDbContext();
            Category dbCategory = db.Categories.Find(id);
            db.Categories.Remove(dbCategory);
            db.SaveChanges();
        }

    }
}