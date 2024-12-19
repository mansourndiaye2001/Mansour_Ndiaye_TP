using Gestion_Banque.Entities;
using Gestion_Banque.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgenceImp agenceImp = new AgenceImp();
            ClientImp clientImp = new ClientImp();
            List<Agence> list = new List<Agence>();

            
            int choix1,choix,choix2;
            do
            {
                Console.WriteLine("1-Gestion des Agences");
                Console.WriteLine("2-Gestion des Clients et Comptes");
                Console.WriteLine("Faire votre choix ");
                 choix = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choix)
                {
                    case 1:
                        do
                        {


                            Console.WriteLine("1-Ajouter une Agence");
                            Console.WriteLine("2-Modifier une Agence");
                            Console.WriteLine("3-Supprimer une Agence");
                            Console.WriteLine("4-Lister  les Agences");
                            Console.WriteLine("5-Retour");
                            Console.WriteLine("Faire votre choix ");
                            choix1 = int.Parse(Console.ReadLine());
                      
                        Console.Clear();
                        switch (choix1)
                        {
                            case 1:

                                    Agence a = new Agence();
                                    list =agenceImp.add(a);

                                break;
                                Console.Clear();
                                case 2:
                                Console.WriteLine("Saisir l'ID a modifier ");
                                int id = int.Parse(Console.ReadLine());
                                agenceImp.update(id);
                                break;
                                Console.Clear();
                            case 3:
                                Console.WriteLine("Saisir l'ID a Supprimer  ");
                                int ids = int.Parse(Console.ReadLine());
                                agenceImp.delete(ids);
                                break;
                                Console.Clear();
                            case 4:
                                list=  agenceImp.list();
                                break;
                                Console.Clear();
                        }

                       
                        } while (choix1 != 5);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("1-Ajouter un client ");
                            Console.WriteLine("2-Modifier un client ");
                            Console.WriteLine("3-Supprimer un client ");
                            Console.WriteLine("4-Lister  les clients ");
                            Console.WriteLine("5-Retour");
                            Console.WriteLine("Faire votre choix ");
                            choix2 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (choix2)
                            {
                                case 1:
                               
                                    if(list.Count == 0)
                                    {
                                        Console.WriteLine("Vous ne pouvez pas ajouter un client car il y'a pas d'agence");
                                    }
                                    else
                                    {
                                        Client client = new Client();
                                        clientImp.add(client);

                                    }
                                 

                                    break;
                                    Console.Clear();
                                    case 2:
                                    Console.WriteLine("Saisir l'id a modifier ");
                                    int id = int.Parse(Console.ReadLine());
                                    clientImp.update(id);
                                    Console.Clear();

                                    break;
                                    Console.Clear();
                                    case 3:
                                    Console.WriteLine("Saisir l'id a supprimer  ");
                                    int ids = int.Parse(Console.ReadLine());
                                    clientImp.delete(ids);
                                    break;
                                    Console.Clear();
                                    
                                    case 4:
                                    Agence.clientList= clientImp.list();
                                    break;
                                    Console.Clear();
                            }

                        }while(choix2!= 5);
                      
                        break;


                }

            } while (choix !=3);

            Console.ReadKey();

        
        }
    }
}
