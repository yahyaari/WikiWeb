using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutUsDanısman",
                table: "AboutUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutUsFakulteBolum",
                table: "AboutUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutUsIsım",
                table: "AboutUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutUsNumara",
                table: "AboutUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutUsUniversite",
                table: "AboutUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "AboutUsId",
                keyValue: 1,
                columns: new[] { "AboutUsContent", "AboutUsDanısman", "AboutUsFakulteBolum", "AboutUsIsım", "AboutUsNumara", "AboutUsUniversite" },
                values: new object[] { "Homomorfik Şifreleme'nin Anlatıldığı Wiki Web Sayfası", "Dr. Öğr. Üyesi Ahmet ALBAYRAK", "Teknoloji Fakültesi Bilgisayar Mühendisliği", "Ali Berdan Karasoy", "182120015", "Düzce Üniversitesi" });

            migrationBuilder.InsertData(
                table: "AboutUs",
                columns: new[] { "AboutUsId", "AboutUsContent", "AboutUsDanısman", "AboutUsFakulteBolum", "AboutUsIsım", "AboutUsNumara", "AboutUsUniversite" },
                values: new object[] { 2, "Homomorfik Şifreleme'nin Anlatıldığı Wiki Web Sayfası", "Dr. Öğr. Üyesi Ahmet ALBAYRAK", "Teknoloji Fakültesi Bilgisayar Mühendisliği", "Yahya Arı", "182120004", "Düzce Üniversitesi" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryDescription", "CategoryName", "CategoryStatus" },
                values: new object[] { 135, "İçerik", "Paragraph", true });

            migrationBuilder.UpdateData(
                table: "Example",
                keyColumn: "ExampleId",
                keyValue: 1,
                column: "ExampleContent",
                value: " using System;\r\n				using Microsoft.Research.SEAL;\r\n				namespace HomomorphicEncryptionExample {\r\n				class Program {\r\n				static void Main(string[] args) {\r\n				// SEAL kütüphanesini kullanarak homomorfik şifreleme örneği\r\n				// Parametrelerin oluşturulması\r\n				EncryptionParameters parms = new EncryptionParameters(SchemeType.BFV);\r\n				parms.PolyModulusDegree = 4096;\r\n				parms.CoeffModulus = CoeffModulus.BFVDefault(polyModulusDegree: 4096);\r\n				parms.PlainModulus = new Modulus(40961);\r\n				using(SEALContext context = new SEALContext(parms))\r\n				{\r\n				// Anahtar çiftlerinin oluşturulması\r\n				KeyGenerator keygen = new KeyGenerator(context);\r\n				PublicKey publicKey = keygen.PublicKey;\r\n				SecretKey secretKey = keygen.SecretKey;\r\n				// Encryptor ve Decryptor'ların oluşturulması\r\n				Encryptor encryptor = new Encryptor(context, publicKey);\r\n				Decryptor decryptor = new Decryptor(context, secretKey);\r\n				// Verinin şifrelenmesi\r\n				Plaintext plainText = new Plaintext(\"42\");\r\n				Console.WriteLine(\"Original: \" + plainText.ToString());\r\n				Ciphertext encryptedData = new Ciphertext();\r\n				encryptor.Encrypt(plainText, encryptedData);\r\n				Console.WriteLine(\"Encrypted: \" + encryptedData.ToString());\r\n				// Verinin şifresinin çözülmesi\r\n				Plaintext decryptedData = new Plaintext();\r\n				decryptor.Decrypt(encryptedData, decryptedData);\r\n				Console.WriteLine(\"Decrypted: \" + decryptedData.ToString());\r\n				}\r\n				}\r\n				}\r\n				}");

            migrationBuilder.UpdateData(
                table: "Example",
                keyColumn: "ExampleId",
                keyValue: 2,
                column: "ExampleContent",
                value: " import com.n1analytics.paillier.*;\r\n				public class HomomorphicEncryptionExample {\r\n				public static void main(String[] args) {\r\n				try {\r\n				// Paillier anahtar çiftlerini oluştur\r\n				PaillierPrivateKey privateKey = PaillierPrivateKey.create(2048);\r\n				PaillierPublicKey publicKey = privateKey.getPublicKey();\r\n				// Şifrelenecek sayıları oluştur\r\n				long plaintext1 = 42;\r\n				long plaintext2 = 15;\r\n				// Sayıları şifrele\r\n				Ciphertext ciphertext1 = publicKey.encrypt(plaintext1);\r\n				Ciphertext ciphertext2 = publicKey.encrypt(plaintext2);\r\n				// Şifreli sayıları topla\r\n				Ciphertext sumCiphertext = ciphertext1.add(ciphertext2);\r\n				// Toplamı çöz\r\n				long decryptedSum = privateKey.decrypt(sumCiphertext).longValue();\r\n				// Sonuçları ekrana yazdır\r\n				System.out.println(\"Plaintext 1: \" + plaintext1);\r\n				System.out.println(\"Plaintext 2: \" + plaintext2);\r\n				System.out.println(\"Encrypted 1: \" + ciphertext1.toString());\r\n				System.out.println(\"Encrypted 2: \" + ciphertext2.toString());\r\n				System.out.println(\"Sum (Encrypted): \" + sumCiphertext.toString());\r\n				System.out.println(\"Decrypted Sum: \" + decryptedSum);\r\n				} catch (PaillierException e) {\r\n				 e.printStackTrace();\r\n				 }\r\n				}\r\n				}");

            migrationBuilder.UpdateData(
                table: "Example",
                keyColumn: "ExampleId",
                keyValue: 3,
                column: "ExampleContent",
                value: "var csharpCode3 = `\r\n				from seal import *\r\n				def main():\r\n				# SEALContext ve Encoder'ın oluşturulması\r\n				parms = EncryptionParameters(scheme_type.BFV)\r\n				parms.set_poly_modulus_degree(4096)\r\n				parms.set_coeff_modulus(CoeffModulus.BFVDefault(4096))\r\n				parms.set_plain_modulus(PlainModulus(40961))\r\n				context = SEALContext(parms)\r\n				encoder = IntegerEncoder(context)\r\n				# Anahtar çiftlerinin oluşturulması\r\n				keygen = KeyGenerator(context)\r\n				public_key = keygen.public_key()\r\n				secret_key = keygen.secret_key()\r\n				# Encryptor ve Decryptor'ların oluşturulması\r\n				 encryptor = Encryptor(context, public_key)\r\n				decryptor = Decryptor(context, secret_key)\r\n				# Verinin şifrelenmesi\r\n				plain_text_1 = 42\r\n				plain_text_2 = 15\r\n				encrypted_data_1 = Ciphertext()\r\n				encrypted_data_2 = Ciphertext()\r\n				encryptor.encrypt(encoder.encode(plain_text_1), encrypted_data_1)\r\n				encryptor.encrypt(encoder.encode(plain_text_2), encrypted_data_2)\r\n				# Şifreli sayıların toplanması\r\n				encrypted_sum = Ciphertext()\r\n				evaluator = Evaluator(context)\r\n				evaluator.add(encrypted_data_1, encrypted_data_2, encrypted_sum)\r\n				# Şifreli toplamın çözülmesi\r\n				 decrypted_sum = Plaintext()\r\n				 decryptor.decrypt(encrypted_sum, decrypted_sum)\r\n				 # Sonuçların ekrana yazdırılması\r\n				print(\"Plaintext 1:\", plain_text_1)\r\n				  print(\"Plaintext 2:\", plain_text_2)\r\n				   print(\"Encrypted 1:\", encrypted_data_1.to_string())\r\n				   print(\"Encrypted 2:\", encrypted_data_2.to_string())\r\n				 print(\"Encrypted Sum:\", encrypted_sum.to_string())\r\n				 print(\"Decrypted Sum:\", encoder.decode_int64(decrypted_sum))\r\n				if _name_ == '_main_':\r\n				    main()\r\n				`;");

            migrationBuilder.InsertData(
                table: "Paragraphs",
                columns: new[] { "ParagraphID", "CategoryID", "ParagraphContent", "ParagraphStatus", "ParagraphTitle" },
                values: new object[] { 135, 135, "Homomorfik şifreleme, veri işleme ihtiyacını ortadan kaldırarak, verilerin güvenliğini artırır. Böylelikle, verilerin güvenliği için endişe duyan kurumlar ve kullanıcılar, verilerini şifreleyerek dış kaynaklara güvenle aktarabilirler.", true, "Açıklama" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AboutUs",
                keyColumn: "AboutUsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 135);

            migrationBuilder.DropColumn(
                name: "AboutUsDanısman",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "AboutUsFakulteBolum",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "AboutUsIsım",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "AboutUsNumara",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "AboutUsUniversite",
                table: "AboutUs");

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "AboutUsId",
                keyValue: 1,
                column: "AboutUsContent",
                value: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");

            migrationBuilder.UpdateData(
                table: "Example",
                keyColumn: "ExampleId",
                keyValue: 1,
                column: "ExampleContent",
                value: " using System;\r\n            using Microsoft.Research.SEAL;\r\n\r\n            namespace HomomorphicEncryptionExample {\r\n                class Program {\r\n                    static void Main(string[] args) {\r\n                        // SEAL kütüphanesini kullanarak homomorfik şifreleme örneği\r\n\r\n                        // Parametrelerin oluşturulması\r\n                        EncryptionParameters parms = new EncryptionParameters(SchemeType.BFV);\r\n                        parms.PolyModulusDegree = 4096;\r\n                        parms.CoeffModulus = CoeffModulus.BFVDefault(polyModulusDegree: 4096);\r\n                        parms.PlainModulus = new Modulus(40961);\r\n\r\n                        using(SEALContext context = new SEALContext(parms))\r\n                        {\r\n                            // Anahtar çiftlerinin oluşturulması\r\n                            KeyGenerator keygen = new KeyGenerator(context);\r\n                            PublicKey publicKey = keygen.PublicKey;\r\n                            SecretKey secretKey = keygen.SecretKey;\r\n\r\n                            // Encryptor ve Decryptor'ların oluşturulması\r\n                            Encryptor encryptor = new Encryptor(context, publicKey);\r\n                            Decryptor decryptor = new Decryptor(context, secretKey);\r\n\r\n                            // Verinin şifrelenmesi\r\n                            Plaintext plainText = new Plaintext(\"42\");\r\n                            Console.WriteLine(\"Original: \" + plainText.ToString());\r\n\r\n                            Ciphertext encryptedData = new Ciphertext();\r\n                            encryptor.Encrypt(plainText, encryptedData);\r\n                            Console.WriteLine(\"Encrypted: \" + encryptedData.ToString());\r\n\r\n                            // Verinin şifresinin çözülmesi\r\n                            Plaintext decryptedData = new Plaintext();\r\n                            decryptor.Decrypt(encryptedData, decryptedData);\r\n                            Console.WriteLine(\"Decrypted: \" + decryptedData.ToString());\r\n                        }\r\n                    }\r\n                }\r\n            }");

            migrationBuilder.UpdateData(
                table: "Example",
                keyColumn: "ExampleId",
                keyValue: 2,
                column: "ExampleContent",
                value: " import com.n1analytics.paillier.*;\r\n\r\n            public class HomomorphicEncryptionExample {\r\n                public static void main(String[] args) {\r\n                    try {\r\n                        // Paillier anahtar çiftlerini oluştur\r\n                        PaillierPrivateKey privateKey = PaillierPrivateKey.create(2048);\r\n                        PaillierPublicKey publicKey = privateKey.getPublicKey();\r\n\r\n                        // Şifrelenecek sayıları oluştur\r\n                        long plaintext1 = 42;\r\n                        long plaintext2 = 15;\r\n\r\n                        // Sayıları şifrele\r\n                        Ciphertext ciphertext1 = publicKey.encrypt(plaintext1);\r\n                        Ciphertext ciphertext2 = publicKey.encrypt(plaintext2);\r\n\r\n                        // Şifreli sayıları topla\r\n                        Ciphertext sumCiphertext = ciphertext1.add(ciphertext2);\r\n\r\n                        // Toplamı çöz\r\n                        long decryptedSum = privateKey.decrypt(sumCiphertext).longValue();\r\n\r\n                        // Sonuçları ekrana yazdır\r\n                        System.out.println(\"Plaintext 1: \" + plaintext1);\r\n                        System.out.println(\"Plaintext 2: \" + plaintext2);\r\n                        System.out.println(\"Encrypted 1: \" + ciphertext1.toString());\r\n                        System.out.println(\"Encrypted 2: \" + ciphertext2.toString());\r\n                        System.out.println(\"Sum (Encrypted): \" + sumCiphertext.toString());\r\n                        System.out.println(\"Decrypted Sum: \" + decryptedSum);\r\n\r\n                    } catch (PaillierException e) {\r\n                        e.printStackTrace();\r\n                    }\r\n                }\r\n            }");

            migrationBuilder.UpdateData(
                table: "Example",
                keyColumn: "ExampleId",
                keyValue: 3,
                column: "ExampleContent",
                value: "from seal import *\r\n\r\n            def main():\r\n                # SEALContext ve Encoder'ın oluşturulması\r\n                parms = EncryptionParameters(scheme_type.BFV)\r\n                parms.set_poly_modulus_degree(4096)\r\n                parms.set_coeff_modulus(CoeffModulus.BFVDefault(4096))\r\n                parms.set_plain_modulus(PlainModulus(40961))\r\n\r\n                context = SEALContext(parms)\r\n                encoder = IntegerEncoder(context)\r\n\r\n                # Anahtar çiftlerinin oluşturulması\r\n                keygen = KeyGenerator(context)\r\n                public_key = keygen.public_key()\r\n                secret_key = keygen.secret_key()\r\n\r\n                # Encryptor ve Decryptor'ların oluşturulması\r\n                encryptor = Encryptor(context, public_key)\r\n                decryptor = Decryptor(context, secret_key)\r\n\r\n                # Verinin şifrelenmesi\r\n                plain_text_1 = 42\r\n                plain_text_2 = 15\r\n\r\n                encrypted_data_1 = Ciphertext()\r\n                encrypted_data_2 = Ciphertext()\r\n\r\n                encryptor.encrypt(encoder.encode(plain_text_1), encrypted_data_1)\r\n                encryptor.encrypt(encoder.encode(plain_text_2), encrypted_data_2)\r\n\r\n                # Şifreli sayıların toplanması\r\n                encrypted_sum = Ciphertext()\r\n                evaluator = Evaluator(context)\r\n                evaluator.add(encrypted_data_1, encrypted_data_2, encrypted_sum)\r\n\r\n                # Şifreli toplamın çözülmesi\r\n                decrypted_sum = Plaintext()\r\n                decryptor.decrypt(encrypted_sum, decrypted_sum)\r\n\r\n                # Sonuçların ekrana yazdırılması\r\n                print(\"Plaintext 1:\", plain_text_1)\r\n                print(\"Plaintext 2:\", plain_text_2)\r\n                print(\"Encrypted 1:\", encrypted_data_1.to_string())\r\n                print(\"Encrypted 2:\", encrypted_data_2.to_string())\r\n                print(\"Encrypted Sum:\", encrypted_sum.to_string())\r\n                print(\"Decrypted Sum:\", encoder.decode_int64(decrypted_sum))\r\n\r\n            if __name__ == '__main__':\r\n                main()");
        }
    }
}
