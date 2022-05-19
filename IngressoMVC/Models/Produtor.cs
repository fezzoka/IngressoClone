using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Produtor:IEntidade
    {
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int id { get; set; }
        public string nome { get; set; }
        public string FotoDePerfilURL { get; set; }
        public string Bio { get; set; }
        #region relacionamentos
        public List<Filme> Filmes { get; set; }
        #endregion
    }
}
