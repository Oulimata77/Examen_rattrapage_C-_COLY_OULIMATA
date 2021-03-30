using System;
using Examen_rat.Model;
using Examen_rat.Services;

namespace Examen_rat
{
    class Program
    {
        private static DemandeAUtilisateur _DemandeAUtlisateur = new DemandeAUtilisateur();
        private static JoueurService _JoueurService = new JoueurService(_DemandeAUtlisateur);
        private static tournoiService _tournoiService = new tournoiService(_DemandeAUtlisateur , _JoueurService);
        static void Main(string[] args)
        {
            while (true)
            {
                string choixUtil = MenuUtil();
                if (choixUtil=="1")
                {
                    Console.WriteLine("Listes des joueurs:\n");
                    _JoueurService.afficheJoueur();
                }
                else if (choixUtil == "2")
                {
                    Console.WriteLine("Listes des tournois:\n");
                    _tournoiService.affichetournoi();
                    
                }
                 else if(choixUtil == "3")
                {
                    Console.WriteLine("..................Creation du joueur...............\n");
                    _JoueurService.creerJoueur();
                }
                 else if (choixUtil == "4")
                {
                    Console.WriteLine("..................Creation du tournoi...............\n");
                    _tournoiService.creerTournoi();
                    
                }
                else if (choixUtil == "5")
                {
                    Console.WriteLine("..................Modification du joueur...............\n");
                    _JoueurService.ModifJoueur();
                    
                }

                else if (choixUtil == "6")
                {
                    Console.WriteLine("..................Modification du tournoi...............\n");
                    _tournoiService.Modiftournoi();
                    
                }
                else if (choixUtil == "7")
                {
                    Console.WriteLine("..................Supprimer d'un joueur...............\n");
                    _JoueurService.SupprimJoueur();
                }
                else if (choixUtil == "8")
                {
                    Console.WriteLine("..................Supprimer d'un tournoi...............\n");
                    _tournoiService.SupprimTournoi();
                }
                else if (choixUtil == "Q"|| choixUtil=="q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Je n'ai pas compris");
                }
                
            }
        }
        private static string MenuUtil()
            {
            Console.WriteLine("BIENVENUE DANS L'APPLICATION DE GESTION DES JOUEURS TENNIS ET DES TOURNOIS\n");
            Console.WriteLine("1.Afficher les joueurs\n");
            Console.WriteLine("2.Afficher les tournoi\n");
            Console.WriteLine("3.Ajouter un joueur\n");
            Console.WriteLine("4.Ajouter un tournoi\n");
            Console.WriteLine("5.Modifier un joueur\n");
            Console.WriteLine("6.Modifier un tournoi\n");
            Console.WriteLine("7.Supprimer un joueur\n");
            Console.WriteLine("8.Supprimer un tournoi\n");
            Console.WriteLine("Q.Pour quitter");
            string choixUtil = _DemandeAUtlisateur.Demandestring("");
            return choixUtil;



        }
    }
}
