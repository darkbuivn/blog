using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.Models;

namespace Blog.Repository
{
    public class BlockRepository
    {
        private DbCon dbCon = new DbCon();

        public Block GetById(int id)
        {
            return dbCon.Blocks.Find(id);
        }

        public List<Block> GetAll()
        {
            return dbCon.Blocks.ToList();
        }

        public void Create(Block block)
        {
            dbCon.Blocks.Add(block);
            dbCon.SaveChanges();
        }

        public void Active(int id)
        {
            Block block = dbCon.Blocks.SingleOrDefault(x => x.Id == id);
            if (block != null)
            {
                block.status = 1;
                dbCon.SaveChanges();
            }
        }

        public void Deactive(int id)
        {
            Block block = dbCon.Blocks.SingleOrDefault(x => x.Id == id);
            if (block != null)
            {
                block.status = 0;
                dbCon.SaveChanges();
            }
        }
         
        public void Update(Block block)
        {
            Block _block = dbCon.Blocks.SingleOrDefault(x => x.Id == block.Id);
            if (_block != null)
            {
                _block.status = block.status;
                _block.Name = block.Name;
                _block.Content = block.Content;
                dbCon.SaveChanges();
            }
        }

        public void Delete(Block block)
        {
            dbCon.Blocks.Remove(block);
            dbCon.SaveChanges();
        }
    }
}