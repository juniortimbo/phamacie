using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phamacie
{
     class programme_pricipal
    {
        static List<Medicament> stock = new List<Medicament>();
        static List<Commande> commandes = new List<Commande>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("=== Gestion de pharmacie ===");
                Console.WriteLine("1. Ajouter un médicament");
                Console.WriteLine("2. Passer une commande");
                Console.WriteLine("3. Afficher les commandes");
                Console.WriteLine("4. Quitter");
                Console.Write("Choisissez une option : ");

                string choix = Console.ReadLine();
                Console.WriteLine();

                switch (choix)
                {
                    case "1":
                        AjouterMedicament();
                        break;
                    case "2":
                        PasserCommande();
                        break;
                   /* case "3":
                        AfficherCommandes();
                        break;
               */
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Option invalide. Veuillez réessayer.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AjouterMedicament()
        {
            Medicament medicament = new Medicament();


            Console.Write("Nom du médicament : ");
            medicament.Nom = Console.ReadLine();

            Console.Write("Quantité : ");
            medicament.Quantite = int.Parse(Console.ReadLine());

            Console.Write("Prix : ");
            medicament.Prix = decimal.Parse(Console.ReadLine());

            stock.Add(medicament);

            Console.WriteLine("Médicament ajouté avec succès !");
        }

        static void PasserCommande()
        {
            Commande commande = new Commande();

            Console.Write("Numéro de commande : ");
            commande.Numero = int.Parse(Console.ReadLine());

            Console.Write("Date de commande : ");
            commande.Date = DateTime.Parse(Console.ReadLine());

            Client client = new Client();

            Console.Write("Nom du client : ");
            client.Nom = Console.ReadLine();

            Console.Write("Adresse du client : ");
            client.Adresse = Console.ReadLine();

            Console.Write("Email du client : ");
            client.Email = Console.ReadLine();

            commande.Client = client;

            commande.Medicaments = new List<Medicament>();

            while (true)
            {
                Console.Write("Ajouter un médicament (oui/non) ? ");
                string reponse = Console.ReadLine();







            }
        }
    }
}


