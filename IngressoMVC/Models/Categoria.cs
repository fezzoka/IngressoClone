using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Categoria:IEntidade
    {
        public int MyProperty { get; set; }
        public int id { get ; set; }
        public DateTime DataCadastro { get ; set; }
        public DateTime DataAlteracao { get ; set ; }
        public List<FilmeCategoria> FilmesCategorias { get; set; }
    }
}
