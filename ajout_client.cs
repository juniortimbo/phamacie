using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace phamacie
{
        public static void ajouter()
    {
        Console.WriteLine("donner son nom");
        string? Nom = Console.ReadLine();

        Console.WriteLine("donne son adresse");
        string? Adresse = Console.ReadLine();

        Console.WriteLine("donner son mail");
        string? Email = Console.ReadLine();

        Client client = new Client(Nom, Adresse, Email);
    }

    

    }


