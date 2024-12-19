using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque.Entities
{
    internal class Client
    {
        public static int idc=0;
        private int id;
        private string nom;
        private string prenom;
        private string tel;
        private Agence agence = new Agence();
        private CompteEpargne  c;
        private CompteSimple compteSimple;
        

        public Client()
        {
          
                idc++;
               this.id = idc;
        }
        public Client(string nom, string prenom, string tel, Agence agence)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.agence = agence;
            this.agence =agence;
        }
       
        public string Nom
        {
            get { return nom; }
            set { nom = value; }


        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public Agence Agence
        {
            get { return agence; }
            set { agence = value; }

        }
        
       public CompteEpargne  Compte
        {
            get { return c; }
            set { c = value; }
        }
        public CompteSimple  CompteSimple
        {
            get { return compteSimple; }
            set { compteSimple = value; }
        }


        public int ID
        {
            get { return id; }
            set { idc = value; }
        }
       

       
        public void AfficherClient()
        {
            Console.WriteLine("Les Informations du client ");
            Console.WriteLine("ID: "+ " "+this.id);
            Console.WriteLine("Nom : "+this.nom +" "+"Prenom: "+" "+this.prenom+ " " +"Tel: "+this.tel);
            Console.WriteLine("Les Informations de l'Agence ");
            agence.AfficheDetails();
            if (compteSimple != null)
            {
                Console.WriteLine("Les Informations du compte ");
                compteSimple.AfficheCompteSimple();
            }
            if (c != null)
            {
                Console.WriteLine("Les Informations du compte ");
                c.AfficheCompteEpargne();
            }
      
            }
            
            
               
            
            
            
        
        public void getClient()
        {
            Console.WriteLine("Les Informations du client ");
            Console.WriteLine("ID: " + " " + this.id);
            Console.WriteLine("Nom : " + this.nom + " " + "Prenom: " + " " + this.prenom + " " + "Tel: " + this.tel);
        }
    }
}
