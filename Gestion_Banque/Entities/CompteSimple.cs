using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque.Entities
{
    internal class CompteSimple : Compte
    {
        private int tauxdecouvert;
        private int id;
        public static int nba = 0;
        public CompteSimple()
        {
            nba++;
            this.id = nba;
        }
       
        public int Tauxdecouvert
        {
            get { return tauxdecouvert; }
            set
            {
                tauxdecouvert = value;
            }

        }
       
        public CompteSimple(string num,float solde ,int tauxdecouvert) : base(num, solde)
        {
            this.tauxdecouvert = tauxdecouvert;
        }
        public void AfficheCompteSimple()
        {
            Console.WriteLine("ID " + " " + this.id);
            Console.WriteLine("Numero du compte" + " " + this.num);
            Console.WriteLine("Solde du compte" + " " + this.solde);
            Console.WriteLine("Taux du compte" + " " + this.Tauxdecouvert);
        }

    }
}
