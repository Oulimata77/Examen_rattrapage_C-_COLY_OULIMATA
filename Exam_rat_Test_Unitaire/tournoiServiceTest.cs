using Examen_rat.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_rat_Test_Unitaire
{
    public class tournoiServiceTest
    {
        tournoiService _test;
        [SetUp]
        public void Setup()
        {
            DemandeAUtilisateur em = new DemandeAUtilisateur();
            //this._test = new tournoiService(em);
        }
        [Test]
        public void CreertournoiTestNull()
        {
            _test.Addtournoi(null);
            try
            {
                string message = _test.Addtournoi();
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
