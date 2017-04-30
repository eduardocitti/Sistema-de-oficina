using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_prog3_bim1
{
    public class PecaOrcamento : Trabalho_prog3_bim1.ProdutoOrcamento
    {
        public PecaOrcamento(Peca peca, Int16 quantidade)
        {
            this.produto = peca;
            this.quantidade = quantidade;
        }

        public Peca getPeca()
        {
            return (Peca)produto;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj is System.DBNull)
            {
                return false;
            }

            PecaOrcamento po = (PecaOrcamento)obj;
            return po.getPeca().getModelo().Equals(this.getPeca().getModelo())
                && po.getPeca().getNome().Equals(this.getPeca().getNome())
                && po.getPeca().getIntervaloAnos().Equals(this.getPeca().getIntervaloAnos());
        }
    }
}
