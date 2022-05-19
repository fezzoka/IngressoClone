using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Ator : Artista
    {
        
        public string nome { get; set; }
        public string Bio { get; set; }
        public string FotoPerfilURL { get; set; }
        public DateTime DataCadastro { get ; set ; }
        public DateTime DataAlteracao { get  ; set ; }
        public int id { get ; set ; }
        #region relacionamento
        public List<Filme> AtoresFilmes { get; set; }
        #endregion
    }
}
