using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eBiblio.Models
{
    public class ListeAuteurs
    {
        public List<Auteur> ObtenirListeAuteur()
        {
            return new List<Auteur>
            {
                new Auteur { id = 1 , nom = "Auteur1"},
                new Auteur { id = 2 , nom = "Auteur2"},
                new Auteur { id = 3 , nom = "Auteur3"}
            };
        }
    }                           
}