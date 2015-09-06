using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.Models;
using Blog.Repository;

namespace Blog.Service
{
    public class TopicService
    {
        private TopicRepository _topicRepository = new TopicRepository();        

        public Topic GetById(int Id)
        {
            return _topicRepository.GetById(Id);
        }

        public List<Topic> GetAll()
        {
            return _topicRepository.GetAll();
        }

        public Topic GetByIdWithCategory(int Id)
        {
            return _topicRepository.GetByIdWithCategory(Id);
        }

        public List<Topic> GetAllIncludeCategory()
        {
            return _topicRepository.GetAllIncludeCategory();
        }

        public List<Topic> GetAllWithCategoryId(int categoryId)
        {
            return _topicRepository.GetAllWithCategoryId(categoryId);
        }
        
        public List<Topic> GetAllWithCategoryIdIncludeCategory(int categoryId)
        {
            return _topicRepository.GetAllWithCategoryIdIncludeCategory(categoryId);
        }

        public void Create(Topic topic)
        {
            _topicRepository.Create(topic);
        }

        public List<Topic> GetNew()
        {
            return _topicRepository.GetNew();
        }
        public void Update(Topic topic)
        {
            _topicRepository.Update(topic);
        }
        public List<Topic> GetMore(int id)
        {
            return _topicRepository.GetMore(id);
        }
        public Topic GetLasted()
        {
            return _topicRepository.GetLasted();
        }
    }
}