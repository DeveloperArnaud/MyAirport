using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Key]
        public int Id { get; set; }

        [ForeignKey("VolId")]
        public int VolId { get; set; }

        [Required(ErrorMessage = "CodeIATA is required")]
        public string CodeIATA { get; set; }

        public int? Poids { get; set; }
        private Vol Vol { get; set; }



    }
}
