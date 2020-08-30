using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatisticaTest
{
    [TestClass]
    public class TestStatistica
    {
        [TestMethod]
        public void TestIsPositivo1()
        {
            int numero = 8;
            bool aspettata = true;
            bool valore = statisticaLibrary.statistica.IsPositivo(numero);
            Assert.AreEqual(aspettata, valore);
        }
        [TestMethod]
        public void TestIsPositivo2()
        {
            int numero = -1;
            bool aspettata = false;
            bool valore = statisticaLibrary.statistica.IsPositivo(numero);
            Assert.AreEqual(aspettata, valore);
        }
        [TestMethod]
        public void TestIsPositivo3()
        {
            int numero = 2;
            bool aspettata =true;
            bool valore = statisticaLibrary.statistica.IsPositivo(numero);
            Assert.AreEqual(aspettata, valore);
        }
        [TestMethod]
        public void TestIsPositivo4()
        {
            int numero = -4;
            bool aspettata = false;
            bool valore = statisticaLibrary.statistica.IsPositivo(numero);
            Assert.AreEqual(aspettata, valore);
        }

        [DataTestMethod]
        [DataRow(1, true)]
        [DataRow(-1, false)]
        [DataRow(4, true)]
        [DataRow(-6, false)]
        public void DataTestIsPositivoDataRow(int numero, bool aspettato)
        {
            bool valore = statisticaLibrary.statistica.IsPositivo(numero);
            Assert.AreEqual(aspettato, valore);
        }
        [TestMethod]
        public void TestContaPositivi1()
        {
            int[] valore = new int[] { -2, 3, -4, 6 };
            int aspettato = 2;
            int risposta = statisticaLibrary.statistica.ContaPositivi(valore);
            Assert.AreEqual(aspettato, risposta);
        }

        [TestMethod]
        public void TestContapositivi2()
        {
            int[] valore = new int[] { 1, -4, -6, 6, 2, -1 };
            int aspettato = 3;
            int risposta = statisticaLibrary.statistica.ContaPositivi(valore);
            Assert.AreEqual(aspettato, risposta);
        }

        [TestMethod]
        public void TestContaPositivi3()
        {
            int[] valore = new int[] { -2, 3, -4, -6 };
            int aspettato = 1;
            int risposta = statisticaLibrary.statistica.ContaPositivi(valore);
            Assert.AreEqual(aspettato, risposta);
        }

        [DataTestMethod]
        [DataRow(new int[] { -2, -6, 4, 3, 2 }, 3)]
        [DataRow(new int[] { -1, -2, 3, 2 }, 2)]
        [DataRow(new int[] { -1, 2, 5, -5, -8, -3,4,6 ,9 }, 5)]
        public void testContaPositivioDatarow(int[] valore, int aspettato)
        {
            int risposta = statisticaLibrary.statistica.ContaPositivi(valore);
            Assert.AreEqual(risposta, aspettato);
        }
        [TestMethod]
        public void TestPositivi1()
        {
            int[] valore = new int[] { -1, 2, -4, -3 };
            int[] aspettato = new int[] { 2 };
            int[] risposta =statisticaLibrary.statistica.Positivi(valore);
            CollectionAssert.AreEquivalent(aspettato, risposta);
        }
        [TestMethod]
        public void TestPositivi2()
        {
            int[] valore = new int[] { -2, -4, -6, 5, 8, -1 };
            int[] aspettato = new int[] { 5,8 };
            int[] risposta = statisticaLibrary.statistica.Positivi(valore);
            CollectionAssert.AreEquivalent(aspettato, risposta);
        }

        [DataTestMethod]
        [DataRow(new int[] { -4, 8, -5, 3 }, new int[] { 3, 8 })]
        [DataRow(new int[] { -23, 1, -6, 3 }, new int[] { 1, 3, })]
        public void DataTestPositivi(int[] valore, int[] aspettato)
        {
            int[] rispsosta = statisticaLibrary.statistica.Positivi(valore);
            CollectionAssert.AreEquivalent(aspettato, rispsosta);
        }
    }
}
