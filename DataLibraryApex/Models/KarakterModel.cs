using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibraryApex.Models
{
    public class KarakterModel
    {
        public int Id { get; set; }
        public int KarakterId { get; set; }
        public string KarakterSoort { get; set; }
        public string KarakterNaam { get; set; }
    }
}
