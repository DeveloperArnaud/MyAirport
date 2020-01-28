using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TriBagageApp
{
    public class Vol
    {
        private int id;
        private String cie;
        private String ligne;
        private DateTime dateVol;
        private String parking;
        private List<Bagage> bagages;
        


        public Vol()
        {


        }
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Cie is required")]
        public String Cie { get; set; }

        [Required(ErrorMessage = "Ligne is required")]
        public String Ligne { get; set; }

        public DateTime DateVol { get; set; }

        public String Parking { get; set; }

        public ICollection<Bagage> Bagages { get; set; }

    }
}
