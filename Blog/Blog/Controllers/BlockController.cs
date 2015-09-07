using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Models;
using Blog.Models.ViewModels;
using Blog.Service;

namespace Blog.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class BlockController : Controller
    {
        private BlockService _blockService = new BlockService();

        public BlockController()
        {

        }

        public BlockController(BlockService blockService)
        {
            _blockService = blockService;
        }

        // GET: Block
        public ActionResult Index()
        {
            List<Block> model = _blockService.GetAll();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)] 
        public ActionResult Create(BlockViewModel model)
        {
            if(ModelState.IsValid)
            {
                Block block = new Block();
                block.Name = model.Name;
                block.Content = model.Content;
                block.status = model.status? 1:0;
                _blockService.Create(block);

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Active(int Id)
        {
            _blockService.Active(Id);
            return RedirectToAction("Index");
        }

        public ActionResult Deactive(int Id)
        {
            _blockService.Deactive(Id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            Block block = _blockService.GetById(Id);
            BlockViewModel model = new BlockViewModel();
            model.Id = block.Id;
            model.Name = block.Name;
            model.Content = block.Content;
            model.status = (block.status == 1)? true : false;
            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)] 
        public ActionResult Edit(BlockViewModel model)
        {
            Block block = _blockService.GetById(model.Id);
            block.Name = model.Name;
            block.Content = model.Content;
            block.status = model.status ? 1 : 0;
            _blockService.Update(block);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            Block block = _blockService.GetById(Id);
            if (block != null)
                _blockService.Delete(block);
            return RedirectToAction("Index");
        }
    }
}