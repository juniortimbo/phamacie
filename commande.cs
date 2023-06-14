using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phamacie
{
    public class Commande

    {
        public int Numero { get; set; }
        public DateTime Date { get; set; }
        public Client Client { get; set; }
        public List<Medicament> Medicaments { get; set; }

        public decimal CalculerMontantTotal()
        {
            decimal montantTotal = 0;
            foreach (Medicament medicament in Medicaments)
            {
                montantTotal += medicament.Prix;
            }
            return montantTotal;
        }
    }

   



}
