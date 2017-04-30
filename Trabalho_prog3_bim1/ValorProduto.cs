using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_prog3_bim1
{
    class ValorProduto
    {
        public static Double getValor(ProdutoOrcamento orcamentoProduto)
        {
            return orcamentoProduto.getQuantidade() * orcamentoProduto.getProduto().getValor();
        }
    }
}
