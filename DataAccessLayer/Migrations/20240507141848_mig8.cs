using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Example",
                columns: table => new
                {
                    ExampleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExampleContent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Example", x => x.ExampleId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryDescription", "CategoryName", "CategoryStatus" },
                values: new object[,]
                {
                    { 102, "İçerik", "Paragraph", true },
                    { 103, "İçerik", "Paragraph", true },
                    { 104, "İçerik", "Paragraph", true },
                    { 105, "İçerik", "Paragraph", true },
                    { 106, "İçerik", "Paragraph", true },
                    { 107, "İçerik", "Paragraph", true },
                    { 108, "İçerik", "Paragraph", true },
                    { 109, "İçerik", "Paragraph", true },
                    { 110, "İçerik", "Paragraph", true },
                    { 111, "İçerik", "Paragraph", true },
                    { 112, "İçerik", "Paragraph", true },
                    { 113, "İçerik", "Paragraph", true },
                    { 114, "İçerik", "Paragraph", true },
                    { 115, "İçerik", "Paragraph", true },
                    { 116, "İçerik", "Paragraph", true },
                    { 117, "İçerik", "Paragraph", true },
                    { 118, "İçerik", "Paragraph", true },
                    { 119, "İçerik", "Paragraph", true },
                    { 120, "İçerik", "Paragraph", true },
                    { 121, "İçerik", "Paragraph", true },
                    { 122, "İçerik", "Paragraph", true },
                    { 123, "İçerik", "Paragraph", true },
                    { 124, "İçerik", "Paragraph", true },
                    { 125, "İçerik", "Paragraph", true },
                    { 126, "İçerik", "Paragraph", true },
                    { 127, "İçerik", "Paragraph", true },
                    { 128, "İçerik", "Paragraph", true },
                    { 129, "İçerik", "Paragraph", true },
                    { 130, "İçerik", "Paragraph", true },
                    { 131, "İçerik", "Paragraph", true },
                    { 132, "İçerik", "Paragraph", true },
                    { 133, "İçerik", "Paragraph", true },
                    { 134, "İçerik", "Paragraph", true }
                });

            migrationBuilder.InsertData(
                table: "Example",
                columns: new[] { "ExampleId", "ExampleContent" },
                values: new object[,]
                {
                    { 1, " using System;\r\n            using Microsoft.Research.SEAL;\r\n\r\n            namespace HomomorphicEncryptionExample {\r\n                class Program {\r\n                    static void Main(string[] args) {\r\n                        // SEAL kütüphanesini kullanarak homomorfik şifreleme örneği\r\n\r\n                        // Parametrelerin oluşturulması\r\n                        EncryptionParameters parms = new EncryptionParameters(SchemeType.BFV);\r\n                        parms.PolyModulusDegree = 4096;\r\n                        parms.CoeffModulus = CoeffModulus.BFVDefault(polyModulusDegree: 4096);\r\n                        parms.PlainModulus = new Modulus(40961);\r\n\r\n                        using(SEALContext context = new SEALContext(parms))\r\n                        {\r\n                            // Anahtar çiftlerinin oluşturulması\r\n                            KeyGenerator keygen = new KeyGenerator(context);\r\n                            PublicKey publicKey = keygen.PublicKey;\r\n                            SecretKey secretKey = keygen.SecretKey;\r\n\r\n                            // Encryptor ve Decryptor'ların oluşturulması\r\n                            Encryptor encryptor = new Encryptor(context, publicKey);\r\n                            Decryptor decryptor = new Decryptor(context, secretKey);\r\n\r\n                            // Verinin şifrelenmesi\r\n                            Plaintext plainText = new Plaintext(\"42\");\r\n                            Console.WriteLine(\"Original: \" + plainText.ToString());\r\n\r\n                            Ciphertext encryptedData = new Ciphertext();\r\n                            encryptor.Encrypt(plainText, encryptedData);\r\n                            Console.WriteLine(\"Encrypted: \" + encryptedData.ToString());\r\n\r\n                            // Verinin şifresinin çözülmesi\r\n                            Plaintext decryptedData = new Plaintext();\r\n                            decryptor.Decrypt(encryptedData, decryptedData);\r\n                            Console.WriteLine(\"Decrypted: \" + decryptedData.ToString());\r\n                        }\r\n                    }\r\n                }\r\n            }" },
                    { 2, " import com.n1analytics.paillier.*;\r\n\r\n            public class HomomorphicEncryptionExample {\r\n                public static void main(String[] args) {\r\n                    try {\r\n                        // Paillier anahtar çiftlerini oluştur\r\n                        PaillierPrivateKey privateKey = PaillierPrivateKey.create(2048);\r\n                        PaillierPublicKey publicKey = privateKey.getPublicKey();\r\n\r\n                        // Şifrelenecek sayıları oluştur\r\n                        long plaintext1 = 42;\r\n                        long plaintext2 = 15;\r\n\r\n                        // Sayıları şifrele\r\n                        Ciphertext ciphertext1 = publicKey.encrypt(plaintext1);\r\n                        Ciphertext ciphertext2 = publicKey.encrypt(plaintext2);\r\n\r\n                        // Şifreli sayıları topla\r\n                        Ciphertext sumCiphertext = ciphertext1.add(ciphertext2);\r\n\r\n                        // Toplamı çöz\r\n                        long decryptedSum = privateKey.decrypt(sumCiphertext).longValue();\r\n\r\n                        // Sonuçları ekrana yazdır\r\n                        System.out.println(\"Plaintext 1: \" + plaintext1);\r\n                        System.out.println(\"Plaintext 2: \" + plaintext2);\r\n                        System.out.println(\"Encrypted 1: \" + ciphertext1.toString());\r\n                        System.out.println(\"Encrypted 2: \" + ciphertext2.toString());\r\n                        System.out.println(\"Sum (Encrypted): \" + sumCiphertext.toString());\r\n                        System.out.println(\"Decrypted Sum: \" + decryptedSum);\r\n\r\n                    } catch (PaillierException e) {\r\n                        e.printStackTrace();\r\n                    }\r\n                }\r\n            }" },
                    { 3, "from seal import *\r\n\r\n            def main():\r\n                # SEALContext ve Encoder'ın oluşturulması\r\n                parms = EncryptionParameters(scheme_type.BFV)\r\n                parms.set_poly_modulus_degree(4096)\r\n                parms.set_coeff_modulus(CoeffModulus.BFVDefault(4096))\r\n                parms.set_plain_modulus(PlainModulus(40961))\r\n\r\n                context = SEALContext(parms)\r\n                encoder = IntegerEncoder(context)\r\n\r\n                # Anahtar çiftlerinin oluşturulması\r\n                keygen = KeyGenerator(context)\r\n                public_key = keygen.public_key()\r\n                secret_key = keygen.secret_key()\r\n\r\n                # Encryptor ve Decryptor'ların oluşturulması\r\n                encryptor = Encryptor(context, public_key)\r\n                decryptor = Decryptor(context, secret_key)\r\n\r\n                # Verinin şifrelenmesi\r\n                plain_text_1 = 42\r\n                plain_text_2 = 15\r\n\r\n                encrypted_data_1 = Ciphertext()\r\n                encrypted_data_2 = Ciphertext()\r\n\r\n                encryptor.encrypt(encoder.encode(plain_text_1), encrypted_data_1)\r\n                encryptor.encrypt(encoder.encode(plain_text_2), encrypted_data_2)\r\n\r\n                # Şifreli sayıların toplanması\r\n                encrypted_sum = Ciphertext()\r\n                evaluator = Evaluator(context)\r\n                evaluator.add(encrypted_data_1, encrypted_data_2, encrypted_sum)\r\n\r\n                # Şifreli toplamın çözülmesi\r\n                decrypted_sum = Plaintext()\r\n                decryptor.decrypt(encrypted_sum, decrypted_sum)\r\n\r\n                # Sonuçların ekrana yazdırılması\r\n                print(\"Plaintext 1:\", plain_text_1)\r\n                print(\"Plaintext 2:\", plain_text_2)\r\n                print(\"Encrypted 1:\", encrypted_data_1.to_string())\r\n                print(\"Encrypted 2:\", encrypted_data_2.to_string())\r\n                print(\"Encrypted Sum:\", encrypted_sum.to_string())\r\n                print(\"Decrypted Sum:\", encoder.decode_int64(decrypted_sum))\r\n\r\n            if __name__ == '__main__':\r\n                main()" }
                });

            migrationBuilder.UpdateData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 100,
                columns: new[] { "ParagraphContent", "ParagraphTitle" },
                values: new object[] { "Toplama homomorfizmi (fully homomorphic encryption, FHE), çıkarma homomorfizmi (partially homomorphic encryption, PHE),\r\n				ve çarpma homomorfizmi (somewhat homomorphic encryption).", "Temelde üç tür homomorfik şifreleme vardır:" });

            migrationBuilder.UpdateData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 101,
                columns: new[] { "ParagraphContent", "ParagraphTitle" },
                values: new object[] { "Bu tür homomorfizm, şifreli veri üzerinde herhangi bir matematiksel işlemi gerçekleştirmeye izin verir.\r\n				Yani şifrelenmiş sayılar üzerinde toplama, çıkarma, çarpma ve bölme işlemleri yapılabilir.\r\n				Fully homomorfik şifreleme, tamamen genel matematiksel işlemleri destekler. Ancak,\r\n				bu tür şifreleme yöntemleri genellikle hesaplama maliyeti ve karmaşıklığı yüksek olduğundan,\r\n				pratik uygulamalarda kullanımı biraz sınırlı olabilir.", "1. Toplama Homomorfizmi (Fully Homomorphic Encryption - FHE):" });

            migrationBuilder.InsertData(
                table: "Paragraphs",
                columns: new[] { "ParagraphID", "CategoryID", "ParagraphContent", "ParagraphStatus", "ParagraphTitle" },
                values: new object[,]
                {
                    { 102, 102, "PHE, şifreli metin üzerinde belirli türde matematiksel işlemleri gerçekleştirmeye izin verir.\r\n				Genellikle toplama veya çarpma işlemlerine izin veren bir homomorfizm türüdür.\r\n				PHE, özellikle belirli uygulamalar için daha hızlı ve daha az hesaplama maliyetine sahiptir.\r\n				Ancak tam anlamıyla genel işlemleri desteklemez.", true, "2. Çıkarma Homomorfizmi (Partially Homomorphic Encryption - PHE):" },
                    { 103, 103, "Somewhat homomorfik şifreleme, genellikle çarpma işlemlerine izin veren bir homomorfizm türüdür.\r\n				Bu, genellikle veri analitiği gibi belirli uygulamalarda kullanışlıdır.\r\n				Bu tür şifreleme yöntemleri, genellikle belirli sayıda çarpma işlemine izin verir. Bu sınırlama,\r\n				tamamen genel olmayan bir homomorfizmi temsil eder.", true, "3. Çarpma Homomorfizmi (Somewhat Homomorphic Encryption):" },
                    { 104, 104, "Homomorfik şifreleme, gizliliğin korunması ve güvenli veri işleme konularında önemli bir rol oynar.\r\n				Özellikle bulut bilişim ve veri paylaşımı gibi alanlarda, verilerin şifrelenmiş hali üzerinde işlemler yapılabilmesi,\r\n				hem gizliliği hem de güvenliği artırabilir. Ancak, homomorfik şifreleme yöntemleri genellikle daha karmaşık ve hesaplama maliyeti yüksek olduğu için,\r\n				pratik uygulamalarda dikkatlice değerlendirilmelidir.", true, "Homomorfik Wiki" },
                    { 105, 105, "Homomorfik şifreleme, şifrelenmiş veriler üzerinde işlem yapmayı mümkün kılan bir şifreleme yöntemidir. Bu yöntem sayesinde, veriler şifrelenmiş haldeyken bile matematiksel işlemler uygulanabilir ve sonuçlar şifrelenmiş olarak kalır. Bu, verilerin gizliliğini koruyarak, dış kaynaklı hesaplama ve depolamaya olanak tanır.", true, "Homomorfik Wiki Açıklama" },
                    { 106, 106, "Özellikle sağlık sektöründe, homomorfik şifreleme, hassas tıbbi verilerin güvenli bir şekilde işlenmesini sağlar. Bu sayede, sağlık hizmetleri, gizlilik endişelerini azaltarak, veri analitiği ve tahmine dayalı analiz gibi önemli hizmetleri daha etkin bir şekilde kullanabilirler.", true, "Homomorfik Wiki Açıklama" },
                    { 107, 107, "Homomorfik şifreleme, şifrelenmiş veriler üzerinde farklı hesaplama sınıfları gerçekleştirebilen birden fazla şifreleme şeması türünü içerir.\r\n				Hesaplamalar Boolean veya aritmetik devreler olarak temsil edilir. Bazı yaygın homomorfik şifreleme türleri kısmen homomorfik,\r\n				biraz homomorfik, seviyeli tamamen homomorfik ve tamamen homomorfik şifrelemedir:", true, "Homomorfik Wiki Açıklama" },
                    { 108, 108, "Kısmen homomorfik şifreleme, örneğin toplama veya çarpma gibi yalnızca tek tip kapıdan oluşan devrelerin\r\n					değerlendirilmesini destekleyen şemaları kapsar.", true, "Homomorfik Wiki Açıklama" },
                    { 109, 109, "Bir dereceye kadar homomorfik şifreleme şemaları, iki tür kapıyı değerlendirebilir,\r\n					ancak yalnızca devrelerin bir alt kümesi için.\r\n					Seviyelendirilmiş tamamen homomorfik şifreleme, sınırlı (önceden belirlenmiş) derinliğe sahip\r\n					birden fazla kapı türünden oluşan rastgele devrelerin değerlendirilmesini destekler.", true, "Homomorfik Wiki Açıklama" },
                    { 110, 110, "Tamamen homomorfik şifreleme (FHE), sınırsız derinlikte birden fazla kapı türünden oluşan rastgele\r\n					devrelerin değerlendirilmesine olanak tanır ve homomorfik şifrelemenin en güçlü kavramıdır.", true, "Homomorfik Wiki Açıklama" },
                    { 111, 111, "Homomorfik şifreleme şemalarının çoğunluğu için, devrelerin çarpımsal derinliği,\r\n				şifrelenmiş veriler üzerinde hesaplamaların gerçekleştirilmesindeki temel pratik sınırlamadır.\r\n				Homomorfik şifreleme şemaları doğası gereği şekillendirilebilir . İşlenebilirlik açısından, homomorfik şifreleme şemaları,\r\n				homomorfik olmayan şemalara göre daha zayıf güvenlik özelliklerine sahiptir.", true, "Homomorfik Wiki Açıklama" },
                    { 112, 112, "\"Homomorfik şifreleme, verilerin gizliliğini koruyarak aynı zamanda şifreli biçimde işlenmelerine olanak tanıyan bir kriptografik ilerlemedir, bu da güvenli veri analizi ve işleme için önemli bir çığır açmaktadır.\"", true, "Homomorfik Wiki Açıklama" },
                    { 113, 113, "Homomorfik şifreleme kavramı, modern kriptografi araştırmalarının bir sonucu olarak ortaya çıkmıştır. İlk homomorfik şifreleme protokolü, 1978 yılında Ron Rivest, Adi Shamir ve Leonard Adleman (RSA olarak da bilinir) tarafından geliştirilen RSA şifrelemesinden birkaç yıl sonra ortaya çıktı.\r\n\r\n				Ancak, tam homomorfik şifreleme protokolü ilk kez 2009 yılında Craig Gentry tarafından tanıtıldı. Gentry'nin çalışması, matematiksel olarak karmaşık bir yapı kullanarak, şifreli veriler üzerinde toplama ve çarpma işlemlerini gerçekleştirebilecek bir protokol sunuyordu. Bu, veri gizliliği açısından devrim niteliğinde bir adımdı, çünkü daha önce, şifreli veriler üzerinde işlem yapmak, genellikle verinin şifresini çözmeyi gerektirirdi.", true, "Tarihçe" },
                    { 114, 114, "Gentry'nin çalışması, homomorfik şifrelemenin potansiyelini gösterdi, ancak pratikte kullanılabilirliği sınırlıydı çünkü hesaplama maliyeti oldukça yüksekti. Ancak, daha sonraki yıllarda, araştırmacılar homomorfik şifreleme protokollerini iyileştirmek ve daha etkili hale getirmek için çeşitli yaklaşımlar geliştirdiler.\r\n\r\n				2013 yılında, Gentry ve Zvika Brakerski, daha etkili ve kullanılabilir bir kısmi homomorfik şifreleme protokolü tanıttılar. Bu protokol, işlemlerin sayısını ve hesaplama maliyetini azaltarak daha pratik bir kullanım sağladı.", true, "Tarihçe" },
                    { 115, 115, "Tamamen homomorfik bir şifreleme şeması oluşturma sorunu ilk olarak 1978'de, RSA şemasının yayınlanmasından sonraki bir yıl içinde önerildi. 30 yılı aşkın süredir bir çözümün var olup olmadığı belirsizdi. Bu dönemde kısmi sonuçlar aşağıdaki şemaları içeriyordu:", true, "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)" },
                    { 116, 116, "RSA şifreleme sistemi (sınırsız sayıda modüler çarpma)", true, "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)" },
                    { 117, 117, "ElGamal şifreleme sistemi (sınırsız sayıda modüler çarpma)", true, "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)" },
                    { 118, 118, "Boneh – Goh – Nissim kripto sistemi (sınırsız sayıda toplama işlemi ancak en fazla bir çarpma)", true, "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)" },
                    { 119, 119, "Goldwasser – Micali şifreleme sistemi (sınırsız sayıda özel veya işlem)", true, "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)" },
                    { 120, 120, "Sander-Young-Yung sistemi (20 yıldan fazla bir süre sonra logaritmik derinlik devreleri sorununu çözdü)", true, "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)" },
                    { 121, 121, "Benaloh şifreleme sistemi (sınırsız sayıda modüler ekleme)", true, "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)" },
                    { 122, 122, "Ishai-Paskin şifreleme sistemi (polinom boyutunda dallanma programları)", true, "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)" },
                    { 123, 123, "Paillier şifreleme sistemi (sınırsız sayıda modüler ekleme)", true, "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)" },
                    { 124, 124, "Homomorfik şifreleme alanı hala aktif olarak araştırılmaktadır ve gelecekte daha gelişmiş ve etkili protokollerin ortaya çıkması muhtemeldir. Bu teknolojinin, gizlilik odaklı uygulamalarda ve bulut bilişim gibi alanlarda daha yaygın olarak kullanılması beklenmektedir.", true, "FHE, Tam Homomorfik Şifreleme (Fully Homomorphic Encryption)" },
                    { 125, 125, "\"Homomorfik, cebirdeki homomorfizmi ifade eder : şifreleme ve şifre çözme fonksiyonları, düz metin ve şifreli metin uzayları arasındaki homomorfizmler olarak düşünülebilir.\"", true, "blockquote" },
                    { 126, 126, "Homomorfik şifreleme, şifreli veriler üzerinde matematiksel işlemler yapmayı mümkün kılan bir kriptografik tekniktir. Bu teknik, çeşitli kullanım senaryolarında çeşitli avantajlar sağlar. İşte homomorfik şifreleme ile yapılabilecek bazı şeyler:", true, "Homomorfik şifreleme ile neler yapılabilir?" },
                    { 127, 127, "Veritabanları veya bulut tabanlı hizmetlerdeki hassas veriler, homomorfik şifreleme ile şifrelenerek işlenebilir.\r\n					Örneğin, bir bulut hizmet sağlayıcısı, şifreli veriler üzerinde hesaplamalar yapabilir ve sonuçları müşterilere geri gönderebilir,\r\n					ancak verilerin içeriğine erişim sağlayamaz.", true, "Koruma:" },
                    { 128, 128, "Homomorfik şifreleme, verilerin gizliliğini korurken bulutta güvenli hesaplamalar yapmayı mümkün kılar. Bu, kişisel veya hassas verilerin güvenli bir şekilde işlenmesini sağlar.", true, "Gizlilik Korunarak Hesaplama Yapma:" },
                    { 129, 129, "Hastane kayıtları gibi özel sağlık verileri, homomorfik şifreleme kullanılarak güvenli bir şekilde işlenebilir. Bu sayede, sağlık hizmeti sağlayıcıları,\r\n					hastaların verileri üzerinde analizler yapabilirken verilerin gizliliği korunmuş olur.", true, "Sağlık Sektörü:" },
                    { 130, 130, "Homomorfik şifreleme, şifreli veriler üzerinde analiz ve madencilik yapılmasını mümkün kılar. Örneğin, bir bulutta depolanan ve homomorfik olarak şifrelenmiş sağlık verileri üzerinde analiz yapılabilir, ancak verilerin gizliliği korunur.", true, "Veri Analitiği ve Veri Madenciliği:" },
                    { 131, 131, "Homomorfik şifreleme, verilerin dış kaynaklara güvenli bir şekilde aktarılmasını sağlar. Bu, hassas verilerin bulut ortamlarında depolanmasını veya üçüncü taraf hizmet sağlayıcılarına aktarılmasını mümkün kılar.", true, "Outsourcing ve Veri Depolama:" },
                    { 132, 132, "Homomorfik şifreleme, verilerin güvenli bir şekilde paylaşılmasını sağlar. Örneğin, farklı kurumlar veya kullanıcılar arasında hassas verilerin paylaşılması gerektiğinde, bu veriler homomorfik olarak şifrelenebilir ve güvenli bir şekilde paylaşılabilir.", true, "Güvenli Veri Paylaşımı:" },
                    { 133, 133, "Homomorfik şifreleme, veri sahiplerinin verilerini paylaşma konusundaki endişelerini azaltır. Bu, veri analizine katılımı teşvik eder ve daha geniş veri setlerinin kullanılmasını sağlar.", true, "Veri Analizine Katılımı Teşvik Etmek:" },
                    { 134, 134, "Finansal veriler, müşteri bilgileri veya finansal işlemler, homomorfik şifreleme ile güvence altına alınabilir. Bu sayede, finansal analizler yapılabilirken müşteri gizliliği korunabilir.", true, "Finansal Hizmetler:" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Example");

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 134);

            migrationBuilder.UpdateData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 100,
                columns: new[] { "ParagraphContent", "ParagraphTitle" },
                values: new object[] { "blablablabla", "Homomorfik Wiki" });

            migrationBuilder.UpdateData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 101,
                columns: new[] { "ParagraphContent", "ParagraphTitle" },
                values: new object[] { "Lorem Ipsum is simply dummy text of the printing and typesetting industry", "homo" });
        }
    }
}
