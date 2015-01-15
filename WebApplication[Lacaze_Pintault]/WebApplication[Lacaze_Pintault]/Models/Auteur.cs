using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_Lacaze_Pintault_.Models
{
    public class Auteur : PersonneBase
    {
        public PersonneBase Personne { get; set; }

    }
}