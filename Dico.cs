using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu
{
    internal class Dico
    {
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
