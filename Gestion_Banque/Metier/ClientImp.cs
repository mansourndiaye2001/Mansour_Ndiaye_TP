using Gestion_Banque.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque.Metier
{
    internal class ClientImp : IRepository<Client>
    {
     
        public List<Agence>listAgence = new List<Agence>();
        public List<Client> add(Client t)

        {

          
            string nom, prenom, tel,num;
            int pos;
            Console.WriteLine("Saisir le nom du Client ");
            nom = Console.ReadLine();
            Console.WriteLine("Saisir le prenom du Client ");
            prenom = Console.ReadLine();
            Console.WriteLine("Saisir le numero de telephone  du Client ");
            tel = Console.ReadLine();
            Console.WriteLine("Saisir l'id de l'agence ");
            listAgence = new AgenceImp().list();
            pos = int.Parse(Console.ReadLine());
            t.Agence = listAgence[pos-1];
            t.Nom = nom;
            t.Prenom = prenom;
            t.Tel = tel;
            Console.WriteLine("veuillez choisir le compte a creer ");
            Console.WriteLine("1-Compte Simple ");
            Console.WriteLine("2-Compte Epargne ");
            Console.WriteLine("Faire votre choix ");
            int choix = int.Parse(Console.ReadLine());
            if (choix == 2)
            {

                Console.WriteLine("Saisir le solde du compte ");
                float solde = float.Parse(Console.ReadLine());
                Console.WriteLine("Saisir la duree ");
                int duree= int.Parse(Console.ReadLine());
                CompteEpargne   c = new CompteEpargne();
                c.Dure=duree;
                c.Solde = solde;
                c.Num = "000" + t.ID + t.Tel;
                t.Compte = c;
                Console.WriteLine("Le Client a ete ajoute avec succes");
          
                Agence.clientList.Add(t);



            }
              if(choix==1)
            {
                Console.WriteLine("Saisir le solde du compte ");
                float solde = float.Parse(Console.ReadLine());
                Console.WriteLine("Saisir le Taux ");
                int taux  = int.Parse(Console.ReadLine());
                CompteSimple  c1 = new CompteSimple();
                c1.Tauxdecouvert = taux;
                c1.Solde = solde;
                c1.Num = "000" + t.ID + t.Tel;
                t.CompteSimple = c1;
               
                Agence.clientList.Add(t);
                Console.WriteLine("Le Client a ete ajoute avec succes");


            }






            return Agence.clientList;
        }

        public void delete(int id)
        {
          for(int i =0; i< Agence.clientList.Count; i++)
            {
                if(Agence.clientList[i].ID == id)
                {
                    Agence.clientList.RemoveAt(i);
                    Console.WriteLine("Le Client a ete supprime avec succes");
                }
            }
        }

        public List<Client>list()
        {
            for (int i = 0; i < Agence.clientList.Count; i++)
            {
                Agence.clientList[i].AfficherClient();

            }
            return Agence.clientList;
        }

        public void update(int id)
        {
            for (int i = 0; i < Agence.clientList.Count; i++)
            {
                if (id == Agence.clientList[i].ID)
                {
                    Console.WriteLine("Saisir les Nouvelles Informations ");
                    string nom, prenom, tel, num;
                    int pos;
                    Console.WriteLine("Saisir le nom du Client ");
                    nom = Console.ReadLine();
                    Console.WriteLine("Saisir le prenom du Client ");
                    prenom = Console.ReadLine();
                    Console.WriteLine("Saisir le numero de telephone  du Client ");
                    tel = Console.ReadLine();
                    Agence.clientList[i].Tel = tel;
                    Agence.clientList[i].Nom = nom;
                    Agence.clientList[i].Prenom = prenom;
                    num = "000" + Agence.clientList[i].ID + Agence.clientList[i].Tel;
                    Console.WriteLine("Les informations du  Client a ete modifie  avec succes");


                    Console.WriteLine("Voulez-vous modifiez les informations de votre Compte 1  ou Non ?");
                    string reponse = Console.ReadLine();
                    if (reponse == "oui" ||  reponse =="OUI")
                    {
                        if (Agence.clientList[i].Compte != null)
                        {
                            Console.WriteLine("saisir la duree ");
                            int duree = int.Parse(Console.ReadLine());
                            Agence.clientList[i].Compte.Dure = duree;
                            Console.WriteLine("saisir le solde  ");
                            int solde  = int.Parse(Console.ReadLine());
                            Agence.clientList[i].Compte.Solde = solde;
                            Agence.clientList[i].Compte.Num = num;
                             Console.WriteLine("Le Client a ete ajoute avec succes");


                            Console.WriteLine("Les informations du  Compte a ete modifie  avec succes");


                        }
                        if (Agence.clientList[i].CompteSimple != null)
                        {
                            Console.WriteLine("saisir le Taux  ");
                            int Taux = int.Parse(Console.ReadLine());
                            Agence.clientList[i].CompteSimple.Tauxdecouvert = Taux;
                            Console.WriteLine("saisir le solde  ");
                            int solde = int.Parse(Console.ReadLine());
                            Agence.clientList[i].CompteSimple.Solde = solde;
                            Agence.clientList[i].CompteSimple.Num = num;
                            Console.WriteLine("Les informations du  Compte ont ete modifie  avec succes");

                        }

                    }
                   
                }
            }
        }
        public void ALLClient()
        {
            for(int i = 0; i < Agence.clientList.Count; i++)
            {
                Agence.clientList[i].getClient();
            }
        }
    }
}
