﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DOMAIN.Models
{
    public class ItemEstoque
    {
        public int IdItemEstoque { get; set; }
        public int IdLote { get; set; }
        public int IdCompra { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
    }
}