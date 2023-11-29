using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trihacklon3
{
    public class CalculatriceMatrices
    {
        /// <summary>
        /// Parcourt la matrice de gauche à droite, puis de droite à gauche (en zig zag descendant)
        /// 1 2 3
        /// 6 5 4
        /// 7 8 9
        /// </summary>
        /// <param name="m">Une matrice quelconque</param>
        /// <returns>Un tableau contenant les cases de la matrices, en zig zag descendant, à partir du coin supérieur gauche</returns>
        public static int[] ZigzagHorizontal(int[,] m)
        {
            return new int[0];
        }
        /// <summary>
        /// Parcourt la matrice dans l'ordre des diagonales descendantes
        /// 1 2 4
        /// 3 5 7
        /// 6 8 9
        /// </summary>
        /// <param name="m">Une matrice quelconque</param>
        /// <returns>Un tableau contenant les cases de la matrices, dans l'ordre des diagonales descendantes</returns>
        public static int[] DiagonalesDescendantes(int[,] m)
        {
            return new int[0];
        }

        /// <summary>
        /// Parcourt la matrice dans l'ordre des diagonales montantes
        /// 1 3 6
        /// 2 5 8
        /// 4 7 9
        /// </summary>
        /// <param name="m">Une matrice quelconque</param>
        /// <returns>Un tableau contenant les cases de la matrices, dans l'ordre des diagonales montantes</returns>
        public static int[] DiagonalesMontantes(int[,] m)
        {
            return new int[0];
        }

        /// <summary>
        /// Parcourt la matrice dans l'ordre de la queue de colombe (diagonale descendantes et montante en alternance)
        /// 1 2 6
        /// 3 5 7
        /// 4 8 9
        /// </summary>
        /// <param name="m">Une matrice quelconque</param>
        /// <returns>Un tableau contenant les cases de la matrices, dans l'ordre de la queue de colombe</returns>
        public static int[] QueueDeColombe(int[,] m)
        {
            return new int[0];
        }
        /// <summary>
        /// Parcourt la matrice en spirale
        /// 1 2 3
        /// 8 9 4
        /// 7 6 5
        /// </summary>
        /// <param name="m">Une matrice quelconque</param>
        /// <returns>Un tableau contenant les cases de la matrices en spirale</returns>
        public static int[] Spirale(int[,] m)
        {
            return new int[0];
        }

        /// <summary>
        /// Détermine si une matrice est carrée. Une matrice est carrée si elle a autant de colonnes que de rangées.
        /// </summary>
        /// <param name="m">Une matrice d'entiers</param>
        /// <returns>Vrai si la matrice est carrée, faux sinon</returns>
        public static bool EstCarre(int[,] m)
        {
            return false;
        }

        /// <summary>
        /// Détermine si la rangée se situe dans la matrice
        /// </summary>
        /// <example>La rangée 1 existe dans une matrice ayant 2 rangées</example>
        /// <example>La rangée 36 n'existe pas dans une matrice ayant 20 rangées</example>
        /// <example>La rangée 10 n'existe pas dans une matrice ayant 10 rangées</example>
        /// <param name="m">Une matrice</param>
        /// <param name="rangee">L'indice d'une rangée</param>
        /// <returns></returns>
        public static bool EstRangeeValide(int[,] m, int rangee)
        {
            return false;
        }

        /// <summary>
        /// Détermine si la colonne se situe dans la matrice
        /// </summary>
        /// <example>La colonne 1 existe dans une matrice ayant 2 colonnes</example>
        /// <example>La colonne 36 n'existe pas dans une matrice ayant 20 colonnes</example>
        /// <example>La colonne 10 n'existe pas dans une matrice ayant 10 colonnes</example>
        /// <param name="m">Une matrice</param>
        /// <param name="colonne">L'indice d'une colonne</param>
        /// <returns></returns>
        public static bool EstColonneValide(int[,] m, int colonne)
        {
            return false;
        }

        /// <summary>
        /// Détermine si la rangée et la colonne se situent dans la matrice
        /// </summary>
        /// <example>La cellule (1,1) existe dans une matrice 2 par 2</example>
        /// <example>La cellule (0,36) n'existe pas dans une matrice 100 par 10</example>
        /// <example>La cellule (10,10) n'existe pas dans une matrice 10 par 10</example>
        /// <param name="m">Une matrice</param>
        /// <param name="rangee">L'indice d'une rangee</param>
        /// <param name="colonne">L'indice d'une colonne</param>
        /// <returns></returns>
        public static bool EstDedans(int[,] m, int rangee, int colonne)
        {
            return false;
        }


        /// <summary>
        /// Trouve le nombre de cellules dans un matrice 
        /// </summary>
        /// <param name="m">Une matrice</param>
        /// <returns>Le nombre de cases dans la matrice</returns>
        public static int NbCellules(int[,] m)
        {
            return -1;
        }

        /// <summary>
        /// Calcule la densité d'une matrice. La densité d'une matrice est sa proportion d'éléments non-nuls.
        /// Pour la calculer : Nb de cases non nulles / Nb de cases totales.
        /// Une matrice vide a une densité de 0.
        /// </summary>
        /// <param name="m">Une matrice d'entiers</param>
        /// <returns>La densité</returns>
        public static double Densite(int[,] m)
        {
            return -1;
        }


        /// <summary>
        /// Déterminent si deux matrices sont égales. Deux matrices sont égales si elles
        /// ont les mêmes dimensions et que chaque cellule est pareille.
        /// </summary>
        /// <param name="m">Une matrice</param>
        /// <param name="n">Une deuxième matrice</param>
        /// <returns>Vrai si m est égale à n, faux sinon</returns>
        public static bool MatricesEgales(int[,] m, int[,] n)
        {
            return false;
        }

        /// <summary>
        /// Détermine si une matrice est symétrique. Une matrice est symétrique si elle est carrée et
        /// que chaque cellule est identique à son opposé par rapport à la diagonale principales.
        /// Une matrice est symétrique si elle est égale à sa transposée.
        /// </summary>
        /// <example>
        /// 1 4 3 2
        /// 4 5 8 7
        /// 3 8 7 9
        /// 2 7 9 1 est symétrique
        /// </example>
        /// <param name="m">Une matrice</param>
        /// <returns>Vrai si m est symétrique, faux sinon</returns>
        public static bool EstSymetrique(int[,] m)
        {
            return false;
        }

        /// <summary>
        /// Bâtit la transposée d'une matrice. La transposée d'une matrice est une matrice dans laquelle les 
        /// rangées de la première deviennent les colonnes de la deuxième. Fonctionne autant sur des matrices
        /// carrées que rectangulaires
        /// </summary>
        /// 1 2 3       1 4 7 
        /// 4 5 6  -->  2 5 8
        /// 7 8 9       3 6 9
        /// <param name="m">Une matrice</param>
        /// <returns>Sa transposée</returns>
        public static int[,] Transpose(int[,] m)
        {
            return new int[0, 0];
        }

        /// <summary>
        /// Bâtit une matrice identique à la première, mais sur laquelle on a appliqué une rotation de 90 degrés
        /// dans le sens des aiguilles d'une montre. Ne fonctionne que sur des matrices carrées.
        /// </summary>
        /// <example>
        /// 1 2 3       7 4 1
        /// 4 5 6  -->  8 5 2
        /// 7 8 9       9 6 3
        /// </example>
        /// <param name="m">Une matrice carrée</param>
        /// <returns>Sa rotation de 90 degrés dans le sens horaire</returns>
        public static int[,] Rotation90Horaire(int[,] m)
        {
            return new int[0, 0];
        }

        /// <summary>
        /// Bâtit une matrice identique à la première, mais sur laquelle on a appliqué une rotation de 90 degrés
        /// dans le sens contraire des aiguilles d'une montre. Ne fonctionne que sur des matrices carrées.
        /// </summary>
        /// <example>
        /// 1 2 3       3 6 9
        /// 4 5 6  -->  2 5 8
        /// 7 8 9       1 4 7
        /// </example>
        /// <param name="m">Une matrice carrée</param>
        /// <returns>Sa rotation de 90 degrés dans le sens anti-horaire</returns>
        public static int[,] Rotation90AntiHoraire(int[,] m)
        {
            return new int[0, 0];
        }

        /// <summary>
        /// Bâtit une matrice identique à la première, mais sur laquelle on a appliqué une rotation de 180 degrés
        /// Ne fonctionne que sur des matrices carrées.
        /// </summary>
        /// <example>
        /// 1 2 3       9 8 7
        /// 4 5 6  -->  6 5 4
        /// 7 8 9       3 2 1
        /// </example>
        /// <param name="m">Une matrice carrée</param>
        /// <returns>Sa rotation de 90 degrés dans le sens horaire</returns>
        public static int[,] Rotation180(int[,] m)
        {
            return new int[0, 0];
        }

        /// <summary>
        /// Détermine si une matrice est diagonale. Une matrice diagonale est une matrice carrée avec
        /// des zéros partout, sauf peut-être sur la diagonale principale.
        /// </summary>
        /// <example>
        /// 1 0 0 
        /// 0 9 0  Est diagonale
        /// 0 0 7 
        /// </example>
        /// <param name="m">Une matrice d'entiers</param>
        /// <returns>Vrai si la matrice est diagonale, faux sinon</returns>
        public static bool EstDiagonale(int[,] m)
        {
            return false;
        }

        /// <summary>
        /// Copie une matrice d'entier
        /// </summary>
        /// <param name="m">Une matrice d'entiers</param>
        /// <returns>Une copie de cette matrice</returns>
        public static int[,] Copier(int[,] m)
        {
            return new int[0, 0];
        }
    }
}

