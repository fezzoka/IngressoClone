using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Cinema
    {
        public Cinema(string descricao, string logo, string nome)
        {
            Descricao = descricao;
            Logo = logo;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Logo { get; set; }
        public string Nome { get; set; }
        #region relacionamentos 
        public List<Filme> Filmes { get; set; }
        #endregion
    }
}
