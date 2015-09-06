using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.Models;
using Blog.Repository;

namespace Blog.Service
{  
    public class CategoryService
    {
        CategoryRepository _categoryRepository = new CategoryRepository();

        public bool IsDuplicate(string categoryName)
        {
            List<Category> categories = _categoryRepository.GetAll();
            foreach(var item in categories)
            {
                if (categoryName.Equals(item.Name))
                    return false;
            }
            return true;

        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public Category GetByIdIncludeTopic(int id)
        {
            return _categoryRepository.GetByIdIncludeTopic(id);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public void Create(string name)
        {
            _categoryRepository.Create(name);
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}