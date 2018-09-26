using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eBiblio.Models
{
    public class Clients
    {
        public List<Client> ObtenirListeClients()
        {
            return new List<Client>
            {
                new Client { Nom = "Halleux" , Email = "jonathan.halleux@gmail.com" },
                new Client { Nom = "Isabelle" , Email = "toto123456@yopmail.com"}
            };

        }
    }
}