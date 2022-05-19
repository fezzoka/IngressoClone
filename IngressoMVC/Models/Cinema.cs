using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Cinema
    {
        public string Descricao { get; set; }
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Nome { get; set; }
        #region relacionamentos 
        public List<Filme> Filmes { get; set; }
        #endregion
    }
}
