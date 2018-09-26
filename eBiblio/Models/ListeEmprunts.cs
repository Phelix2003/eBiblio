using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eBiblio.Models
{
    public class ListeEmprunts
    {
        public List<Emprunt> ObtenirListeEmprunts(Client client1, Client client2, Livre livre1, Livre livre2, Livre livre3)
        {
            return new List<Emprunt>
            {
                new Emprunt { Client = client1, ListeLivres = new List<Livre>{ livre1 } },
                new Emprunt { Client = client1, ListeLivres = new List<Livre>{ livre2, livre3}}
            };
        }
    }
}