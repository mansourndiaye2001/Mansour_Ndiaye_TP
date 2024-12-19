using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque.Entities
{
    internal class CompteEpargne : Compte

    {
        public static int nbA=0;
        private int id;
        private int dure;
      
         
       
        public CompteEpargne()
        {
            nbA++;
        this.id = nbA;
         
           
        }

        public CompteEpargne(int dure, string num, float solde) : base(num, solde)
        {
            this.dure = dure;
        }

        public int Dure
        {
            get { return dure; }
            set { dure = value; }
        }
        public int ID
        {
            get { return id; }
        }

        public void AfficheCompteEpargne()
        {
            Console.WriteLine("ID " + " " + this.id);
            Console.WriteLine("Numero du compte" + " "+this.num);
            Console.WriteLine("Solde du compte" + " " + this.solde);
            Console.WriteLine("Durre du compte" + " " + this.dure);
        }
    }
}
