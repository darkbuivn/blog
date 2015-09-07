using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models.ViewModels
{
    public class BlockViewModel
    {        
        public int Id { get; set; }
      
        public string Name { get; set; }
   
        public string Content { get; set; }

        public bool status { get; set; }
    }
}