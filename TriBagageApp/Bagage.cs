using System;
using System.Collections.Generic;

namespace TriBagageApp
{
    public class Bagage
    {
        public int Id { get; set; }
        public int IdVol { get; set; }
        public int CodeIATA { get; set; }
        public int Poids { get; set; }
        private Vol Vol { get; set; }
        public List<Bagage> Bagages { get; set; }




    }
}
