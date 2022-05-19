﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Artista : IEntidade
    {
        public int id { get ; set; }
        public DateTime DataCadastro { get ; set ; }
        public DateTime DataAlteracao { get; set; }
}
