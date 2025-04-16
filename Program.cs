using System;

namespace Pendu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comment vous appelez-vous ?");
            string name = "";
            
            // On demande un nom qui ne peut pas être vide
            do {
                name = Console.ReadLine();
            } while (name == null);
            Console.WriteLine("\nBonjour " + name + " ! Nous allons jouer au pendu !\nLe but est simple : vous devez deviner un mot en trouvant les lettres qui le compose une par une.");
            Console.ReadLine();

             bool victoire = Jeu.LancerJeu(name);

            // Fin du jeu
            if (victoire)
            {
                Console.Clear();
                Console.WriteLine("Bravo, " + name + "! Vous avez gagné !\n\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dommage ! Vous avez perdu, " + name + ". \n\n");
            }
            Console.WriteLine("Merci d'avoir joué, " + name + " ! Nous espérons que vous avez passé un agréable moment, et que vous reviendrez une prochaine fois !\n\n");
        }
    }
}
    