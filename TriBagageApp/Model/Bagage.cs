using System;
using System.Collections.Generic;

namespace TriBagageApp
{
    public class Bagage
    {
        private int id;
        private int idVol;
        private String codeIATA;
        private int poids;
        private Vol vol;

        public Bagage()
        {

        }
        
        public int Id { get; set; }

        public int IdVol { get; set; }

        public int CodeIATA { get; set; }

        public int Poids { get; set; }

        private Vol Vol { get; set; }



    }
}
