using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TYBearQuiz.Database_files
{
    public class Beanie
    {
        [Key]
        public string Name { get; set; }
        public string Variety { get; set; }
        public string Animal { get; set; }
        public string Color { get; set; }
        public string Sport { get; set; }
        [Column("Exclusive To")]
        public string Country { get; set; }
        [Column("Image Url")]
        public string Image { get; set; }

    }
}
