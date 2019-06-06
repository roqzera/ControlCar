namespace PimForms.Formulários
{
    partial class CadastrarSeguro
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
            this.tbxPlaca = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.tbxNomeSeguradora = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.maskDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.maskDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.lblMesagemObrigatoriedade = new System.Windows.Forms.Label();
            this.labeltesteErro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.BackColor = System.Drawing.Color.Gray;
            this.lblTituloForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(0, 0);
            this.lblTituloForm.Margin = new System.Windows.Forms.Padding(0);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(640, 32);
            this.lblTituloForm.TabIndex = 3;
            this.lblTituloForm.Text = "Cadastrar Seguro";
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPlaca
            // 
            this.tbxPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlaca.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPlaca.Location = new System.Drawing.Point(343, 89);
            this.tbxPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPlaca.Name = "tbxPlaca";
            this.tbxPlaca.Size = new System.Drawing.Size(249, 24);
            this.tbxPlaca.TabIndex = 5;
            this.tbxPlaca.TextChanged += new System.EventHandler(this.TbxPlaca_TextChanged);
            // 
            // txtValor
            // 
            this.txtValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.DimGray;
            this.txtValor.Location = new System.Drawing.Point(343, 47);
            this.txtValor.Margin = new System.Windows.Forms.Padding(2);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(249, 24);
            this.txtValor.TabIndex = 4;
            this.txtValor.Enter += new System.EventHandler(this.TxtValor_Enter);
            // 
            // tbxNomeSeguradora
            // 
            this.tbxNomeSeguradora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNomeSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNomeSeguradora.ForeColor = System.Drawing.Color.DimGray;
            this.tbxNomeSeguradora.Location = new System.Drawing.Point(46, 47);
            this.tbxNomeSeguradora.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNomeSeguradora.Name = "tbxNomeSeguradora";
            this.tbxNomeSeguradora.Size = new System.Drawing.Size(249, 24);
            this.tbxNomeSeguradora.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.DimGray;
            this.lblNome.Location = new System.Drawing.Point(44, 24);
            this.lblNome.Margin = new System.Windows.Forms.Padding(0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(253, 21);
            this.lblNome.TabIndex = 34;
            this.lblNome.Text = "Nome da Seguradora *";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.ForeColor = System.Drawing.Color.DimGray;
            this.lblDataInicio.Location = new System.Drawing.Point(44, 66);
            this.lblDataInicio.Margin = new System.Windows.Forms.Padding(0);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(253, 21);
            this.lblDataInicio.TabIndex = 36;
            this.lblDataInicio.Text = "Data de Início *";
            this.lblDataInicio.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // maskDataInicio
            // 
            this.maskDataInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskDataInicio.ForeColor = System.Drawing.Color.DimGray;
            this.maskDataInicio.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.maskDataInicio.Location = new System.Drawing.Point(47, 90);
            this.maskDataInicio.Mask = "00 / 00 / 0000";
            this.maskDataInicio.Name = "maskDataInicio";
            this.maskDataInicio.Size = new System.Drawing.Size(247, 24);
            this.maskDataInicio.TabIndex = 2;
            this.maskDataInicio.ValidatingType = typeof(System.DateTime);
            this.maskDataInicio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskDataInicio_MaskInputRejected);
            this.maskDataInicio.Click += new System.EventHandler(this.MaskDataInicio_Click);
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataVencimento.ForeColor = System.Drawing.Color.DimGray;
            this.lblDataVencimento.Location = new System.Drawing.Point(44, 108);
            this.lblDataVencimento.Margin = new System.Windows.Forms.Padding(0);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(253, 21);
            this.lblDataVencimento.TabIndex = 47;
            this.lblDataVencimento.Text = "Data de Vencimento *";
            this.lblDataVencimento.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // maskDataVencimento
            // 
            this.maskDataVencimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskDataVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskDataVencimento.ForeColor = System.Drawing.Color.DimGray;
            this.maskDataVencimento.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.maskDataVencimento.Location = new System.Drawing.Point(47, 132);
            this.maskDataVencimento.Mask = "00 / 00 / 0000";
            this.maskDataVencimento.Name = "maskDataVencimento";
            this.maskDataVencimento.Size = new System.Drawing.Size(247, 24);
            this.maskDataVencimento.TabIndex = 3;
            this.maskDataVencimento.ValidatingType = typeof(System.DateTime);
            this.maskDataVencimento.Click += new System.EventHandler(this.MaskDataVencimento_Click);
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::PimForms.Properties.Resources.icone_cancelar_20x20;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(187, 259);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "       Cancelar";
            this.button1.UseVisualStyleBackColor = false;
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
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "       Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.Color.DimGray;
            this.lblPlaca.Location = new System.Drawing.Point(341, 66);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(253, 21);
            this.lblPlaca.TabIndex = 39;
            this.lblPlaca.Text = "Placa do Veículo *";
            this.lblPlaca.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.DimGray;
            this.lblValor.Location = new System.Drawing.Point(341, 24);
            this.lblValor.Margin = new System.Windows.Forms.Padding(0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(253, 21);
            this.lblValor.TabIndex = 38;
            this.lblValor.Text = "Valor *";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.931329F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.55844F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.941231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.63768F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.931329F));
            this.tableLayoutPanel1.Controls.Add(this.lblValor, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPlaca, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAdicionar, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.labeltesteErro, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblMesagemObrigatoriedade, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.maskDataVencimento, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblDataVencimento, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.maskDataInicio, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDataInicio, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblNome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxNomeSeguradora, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtValor, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbxPlaca, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // CadastrarSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 340);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblTituloForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarSeguro";
            this.Text = "CadastrarSeguro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarSeguro_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.TextBox tbxPlaca;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox tbxNomeSeguradora;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.MaskedTextBox maskDataInicio;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.MaskedTextBox maskDataVencimento;
        private System.Windows.Forms.Label lblMesagemObrigatoriedade;
        private System.Windows.Forms.Label labeltesteErro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}