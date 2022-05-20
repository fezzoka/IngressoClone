using IngressoMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Filme
    {
        public Filme(string imagemURL, string titulo, double preco)
        {
            ImagemURL = imagemURL;
            Titulo = titulo;
            Preco = preco;
        }

        public List<AtorFilme> Atores_Filmes { get; set; }
        public Categoria CategoriaFilme { get; set; }
        public int cinemaid { get; set; }
        public DateTime DataDeInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Descricao { get; set; }
        public int id { get; set; }
        public string ImagemURL { get;private set; }
        public string Titulo { get;private set; }
        public double Preco { get;private set; }
        #region relacionamentos
        public Cinema Cinema { get; set; }
        public int CinemaId { get; set; }

        public int ProdutorId { get; set; }
        public Produtor Produtor { get; set; }
        public List<Filme> AtoresFilmes { get; set; }
        #endregion
        public void AlteraPreco(double novoPreco)
        {
            if(novoPreco < 0)
            {
                return;
            }
            Preco = novoPreco;
        }
    }
}
