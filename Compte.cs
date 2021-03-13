using System;
using System.Collections.Generic;
using System.Text;

namespace BanquePr
{
    class Compte
    {
        private int Numcompte;
        static int cpt = 0;
        Client Titulaire;
        MAD Solde;
        MAD Plafond;


        public Compte(Client Titulaire,MAD Solde,MAD Plafond)
        {
            this.Numcompte = ++cpt;
            this.Titulaire = Titulaire;
            this.Solde = Solde;
            this.Plafond = Plafond;

        }

        public bool Credite(MAD Montant)
        {

                this.Solde = this.Solde + Montant;
                Console.WriteLine("Success");
                return true;

        }
        public bool Debite(MAD Montant)
        {
            if (Montant <= this.Plafond)
            {

                this.Solde = this.Solde - Montant;
                return true;
                Console.WriteLine("Success");

            }

            else
            {

                Console.WriteLine("Plafond Depasse");
                return true;

            }
        }

        public bool Virement(Compte c,MAD Montant)
        {


            if (this.Solde >= Montant) { 
            this.Solde = this.Solde - Montant;
            c.Solde = c.Solde + Montant;
             Console.WriteLine("Montant Transfere");

                return true;

            }
            else
            {

                Console.WriteLine("Sold insuffisant");

                return false;
            }
        }



        public void Consuter()                                                                                             
        {


            Console.WriteLine(" Num: " + this.Numcompte + " Client  : " + this.Titulaire.Afficher() + " Le Solde : " + this.Solde.AffV());

        }

    }
}
