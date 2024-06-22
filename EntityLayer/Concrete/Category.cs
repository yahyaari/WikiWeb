using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    // Category sınıfı, "Kategori" bilgilerini temsil eder.
    public class Category
    {

        // Kategorinin benzersiz kimliği.
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        public List<HomePage> Paragraphs { get; set; }
    }
}
