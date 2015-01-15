using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication_Lacaze_Pintault_.Models
{
    public interface IPersonnes
    {
        string Nom { get; set; }
        string Prenom { get; set; }

        string Affiche();
    }
}
