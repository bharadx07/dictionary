using System;
using System.Linq;
using Newtonsoft.Json; //Modules with nuget


namespace Csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Chipher chipher = new Chipher();

            string encrypted = chipher.encrypt("Prakash");

            Console.WriteLine(encrypted);

            string decrypted = chipher.decrypt(encrypted);

            Console.WriteLine(decrypted);

            var value = JsonConvert.DeserializeObject("{}");
        }
    }

    //Classes
    class Chipher
    {
        const string INSERTION_KEY = "dfskjljjjljljljljljljljljljljljljljljljljljljljljlj9er92038fidsusmfkk3^67fjakkleulutiosdfnlasf"; //Combo of js var defs (const, let, var) and java type defs

        public string encrypt(string plaintext)
        {
            return string.Join("", plaintext.Select(c => c + INSERTION_KEY));
        }

        public string decrypt(string Chipher)
        {
            string decrypted = "";
            for (int i = 0; i < Chipher.Length; i += INSERTION_KEY.Length + 1)
            {
                decrypted += Chipher[i];
            }

            return decrypted;


        }
    }
}

