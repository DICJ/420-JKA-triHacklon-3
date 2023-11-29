using System.Text.RegularExpressions;

namespace Trihacklon3
{
    public class Program
    {
        private const char QUIT = 'Q';
        /// <summary>
        /// Imprime une chaîne à la console en Cyan, puis rétablit à couleur initiale
        /// </summary>
        /// <param name="s">La chaîne à imprimer en couleur</param>
        static void MotImportant(string s)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(s);
            Console.ResetColor();
        }

        /// <summary>
        /// Imprime une matrice à la console avec une jolie bordure
        /// </summary>
        /// <param name="m">La matrice à imprimer</param>
        public static void ImprimerMatrice(int[,] m)
        {
            int largestCell = 0;
            foreach (int c in m)
            {
                if (c.ToString().Length > largestCell)
                    largestCell = c.ToString().Length;
            }
            largestCell++;
            int largeur = largestCell * m.GetLength(1) + 1;
            MotImportant("╔");
            for (int i = 0; i < largeur; i++) MotImportant("═");
            MotImportant("╗");
            Console.WriteLine();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                MotImportant("║");
                for (int j = 0; j < m.GetLength(1); j++)
                    Console.Write(Convert.ToString(m[i, j]).PadLeft(largestCell));
                MotImportant(" ║");
                Console.WriteLine();
            }
            MotImportant("╚");
            for (int i = 0; i < largeur; i++)
                MotImportant("═");
            MotImportant("╝");
            Console.WriteLine();
        }

        /// <summary>
        /// Imprime un labyrinthe à la console avec une jolie bordure.
        /// </summary>
        /// <param name="m">Le labyrinthe à imprimer</param>
        public static void ImprimerLabyrhinthe(int[,] m)
        {
            int largeur = 3 * m.GetLength(1);
            MotImportant("╔");
            for (int i = 0; i < largeur; i++) MotImportant("═");
            MotImportant("╗");
            Console.WriteLine();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                MotImportant("║");
                for (int j = 0; j < m.GetLength(1); j++)
                    if (m[i, j] <= -2)
                        Console.Write("███");
                    else if (m[i, j] == -1)
                        Console.Write(" $ ");
                    else if (m[i, j] == 0)
                        Console.Write("   ");
                    else
                        Console.Write(" · ");
                MotImportant("║");
                Console.WriteLine();
            }
            MotImportant("╚");
            for (int i = 0; i < largeur; i++)
                MotImportant("═");
            MotImportant("╝");
            Console.WriteLine();
        }

        /// <summary>
        /// Imprime un tableau à la console, avec jolie bordure
        /// </summary>
        /// <param name="t">Le tableau à imprimer</param>
        static void ImprimerTableau(int[] t)
        {
            int largeur = 0;
            foreach (int c in t)
                largeur += c.ToString().Length + 1;

            MotImportant("╔");
            for (int i = 0; i < largeur; i++) MotImportant("═");
            MotImportant("╗");
            Console.WriteLine();

            MotImportant("║");
            for (int i = 0; i < t.Length; i++)
                Console.Write(t[i] + " ");
            MotImportant("║");
            Console.WriteLine();

            MotImportant("╚");
            for (int i = 0; i < largeur; i++)
                MotImportant("═");
            MotImportant("╝");
            Console.WriteLine();
        }

        /// <summary>
        /// Bâtit ne matrice d'entier à partir d'une string dans laquelle les lignes sont séparées par des ; 
        /// </summary>
        /// <param name="entree">Une chaîne de caractères</param>
        /// <returns>La matrice décrite par la chaîne. Nul si la chaîne ne représente pas une matrice d'entiers</returns>
        static int[,] Decortiquer(string entree)
        {
            Regex rx = new Regex(@"^(( *-?\d)+;)+$");
            if (!rx.IsMatch(entree))
                return null;
            string[] lignes = entree.Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] colonnes = lignes[0].Split(" ");
            int nbColonnes = colonnes.Length;
            int nbLignes = lignes.Length;
            int[,] m = new int[nbLignes, nbColonnes];
            for (int i = 0; i < nbLignes; i++)
            {
                colonnes = lignes[i].Split(" ");
                if (colonnes.Length != nbColonnes)
                    return null;
                for (int j = 0; j < nbColonnes; j++)
                    m[i, j] = int.Parse(colonnes[j]);
            }
            return m;
        }

        /// <summary>
        /// Lit une entrée multiligne de l'usager puis bâtit une matrice d'entiers avec.
        /// Si l'entrée ne représente pas une matrice, la matrice retournée est nulle.
        /// </summary>
        /// <returns>Une matrice contenant l'entrée de l'usager. Nul si l'entrée ne représente pas une matrice.</returns>
        static int[,] LireMatrice()
        {
            string entree = "";
            string next;
            do
            {
                next = Console.ReadLine().Trim();
                if (next != "")
                    entree += next + ";";
            } while (next != "");
            return Decortiquer(entree);
        }

        /// <summary>
        /// Affiche des caractéristiques d'une matrice
        /// </summary>
        static void ImprimerCaracteristiquesMatrices(int[,] m)
        {
            ImprimerMatrice(m);
            Console.WriteLine();

            Console.WriteLine("\nDiagonale descendante");
            ImprimerTableau(CalculatriceMatrices.DiagonalesDescendantes(m));
            Console.WriteLine("\nDiagonale montante");
            ImprimerTableau(CalculatriceMatrices.DiagonalesMontantes(m));
            Console.WriteLine("\nQueue de colombe");
            ImprimerTableau(CalculatriceMatrices.QueueDeColombe(m));
            Console.WriteLine("\nZigzag horizontal");
            ImprimerTableau(CalculatriceMatrices.ZigzagHorizontal(m));
            Console.WriteLine("\nSpirale");
            ImprimerTableau(CalculatriceMatrices.Spirale(m));

            if (CalculatriceMatrices.EstCarre(m))
            {
                Console.WriteLine("\nElle est carrée");
                Console.WriteLine("Sa rotation de 90 degrés dans le sens des aiguilles d'une montre");
                ImprimerMatrice(CalculatriceMatrices.Rotation90Horaire(m));
                Console.WriteLine("\nSa rotation de 180 degrés");
                ImprimerMatrice(CalculatriceMatrices.Rotation180(m));
                Console.WriteLine("\nSa rotation de 90 degrés dans le sens contraire des aiguilles d'une montre");
                ImprimerMatrice(CalculatriceMatrices.Rotation90AntiHoraire(m));
            }
            if (CalculatriceMatrices.EstSymetrique(m))
                Console.WriteLine("\nElle est symétrique");

            Console.WriteLine($"\nSa densité est de {Math.Round(CalculatriceMatrices.Densite(m) * 100)}%.");
            Console.WriteLine("\nSa transpose");
            ImprimerMatrice(CalculatriceMatrices.Transpose(m));
        }

        /// <summary>
        /// Affiche des caractéristiques de matrices entrées par l'utilisateur
        /// </summary>
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine($"Entrez une matrice ligne par ligne.");
                Console.WriteLine($"Séparez les cases par des espaces. Pour terminer, entrez une ligne vide.");
                int[,] m = LireMatrice();
                if (m != null)
                    ImprimerCaracteristiquesMatrices(m);
                else
                    Console.WriteLine("Ceci n'est pas une matrice d'entier valide.");
                Console.WriteLine($"\n\nAppuyez sur une touche pour continuer. Pour quitter, entrez '{QUIT}'\n");
            } while (Console.ReadKey().KeyChar != QUIT);
        }
    }
}