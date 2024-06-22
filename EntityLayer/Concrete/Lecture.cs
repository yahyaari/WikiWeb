using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    // Lecture sınıfı, "Konu Anlatımı Sayfası" bilgilerini temsil eder.
    public class Lecture
	{
		public int LectureId { get; set; }
		public string? LectureContent { get; set; }
	}
}
