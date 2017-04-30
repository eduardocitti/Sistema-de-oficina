using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho_prog3_bim1
{
    class Preco
    {
        private double valorOriginal;

        public Preco(double p)
        {
            this.valorOriginal = p;
        }

        public static Preco operator +(Preco um, Preco outro)
        {
            return new Preco(um.valorOriginal + outro.valorOriginal);
        }

        public override string ToString()
        {
            return valorOriginal.ToString("C");
        }
    }
}
