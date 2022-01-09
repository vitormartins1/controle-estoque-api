﻿using System.ComponentModel.DataAnnotations;

namespace Estoque.DOMAIN.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
