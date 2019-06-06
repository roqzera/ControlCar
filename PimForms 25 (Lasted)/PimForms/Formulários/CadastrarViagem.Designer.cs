namespace PimForms.Formulários
{
    partial class CadastrarViagem
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
            this.tbxKmInicial = new System.Windows.Forms.TextBox();
            this.maskValorAdiantamento = new System.Windows.Forms.MaskedTextBox();
            this.lblPlacaVeiculo = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblValorAdiantamento = new System.Windows.Forms.Label();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblDataRetorno = new System.Windows.Forms.Label();
            this.lblKmInicial = new System.Windows.Forms.Label();
            this.lblKmFinal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedDataSaida = new System.Windows.Forms.MaskedTextBox();
            this.maskedDataRetorno = new System.Windows.Forms.MaskedTextBox();
            this.tbxKmFinal = new System.Windows.Forms.TextBox();
            this.tbxDestino = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.lblMesagemObrigatoriedade = new System.Windows.Forms.Label();
            this.tbxPlaca = new System.Windows.Forms.TextBox();
            this.labeltesteErro = new System.Windows.Forms.Label();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxKmInicial
            // 
            this.tbxKmInicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxKmInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKmInicial.ForeColor = System.Drawing.Color.DimGray;
            this.tbxKmInicial.Location = new System.Drawing.Point(343, 131);
            this.tbxKmInicial.Margin = new System.Windows.Forms.Padding(2);
            this.tbxKmInicial.Name = "tbxKmInicial";
            this.tbxKmInicial.Size = new System.Drawing.Size(249, 24);
            this.tbxKmInicial.TabIndex = 7;
            this.tbxKmInicial.Click += new System.EventHandler(this.TbxKmInicial_Click);
            // 
            // maskValorAdiantamento
            // 
            this.maskValorAdiantamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskValorAdiantamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskValorAdiantamento.ForeColor = System.Drawing.Color.DimGray;
            this.maskValorAdiantamento.Location = new System.Drawing.Point(47, 174);
            this.maskValorAdiantamento.Name = "maskValorAdiantamento";
            this.maskValorAdiantamento.Size = new System.Drawing.Size(247, 24);
            this.maskValorAdiantamento.TabIndex = 4;
            this.maskValorAdiantamento.Click += new System.EventHandler(this.MaskValorAdiantamento_Click);
            // 
            // lblPlacaVeiculo
            // 
            this.lblPlacaVeiculo.AutoSize = true;
            this.lblPlacaVeiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlacaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPlacaVeiculo.ForeColor = System.Drawing.Color.DimGray;
            this.lblPlacaVeiculo.Location = new System.Drawing.Point(44, 66);
            this.lblPlacaVeiculo.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            this.lblPlacaVeiculo.Size = new System.Drawing.Size(253, 21);
            this.lblPlacaVeiculo.TabIndex = 34;
            this.lblPlacaVeiculo.Text = "Placa do Veículo *";
            this.lblPlacaVeiculo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDestino.ForeColor = System.Drawing.Color.DimGray;
            this.lblDestino.Location = new System.Drawing.Point(44, 108);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(253, 21);
            this.lblDestino.TabIndex = 35;
            this.lblDestino.Text = "Destino *";
            this.lblDestino.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblValorAdiantamento
            // 
            this.lblValorAdiantamento.AutoSize = true;
            this.lblValorAdiantamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorAdiantamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblValorAdiantamento.ForeColor = System.Drawing.Color.DimGray;
            this.lblValorAdiantamento.Location = new System.Drawing.Point(44, 150);
            this.lblValorAdiantamento.Margin = new System.Windows.Forms.Padding(0);
            this.lblValorAdiantamento.Name = "lblValorAdiantamento";
            this.lblValorAdiantamento.Size = new System.Drawing.Size(253, 21);
            this.lblValorAdiantamento.TabIndex = 37;
            this.lblValorAdiantamento.Text = "Valor do Adiantamento *";
            this.lblValorAdiantamento.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDataSaida.ForeColor = System.Drawing.Color.DimGray;
            this.lblDataSaida.Location = new System.Drawing.Point(341, 26);
            this.lblDataSaida.Margin = new System.Windows.Forms.Padding(0);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(253, 19);
            this.lblDataSaida.TabIndex = 38;
            this.lblDataSaida.Text = "Data Saída *";
            this.lblDataSaida.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDataRetorno
            // 
            this.lblDataRetorno.AutoSize = true;
            this.lblDataRetorno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDataRetorno.ForeColor = System.Drawing.Color.DimGray;
            this.lblDataRetorno.Location = new System.Drawing.Point(341, 66);
            this.lblDataRetorno.Margin = new System.Windows.Forms.Padding(0);
            this.lblDataRetorno.Name = "lblDataRetorno";
            this.lblDataRetorno.Size = new System.Drawing.Size(253, 21);
            this.lblDataRetorno.TabIndex = 39;
            this.lblDataRetorno.Text = "Data Retorno *";
            this.lblDataRetorno.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblKmInicial
            // 
            this.lblKmInicial.AutoSize = true;
            this.lblKmInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKmInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblKmInicial.ForeColor = System.Drawing.Color.DimGray;
            this.lblKmInicial.Location = new System.Drawing.Point(341, 108);
            this.lblKmInicial.Margin = new System.Windows.Forms.Padding(0);
            this.lblKmInicial.Name = "lblKmInicial";
            this.lblKmInicial.Size = new System.Drawing.Size(253, 21);
            this.lblKmInicial.TabIndex = 40;
            this.lblKmInicial.Text = "KM Inicial *";
            this.lblKmInicial.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblKmFinal
            // 
            this.lblKmFinal.AutoSize = true;
            this.lblKmFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKmFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblKmFinal.ForeColor = System.Drawing.Color.DimGray;
            this.lblKmFinal.Location = new System.Drawing.Point(341, 150);
            this.lblKmFinal.Margin = new System.Windows.Forms.Padding(0);
            this.lblKmFinal.Name = "lblKmFinal";
            this.lblKmFinal.Size = new System.Drawing.Size(253, 21);
            this.lblKmFinal.TabIndex = 41;
            this.lblKmFinal.Text = "KM Final";
            this.lblKmFinal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.tableLayoutPanel1.Controls.Add(this.tbxKmInicial, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblDataSaida, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDataRetorno, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblKmInicial, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblKmFinal, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnAdicionar, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.maskedDataSaida, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.maskedDataRetorno, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbxKmFinal, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblPlacaVeiculo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDestino, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbxDestino, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblValorAdiantamento, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.maskValorAdiantamento, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblNome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFuncionario, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMesagemObrigatoriedade, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxPlaca, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labeltesteErro, 1, 11);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.441559F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.168831F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 309);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint_1);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Gray;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Image = global::PimForms.Properties.Resources.icone_confirmar_20x20;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(341, 259);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(110, 30);
            this.btnAdicionar.TabIndex = 9;
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
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::PimForms.Properties.Resources.icone_cancelar_20x20;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(187, 259);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "       Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // maskedDataSaida
            // 
            this.maskedDataSaida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedDataSaida.ForeColor = System.Drawing.Color.DimGray;
            this.maskedDataSaida.Location = new System.Drawing.Point(344, 48);
            this.maskedDataSaida.Mask = "00/00/0000";
            this.maskedDataSaida.Name = "maskedDataSaida";
            this.maskedDataSaida.Size = new System.Drawing.Size(247, 24);
            this.maskedDataSaida.TabIndex = 5;
            this.maskedDataSaida.ValidatingType = typeof(System.DateTime);
            this.maskedDataSaida.Click += new System.EventHandler(this.MaskedDataSaida_Click);
            // 
            // maskedDataRetorno
            // 
            this.maskedDataRetorno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedDataRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedDataRetorno.ForeColor = System.Drawing.Color.DimGray;
            this.maskedDataRetorno.Location = new System.Drawing.Point(344, 90);
            this.maskedDataRetorno.Mask = "00/00/0000";
            this.maskedDataRetorno.Name = "maskedDataRetorno";
            this.maskedDataRetorno.Size = new System.Drawing.Size(247, 24);
            this.maskedDataRetorno.TabIndex = 6;
            this.maskedDataRetorno.ValidatingType = typeof(System.DateTime);
            this.maskedDataRetorno.Click += new System.EventHandler(this.MaskedDataRetorno_Click);
            // 
            // tbxKmFinal
            // 
            this.tbxKmFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxKmFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKmFinal.ForeColor = System.Drawing.Color.DimGray;
            this.tbxKmFinal.Location = new System.Drawing.Point(343, 173);
            this.tbxKmFinal.Margin = new System.Windows.Forms.Padding(2);
            this.tbxKmFinal.Name = "tbxKmFinal";
            this.tbxKmFinal.Size = new System.Drawing.Size(249, 24);
            this.tbxKmFinal.TabIndex = 8;
            this.tbxKmFinal.Click += new System.EventHandler(this.TbxKmFinal_Click);
            // 
            // tbxDestino
            // 
            this.tbxDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDestino.ForeColor = System.Drawing.Color.DimGray;
            this.tbxDestino.Location = new System.Drawing.Point(46, 131);
            this.tbxDestino.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDestino.Name = "tbxDestino";
            this.tbxDestino.Size = new System.Drawing.Size(249, 24);
            this.tbxDestino.TabIndex = 3;
            this.tbxDestino.Click += new System.EventHandler(this.TbxDestino_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.DimGray;
            this.lblNome.Location = new System.Drawing.Point(44, 26);
            this.lblNome.Margin = new System.Windows.Forms.Padding(0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(253, 19);
            this.lblNome.TabIndex = 54;
            this.lblNome.Text = "Nome do Funcionario *";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionario.ForeColor = System.Drawing.Color.DimGray;
            this.txtFuncionario.Location = new System.Drawing.Point(46, 47);
            this.txtFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(249, 24);
            this.txtFuncionario.TabIndex = 1;
            this.txtFuncionario.Click += new System.EventHandler(this.TxtFuncionario_Click);
            // 
            // lblMesagemObrigatoriedade
            // 
            this.lblMesagemObrigatoriedade.AutoSize = true;
            this.lblMesagemObrigatoriedade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMesagemObrigatoriedade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesagemObrigatoriedade.ForeColor = System.Drawing.Color.DimGray;
            this.lblMesagemObrigatoriedade.Location = new System.Drawing.Point(47, 0);
            this.lblMesagemObrigatoriedade.Name = "lblMesagemObrigatoriedade";
            this.lblMesagemObrigatoriedade.Size = new System.Drawing.Size(247, 26);
            this.lblMesagemObrigatoriedade.TabIndex = 56;
            this.lblMesagemObrigatoriedade.Text = "(*)  Campos de preenchimento Obrigatório";
            this.lblMesagemObrigatoriedade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxPlaca
            // 
            this.tbxPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlaca.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPlaca.Location = new System.Drawing.Point(46, 89);
            this.tbxPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPlaca.Name = "tbxPlaca";
            this.tbxPlaca.Size = new System.Drawing.Size(249, 24);
            this.tbxPlaca.TabIndex = 2;
            this.tbxPlaca.Click += new System.EventHandler(this.TbxPlaca_Click);
            // 
            // labeltesteErro
            // 
            this.labeltesteErro.AutoSize = true;
            this.labeltesteErro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeltesteErro.ForeColor = System.Drawing.Color.Red;
            this.labeltesteErro.Location = new System.Drawing.Point(47, 234);
            this.labeltesteErro.Name = "labeltesteErro";
            this.labeltesteErro.Size = new System.Drawing.Size(247, 25);
            this.labeltesteErro.TabIndex = 58;
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
            this.lblTituloForm.Text = "Cadastrar Viagem";
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CadastrarViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 340);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarViagem";
            this.Text = "CadastrarViagem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarViagem_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPlacaVeiculo;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblValorAdiantamento;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblDataRetorno;
        private System.Windows.Forms.Label lblKmInicial;
        private System.Windows.Forms.Label lblKmFinal;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMesagemObrigatoriedade;
        public System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Label labeltesteErro;
        public System.Windows.Forms.TextBox tbxKmInicial;
        public System.Windows.Forms.MaskedTextBox maskValorAdiantamento;
        public System.Windows.Forms.TextBox tbxDestino;
        public System.Windows.Forms.MaskedTextBox maskedDataSaida;
        public System.Windows.Forms.MaskedTextBox maskedDataRetorno;
        public System.Windows.Forms.TextBox tbxKmFinal;
        public System.Windows.Forms.TextBox txtFuncionario;
        public System.Windows.Forms.TextBox tbxPlaca;
    }
}