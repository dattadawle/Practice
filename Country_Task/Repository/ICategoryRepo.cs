﻿public interface ICategoryRepo
{
    IEnumerable<Category> GetAll();

    Category GetById(int id);

    void Create(Category category);
    void Update(Category category);
    void Delete(int id);


}