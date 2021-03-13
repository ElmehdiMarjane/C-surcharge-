using System;
using System.Collections.Generic;
using System.Text;

namespace BanquePr
{
    class MAD
    {
        private double Valeur;


        public MAD(double Valeur)
        {

            this.Valeur = Valeur;
        }


         public static MAD operator+(MAD M,MAD P){
            MAD tot;
            tot = new MAD(1000);
            tot.Valeur = M.Valeur + P.Valeur;
            return tot;
            }
        public static MAD operator -(MAD M, MAD P)
        {
            MAD tot;
            tot = new MAD(0);
            tot.Valeur = M.Valeur - P.Valeur;
            return tot;
        }

        public static bool operator <(MAD M, MAD P)
        {
            if (M.Valeur < P.Valeur) {
          
            return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(MAD M, MAD P)
        {

            if (M.Valeur > P.Valeur)
            {

                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool operator <=(MAD M, MAD P)
        {
            if (M.Valeur <= P.Valeur)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(MAD M, MAD P)
        {
            if (M.Valeur >= P.Valeur)
            {

                return true;
            }
            else
            {
                return false;
            }
        }


        public string AffV()
        {


            return this.Valeur.ToString();
        }


    }
}
