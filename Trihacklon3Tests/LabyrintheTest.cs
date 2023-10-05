using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trihacklon3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trihacklon3.Tests
{
    [TestClass()]
    public class LabyrintheTest
    {
        [TestMethod()]
        public void EstLabyrintheTest()
        {
            int[,] carre = new int[,]
            {
                {  0, 0, -2, -2 },
                { -2, 0, -2,  0 },
                {  0, 0, -2, -2 },
                { -2, 0,  0, -1 }
             };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 0, 0));
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 3, 1));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(carre, 1, 3));
        }

        [TestMethod()]
        public void EstLabyrintheEncoreTest()
        {
            int[,] carre = new int[,]
            {
                    {  0,  0, -2, -2 },
                    { -2,  0, -2,  0 },
                    {  0, -2, -2, -2 },
                    { -2,  0,  0, -1 }
             };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 3, 1));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(carre, 0, 0));
        }

        [TestMethod()]
        public void EstLabyrinthePeuMursTest()
        {
            int[,] carre = new int[,]
            {
                    {  0,  0,  0, -1 },
                    {  0,  0,  0,  0 },
                    { -2, -2,  0,  0 },
                    {  0, -2,  0,  0 }
             };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 0, 0));
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 3, 3));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(carre, 3, 0));
        }

        [TestMethod()]
        public void EstLabyrintheLargeTest()
        {
            int[,] large = new int[,]
            {
                    {  0,  0, -2, -2,  0, -1 },
                    { -2,  0, -2,  0,  0, -2 },
                    {  0,  0,  0,  0, -2,  0 },
                    { -2, -2, -2, -2, -2,  0 },
            };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(large, 0, 0));
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(large, 2, 0));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(large, 2, 5));
        }

        [TestMethod()]
        public void LabyrinthePetitTest()
        {
            var carre = new int[,]
            {
                {  0, 0, -2, -2 },
                { -2, 0,  0,  0 },
                {  0, 0, -2, -2 },
                { -2, 0,  0, -1 }
             };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 0, 0));
            Assert.IsFalse (CalculatriceMatrices.Labyrinthe(carre, 0, 3));
        }
        
        [TestMethod()]
        public void LabyrintheLargeTest()
        {

            int[,] large = new int[,]
            {
                {  0,  0, -2, -2,  0, -1 },
                { -2,  0, -2,  0,  0, -2 },
                {  0,  0,  0,  0, -2, -2 },
                { -2, -2, -2, -2, -2, -2 },
            };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(large, 0, 0));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(large, 3, 5));
        }

        [TestMethod()]
        public void LabyrintheLargeCheminTest()
        {

            int[,] large = new int[,]
            {
                {  0,  0, -2, -2,  0, -1 },
                { -2,  0, -2,  0,  0, -2 },
                {  0,  0,  0,  0, -2, -2 },
                { -2, -2, -2, -2, -2, -2 },
            };
            CalculatriceMatrices.Labyrinthe(large, 0, 0, 1);
            CollectionAssert.AreEqual(
                new int[,]
                {
                    {  1,  2, -2, -2,  9, -1 },
                    { -2,  3, -2,  7,  8, -2 },
                    {  0,  4,  5,  6, -2, -2 },
                    { -2, -2, -2, -2, -2, -2 },
                },
                large);
        }

        [TestMethod()]
        public void LabyrinthePetitCheminTest()
        {
            int[,] carre = new int[,]
            {
                {  0, 0, -2, -2 },
                { -2, 0,  0,  0 },
                {  0, 0, -2, -2 },
                { -2, 0,  0, -1 }
             };
            CalculatriceMatrices.Labyrinthe(carre, 0, 0, 1);
            CollectionAssert.AreEqual(
                new int[,]
                {
                {  1, 2, -2, -2 },
                { -2, 3,  0,  0 },
                {  0, 4, -2, -2 },
                { -2, 5,  6, -1 }
                },
                carre);
        }

        [TestMethod()]
        public void EstLabyrintheCheminTest()
        {
            int[,] carre = new int[,]
            {
                {  0, 0, -2, -2 },
                { -2, 0, -2,  0 },
                {  0, 0, -2, -2 },
                { -2, 0,  0, -1 }
            };
            int[,] solution = new int[,]
            {
                {  1, 2, -2, -2 },
                { -2, 3, -2,  0 },
                {  0, 4, -2, -2 },
                { -2, 5,  6, -1 }
            };
            CalculatriceMatrices.Labyrinthe(carre, 0, 0, 1);
            CollectionAssert.AreEqual(solution, carre);
        }

        [TestMethod()]
        public void EstLabyrintheEncoreCheminTest()
        {
            int[,] carre = new int[,]
            {
                    {  0,  0, -2, -2 },
                    { -2,  0, -2,  0 },
                    {  0, -2, -2, -2 },
                    { -2,  0,  0, -1 }
             };

            int[,] solution = new int[,]
            {
                    {  0,  0, -2, -2 },
                    { -2,  0, -2,  0 },
                    {  0, -2, -2, -2 },
                    { -2,  1,  2, -1 }
            };
            CalculatriceMatrices.Labyrinthe(carre, 3, 1, 1);
            CollectionAssert.AreEqual(solution, carre);
        }

        [TestMethod()]
        public void EstLabyrintheLargeCheminTest()
        {
            int[,] large = new int[,]
            {
                    {  0,  0, -2, -2,  0, -1 },
                    { -2,  0, -2,  0,  0, -2 },
                    {  0,  0,  0,  0, -2,  0 },
                    { -2, -2, -2, -2, -2,  0 },
            };
            int[,] solution = new int[,]
            {
                    {  1,  2, -2, -2,  9, -1 },
                    { -2,  3, -2,  7,  8, -2 },
                    {  0,  4,  5,  6, -2,  0 },
                    { -2, -2, -2, -2, -2,  0 },
            };

            CalculatriceMatrices.Labyrinthe(large, 0, 0, 1);
            CollectionAssert.AreEqual(solution, large);
        }

        //*POUR DONNER PLUS D'ÉTOILES*//

        [TestMethod()]
        public void EstLabyrintheTestBis()
        {
            int[,] carre = new int[,]
            {
                {  0, 0, -2, -2 },
                { -2, 0, -2,  0 },
                {  0, 0, -2, -2 },
                { -2, 0,  0, -1 }
             };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 0, 0));
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 3, 1));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(carre, 1, 3));
        }

        [TestMethod()]
        public void EstLabyrintheEncoreTestBis()
        {
            int[,] carre = new int[,]
            {
                    {  0,  0, -2, -2 },
                    { -2,  0, -2,  0 },
                    {  0, -2, -2, -2 },
                    { -2,  0,  0, -1 }
             };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 3, 1));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(carre, 0, 0));
        }

        [TestMethod()]
        public void EstLabyrinthePeuMursTestBis()
        {
            int[,] carre = new int[,]
            {
                    {  0,  0,  0, -1 },
                    {  0,  0,  0,  0 },
                    { -2, -2,  0,  0 },
                    {  0, -2,  0,  0 }
             };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 0, 0));
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 3, 3));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(carre, 3, 0));
        }

        [TestMethod()]
        public void EstLabyrintheLargeTestBis()
        {
            int[,] large = new int[,]
            {
                    {  0,  0, -2, -2,  0, -1 },
                    { -2,  0, -2,  0,  0, -2 },
                    {  0,  0,  0,  0, -2,  0 },
                    { -2, -2, -2, -2, -2,  0 },
            };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(large, 0, 0));
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(large, 2, 0));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(large, 2, 5));
        }

        [TestMethod()]
        public void LabyrinthePetitTestBis()
        {
            var carre = new int[,]
            {
                {  0, 0, -2, -2 },
                { -2, 0,  0,  0 },
                {  0, 0, -2, -2 },
                { -2, 0,  0, -1 }
             };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 0, 0));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(carre, 0, 3));
        }

        [TestMethod()]
        public void LabyrintheLargeTestBis()
        {

            int[,] large = new int[,]
            {
                {  0,  0, -2, -2,  0, -1 },
                { -2,  0, -2,  0,  0, -2 },
                {  0,  0,  0,  0, -2, -2 },
                { -2, -2, -2, -2, -2, -2 },
            };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(large, 0, 0));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(large, 3, 5));
        }

        [TestMethod()]
        public void LabyrintheLargeCheminTestBis()
        {

            int[,] large = new int[,]
            {
                {  0,  0, -2, -2,  0, -1 },
                { -2,  0, -2,  0,  0, -2 },
                {  0,  0,  0,  0, -2, -2 },
                { -2, -2, -2, -2, -2, -2 },
            };
            CalculatriceMatrices.Labyrinthe(large, 0, 0, 1);
            CollectionAssert.AreEqual(
                new int[,]
                {
                    {  1,  2, -2, -2,  9, -1 },
                    { -2,  3, -2,  7,  8, -2 },
                    {  0,  4,  5,  6, -2, -2 },
                    { -2, -2, -2, -2, -2, -2 },
                },
                large);
        }

        [TestMethod()]
        public void LabyrinthePetitCheminTestBis()
        {
            int[,] carre = new int[,]
            {
                {  0, 0, -2, -2 },
                { -2, 0,  0,  0 },
                {  0, 0, -2, -2 },
                { -2, 0,  0, -1 }
             };
            CalculatriceMatrices.Labyrinthe(carre, 0, 0, 1);
            CollectionAssert.AreEqual(
                new int[,]
                {
                {  1, 2, -2, -2 },
                { -2, 3,  0,  0 },
                {  0, 4, -2, -2 },
                { -2, 5,  6, -1 }
                },
                carre);
        }

        [TestMethod()]
        public void EstLabyrintheCheminTestBis()
        {
            int[,] carre = new int[,]
            {
                {  0, 0, -2, -2 },
                { -2, 0, -2,  0 },
                {  0, 0, -2, -2 },
                { -2, 0,  0, -1 }
            };
            int[,] solution = new int[,]
            {
                {  1, 2, -2, -2 },
                { -2, 3, -2,  0 },
                {  0, 4, -2, -2 },
                { -2, 5,  6, -1 }
            };
            CalculatriceMatrices.Labyrinthe(carre, 0, 0, 1);
            CollectionAssert.AreEqual(solution, carre);
        }

        [TestMethod()]
        public void EstLabyrintheEncoreCheminTestBis()
        {
            int[,] carre = new int[,]
            {
                    {  0,  0, -2, -2 },
                    { -2,  0, -2,  0 },
                    {  0, -2, -2, -2 },
                    { -2,  0,  0, -1 }
             };

            int[,] solution = new int[,]
            {
                    {  0,  0, -2, -2 },
                    { -2,  0, -2,  0 },
                    {  0, -2, -2, -2 },
                    { -2,  1,  2, -1 }
            };
            CalculatriceMatrices.Labyrinthe(carre, 3, 1, 1);
            CollectionAssert.AreEqual(solution, carre);
        }

        [TestMethod()]
        public void EstLabyrintheLargeCheminTestBis()
        {
            int[,] large = new int[,]
            {
                    {  0,  0, -2, -2,  0, -1 },
                    { -2,  0, -2,  0,  0, -2 },
                    {  0,  0,  0,  0, -2,  0 },
                    { -2, -2, -2, -2, -2,  0 },
            };
            int[,] solution = new int[,]
            {
                    {  1,  2, -2, -2,  9, -1 },
                    { -2,  3, -2,  7,  8, -2 },
                    {  0,  4,  5,  6, -2,  0 },
                    { -2, -2, -2, -2, -2,  0 },
            };

            CalculatriceMatrices.Labyrinthe(large, 0, 0, 1);
            CollectionAssert.AreEqual(solution, large);
        }




        [TestMethod()]
        public void EstLabyrintheTestTer()
        {
            int[,] carre = new int[,]
            {
                {  0, 0, -2, -2 },
                { -2, 0, -2,  0 },
                {  0, 0, -2, -2 },
                { -2, 0,  0, -1 }
             };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 0, 0));
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 3, 1));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(carre, 1, 3));
        }

        [TestMethod()]
        public void EstLabyrintheEncoreTestTer()
        {
            int[,] carre = new int[,]
            {
                    {  0,  0, -2, -2 },
                    { -2,  0, -2,  0 },
                    {  0, -2, -2, -2 },
                    { -2,  0,  0, -1 }
             };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 3, 1));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(carre, 0, 0));
        }

        [TestMethod()]
        public void EstLabyrinthePeuMursTestTer()
        {
            int[,] carre = new int[,]
            {
                    {  0,  0,  0, -1 },
                    {  0,  0,  0,  0 },
                    { -2, -2,  0,  0 },
                    {  0, -2,  0,  0 }
             };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 0, 0));
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 3, 3));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(carre, 3, 0));
        }

        [TestMethod()]
        public void EstLabyrintheLargeTestTer()
        {
            int[,] large = new int[,]
            {
                    {  0,  0, -2, -2,  0, -1 },
                    { -2,  0, -2,  0,  0, -2 },
                    {  0,  0,  0,  0, -2,  0 },
                    { -2, -2, -2, -2, -2,  0 },
            };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(large, 0, 0));
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(large, 2, 0));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(large, 2, 5));
        }

        [TestMethod()]
        public void LabyrinthePetitTestTer()
        {
            var carre = new int[,]
            {
                {  0, 0, -2, -2 },
                { -2, 0,  0,  0 },
                {  0, 0, -2, -2 },
                { -2, 0,  0, -1 }
             };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(carre, 0, 0));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(carre, 0, 3));
        }

        [TestMethod()]
        public void LabyrintheLargeTestTer()
        {

            int[,] large = new int[,]
            {
                {  0,  0, -2, -2,  0, -1 },
                { -2,  0, -2,  0,  0, -2 },
                {  0,  0,  0,  0, -2, -2 },
                { -2, -2, -2, -2, -2, -2 },
            };
            Assert.IsTrue(CalculatriceMatrices.Labyrinthe(large, 0, 0));
            Assert.IsFalse(CalculatriceMatrices.Labyrinthe(large, 3, 5));
        }

        [TestMethod()]
        public void LabyrintheLargeCheminTestTer()
        {

            int[,] large = new int[,]
            {
                {  0,  0, -2, -2,  0, -1 },
                { -2,  0, -2,  0,  0, -2 },
                {  0,  0,  0,  0, -2, -2 },
                { -2, -2, -2, -2, -2, -2 },
            };
            CalculatriceMatrices.Labyrinthe(large, 0, 0, 1);
            CollectionAssert.AreEqual(
                new int[,]
                {
                    {  1,  2, -2, -2,  9, -1 },
                    { -2,  3, -2,  7,  8, -2 },
                    {  0,  4,  5,  6, -2, -2 },
                    { -2, -2, -2, -2, -2, -2 },
                },
                large);
        }

        [TestMethod()]
        public void LabyrinthePetitCheminTestTer()
        {
            int[,] carre = new int[,]
            {
                {  0, 0, -2, -2 },
                { -2, 0,  0,  0 },
                {  0, 0, -2, -2 },
                { -2, 0,  0, -1 }
             };
            CalculatriceMatrices.Labyrinthe(carre, 0, 0, 1);
            CollectionAssert.AreEqual(
                new int[,]
                {
                {  1, 2, -2, -2 },
                { -2, 3,  0,  0 },
                {  0, 4, -2, -2 },
                { -2, 5,  6, -1 }
                },
                carre);
        }

        [TestMethod()]
        public void EstLabyrintheCheminTestTer()
        {
            int[,] carre = new int[,]
            {
                {  0, 0, -2, -2 },
                { -2, 0, -2,  0 },
                {  0, 0, -2, -2 },
                { -2, 0,  0, -1 }
            };
            int[,] solution = new int[,]
            {
                {  1, 2, -2, -2 },
                { -2, 3, -2,  0 },
                {  0, 4, -2, -2 },
                { -2, 5,  6, -1 }
            };
            CalculatriceMatrices.Labyrinthe(carre, 0, 0, 1);
            CollectionAssert.AreEqual(solution, carre);
        }

        [TestMethod()]
        public void EstLabyrintheEncoreCheminTestTer()
        {
            int[,] carre = new int[,]
            {
                    {  0,  0, -2, -2 },
                    { -2,  0, -2,  0 },
                    {  0, -2, -2, -2 },
                    { -2,  0,  0, -1 }
             };

            int[,] solution = new int[,]
            {
                    {  0,  0, -2, -2 },
                    { -2,  0, -2,  0 },
                    {  0, -2, -2, -2 },
                    { -2,  1,  2, -1 }
            };
            CalculatriceMatrices.Labyrinthe(carre, 3, 1, 1);
            CollectionAssert.AreEqual(solution, carre);
        }

        [TestMethod()]
        public void EstLabyrintheLargeCheminTestTer()
        {
            int[,] large = new int[,]
            {
                    {  0,  0, -2, -2,  0, -1 },
                    { -2,  0, -2,  0,  0, -2 },
                    {  0,  0,  0,  0, -2,  0 },
                    { -2, -2, -2, -2, -2,  0 },
            };
            int[,] solution = new int[,]
            {
                    {  1,  2, -2, -2,  9, -1 },
                    { -2,  3, -2,  7,  8, -2 },
                    {  0,  4,  5,  6, -2,  0 },
                    { -2, -2, -2, -2, -2,  0 },
            };

            CalculatriceMatrices.Labyrinthe(large, 0, 0, 1);
            CollectionAssert.AreEqual(solution, large);
        }
    }
}