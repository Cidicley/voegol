﻿using System.Collections.Generic;

namespace TestePratico.API.domain.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public IList<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
