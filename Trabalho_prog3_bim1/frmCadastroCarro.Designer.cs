namespace Trabalho_prog3_bim1
{
    partial class frmCadastroCarro
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
            this.txtNomeCarro = new System.Windows.Forms.TextBox();
            this.lblNomeCarroTitle = new System.Windows.Forms.Label();
            this.lblModeloTitle = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblAnoTitle = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeCarro
            // 
            this.txtNomeCarro.Location = new System.Drawing.Point(104, 22);
            this.txtNomeCarro.Name = "txtNomeCarro";
            this.txtNomeCarro.Size = new System.Drawing.Size(191, 20);
            this.txtNomeCarro.TabIndex = 0;
            // 
            // lblNomeCarroTitle
            // 
            this.lblNomeCarroTitle.AutoSize = true;
            this.lblNomeCarroTitle.Location = new System.Drawing.Point(17, 22);
            this.lblNomeCarroTitle.Name = "lblNomeCarroTitle";
            this.lblNomeCarroTitle.Size = new System.Drawing.Size(81, 13);
            this.lblNomeCarroTitle.TabIndex = 1;
            this.lblNomeCarroTitle.Text = "Nome do Carro:";
            // 
            // lblModeloTitle
            // 
            this.lblModeloTitle.AutoSize = true;
            this.lblModeloTitle.Location = new System.Drawing.Point(17, 59);
            this.lblModeloTitle.Name = "lblModeloTitle";
            this.lblModeloTitle.Size = new System.Drawing.Size(45, 13);
            this.lblModeloTitle.TabIndex = 3;
            this.lblModeloTitle.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(104, 59);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(191, 20);
            this.txtModelo.TabIndex = 1;
            // 
            // lblAnoTitle
            // 
            this.lblAnoTitle.AutoSize = true;
            this.lblAnoTitle.Location = new System.Drawing.Point(17, 96);
            this.lblAnoTitle.Name = "lblAnoTitle";
            this.lblAnoTitle.Size = new System.Drawing.Size(29, 13);
            this.lblAnoTitle.TabIndex = 5;
            this.lblAnoTitle.Text = "Ano:";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(104, 96);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(191, 20);
            this.txtAno.TabIndex = 3;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(104, 137);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(220, 137);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCadastroCarro
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(319, 175);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblAnoTitle);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblModeloTitle);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblNomeCarroTitle);
            this.Controls.Add(this.txtNomeCarro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Carro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarroCadastrado);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCarro;
        private System.Windows.Forms.Label lblNomeCarroTitle;
        private System.Windows.Forms.Label lblModeloTitle;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblAnoTitle;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}