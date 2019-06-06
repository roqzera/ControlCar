namespace PimForms.Formulários
{
    partial class ListarMulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarMulta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonListar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonPesquisar = new System.Windows.Forms.ToolStripButton();
            this.dataGridListar = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListar)).BeginInit();
            this.SuspendLayout();
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
            this.lblTituloForm.TabIndex = 4;
            this.lblTituloForm.Text = "Consultar Multas";
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.toolStripButton1,
            this.toolStripButtonListar,
            this.toolStripButtonEditar,
            this.toolStripButtonExcluir,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtPesquisa,
            this.toolStripButtonPesquisar});
            this.toolStrip1.Location = new System.Drawing.Point(31, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 60);
            this.toolStrip1.TabIndex = 49;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Atualizar";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
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
            this.toolStripButtonListar.Click += new System.EventHandler(this.ToolStripButtonListar_Click_1);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(104, 60);
            this.toolStripLabel1.Text = "Placa Do Veiculo";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(100, 60);
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
            this.toolStripButtonPesquisar.Click += new System.EventHandler(this.ToolStripButtonPesquisar_Click_1);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridListar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridListar.ColumnHeadersHeight = 35;
            this.dataGridListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridListar.EnableHeadersVisualStyles = false;
            this.dataGridListar.GridColor = System.Drawing.Color.LightGray;
            this.dataGridListar.Location = new System.Drawing.Point(18, 92);
            this.dataGridListar.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridListar.Name = "dataGridListar";
            this.dataGridListar.ReadOnly = true;
            this.dataGridListar.RowHeadersVisible = false;
            this.dataGridListar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridListar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridListar.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridListar.Size = new System.Drawing.Size(600, 208);
            this.dataGridListar.TabIndex = 50;
            // 
            // ListarMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 340);
            this.Controls.Add(this.dataGridListar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblTituloForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarMulta";
            this.Text = "ListarMulta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListarMulta_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButtonListar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripButton toolStripButtonExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPesquisar;
        private System.Windows.Forms.DataGridView dataGridListar;
        private System.Windows.Forms.ToolStripTextBox txtPesquisa;
    }
}