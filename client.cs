using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phamacie
{
    public class Client
    {

        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }


        public Client(string Nom, string Adresse, string Email)

        {
            this.Nom = Nom;
            this.Adresse = Adresse;
            this.Email = Email;
        }
}
}
