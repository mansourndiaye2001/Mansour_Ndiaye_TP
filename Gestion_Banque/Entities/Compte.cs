using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque.Entities
{
    internal  class Compte
    {
    
       
        protected string num;
        protected float solde;
    
        public Compte()
        {
          
        }
        public Compte(string num, float solde)
        {
            this.num = num;
            this.solde = solde;

        }


        public string Num

        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }


        }
        public float Solde
        {
            get
            {
                return solde;
            }
            set
            {

                solde = value;
            }
        }
        public  void AfficheCompte()
        {
            
            Console.WriteLine("Numero du compte" + " " + this.num);
            Console.WriteLine("Solde du compte" + " " + this.solde);
        }
       
        

      
    }
}
