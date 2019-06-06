namespace PimForms.Formulários
{
    partial class CadastrarCustoViagem
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
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblMesagemObrigatoriedade = new System.Windows.Forms.Label();
            this.lblValorAbastecimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtIdViagem = new System.Windows.Forms.TextBox();
            this.txtCustoPedagio = new System.Windows.Forms.TextBox();
            this.txtCustoEstacionamento = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labeltesteErro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustoAbastecimento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustoAluguel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloForm.BackColor = System.Drawing.Color.Gray;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(0, 0);
            this.lblTituloForm.Margin = new System.Windows.Forms.Padding(0);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(640, 32);
            this.lblTituloForm.TabIndex = 5;
            this.lblTituloForm.Text = "Cadastrar Custo";
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.DimGray;
            this.lblValor.Location = new System.Drawing.Point(44, 66);
            this.lblValor.Margin = new System.Windows.Forms.Padding(0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(253, 21);
            this.lblValor.TabIndex = 38;
            this.lblValor.Text = "Custo de Pedágio";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblValor.Click += new System.EventHandler(this.LblValor_Click);
            // 
            // lblMesagemObrigatoriedade
            // 
            this.lblMesagemObrigatoriedade.AutoSize = true;
            this.lblMesagemObrigatoriedade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMesagemObrigatoriedade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesagemObrigatoriedade.ForeColor = System.Drawing.Color.DimGray;
            this.lblMesagemObrigatoriedade.Location = new System.Drawing.Point(47, 0);
            this.lblMesagemObrigatoriedade.Name = "lblMesagemObrigatoriedade";
            this.lblMesagemObrigatoriedade.Size = new System.Drawing.Size(247, 24);
            this.lblMesagemObrigatoriedade.TabIndex = 46;
            this.lblMesagemObrigatoriedade.Text = "(*)  Campos de preenchimento Obrigatório";
            this.lblMesagemObrigatoriedade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValorAbastecimento
            // 
            this.lblValorAbastecimento.AutoSize = true;
            this.lblValorAbastecimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorAbastecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAbastecimento.ForeColor = System.Drawing.Color.DimGray;
            this.lblValorAbastecimento.Location = new System.Drawing.Point(341, 66);
            this.lblValorAbastecimento.Margin = new System.Windows.Forms.Padding(0);
            this.lblValorAbastecimento.Name = "lblValorAbastecimento";
            this.lblValorAbastecimento.Size = new System.Drawing.Size(253, 21);
            this.lblValorAbastecimento.TabIndex = 36;
            this.lblValorAbastecimento.Text = "Custo de Estacionamento";
            this.lblValorAbastecimento.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.DimGray;
            this.lblNome.Location = new System.Drawing.Point(341, 24);
            this.lblNome.Margin = new System.Windows.Forms.Padding(0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(253, 21);
            this.lblNome.TabIndex = 34;
            this.lblNome.Text = "Custo de Abastecimento";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtIdViagem
            // 
            this.txtIdViagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdViagem.ForeColor = System.Drawing.Color.DimGray;
            this.txtIdViagem.Location = new System.Drawing.Point(46, 47);
            this.txtIdViagem.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdViagem.Name = "txtIdViagem";
            this.txtIdViagem.Size = new System.Drawing.Size(249, 24);
            this.txtIdViagem.TabIndex = 1;
            // 
            // txtCustoPedagio
            // 
            this.txtCustoPedagio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustoPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoPedagio.ForeColor = System.Drawing.Color.DimGray;
            this.txtCustoPedagio.Location = new System.Drawing.Point(46, 89);
            this.txtCustoPedagio.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustoPedagio.Name = "txtCustoPedagio";
            this.txtCustoPedagio.Size = new System.Drawing.Size(249, 24);
            this.txtCustoPedagio.TabIndex = 2;
            // 
            // txtCustoEstacionamento
            // 
            this.txtCustoEstacionamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustoEstacionamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoEstacionamento.ForeColor = System.Drawing.Color.DimGray;
            this.txtCustoEstacionamento.Location = new System.Drawing.Point(343, 89);
            this.txtCustoEstacionamento.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustoEstacionamento.Name = "txtCustoEstacionamento";
            this.txtCustoEstacionamento.Size = new System.Drawing.Size(249, 24);
            this.txtCustoEstacionamento.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.931329F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.55844F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.941231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.63768F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.931329F));
            this.tableLayoutPanel1.Controls.Add(this.btnAdicionar, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.labeltesteErro, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblMesagemObrigatoriedade, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIdViagem, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblValorAbastecimento, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblValor, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblNome, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCustoPedagio, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCustoAbastecimento, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCustoEstacionamento, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtCustoAluguel, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.083411F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.00546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.00546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.00546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.00546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.00546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.00546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.00546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.00546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.00546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.005459F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.360761F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.50123F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 308);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Gray;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Image = global::PimForms.Properties.Resources.icone_confirmar_20x20;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(341, 259);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(110, 30);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "       Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::PimForms.Properties.Resources.icone_cancelar_20x20;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(187, 259);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 30);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "       Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // labeltesteErro
            // 
            this.labeltesteErro.AutoSize = true;
            this.labeltesteErro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeltesteErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltesteErro.ForeColor = System.Drawing.Color.Red;
            this.labeltesteErro.Location = new System.Drawing.Point(47, 234);
            this.labeltesteErro.Name = "labeltesteErro";
            this.labeltesteErro.Size = new System.Drawing.Size(247, 25);
            this.labeltesteErro.TabIndex = 44;
            this.labeltesteErro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Id Viagem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCustoAbastecimento
            // 
            this.txtCustoAbastecimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustoAbastecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoAbastecimento.ForeColor = System.Drawing.Color.DimGray;
            this.txtCustoAbastecimento.Location = new System.Drawing.Point(343, 47);
            this.txtCustoAbastecimento.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustoAbastecimento.Name = "txtCustoAbastecimento";
            this.txtCustoAbastecimento.Size = new System.Drawing.Size(249, 24);
            this.txtCustoAbastecimento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(44, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Custo de Aluguel";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCustoAluguel
            // 
            this.txtCustoAluguel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustoAluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoAluguel.ForeColor = System.Drawing.Color.DimGray;
            this.txtCustoAluguel.Location = new System.Drawing.Point(46, 131);
            this.txtCustoAluguel.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustoAluguel.Name = "txtCustoAluguel";
            this.txtCustoAluguel.ReadOnly = true;
            this.txtCustoAluguel.Size = new System.Drawing.Size(249, 24);
            this.txtCustoAluguel.TabIndex = 50;
            this.txtCustoAluguel.Click += new System.EventHandler(this.TxtCustoAluguel_Click);
            // 
            // CadastrarCustoViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 340);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarCustoViagem";
            this.Text = "CadastrarCustoViagem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblMesagemObrigatoriedade;
        private System.Windows.Forms.Label lblValorAbastecimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtIdViagem;
        private System.Windows.Forms.TextBox txtCustoPedagio;
        private System.Windows.Forms.TextBox txtCustoEstacionamento;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labeltesteErro;
        private System.Windows.Forms.TextBox txtCustoAbastecimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustoAluguel;
    }
}