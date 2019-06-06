namespace PimForms.Formulários
{
    partial class CadastrarFuncionario
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.maskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskValidadeCNH = new System.Windows.Forms.MaskedTextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblDataDeNascimento = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNumeroCnh = new System.Windows.Forms.Label();
            this.lblCategoriaDaCnh = new System.Windows.Forms.Label();
            this.lblValidadeCnh = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labeltesteErro = new System.Windows.Forms.Label();
            this.comboBoxCategoriaCnh = new System.Windows.Forms.ComboBox();
            this.lblMesagemObrigatoriedade = new System.Windows.Forms.Label();
            this.maskMatricula = new System.Windows.Forms.MaskedTextBox();
            this.maskNumeroCnh = new System.Windows.Forms.MaskedTextBox();
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
            this.lblTituloForm.TabIndex = 1;
            this.lblTituloForm.Text = "Cadastrar Funcionário";
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel1.Controls.Add(this.txtNome, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCargo, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.maskCPF, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.maskDataNascimento, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.maskTelefone, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.maskValidadeCNH, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblMatricula, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNome, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCpf, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDataDeNascimento, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblTelefone, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblCargo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblNumeroCnh, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCategoriaDaCnh, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblValidadeCnh, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnAdicionar, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.labeltesteErro, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCategoriaCnh, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblMesagemObrigatoriedade, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.maskMatricula, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.maskNumeroCnh, 3, 6);
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
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtNome.Location = new System.Drawing.Point(46, 89);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(249, 24);
            this.txtNome.TabIndex = 2;
            this.txtNome.Click += new System.EventHandler(this.TxtNome_Click);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            // 
            // txtCargo
            // 
            this.txtCargo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCargo.Location = new System.Drawing.Point(343, 47);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(249, 24);
            this.txtCargo.TabIndex = 6;
            this.txtCargo.Click += new System.EventHandler(this.TxtCargo_Click);
            this.txtCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCargo_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(343, 89);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 24);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Click += new System.EventHandler(this.TxtEmail_Click);
            // 
            // maskCPF
            // 
            this.maskCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCPF.ForeColor = System.Drawing.Color.DimGray;
            this.maskCPF.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.maskCPF.Location = new System.Drawing.Point(47, 132);
            this.maskCPF.Mask = "000,000,000-00 ";
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(247, 24);
            this.maskCPF.TabIndex = 3;
            this.maskCPF.Click += new System.EventHandler(this.MaskCPF_Click);
            // 
            // maskDataNascimento
            // 
            this.maskDataNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskDataNascimento.ForeColor = System.Drawing.Color.DimGray;
            this.maskDataNascimento.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.maskDataNascimento.Location = new System.Drawing.Point(47, 174);
            this.maskDataNascimento.Mask = "00/00/0000";
            this.maskDataNascimento.Name = "maskDataNascimento";
            this.maskDataNascimento.Size = new System.Drawing.Size(247, 24);
            this.maskDataNascimento.TabIndex = 4;
            this.maskDataNascimento.ValidatingType = typeof(System.DateTime);
            this.maskDataNascimento.Click += new System.EventHandler(this.MaskDataNascimento_Click);
            // 
            // maskTelefone
            // 
            this.maskTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskTelefone.ForeColor = System.Drawing.Color.DimGray;
            this.maskTelefone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.maskTelefone.Location = new System.Drawing.Point(47, 216);
            this.maskTelefone.Mask = "(00)00000-0000";
            this.maskTelefone.Name = "maskTelefone";
            this.maskTelefone.Size = new System.Drawing.Size(247, 24);
            this.maskTelefone.TabIndex = 5;
            this.maskTelefone.Click += new System.EventHandler(this.MaskTelefone_Click_1);
            // 
            // maskValidadeCNH
            // 
            this.maskValidadeCNH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskValidadeCNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskValidadeCNH.ForeColor = System.Drawing.Color.DimGray;
            this.maskValidadeCNH.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.maskValidadeCNH.Location = new System.Drawing.Point(344, 216);
            this.maskValidadeCNH.Mask = "00/00/0000";
            this.maskValidadeCNH.Name = "maskValidadeCNH";
            this.maskValidadeCNH.Size = new System.Drawing.Size(247, 24);
            this.maskValidadeCNH.TabIndex = 10;
            this.maskValidadeCNH.ValidatingType = typeof(System.DateTime);
            this.maskValidadeCNH.Click += new System.EventHandler(this.MaskValidadeCNH_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.ForeColor = System.Drawing.Color.DimGray;
            this.lblMatricula.Location = new System.Drawing.Point(44, 24);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(253, 21);
            this.lblMatricula.TabIndex = 33;
            this.lblMatricula.Text = "Matrícula *";
            this.lblMatricula.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.DimGray;
            this.lblNome.Location = new System.Drawing.Point(44, 66);
            this.lblNome.Margin = new System.Windows.Forms.Padding(0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(253, 21);
            this.lblNome.TabIndex = 34;
            this.lblNome.Text = "Nome *";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.Color.DimGray;
            this.lblCpf.Location = new System.Drawing.Point(44, 108);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(253, 21);
            this.lblCpf.TabIndex = 35;
            this.lblCpf.Text = "CPF *";
            this.lblCpf.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDataDeNascimento
            // 
            this.lblDataDeNascimento.AutoSize = true;
            this.lblDataDeNascimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataDeNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeNascimento.ForeColor = System.Drawing.Color.DimGray;
            this.lblDataDeNascimento.Location = new System.Drawing.Point(44, 150);
            this.lblDataDeNascimento.Margin = new System.Windows.Forms.Padding(0);
            this.lblDataDeNascimento.Name = "lblDataDeNascimento";
            this.lblDataDeNascimento.Size = new System.Drawing.Size(253, 21);
            this.lblDataDeNascimento.TabIndex = 36;
            this.lblDataDeNascimento.Text = "Data de Nascimento *";
            this.lblDataDeNascimento.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.DimGray;
            this.lblTelefone.Location = new System.Drawing.Point(44, 192);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(253, 21);
            this.lblTelefone.TabIndex = 37;
            this.lblTelefone.Text = "Celular *";
            this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.DimGray;
            this.lblCargo.Location = new System.Drawing.Point(341, 24);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(253, 21);
            this.lblCargo.TabIndex = 38;
            this.lblCargo.Text = "Cargo *";
            this.lblCargo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Location = new System.Drawing.Point(341, 66);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(253, 21);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "E-mail *";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblNumeroCnh
            // 
            this.lblNumeroCnh.AutoSize = true;
            this.lblNumeroCnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumeroCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCnh.ForeColor = System.Drawing.Color.DimGray;
            this.lblNumeroCnh.Location = new System.Drawing.Point(341, 108);
            this.lblNumeroCnh.Margin = new System.Windows.Forms.Padding(0);
            this.lblNumeroCnh.Name = "lblNumeroCnh";
            this.lblNumeroCnh.Size = new System.Drawing.Size(253, 21);
            this.lblNumeroCnh.TabIndex = 40;
            this.lblNumeroCnh.Text = "Número da CNH";
            this.lblNumeroCnh.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblCategoriaDaCnh
            // 
            this.lblCategoriaDaCnh.AutoSize = true;
            this.lblCategoriaDaCnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategoriaDaCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaDaCnh.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategoriaDaCnh.Location = new System.Drawing.Point(341, 150);
            this.lblCategoriaDaCnh.Margin = new System.Windows.Forms.Padding(0);
            this.lblCategoriaDaCnh.Name = "lblCategoriaDaCnh";
            this.lblCategoriaDaCnh.Size = new System.Drawing.Size(253, 21);
            this.lblCategoriaDaCnh.TabIndex = 41;
            this.lblCategoriaDaCnh.Text = "Categoria da CNH";
            this.lblCategoriaDaCnh.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblValidadeCnh
            // 
            this.lblValidadeCnh.AutoSize = true;
            this.lblValidadeCnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValidadeCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidadeCnh.ForeColor = System.Drawing.Color.DimGray;
            this.lblValidadeCnh.Location = new System.Drawing.Point(341, 192);
            this.lblValidadeCnh.Margin = new System.Windows.Forms.Padding(0);
            this.lblValidadeCnh.Name = "lblValidadeCnh";
            this.lblValidadeCnh.Size = new System.Drawing.Size(253, 21);
            this.lblValidadeCnh.TabIndex = 42;
            this.lblValidadeCnh.Text = "Validade da CNH";
            this.lblValidadeCnh.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.button1.Click += new System.EventHandler(this.Button1_Click);
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
            // comboBoxCategoriaCnh
            // 
            this.comboBoxCategoriaCnh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategoriaCnh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoriaCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoriaCnh.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxCategoriaCnh.FormattingEnabled = true;
            this.comboBoxCategoriaCnh.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "C",
            "D",
            "E"});
            this.comboBoxCategoriaCnh.Location = new System.Drawing.Point(344, 174);
            this.comboBoxCategoriaCnh.Name = "comboBoxCategoriaCnh";
            this.comboBoxCategoriaCnh.Size = new System.Drawing.Size(247, 23);
            this.comboBoxCategoriaCnh.TabIndex = 9;
            this.comboBoxCategoriaCnh.Click += new System.EventHandler(this.ComboBoxCategoriaCnh_Click);
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
            // maskMatricula
            // 
            this.maskMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskMatricula.ForeColor = System.Drawing.Color.DimGray;
            this.maskMatricula.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.maskMatricula.Location = new System.Drawing.Point(47, 48);
            this.maskMatricula.Mask = ">A>A>A>A>A";
            this.maskMatricula.Name = "maskMatricula";
            this.maskMatricula.Size = new System.Drawing.Size(247, 24);
            this.maskMatricula.TabIndex = 1;
            this.maskMatricula.ValidatingType = typeof(System.DateTime);
            this.maskMatricula.Click += new System.EventHandler(this.MaskMatricula_Click);
            // 
            // maskNumeroCnh
            // 
            this.maskNumeroCnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskNumeroCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskNumeroCnh.ForeColor = System.Drawing.Color.DimGray;
            this.maskNumeroCnh.Location = new System.Drawing.Point(344, 132);
            this.maskNumeroCnh.Mask = ">A>A>A>A>A>A>A>A>A>A>A";
            this.maskNumeroCnh.Name = "maskNumeroCnh";
            this.maskNumeroCnh.Size = new System.Drawing.Size(247, 24);
            this.maskNumeroCnh.TabIndex = 8;
            this.maskNumeroCnh.Click += new System.EventHandler(this.MaskNumeroCnh_Click);
            // 
            // CadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 340);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblTituloForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarFuncionario";
            this.Text = "CadastrarFuncionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarFuncionario_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblDataDeNascimento;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNumeroCnh;
        private System.Windows.Forms.Label lblCategoriaDaCnh;
        private System.Windows.Forms.Label lblValidadeCnh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labeltesteErro;
        private System.Windows.Forms.Label lblMesagemObrigatoriedade;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtCargo;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.MaskedTextBox maskCPF;
        public System.Windows.Forms.MaskedTextBox maskDataNascimento;
        public System.Windows.Forms.MaskedTextBox maskTelefone;
        public System.Windows.Forms.MaskedTextBox maskValidadeCNH;
        public System.Windows.Forms.ComboBox comboBoxCategoriaCnh;
        public System.Windows.Forms.MaskedTextBox maskMatricula;
        public System.Windows.Forms.MaskedTextBox maskNumeroCnh;
    }
}