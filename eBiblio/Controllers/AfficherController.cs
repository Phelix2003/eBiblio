using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eBiblio.Models;

namespace eBiblio.Controllers
{
    public class AfficherController : Controller
    {
        // GET: Afficher
        public ActionResult Index()
        {
            ListeAuteurs listeAuteurs = new ListeAuteurs();
            List<Auteur> listea = listeAuteurs.ObtenirListeAuteur();
            ListeLivres listeLivres = new ListeLivres();
            ViewData["ListeLivres"] = listeLivres.ObtenirListeLivre(listea[0], listea[1], listea[2]);



            return View();
        }

        public ActionResult Auteurs()
        {
            ListeAuteurs listeAuteurs = new ListeAuteurs();
            ViewData["ListeAuteurs"] = listeAuteurs.ObtenirListeAuteur();
            return View("Auteurs");
        }

        public ActionResult Auteur(int id)
        {
            ListeAuteurs listeAuteurs = new ListeAuteurs();
            List<Auteur> auteurs = listeAuteurs.ObtenirListeAuteur();
            ListeLivres listeLivres = new ListeLivres();
            List<Livre> livres = new ListeLivres().ObtenirListeLivre(auteurs[0], auteurs[1], auteurs[2]);

            List<Livre> livresAuterId = new List<Livre> { };

            foreach (Livre livre in livres)
            {
                if (livre.Auteur.id == id)
                {
                    livresAuterId.Add(livre);
                }
            }

            ViewData["ListeLivreAuterId"] = livresAuterId;

            return View("Auteur");
        }

        public ActionResult Livre(int id)
        {
            ListeAuteurs listeAuteurs = new ListeAuteurs();
            List<Auteur> auteurs = listeAuteurs.ObtenirListeAuteur();
            ListeLivres listeLivres = new ListeLivres();
            List<Livre> livres = new ListeLivres().ObtenirListeLivre(auteurs[0], auteurs[1], auteurs[2]);
            List<Client> Clients = new Clients().ObtenirListeClients();
            List<Emprunt> Emprunts = new ListeEmprunts().ObtenirListeEmprunts(Clients[0], Clients[1], livres[0], livres[1], livres[2]);

            foreach(Livre livre in livres)
            {
                if (livre.Id == id)
                {
                    ViewData["LivreTitre"] = livre.Titre;
                    ViewData["LivreDate"] = livre.Parution;


                    foreach(Emprunt emprunt in Emprunts)
                    {
                        Livre livretrouve = emprunt.ListeLivres.FirstOrDefault(u => u.Id == id);
                        if(livretrouve != null)
                            ViewData["LivreEmpruntePar"] = emprunt.Client.Nom;
                    }

                    return View("Livre");
                }
            }

            return View("Error");




        }



    }
}