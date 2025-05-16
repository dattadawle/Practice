using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperation.Models
{
    public  interface ICategoryDAl
    {
         List<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void Create(Category category);
        void Update(Category category);
        void Delete(int id);



    }
}
