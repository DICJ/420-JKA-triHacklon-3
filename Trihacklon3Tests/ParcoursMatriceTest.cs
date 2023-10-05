using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trihacklon3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trihacklon3.Tests
{
    [TestClass()]
    public class ParcoursMatriceTest
    {
        int[,] carre;
        int[,] large;
        int[,] haute;
        int[,] petitCarre;
        int[,] miniCarre;
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
            grosCarre = new int[,]
            {
                { 20,  30,  40,  50,  500, -50},
                { 21,  22,  23,  24,  240, -24},
                { 31,  32,  33,  34,  340, -34},
                { 41,  42,  43,  44,  440, -44},
                {-31, -32, -33, -35, -340,  35},
                {-41, -42, -43, -45, -440,  45},
            };
        }



        [TestMethod()]
        public void ZigzagCarreTestMoyen()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 30, 40, 50, 24, 23, 22, 21, 31, 32, 33, 34, 44, 43, 42, 41 },
                CalculatriceMatrices.ZigzagHorizontal(carre));
        }

        [TestMethod()]
        public void ZigzagCarreTestGros()
        {
            CollectionAssert.AreEqual(
                new int[]
                { 20,  30,  40,  50,  500, -50,
                  -24, 240, 24, 23, 22, 21,
                  31,  32,  33,  34,  340, -34,
                  -44, 440, 44, 43, 42, 41,
                 -31, -32, -33, -35, -340,  35,
                 45, -440, -45, -43, -42, -41 },
                CalculatriceMatrices.ZigzagHorizontal(grosCarre));
        }

        [TestMethod()]
        public void ZigzagRectTestHaut()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 30, 22, 21, 31, 32, 42, 41, 800, 9, 89, 90, 71, -6 },
                CalculatriceMatrices.ZigzagHorizontal(haute));
        }

        [TestMethod()]
        public void ZigzagRectTestLarge()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 30, 40, 50, 99, -60, 1, 800, 24, 23, 22, 21, 31, 32, 33, 34, 80, -255 },
                CalculatriceMatrices.ZigzagHorizontal(large));
        }



        [TestMethod()]
        public void SpiraleCarreTestMoyen()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 30, 40, 50, 24, 34, 44, 43, 42, 41, 31, 21, 22, 23, 33, 32 },
                CalculatriceMatrices.Spirale(carre));
        }

        [TestMethod()]
        public void SpiraleCarreTestPetit()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 30, 22, 21 },
                CalculatriceMatrices.Spirale(petitCarre));
        }

        [TestMethod()]
        public void SpiraleCarreTestMini()
        {
            CollectionAssert.AreEqual(
                new int[] { 20 },
                CalculatriceMatrices.Spirale(miniCarre));
        }

        [TestMethod()]
        public void SpiraleCarreTestVide()
        {
            CollectionAssert.AreEqual(
                new int[] { 1, 2, 3 },
                CalculatriceMatrices.Spirale(new int[,] { { 1, 2, 3 } }));
        }

        [TestMethod()]
        public void SpiraleCarreTestGros()
        {
            CollectionAssert.AreEqual(
                new int[]
                {
                    20, 30, 40, 50, 500, -50,
                    -24, -34, -44, 35, 45,
                    -440, -45, -43, -42, -41,
                    -31, 41, 31, 21,
                    22, 23, 24, 240, 340, 440, -340, -35, -33, -32, 42, 32,
                    33, 34, 44, 43
                },
                CalculatriceMatrices.Spirale(grosCarre));
        }

        [TestMethod()]
        public void SpiraleRectTestLarge()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 30, 40, 50, 99, -60, 1, -255, 80, 34, 33, 32, 31, 21, 22, 23, 24, 800 },
                CalculatriceMatrices.Spirale(large));
        }

        [TestMethod()]
        public void SpiraleRectTestHaut()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 30, 22, 32, 42, 9, 89, -6, 71, 90, 800, 41, 31, 21 },
                CalculatriceMatrices.Spirale(haute));
        }

        [TestMethod()]
        public void DiagonalesDescendantesCarreTestMoyen()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 30, 21, 40, 22, 31, 50, 23, 32, 41, 24, 33, 42, 34, 43, 44 },
                CalculatriceMatrices.DiagonalesDescendantes(carre));
        }

        [TestMethod()]
        public void DiagonalesDescendantesCarreTestPetit()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 30, 21, 22 },
                CalculatriceMatrices.DiagonalesDescendantes(petitCarre));
        }

        [TestMethod()]
        public void DiagonalesDescendantesCarreTestGros()
        {
            CollectionAssert.AreEqual(
                new int[] {
                    20,
                    30, 21,
                    40, 22, 31,
                    50, 23, 32, 41,
                    500, 24, 33, 42, -31,
                    -50, 240, 34, 43, -32, -41,
                    -24, 340, 44, -33, -42,
                    -34, 440, -35, -43,
                    -44, -340, -45,
                    35, -440,
                    45},
            CalculatriceMatrices.DiagonalesDescendantes(grosCarre));
        }

        [TestMethod()]
        public void DiagonalesDescendantesRectTestLarge()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 30, 21, 40, 22, 31, 50, 23, 32, 99, 24, 33, -60, 800, 34, 1, 80, -255 },
                CalculatriceMatrices.DiagonalesDescendantes(large));
            CollectionAssert.AreEqual(
                new int[] { 20, 30, 21, 22, 31, 32, 41, 42, 800, 9, 90, 89, 71, -6 },
                CalculatriceMatrices.DiagonalesDescendantes(haute));
        }

        [TestMethod()]
        public void DiagonalesMontantesCarreTest()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 21, 30, 31, 22, 40, 41, 32, 23, 50, 42, 33, 24, 43, 34, 44 },
                CalculatriceMatrices.DiagonalesMontantes(carre));
        }

        [TestMethod()]
        public void DiagonalesMontantesCarreTestPetit()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 21, 30, 22 },
                CalculatriceMatrices.DiagonalesMontantes(petitCarre));
        }

        
        [TestMethod()]
        public void DiagonalesMontantesCarreTestGros()
        {

            CollectionAssert.AreEqual(
                new int[] {
                    20,
                    21, 30,
                    31, 22, 40,
                    41, 32, 23, 50,
                    -31, 42, 33, 24, 500,
                    -41, -32, 43, 34, 240, -50,
                    -42, -33, 44, 340, -24,
                    -43, -35, 440, -34,
                    -45, -340, -44,
                    -440, 35,
                    45},
                CalculatriceMatrices.DiagonalesMontantes(grosCarre));
        }

        [TestMethod()]
        public void DiagonalesMontantesRectTestLarge()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 21, 30, 31, 22, 40, 32, 23, 50, 33, 24, 99, 34, 800, -60, 80, 1, -255 },
                CalculatriceMatrices.DiagonalesMontantes(large));
        
            CollectionAssert.AreEqual(
                new int[] { 20, 21, 30, 31, 22, 41, 32, 800, 42, 90, 9, 71, 89, -6 },
                CalculatriceMatrices.DiagonalesMontantes(haute));
        }

        [TestMethod()]
        public void ColombeCarreTest()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 30, 21, 31, 22, 40, 50, 23, 32, 41, 42, 33, 24, 34, 43, 44 },
                CalculatriceMatrices.QueueDeColombe(carre));
        }

        [TestMethod()]
        public void ColombeCarreTestPetit()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 30, 21, 22 },
                CalculatriceMatrices.QueueDeColombe(petitCarre));
        }

        [TestMethod()]
        public void ColombeCarreTestMini()
        {
            CollectionAssert.AreEqual(
                new int[] { 20 },
                CalculatriceMatrices.QueueDeColombe(miniCarre));
        }

        [TestMethod()]
        public void ColombeCarreTestVide()
        {
            CollectionAssert.AreEqual(
                new int[] { 1, 2, 3 },
                CalculatriceMatrices.QueueDeColombe(new int[,] { { 1, 2, 3 } }));

        }

        [TestMethod()]
        public void ColombeCarreTestGros()
        {
            CollectionAssert.AreEqual(
                new int[] {
                    20,
                    30, 21,
                    31, 22, 40,
                    50, 23, 32, 41,
                    -31, 42, 33, 24, 500,
                    -50, 240, 34, 43,  -32, -41,
                    -42, -33, 44, 340, -24,
                    -34, 440, -35, -43,
                    -45, -340, -44,
                    35,-440,
                    45},
                CalculatriceMatrices.QueueDeColombe(grosCarre));
        }

        [TestMethod()]
        public void ColombeRectTestLarge()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 30, 21, 31, 22, 40, 50, 23, 32, 33, 24, 99, -60, 800, 34, 80, 1, -255 },
                CalculatriceMatrices.QueueDeColombe(large));
        }

        [TestMethod()]
        public void ColombeRectTestHaut()
        {
            CollectionAssert.AreEqual(
                new int[] { 20, 30, 21, 31, 22, 32, 41, 800, 42, 9, 90, 71, 89, -6 },
                CalculatriceMatrices.QueueDeColombe(haute));
        }
    }
}