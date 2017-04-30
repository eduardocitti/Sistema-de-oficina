using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_prog3_bim1
{
    public partial class frmPrincipal : Form
    {
        public List<Carro> listaCarros = new List<Carro>();
        public List<Peca> listaPecas = new List<Peca>();
        public List<Servico> listaServicos = new List<Servico>();
        public HashSet<ServicoOrcamento> listaServicosOrcamento = new HashSet<ServicoOrcamento>(new ProdutoOrcamentoComparer());
        public HashSet<PecaOrcamento> listaPecasOrcamento = new HashSet<PecaOrcamento>(new ProdutoOrcamentoComparer());
        // public List<PecaOrcamento> listaPecasOrcamento = new List<PecaOrcamento>();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizaListaCarros();
            AtualizaListaPecas();
            AtualizaListaServicos();

            cbCarro_SelectedIndexChanged(cbCarro, EventArgs.Empty);
            valorTotal.Text = new Preco(0).ToString();
        }

        private void btnCadastrarCarro_Click(object sender, EventArgs e)
        {
            frmCadastroCarro cadastrocarro = new frmCadastroCarro(listaCarros, this);
            cadastrocarro.ShowDialog();
        }

        private void btnCadastrarPeca_Click(object sender, EventArgs e)
        {
            frmCadastroPeca cadastropeca = new frmCadastroPeca(listaPecas, this, listaCarros);
            cadastropeca.ShowDialog();
        }

        private void btnCadastrarServico_Click(object sender, EventArgs e)
        {
            frmCadastroServico cadastroservico = new frmCadastroServico(listaServicos, this);
            cadastroservico.ShowDialog();

        }

        public void AtualizaListaCarros()
        {
            StreamReader listaCarrosStream;
            try
            {
                listaCarrosStream = File.OpenText("lista_carros.csv");
            }
            catch (FileNotFoundException e)
            {
                StreamWriter criarStream = File.CreateText("lista_carros.csv");
                criarStream.Close();
                criarStream = null;
                listaCarrosStream = File.OpenText("lista_carros.csv");
            }
            cbCarro.Items.Clear();
            listaCarros.Clear();
            var csv = new CsvReader(listaCarrosStream);
            csv.Configuration.HasHeaderRecord = false;
            csv.Configuration.TrimFields = true;
            while (csv.Read())
            {
                Carro carro = new Carro(
                    csv.GetField<String>(0),
                    csv.GetField<String>(1),
                    csv.GetField<Int16>(2)
                );
                listaCarros.Add(carro);
            }
            listaCarrosStream.Close();
            foreach (Carro nomeCarro in listaCarros)
            {
                cbCarro.Items.Add(nomeCarro);
            }
        }

        public void AtualizaListaPecas()
        {
            StreamReader listaPecasStream;
            try
            {
                listaPecasStream = File.OpenText("lista_pecas.csv");
            }
            catch (FileNotFoundException e)
            {
                StreamWriter criarStream = File.CreateText("lista_pecas.csv");
                criarStream.Close();
                criarStream = null;
                listaPecasStream = File.OpenText("lista_pecas.csv");
            }
            dgPecas.Rows.Clear();
            listaPecas.Clear();
            var csv = new CsvReader(listaPecasStream);
            csv.Configuration.HasHeaderRecord = false;
            csv.Configuration.TrimFields = true;
            while (csv.Read())
            {
                Peca peca = new Peca(
                    csv.GetField<String>(0),
                    csv.GetField<String>(1),
                    csv.GetField<Int16>(2),
                    csv.GetField<Int16>(3),
                    csv.GetField<Double>(4)
                );
                listaPecas.Add(peca);
            }
            listaPecasStream.Close();
            foreach (Peca peca in listaPecas)
            {
                dgPecas.Rows.Add(peca, peca.getModelo(), peca.getIntervaloAnos(), new Preco(peca.getValor()));
            }
            cbCarro_SelectedIndexChanged(cbCarro, EventArgs.Empty);
        }

        public void AtualizaListaServicos()
        {
            StreamReader listaServicosStream;
            try
            {
                listaServicosStream = File.OpenText("lista_servicos.csv");
            }
            catch (FileNotFoundException e)
            {
                StreamWriter criarStream = File.CreateText("lista_servicos.csv");
                criarStream.Close();
                criarStream = null;
                listaServicosStream = File.OpenText("lista_servicos.csv");
            }
            dgServicos.Rows.Clear();
            listaServicos.Clear();
            var csv = new CsvReader(listaServicosStream);
            csv.Configuration.HasHeaderRecord = false;
            csv.Configuration.TrimFields = true;
            while (csv.Read())
            {
                Servico servico = new Servico(
                    csv.GetField<String>(0),
                    csv.GetField<Double>(1)
                );
                listaServicos.Add(servico);
            }
            listaServicosStream.Close();
            foreach (Servico servicos in listaServicos)
            {
                dgServicos.Rows.Add(servicos, new Preco(servicos.getValorHora()));
            }
        }

        public void AtualizaListaServicosOrcamento()
        {
            dgServicoOrcamento.Rows.Clear();
            // filtra e remove da lista os servicos com qtd = 0
            listaServicosOrcamento.RemoveWhere(servicoQtd => servicoQtd.getQuantidade() <= 0);
            foreach (ServicoOrcamento servicoOrcamento in listaServicosOrcamento)
            {
                Servico servico = (Servico)servicoOrcamento.getServico();
                dgServicoOrcamento.Rows.Add(servicoOrcamento, servicoOrcamento.getQuantidade(), new Preco(servicoOrcamento.getValor()));
            }
        }

        public void AtualizaListaPecasOrcamento()
        {
            dgPecaOrcamento.Rows.Clear();
            //filtramos a lista de Pecas Orcamento pela quantidade
            listaPecasOrcamento.RemoveWhere(pecaQtd => pecaQtd.getQuantidade() <= 0);
            foreach (PecaOrcamento pecaOrcamento in listaPecasOrcamento)
            {
                Peca peca = (Peca)pecaOrcamento.getPeca();
                dgPecaOrcamento.Rows.Add(pecaOrcamento, peca.getModelo(), peca.getIntervaloAnos(), pecaOrcamento.getQuantidade(), new Preco(pecaOrcamento.getValor()));
            }
        }

        private void btnAdicionaPeca_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgPecas.SelectedRows)
            {
                DataGridViewCellCollection data = row.Cells;
                Peca peca = (Peca)row.Cells[0].Value;

                if (peca != null)
                {
                    PecaOrcamento pecaOrcamento = new PecaOrcamento(peca, 1);

                    if (listaPecasOrcamento.Contains(pecaOrcamento))
                    {
                        PecaOrcamento listado = listaPecasOrcamento.First(po => po.Equals(pecaOrcamento));
                        listado.incrementaQuantidade();
                    }
                    else
                    {
                        listaPecasOrcamento.Add(pecaOrcamento);
                    }
                }
            }
            AtualizaListaPecasOrcamento();
            AtualizarTotal();
        }

        private void btnRemovePeca_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgPecaOrcamento.SelectedRows)
            {
                PecaOrcamento pecaOrcamento = (PecaOrcamento)row.Cells[0].Value;
                if (pecaOrcamento != null)
                {
                    pecaOrcamento.reduzQuantidade();
                }
            }
            AtualizaListaPecasOrcamento();
            AtualizarTotal();
        }

        private void btnAdicionaServico_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgServicos.SelectedRows)
            {
                DataGridViewCellCollection data = row.Cells;
                Servico servico = (Servico)row.Cells[0].Value;
                if (servico != null)
                {
                    ServicoOrcamento servicoOrcamento = new ServicoOrcamento(servico, 1);

                    if (listaServicosOrcamento.Contains(servicoOrcamento))
                    {
                        ServicoOrcamento listado = listaServicosOrcamento.First(po => po.getServico().getNome() == servicoOrcamento.getServico().getNome());
                        listado.incrementaQuantidade();
                    }
                    else
                    {
                        listaServicosOrcamento.Add(servicoOrcamento);
                    }
                }
            }
            AtualizaListaServicosOrcamento();
            AtualizarTotal();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCadastrarCarro_Click(sender, e);
        }

        private void peçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCadastrarServico_Click(sender, e);
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCadastrarCarro_Click(sender, e);
        }

        private void btnRemoveServico_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgServicoOrcamento.SelectedRows)
            {
                ServicoOrcamento servicoOrcamento = (ServicoOrcamento)row.Cells[0].Value;
                if (servicoOrcamento != null)
                {
                    servicoOrcamento.reduzQuantidade();
                }
            }
            AtualizaListaServicosOrcamento();
            AtualizarTotal();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AtualizarTotal()
        {
            /*Double totalServico = 0;
            foreach(ServicoOrcamento servicoOrcamento in listaServicosOrcamento)
            {
                totalServico += Convert.ToDouble(servicoOrcamento.getValor());
            }
            lblTotal.Text = totalServico.ToString();*/

            Preco servicos = new Preco(listaServicosOrcamento.Sum(so => so.getValor()));
            Preco pecas = new Preco(listaPecasOrcamento.Sum(so => so.getValor()));
            valorTotal.Text = (servicos + pecas).ToString();
        }

        private void cbCarro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaCarros.Count == 0)
            {
                return;
            }
            else
            {
                if ((sender as ComboBox).SelectedIndex != -1)
                {
                    cbCarro.SelectedIndex = (sender as ComboBox).SelectedIndex;
                }
                else
                {
                    cbCarro.SelectedIndex = 0;
                }

            }

            Carro carro = (Carro)cbCarro.SelectedItem;
            carroSelecionado.Text = carro.getModelo();
            anoCarroSelecionado.Text = carro.getAno().ToString();
            dgPecas.Rows.Clear();
            foreach (Peca peca in listaPecas.Where(peca => peca.pertence(carro)))
            {
                dgPecas.Rows.Add(peca, peca.getModelo(), peca.getIntervaloAnos(), new Preco(peca.getValor()));
            }
        }

        private void btLimparOrcamento_Click(object sender, EventArgs e)
        {
            listaPecasOrcamento.Clear();
            listaServicosOrcamento.Clear();
            AtualizaListaPecasOrcamento();
            AtualizaListaServicosOrcamento();
            AtualizarTotal();
        }
    }
}
