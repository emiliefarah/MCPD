using System;
using exo_poo.classe;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Chaise c1 = new Chaise(4, "bois", "marron");
            Chaise c2 = new Chaise(6, "metal", "bleu");
            Chaise c3 = new Chaise(4, "tissus", "rose");
            Chaise c4 = new Chaise(3, "plastique", "orange");



            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);



        }









    }
}