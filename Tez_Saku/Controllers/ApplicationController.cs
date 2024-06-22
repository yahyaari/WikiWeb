using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Reflection;
using Microsoft.Research.SEAL;
using System.Security.Cryptography;
using DataAccessLayer.Concrete;
using System.Text;

namespace Homomorfik_Wiki.Controllers
{
    public class ApplicationController : Controller
    {
        private SEALContext context;
        private KeyGenerator keygen;
        private Encryptor encryptor;
        private Decryptor decryptor;

        // Index metodu, sayfanın başlangıç durumunu oluşturur.
        public IActionResult Index()
        {
            // Parametrelerin ayarlanması
            EncryptionParameters parms = new EncryptionParameters(SchemeType.BFV);
            parms.PolyModulusDegree = 4096;
            parms.CoeffModulus = CoeffModulus.BFVDefault(parms.PolyModulusDegree);
            parms.PlainModulus = new Modulus(256);

            // SEALContext oluştur
            context = new SEALContext(parms, true, SecLevelType.None);

            // Anahtar oluşturma
            keygen = new KeyGenerator(context);
            PublicKey publicKey;
            keygen.CreatePublicKey(out publicKey); // Genel anahtar oluşturuluyor
            SecretKey secretKey = keygen.SecretKey;

            // Şifreleme ve deşifreleme nesnelerini oluşturma
            encryptor = new Encryptor(context, publicKey);
            decryptor = new Decryptor(context, secretKey);

            return View();
        }
        // Ciphertext'i Base64 formatına kodlayan metot
        private string EncodeCiphertext(Ciphertext ciphertext)
        {
            using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
            {
                ciphertext.Save(stream);
                return Convert.ToBase64String(stream.ToArray());
            }
        }


        // Ciphertext'i deşifre eden metot
        private Plaintext DecryptCiphertext(Ciphertext ciphertext, Decryptor decryptor)
        {
            Plaintext plaintext = new Plaintext();
            decryptor.Decrypt(ciphertext, plaintext);
            return plaintext;
        }
        // Metin girişini şifreleyen HTTP Post metodu
        [HttpPost]
        [HttpPost]
        public IActionResult Encrypt(int myTextbox)
        {
            // Parametrelerin ayarlanması
            EncryptionParameters parms = new EncryptionParameters(SchemeType.BFV);
            parms.PolyModulusDegree = 4096;
            parms.CoeffModulus = CoeffModulus.BFVDefault(parms.PolyModulusDegree);
            parms.PlainModulus = new Modulus(256);

            // SEALContext oluştur
            SEALContext context = new SEALContext(parms, true, SecLevelType.None);

            // Anahtar oluşturma
            KeyGenerator keygen = new KeyGenerator(context);
            PublicKey publicKey;
            keygen.CreatePublicKey(out publicKey); // Genel anahtar oluşturuluyor
            SecretKey secretKey = keygen.SecretKey;

            // Şifreleme ve deşifreleme nesnelerini oluşturma
            Encryptor encryptor = new Encryptor(context, publicKey);
            Decryptor decryptor = new Decryptor(context, secretKey);

            // Kullanıcının girdiği değeri homomorfik olarak şifrele
            Ciphertext encryptedResult = HomomorphicEncryption(myTextbox, encryptor);

            // Şifrelenmiş sonucu ViewBag üzerinden Index view'ına aktar
            ViewBag.EncryptedResult = encryptedResult;

            return View("Index");
        }
        // Homomorfik şifreleme işlemini gerçekleştiren metot
        private Ciphertext HomomorphicEncryption(int value, Encryptor encryptor)
        {
            // İstenen veriyi şifrele
            Plaintext plain = new Plaintext(value.ToString());
            Ciphertext encrypted = new Ciphertext();
            encryptor.Encrypt(plain, encrypted);

            // Şifreli veriyi geri döndür
            return encrypted;
        }


        // HTTP Post metoduyla şifrelenmiş metni deşifre eden metot
        [HttpPost]
        public IActionResult Decrypt(string myEncryptedTextbox)
        {
            try
            {
                // Şifrelenmiş metni deşifre et
                string decryptedResult = DecryptEncryptedText(myEncryptedTextbox);

                // Deşifre edilmiş sonucu ViewBag üzerinden Index view'ına aktar
                ViewBag.DecryptedResult = decryptedResult;
            }
            catch (Exception ex)
            {
                // Hata durumunda hata mesajını ViewBag üzerinden Index view'ına aktar
                ViewBag.DecryptionError = "Deşifreleme işlemi başarısız oldu: " + ex.Message;
            }

            return View("Index");
        }
        // Şifrelenmiş metni deşifre eden metot
        private string DecryptEncryptedText(string encryptedText)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            using (System.IO.MemoryStream stream = new System.IO.MemoryStream(encryptedBytes))
            {
                Ciphertext ciphertext = new Ciphertext();
                ciphertext.Load(context, stream); // Burada context nesnesinin doğru şekilde ayarlandığından emin olun
                Plaintext plaintext = new Plaintext();
                decryptor.Decrypt(ciphertext, plaintext);
                return plaintext.ToString();
            }
        }


    }
}