using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_prog3_bim1
{
    class Orcamento
    {
        private Double valor = 0;
        private List<PecaOrcamento> listaPecasOrcamento = new List<PecaOrcamento>();
        private List<ServicoOrcamento> listaServicosOrcamento = new List<ServicoOrcamento>();
        private List<Carro> listaCarros = new List<Carro>();

        public Double Valor
        {
            get 
            {
                foreach (ServicoOrcamento servicoOrcamento in listaServicosOrcamento)
                {
                    valor += ValorProduto.getValor(servicoOrcamento);
                }

                foreach (PecaOrcamento pecaOrcamento in listaPecasOrcamento)
                {
                    valor += ValorProduto.getValor(pecaOrcamento);
                }
                return valor; 
            }
        }
    }
}
