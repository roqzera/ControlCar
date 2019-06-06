namespace PimForms.SubMenus
{
    partial class FormSubMenuViagem
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
            this.pnlFormulariosViagem = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultarCusto = new System.Windows.Forms.Button();
            this.btnConsultarViagem = new System.Windows.Forms.Button();
            this.btnCadastrarCusto = new System.Windows.Forms.Button();
            this.btnCadastrarViagem = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormulariosViagem
            // 
            this.pnlFormulariosViagem.BackColor = System.Drawing.Color.White;
            this.pnlFormulariosViagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulariosViagem.Location = new System.Drawing.Point(160, 0);
            this.pnlFormulariosViagem.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFormulariosViagem.Name = "pnlFormulariosViagem";
            this.pnlFormulariosViagem.Size = new System.Drawing.Size(640, 340);
            this.pnlFormulariosViagem.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.pnlFormulariosViagem, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 340);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(160, 340);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConsultarCusto);
            this.panel1.Controls.Add(this.btnConsultarViagem);
            this.panel1.Controls.Add(this.btnCadastrarCusto);
            this.panel1.Controls.Add(this.btnCadastrarViagem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 308);
            this.panel1.TabIndex = 1;
            // 
            // btnConsultarCusto
            // 
            this.btnConsultarCusto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultarCusto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConsultarCusto.FlatAppearance.BorderSize = 0;
            this.btnConsultarCusto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnConsultarCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCusto.ForeColor = System.Drawing.Color.Gray;
            this.btnConsultarCusto.Image = global::PimForms.Properties.Resources.img_consultar_gray_30x30;
            this.btnConsultarCusto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarCusto.Location = new System.Drawing.Point(0, 180);
            this.btnConsultarCusto.Margin = new System.Windows.Forms.Padding(0);
            this.btnConsultarCusto.Name = "btnConsultarCusto";
            this.btnConsultarCusto.Size = new System.Drawing.Size(160, 50);
            this.btnConsultarCusto.TabIndex = 7;
            this.btnConsultarCusto.Text = "Consultar Custo";
            this.btnConsultarCusto.UseVisualStyleBackColor = false;
            this.btnConsultarCusto.Click += new System.EventHandler(this.BtnConsultarCusto_Click);
            // 
            // btnConsultarViagem
            // 
            this.btnConsultarViagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultarViagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConsultarViagem.FlatAppearance.BorderSize = 0;
            this.btnConsultarViagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnConsultarViagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarViagem.ForeColor = System.Drawing.Color.Gray;
            this.btnConsultarViagem.Image = global::PimForms.Properties.Resources.img_consultar_gray_30x30;
            this.btnConsultarViagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarViagem.Location = new System.Drawing.Point(0, 60);
            this.btnConsultarViagem.Margin = new System.Windows.Forms.Padding(0);
            this.btnConsultarViagem.Name = "btnConsultarViagem";
            this.btnConsultarViagem.Size = new System.Drawing.Size(160, 50);
            this.btnConsultarViagem.TabIndex = 4;
            this.btnConsultarViagem.Text = "Consultar Viagem";
            this.btnConsultarViagem.UseVisualStyleBackColor = false;
            this.btnConsultarViagem.Click += new System.EventHandler(this.BtnConsultarViagem_Click);
            // 
            // btnCadastrarCusto
            // 
            this.btnCadastrarCusto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarCusto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarCusto.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCusto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCadastrarCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCusto.ForeColor = System.Drawing.Color.Gray;
            this.btnCadastrarCusto.Image = global::PimForms.Properties.Resources.img_custo_gray_30x30;
            this.btnCadastrarCusto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarCusto.Location = new System.Drawing.Point(0, 120);
            this.btnCadastrarCusto.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarCusto.Name = "btnCadastrarCusto";
            this.btnCadastrarCusto.Size = new System.Drawing.Size(160, 50);
            this.btnCadastrarCusto.TabIndex = 5;
            this.btnCadastrarCusto.Text = "Cadastrar Custo ";
            this.btnCadastrarCusto.UseVisualStyleBackColor = false;
            this.btnCadastrarCusto.Click += new System.EventHandler(this.BtnCadastrarCusto_Click);
            // 
            // btnCadastrarViagem
            // 
            this.btnCadastrarViagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarViagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarViagem.FlatAppearance.BorderSize = 0;
            this.btnCadastrarViagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCadastrarViagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarViagem.ForeColor = System.Drawing.Color.Gray;
            this.btnCadastrarViagem.Image = global::PimForms.Properties.Resources.img_viagem_gray_30x30;
            this.btnCadastrarViagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarViagem.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrarViagem.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarViagem.Name = "btnCadastrarViagem";
            this.btnCadastrarViagem.Size = new System.Drawing.Size(160, 50);
            this.btnCadastrarViagem.TabIndex = 3;
            this.btnCadastrarViagem.Text = "Cadastrar Viagem";
            this.btnCadastrarViagem.UseVisualStyleBackColor = false;
            this.btnCadastrarViagem.Click += new System.EventHandler(this.BtnCadastrarViagem_Click);
            // 
            // FormSubMenuViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSubMenuViagem";
            this.Text = "FormSubMenuViagem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlFormulariosViagem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button btnCadastrarViagem;
        protected System.Windows.Forms.Button btnConsultarCusto;
        protected System.Windows.Forms.Button btnConsultarViagem;
        protected System.Windows.Forms.Button btnCadastrarCusto;
    }
}