namespace PimForms.Formulários
{
    partial class ListarVeiculos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarVeiculos));
            this.dataGridListar = new System.Windows.Forms.DataGridView();
            this.lblTamanhoDaLista = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonListar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxPlaca = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonPesquisar = new System.Windows.Forms.ToolStripButton();
            this.lblTituloForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridListar
            // 
            this.dataGridListar.AllowUserToAddRows = false;
            this.dataGridListar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridListar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridListar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridListar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridListar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridListar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridListar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridListar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridListar.ColumnHeadersHeight = 35;
            this.dataGridListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridListar.EnableHeadersVisualStyles = false;
            this.dataGridListar.GridColor = System.Drawing.Color.LightGray;
            this.dataGridListar.Location = new System.Drawing.Point(20, 112);
            this.dataGridListar.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridListar.Name = "dataGridListar";
            this.dataGridListar.ReadOnly = true;
            this.dataGridListar.RowHeadersVisible = false;
            this.dataGridListar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridListar.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridListar.Size = new System.Drawing.Size(600, 208);
            this.dataGridListar.TabIndex = 50;
            this.dataGridListar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridListar_CellContentClick_1);
            // 
            // lblTamanhoDaLista
            // 
            this.lblTamanhoDaLista.AutoSize = true;
            this.lblTamanhoDaLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanhoDaLista.Location = new System.Drawing.Point(360, 69);
            this.lblTamanhoDaLista.Name = "lblTamanhoDaLista";
            this.lblTamanhoDaLista.Size = new System.Drawing.Size(0, 18);
            this.lblTamanhoDaLista.TabIndex = 49;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonListar,
            this.toolStripButtonEditar,
            this.toolStripButtonExcluir,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripTextBoxPlaca,
            this.toolStripButtonPesquisar});
            this.toolStrip1.Location = new System.Drawing.Point(20, 42);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 60);
            this.toolStrip1.TabIndex = 48;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // toolStripButtonListar
            // 
            this.toolStripButtonListar.AutoSize = false;
            this.toolStripButtonListar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonListar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonListar.Image")));
            this.toolStripButtonListar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonListar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonListar.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripButtonListar.Name = "toolStripButtonListar";
            this.toolStripButtonListar.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonListar.Text = "toolStripButton2";
            this.toolStripButtonListar.ToolTipText = "Listar";
            this.toolStripButtonListar.Click += new System.EventHandler(this.ToolStripButtonListar_Click);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.AutoSize = false;
            this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditar.Image")));
            this.toolStripButtonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonEditar.Text = "toolStripButton3";
            this.toolStripButtonEditar.ToolTipText = "Editar";
            this.toolStripButtonEditar.Click += new System.EventHandler(this.ToolStripButtonEditar_Click);
            // 
            // toolStripButtonExcluir
            // 
            this.toolStripButtonExcluir.AutoSize = false;
            this.toolStripButtonExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExcluir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExcluir.Image")));
            this.toolStripButtonExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExcluir.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripButtonExcluir.Name = "toolStripButtonExcluir";
            this.toolStripButtonExcluir.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonExcluir.Text = "toolStripButton2";
            this.toolStripButtonExcluir.ToolTipText = "Excluir";
            this.toolStripButtonExcluir.Click += new System.EventHandler(this.ToolStripButtonExcluir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(38, 60);
            this.toolStripLabel1.Text = "Placa";
            // 
            // toolStripTextBoxPlaca
            // 
            this.toolStripTextBoxPlaca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripTextBoxPlaca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.toolStripTextBoxPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxPlaca.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripTextBoxPlaca.Name = "toolStripTextBoxPlaca";
            this.toolStripTextBoxPlaca.Size = new System.Drawing.Size(100, 60);
            this.toolStripTextBoxPlaca.Click += new System.EventHandler(this.ToolStripTextBoxPlaca_Click);
            // 
            // toolStripButtonPesquisar
            // 
            this.toolStripButtonPesquisar.AutoSize = false;
            this.toolStripButtonPesquisar.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripButtonPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPesquisar.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripButtonPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPesquisar.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripButtonPesquisar.Name = "toolStripButtonPesquisar";
            this.toolStripButtonPesquisar.Size = new System.Drawing.Size(80, 25);
            this.toolStripButtonPesquisar.Text = "Pesquisar";
            this.toolStripButtonPesquisar.Click += new System.EventHandler(this.ToolStripButtonPesquisar_Click);
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.BackColor = System.Drawing.Color.Gray;
            this.lblTituloForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(0, 0);
            this.lblTituloForm.Margin = new System.Windows.Forms.Padding(0);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(640, 32);
            this.lblTituloForm.TabIndex = 47;
            this.lblTituloForm.Text = "Consultar Veículos";
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListarVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 340);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.dataGridListar);
            this.Controls.Add(this.lblTamanhoDaLista);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarVeiculos";
            this.Text = "ListarVeiculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListarVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridListar;
        private System.Windows.Forms.Label lblTamanhoDaLista;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonListar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripButton toolStripButtonExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPesquisar;
        public System.Windows.Forms.Label lblTituloForm;
        public System.Windows.Forms.ToolStripTextBox toolStripTextBoxPlaca;
    }
}