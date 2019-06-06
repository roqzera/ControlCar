namespace PimForms.Formulários
{
    partial class CadastrarAcompanhante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarAcompanhante));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtMatriculaOcupante = new System.Windows.Forms.ToolStripTextBox();
            this.btnAdicionarOcupante = new System.Windows.Forms.ToolStripButton();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblQuantidadeDeAcompanhantes = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblOcupante3 = new System.Windows.Forms.Label();
            this.lblOcupante2 = new System.Windows.Forms.Label();
            this.lblOcupante1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtMatriculaOcupante,
            this.btnAdicionarOcupante});
            this.toolStrip1.Location = new System.Drawing.Point(262, 94);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(424, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(170, 22);
            this.toolStripLabel1.Text = "Matrícula do Acompanhante";
            // 
            // txtMatriculaOcupante
            // 
            this.txtMatriculaOcupante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatriculaOcupante.ForeColor = System.Drawing.Color.DimGray;
            this.txtMatriculaOcupante.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtMatriculaOcupante.Name = "txtMatriculaOcupante";
            this.txtMatriculaOcupante.Size = new System.Drawing.Size(100, 25);
            // 
            // btnAdicionarOcupante
            // 
            this.btnAdicionarOcupante.AutoSize = false;
            this.btnAdicionarOcupante.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdicionarOcupante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdicionarOcupante.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdicionarOcupante.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarOcupante.Image")));
            this.btnAdicionarOcupante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionarOcupante.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAdicionarOcupante.Name = "btnAdicionarOcupante";
            this.btnAdicionarOcupante.Size = new System.Drawing.Size(80, 25);
            this.btnAdicionarOcupante.Text = "Adicionar";
            this.btnAdicionarOcupante.Click += new System.EventHandler(this.BtnAdicionarOcupante_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Gray;
            this.btnFechar.Enabled = false;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(321, 426);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 30);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
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
            this.lblTituloForm.Size = new System.Drawing.Size(900, 32);
            this.lblTituloForm.TabIndex = 11;
            this.lblTituloForm.Text = "Deseja cadastrar Acompanhantes?";
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblId);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblQuantidadeDeAcompanhantes);
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Controls.Add(this.lblOcupante3);
            this.panel2.Controls.Add(this.lblOcupante2);
            this.panel2.Controls.Add(this.lblOcupante1);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 500);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(683, 364);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "label1";
            this.lblId.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PimForms.Properties.Resources.img_usuario_login_gray_30x30;
            this.pictureBox3.Location = new System.Drawing.Point(121, 257);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PimForms.Properties.Resources.img_usuario_login_gray_30x30;
            this.pictureBox2.Location = new System.Drawing.Point(121, 214);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PimForms.Properties.Resources.img_usuario_login_gray_30x30;
            this.pictureBox1.Location = new System.Drawing.Point(121, 170);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblQuantidadeDeAcompanhantes
            // 
            this.lblQuantidadeDeAcompanhantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeDeAcompanhantes.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuantidadeDeAcompanhantes.Location = new System.Drawing.Point(118, 346);
            this.lblQuantidadeDeAcompanhantes.Name = "lblQuantidadeDeAcompanhantes";
            this.lblQuantidadeDeAcompanhantes.Size = new System.Drawing.Size(600, 18);
            this.lblQuantidadeDeAcompanhantes.TabIndex = 14;
            this.lblQuantidadeDeAcompanhantes.Text = "Até o momento nenhum acompanhante foi adicionado a esta viagem.";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Gray;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(469, 426);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 30);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Cadastrar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // lblOcupante3
            // 
            this.lblOcupante3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupante3.ForeColor = System.Drawing.Color.DimGray;
            this.lblOcupante3.Location = new System.Drawing.Point(155, 259);
            this.lblOcupante3.Name = "lblOcupante3";
            this.lblOcupante3.Size = new System.Drawing.Size(600, 18);
            this.lblOcupante3.TabIndex = 12;
            // 
            // lblOcupante2
            // 
            this.lblOcupante2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupante2.ForeColor = System.Drawing.Color.DimGray;
            this.lblOcupante2.Location = new System.Drawing.Point(155, 216);
            this.lblOcupante2.Name = "lblOcupante2";
            this.lblOcupante2.Size = new System.Drawing.Size(600, 18);
            this.lblOcupante2.TabIndex = 11;
            // 
            // lblOcupante1
            // 
            this.lblOcupante1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupante1.ForeColor = System.Drawing.Color.DimGray;
            this.lblOcupante1.Location = new System.Drawing.Point(155, 172);
            this.lblOcupante1.Name = "lblOcupante1";
            this.lblOcupante1.Size = new System.Drawing.Size(600, 18);
            this.lblOcupante1.TabIndex = 10;
            // 
            // CadastrarAcompanhante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarAcompanhante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarOcupantes";
            this.Load += new System.EventHandler(this.CadastrarOcupantes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtMatriculaOcupante;
        private System.Windows.Forms.ToolStripButton btnAdicionarOcupante;
        public System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.Label lblOcupante3;
        public System.Windows.Forms.Label lblOcupante2;
        public System.Windows.Forms.Label lblOcupante1;
        public System.Windows.Forms.Label lblQuantidadeDeAcompanhantes;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Button btnFechar;
    }
}