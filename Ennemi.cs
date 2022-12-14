// Classe Ennemi
//
// Un ennemi
//
// L'ennemi a les mêmes statistiques et méthodes que le joueur avec quelques différences
//  - pas d'habilete
//  - pas de méthode pour donner les actions, l'ennemi ne fait qu'attaquer
//  - un nouvel attribut dit si les attaques de l'ennemi sont magiques ou non
//  - une méthode pour dire si les attaques sont magiques ou non, basée sur l'attribut
//
// Création : 2022/11/19
// Par : Frédérik Taleb
// Modification : 2022/11/24
// Par : Frédérik Taleb

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinal_A22
{
    public class Ennemi
    {
        // attributs (public)
        // un nom 
        public string nom;
        // att,
        public int att;
        // matt,
        public int matt;
        // def,
        public int def;
        // mdef,
        public int mdef;
        // hp des entiers
        public int hp;

        // magique un attribut qui détermine si les attaques sont magiques ou non
        public bool magique;
        // Constructeur
        // reçoit tous les attributs en paramètre
        public Ennemi(string nom, int att, int matt, int def, int mdef, int hp, bool magique)
        // assigne les paramètres aux attributs correspondants
        {
            this.nom = nom;
            this.att = att;
            this.matt = matt;
            this.def = def;
            this.mdef = mdef;
            this.hp = hp;
            this.magique = magique;
        }
        // assigne les paramètres aux attributs correspondants

        // estMagique
        public bool estMagique()
        {


            if (this.magique == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // retourne l'attribut magique 

        // @return bool vrai si les attaques sont magiques, faux sinon
        public int attaquer()
        {
            return this.att;
        }
        // attaquer
        //
        // renvoie la statistique d'attaque

        // defendre
        public int defendre(bool magique, int dmg)
        {
            if (magique == true)
            {
                dmg -= this.mdef;
            }
            else
            {
                dmg -= this.def;
            }

            return this.hp -= dmg;

         
        }
        // selon l'attaque, magique ou non, diminue les points de dommage du nombre de points de défense
        // diminiue les points de vie selon les dommages finaux, les dommages finaux ne peuvent pas être sous 0
        //
        // @param bool magique vrai pour une attaque magique, faux sinon
        // @param int dmg      le nombre de point de dommage avant la réduction par la défense
        // si l'attaque est magique

        // les dommages finaux sont le dommage - la défense magique

        // sinon

        // les dommages finaux sont le dommage - la défense

        // diminuer les points de vie du nombre de points de dommage final



        // estVivant
        public bool estVivant()
        {
            if (this.hp < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // détermine s'il reste des points de vie
        // 
        // @return bool vrai s'il reste des points de vie, faux sinon

        // enumererStats
        public string enumererStats()
        {
            return "Nom : " + this.nom + "Hp : " + this.hp;
        }
        // envoie un string contenant le nom et les points de vie
        // "Nom : {0}, Hp : {1}"
        //
        // @return string le nom et les points de vie selon le format établi
    }
}
