namespace PimForms.Formulários
{
    partial class CadastrarManutencao
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtQuilometragem = new System.Windows.Forms.TextBox();
            this.maskData = new System.Windows.Forms.MaskedTextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblQuilometragem = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMesagemObrigatoriedade = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.labeltesteErro = new System.Windows.Forms.Label();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.DimGray;
            this.txtValor.Location = new System.Drawing.Point(343, 131);
            this.txtValor.Margin = new System.Windows.Forms.Padding(2);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(249, 24);
            this.txtValor.TabIndex = 6;
            // 
            // txtLocal
            // 
            this.txtLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocal.ForeColor = System.Drawing.Color.DimGray;
            this.txtLocal.Location = new System.Drawing.Point(46, 131);
            this.txtLocal.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(249, 24);
            this.txtLocal.TabIndex = 3;
            // 
            // txtQuilometragem
            // 
            this.txtQuilometragem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuilometragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuilometragem.ForeColor = System.Drawing.Color.DimGray;
            this.txtQuilometragem.Location = new System.Drawing.Point(343, 89);
            this.txtQuilometragem.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuilometragem.Name = "txtQuilometragem";
            this.txtQuilometragem.Size = new System.Drawing.Size(249, 24);
            this.txtQuilometragem.TabIndex = 5;
            // 
            // maskData
            // 
            this.maskData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskData.ForeColor = System.Drawing.Color.DimGray;
            this.maskData.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.maskData.Location = new System.Drawing.Point(344, 48);
            this.maskData.Mask = "00/00/0000";
            this.maskData.Name = "maskData";
            this.maskData.Size = new System.Drawing.Size(247, 24);
            this.maskData.TabIndex = 4;
            this.maskData.ValidatingType = typeof(System.DateTime);
            this.maskData.Click += new System.EventHandler(this.MaskData_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.Color.DimGray;
            this.lblPlaca.Location = new System.Drawing.Point(44, 24);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(253, 21);
            this.lblPlaca.TabIndex = 33;
            this.lblPlaca.Text = "Placa do Veículo *";
            this.lblPlaca.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblPlaca.Click += new System.EventHandler(this.LblPlaca_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTipo.Location = new System.Drawing.Point(44, 66);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(253, 21);
            this.lblTipo.TabIndex = 34;
            this.lblTipo.Text = "Tipo *";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.DimGray;
            this.lblLocal.Location = new System.Drawing.Point(44, 108);
            this.lblLocal.Margin = new System.Windows.Forms.Padding(0);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(253, 21);
            this.lblLocal.TabIndex = 35;
            this.lblLocal.Text = "Local *";
            this.lblLocal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescricao.Location = new System.Drawing.Point(44, 171);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(253, 21);
            this.lblDescricao.TabIndex = 36;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.DimGray;
            this.lblData.Location = new System.Drawing.Point(341, 24);
            this.lblData.Margin = new System.Windows.Forms.Padding(0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(253, 21);
            this.lblData.TabIndex = 38;
            this.lblData.Text = "Data *";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblQuilometragem
            // 
            this.lblQuilometragem.AutoSize = true;
            this.lblQuilometragem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuilometragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuilometragem.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuilometragem.Location = new System.Drawing.Point(341, 66);
            this.lblQuilometragem.Margin = new System.Windows.Forms.Padding(0);
            this.lblQuilometragem.Name = "lblQuilometragem";
            this.lblQuilometragem.Size = new System.Drawing.Size(253, 21);
            this.lblQuilometragem.TabIndex = 39;
            this.lblQuilometragem.Text = "Quilometragem *";
            this.lblQuilometragem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.931328F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.55844F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.94123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.63768F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.931328F));
            this.tableLayoutPanel1.Controls.Add(this.txtQuilometragem, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPlaca, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLocal, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblData, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQuilometragem, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAdicionar, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblMesagemObrigatoriedade, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLocal, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.maskData, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDescricao, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtDescricao, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtValor, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblTipo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblValor, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxTipo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPlaca, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labeltesteErro, 3, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.083563F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.005592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.005592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.005592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.005592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.005592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.005592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.005592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.005592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.01017F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.360042F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.50148F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 308);
            this.tableLayoutPanel1.TabIndex = 4;
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
            this.btnAdicionar.Location = new System.Drawing.Point(341, 260);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(110, 30);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "       Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
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
            this.button1.Location = new System.Drawing.Point(187, 260);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "       Cancelar";
            this.button1.UseVisualStyleBackColor = false;
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
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescricao.Location = new System.Drawing.Point(46, 194);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(249, 51);
            this.txtDescricao.TabIndex = 7;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.DimGray;
            this.lblValor.Location = new System.Drawing.Point(341, 108);
            this.lblValor.Margin = new System.Windows.Forms.Padding(0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(253, 21);
            this.lblValor.TabIndex = 53;
            this.lblValor.Text = "Valor *";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipo.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Preventiva",
            "Corretiva"});
            this.comboBoxTipo.Location = new System.Drawing.Point(47, 90);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(247, 26);
            this.comboBoxTipo.TabIndex = 2;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.ForeColor = System.Drawing.Color.DimGray;
            this.txtPlaca.Location = new System.Drawing.Point(46, 47);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(249, 24);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.Click += new System.EventHandler(this.TxtPlaca_Click);
            // 
            // labeltesteErro
            // 
            this.labeltesteErro.AutoSize = true;
            this.labeltesteErro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeltesteErro.ForeColor = System.Drawing.Color.Red;
            this.labeltesteErro.Location = new System.Drawing.Point(344, 150);
            this.labeltesteErro.Name = "labeltesteErro";
            this.labeltesteErro.Size = new System.Drawing.Size(247, 21);
            this.labeltesteErro.TabIndex = 59;
            this.labeltesteErro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblTituloForm.TabIndex = 5;
            this.lblTituloForm.Text = "Cadastrar Manutenção";
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CadastrarManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 340);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarManutencao";
            this.Text = "CadastrarManutencao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarManutencao_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblQuilometragem;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMesagemObrigatoriedade;
        public System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label labeltesteErro;
        public System.Windows.Forms.TextBox txtPlaca;
        public System.Windows.Forms.MaskedTextBox maskData;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.TextBox txtLocal;
        public System.Windows.Forms.TextBox txtQuilometragem;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.ComboBox comboBoxTipo;
    }
}