using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Joueur
    {
        private string pseudoJoueur;
        private int scoreJoueur;
        private bool joueurIA = false;
        private bool relance = false;


        /// <summary>
        /// Constructeur de joueur, fournir le pseudo et le type de joueur
        /// </summary>
        /// <param name="pseudo">Pseudo du joueur</param>
        /// <param name="ia">Si est IA ou non</param>
        public Joueur(string pseudo, bool ia) {
            this.pseudoJoueur = pseudo;
            this.joueurIA = ia;
        }


        public void lancerDe()
        {
            
        }

    }
}
