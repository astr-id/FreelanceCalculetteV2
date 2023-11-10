using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceCalculetteV2
{
    public class CalculFacture
    {
        private decimal totalBrut = 0;
        private string reponse;

        public decimal TotalBrut
        {
            get { return totalBrut; }
            set { totalBrut = value; }
        }

        public void CalculerTotal()
        {
            while (true)
            {
                Console.WriteLine("Entrez le montant de vos factures. Entrez STOP une fois que vous avez terminé");
                reponse = Console.ReadLine();

                if (reponse == "STOP")
                {
                    break;
                }
                if (decimal.TryParse(reponse, out decimal montant))
                {
                    TotalBrut += montant;
                }
                else
                {
                    Console.WriteLine("Montant invalide. Veuillez entrer un nombre valide.");
                }
            }
        }

        public void AfficherResultats()
        {
            decimal totalNet = TotalBrut * 0.75m;
            decimal plafond = 36800;

            Console.WriteLine("Brut Annuel : " + TotalBrut + " euros");
            Console.WriteLine("Net Annuel : " + totalNet + " euros");
            Console.WriteLine("Brut Mensuel : " + GetMensual(TotalBrut) + " euros");
            Console.WriteLine("Net Mensuel : " + GetMensual(totalNet) + " euros");

            if (TotalBrut < plafond)
            {
                Console.WriteLine("Vous êtes à " + (plafond - TotalBrut) + " euros du plafond");
            }
            else
            {
                Console.WriteLine("Attention ! Vous dépassez le plafond de " + (TotalBrut - plafond) + " euros du plafond");
            }
        }

        private decimal GetMensual(decimal total)
        {
            return total / 12;
        }
    }
}
