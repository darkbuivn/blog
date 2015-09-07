using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.Models;
using Blog.Repository;

namespace Blog.Service
{
    public class BlockService
    {
        BlockRepository _blockRepository = new BlockRepository();

        public Block GetById(int id)
        {
            return _blockRepository.GetById(id);
        }

        public List<Block> GetAll()
        {
            return _blockRepository.GetAll();
        }

        public void Create(Block block)
        {
            _blockRepository.Create(block);
        }

        public void Active(int id)
        {
            _blockRepository.Active(id);
        }

        public void Deactive(int id)
        {
            _blockRepository.Deactive(id);
        }

        public void Update(Block block)
        {
            _blockRepository.Update(block);
        }

        public void Delete(Block block)
        {
            _blockRepository.Delete(block);
        }
    }
}