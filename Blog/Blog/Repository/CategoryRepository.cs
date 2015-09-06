using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Blog.Models;

namespace Blog.Repository
{
    public class CategoryRepository
    {
        private DbCon dbCon = new DbCon();

        public Category GetById(int id)
        {
            return dbCon.Categories.Find(id);
        }

        public Category GetByIdIncludeTopic(int id)
        {
            return dbCon.Categories.Include(x => x.Topics).Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Category> GetAll()
        {
            return dbCon.Categories.ToList();
        }
         
        public List<Category> GetAllIncludeTopic()
        {
            return dbCon.Categories.Include(x => x.Topics).ToList();
        }

        public void Create(string name)
        {
            Category category = new Category();
            category.Name = name;
            dbCon.Categories.Add(category);
            dbCon.SaveChanges();
        }

        public void Update(Category category)
        {
            Category _category = dbCon.Categories.SingleOrDefault(x => x.Id == category.Id);
            if (_category != null)
            {
                _category.Name = category.Name;
                dbCon.SaveChanges();
            }
        }
    }
}