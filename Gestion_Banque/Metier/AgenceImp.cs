using Gestion_Banque.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque.Metier
{
    internal class AgenceImp : IRepository<Agence>

    {
       public static  List<Agence> AgenceList = new List<Agence>();

        public List<Agence> add(Agence t)
        {
          
            string libelle,code;
            Console.WriteLine("Saisir le libelle de l'Agence ");
            libelle= Console.ReadLine();
            if(libelle.Length < 3)
            {
                t.Code = "000" + libelle.Substring(0,libelle.Length );
            }
            else
            {
                t.Code = "000" + libelle.Substring(0, 3);
            }
            t.Code = "000" + libelle.Substring(0, 3);
            t.Libelle = libelle;
             AgenceList.Add(t);
            Console.WriteLine("L'Agence  a ete ajoute  avec succes");
            return AgenceList;

            
        }

        public void delete(int id)
        {
           for (int i = 0; i < AgenceList.Count; i++)
            {
                if (AgenceList[i].Id == id)
                {
                    AgenceList.Remove(AgenceList[i]);
                    Console.WriteLine("L'Agence  a ete supprime  avec succes");
                }

            }
        }

        public List<Agence>  list()
        {
            int i;
         
            for( i = 0; i < AgenceList.Count(); i++)
            {
                AgenceList[i].AfficheDetails();
               
            }
            return AgenceList;

         

        }
           
        

        public void update(int id)
        {
            String libelle,code;
            for (int i = 0; i < AgenceList.Count; i++)
            {
                if (AgenceList[i].Id == id)
                {
                    Console.WriteLine("Saisir le libelle de l'Agence ");
                   AgenceList[i].Libelle= libelle = Console.ReadLine();
                    AgenceList[i].Code = "000"+libelle.Substring(0, 3);
                    Console.WriteLine("L'Agence  a ete modifie  avec succes");


                }

            }
        }
    }
}
