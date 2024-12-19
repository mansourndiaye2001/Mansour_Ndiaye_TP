using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque.Entities
{
    internal class Agence
    {
        public static int nbA=0;
        private int id;
        private string code;
        private string libelle;
        public static  List<Client>clientList  = new List<Client>();
        public Agence() {
            nbA++;
            this.id=nbA;
        }
       
        public Agence(string code)
        {
            this.code = code;
         
         

        }
        public int Id
        {
            get { return id; }
        }
            

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }


        }
        public string Libelle
        {
            get
            {
                return libelle;
            }
            set
            {
                libelle = value;
            }
        }
      
        public void AfficheDetails()
        {
            Console.WriteLine("ID :" + " " + this.id);
            Console.WriteLine("Libelle :"+ " "+this.Libelle);
            Console.WriteLine("Code :" + " " + this.Code);
        }
      
       }
    }
 

