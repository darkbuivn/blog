using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Blog.Models
{
    [Table("Category")]
    public class Category
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [Column("Name")]    
        public string Name { get; set; }

        public virtual IEnumerable<Topic> Topics { get; set; }
    }
}