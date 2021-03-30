using Examen_rat.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_rat.Services
{
   
   public class JoueurService
    {
        private static DemandeAUtilisateur _DemandeAUtlisateur;
        private List<Joueur> ListJoueurs = new List<Joueur>();

        public JoueurService(DemandeAUtilisateur demandeAUtlisateur)
        {
            _DemandeAUtlisateur = demandeAUtlisateur;
        }
        public void afficheJoueur()
        {
            foreach(Joueur j in ListJoueurs)
            {
                Console.WriteLine("Nom:" + j.nom);
                Console.WriteLine("Prenom:" + j.prenom);

                Console.WriteLine("Classement:" + j.classement);
                Console.WriteLine("\n");

            }
        }
        public void afficheunJoueur(Joueur j)
        {
              Console.WriteLine("Nom:" + j.nom);
                Console.WriteLine("Prenom:" + j.prenom);

                Console.WriteLine("Classement:" + j.classement);
                Console.WriteLine("\n");

           
        }
        public void AddJoueur(Joueur j)
        {
            ListJoueurs.Add(j);
        }
        public void SupJoueur(Joueur j)
        {
            ListJoueurs.Remove(j);
        }
        public Joueur creerJoueur()
        {
            Joueur j = new Joueur();
            j.nom = _DemandeAUtlisateur.Demandestring("Nom du joueur");
            j.prenom = _DemandeAUtlisateur.Demandestring("Prenom du joueur");
            j.classement = _DemandeAUtlisateur.DemandeEntier("Classement");
            Console.WriteLine("\n");

            ListJoueurs.Add(j);
            return j;

        }

        public string TrouvJoueur()
        {
            throw new NotImplementedException();
        }

        public void SupprimJoueur()
        {
            Joueur j = new Joueur();
            int classSup = _DemandeAUtlisateur.DemandeEntier("Le classement que vous voulez supprimer");
            j = TrouvJoueur(classSup);
                     ListJoueurs.Remove(j);

        }

        public string CreerJoueur()
        {
            throw new NotImplementedException();
        }

        public void ModifJoueur()
        {
            int classSup = _DemandeAUtlisateur.DemandeEntier("Le classement que vous voulez modifier");
            Joueur j = new Joueur();
            j = TrouvJoueur(classSup);
            
                    ListJoueurs.Remove(j);
                 
            afficheunJoueur(j);
            Console.WriteLine("\n");

            creerJoueur();

        }

        public Joueur TrouvJoueur(int Trouv)
        {
            Joueur j1 = new Joueur();
            foreach (Joueur jt in ListJoueurs)
            {
                if (jt.classement == Trouv)
                {
                    j1 = jt;
                    
                    break;
                }
                
            }
            return j1;
        }
    }
}
