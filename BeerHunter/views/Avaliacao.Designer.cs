namespace BeerHunter.views
{
    partial class Avaliacao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTeorAlcolico = new System.Windows.Forms.Label();
            this.lblLupulo = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lbNomeCerveja = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTeorAlcolico);
            this.groupBox1.Controls.Add(this.lblLupulo);
            this.groupBox1.Controls.Add(this.lblPreco);
            this.groupBox1.Controls.Add(this.lbNomeCerveja);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblTeorAlcolico
            // 
            this.lblTeorAlcolico.AutoSize = true;
            this.lblTeorAlcolico.Location = new System.Drawing.Point(17, 328);
            this.lblTeorAlcolico.Name = "lblTeorAlcolico";
            this.lblTeorAlcolico.Size = new System.Drawing.Size(35, 13);
            this.lblTeorAlcolico.TabIndex = 4;
            this.lblTeorAlcolico.Text = "label4";
            // 
            // lblLupulo
            // 
            this.lblLupulo.AutoSize = true;
            this.lblLupulo.Location = new System.Drawing.Point(17, 352);
            this.lblLupulo.Name = "lblLupulo";
            this.lblLupulo.Size = new System.Drawing.Size(35, 13);
            this.lblLupulo.TabIndex = 3;
            this.lblLupulo.Text = "label3";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(17, 305);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "label2";
            // 
            // lbNomeCerveja
            // 
            this.lbNomeCerveja.AutoSize = true;
            this.lbNomeCerveja.Location = new System.Drawing.Point(98, 16);
            this.lbNomeCerveja.Name = "lbNomeCerveja";
            this.lbNomeCerveja.Size = new System.Drawing.Size(74, 13);
            this.lbNomeCerveja.TabIndex = 1;
            this.lbNomeCerveja.Text = "Nome Cerveja";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(48, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 242);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(321, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Avaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 429);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Avaliacao";
            this.Text = "Avaliacao";
            this.Load += new System.EventHandler(this.Avaliacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTeorAlcolico;
        private System.Windows.Forms.Label lblLupulo;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lbNomeCerveja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}