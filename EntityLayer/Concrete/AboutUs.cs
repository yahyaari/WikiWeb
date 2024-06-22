using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    // AboutUs sınıfı, "Hakkımızda" bilgilerini temsil eder.
    public class AboutUs
	{
        // Hakkımızda bilgisinin benzersiz kimliği.
        public int AboutUsId { get; set; }
        public string? AboutUsContent { get; set; }
        public string? AboutUsDanısman { get; set; }
        public string? AboutUsUniversite { get; set; }
        public string? AboutUsFakulteBolum { get; set; }
        public string? AboutUsIsım { get; set; }
        public string? AboutUsNumara { get; set; }
        
    }
}
