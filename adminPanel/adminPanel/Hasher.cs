using System;
using System.Security.Cryptography;

namespace adminPanel
{
    // En egen klassen til å hashe passordet
    public class Hasher
    {
        public string PassordHasher(string passord)
        {
            // Generer saltet
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            // Hasher og salt med hjelp av Rfc2898
            var passordHash = new Rfc2898DeriveBytes(passord, salt, 10000);

            // Plasserer stringen inn i byte-arrayet ved hjelp av GetBytes().
            byte[] hash = passordHash.GetBytes(20);

            /* Lager et nytt bytearray hvor saltet og passordet skal bli lagret.
             * Lengden er satt til 36 fordi saltet sin lengde er 16 og 
             * passordet har en lengde på 20.
            */
            byte[] hashBytes = new byte[36];

            // Plasserer saltet og hashet på riktige indexer i hashBytes.
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // Helt til slutt konverteres bytearrayet til string.
            string lagretPassordHash = Convert.ToBase64String(hashBytes);

            // Returnerer det hashede passordet.
            return lagretPassordHash;
        }

        // Metode for å sjekke om passordet som skrives inn og hashet som er lagret i databasen er like.
        public bool SjekkHash(string passord, string hash)
        {
            // Konverterer det lagrede hashpassordet til bytes
            byte[] hashBytes = Convert.FromBase64String(hash);

            // Henter ut saltet fra arrayet hashbytes.
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Hasher passordet fra brukerern sammen med saltet
            var passordHash = new Rfc2898DeriveBytes(passord, salt, 10000);

            // Putter hashet inn i et bytearray så vi kan sjekket det byte for byte
            byte[] hasher = passordHash.GetBytes(20);

            /*
             * Sjekker hver byte opp mot hveandre.
             * Vi starter fra 16 fordi 0-15 er saltet
            */
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i+16] != hasher[i])
                {
                    return false;
                }
            }
            // Hvis det ikke er noen forskjell på strengene returnerer vi true
            return true;
        }
    }
}
