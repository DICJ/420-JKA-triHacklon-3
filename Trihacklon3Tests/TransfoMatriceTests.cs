using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trihacklon3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trihacklon3.Tests
{
    [TestClass()]
    public class TransfoMatriceTest
    {
        int[,] carre;
        int[,] large;
        int[,] haute;
        int[,] petitCarre;
        int[,] miniCarre;
        int[,] vide;
        int[,] grosCarre;

        [TestInitialize]
        public void InitMatrices()
        {
            carre = new int[,]
            {
                {20, 30, 40, 50},
                {21, 22, 23, 24},
                {31, 32, 33, 34},
                {41, 42, 43, 44}
            };
            large = new int[,]
            {
                {20, 30, 40, 50, 99, -60},
                {21, 22, 23, 24, 800, 1},
                {31, 32, 33, 34, 80, -255}
            };
            haute = new int[,]
            {
                {20, 30},
                {21, 22},
                {31, 32},
                {41, 42},
                {800, 9},
                {90, 89},
                {71, -6}
            };
            petitCarre = new int[,]
            {
                {20, 30},
                {21, 22}
            };
            miniCarre = new int[,] { { 20 } };
            vide = new int[0, 0];
            grosCarre = new int[,]
            {
                { 20,  30,  40,  50,  500, -50},
                { 21,  22,  23,  24,  240, -24},
                { 31,  32,  33,  34,  340, -34},
                { 41,  42,  43,  44,  440, -44},
                {-31, -32, -33, -35, -340,  35},
                {-41, -42, -43, -45, -440,  45}
            };
        }

        [TestMethod()]
        public void Rotation90HoraireTest()
        {
            CollectionAssert.AreEqual(
                new int[,]
                {  {41, 31, 21, 20},
                   {42, 32, 22, 30},
                   {43, 33, 23, 40},
                   {44, 34, 24, 50}},
                CalculatriceMatrices.Rotation90Horaire(carre));
        }

        [TestMethod()]
        public void Rotation90HoraireGrosTest()
        {
            CollectionAssert.AreEqual(
                new int[,] {
                { -41,  -31,  41,  31,  21, 20},
                { -42,  -32,  42,  32,  22, 30},
                { -43,  -33,  43,  33,  23, 40},
                { -45,  -35,  44,  34,  24, 50},
                { -440, -340, 440, 340, 240,  500},
                { 45, 35, -44, -34, -24,  -50} },
                CalculatriceMatrices.Rotation90Horaire(grosCarre));
        }

        [TestMethod()]
        public void Rotation90HorairePetitTest()
        {
            CollectionAssert.AreEqual(
                new int[,] { { 21, 20 }, { 22, 30 } },
                CalculatriceMatrices.Rotation90Horaire(petitCarre));
            CollectionAssert.AreEqual(
                new int[,] { { 20 } },
                CalculatriceMatrices.Rotation90Horaire(miniCarre));
        }

        [TestMethod()]
        public void Rotation180Test()
        {
            CollectionAssert.AreEqual(
                new int[,]
                {
                   { 44, 43, 42, 41},
                   { 34, 33, 32, 31},
                   { 24, 23, 22, 21},
                   { 50, 40, 30, 20}
                },
                CalculatriceMatrices.Rotation180(carre));
        }

        [TestMethod()]
        public void Rotation180GrosTest()
        {
            CollectionAssert.AreEqual(
                new int[,]
                {
                    { 45,  -440,  -45,  -43,  -42, -41},
                    { 35,  -340,  -35,  -33,  -32, -31},
                    { -44,  440,  44,  43,  42, 41},
                    { -34,  340,  34,  33,  32, 31},
                    { -24, 240, 24, 23, 22,  21},
                    { -50, 500, 50, 40, 30,  20}
                },
                CalculatriceMatrices.Rotation180(grosCarre));
        }

        [TestMethod()]
        public void Rotation180PetitTest()
        {
            CollectionAssert.AreEqual(
                new int[,] {
                    { 22, 21 },
                    { 30, 20 }
                },
                CalculatriceMatrices.Rotation180(petitCarre));
            CollectionAssert.AreEqual(
                new int[,] { { 20 } },
                CalculatriceMatrices.Rotation180(miniCarre));
        }

        [TestMethod()]
        public void Rotation90AntiHoraireTest()
        {
            CollectionAssert.AreEqual(
                new int[,]
                {
                   { 50, 24, 34, 44},
                   { 40, 23, 33, 43},
                   { 30, 22, 32, 42},
                   { 20, 21, 31, 41}
                 },
                CalculatriceMatrices.Rotation90AntiHoraire(carre));

        }

        [TestMethod()]
        public void Rotation90AntiHoraireGrosTest()
        {
            CollectionAssert.AreEqual(
                new int[,]
                {
                    { -50,  -24,  -34, -44,  35,  45},
                    { 500,  240,  340, 440,-340,-440},
                    {  50,   24,   34,  44, -35, -45},
                    {  40,   23,   33,  43, -33, -43},
                    {  30,   22,   32,  42, -32, -42},
                    {  20,   21,   31,  41, -31, -41}
                },
                CalculatriceMatrices.Rotation90AntiHoraire(grosCarre));

        }

        [TestMethod()]
        public void Rotation90AntiHorairePetitTest()
        {
            CollectionAssert.AreEqual(
                new int[,] {
                    { 30, 22 },
                    { 20, 21 }
                },
                CalculatriceMatrices.Rotation90AntiHoraire(petitCarre));
            CollectionAssert.AreEqual(
                new int[,] { { 20 } },
                CalculatriceMatrices.Rotation90AntiHoraire(miniCarre));
        }

        [TestMethod()]
        public void TransposeCarreeTest()
        {
            CollectionAssert.AreEqual(
            new int[,]
            {
                   { 20, 21, 31, 41},
                   { 30, 22, 32, 42},
                   { 40, 23, 33, 43},
                   { 50, 24, 34, 44}
             },
            CalculatriceMatrices.Transpose(carre));
        }

        [TestMethod()]
        public void TransposeCarreeGrosTest()
        {
            CollectionAssert.AreEqual(
                new int[,] {
                { 20,  21,  31,  41,  -31, -41},
                { 30,  22,  32,  42,  -32, -42},
                { 40,  23,  33,  43,  -33, -43},
                { 50,  24,  34,  44,  -35, -45},
                { 500, 240, 340, 440, -340,  -440},
                { -50, -24, -34, -44, 35,  45} },
                CalculatriceMatrices.Transpose(grosCarre));
        }

        [TestMethod()]
        public void TransposeCarreePetitTest()
        {
            CollectionAssert.AreEqual(
               new int[,] {
                    { 20, 21 },
                    { 30, 22 }
               },
               CalculatriceMatrices.Transpose(petitCarre));
            CollectionAssert.AreEqual(
                new int[,] { { 20 } },
                CalculatriceMatrices.Transpose(miniCarre));
        }

        [TestMethod()]
        public void TransposeRectTest()
        {
            CollectionAssert.AreEqual(
            new int[,]
            {
                   { 20, 21, 31},
                   { 30, 22, 32 },
                   { 40, 23, 33},
                   { 50, 24, 34},
                   { 99, 800, 80},
                   { -60, 1, -255}
             },
            CalculatriceMatrices.Transpose(large));
            CollectionAssert.AreEqual(
            new int[,]
            {
                   { 20, 21, 31, 41, 800, 90, 71},
                   { 30, 22, 32, 42, 9, 89, -6},
             },
            CalculatriceMatrices.Transpose(haute));
        }


        [TestMethod()]
        public void EstSymetriqueTest()
        {
            Assert.IsFalse(CalculatriceMatrices.EstSymetrique(haute));
            Assert.IsFalse(CalculatriceMatrices.EstSymetrique(large));
            Assert.IsFalse(CalculatriceMatrices.EstSymetrique(petitCarre));
            Assert.IsFalse(CalculatriceMatrices.EstSymetrique(carre));
            Assert.IsFalse(CalculatriceMatrices.EstSymetrique(grosCarre));

            Assert.IsTrue(CalculatriceMatrices.EstSymetrique(miniCarre));
            Assert.IsTrue(CalculatriceMatrices.EstSymetrique(vide));
        }


        [TestMethod()]
        public void EstSymetriqueEncoreTest()
        {
            Assert.IsTrue(CalculatriceMatrices.EstSymetrique(new int[,]
            {
                    {20, 21, 31, 41},
                    {21, 22, 23, 24},
                    {31, 23, 33, 34},
                    {41, 24, 34, 44}
            }));

            Assert.IsFalse(CalculatriceMatrices.EstSymetrique(new int[,]
            {
                {20, 21, 31, 41},
                {21, 22, 22, 24},
                {31, 23, 33, 34},
                {41, 24, 34, 44}
            }));

            Assert.IsTrue(CalculatriceMatrices.EstSymetrique(new int[,]
            {
                {1, 0, 0, 0},
                {0, 2, 0, 0},
                {0, 0, 3, 0},
                {0, 0, 0, 4}
            }));
        }

        [TestMethod()]
        public void EstDiagonaleTest()
        {
            Assert.IsFalse(CalculatriceMatrices.EstDiagonale(haute));
            Assert.IsFalse(CalculatriceMatrices.EstDiagonale(large));
            Assert.IsFalse(CalculatriceMatrices.EstDiagonale(petitCarre));
            Assert.IsFalse(CalculatriceMatrices.EstDiagonale(carre));
            Assert.IsFalse(CalculatriceMatrices.EstDiagonale(grosCarre));

            Assert.IsTrue(CalculatriceMatrices.EstDiagonale(miniCarre));
            Assert.IsTrue(CalculatriceMatrices.EstDiagonale(vide));
        }

        [TestMethod()]
        public void EstDiagonaleEncoreTest()
        {
            Assert.IsTrue(CalculatriceMatrices.EstDiagonale(new int[,]
            {
                    {20, 0, 0, 0},
                    {0, 22, 0, 0},
                    {0, 0, 33, 0},
                    {0, 0, 0, 44}
            }));

            Assert.IsFalse(CalculatriceMatrices.EstDiagonale(new int[,]
            {
                {20, 0, 0, 0},
                {0, 22, 22, 0},
                {0, 23, 0, 0},
                {0, 0, 0, 44}
            }));

            Assert.IsTrue(CalculatriceMatrices.EstDiagonale(new int[,]
            {
                {1, 0, 0, 0},
                {0, 2, 0, 0},
                {0, 0, 3, 0},
                {0, 0, 0, 4}
            }));

            Assert.IsTrue(CalculatriceMatrices.EstDiagonale(new int[,]
            {
                {1, 0, 0, 0},
                {0, 2, 0, 0},
                {0, 0, 0, 0},
                {0, 0, 0, 4}
            }));


            Assert.IsFalse(CalculatriceMatrices.EstDiagonale(new int[,]
            {
                {1, 0, 0, 0},
                {0, 2, 2, 0},
                {0, 2, 3, 0},
                {0, 0, 0, 4}
            }));
        }

        [TestMethod()]
        public void MatricesEgalesTest()
        {
            Assert.IsTrue(CalculatriceMatrices.MatricesEgales(carre, carre));
            Assert.IsFalse(CalculatriceMatrices.MatricesEgales(grosCarre, carre));
            Assert.IsFalse(CalculatriceMatrices.MatricesEgales(carre, grosCarre));
        }

        [TestMethod()]
        public void MatricesEgalesCarreTest()
        {

            Assert.IsTrue(CalculatriceMatrices.MatricesEgales(
                new int[,]
                {
                    {20, 30, 40, 50},
                    {21, 22, 23, 24},
                    {31, 32, 33, 34},
                    {41, 42, 43, 44}
                }, carre));
            Assert.IsFalse(CalculatriceMatrices.MatricesEgales(
                new int[,]
                {
                    {20, 30, 40, 50},
                    {21, 22, 23, 24},
                    {31, 32, 33, 34},
                    {41, 42, 43, 43}
                }, carre));
        }

        [TestMethod()]
        public void MatricesEgalesRectTest()
        {
            Assert.IsTrue(CalculatriceMatrices.MatricesEgales(
                new int[,]
                {
                    {20, 30, 40, 50, 99, -60},
                    {21, 22, 23, 24, 800, 1},
                    {31, 32, 33, 34, 80, -255}
                }, large));
            Assert.IsFalse(CalculatriceMatrices.MatricesEgales(
                new int[,]
                {
                    {20, 30, 40, 50, 99, -60},
                    {21, 22, 23, 24, 800, 1},
                    {31, 32, 33, 34, 80, -0}
                }, large));
        }


    }
}