using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_prog3_bim1
{
    public class ValidacaoNumerica
    {
        public static void validaValor(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (e.KeyChar == ',' && tb.Text.IndexOf(',') > -1)
            {
                e.Handled = true;
                MessageBox.Show("Apenas um separador decimal é permitido!");
                return;
            }

            if (e.KeyChar == '.')
            {
                if (tb.Text.IndexOf(',') > -1)
                {
                    e.Handled = true;
                    MessageBox.Show("Apenas um separador decimal é permitido!");
                    return;
                }
                else
                {
                    tb.Text += ',';
                    e.Handled = true;
                    return;
                }
            }

            validaNumero(e);
        }

        public static void validaAno(object sender, KeyPressEventArgs e)
        {
            validaNumero(e);
        }

        private static void validaNumero(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Somente números são permitidos!");
            }
        }
    }
}
