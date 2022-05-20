using IngressoMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Artista : IEntidade
    {
        protected Artista(string nome, string bio, string fotoPerfilURL)
        {
            DataCadastro = DateTime.Now;
            DataAlteracao = DataCadastro;
            Nome = nome;
            Bio = bio;
            FotoPerfilURL = fotoPerfilURL;
        }
        public int id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Bio { get; set; }
        public string FotoPerfilURL { get; set; }
        public string Nome { get; set; }
    
    }
}
