using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generique
{
    public class MaListeGenerique<T> 
    {
        private int capacite;
        private int nbElement;
        private T[] tableau;

        public MaListeGenerique()
        {
            capacite = 10;
            nbElement = 0;
            tableau = new T[capacite];
        }

        public void Ajouter(T element)
        {
            if (nbElement >= capacite)
            {
                capacite *= 2;
                T[] copieTableau = new T[capacite];
                for (int i = 0; i < tableau.Length; i++)
                {
                    copieTableau[i] = tableau[i];
                }
                tableau = copieTableau;
            }
            tableau[nbElement] = element;
            nbElement++;
        }
        public T ObtenirElement(int indice)
        {
            return tableau[indice];
        }
    }
}
