using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Ator : Artista
    {
        protected Ator(string nome, string bio, string fotoPerfilURL) : base(nome, bio, fotoPerfilURL)
        {
        }
        #region relacionamento
        public List<Filme> AtoresFilmes { get; set; }
        #endregion
    }
}
