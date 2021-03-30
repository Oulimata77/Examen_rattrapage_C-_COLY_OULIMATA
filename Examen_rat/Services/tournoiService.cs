using System;
using System.Collections.Generic;
using System.Text;
using Examen_rat.Model;
namespace Examen_rat.Services
{
    public class tournoiService
    {
        private static DemandeAUtilisateur _DemandeAUtlisateur;
        private static JoueurService _JoueurService;
      
        private List<tournoi> ListTournois = new List<tournoi>();

        public tournoiService(DemandeAUtilisateur _demandeAUtlisateur, JoueurService _joueurService)
        {
            _DemandeAUtlisateur = _demandeAUtlisateur;
            _JoueurService = _joueurService;
        }
        public void affichetournoi()
        {
            Console.WriteLine("liste des tournois");
            foreach (tournoi t in ListTournois)
            {
                Console.WriteLine("Nom du tournoi :" + t.nom);
                Console.WriteLine("Vainqueur:" + t.vainqueur.nom + "" + t.vainqueur.prenom);



            }

        }

        public string Addtournoi()
        {
            throw new NotImplementedException();
        }

        public void creerTournoi()
        {
            tournoi t = new tournoi();
            int cvainqueur;
            t.nom = _DemandeAUtlisateur.Demandestring("Nom du tournoi");
            cvainqueur = _DemandeAUtlisateur.DemandeEntier("classement du vainqueur");
            t.vainqueur = _JoueurService.TrouvJoueur(cvainqueur);
            ListTournois.Add(t);
        }
        public tournoi Touvtournoi(string rnom)
        {
            tournoi t = new tournoi();
            foreach (tournoi js in ListTournois)
            {
                if (js.nom == rnom)
                {
                    t = js;

                    break;
                }

            }
            return t;
        }
        public void Addtournoi(tournoi t)
        {
            ListTournois.Add(t);
        }
        public void SupprimTournoi()
        {
            tournoi t = new tournoi();
            string classSup;
            classSup = _DemandeAUtlisateur.Demandestring("Le classement que vous voulez supprimer");

            t = Touvtournoi(classSup);
            ListTournois.Remove(t);

        }
        public void AfficheUNtournoi(tournoi t)
        {
            Console.WriteLine("Nom du tournoi :" + t.nom);
            Console.WriteLine("Vainqueur:" + t.vainqueur.nom + "" + t.vainqueur.prenom);
            Console.WriteLine("\n");


        }

    public void Modiftournoi()
        {

            tournoi t = new tournoi();

            string Modiftour = _DemandeAUtlisateur.Demandestring("Le nom du tournoi que vous voulez");

            t = Touvtournoi(Modiftour);

            ListTournois.Remove(t);
            AfficheUNtournoi(t);

            Console.WriteLine("Le tournoi modifié ");

            creerTournoi();
        }

    }
}
   