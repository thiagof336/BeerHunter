namespace BeerHunter.views
{
    partial class RealizarAvaliacao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNomeUsuario = new MetroFramework.Controls.MetroLabel();
            this.FotoUsuario = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNomeCerveja = new MetroFramework.Controls.MetroLabel();
            this.lblNotaPreco = new System.Windows.Forms.Label();
            this.lblNotaLocal = new System.Windows.Forms.Label();
            this.lblNotaTemperatura = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.RichTextBox();
            this.txtNotaTemperatura = new System.Windows.Forms.TextBox();
            this.txtNotaLocal = new System.Windows.Forms.TextBox();
            this.txtNotaPreco = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DataGridHistorico = new System.Windows.Forms.DataGridView();
            this.btn_Salvar = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoUsuario)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNomeUsuario);
            this.groupBox1.Controls.Add(this.FotoUsuario);
            this.groupBox1.Location = new System.Drawing.Point(11, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Usuario";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(191, 32);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(81, 19);
            this.lblNomeUsuario.TabIndex = 2;
            this.lblNomeUsuario.Text = "metroLabel1";
            // 
            // FotoUsuario
            // 
            this.FotoUsuario.Location = new System.Drawing.Point(6, 19);
            this.FotoUsuario.Name = "FotoUsuario";
            this.FotoUsuario.Size = new System.Drawing.Size(118, 133);
            this.FotoUsuario.TabIndex = 0;
            this.FotoUsuario.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNomeCerveja);
            this.groupBox2.Controls.Add(this.lblNotaPreco);
            this.groupBox2.Controls.Add(this.lblNotaLocal);
            this.groupBox2.Controls.Add(this.lblNotaTemperatura);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtComentario);
            this.groupBox2.Controls.Add(this.txtNotaTemperatura);
            this.groupBox2.Controls.Add(this.txtNotaLocal);
            this.groupBox2.Controls.Add(this.txtNotaPreco);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(6, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Avaliar Cerveja";
            // 
            // lblNomeCerveja
            // 
            this.lblNomeCerveja.AutoSize = true;
            this.lblNomeCerveja.Location = new System.Drawing.Point(135, 16);
            this.lblNomeCerveja.Name = "lblNomeCerveja";
            this.lblNomeCerveja.Size = new System.Drawing.Size(81, 19);
            this.lblNomeCerveja.TabIndex = 3;
            this.lblNomeCerveja.Text = "metroLabel1";
            // 
            // lblNotaPreco
            // 
            this.lblNotaPreco.AutoSize = true;
            this.lblNotaPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.lblNotaPreco.Location = new System.Drawing.Point(36, 87);
            this.lblNotaPreco.Name = "lblNotaPreco";
            this.lblNotaPreco.Size = new System.Drawing.Size(35, 13);
            this.lblNotaPreco.TabIndex = 11;
            this.lblNotaPreco.Text = "label5";
            // 
            // lblNotaLocal
            // 
            this.lblNotaLocal.AutoSize = true;
            this.lblNotaLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.lblNotaLocal.Location = new System.Drawing.Point(160, 87);
            this.lblNotaLocal.Name = "lblNotaLocal";
            this.lblNotaLocal.Size = new System.Drawing.Size(35, 13);
            this.lblNotaLocal.TabIndex = 10;
            this.lblNotaLocal.Text = "label4";
            // 
            // lblNotaTemperatura
            // 
            this.lblNotaTemperatura.AutoSize = true;
            this.lblNotaTemperatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.lblNotaTemperatura.Location = new System.Drawing.Point(286, 87);
            this.lblNotaTemperatura.Name = "lblNotaTemperatura";
            this.lblNotaTemperatura.Size = new System.Drawing.Size(35, 13);
            this.lblNotaTemperatura.TabIndex = 9;
            this.lblNotaTemperatura.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(450, 49);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(221, 70);
            this.txtComentario.TabIndex = 7;
            this.txtComentario.Text = "";
            // 
            // txtNotaTemperatura
            // 
            this.txtNotaTemperatura.Location = new System.Drawing.Point(266, 143);
            this.txtNotaTemperatura.Name = "txtNotaTemperatura";
            this.txtNotaTemperatura.Size = new System.Drawing.Size(54, 20);
            this.txtNotaTemperatura.TabIndex = 5;
            // 
            // txtNotaLocal
            // 
            this.txtNotaLocal.Location = new System.Drawing.Point(146, 143);
            this.txtNotaLocal.Name = "txtNotaLocal";
            this.txtNotaLocal.Size = new System.Drawing.Size(54, 20);
            this.txtNotaLocal.TabIndex = 4;
            // 
            // txtNotaPreco
            // 
            this.txtNotaPreco.Location = new System.Drawing.Point(25, 143);
            this.txtNotaPreco.Name = "txtNotaPreco";
            this.txtNotaPreco.Size = new System.Drawing.Size(54, 20);
            this.txtNotaPreco.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(246, 49);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 88);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(125, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 88);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(5, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 88);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DataGridHistorico);
            this.groupBox3.Location = new System.Drawing.Point(318, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 188);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Historico de Buscas";
            // 
            // DataGridHistorico
            // 
            this.DataGridHistorico.BackgroundColor = System.Drawing.Color.White;
            this.DataGridHistorico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridHistorico.Location = new System.Drawing.Point(10, 19);
            this.DataGridHistorico.Name = "DataGridHistorico";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridHistorico.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridHistorico.RowHeadersVisible = false;
            this.DataGridHistorico.Size = new System.Drawing.Size(365, 158);
            this.DataGridHistorico.TabIndex = 9;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(544, 480);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(149, 39);
            this.btn_Salvar.TabIndex = 12;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseSelectable = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(413, 480);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(103, 39);
            this.metroButton2.TabIndex = 13;
            this.metroButton2.Text = "Voltar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // RealizarAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 537);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RealizarAvaliacao";
            this.Text = "Realizar Avaliação";
            this.Load += new System.EventHandler(this.RealizarAvaliacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoUsuario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox FotoUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNotaTemperatura;
        private System.Windows.Forms.TextBox txtNotaLocal;
        private System.Windows.Forms.TextBox txtNotaPreco;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNotaPreco;
        private System.Windows.Forms.Label lblNotaLocal;
        private System.Windows.Forms.Label lblNotaTemperatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtComentario;
        private System.Windows.Forms.DataGridView DataGridHistorico;
        private MetroFramework.Controls.MetroLabel lblNomeUsuario;
        private MetroFramework.Controls.MetroLabel lblNomeCerveja;
        private MetroFramework.Controls.MetroButton btn_Salvar;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}