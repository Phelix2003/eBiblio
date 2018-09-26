using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eBiblio.Models
{
    public class Emprunt
    {
        public Client Client { get; set; }
        public List<Livre> ListeLivres { get; set; }
    }
}