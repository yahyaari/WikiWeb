using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    // Context sınıfı, veritabanı bağlantısını sağlar ve veritabanı işlemlerini yönetir.
    public class Context : DbContext
    {
        // Veritabanı bağlantı ayarlarının yapılandırılması.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Veritabanı bağlantısı için SQL Server kullanılacak şekilde yapılandırma.
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=CoreTezDb; integrated security=true;");
        }

        // Kategoriler tablosunu temsil eden DbSet.
        public DbSet<Category> Categories { get; set; }

        // Ana sayfa paragraflarını temsil eden DbSet.

        public DbSet<HomePage> Paragraphs { get; set; }

        // Hakkımızda bilgisi tablosunu temsil eden DbSet.
        public DbSet<AboutUs> AboutUs { get; set; }

        // Konu Anlatımı tablosunu temsil eden DbSet.
        public DbSet<Lecture> Lectures { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasData(
                      new Category() { CategoryID = 100, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 101, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 102, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 103, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 104, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 105, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 106, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 107, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 108, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 109, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 110, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 111, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 112, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 113, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 114, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 115, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 116, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 117, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 118, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 119, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 120, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 121, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 122, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 123, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 124, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 125, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 126, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 127, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 128, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 129, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 130, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 131, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 132, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 133, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 134, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true },
                      new Category() { CategoryID = 135, CategoryName = "Paragraph", CategoryDescription = "İçerik", CategoryStatus = true }
                      
                      
                     
                      

                );

            modelBuilder.Entity<HomePage>()
               .HasData(
                     new HomePage() 
                     {   CategoryID = 100,
                         ParagraphID = 100, 
                         ParagraphTitle = "Temelde üç tür homomorfik şifreleme vardır:",
                         ParagraphContent = "Toplama homomorfizmi (fully homomorphic encryption, FHE), çıkarma homomorfizmi (partially homomorphic encryption, PHE),\r\n\t\t\t\tve çarpma homomorfizmi (somewhat homomorphic encryption).", 
                         ParagraphStatus = true 
                     },

                     new HomePage() 
                     {   CategoryID = 101, 
                         ParagraphID = 101, 
                         ParagraphTitle = "1. Tam Homomorfik Şifreleme (Fully Homomorphic Encryption - FHE):", 
                         ParagraphContent = "Şifreli veriler üzerinde herhangi bir hesaplama yapabilme yeteneğine sahip olmayı ifade eder. Yani, şifrelenmiş veriler üzerinde toplama, çarpma gibi matematiksel işlemleri gerçekleştirebilirsiniz ve sonuçlar yine şifreli olarak kalır. FHE, homomorfik şifrelemenin en güçlü ve kapsamlı türüdür.\r\n\r\nBu, veri gizliliğini korurken bulut bilişim gibi ortamlarda hesaplama yapma veya hassas verileri paylaşma gibi durumlarda oldukça yararlıdır. Örneğin, bir bulut hizmeti sağlayıcısına verilerinizi şifreli olarak gönderebilir ve bu veriler üzerinde hesaplamalar yapabilirsiniz. Hizmet sağlayıcısı sonuçları size şifreli olarak geri gönderecektir ve siz sadece sonuçları çözümleyebileceksiniz, verinin içeriğine erişemezler.\r\n\r\nFHE'nin gücü ve kullanım alanları oldukça geniştir, ancak matematiksel olarak oldukça karmaşık ve hesaplama yoğun bir teknolojidir. Bu nedenle, pratik uygulamaları genellikle dikkatlice planlanır ve optimize edilir.", 
                         ParagraphStatus = true 
                     },

					 new HomePage()
					  {
						  CategoryID = 102,
						  ParagraphID = 102,
						  ParagraphTitle = "2. Kısmi Homomorfik Şifreleme (Partially Homomorphic Encryption - PHE):",
						  ParagraphContent = "Şifreli veriler üzerinde sınırlı bir şekilde matematiksel işlemler yapabilme yeteneğine sahiptir. Yani, şifrelenmiş veriler üzerinde belirli matematiksel işlemleri gerçekleştirebilirsiniz, ancak tüm işlemleri yapamazsınız.\r\n\r\nGenellikle, kısmen homomorfik şifrelemelerde sınırlı işlem türleri vardır. Örneğin, toplama veya çarpma gibi tek bir işlemi gerçekleştirebilirler, ancak her ikisini birden yapamazlar. Bu tür şifreleme çözümleri, belirli kullanım durumları için yeterli olabilir, ancak tam homomorfik şifreleme kadar geniş bir işlem yelpazesine sahip değildirler.\r\n\r\nKısmen homomorfik şifreleme, özellikle veri gizliliğinin korunması gereken uygulamalarda kullanışlı olabilir. Örneğin, verileri güvenli bir şekilde işlemek için bulut bilişim ortamlarında veya veri paylaşımı senaryolarında kullanılabilirler.",
						  ParagraphStatus = true
					  },

					 new HomePage()
					  {
						  CategoryID = 103,
						  ParagraphID = 103,
						  ParagraphTitle = "3. Biraz Homomorfik Şifreleme (Somewhat Homomorphic Encryption - SHE):",
						  ParagraphContent = "Şifrelenmiş veriler üzerinde sınırlı bir şekilde matematiksel işlemler yapabilme yeteneğine sahiptir. Yani, şifreli veriler üzerinde birkaç matematiksel işlem gerçekleştirebilirsiniz, ancak tam homomorfik şifreleme kadar kapsamlı değildir.\r\n\r\nGenellikle, biraz homomorfik şifreleme çözümleri, toplama ve çarpma gibi belirli işlemleri gerçekleştirebilir, ancak sınırlı sayıda işlem yapılabilmektedir. Örneğin, verileri şifreli olarak bulutta saklamak ve bulutta hesaplamalar yapmak için kullanılabilirler.\r\n\r\nSHE, tam homomorfik şifreleme kadar geniş bir işlem yelpazesine sahip olmasa da, belirli kullanım durumlarında yeterli olabilir. Özellikle, veri gizliliğinin korunması gereken uygulamalarda veya güvenli hesaplama gerektiren senaryolarda kullanışlı olabilirler.",
						  ParagraphStatus = true
					  },

					 new HomePage()
					   {
						   CategoryID = 104,
						   ParagraphID = 104,
						   ParagraphTitle = "Homomorfik Wiki",
						   ParagraphContent = "Homomorfik şifreleme, gizliliğin korunması ve güvenli veri işleme konularında önemli bir rol oynar.\r\n\t\t\t\tÖzellikle bulut bilişim ve veri paylaşımı gibi alanlarda, verilerin şifrelenmiş hali üzerinde işlemler yapılabilmesi,\r\n\t\t\t\them gizliliği hem de güvenliği artırabilir. Ancak, homomorfik şifreleme yöntemleri genellikle daha karmaşık ve hesaplama maliyeti yüksek olduğu için,\r\n\t\t\t\tpratik uygulamalarda dikkatlice değerlendirilmelidir.",
						   ParagraphStatus = true
					   },

					 new HomePage()
						{
							CategoryID = 105,
							ParagraphID = 105,
							ParagraphTitle = "Homomorfik Wiki Açıklama",
							ParagraphContent = "Homomorfik şifreleme, şifrelenmiş veriler üzerinde işlem yapmayı mümkün kılan bir şifreleme yöntemidir. Bu yöntem sayesinde, veriler şifrelenmiş haldeyken bile matematiksel işlemler uygulanabilir ve sonuçlar şifrelenmiş olarak kalır. Bu, verilerin gizliliğini koruyarak, dış kaynaklı hesaplama ve depolamaya olanak tanır.",
							ParagraphStatus = true
						},

				     new HomePage()
						 {
							 CategoryID = 106,
							 ParagraphID = 106,
							 ParagraphTitle = "Homomorfik Wiki Açıklama",
							 ParagraphContent = "Özellikle sağlık sektöründe, homomorfik şifreleme, hassas tıbbi verilerin güvenli bir şekilde işlenmesini sağlar. Bu sayede, sağlık hizmetleri, gizlilik endişelerini azaltarak, veri analitiği ve tahmine dayalı analiz gibi önemli hizmetleri daha etkin bir şekilde kullanabilirler.",
							 ParagraphStatus = true
						 },

					 new HomePage()
						  {
							  CategoryID = 107,
							  ParagraphID = 107,
							  ParagraphTitle = "Homomorfik Wiki Açıklama",
							  ParagraphContent = "Homomorfik şifreleme, şifrelenmiş veriler üzerinde farklı hesaplama sınıfları gerçekleştirebilen birden fazla şifreleme şeması türünü içerir.\r\n\t\t\t\tHesaplamalar Boolean veya aritmetik devreler olarak temsil edilir. Bazı yaygın homomorfik şifreleme türleri kısmen homomorfik,\r\n\t\t\t\tbiraz homomorfik, seviyeli tamamen homomorfik ve tamamen homomorfik şifrelemedir:",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 108,
							  ParagraphID = 108,
							  ParagraphTitle = "Homomorfik Wiki Açıklama",
							  ParagraphContent = "Kısmen homomorfik şifreleme, örneğin toplama veya çarpma gibi yalnızca tek tip kapıdan oluşan devrelerin\r\n\t\t\t\t\tdeğerlendirilmesini destekleyen şemaları kapsar.",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 109,
							  ParagraphID = 109,
							  ParagraphTitle = "Homomorfik Wiki Açıklama",
							  ParagraphContent = "Bir dereceye kadar homomorfik şifreleme şemaları, iki tür kapıyı değerlendirebilir,\r\n\t\t\t\t\tancak yalnızca devrelerin bir alt kümesi için.\r\n\t\t\t\t\tSeviyelendirilmiş tamamen homomorfik şifreleme, sınırlı (önceden belirlenmiş) derinliğe sahip\r\n\t\t\t\t\tbirden fazla kapı türünden oluşan rastgele devrelerin değerlendirilmesini destekler.",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 110,
							  ParagraphID = 110,
							  ParagraphTitle = "Homomorfik Wiki Açıklama",
							  ParagraphContent = "Tamamen homomorfik şifreleme (FHE), sınırsız derinlikte birden fazla kapı türünden oluşan rastgele\r\n\t\t\t\t\tdevrelerin değerlendirilmesine olanak tanır ve homomorfik şifrelemenin en güçlü kavramıdır.",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 111,
							  ParagraphID = 111,
							  ParagraphTitle = "Homomorfik Wiki Açıklama",
							  ParagraphContent = "Homomorfik şifreleme şemalarının çoğunluğu için, devrelerin çarpımsal derinliği,\r\n\t\t\t\tşifrelenmiş veriler üzerinde hesaplamaların gerçekleştirilmesindeki temel pratik sınırlamadır.\r\n\t\t\t\tHomomorfik şifreleme şemaları doğası gereği şekillendirilebilir . İşlenebilirlik açısından, homomorfik şifreleme şemaları,\r\n\t\t\t\thomomorfik olmayan şemalara göre daha zayıf güvenlik özelliklerine sahiptir.",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 112,
							  ParagraphID = 112,
							  ParagraphTitle = "Homomorfik Wiki Açıklama",
							  ParagraphContent = "\"Homomorfik şifreleme, verilerin gizliliğini koruyarak aynı zamanda şifreli biçimde işlenmelerine olanak tanıyan bir kriptografik ilerlemedir, bu da güvenli veri analizi ve işleme için önemli bir çığır açmaktadır.\"",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 113,
							  ParagraphID = 113,
							  ParagraphTitle = "Tarihçe",
							  ParagraphContent = "Homomorfik şifreleme kavramı, modern kriptografi araştırmalarının bir sonucu olarak ortaya çıkmıştır. İlk homomorfik şifreleme protokolü, 1978 yılında Ron Rivest, Adi Shamir ve Leonard Adleman (RSA olarak da bilinir) tarafından geliştirilen RSA şifrelemesinden birkaç yıl sonra ortaya çıktı.\r\n\r\n\t\t\t\tAncak, tam homomorfik şifreleme protokolü ilk kez 2009 yılında Craig Gentry tarafından tanıtıldı. Gentry'nin çalışması, matematiksel olarak karmaşık bir yapı kullanarak, şifreli veriler üzerinde toplama ve çarpma işlemlerini gerçekleştirebilecek bir protokol sunuyordu. Bu, veri gizliliği açısından devrim niteliğinde bir adımdı, çünkü daha önce, şifreli veriler üzerinde işlem yapmak, genellikle verinin şifresini çözmeyi gerektirirdi.",
							  ParagraphStatus = true
						  },

				     new HomePage()
						  {
							  CategoryID = 114,
							  ParagraphID = 114,
							  ParagraphTitle = "Tarihçe",
							  ParagraphContent = "Gentry'nin çalışması, homomorfik şifrelemenin potansiyelini gösterdi, ancak pratikte kullanılabilirliği sınırlıydı çünkü hesaplama maliyeti oldukça yüksekti. Ancak, daha sonraki yıllarda, araştırmacılar homomorfik şifreleme protokollerini iyileştirmek ve daha etkili hale getirmek için çeşitli yaklaşımlar geliştirdiler.\r\n\r\n\t\t\t\t2013 yılında, Gentry ve Zvika Brakerski, daha etkili ve kullanılabilir bir kısmi homomorfik şifreleme protokolü tanıttılar. Bu protokol, işlemlerin sayısını ve hesaplama maliyetini azaltarak daha pratik bir kullanım sağladı.",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 115,
							  ParagraphID = 115,
							  ParagraphTitle = "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)",
							  ParagraphContent = "Tamamen homomorfik bir şifreleme şeması oluşturma sorunu ilk olarak 1978'de, RSA şemasının yayınlanmasından sonraki bir yıl içinde önerildi. 30 yılı aşkın süredir bir çözümün var olup olmadığı belirsizdi. Bu dönemde kısmi sonuçlar aşağıdaki şemaları içeriyordu:",
							  ParagraphStatus = true
						  },

				     new HomePage()
						  {
							  CategoryID = 116,
							  ParagraphID = 116,
							  ParagraphTitle = "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)",
							  ParagraphContent = "RSA şifreleme sistemi (sınırsız sayıda modüler çarpma)",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 117,
							  ParagraphID = 117,
							  ParagraphTitle = "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)",
							  ParagraphContent = "ElGamal şifreleme sistemi (sınırsız sayıda modüler çarpma)",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 118,
							  ParagraphID = 118,
							  ParagraphTitle = "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)",
							  ParagraphContent = "Boneh – Goh – Nissim kripto sistemi (sınırsız sayıda toplama işlemi ancak en fazla bir çarpma)",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 119,
							  ParagraphID = 119,
							  ParagraphTitle = "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)",
							  ParagraphContent = "Goldwasser – Micali şifreleme sistemi (sınırsız sayıda özel veya işlem)",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 120,
							  ParagraphID = 120,
							  ParagraphTitle = "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)",
							  ParagraphContent = "Sander-Young-Yung sistemi (20 yıldan fazla bir süre sonra logaritmik derinlik devreleri sorununu çözdü)",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 121,
							  ParagraphID = 121,
							  ParagraphTitle = "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)",
							  ParagraphContent = "Benaloh şifreleme sistemi (sınırsız sayıda modüler ekleme)",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 122,
							  ParagraphID = 122,
							  ParagraphTitle = "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)",
							  ParagraphContent = "Ishai-Paskin şifreleme sistemi (polinom boyutunda dallanma programları)",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 123,
							  ParagraphID = 123,
							  ParagraphTitle = "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)",
							  ParagraphContent = "Paillier şifreleme sistemi (sınırsız sayıda modüler ekleme)",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 124,
							  ParagraphID = 124,
							  ParagraphTitle = "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)",
							  ParagraphContent = "Homomorfik şifreleme alanı hala aktif olarak araştırılmaktadır ve gelecekte daha gelişmiş ve etkili protokollerin ortaya çıkması muhtemeldir. Bu teknolojinin, gizlilik odaklı uygulamalarda ve bulut bilişim gibi alanlarda daha yaygın olarak kullanılması beklenmektedir.",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 125,
							  ParagraphID = 125,
							  ParagraphTitle = "blockquote",
							  ParagraphContent = "\"Homomorfik, cebirdeki homomorfizmi ifade eder : şifreleme ve şifre çözme fonksiyonları, düz metin ve şifreli metin uzayları arasındaki homomorfizmler olarak düşünülebilir.\"",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 126,
							  ParagraphID = 126,
							  ParagraphTitle = "Homomorfik şifreleme ile neler yapılabilir?",
							  ParagraphContent = "Homomorfik şifreleme, şifreli veriler üzerinde matematiksel işlemler yapmayı mümkün kılan bir kriptografik tekniktir. Bu teknik, çeşitli kullanım senaryolarında çeşitli avantajlar sağlar. İşte homomorfik şifreleme ile yapılabilecek bazı şeyler:",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 127,
							  ParagraphID = 127,
							  ParagraphTitle = "Koruma:",
							  ParagraphContent = "Veritabanları veya bulut tabanlı hizmetlerdeki hassas veriler, homomorfik şifreleme ile şifrelenerek işlenebilir.\r\n\t\t\t\t\tÖrneğin, bir bulut hizmet sağlayıcısı, şifreli veriler üzerinde hesaplamalar yapabilir ve sonuçları müşterilere geri gönderebilir,\r\n\t\t\t\t\tancak verilerin içeriğine erişim sağlayamaz.",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 128,
							  ParagraphID = 128,
							  ParagraphTitle = "Gizlilik Korunarak Hesaplama Yapma:",
							  ParagraphContent = "Homomorfik şifreleme, verilerin gizliliğini korurken bulutta güvenli hesaplamalar yapmayı mümkün kılar. Bu, kişisel veya hassas verilerin güvenli bir şekilde işlenmesini sağlar.",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 129,
							  ParagraphID = 129,
							  ParagraphTitle = "Sağlık Sektörü:",
							  ParagraphContent = "Hastane kayıtları gibi özel sağlık verileri, homomorfik şifreleme kullanılarak güvenli bir şekilde işlenebilir. Bu sayede, sağlık hizmeti sağlayıcıları,\r\n\t\t\t\t\thastaların verileri üzerinde analizler yapabilirken verilerin gizliliği korunmuş olur.",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 130,
							  ParagraphID = 130,
							  ParagraphTitle = "Veri Analitiği ve Veri Madenciliği:",
							  ParagraphContent = "Homomorfik şifreleme, şifreli veriler üzerinde analiz ve madencilik yapılmasını mümkün kılar. Örneğin, bir bulutta depolanan ve homomorfik olarak şifrelenmiş sağlık verileri üzerinde analiz yapılabilir, ancak verilerin gizliliği korunur.",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 131,
							  ParagraphID = 131,
							  ParagraphTitle = "Outsourcing ve Veri Depolama:",
							  ParagraphContent = "Homomorfik şifreleme, verilerin dış kaynaklara güvenli bir şekilde aktarılmasını sağlar. Bu, hassas verilerin bulut ortamlarında depolanmasını veya üçüncü taraf hizmet sağlayıcılarına aktarılmasını mümkün kılar.",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 132,
							  ParagraphID = 132,
							  ParagraphTitle = "Güvenli Veri Paylaşımı:",
							  ParagraphContent = "Homomorfik şifreleme, verilerin güvenli bir şekilde paylaşılmasını sağlar. Örneğin, farklı kurumlar veya kullanıcılar arasında hassas verilerin paylaşılması gerektiğinde, bu veriler homomorfik olarak şifrelenebilir ve güvenli bir şekilde paylaşılabilir.",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 133,
							  ParagraphID = 133,
							  ParagraphTitle = "Veri Analizine Katılımı Teşvik Etmek:",
							  ParagraphContent = "Homomorfik şifreleme, veri sahiplerinin verilerini paylaşma konusundaki endişelerini azaltır. Bu, veri analizine katılımı teşvik eder ve daha geniş veri setlerinin kullanılmasını sağlar.",
							  ParagraphStatus = true
						  },

					 new HomePage()
						  {
							  CategoryID = 134,
							  ParagraphID = 134,
							  ParagraphTitle = "Finansal Hizmetler:",
							  ParagraphContent = "Finansal veriler, müşteri bilgileri veya finansal işlemler, homomorfik şifreleme ile güvence altına alınabilir. Bu sayede, finansal analizler yapılabilirken müşteri gizliliği korunabilir.",
							  ParagraphStatus = true
						  },

                     new HomePage()
                          {
                              CategoryID = 135,
                              ParagraphID = 135,
                              ParagraphTitle = "Açıklama",
                              ParagraphContent = "Homomorfik şifreleme, veri işleme ihtiyacını ortadan kaldırarak, verilerin güvenliğini artırır. Böylelikle, verilerin güvenliği için endişe duyan kurumlar ve kullanıcılar, verilerini şifreleyerek dış kaynaklara güvenle aktarabilirler.",
                              ParagraphStatus = true
                          }

						 );

			modelBuilder.Entity<AboutUs>()
				.HasData(
					  new AboutUs() 
					  { 
						  AboutUsId=1, 
						  AboutUsContent = "Homomorfik Şifreleme'nin Anlatıldığı Wiki Web Sayfası",
						  AboutUsDanısman = "Dr. Öğr. Üyesi Ahmet ALBAYRAK",
						  AboutUsUniversite = "Düzce Üniversitesi",
						  AboutUsFakulteBolum = "Teknoloji Fakültesi Bilgisayar Mühendisliği",
						  AboutUsIsım = "Ali Berdan Karasoy",
						  AboutUsNumara = "182120015",
						  
					  },

					  new AboutUs()
					  {
						  AboutUsId = 2,
						  AboutUsContent = "Homomorfik Şifreleme'nin Anlatıldığı Wiki Web Sayfası",
						  AboutUsDanısman = "Dr. Öğr. Üyesi Ahmet ALBAYRAK",
						  AboutUsUniversite = "Düzce Üniversitesi",
						  AboutUsFakulteBolum = "Teknoloji Fakültesi Bilgisayar Mühendisliği",
						  AboutUsIsım = "Yahya Arı",
						  AboutUsNumara = "182120004",

					  }



				);
			
            modelBuilder.Entity<Lecture>()
				.HasData(
					  new Lecture()
					  {
						  LectureId = 1,
						  LectureContent = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",  
					  },

					  new Lecture()
					  {
						  LectureId = 2,

						  LectureContent = "Homomorfik şifreleme, şifrelenmiş veriler üzerinde önce şifresini çözmeden hesaplamalar yapmaya izin veren bir şifreleme şeklidir. Hesaplamanın sonucu şifrelenmiş bir formdadır, şifresi çözüldüğünde çıktı, şifrelenmemiş veriler üzerinde işlemlerin gerçekleştirilmiş hali ile aynıdır. Homomorfik şifreleme, dış kaynaklı depolama, hesaplama ve gizliliği korumak için kullanılabilir. Bu verilerin şifrelenmiş haldeyken işlenmesi için ticari bulut ortamlarına şifrelenmesine ve dışarıdan kaynaklanmasına olanak tanır. Yüksek düzeyli olan endüstrilerde homomorfik şifreleme, veri paylaşımını engelleyen gizlilik engellerini kaldırarak yeni hizmetleri etkinleştirmek için kullanılabilir.\r\n",
						  
					  },

						  new Lecture()
						  {
							  LectureId = 3,

							  LectureContent = "Homomorfik şifreleme, şifreli metinlerde hesaplama yapılmasına olanak sağlayan ve şifresi çözüldüğünde düz metin üzerinde yapılmış gibi işlemlerin sonucuyla eşleşen şifreli bir sonuç üreten bir şifreleme yöntemidir. Bu teknolojiyle, bilgi işlem gücü isteyen kullanıcılar artık bulut sunucuya düz metin açamayacak ve bu da veri sızıntısını etkili bir şekilde önleyebilecektir.\r\n",
							 
						  },

						  new Lecture()
						  {
							  LectureId = 4,

							  LectureContent = "Homomorfik şifreleme, gizli anahtara erişim olmadan şifrelenmiş veriler üzerinde hesaplama yapmak için ek bir değerlendirme özelliğine sahip bir şifreleme biçimidir. Böyle bir hesaplamanın sonucu şifrelenmiş olarak kalır. Homomorfik şifreleme, simetrik anahtar veya açık anahtar şifrelemesinin bir uzantısı olarak görülebilir. Homomorfik, cebirdeki homomorfizmi ifade eder: şifreleme ve şifre çözme fonksiyonları, düz metin ve şifreli metin uzayları arasındaki homomorfizmler olarak düşünülebilir.\r\n",
							  
						  },

						  new Lecture()
						  {
							  LectureId = 5,

							  LectureContent = "Homomorfik şifreleme, şifrelenmiş veriler üzerinde farklı hesaplama sınıfları gerçekleştirebilen çok sayıda şifreleme şeması içerir. Bazı homomorfik şifreleme çeşitleri;\r\n",
							  
						  },

						  new Lecture()
						  {
							  LectureId = 6,
							 
							  LectureContent = "Derin öğrenme için en kullanışlı şifreleme türüdür. Herhangi bir sayıda toplama ve çarpma işlemine izin verir.",
							  
						  },

						  new Lecture()
						  {
							  LectureId = 7,
							  LectureContent = "Toplama ve çarpma gibi işlemlere izin verir, fakat gerçekleştirilebilecek işlem sayısı açısından sınırlıdır.",
						  },

						  new Lecture()
						  {
							  LectureId = 8,
							  LectureContent = "Toplama ve çarpma gibi işlemlere izin verir. Sınırsız işlem yapılabilir.",
						  },

						  new Lecture()
						  {
							  LectureId = 9,
							  LectureContent = "Şifreleme işlemi bir bilgiyi bir yerden bir yere güvenli bir biçimde\r\n\t\t\t\taktaralılmasını sağlamanın yanında bilginin güvenli bir şekilde saklanmasınıda\r\n\t\t\t\tsağlamaktadır. Bilgi saklama, bilgiyi göndermede olduğu gibi bilginin bir anahtar ile\r\n\t\t\t\tşifrelenmesi ve bir alanda saklanması şeklinde gerçekleşir. Anahtara sahip kullanıcılar\r\n\t\t\t\tveya günümüzde çok fazla kullanımı olan bulut hizmetlerinide kapsayan servis\r\n\t\t\t\tsağlayıcıları bilgiler üzerinde özel haklara sahiptir. Anahtarın doğrudan bir paylaşımı\r\n\t\t\t\tolmasa bile, bilgi, üçüncü bir taraf ile yapılması gereken bir işlem için paylaşılması\r\n\t\t\t\tgerekebilir. Tam bu noktada bilginin güvenliğine karşı bir zafiyet oluşmaktadır.\r\n\t\t\t\tHomomorfik Şifreleme, bilgi üzerinde yapılmak istenilen matematiksel işlemi\r\n\t\t\t\tşifrelenmiş metin üzerinde yapılmasını olanak sağlayan bir kriptografik yöntemdir. Bu\r\n\t\t\t\tsayede, bilgiler üzerinde işlemler güvenli bir şekilde yapılabilir.\r\n\t\t\t\tBilgiyi bozmadan, şifrelenmiş veriler üzerinde basit işlemlerin yapılabilmesi\r\n\t\t\t\tdüşüncesi ilk olarak 1978 yılında Rivest, Adleman ve Derouzous tarafından ortaya\r\n\t\t\t\tatılmıştır. 1978’den bu yana bu konu önem kazanmış ve bu konuda sayısız çalışma\r\n\t\t\t\tyapılmıştır.",
						  },

						  new Lecture()
						  {
							  LectureId = 10,
							  LectureContent = "2009 yılına kadar RSA, ElGamal ve Pailler algoritmaları gibi birçok algoritmada\r\n\t\t\t\tuygulanmış, fakat sadece tek bir işlem tipi yapılabilmesine olanak sağlamıştır. 2009\r\n\t\t\t\tyılında Craig Gentry şifreli veriler üzerinde birden fazla işlem yapabilme yani TamHomomorfik Şifreleme fikrini yayınlaması ile bu konu tekrardan önem kazanmıştır.\r\n\t\t\t\tBunun büyük bir başarı olmasına karşın,bu konunun iyileştirilmesi, uygulanması ve var\r\n\t\t\t\tolan uygulamalar ile uyumlu hale getirilmesi gerektiği gösterilmiştir",
						  },

						  new Lecture()
						  {
							  LectureId = 11,
							 
							  LectureContent = "Şifreleme bilgilerin güvenliğini sağlamak için çok önemlidir. Fakat geleneksel\r\n\t\t\t\tşifreleme yöntemleri bilgiler üzerinde yapılacak işlemleri, şifre çözmeden\r\n\t\t\t\tgerçekleştiremez. Bunun yanı sıra, günümüzde yaygın olarak kullanılan bulut sistemleri\r\n\t\t\t\tile bilgilerin depolanması ve paylaşılması gizliliğimizden ödün vermemizi\r\n\t\t\t\tgerektirmektedir. Bilgilerin hem rahatça paylaşılması hem de güvenliğinin sağlanması\r\n\t\t\t\tiçin şifrelenmiş bilgiler üzerinde işlemlerin yapılabilmesine olanak sağlayacak bir\r\n\t\t\t\tyapının olması gerekmektedir.\r\n\t\t\t\tÖzet olarak bu yapının gereksinimlerini şöyle sıralayabiliriz;",
							 
						  },

						  new Lecture()
						  {
							  LectureId = 12,
							  LectureContent = "Açık metin üzerinde değil şifrelenmiş metin üzerinde matematiksel işlemler\r\n\t\t\t\t\tyapılmalıdır.",
						  },

						  new Lecture()
						  {
							  LectureId = 13,
							  LectureContent = "Şifreli metnin şifresi çözüldüğünde elde edilen sonuç, aynı işlemlerin açık\r\n\t\t\t\t\tmetin üzerinde yapılması ile elde edilecek sonuç ile aynı olmalıdır.",
						  },

						  new Lecture()
						  {
							  LectureId = 14,
							  LectureContent = "Bu gereksinimleri sağlayan yapılara Homomorfik Şifreleme yapıları\r\n\t\t\t\tdenilmektedir.",
						  },
						  new Lecture()
						  {
							  LectureId = 15,
							  LectureContent = "Örnek olarak, A kişisi 1’e 2'yi eklemek istiyor fakat sayıların nasıl ekleneceğini bilmiyor.\r\n\t\t\t\t\t\tA bu problemi çözmek için başka birinden yani B kişisinden yardım almak istiyor.\r\n\t\t\t\t\t\tFakat A kişisi elinde bulunan 1 ve 2’yi güvenlik nedeni ile herhangi biri ile paylaşmakta\r\n\t\t\t\t\t\tistemiyor. Bundan dolayı A kişisi yardım almak istediği B kişisine aynı zaman\r\n\t\t\t\t\t\tgüvenmemektedir. A kişisi hem 1’e 2’yi eklemek için B kişisinden yardım alıp hem de\r\n\t\t\t\t\t\tB kişisine hangi sayıları eklemek istedi bilgisini vermeden bu işlemi gerçekleştirmek\r\n\t\t\t\t\t\tiçin önce elindeki sayıları (1,2) şifreleme işlemi gerçekleştirerek yeni sayılar elde eder.\r\n\t\t\t\t\t\tŞifreleme(1) = 33, Şifreleme(2) = 54. A kişisi elde ettiği bu sayıları ve yapmak istediği\r\n\t\t\t\t\t\ttoplama işlemini (f) B kişisine gönderir. B kişisi sadece şifrelenmiş olan 33 ve 54\r\n\t\t\t\t\t\tsayılarını bilmektedir. B kişisi bu sayıları toplar 33 + 54 = 87 ve sonucu A kişisine geri\r\n\t\t\t\t\t\tgönderir. A kişisi gelen cevabı şifre çözme işlemi gerçekleştirerek Şifre çözme (87) = 3\r\n\t\t\t\t\t\tcevabına ulaşmış olur.\r\n\t\t\t\t\t\tYani HE, şifreli metin üzerinde işlem gerçekleştirebileceğiniz ve\r\n\t\t\t\t\t\tbu sonucun şifresi çözüldüğü\r\n\t\t\t\t\t\tile aynı olacaktır.",
						  },
						  new Lecture()
						  {
							  LectureId = 16,
							  LectureContent = "Yani HE(Homomorphic Encryption),şifreli metin üzerinde işlem gerçekleştirebileceğiniz ve elde edeceğiniz\r\n\t\t\t\tbu sonucun şifresi çözüldüğü zaman, açık metin ile bu işlemi gerçekleştirdiğiniz sonuç ile aynı olucaktır.",
						  },
						  new Lecture()
						  {
							  LectureId = 17,
							  LectureContent = "Bu sayede bilgilerin gizliliği sürdürülerek güvenli bir şekilde bilgiler üzerinde\r\n\t\t\t\tmatematiksel işlemler yapılabilmektedir.",
						  },
						  new Lecture()
						  {
							  LectureId = 18,
							  LectureContent = "Kısmi homomorfik şifreleme, belirli matematiksel işlemleri gerçekleştirmek için \r\n\t\t\t\tkullanılan bir şifreleme tekniğidir. Tam homomorfik şifreleme gibi, kısmi homomorfik \r\n\t\t\t\tşifreleme de verileri şifreli olarak saklayıp işlem yapmayı mümkün kılar. Ancak, tam homomorfik\r\n\t\t\t\tşifrelemeden farklı olarak, kısmi homomorfik şifreleme sadece belirli işlemler için \r\n\t\t\t\tkullanılabilir.Kısmi-Homomorfik Şifreleme yönteminde ya çarpma işlemi ya da toplama\r\n\t\t\t\tişlemi olmak üzere sadece bir tek işlem gerçekleştirebilir. RSA, ElGamal ve Paillier\r\n\t\t\t\tKısmi-Homomorfik Şifreleme özelliği göstermektedir.",
						  },
						  new Lecture()
						  {
							  LectureId = 19,
							  LectureContent = "Bu tür, şifreli veriler arasında çarpma işlemi yapılmasına \r\n\t\t\t\t\t\tolanak tanır. Ancak, şifreli veriler üzerinde sadece çarpma\r\n\t\t\t\t\t\tişlemi yapılabilir, toplama işlemi yapılamaz.",
						  },
						  new Lecture()
						  {
							  LectureId = 20,
							  LectureContent = "Bu tür, şifreli veriler arasında toplama işlemi yapılmasına olanak tanır.\r\n\t\t\t\t\t\tŞifreli veriler üzerinde sadece toplama işlemi yapılabilir, çarpma işlemi yapılamaz.",
						  },
						  new Lecture()
						  {
							  LectureId = 21,
							  LectureContent = "Kısmi homomorfik şifreleme, özellikle bulut bilişim ve veri güvenliği gibi alanlarda \r\n\t\t\t\tkullanışlıdır. Örneğin, veri analizi veya hesaplama yaparken, hassas verilerin gizliliğini \r\n\t\t\t\tkoruyarak işlem yapılmasını sağlar. Ancak, tam homomorfik şifreleme kadar geniş bir \r\n\t\t\t\tkullanım alanına sahip olmayabilir, çünkü yalnızca belirli işlemleri gerçekleştirmek için kullanılabilir.",
						  },
						  new Lecture()
						  {
							  LectureId = 22,
							  LectureContent = "RSA algoritması bilinen ilk Homomorfik Şifreleme yöntemlerinden biridir.\r\n\t\t\t\tÇarpmaya göre Kısmi-Homomorfik Şifreleme özelliği gösterir. 𝑚1 1.\r\n\t\t\t\taçık metin, 𝑚2 2. açık metin, 𝑛 mod değeri, 𝑦 açık anahtar olsun. RSA algoritmasının\r\n\t\t\t\tçarpmaya göre Kısmi-Homomorfik Şifreleme özelliğini aşağıdaki gibi gösterilebilir;",
						  },
						  new Lecture()
						  {
							  LectureId = 23,
							  LectureContent = "Görüldüğü gibi iki açık metinin şifrelenmiş olarak çarpımı açık metin\r\n\t\t\t\tolarak çarpımının şifrelenmiş haline eşittir.",
						  },
						  new Lecture()
						  {
							  LectureId = 24,
							  LectureContent = "ElGamal algoritması toplamaya göre Homomorfik Şifreleme özelliği\r\n\t\t\t\tgöstermektedir. 𝑚1 1. açık metin, 𝑚2 2. açık metin, 𝑦 mod değeri,\r\n\t\t\t\t𝐾ortak anahtar olsun. ElGamal algoritmasının toplamaya göre Kısmi-Homomorfik\r\n\t\t\t\tŞifreleme özelliğini aşağıdaki gibi gösterilebilir;",
						  },
						  new Lecture()
						  {
							  LectureId = 25,
							  LectureContent = "Görüldüğü gibi iki açık metinin şifrelenmiş olarak toplamı açık metin\r\n\t\t\t\tolarak toplamının şifrelenmiş haline eşittir.",
						  },
						  new Lecture()
						  {
							  LectureId = 26,
							  LectureContent = "Paillier algoritması toplamaya göre Homomorfik Şifreleme özelliği\r\n\t\t\t\tgöstermektedir.Şifrelenmiş metinlerin toplamı, açık metinlerin\r\n\t\t\t\ttoplamına eşittir. 𝑚1 1. açık metin, 𝑚2 2. açık metin, 𝑛 mod değeri, 𝑔 açık anahtar, 𝑟\r\n\t\t\t\tseçilen rastgele değer olsun. Paillier algoritmasının toplamaya göre Kısmi-Homomorfik\r\n\t\t\t\tŞifreleme özelliğini aşağıdaki gibi gösterilebilir;",
						  },
						  new Lecture()
						  {
							  LectureId = 27,
							  LectureContent = "Görüldüğü gibi iki açık metinin şifrelenmiş olarak toplamı açık metin\r\n\t\t\t\tolarak  toplamının şifrelenmiş haline eşittir.",
						  },
						  new Lecture()
						  {
							  LectureId = 28,
							  LectureContent = "Tam-Homomorfik Şifreleme, şifreli veriler üzerinde yapılan işlemler tek bir\r\n\t\t\t\tişlem tipiyle sınırlı kalmadan, farklı işlem tiplerini sayısız sayıda yapmaya izin veren\r\n\t\t\t\tyapılardır. Tam-Homomorfik Şifreleme yapısı temelde halka\r\n\t\t\t\thomomorfizmi olarak düşünülebilir.",
						  },
						  new Lecture()
						  {
							  LectureId = 29,
							  LectureContent = "2009 yılında, Gentry ilk Tam-Homomorfik Şifreleme yapısını açıkladı. Bu yapı\r\n\t\t\t\tKısmi-Homomorfik ve Homomorfik Benzeri Şifrelemelerinin aksine hem toplama hem\r\n\t\t\t\tçarpma işlemlerini bir arada ve sınırsız sayıda yapmayı destekliyordu. Gentry’nin\r\n\t\t\t\tsunduğu yapı sadece bir Tam-Homomorfik Şifreleme yapısı olmasından bir yana, TamHomomorfik Şifreleme yapısı oluşturabilmek için nasıl bir yol izlenmesi gerektiğini\r\n\t\t\t\tanlatıyordu. Gentry’nin sunduğu yapıdan sonra birçok kişi yeni bir Tam-Homomorfik\r\n\t\t\t\tyapı tasarlamaya çalıştı.",
						  },
						  new Lecture()
						  {
							  LectureId = 30,
							  LectureContent = "Gentry’nin önerdiği yapı ideal kafes (ideal lattice) tabanlı bir yapıydı.\r\n\t\t\t\tGentry’nin sunduğu Tam-Homomorfik Şifreleme yapısından öncede kafes tabanlı\r\n\t\t\t\tkriptoloji üzerinde çalışmalar devam etmekteydi. Bu yapı teorik olarak çok önemli bir\r\n\t\t\t\tyeri olsa da, uygulanabilirliği konusunda hesaplama maliyeti gibi sebeplerden dolayı\r\n\t\t\t\tçok verimli değildi. Bu yapının daha verimli bir hale getirilmesi için birçok çalışma\r\n\t\t\t\tyapılmıştır.Yapılan yeni çalışmaların çoğu kafes problemlerindeki zorluğu güvenlik\r\n\t\t\t\tolarak kullanmasına dayanmaktadır.",
						  },
						  new Lecture()
						  {
							  LectureId = 31,
							  LectureContent = "Gentry, ideal kafeslere dayanan SWHE bir yapı kurarak başlamıştır. Fakat belirli\r\n\t\t\t\tbir işlem sayısından sonra elde edilen sonuçlar başarısız olmuştur. Bunun sebebi şifreli\r\n\t\t\t\tmetindeki gürültü miktarının fazla olmasından kaynaklıdır. Gentry,\r\n\t\t\t\tblue print method denilen, Önyükleme (boostrapping) ve şifre çözme devresini\r\n\t\t\t\tönyükleme yapılabilir hale getirmek için bir teknik (squashing) işlemlerini önerdi.\r\n\t\t\t\tBoostrapping ve squashing işlemleri tekrar edebilir özelliktedir. Bundan dolayı\r\n\t\t\t\toluşturulan yapı bu işlemlere sokularak sınırsız sayıda toplama ve çarpma işlemi\r\n\t\t\t\tgerçekleştirebilecektir.",
						  },
						  new Lecture()
						  {
							  LectureId = 32,
							  LectureContent = "Toplamı gizli anahtarın çarpımının tersine eşit olan bir vektör\r\n\t\t\t\tkümesi seçilir. Eğer şifreli metin bu kümenin elemanları ile çarpılırsa devrenin polinom\r\n\t\t\t\tderecesi şemanın kaldırabileceği seviyeye indirgenir. Şifreli metin artık boostrapping\r\n\t\t\t\tyapılabilir bir durumdadır.",
						  },
						  new Lecture()
						  {
							  LectureId = 33,
							  LectureContent = "Şifrelenmiş metin içerisindeki gürültüyü ortadan kaldırmak için\r\n\t\t\t\tşifreli metini yeniden şifreleme işlemidir. Squashing işlemi gerçekleştirilerek\r\n\t\t\t\tboostrapping yapılabilir bir duruma gelen şifreli metin boostrapping işlemi\r\n\t\t\t\tgerçekleştirilerek yeni şifreli metin elde edilir.",
						  },
						  new Lecture()
						  {
							  LectureId = 34,
							  LectureContent = "Yani, gürültü içeren şifreli metni şifre çözme işlemi uygulayarak gürültüyü\r\n\t\t\t\tkaldırır ve sonradan tekrar şifreleme işlemi gerçekleştiğinde küçük gürültülü bir hale\r\n\t\t\t\tgetirir. Bu işlem gürültünün eşik noktasına ulaşana kadar tekrarlanabilir. Gentry’nin\r\n\t\t\t\tsunduğu bu yapıda maliyetin çok fazla olduğu görülmektedir. Bu şekilde bir SWHE\r\n\t\t\t\tyapısı oluşturup, squashing ve boostrapping işlemleri gerçekleştirerek bir FHE yapısı\r\n\t\t\t\toluşturulabilir.",
						  },
						  new Lecture()
						  {
							  LectureId = 35,
							  LectureContent = "Biraz homomorfik şifreleme (SHE), şifrelenmiş veriler üzerinde sınırlı bir şekilde matematiksel işlemler yapabilme yeteneğine sahip bir şifreleme türüdür. Bu tür şifreleme, verilerin gizliliğini korurken işlemler yapma ihtiyacı olan çeşitli uygulamalar için önemlidir.\r\n\r\n\t\t\t\tTemel olarak, SHE şifreleme şeması, şifrelenmiş veriler üzerinde sınırlı bir homomorfik özelliğe sahiptir. Bu özellik, belirli matematiksel işlemleri gerçekleştirmenize olanak tanırken, şifrelenmiş verinin gizliliğini korur. SHE'nin en yaygın olarak kullanılan örneği, homomorfik olarak toplama işlemlerini gerçekleştirebilme yeteneğidir. Yani, iki şifreli sayıyı toplayabilir ve sonucu şifreli olarak elde edebilirsiniz.\r\n\r\n\t\t\t\tAncak, SHE'nin tam homomorfik şifreleme (FHE) kadar geniş bir işlem yelpazesine sahip olmadığını belirtmek önemlidir. SHE, çarpma gibi daha karmaşık işlemleri gerçekleştirmek için genellikle yetersizdir. Bu nedenle, SHE genellikle belirli uygulamalar için yeterli olan bir orta yol sağlar.\r\n\r\n\t\t\t\tÖzetle, SHE, verilerin gizliliğini korurken sınırlı matematiksel işlemler gerçekleştirmenizi sağlayan bir şifreleme türüdür. Bu özellikle bulut hesaplama, veri analizi gibi alanlarda gizliliğin korunması gereken durumlarda kullanılabilir.",
						  },
						  new Lecture()
						  {
							  LectureId = 36,
							  LectureContent = "Günümüzde insanların genom haritaları çıkarılma çalışmaları hızlı bir şekilde\r\n\t\t\t\tsürmektedir. Yakın bir gelecekte dünya üzerindeki insanların birçoğunun genom\r\n\t\t\t\tharitalarına sahip olacağız. Biyoloji, tıp ve insanlığın varoluşu konuları hakkında bu\r\n\t\t\t\tbilgilerin bize yardımcı olmaları beklenmektedir. Genom haritaları bilgisi\r\n\t\t\t\tlaboratuarlarda ve tıp merkezlerinde tutulmaktadır. Fakat bu verilerin saklanmasında ve\r\n\t\t\t\tpaylaşılmasında insanların güvenliği ve gizliliği açısından sıkıntılar doğmaktadır. DNA\r\n\t\t\t\tve RNA bir insanın parmak izi gibi özel bir tanımıdır. Bu bilgilerin güvenliğinin\r\n\t\t\t\tsağlanmadan paylaşılması büyük bir sorun teşkil etmektedir.\r\n\t\t\t\tGenom verilerin korunması National Institutes of Health tarafından\r\n\t\t\t\tsağlanmaktadır. Bu verilere güvenli erişim için devlet kontrolü altında veya güvenilir\r\n\t\t\t\tortaklar tarafından erişim sağlanmaktadır. Bu verilerin hızlı bir şekilde artmasından\r\n\t\t\t\tdolayı bulut tabanlı yeni çalışmalar önerildi. Fakat şuan için bu verilerin bulut ortamına\r\n\t\t\t\taktarılması güvenli değildir.\r\n\t\t\t\tGenom verilerinin bazıları veriler üzerinde işlemlerin yapılarak belirli bir sonuç\r\n\t\t\t\telde etmeye dayanmaktadır. HE yöntemi ile buluta yüklenecek genom verilerinin\r\n\t\t\t\tbazıları üzerinde güvenli bir şekilde işlem yapılabilirliği sağlanabilir.",
						  },
						  new Lecture()
						  {
							  LectureId = 37,
							  LectureContent = "Hükümete bağlı bulunan bina, şebeke, jeneratör vb. gibi yapıların birbiri ile\r\n\t\t\t\tbağlantılığı olduğu akıllı bir şebeke ağı oluştuğunda, bu yapılar belirli bir veri\r\n\t\t\t\türetecektir. Bu verilerin çeşitli hükümet organları ile paylaşılarak gerekli analizlerin ve\r\n\t\t\t\tincelemelerin yapılması gerekmektedir. Bu işlemlerin güvenli bir şekilde yapılabilmesi\r\n\t\t\t\tiçin HE yapısından faydalanarak gerekli hesaplamalar ve incelemeler yapılabilir. Bu tür\r\n\t\t\t\tbilgiler ile kötü amaçlı yazılımlar, anormallikler ve izinsiz girişlerin tespiti yapılarak\r\n\t\t\t\tgüvenlik sağlanabilir.\r\n\t\t\t\tBöyle bir yapı çok fazla alandan çok fazla bilgi içerdiği için bu bilgileri korumak\r\n\t\t\t\tve kötü kişiler tarafından ele geçirilmediğini sağmak çok önemlidir. Örnek olarak,\r\n\t\t\t\tşebeke ve güç dağılımı bilgilerinin kötü kişiler tarafından ele geçirildiğinde, bu alanlara\r\n\t\t\t\tsaldırılar olabilir.\r\n\t\t\t\tHerhangi başka bir uygulama ile bu güvenliği sağlamak, uygulamada kullanılan\r\n\t\t\t\työntemlerin belirgin olamaması, algoritmaların bilinmemesi ve protokollerin\r\n\t\t\t\tgüvenilirliğinin test edilememesi durumlarından dolayı kesin değildir. Bu nedenle kritik\r\n\t\t\t\talanlarda HE yöntemi kullanmak çok daha iyi olabilmektedir.",
						  },
						  new Lecture()
						  {
							  LectureId = 38,
							  LectureContent = "ABD’de her geçen yıl 1 milyondan fazla öğrenci lise zamanı okulu\r\n\t\t\t\tbırakmaktadır (2017 verilerine göre). Liseye başlayan öğrencilerin çeyreği okulunu\r\n\t\t\t\tzamanında bitirememektedir. Bu problemi en aza indirgemek için; liseyi bitirememe ve\r\n\t\t\t\tliseyi zamanında tamamlayamama grubunda olabilecek öğrencileri liseye başlamadan\r\n\t\t\t\tönce tespit edip gerekli önlemler alınabilir. Böyle bir tespitin yapılabilmesi için\r\n\t\t\t\thükümete bağlı okul, hastane, polise vb. kurumlardaki bilgilerin birleştirerek analiz\r\n\t\t\t\tedilmesi gerekmektedir.Fakat bu kurumların hepsinin kendi bilgilerini koruma ve\r\n\t\t\t\tgüvenliğin sağlamakla yükümlüdür.\r\n\t\t\t\tBütün bu bilgilerin tek yerde tutulması büyük bir risk oluşturmaktadır. Bu denli\r\n\t\t\t\tbüyük bir bilgi kötü kişiler tarafından ele geçirmeye çalışılabilir ve sürekli saldırı\r\n\t\t\t\taltında olabilir.\r\n\t\t\t\tHE yapısından faydalanarak bu bilgilerin herhangi bir yere taşınmasına gerek\r\n\t\t\t\tkalmadan hesaplanabilir hale getirilebilir. Bu şekilde güvenlik en üst düzeyde tutulmuş\r\n\t\t\t\tolacaktır.",
						  },
						  new Lecture()
						  {
							  LectureId = 39,
							  LectureContent = "Sağlık hizmetlerinde kişilerin hassas bilgileri bulunmaktadır. Bu bilgilerin\r\n\t\t\t\tgüvenliğinin iyi sağlanması kötü kişiler tarafından ele geçirilmemesi çok önemlidir.\r\n\t\t\t\tFakat bir yandan bu bilgilerin sürekli olarak işlenmesi gerekmektedir. Risk ve fayda\r\n\t\t\t\tarasındaki bu bilgilerin doğru bir şekilde korunmadığında bilgi kaybının yanında büyük\r\n\t\t\t\tmaliyetlere sebep olduğu görülmektedir.\r\n\t\t\t\tHE yapısı sağlık hizmetlerindeki bilgilerin risk ve fayda dengesini sağlamada rol\r\n\t\t\t\toynayabilir. Fatura, rapor oluşturma gibi yapılacak işlemlerin yapılması sırasında\r\n\t\t\t\tbilgilerin gizli kalmasını sağlayıp sadece sonucun elde edilmesini sağlayabilir. Bu\r\n\t\t\t\tşekilde verilerin güvenliği sağlanarak, büyük maliyetlere sebebiyet verecek olaylardan\r\n\t\t\t\tkorunmasını sağlar.",
						  },
						  new Lecture()
						  {
							  LectureId = 40,
							  LectureContent = "Bulut Bilişim, günümüzde popüler bir şekilde kullanılan internet üzerinde\r\n\t\t\t\tverilerin depolanabileceği bir teknolojidir. Bulut bilişim, ulaşılabilirliğin kolay olması\r\n\t\t\t\tve maliyetinin düşük olmasından dolayı çok tercih edilmektedir. Aynı zamanda kişisel\r\n\t\t\t\tverilerin bu teknoloji üzerinde tutulmasından dolayı, saldırganlar için potansiyel bir\r\n\t\t\t\tsaldırma yeridir. Saldırıya uğrayan bir bulutun, kişisel verileri nasıl koruyacağına dair\r\n\t\t\t\tsorunlar gündeme gelmektedir. Bu sorunu çözebilmek için bulut üzerinde tutulan\r\n\t\t\t\tverilerin şifreli bir şekilde saklanması gerekmektedir. Saldırgana kullanıcı verilerine\r\n\t\t\t\tulaşabile şifreli oldukları için herhangi bir şey elde edemez. Fakat verilerin şifreli bir\r\n\t\t\t\tşekilde tutulması kullanıcıların verilerine ulaşmak istemesi veya üzerinde değişiklikler\r\n\t\t\t\tyapmak istemesi halinde şifreleme ve şifre çözme işlemleri gerçekleştirmek\r\n\t\t\t\tgerekmektedir. Bu işlemler ek maliyetler getirecektir.\r\n\t\t\t\tHE yapısı bulut bilişiminde kullanılabilir. HE yapısı sayesinde şifrelenmiş\r\n\t\t\t\tolarak saklanan veriler üzerinde kullanıcılar gerekli işlemleri gerçekleştirerek maliyet\r\n\t\t\t\tdüşürülebilir. Veriler şifreli olacağı için saldırganlar tarafından da korunaklı bir yapı\r\n\t\t\t\thaline gelecektir.",
						  },
						  new Lecture()
						  {
							  LectureId = 41,
							  LectureContent = "Mobil ajanlar, kullanıcıların önceden belirlenmiş olan görevleri kullanıcıların\r\n\t\t\t\tmüdahalesi gerekmeden başka bilgisayarlar üzerinde gerçekleştiren programlardır.\r\n\t\t\t\tMobil ajanların çalıştığı diğer bilgisayarların kötü niyetli\r\n\t\t\t\tkişiler tarafınca kontrol edilebilmesinden dolayı güvenlik açığı ortaya çıkmaktadır.\r\n\t\t\t\tBundan dolayı mobil ajanları kötü niyetli kişiler tarafından korumak ve işlemlerini\r\n\t\t\t\tgerçekleştirmek için HE yapısı kullanılabilir. Verileri, mobil ajanlar tarafından başka\r\n\t\t\t\tbilgisayarlarda kullanılmadan önce şifrelemek ve sonrasında şifreli veriler üzerinde\r\n\t\t\t\thesaplama yapmak için HE yapısından faydalanılabilir.",
						  },
						  new Lecture()
						  {
							  LectureId = 42,
							  LectureContent = "Elektronik ortamda gizli oylama sistemlerinde, oylar üzerinde işlemlerin\r\n\t\t\t\tyapılması gerekmektedir. Yapılacak olan bu işlemler sırasında, oy veren bireylerin\r\n\t\t\t\tkullandıkları oy hakkındaki bilgilerin gizlilik nedeni ile ortaya çıkarılmaması\r\n\t\t\t\tgerekmektedir. Şifreli olarak saklanan oylar üzerinde işlem yapabilmek için HE yapısı\r\n\t\t\t\tkullanılabilir. Bu sayede oylar üzerinde analizler yapılırken, oyların gizliliği\r\n\t\t\t\tsürdürülebilir.",
						  },

						  new Lecture()
						  {
							  LectureId = 43,
							  LectureContent = "Avuç ve parmak izi tanıma teknolojileri özellikle son yıllarda daha fazla\r\n\t\t\t\tkullanılmaya başlamıştır. Avuç ve parmak uçlarındaki deri üzerindeki dalgalanmaların\r\n\t\t\t\tkarakteristik bir yapıya sahip olmasında dolayı, bu veriler ile tanımlama işlemleri\r\n\t\t\t\tgerçekleştirilmektedir. Bu uygulamaların sahip\r\n\t\t\t\tolduğu kişisel avuç ve parmak izi verilerinin şifreli bir şekilde tutularak ve gerektiğinde\r\n\t\t\t\tbu işlemlerin şifreli bir şekilde yapılması güvenlik için önemlidir. HE yapısı ile bu\r\n\t\t\t\tuygulamalardaki güvenlik arttırılabilir.",
						  },

						  new Lecture()
						  {
							  LectureId = 44,
							  LectureContent = "Finansal sektörde müşteriler tarafından şirketlere yapılacak yatırımlar, şirket\r\n\t\t\t\thakkındaki bilgiler doğrultusunda yapılmaktadır. Bu bilgiler, şirketin performansı,\r\n\t\t\t\tenvanter durumu gibi bilgilerden oluşmaktadır. Bu bilgiler üzerinde hesaplamalar\r\n\t\t\t\tyapılarak şirket hakkında gerekli bilgiye sahip olan müşteri yatırım yapıp\r\n\t\t\t\tyapmayacağına karar verir. Şirketler bu bilgileri avantajlarını koruyabilmek için gizli\r\n\t\t\t\ttutmak isteyebilirler.\r\n\t\t\t\tŞirketler HE yapısı kullanılarak bu bilgileri açık bir şekilde yayınlamadan\r\n\t\t\t\tmüşteriler tarafından kullanılabilir bir yapı oluşturabilir. Bu sayede şirketler bilgilerini\r\n\t\t\t\taçık bir şekilde paylaşmamış ve müşteriler şirket bilgileri hakkında yapmak istedikleri\r\n\t\t\t\thesaplamaları yapabilirler.",
						  },
						  new Lecture()
						  {
							  LectureId = 45,
							  LectureContent = "Reklam, satıcının sattığı ürün veya hizmetin müşteriler tarafından bilinmesini\r\n\t\t\t\tsağlayan bir araçtır. Reklam veren satıcıların asıl ulaşmak istedikleri kişiler potansiyel\r\n\t\t\t\talıcılardır. Potansiyel alıcıların kimler olduğunu belirlemek için, insanların kullandıkları\r\n\t\t\t\tbilgisayar, telefon gibi iletişim içerisinde olan elektronik eşyalar kullanılır. Bu eşyaları\r\n\t\t\t\tkullanan insanların; aradıkları kelimeler, ilgi alanları, e-postalar, konum bilgileri gibi\r\n\t\t\t\tbilgilerini toplayarak, o kişi hakkında bilgi sahibi olunabilir. Toplanan bu bilgiler\r\n\t\t\t\tsayesinde reklam yapan satıcıların sattığı ürünün veya hizmetin potansiyel alıcısı olduğu\r\n\t\t\t\ttahmin edilen kişilere sunulması. Bu sayede satıcıların müşterileri ile kolay bir şekilde\r\n\t\t\t\tbuluşması sağlanabilir.\r\n\t\t\t\tHE yapısı sayesinde kişilerden toplanan kişisel bilgilerin açık olarak saklanması\r\n\t\t\t\tgerekmemektedir. Şifreli olarak saklanan bilgilerin, gerektiğinde şifreli olarak işlem\r\n\t\t\t\tyapılarak sonuçları üzerinden potansiyel alıcılar belirlenebilir.",
						  },
						  new Lecture()
						  {
							  LectureId = 46,
							  LectureContent = "Veri kümeleme, ağ içerisinde bulunan algılayıcıların veri miktarlarını düşürerek\r\n\t\t\t\tenerji tasarrufu yapmasını sağlayan bir yapıdır. Güvenlik sorunları ile karşılaşılmaması\r\n\t\t\t\tiçin veri gönderecek tarafın veriyi şifreleyerek baz istasyonuna göndermesi\r\n\t\t\t\tgerekmektedir. Fakat verinin gideceği yol üzerindeki algılayıcılar veriyi açık metin\r\n\t\t\t\thaline getirerek veri kümele işlemi yapması gerekmektedir. Güvenlik ve veri kümeleme\r\n\t\t\t\tbirbirlerine zıt bir şekilde çalışmaktadır.\r\n\t\t\t\tVeriyi baz istasyonuna gönderen taraf veriyi simetrik anahtar şifreleme ile\r\n\t\t\t\tgöndermektedir. Ağ üzerindeki algılayıcılar şifre çözme işlemi ile veriyi çözer, veri\r\n\t\t\t\tkümeleme yapar ve sonrasında tekrar şifreleme işlemini gerçekleştirerek veriyi\r\n\t\t\t\tgönderir. Veri bu işlemler sırasında gizliliğini yitirmektedir.\r\n\t\t\t\tHem veri gizliliğini sağlamak hem de veri kümele işlemini gerçekleştirmek için\r\n\t\t\t\tHE yapısından faydalanılabilir. HE yapısı sayesinde veriyi baz istasyonuna gönderen\r\n\t\t\t\ttaraf veriyi şifreleyerek gönderir. Ağ üzerindeki algılayıcılar şifre çözme işlemini\r\n\t\t\t\tgerçekleştirmeden veri kümele işlemini yapar ve veriyi gönderir. Bu sayede şifreli veri\r\n\t\t\t\tyol boyunca açılmadı için veri gizliliği sağlanmış ve veri kümele işlemi\r\n\t\t\t\tgerçekleştirilmiş olur.",
						  },
						  new Lecture()
						  {
							  LectureId = 47,
							  LectureContent = "IoT, etrafımıza etkide bulunan veya analiz etmemizi sağlayan cihazları etkileşim\r\n\t\t\t\tiçinde olmalarını sağlayan bir iletişim ağıdır. Bu iletişim ağı sayesinde üretim\r\n\t\t\t\tsüreçlerini, hasta takipleri, geri dönüşüm süreçleri, akıllı binalar gibi alanlarda kontrol\r\n\t\t\t\tsağlanabilir ve analiz yapılabilir.\r\n\t\t\t\tStandart şifreleme yöntemlerinden faydalanarak IoT oluşturulduğunda iki tane\r\n\t\t\t\tproblem ortaya çıkmaktadır. Eğer veriler şifrelenmemiş olarak depolanırsa, kötü niyetli\r\n\t\t\t\tkişiler tarafından ele geçirilebilir. Eğer veriler şifrelenmiş olarak depolanırsa,\r\n\t\t\t\tsağlayıcılar üzerinde çalışması için şifrenin çözülmesi gerekir.\r\n\t\t\t\tHE sayesinde veriler şifrelenmiş şekilde depolanarak, şifre çözme işlemine gerek\r\n\t\t\t\tkalmadan sağlayıcılar üzerinde işlem yapılabilir. RSA algoritması, ElGamal\r\n\t\t\t\talgoritması, Paillier algoritması bu amaç ile kullanılabilir. IoT için Homomorfik\r\n\t\t\t\tŞifreleme çok önemlidir. Çünkü bir yandan veri gizliliğini koruyarak, bir yandan da\r\n\t\t\t\tsağlayıcılar ve düğüm noktalarında hızlı bir şekilde şifre çözme ve şifreleme işlemlerine\r\n\t\t\t\tgerek duymadan gerçekleştirilebilir. Düğümlerde toplama ve çarpma işlemleri\r\n\t\t\t\tgerçekleştirilerek işlem ve depolama maliyeti azaltılabilir. Bu sayede düşük güç\r\n\t\t\t\ttüketimi gerçekleşmiş olur.",
						  },
						  new Lecture()
						  {
							  LectureId = 48,
							  LectureContent = "Veri tabanı düzenli şekilde verilerin saklandığı bilgi topluluğudur. Veri\r\n\t\t\t\ttabanındaki verilere istenildiği zaman ulaşılabilir ve kullanılabilir.\r\n\t\t\t\tBu veriler veri tabanında güvenlik için şifreli bir şekilde bulunmaktadır. Fakat veriler\r\n\t\t\t\tüzerinde gerçekleştirilecek işlemlerin yapılması sırasında bu verilerin şifrelerinin\r\n\t\t\t\tçözülmesi ve açık metin üzerinde işlemlerin gerçekleşmesi gerekmektedir. Bu nedenle,\r\n\t\t\t\tveri tabanındaki veriler güvenlik riskleri ile karşı karşıyadır.\r\n\t\t\t\tHE yapısı veriler üzerinde şifre çözme işlemini gerçekleştirmeden işlemler\r\n\t\t\t\tyapılabilmesine olanak sağlamaktadır. Bu sayede veri tabanında saklanan veriler\r\n\t\t\t\tüzerinde işlemler güvenli bir şekilde gerçekleşebilir.",
						  },
						  new Lecture()
						  {
							  LectureId = 49,
							  LectureContent = "Ağ kontrol sistemleri siber güvenliğin en önemli konularından biridir. Su, ulaşım\r\n\t\t\t\tve elektrik ağları gibi endüstriyel ve kritik altyapılara uygulanır. Kötü niyetli kişiler bu\r\n\t\t\t\tağlara karşı saldırılarda bulunmaktadır. İletişim kanalları üzerinden gönderilen\r\n\t\t\t\tsinyallerin güvenliği sağlanmalıdır (Kogiso & Fujita, 2015).\r\n\t\t\t\tKontrol cihazının parametrelerini ve kontrol cihazı içerisindeki sinyalleri\r\n\t\t\t\tşifrelemek güvenlik açısından önemlidir. Kontrol cihazına gelene sinyal şifreli bir\r\n\t\t\t\tşekilde gelerek şifre çözme işlemi gerçekleştirilir ve gerekli işlemlerin yapılması\r\n\t\t\t\tsonucunda tekrar şifrelenerek şifreli olarak kontrol cihazından çıkış gerçekleştirir. HE\r\n\t\t\t\tyapısı kontrol cihazlarında uygulandığında şifreli olarak gelen sinyal şifre çözme işlemi\r\n\t\t\t\tgerçekleşmeden gerekli işlemler üzerinde gerçekleştirilerek şifreli olarak çıkış\r\n\t\t\t\tgerçekleştirir. Bu sayede ağ kontrol cihazları üzerinde güvenlik arttırılmış olacaktır.",
						  },
						  new Lecture()
						  {
							  LectureId = 50,
							  LectureContent = "Açık arttırma bir malın, menkulün, eşyanın vb. ürünlerin alıcı ve satıcıların bir\r\n\t\t\t\tarada bulunarak fiyat tekliflerinin bildirilmesi ile en yüksek fiyata sahip alıcının ürünü\r\n\t\t\t\talmasıdır. Açık arttırmalar açık teklif veya kapalı teklif şeklinde ikiye ayrılmaktadır.\r\n\t\t\t\tAçık teklif şeklinde gerçekleşen açık arttırmalarda, alıcılar fiyat tekliflerini açık bir\r\n\t\t\t\tşekilde gerçekleştirirler. Kapalı teklif şeklinde gerçekleşen açık arttırmalarda, alıcılar\r\n\t\t\t\tfiyat tekliflerini kapalı bir şekilde gerçekleştirirler.\r\n\t\t\t\tKapalı teklif açık arttırmalarda, alıcıların verdikleri teklifler gizli olmalıdır. Bu\r\n\t\t\t\ttekliflerin açığa çıkması açık arttırmayı olumsuz yönde etkilemektedir. Bir yandan bu\r\n\t\t\t\ttekliflerin karşılaştırma işlemleri gerçekleştirilmesi gerekmektedir. Burada üçüncü\r\n\t\t\t\tşahıslara olan güven esas alınmaktadır.\r\n\t\t\t\tHE yapısı kapalı teklif açık arttırmalarda uygulanabilir. Bu sayede alıcılar\r\n\t\t\t\ttarafından verilen teklifler şifreli bir şekilde saklanır. Karşılaştırmaların yapılması için\r\n\t\t\t\tşifreli olarak saklanan veriler şifre çözme işlemine gerek olmadan gerekli işlemler\r\n\t\t\t\tüzerinde gerçekleştirilebilir. Bunun sonucunda, teklifler üçüncü bir şahıssa güven\r\n\t\t\t\tolmayı gerektirmeden açık arttırma gerçekleşebilir.",
						  },
						  new Lecture()
						  {
							  LectureId = 51,
							  LectureContent = "Homomorfik şifreleme, verileri şifrelerken, şifrelenmiş veri üzerinde işlemler yapılabilir \r\n\t\t\t\t\thale getirir. Ancak bu işlemler sonucunda elde edilen çıktılar, şifrelenmiş veriden doğrudan anlamlı \r\n\t\t\t\t\tbir şekilde yararlanılmasını önlemek için tekrar şifrelenmiş olmalıdır. Bu sayede, veri sahiplerinin \r\n\t\t\t\t\tgizli verilerinin ifşa edilmesi önlenir.",
						  },
						  new Lecture()
						  {
							  LectureId = 52,
							  LectureContent = "Homomorfik şifreleme, şifreli veri üzerinde işlemler yapılabilmesini sağlar, ancak \r\n\t\t\t\t\tbu işlemler sonucunda verinin bütünlüğünün korunması kritiktir. Yani, işlenmiş verinin, orijinal \r\n\t\t\t\t\tveriden doğru bir şekilde türetildiğinden emin olunmalıdır.",
						  },
						  new Lecture()
						  {
							  LectureId = 53,
							  LectureContent = "Homomorfik şifreleme sistemlerinde kullanılan şifreleme \r\n\t\t\t\t\tanahtarlarının güvenliği büyük önem taşır. Eğer bir saldırgan anahtarları ele geçirirse, bu \r\n\t\t\t\t\tsaldırganın şifrelenmiş veri üzerinde istediği işlemleri yapması mümkün olabilir.",
						  },
						  new Lecture()
						  {
							  LectureId = 54,
							  LectureContent = "Veri işleme sürecinde, verinin kim tarafından işlendiğinin \r\n\t\t\t\t\tdoğrulanması önemlidir. Bu nedenle, hem veri işleme sürecinin hem de işlem sonuçlarının \r\n\t\t\t\t\tdoğrulanması için güvenilir doğrulama mekanizmaları gereklidir.",
						  },
						  new Lecture()
						  {
							  LectureId = 55,
							  LectureContent = "Homomorfik şifreleme sistemleri, çeşitli saldırılara karşı dirençli olmalıdır. Özellikle\r\n\t\t\t\t\tkriptografik saldırılara karşı dayanıklı olmalı ve saldırganların şifreli veriyi kırmak için \r\n\t\t\t\t\tkullanabilecekleri yöntemlere karşı korunaklı olmalıdır.",
						  },
						  new Lecture()
						  {
							  LectureId = 56,
							  LectureContent = "Bu ilkeler, homomorfik şifreleme teknolojisinin güvenliği ve gizliliği sağlamak için temel alınan \r\n\t\t\t\tprensiplerdir. Bu ilkeler, bu teknolojinin güvenilir ve etkili bir şekilde uygulanmasını sağlamak için\r\n\t\t\t\tdikkate alınmalıdır.",
						  },
						  new Lecture()
						  {
							  LectureId = 57,
							  LectureContent = "Homomorfik şifreleme ve veri analitiği arasındaki ilişki, veri gizliliği ve güvenliği ile veri \r\n\t\t\t\tanalitiği arasında bir denge kurma ihtiyacından doğar. İşte bu konudaki potansiyeller ve zorluklar:",
						  },
						  new Lecture()
						  {
							  LectureId = 58,
							  LectureContent = "Potansiyeller:",
						  },
						  new Lecture()
						  {
							  LectureId = 59,
							  LectureContent = "Homomorfik şifreleme, verilerin analiz edilmesine olanak tanırken, aynı zamanda \r\n\t\t\t\tverilerin gizliliğini korur. Bu, hassas verilerin analiz edilmesi için güvenli bir \r\n\t\t\t\tortam sağlar, çünkü veriler şifreli olarak kalır ve analiz sırasında açık metin haline gelmez.",
						  },
						  new Lecture()
						  {
							  LectureId = 60,
							  LectureContent = "Homomorfik şifreleme, farklı kurumlar arasında hassas verilerin güvenli bir şekilde\r\n\t\t\t\tpaylaşılmasını sağlar. Veriler şifreli olduğu için, paylaşım sırasında gizliliği \r\n\t\t\t\tkorunurken, analiz yapmak isteyen kurumlar bu verilere erişebilir.",
						  },
						  new Lecture()
						  {
							  LectureId = 61,
							  LectureContent = "Homomorfik şifreleme sayesinde, özellikle sağlık, finans ve diğer hassas alanlardaki\r\n\t\t\t\tverilerin analizi mümkün hale gelir. Örneğin, sağlık verileri gibi özel\r\n\t\t\t\tveriler, analiz edilirken bile gizliliği korunarak değerlendirilebilir.",
						  },
						  new Lecture()
						  {
							  LectureId = 62,
							  LectureContent = "Zorluklar:",
						  },
						  new Lecture()
						  {
							  LectureId = 63,
							 
							  LectureContent = "Homomorfik şifreleme, hesaplama yoğun işlemler gerektirir. Özellikle \r\n\t\t\t\tbüyük veri kümeleriyle çalışırken, homomorfik işlemlerin yapılması \r\n\t\t\t\tzaman alabilir ve yüksek hesaplama gücüne ihtiyaç duyabilir.\r\n",
							 
						  },
						  new Lecture()
						  {
							  LectureId = 64,
							 
							  LectureContent = "Homomorfik şifreleme, geleneksel veri analitiği yöntemlerine göre \r\n\t\t\t\tdaha yavaş olabilir. Bu nedenle, gerçek zamanlı analizler veya \r\n\t\t\t\thızlı yanıtlar gerektiren uygulamalarda kullanılması zor olabilir.",
							 
						  },
						  new Lecture()
						  {
							  LectureId = 65,
							  
							  LectureContent = "Homomorfik şifreleme, karmaşık kriptografik algoritmaları\r\n\t\t\t\tgerektirir. Bu algoritmaların tasarımı ve uygulanması zor \r\n\t\t\t\tolabilir ve hatalı bir şekilde uygulandığında güvenlik riski oluşturabilir.",
							
						  },
						  new Lecture()
						  {
							  LectureId = 66,
							 
							  LectureContent = "Homomorfik şifreleme, verilerin boyutunu artırabilir. Özellikle şifreleme sırasında \r\n\t\t\t\tveri genişleyebilir ve bu da depolama ve iletim maliyetlerini artırabilir.",
							  
						  },
						  new Lecture()
						  {
							  LectureId = 67,
							  
							  LectureContent = "Homomorfik şifreleme ve veri analitiği arasındaki ilişki, veri gizliliği ve analitik esneklik \r\n\t\t\tarasında bir denge kurmayı gerektirir. Potansiyelleri, veri gizliliğini korurken veri analitiğini \r\n\t\t\tmümkün kılar. Ancak zorluklar, performans, hesaplama gücü ve kriptografik zorluklar gibi teknik engellerle karşılaşabilir.",
							  
						  }

						   
						   



				);

			modelBuilder.Entity<Example>()
				.HasData(
					  new Example() 
					  { 
						  ExampleId = 1, 
						  ExampleContent = "using System;\r\n            " +
						  "using Microsoft.Research.SEAL;\r\n\r\n            " +
						  "namespace HomomorphicEncryptionExample {\r\n                " +
						  "class Program {\r\n                    " +
						  "static void Main(string[] args) {\r\n                        " +
						  "// SEAL kütüphanesini kullanarak homomorfik şifreleme örneği\r\n\r\n                        " +
						  "// Parametrelerin oluşturulması\r\n                        " +
						  "EncryptionParameters parms = new EncryptionParameters(SchemeType.BFV);\r\n                        " +
						  "parms.PolyModulusDegree = 4096;\r\n                        " +
						  "parms.CoeffModulus = CoeffModulus.BFVDefault(polyModulusDegree: 4096);\r\n                        " +
						  "parms.PlainModulus = new Modulus(40961);\r\n\r\n                        " +
						  "using(SEALContext context = new SEALContext(parms))\r\n                        " +
						  "{\r\n                            " +
						  "// Anahtar çiftlerinin oluşturulması\r\n                            " +
						  "KeyGenerator keygen = new KeyGenerator(context);\r\n                            " +
						  "PublicKey publicKey = keygen.PublicKey;\r\n                            " +
						  "SecretKey secretKey = keygen.SecretKey;\r\n\r\n                            " +
						  "// Encryptor ve Decryptor'ların oluşturulması\r\n                            " +
						  "Encryptor encryptor = new Encryptor(context, publicKey);\r\n                            " +
						  "Decryptor decryptor = new Decryptor(context, secretKey);\r\n\r\n                            " +
						  "// Verinin şifrelenmesi\r\n                            " +
						  "Plaintext plainText = new Plaintext(\"42\");\r\n                            " +
						  "Console.WriteLine(\"Original: \" + plainText.ToString());\r\n\r\n                            " +
						  "Ciphertext encryptedData = new Ciphertext();\r\n                            " +
						  "encryptor.Encrypt(plainText, encryptedData);\r\n                            " +
						  "Console.WriteLine(\"Encrypted: \" + encryptedData.ToString());\r\n\r\n                      " +
						  "      // Verinin şifresinin çözülmesi\r\n                 " +
						  "           Plaintext decryptedData = new Plaintext();\r\n          " +
						  "                  decryptor.Decrypt(encryptedData, decryptedData);\r\n                       " +
						  "     Console.WriteLine(\"Decrypted: \" + decryptedData.ToString());\r\n             " +
						  "           }\r\n           " +
						  "         }\r\n       " +
						  "         }\r\n       " +
						  "     }", 
					  },

					  new Example()
					  {
						  ExampleId = 2,
						  ExampleContent = " import com.n1analytics.paillier.*;\r\n\r\n      " +
						  "      public class HomomorphicEncryptionExample {\r\n       " +
						  "         public static void main(String[] args) {\r\n            " +
						  "        try {\r\n        " +
						  "                // Paillier anahtar çiftlerini oluştur\r\n                " +
						  "        PaillierPrivateKey privateKey = PaillierPrivateKey.create(2048);\r\n               " +
						  "         PaillierPublicKey publicKey = privateKey.getPublicKey();\r\n\r\n                   " +
						  "     // Şifrelenecek sayıları oluştur\r\n           " +
						  "             long plaintext1 = 42;\r\n              " +
						  "          long plaintext2 = 15;\r\n\r\n           " +
						  "             // Sayıları şifrele\r\n        " +
						  "                Ciphertext ciphertext1 = publicKey.encrypt(plaintext1);\r\n                    " +
						  "    Ciphertext ciphertext2 = publicKey.encrypt(plaintext2);\r\n\r\n              " +
						  "          // Şifreli sayıları topla\r\n              " +
						  "          Ciphertext sumCiphertext = ciphertext1.add(ciphertext2);\r\n\r\n              " +
						  "          // Toplamı çöz\r\n              " +
						  "          long decryptedSum = privateKey.decrypt(sumCiphertext).longValue();\r\n\r\n              " +
						  "          // Sonuçları ekrana yazdır\r\n            " +
						  "            System.out.println(\"Plaintext 1: \" + plaintext1);\r\n              " +
						  "          System.out.println(\"Plaintext 2: \" + plaintext2);\r\n      " +
						  "                  System.out.println(\"Encrypted 1: \" + ciphertext1.toString());\r\n            " +
						  "            System.out.println(\"Encrypted 2: \" + ciphertext2.toString());\r\n             " +
						  "           System.out.println(\"Sum (Encrypted): \" + sumCiphertext.toString());\r\n                " +
						  "        System.out.println(\"Decrypted Sum: \" + decryptedSum);\r\n\r\n           " +
						  "         } catch (PaillierException e) {\r\n                  " +
						  "      e.printStackTrace();\r\n                " +
						  "    }\r\n            " +
						  "    }\r\n         " +
						  "   }" +
						  "",
					  },

					  new Example()
					  {
						  ExampleId = 3,
						  ExampleContent = "from seal import *\r\n\r\n         " +
						  "   def main():\r\n             " +
						  "   # SEALContext ve Encoder'ın oluşturulması\r\n       " +
						  "         parms = EncryptionParameters(scheme_type.BFV)\r\n             " +
						  "   parms.set_poly_modulus_degree(4096)\r\n           " +
						  "     parms.set_coeff_modulus(CoeffModulus.BFVDefault(4096))\r\n             " +
						  "   parms.set_plain_modulus(PlainModulus(40961))\r\n\r\n              " +
						  "  context = SEALContext(parms)\r\n              " +
						  "  encoder = IntegerEncoder(context)\r\n\r\n               " +
						  " # Anahtar çiftlerinin oluşturulması\r\n                " +
						  "keygen = KeyGenerator(context)\r\n                " +
						  "public_key = keygen.public_key()\r\n                " +
						  "secret_key = keygen.secret_key()\r\n\r\n                " +
						  "# Encryptor ve Decryptor'ların oluşturulması\r\n                " +
						  "encryptor = Encryptor(context, public_key)\r\n                " +
						  "decryptor = Decryptor(context, secret_key)\r\n\r\n               " +
						  " # Verinin şifrelenmesi\r\n                " +
						  "plain_text_1 = 42\r\n                " +
						  "plain_text_2 = 15\r\n\r\n                " +
						  "encrypted_data_1 = Ciphertext()\r\n               " +
						  " encrypted_data_2 = Ciphertext()\r\n\r\n               " +
						  " encryptor.encrypt(encoder.encode(plain_text_1), encrypted_data_1)\r\n                " +
						  "encryptor.encrypt(encoder.encode(plain_text_2), encrypted_data_2)\r\n\r\n                " +
						  "# Şifreli sayıların toplanması\r\n                " +
						  "encrypted_sum = Ciphertext()\r\n                " +
						  "evaluator = Evaluator(context)\r\n                " +
						  "evaluator.add(encrypted_data_1, encrypted_data_2, encrypted_sum)\r\n\r\n                " +
						  "# Şifreli toplamın çözülmesi\r\n                " +
						  "decrypted_sum = Plaintext()\r\n                " +
						  "decryptor.decrypt(encrypted_sum, decrypted_sum)\r\n\r\n                " +
						  "# Sonuçların ekrana yazdırılması\r\n                " +
						  "print(\"Plaintext 1:\", plain_text_1)\r\n                " +
						  "print(\"Plaintext 2:\", plain_text_2)\r\n                " +
						  "print(\"Encrypted 1:\", encrypted_data_1.to_string())\r\n                " +
						  "print(\"Encrypted 2:\", encrypted_data_2.to_string())\r\n       " +
						  "print(\"Encrypted Sum:\", encrypted_sum.to_string())\r\n                " +
						  "print(\"Decrypted Sum:\", encoder.decode_int64(decrypted_sum)) " +
						  "if __name__ == '__main__':" +
						  "main()" +
						  ""
                      }



				);

		}
    }
}
