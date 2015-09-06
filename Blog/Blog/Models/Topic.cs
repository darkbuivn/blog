using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Blog.Models
{
    [Table("Topic")]
    public class Topic
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("ShortDesc")]
        public string ShortDesc { get; set; }

        [Column("Content")]
        public string Content { get; set; }

        [Column("Image")]
        public string Image { get; set; }

        [Column("CategoryId")]       
        public int CategoryId { get; set; }

        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}