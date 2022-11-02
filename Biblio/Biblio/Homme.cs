using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    /// <summary>
    /// Cette classe est utilisée pour créer un homme 
    /// avec pas beaucoup de detail mais c'est un exemple
    /// </summary>
    public class Homme
    {
        int taille;
        string Sexe;
        string couleurCheveux;
        public event EventHandler<EventArgs> ChangementCouleurCheveux;
        /// <summary>
        /// Ce constructeur permet de donné les caractéristiques de l'homme.
        /// </summary>
        /// <param name="taille">grandeur de l'homme</param>
        /// <param name="sexe">Femme ou Homme</param>
        /// <param name="couleurCheveux">Couleur de cheveux que a l'homme</param>
        public Homme(int taille, string sexe, string couleurCheveux)
        {
            this.taille = taille;
            Sexe = sexe;
            this.couleurCheveux = couleurCheveux;
        }


        public void ChangerCouleurCheveux(string nouvelleCouleurCheveux)
        {
            //ChangementCouleurCheveux?.Invoke(this,);
            this.couleurCheveux = nouvelleCouleurCheveux;
        }
        /// <summary>
        /// Cette fonction permet de rajouter une langue que l'homme 
        /// utilise pour communiquer.
        /// </summary>
        /// <param name="langue">Français, anglais et etc</param>
        /// <returns></returns>
        public string LangueParle(string langue)
        {
            langue = "";
            return langue;
        }

        
    }
}
