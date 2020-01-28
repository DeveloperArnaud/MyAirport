using System;
using TriBagageApp.Context;

namespace TriBagageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (MyAirportContext context = new MyAirportContext())
            {
                Bagage b1 = new Bagage { CodeIATA = "098765432" };
                Bagage b2 = new Bagage { CodeIATA = "098723543", Poids = 4 };

                Vol v1 = new Vol { Cie = "LH",
                    DateVol = Convert.ToDateTime("12/12/2020 16:12"),
                    Ligne = "34567",
                    Parking = "7UY",
                    Bagages = new System.Collections.Generic.List<Bagage> { b1, b2} 
            };

                Vol v2 = new Vol
                {
                    Cie = "SQ",
                    DateVol = Convert.ToDateTime("12/12/2020 21:21"),
                    Ligne = "222",
                    Parking = "Z54"
                };

                context.Add(v1);
                context.Add(v2);
                context.SaveChanges();
               


            }
        }
    }
}
