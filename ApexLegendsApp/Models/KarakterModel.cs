using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApexLegendsApp.Models
{
    public class KarakterModel
    {
        [Display(Name = "Karakter ID")]
        [Range(1,999999, ErrorMessage ="Je moet een goede ID invoeren")]
        public int KarakterID { get; set; }
        [Required(ErrorMessage = "Vul een Soort in")]
        [Display(Name = "Karakter Soort")]
        public string KarakterSoort { get; set; }
        [Required(ErrorMessage = "Vul een Naam in")]
        [Display(Name = "Karakter Naam")]
        public string KarakterNaam { get; set; }
    }
}
