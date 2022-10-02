using System;

namespace EncryptionDecryptionUsingSymmetricKey
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            Console.WriteLine("Please enter a string for encryption");
            var pass = Console.ReadLine();
            var encryptedString = AesOperation.EncryptString(key, pass);
            Console.WriteLine($"encrypted string = {encryptedString}");

            var decryptedString = AesOperation.DecryptString(key, encryptedString);
            Console.WriteLine($"decrypted string = {decryptedString}");

            Console.ReadKey();
        }
    }
}