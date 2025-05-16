using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDOperation.Models
{
    public class CategoryBAL : ICategoryBAL
    {
        ICategoryDAl categoryDal;
        public CategoryBAL(ICategoryDAl categoryDAl)
        {
            categoryDal = categoryDAl;
        }
        public List<Category> GetAllCategories()
        {
           /* CategoryDal categoryDal = new CategoryDal();*/

          var categories= categoryDal.GetAllCategories().ToList();
            return categories;
        }

        public Category GetCategoryById(int id)
        {
            /*CategoryDal categoryDal = new CategoryDal();*/

            Category category= categoryDal.GetCategoryById(id);
            return category;
        }

        public void Create(Category category)
        {
           /* CategoryDal categoryDal= new CategoryDal();*/
            categoryDal.Create(category);
        }

        public void Update(Category category)
        {
          /*  CategoryDal categoryDal= new CategoryDal();*/
            categoryDal.Update(category);
        }

        public void Delete(int id)
        {
           /* CategoryDal categoryDal = new CategoryDal();*/
            categoryDal.Delete(id);
        }


    }
}