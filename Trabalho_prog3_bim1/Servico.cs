using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_prog3_bim1
{
    public class Servico : Trabalho_prog3_bim1.IProduto
    {
        public Servico(String nome, Double valorHora)
        {
            this.nome = nome;
            this.valor = valorHora;
        }

        public Double getValorHora()
        {
            return valor;
        }

        public void setValorHora(Double valorHora)
        {
            this.valor = valorHora;
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
