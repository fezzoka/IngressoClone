using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class AtorFilme
    {
        public int AtorID { get; private set; }
        public Ator  Ator { get; set; }
        public int FilmeID { get; private set; }
        public Filme Filme { get; set; }
    }
}
