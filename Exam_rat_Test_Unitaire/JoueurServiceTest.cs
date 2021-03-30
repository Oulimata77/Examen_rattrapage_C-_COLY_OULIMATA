using Examen_rat.Model;
using Examen_rat.Services;
using NUnit.Framework;
using System;

namespace Exam_rat_Test_Unitaire
{
    public class JoueurServiceTest
    {
        JoueurService _testjoueur;
      
        [SetUp]
        public void Setup()
        {
            DemandeAUtilisateur dem = new DemandeAUtilisateur();
            this._testjoueur = new JoueurService(dem);
        }

        [Test]
        public void AfficheJoueurTest()
        {
            var Aff = _testjoueur.creerJoueur();
            var list = "Nom:sall,prenom : Paul, classement: 1\n Nom:Faye,prenom : Joseph, classement: 2\n Nom:Mendy,prenom : Pascal, classement: 3\n";
           
            Assert.AreEqual(list, Aff);
        }
        [Test]
        public void CreerJoueurTest()
        {
            Joueur j = new Joueur();
            j.Nom= "Paul";
            j.prenom = "Joseph";
            j.classement = 1;
            _testjoueur.AddJoueur(j);

            j = new Joueur();
            j.Nom = "Faye";
            j.prenom = "Fatou";
            j.classement = 2;
            _testjoueur.AddJoueur(j);

            j = new Joueur();
            
            j.Nom = "Portales";
            j.prenom = "Chacha";
            j.classement = 3;
            _testjoueur.AddJoueur(j);
           
            string message = _testjoueur.TrouvJoueur();
            string expected = "Nom:Juli,prenom:Joseph,classement :1\n ,Nom=Faye ,prenom:Julie,classement:2\n,Nom=Sall ,prenom:Charlotte,classement:3\n";
            Assert.AreEqual(expected, message);

        }
        [Test]
        public void CreerJoueurTestNull()
        {
            _testjoueur.AddJoueur(null);
            try
            {
                string message = _testjoueur.CreerJoueur();
                Assert.Fail("Creer message aurait du planter");
            }
            catch (Exception e)
            {
                e = null;
                Assert.Pass();
            }
        }
        [Test]
        public void SuppJoueurTestNull()
        {
            _testjoueur.SupJoueur(null);
            try
            {
                string message = _testjoueur.SupprimJoueur();
                Assert.Fail("Creer message aurait du planter");
            }
            catch (Exception e)
            {
                e = null;
                Assert.Pass();
            }
        }

    }
}