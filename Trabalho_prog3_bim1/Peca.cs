using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_prog3_bim1
{
    public class Peca : Trabalho_prog3_bim1.IProduto
    {
        private String modelo;
        private Int16 anoInicial;
        private Int16 anoFinal;

        public Peca(String nome, String modelo, Int16 anoInicial, Int16 anoFinal, Double valor)
        {
            this.nome = nome;
            this.modelo = modelo;
            this.anoInicial = anoInicial;
            this.anoFinal = anoFinal;
            this.valor = valor;
        }

        public Int16 getAnoInicial()
        {
            return anoInicial;
        }
        public void setAnoInicial(Int16 anoInicial)
        {
            this.anoInicial = anoInicial;
        }

        public Int16 getAnoFinal()
        {
            return anoFinal;
        }
        public void setAnoFinal(Int16 anoFinal)
        {
            this.anoFinal = anoFinal;
        }
        override public String ToString()
        {
            return nome;
        }

        public String getModelo()
        {
            return modelo;
        }

        public void setModelo(String modelo)
        {
            this.modelo = modelo;
        }

        internal object getIntervaloAnos()
        {
            return String.Format("{0} - {1}", anoInicial, anoFinal);
        }

        public Boolean pertence(Carro carro)
        {
            return this.getModelo() == carro.getModelo() && validaAno(carro);
        }

        public Boolean validaAno(Carro carro)
        {
            return carro.getAno() >= this.anoInicial && carro.getAno() <= this.anoFinal;
        }

        public bool Equals(Peca x, Peca y)
        {
            return x.getModelo().Equals(y.getModelo());
        }
    }
}
