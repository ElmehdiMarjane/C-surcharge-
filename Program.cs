using System;

namespace BanquePr
{
    class Program
    {
        static void Main(string[] args)
        {

            Client a;
            Compte c, p;
            a = new Client("Med","me","med@me.co");
            c = new Compte(a,new MAD(20000),new MAD(4000));
            p = new Compte(a, new MAD(100000), new MAD(6000));


            c.Consuter();
            p.Consuter();
            c.Debite(new MAD(4000));
            p.Credite(new MAD(2000));
            c.Consuter();
            p.Consuter();

            p.Virement(c, new MAD(3000));

            c.Consuter();
            p.Consuter();
        }
    }
}
