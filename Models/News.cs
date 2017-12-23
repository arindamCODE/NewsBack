using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class News
    {
        public int ID { get; set; }

        [Required]
        public string Source { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string URL { get; set; }

        [Required]
        public string URLtoImage { get; set; }
    }
}