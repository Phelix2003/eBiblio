using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eBiblio.Models;

namespace eBiblio.Controllers
{
    public class RechercheController : Controller
    {
        // GET: Recherche
        public ActionResult Index(string Search)
        {


            ViewData["ListeLivre"] = RechercheLivre(Search);
            ViewData["ListeAuteur"] = RechercheAuteur(Search);

            return View();
        }

        private List<Livre> RechercheLivre(string Search)
        {
            List<Livre> LivreTrouve = new List<Livre> {};
            List<Auteur> auteurs = new ListeAuteurs().ObtenirListeAuteur();
            List<Livre> LivreRecherche = new ListeLivres().ObtenirListeLivre(auteurs[0],auteurs[1],auteurs[2]);

            foreach (Livre livre in LivreRecherche)
            {
                if (livre.Titre.ToLower().Contains(Search.ToLower()))
                    LivreTrouve.Add(livre);
            }
            return LivreTrouve;
        }

        private List<Auteur> RechercheAuteur(string Search)
        {
            List<Auteur> AuteurTrouve = new List<Auteur> { };
            List<Auteur> AuteursCherche = new ListeAuteurs().ObtenirListeAuteur();

            foreach (Auteur auteur in AuteursCherche)
            {
                if (auteur.nom.ToLower().Contains(Search.ToLower()))
                    AuteurTrouve.Add(auteur);
            }
            return AuteurTrouve;
        }


    }
}