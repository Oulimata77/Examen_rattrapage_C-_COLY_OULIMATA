using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_rat.Services
{
   public class DemandeAUtilisateur
    {
        public string Demandestring(string message) {
            Console.WriteLine(message);
            string Saisie = Console.ReadLine();
            while (string.IsNullOrEmpty(Saisie))
            {
                Console.WriteLine("saisi est correcte");
                Saisie = Console.ReadLine();
            }
            return Saisie;
        }
        public int DemandeEntier(string message)
        {
            Console.WriteLine(message);
            string b;
            b = Console.ReadLine();
            int intValue;
            while (!int.TryParse(b, out intValue))
            {
                Console.WriteLine("la saisie est incorrecte");
                b = Console.ReadLine();
            }
            return intValue;
        }
    }
}
