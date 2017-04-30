namespace Trabalho_prog3_bim1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cbCarro = new System.Windows.Forms.ComboBox();
            this.btnCadastrarCarro = new System.Windows.Forms.Button();
            this.btnCadastrarPeca = new System.Windows.Forms.Button();
            this.btnCadastrarServico = new System.Windows.Forms.Button();
            this.dgServicos = new System.Windows.Forms.DataGridView();
            this.servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPecas = new System.Windows.Forms.DataGridView();
            this.peca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorpeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPecaOrcamento = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgServicoOrcamento = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveServico = new System.Windows.Forms.Button();
            this.btnAdicionaServico = new System.Windows.Forms.Button();
            this.btnAdicionaPeca = new System.Windows.Forms.Button();
            this.btnRemovePeca = new System.Windows.Forms.Button();
            this.lblSelCarroTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peçaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.Button();
            this.valorTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.carroSelecionado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.anoCarroSelecionado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btLimparOrcamento = new System.Windows.Forms.Button();
            this.limparOrçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPecaOrcamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicoOrcamento)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCarro
            // 
            this.cbCarro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarro.FormattingEnabled = true;
            this.cbCarro.Location = new System.Drawing.Point(12, 66);
            this.cbCarro.Name = "cbCarro";
            this.cbCarro.Size = new System.Drawing.Size(121, 21);
            this.cbCarro.TabIndex = 0;
            this.cbCarro.SelectedIndexChanged += new System.EventHandler(this.cbCarro_SelectedIndexChanged);
            // 
            // btnCadastrarCarro
            // 
            this.btnCadastrarCarro.Location = new System.Drawing.Point(12, 109);
            this.btnCadastrarCarro.Name = "btnCadastrarCarro";
            this.btnCadastrarCarro.Size = new System.Drawing.Size(121, 23);
            this.btnCadastrarCarro.TabIndex = 1;
            this.btnCadastrarCarro.Text = "Cadastrar Carro";
            this.btnCadastrarCarro.UseVisualStyleBackColor = true;
            this.btnCadastrarCarro.Click += new System.EventHandler(this.btnCadastrarCarro_Click);
            // 
            // btnCadastrarPeca
            // 
            this.btnCadastrarPeca.Location = new System.Drawing.Point(12, 155);
            this.btnCadastrarPeca.Name = "btnCadastrarPeca";
            this.btnCadastrarPeca.Size = new System.Drawing.Size(121, 23);
            this.btnCadastrarPeca.TabIndex = 2;
            this.btnCadastrarPeca.Text = "Cadastrar Peça";
            this.btnCadastrarPeca.UseVisualStyleBackColor = true;
            this.btnCadastrarPeca.Click += new System.EventHandler(this.btnCadastrarPeca_Click);
            // 
            // btnCadastrarServico
            // 
            this.btnCadastrarServico.Location = new System.Drawing.Point(12, 196);
            this.btnCadastrarServico.Name = "btnCadastrarServico";
            this.btnCadastrarServico.Size = new System.Drawing.Size(121, 23);
            this.btnCadastrarServico.TabIndex = 3;
            this.btnCadastrarServico.Text = "Cadastrar Serviço";
            this.btnCadastrarServico.UseVisualStyleBackColor = true;
            this.btnCadastrarServico.Click += new System.EventHandler(this.btnCadastrarServico_Click);
            // 
            // dgServicos
            // 
            this.dgServicos.AllowUserToResizeRows = false;
            this.dgServicos.BackgroundColor = System.Drawing.Color.Silver;
            this.dgServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servico,
            this.valor});
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgServicos.DefaultCellStyle = dataGridViewCellStyle25;
            this.dgServicos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgServicos.Location = new System.Drawing.Point(149, 42);
            this.dgServicos.Name = "dgServicos";
            this.dgServicos.ReadOnly = true;
            this.dgServicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgServicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgServicos.RowHeadersVisible = false;
            this.dgServicos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgServicos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgServicos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgServicos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgServicos.Size = new System.Drawing.Size(248, 150);
            this.dgServicos.TabIndex = 4;
            // 
            // servico
            // 
            this.servico.Frozen = true;
            this.servico.HeaderText = "Serviço";
            this.servico.Name = "servico";
            this.servico.ReadOnly = true;
            this.servico.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.servico.Width = 150;
            // 
            // valor
            // 
            this.valor.Frozen = true;
            this.valor.HeaderText = "Valor p/ Hora";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgPecas
            // 
            this.dgPecas.AllowUserToResizeRows = false;
            this.dgPecas.BackgroundColor = System.Drawing.Color.Silver;
            this.dgPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peca,
            this.modelo,
            this.ano,
            this.valorpeca});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPecas.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgPecas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgPecas.Location = new System.Drawing.Point(422, 42);
            this.dgPecas.Name = "dgPecas";
            this.dgPecas.ReadOnly = true;
            this.dgPecas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPecas.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgPecas.RowHeadersVisible = false;
            this.dgPecas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPecas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgPecas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgPecas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgPecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPecas.Size = new System.Drawing.Size(431, 150);
            this.dgPecas.TabIndex = 5;
            // 
            // peca
            // 
            this.peca.Frozen = true;
            this.peca.HeaderText = "Peça";
            this.peca.Name = "peca";
            this.peca.ReadOnly = true;
            this.peca.Width = 150;
            // 
            // modelo
            // 
            this.modelo.Frozen = true;
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // ano
            // 
            this.ano.Frozen = true;
            this.ano.HeaderText = "Ano";
            this.ano.Name = "ano";
            this.ano.ReadOnly = true;
            // 
            // valorpeca
            // 
            this.valorpeca.Frozen = true;
            this.valorpeca.HeaderText = "Valor";
            this.valorpeca.Name = "valorpeca";
            this.valorpeca.ReadOnly = true;
            this.valorpeca.Width = 80;
            // 
            // dgPecaOrcamento
            // 
            this.dgPecaOrcamento.AllowUserToResizeRows = false;
            this.dgPecaOrcamento.BackgroundColor = System.Drawing.Color.Silver;
            this.dgPecaOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPecaOrcamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.quantidade,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPecaOrcamento.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgPecaOrcamento.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgPecaOrcamento.Location = new System.Drawing.Point(422, 241);
            this.dgPecaOrcamento.Name = "dgPecaOrcamento";
            this.dgPecaOrcamento.ReadOnly = true;
            this.dgPecaOrcamento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPecaOrcamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgPecaOrcamento.RowHeadersVisible = false;
            this.dgPecaOrcamento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPecaOrcamento.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgPecaOrcamento.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgPecaOrcamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgPecaOrcamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPecaOrcamento.Size = new System.Drawing.Size(431, 150);
            this.dgPecaOrcamento.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Peça";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Ano";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Qtd";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 30;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dgServicoOrcamento
            // 
            this.dgServicoOrcamento.AllowUserToResizeRows = false;
            this.dgServicoOrcamento.BackgroundColor = System.Drawing.Color.Silver;
            this.dgServicoOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServicoOrcamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.quantidadeServico,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgServicoOrcamento.DefaultCellStyle = dataGridViewCellStyle31;
            this.dgServicoOrcamento.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgServicoOrcamento.Location = new System.Drawing.Point(149, 241);
            this.dgServicoOrcamento.Name = "dgServicoOrcamento";
            this.dgServicoOrcamento.ReadOnly = true;
            this.dgServicoOrcamento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgServicoOrcamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgServicoOrcamento.RowHeadersVisible = false;
            this.dgServicoOrcamento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgServicoOrcamento.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgServicoOrcamento.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgServicoOrcamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgServicoOrcamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgServicoOrcamento.Size = new System.Drawing.Size(248, 150);
            this.dgServicoOrcamento.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Serviço";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // quantidadeServico
            // 
            this.quantidadeServico.HeaderText = "Qtd";
            this.quantidadeServico.Name = "quantidadeServico";
            this.quantidadeServico.ReadOnly = true;
            this.quantidadeServico.Width = 30;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Valor p/ Hora";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnRemoveServico
            // 
            this.btnRemoveServico.Location = new System.Drawing.Point(198, 204);
            this.btnRemoveServico.Name = "btnRemoveServico";
            this.btnRemoveServico.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveServico.TabIndex = 8;
            this.btnRemoveServico.Text = "-";
            this.btnRemoveServico.UseVisualStyleBackColor = true;
            this.btnRemoveServico.Click += new System.EventHandler(this.btnRemoveServico_Click);
            // 
            // btnAdicionaServico
            // 
            this.btnAdicionaServico.Location = new System.Drawing.Point(277, 204);
            this.btnAdicionaServico.Name = "btnAdicionaServico";
            this.btnAdicionaServico.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionaServico.TabIndex = 9;
            this.btnAdicionaServico.Text = "+";
            this.btnAdicionaServico.UseVisualStyleBackColor = true;
            this.btnAdicionaServico.Click += new System.EventHandler(this.btnAdicionaServico_Click);
            // 
            // btnAdicionaPeca
            // 
            this.btnAdicionaPeca.Location = new System.Drawing.Point(639, 204);
            this.btnAdicionaPeca.Name = "btnAdicionaPeca";
            this.btnAdicionaPeca.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionaPeca.TabIndex = 11;
            this.btnAdicionaPeca.Text = "+";
            this.btnAdicionaPeca.UseVisualStyleBackColor = true;
            this.btnAdicionaPeca.Click += new System.EventHandler(this.btnAdicionaPeca_Click);
            // 
            // btnRemovePeca
            // 
            this.btnRemovePeca.Location = new System.Drawing.Point(560, 204);
            this.btnRemovePeca.Name = "btnRemovePeca";
            this.btnRemovePeca.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePeca.TabIndex = 10;
            this.btnRemovePeca.Text = "-";
            this.btnRemovePeca.UseVisualStyleBackColor = true;
            this.btnRemovePeca.Click += new System.EventHandler(this.btnRemovePeca_Click);
            // 
            // lblSelCarroTitle
            // 
            this.lblSelCarroTitle.AutoSize = true;
            this.lblSelCarroTitle.Location = new System.Drawing.Point(12, 42);
            this.lblSelCarroTitle.Name = "lblSelCarroTitle";
            this.lblSelCarroTitle.Size = new System.Drawing.Size(98, 13);
            this.lblSelCarroTitle.TabIndex = 14;
            this.lblSelCarroTitle.Text = "Selecione um carro";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparOrçamentoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carroToolStripMenuItem,
            this.peçaToolStripMenuItem,
            this.serviçoToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "&Cadastrar";
            // 
            // carroToolStripMenuItem
            // 
            this.carroToolStripMenuItem.Name = "carroToolStripMenuItem";
            this.carroToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.carroToolStripMenuItem.Text = "&Carro";
            this.carroToolStripMenuItem.Click += new System.EventHandler(this.carroToolStripMenuItem_Click);
            // 
            // peçaToolStripMenuItem
            // 
            this.peçaToolStripMenuItem.Name = "peçaToolStripMenuItem";
            this.peçaToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.peçaToolStripMenuItem.Text = "&Peça";
            this.peçaToolStripMenuItem.Click += new System.EventHandler(this.peçaToolStripMenuItem_Click);
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.serviçoToolStripMenuItem.Text = "&Serviço";
            this.serviçoToolStripMenuItem.Click += new System.EventHandler(this.serviçoToolStripMenuItem_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 414);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 23);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Encerrar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // valorTotal
            // 
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.Size = new System.Drawing.Size(32, 20);
            this.valorTotal.Text = "-----";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(200, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(148, 20);
            this.toolStripStatusLabel1.Text = "Valor total do orçamento:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(101, 20);
            this.toolStripStatusLabel2.Text = "Modelo do carro:";
            // 
            // carroSelecionado
            // 
            this.carroSelecionado.AutoSize = false;
            this.carroSelecionado.Name = "carroSelecionado";
            this.carroSelecionado.Size = new System.Drawing.Size(125, 20);
            this.carroSelecionado.Text = "-----";
            this.carroSelecionado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(32, 20);
            this.toolStripStatusLabel3.Text = "Ano:";
            // 
            // anoCarroSelecionado
            // 
            this.anoCarroSelecionado.Name = "anoCarroSelecionado";
            this.anoCarroSelecionado.Size = new System.Drawing.Size(32, 20);
            this.anoCarroSelecionado.Text = "-----";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.carroSelecionado,
            this.toolStripSeparator2,
            this.toolStripStatusLabel3,
            this.anoCarroSelecionado,
            this.toolStripStatusLabel1,
            this.valorTotal});
            this.toolStrip1.Location = new System.Drawing.Point(0, 443);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.toolStrip1.Size = new System.Drawing.Size(867, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btLimparOrcamento
            // 
            this.btLimparOrcamento.Location = new System.Drawing.Point(514, 414);
            this.btLimparOrcamento.Name = "btLimparOrcamento";
            this.btLimparOrcamento.Size = new System.Drawing.Size(121, 23);
            this.btLimparOrcamento.TabIndex = 19;
            this.btLimparOrcamento.Text = "Limpar Orçamento";
            this.btLimparOrcamento.UseVisualStyleBackColor = true;
            this.btLimparOrcamento.Click += new System.EventHandler(this.btLimparOrcamento_Click);
            // 
            // limparOrçamentoToolStripMenuItem
            // 
            this.limparOrçamentoToolStripMenuItem.Name = "limparOrçamentoToolStripMenuItem";
            this.limparOrçamentoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.limparOrçamentoToolStripMenuItem.Text = "Limpar Orçamento";
            this.limparOrçamentoToolStripMenuItem.Click += new System.EventHandler(this.btLimparOrcamento_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 468);
            this.Controls.Add(this.btLimparOrcamento);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblSelCarroTitle);
            this.Controls.Add(this.btnAdicionaPeca);
            this.Controls.Add(this.btnRemovePeca);
            this.Controls.Add(this.btnAdicionaServico);
            this.Controls.Add(this.btnRemoveServico);
            this.Controls.Add(this.dgPecaOrcamento);
            this.Controls.Add(this.dgServicoOrcamento);
            this.Controls.Add(this.dgPecas);
            this.Controls.Add(this.dgServicos);
            this.Controls.Add(this.btnCadastrarServico);
            this.Controls.Add(this.btnCadastrarPeca);
            this.Controls.Add(this.btnCadastrarCarro);
            this.Controls.Add(this.cbCarro);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemas de Orçamentos Automotivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPecaOrcamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicoOrcamento)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCarro;
        private System.Windows.Forms.Button btnCadastrarCarro;
        private System.Windows.Forms.Button btnCadastrarPeca;
        private System.Windows.Forms.Button btnCadastrarServico;
        private System.Windows.Forms.DataGridView dgServicos;
        private System.Windows.Forms.DataGridView dgPecas;
        private System.Windows.Forms.DataGridView dgPecaOrcamento;
        private System.Windows.Forms.DataGridView dgServicoOrcamento;
        private System.Windows.Forms.Button btnRemoveServico;
        private System.Windows.Forms.Button btnAdicionaServico;
        private System.Windows.Forms.Button btnAdicionaPeca;
        private System.Windows.Forms.Button btnRemovePeca;
        private System.Windows.Forms.Label lblSelCarroTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn peca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorpeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peçaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel carroSelecionado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel valorTotal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel anoCarroSelecionado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btLimparOrcamento;
        private System.Windows.Forms.ToolStripMenuItem limparOrçamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

