using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    // HomePage sınıfı, "Ana Sayfa" bilgilerini temsil eder.
    public class HomePage
    {
        [Key]
        public int ParagraphID { get; set; }
        public string? ParagraphTitle { get; set; }
        public string? ParagraphContent { get; set; }
        public bool ParagraphStatus { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
