using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace adminPanel
{

    public class Hasher
    {
        public string PassordHasher(string passord)
        {
            //Generer saltet
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            //Hasher og salt med hjelp av Rfc2898
            var passordHash = new Rfc2898DeriveBytes(passord, salt, 10000);
            //Plasserer stringen inn i byte-arrayet(Det er det getBytes gjør)
            byte[] hash = passordHash.GetBytes(20);
            //Lager et nytt bytearray hvor saltet og passordet er lagret
            //Den er satt til 36 fordi saltet er 16 og passordeter 20
            byte[] hashBytes = new byte[36];
            //Plasserer saltet og hashet på riktige indexer i hashBytes
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            //Helt til slutt konverteres bytearrayet til string
            string lagretPassordHash = Convert.ToBase64String(hashBytes);
            //Returnerer det hashede passordet tilbake.
            return lagretPassordHash;
        }

        public bool SjekkHash(string passord, string hash)
        {
            //Konverterer til bytes
            byte[] hashBytes = Convert.FromBase64String(hash);
            //Tar saltet ut fra stringen
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            //Hasher passordet fra brukerern sammen med saltet
            var passordHash = new Rfc2898DeriveBytes(passord, salt, 10000);
            //putter hashet inn i et bytearray så vi kan sjekket det byte for byte
            byte[] hasher = passordHash.GetBytes(20);
            int ok = 1;
            //Vi starter fra 16 fordi 0-15 er saltet
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i+16] != hasher[i])
                {
                    ok = 0;
                    return false;
                }
            }
            //hvis det ikk er noen forskjell på strengene returnerer vi true
            if (ok == 1)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
