using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_prog3_bim1
{
    class ProdutoOrcamentoComparer: IEqualityComparer<ProdutoOrcamento>
    {
        public bool Equals(ProdutoOrcamento x, ProdutoOrcamento y)
        {
            return x.getProduto().Equals(y.getProduto());
        }

        public int GetHashCode(ProdutoOrcamento obj)
        {
            if (obj is PecaOrcamento)
            {
                PecaOrcamento po = (PecaOrcamento)obj;
                return ((Peca)po.getPeca()).getModelo().GetHashCode();
            }
            return obj.getProduto().getNome().GetHashCode();
        }
    }
}
