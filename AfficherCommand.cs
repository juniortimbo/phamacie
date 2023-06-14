using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace phamacie
{ 
 static void AfficherCommandes()
{
    if (commandes.Count == 0)
    {
        Console.WriteLine("Aucune commande enregistrée.");
    }
    else
    {
        Console.WriteLine("Liste des commandes :");
        foreach (Commande commande in commandes)
        {
            Console.WriteLine($"Numéro de commande : {commande.Numero}");
            Console.WriteLine($"Date de commande : {commande.Date}");
            Console.WriteLine($"Client : {commande.Client.Nom}");
            Console.WriteLine("Médicaments :");
            foreach (Medicament medicament in commande.Medicaments)
            {
                Console.WriteLine($"- {medicament.Nom} (Quantité : {medicament.Quantite}, Prix unitaire : {medicament.Prix})");
            }
            Console.WriteLine($"Montant total : {commande.CalculerMontantTotal()}");
            Console.WriteLine("-----------------------------------");
        }
    }
}
}