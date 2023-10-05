using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trihacklon3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trihacklon3.Tests
{
    [TestClass()]
    public class CoordMatriceTest
    {
        [TestMethod()]
        public void EstCarreTest()
        {
            Assert.IsTrue(CalculatriceMatrices.EstCarre(new int[30, 30]));
            Assert.IsTrue(CalculatriceMatrices.EstCarre(new int[1, 1]));
            Assert.IsFalse(CalculatriceMatrices.EstCarre(new int[30, 15]));
            Assert.IsFalse(CalculatriceMatrices.EstCarre(new int[15, 30]));
        }

        [TestMethod()]
        public void EstRangeeValideTest()
        {
            Assert.IsTrue(CalculatriceMatrices.EstRangeeValide(new int[30, 30], 5));
            Assert.IsTrue(CalculatriceMatrices.EstRangeeValide(new int[30, 15], 5));
            Assert.IsTrue(CalculatriceMatrices.EstRangeeValide(new int[30, 3], 29));
            Assert.IsTrue(CalculatriceMatrices.EstRangeeValide(new int[10, 10], 0));
            Assert.IsFalse(CalculatriceMatrices.EstRangeeValide(new int[10, 30], 10));
            Assert.IsFalse(CalculatriceMatrices.EstRangeeValide(new int[4, 30], 9));
            Assert.IsFalse(CalculatriceMatrices.EstRangeeValide(new int[30, 30], -1));
        }

        [TestMethod()]
        public void EstColonneValideTest()
        {
            Assert.IsTrue(CalculatriceMatrices.EstColonneValide(new int[30, 30], 5));
            Assert.IsTrue(CalculatriceMatrices.EstColonneValide(new int[30, 15], 5));
            Assert.IsTrue(CalculatriceMatrices.EstColonneValide(new int[30, 3], 2));
            Assert.IsTrue(CalculatriceMatrices.EstColonneValide(new int[10, 10], 0));
            Assert.IsFalse(CalculatriceMatrices.EstColonneValide(new int[30, 3], 3));
            Assert.IsFalse(CalculatriceMatrices.EstColonneValide(new int[40, 30], 35));
            Assert.IsFalse(CalculatriceMatrices.EstColonneValide(new int[30, 30], -1));
        }

        [TestMethod()]
        public void EstDedansTest()
        {
            Assert.IsTrue(CalculatriceMatrices.EstDedans(new int[30, 30], 5, 5));
            Assert.IsTrue(CalculatriceMatrices.EstDedans(new int[30, 15], 21, 12));
            Assert.IsTrue(CalculatriceMatrices.EstDedans(new int[30, 3], 29, 2));
            Assert.IsTrue(CalculatriceMatrices.EstDedans(new int[10, 10], 0, 0));
            Assert.IsFalse(CalculatriceMatrices.EstDedans(new int[30, 3], 30, 1));
            Assert.IsFalse(CalculatriceMatrices.EstDedans(new int[30, 3], 1, 4));
            Assert.IsFalse(CalculatriceMatrices.EstDedans(new int[40, 30], 35, 35));
            Assert.IsFalse(CalculatriceMatrices.EstDedans(new int[40, 30], 40, 15));
            Assert.IsFalse(CalculatriceMatrices.EstDedans(new int[3, 3], -1, 2));
            Assert.IsFalse(CalculatriceMatrices.EstDedans(new int[3, 3], 1, -1));
            Assert.IsFalse(CalculatriceMatrices.EstDedans(new int[3, 3], -1, -1));
        }
        [TestMethod()]
        public void NbCellulesTest()
        {
            Assert.AreEqual(30 * 30, CalculatriceMatrices.NbCellules(new int[30, 30]));
            Assert.AreEqual(30 * 15, CalculatriceMatrices.NbCellules(new int[30, 15]));
            Assert.AreEqual(30 * 3, CalculatriceMatrices.NbCellules(new int[30, 3]));
            Assert.AreEqual(10 * 10, CalculatriceMatrices.NbCellules(new int[10, 10]));
        }


        [TestMethod()]
        public void DensiteTest()
        {
            Assert.AreEqual(0, CalculatriceMatrices.Densite(new int[30, 30]));

            Assert.AreEqual(1, CalculatriceMatrices.Densite(new int[,]
            {
                {20, 30, 40, 50},
                {21, 22, 23, 24},
                {31, 32, 33, 34},
                {41, 42, 43, 44}
            }));
            Assert.AreEqual(12.0 / 16.0, CalculatriceMatrices.Densite(new int[,]
            {
                {0, 30, 40, 0},
                {21, 22, 23, 24},
                {0, 32, 0, 34},
                {41, 42, 43, 44}
            }));
        }

        [TestMethod()]
        public void DensiteEncore()
        {
            Assert.AreEqual(0, CalculatriceMatrices.Densite(new int[10, 3]));
            Assert.AreEqual(1, CalculatriceMatrices.Densite(new int[,]
            {
                {20, 30, 40, 50, 99, -60},
                {21, 22, 23, 24, 800, 1},
                {31, 32, 33, 34, 80, -255}
            }));
            Assert.AreEqual(15.0 / 18.0, CalculatriceMatrices.Densite(new int[,]
            {
                {20, 0, 40, 50, 99, -60},
                {21, 22, 0, 24, 800, 1},
                {31, 32, 33, 0, 80, -255}
            }));
        }


        [TestMethod()]
        public void CopierMatricesTest()
        {
            var carre = new int[,]
            {
                {20, 30, 40, 50},
                {21, 22, 23, 24},
                {31, 32, 33, 34},
                {41, 42, 43, 44}
            };
            var copie = CalculatriceMatrices.Copier(carre);
            CollectionAssert.AreEqual(carre, copie);
            Assert.AreNotSame(copie, carre);
        }


        [TestMethod()]
        public void CopierMatricesRectTest()
        {

           var  haute = new int[,]
            {
                {20, 30},
                {21, 22},
                {31, 32},
                {41, 42},
                {800, 9},
                {90, 89},
                {71, -6}
            };
            var copie = CalculatriceMatrices.Copier(haute);
            CollectionAssert.AreEqual(haute, copie);
            Assert.AreNotSame(copie, haute);
        }

    }
}