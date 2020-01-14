using System;
using System.Collections.Generic;

namespace TriBagageApp
{
    public class Vol
    {
        private int id;
        private String cie;
        private String ligne;
        private DateTime dateVol;
        private String parking;
        private List<Bagage> lesBagages;
        


        public Vol()
        {


        }

        public int Id { get; set; }

        public String Cie { get; set; }

        public String Ligne { get; set; }

        public DateTime DateVol { get; set; }

        public String Parking { get; set; }

        private List<Bagage> LesBagages { get; set; }

    }
}
