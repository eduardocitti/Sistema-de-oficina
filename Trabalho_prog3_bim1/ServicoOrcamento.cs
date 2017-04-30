using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_prog3_bim1
{
    public class ServicoOrcamento : Trabalho_prog3_bim1.ProdutoOrcamento
    {
        public ServicoOrcamento(Servico servico, Int16 quantidade)
        {
            this.produto = servico;
            this.quantidade = quantidade;
        }

        public IProduto getServico()
        {
            return produto;
        }
    }
}
