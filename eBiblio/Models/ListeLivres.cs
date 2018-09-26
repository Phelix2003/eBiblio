using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eBiblio.Models
{
    public class ListeLivres
    {
        public List<Livre> ObtenirListeLivre(Auteur auteur1, Auteur auteur2, Auteur auteur3)
        {
            return new List<Livre>
            {
                new Livre { Auteur = auteur1, Id = 1 , Parution = DateTime.Now  , Titre = "Tom1" },
                new Livre { Auteur = auteur1, Id = 2 , Parution = DateTime.Parse("01/08/2012")  , Titre = "Tom2" },
                new Livre { Auteur = auteur2, Id = 3 , Parution = DateTime.Parse("02/08/2013")  , Titre = "Tom3" },
                new Livre { Auteur = auteur3, Id = 4 , Parution = DateTime.Parse("03/08/2014")  , Titre = "Tom4" },
                new Livre { Auteur = auteur3, Id = 5 , Parution = DateTime.Parse("04/08/2015")  , Titre = "Tom5" }
            };

        }
    }
}
