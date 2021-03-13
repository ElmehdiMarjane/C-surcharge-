using System;
using System.Collections.Generic;
using System.Text;

namespace BanquePr
{
    class Client
    {
        private string nom;
        private string prenom;
        private string email;

        public Client(string nom,string prenom,string email)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;


        }

        public string Afficher()
        {


            return ("Le nom: "+this.nom+" le prenom : "+this.prenom+" L'email : "+this.email).ToString();
        }



    }
}
