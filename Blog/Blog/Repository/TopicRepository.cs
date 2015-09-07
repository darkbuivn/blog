using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Blog.Models;

namespace Blog.Repository
{
    public class TopicRepository
    {
        private DbCon dbCon = new DbCon();

        public Topic GetById(int Id)
        {
            return dbCon.Topics.Where(x => x.Id == Id).FirstOrDefault();
        }

        public Topic GetByIdWithCategory(int Id)
        {
            return dbCon.Topics.Include(x => x.Category).Where(x => x.Id == Id).FirstOrDefault();
        }

        public List<Topic> GetAll()
        {
            return dbCon.Topics.ToList();
        }

        public List<Topic> GetAllIncludeCategory()
        {
            return dbCon.Topics.Include(x => x.Category).ToList();
        }

        public List<Topic> GetAllWithCategoryId(int categoryId)
        {
            return dbCon.Topics.Where(x => x.CategoryId == categoryId).ToList();
        }

        public List<Topic> GetAllWithCategoryIdIncludeCategory(int categoryId)
        {
            return dbCon.Topics.Include(x => x.Category).Where(x => x.CategoryId == categoryId).ToList();
        }

        public List<Topic> GetOrthersWithCategoryId(int categoryId, int Id)
        {
            return dbCon.Topics.Where(x => x.CategoryId == categoryId).Where(x => x.Id != Id).ToList();
        }

        public List<Topic> GetNew()
        {
            return dbCon.Topics.OrderByDescending(x => x.Id).Take(5).ToList();
        }

        public void Create(Topic topic)
        {
            dbCon.Topics.Add(topic);
            dbCon.SaveChanges();
        }

        public List<Topic> GetMore(int id) 
        {
            return dbCon.Topics.Where(x => x.Id < id).OrderByDescending(x => x.Id).Take(5).ToList();
        }

        public Topic GetLasted()
        {
            return dbCon.Topics.OrderByDescending(x => x.Id).FirstOrDefault();
        }

        public List<Topic> SearchResult(string searchstr) 
        {
            return dbCon.Topics.Where(x => x.Title.Contains(searchstr) || x.ShortDesc.Contains(searchstr) || x.Content.Contains(searchstr)).ToList();
        }

        public void Update(Topic topic)
        {
            Topic _topic = dbCon.Topics.SingleOrDefault(x => x.Id == topic.Id);
            if (_topic != null)
            {
                _topic.ShortDesc = topic.ShortDesc;
                _topic.Content = topic.Content;
                _topic.CategoryId = topic.CategoryId;
                _topic.Title = topic.Title;
                _topic.Image = topic.Image;
                dbCon.SaveChanges();
            }
        }
    }
}