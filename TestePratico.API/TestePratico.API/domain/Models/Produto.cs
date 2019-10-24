﻿namespace TestePratico.API.domain.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public short QuantidadePacote { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}