using System;
using System.Text.RegularExpressions;

namespace Pendu
{
    internal class Jeu
    {
        public static bool LancerJeu(string name)
        {
            const int MAX_ESSAIS = 6;

            // Choix du mot à deviner
            string motADeviner = ChoisirMot();
            string motCache = new string('_', motADeviner.Length);
            int essaisRestants = MAX_ESSAIS;
            List<char> lettresDejaEssayees = new List<char>();
            
            // Lancement de la boucle principale du jeu
            while (essaisRestants > 0 && motCache != motADeviner)
            {
                Console.Clear();
                
                // On affiche le mot à deviner avec des "_" pour les lettres non trouvées, le nombre d'essais restants avant de perdre, et les lettres que le joueur a déjà essayées
                Console.WriteLine("Mot à deviner : " + motCache + "\nEssais restants : " + essaisRestants + "\nLettres déjà essayées : " + string.Join(", ", lettresDejaEssayees));

                // Le joueur saisit une lettre
                Console.Write("Entrez une lettre : ");
                char lettre = Console.ReadKey().KeyChar;
                Console.WriteLine();
                
                // Si la lettre a déjà été essayée, on affiche un message et on reprend au début de la boucle While, sinon, on l'ajoute à la liste
                if (lettresDejaEssayees.Contains(lettre))
                {
                    Console.WriteLine("Vous avez déjà essayé cette lettre !");
                    continue;
                }
                lettresDejaEssayees.Add(lettre);

                // Si la lettre est contenue dans le mot à deviner, on retire le caractère "_" du mot à l'indice correspondant, puis on insère la lettre tapée
                if (motADeviner.Contains(lettre))
                {
                    for (int i = 0; i < motADeviner.Length; i++)
                    {
                        if (motADeviner[i] == lettre)
                        {
                            motCache = motCache.Remove(i, 1);
                            motCache = motCache.Insert(i, lettre.ToString());
                        }
                    }
                    Console.WriteLine("Bien joué ! La lettre " + lettre + " est dans le mot.");
                }
                else
                {
                    essaisRestants--;
                    Console.WriteLine("Dommage ! La lettre " + lettre + " n'est pas dans le mot.");
                }
                Console.ReadLine();
            }
            
            // Retourne "true" si le mot a été deviné, "false" sinon
            return (motCache == motADeviner);
        }

        public static string ChoisirMot()
        {
            // Liste de mots à deviner
            List<string> mots = new List<string>
            {
                "pamplemousse",
                "ordinateur",
                "programmer",
                "dinosaure",
                "jeu",
                "champignon",
                "kayak",
                "deltaplane",
                "ficelle",
                "automobile"
            };
            Random random = new Random();
            int index = random.Next(mots.Count);
            return mots[index];
        }
    }
}
