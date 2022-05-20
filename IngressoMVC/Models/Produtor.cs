using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models.Interfaces
{
    public class Produtor: Artista
    {
        protected Produtor(string nome, string bio, string fotoPerfilURL) : base(nome, bio, fotoPerfilURL)
        {
        }

        #region relacionamentos
        public List<Filme> Filmes { get; set; }
        #endregion
    }
}
