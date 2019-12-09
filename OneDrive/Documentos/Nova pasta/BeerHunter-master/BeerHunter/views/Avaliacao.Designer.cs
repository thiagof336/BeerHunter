namespace BeerHunter.views
{
    partial class telaAvaliacao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Lupulo = new MetroFramework.Controls.MetroLabel();
            this.lbl_TeorAlcolico = new MetroFramework.Controls.MetroLabel();
            this.FotoCerveja = new System.Windows.Forms.PictureBox();
            this.lb_NomeCerveja = new MetroFramework.Controls.MetroLabel();
            this.lbl_Preco = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_avaliar = new MetroFramework.Controls.MetroButton();
            this.gridHistoricoAvaliacaoCerveja = new System.Windows.Forms.DataGridView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lbl_Npreco = new System.Windows.Forms.Label();
            this.lbl_NLocal = new System.Windows.Forms.Label();
            this.lbl_NTemperatura = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoCerveja)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistoricoAvaliacaoCerveja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Lupulo);
            this.groupBox1.Controls.Add(this.lbl_TeorAlcolico);
            this.groupBox1.Controls.Add(this.FotoCerveja);
            this.groupBox1.Controls.Add(this.lb_NomeCerveja);
            this.groupBox1.Controls.Add(this.lbl_Preco);
            this.groupBox1.Location = new System.Drawing.Point(9, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbl_Lupulo
            // 
            this.lbl_Lupulo.AutoSize = true;
            this.lbl_Lupulo.Location = new System.Drawing.Point(14, 369);
            this.lbl_Lupulo.Name = "lbl_Lupulo";
            this.lbl_Lupulo.Size = new System.Drawing.Size(83, 19);
            this.lbl_Lupulo.TabIndex = 17;
            this.lbl_Lupulo.Text = "metroLabel7";
            // 
            // lbl_TeorAlcolico
            // 
            this.lbl_TeorAlcolico.AutoSize = true;
            this.lbl_TeorAlcolico.Location = new System.Drawing.Point(14, 339);
            this.lbl_TeorAlcolico.Name = "lbl_TeorAlcolico";
            this.lbl_TeorAlcolico.Size = new System.Drawing.Size(83, 19);
            this.lbl_TeorAlcolico.TabIndex = 14;
            this.lbl_TeorAlcolico.Text = "metroLabel4";
            // 
            // FotoCerveja
            // 
            this.FotoCerveja.Location = new System.Drawing.Point(48, 42);
            this.FotoCerveja.Name = "FotoCerveja";
            this.FotoCerveja.Size = new System.Drawing.Size(180, 242);
            this.FotoCerveja.TabIndex = 0;
            this.FotoCerveja.TabStop = false;
            // 
            // lb_NomeCerveja
            // 
            this.lb_NomeCerveja.AutoSize = true;
            this.lb_NomeCerveja.Location = new System.Drawing.Point(102, 16);
            this.lb_NomeCerveja.Name = "lb_NomeCerveja";
            this.lb_NomeCerveja.Size = new System.Drawing.Size(81, 19);
            this.lb_NomeCerveja.TabIndex = 11;
            this.lb_NomeCerveja.Text = "metroLabel1";
            // 
            // lbl_Preco
            // 
            this.lbl_Preco.AutoSize = true;
            this.lbl_Preco.Location = new System.Drawing.Point(14, 305);
            this.lbl_Preco.Name = "lbl_Preco";
            this.lbl_Preco.Size = new System.Drawing.Size(83, 19);
            this.lbl_Preco.TabIndex = 12;
            this.lbl_Preco.Text = "metroLabel2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_avaliar);
            this.groupBox2.Controls.Add(this.gridHistoricoAvaliacaoCerveja);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Location = new System.Drawing.Point(321, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_avaliar
            // 
            this.btn_avaliar.Location = new System.Drawing.Point(487, 195);
            this.btn_avaliar.Name = "btn_avaliar";
            this.btn_avaliar.Size = new System.Drawing.Size(75, 23);
            this.btn_avaliar.TabIndex = 10;
            this.btn_avaliar.Text = "Avaliar";
            this.btn_avaliar.UseSelectable = true;
            this.btn_avaliar.Click += new System.EventHandler(this.btn_avaliar_Click);
            // 
            // gridHistoricoAvaliacaoCerveja
            // 
            this.gridHistoricoAvaliacaoCerveja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridHistoricoAvaliacaoCerveja.BackgroundColor = System.Drawing.Color.White;
            this.gridHistoricoAvaliacaoCerveja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridHistoricoAvaliacaoCerveja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.gridHistoricoAvaliacaoCerveja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridHistoricoAvaliacaoCerveja.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridHistoricoAvaliacaoCerveja.GridColor = System.Drawing.SystemColors.Control;
            this.gridHistoricoAvaliacaoCerveja.Location = new System.Drawing.Point(6, 16);
            this.gridHistoricoAvaliacaoCerveja.Name = "gridHistoricoAvaliacaoCerveja";
            this.gridHistoricoAvaliacaoCerveja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHistoricoAvaliacaoCerveja.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridHistoricoAvaliacaoCerveja.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridHistoricoAvaliacaoCerveja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHistoricoAvaliacaoCerveja.Size = new System.Drawing.Size(556, 173);
            this.gridHistoricoAvaliacaoCerveja.TabIndex = 9;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(193, 80);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "metroLabel3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(327, 290);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 143);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(514, 290);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(181, 143);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(701, 289);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(181, 143);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(808, 438);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 11;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseSelectable = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(641, 6);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(13, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = " ";
            // 
            // lbl_Npreco
            // 
            this.lbl_Npreco.AutoSize = true;
            this.lbl_Npreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.lbl_Npreco.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Npreco.ForeColor = System.Drawing.Color.Black;
            this.lbl_Npreco.Location = new System.Drawing.Point(403, 352);
            this.lbl_Npreco.Name = "lbl_Npreco";
            this.lbl_Npreco.Size = new System.Drawing.Size(18, 20);
            this.lbl_Npreco.TabIndex = 19;
            this.lbl_Npreco.Text = "1";
            // 
            // lbl_NLocal
            // 
            this.lbl_NLocal.AutoSize = true;
            this.lbl_NLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.lbl_NLocal.Font = new System.Drawing.Font("Open Sans", 11.25F);
            this.lbl_NLocal.ForeColor = System.Drawing.Color.Black;
            this.lbl_NLocal.Location = new System.Drawing.Point(592, 352);
            this.lbl_NLocal.Name = "lbl_NLocal";
            this.lbl_NLocal.Size = new System.Drawing.Size(18, 20);
            this.lbl_NLocal.TabIndex = 20;
            this.lbl_NLocal.Text = "2";
            // 
            // lbl_NTemperatura
            // 
            this.lbl_NTemperatura.AutoSize = true;
            this.lbl_NTemperatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.lbl_NTemperatura.Font = new System.Drawing.Font("Open Sans", 11.25F);
            this.lbl_NTemperatura.ForeColor = System.Drawing.Color.Black;
            this.lbl_NTemperatura.Location = new System.Drawing.Point(780, 352);
            this.lbl_NTemperatura.Name = "lbl_NTemperatura";
            this.lbl_NTemperatura.Size = new System.Drawing.Size(18, 20);
            this.lbl_NTemperatura.TabIndex = 21;
            this.lbl_NTemperatura.Text = "3";
            // 
            // telaAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 480);
            this.Controls.Add(this.lbl_NTemperatura);
            this.Controls.Add(this.lbl_NLocal);
            this.Controls.Add(this.lbl_Npreco);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaAvaliacao";
            this.Text = "Tela de Avaliação";
            this.Load += new System.EventHandler(this.Avaliacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoCerveja)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistoricoAvaliacaoCerveja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox FotoCerveja;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridHistoricoAvaliacaoCerveja;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroButton btn_avaliar;
        private MetroFramework.Controls.MetroButton btn_voltar;
        private MetroFramework.Controls.MetroLabel lbl_Lupulo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lbl_TeorAlcolico;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lbl_Preco;
        private MetroFramework.Controls.MetroLabel lb_NomeCerveja;
        private System.Windows.Forms.Label lbl_Npreco;
        private System.Windows.Forms.Label lbl_NLocal;
        private System.Windows.Forms.Label lbl_NTemperatura;
    }
}