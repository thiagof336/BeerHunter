namespace BeerHunter.views
{
    partial class BuscaDeCervejaUsuario
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
            this.SeletorBusca = new System.Windows.Forms.ComboBox();
            this.textBusca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstViewCerveja = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // SeletorBusca
            // 
            this.SeletorBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeletorBusca.FormattingEnabled = true;
            this.SeletorBusca.Items.AddRange(new object[] {
            "Nome",
            "Fabricante",
            "Teor Alcolico",
            "Lupulo",
            "Preco",
            "Tipo"});
            this.SeletorBusca.Location = new System.Drawing.Point(12, 98);
            this.SeletorBusca.Name = "SeletorBusca";
            this.SeletorBusca.Size = new System.Drawing.Size(125, 21);
            this.SeletorBusca.TabIndex = 0;
            // 
            // textBusca
            // 
            this.textBusca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBusca.Location = new System.Drawing.Point(147, 99);
            this.textBusca.Name = "textBusca";
            this.textBusca.Size = new System.Drawing.Size(438, 20);
            this.textBusca.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(324, 125);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seletor";
            // 
            // lstViewCerveja
            // 
            this.lstViewCerveja.HideSelection = false;
            this.lstViewCerveja.Location = new System.Drawing.Point(12, 174);
            this.lstViewCerveja.Name = "lstViewCerveja";
            this.lstViewCerveja.Size = new System.Drawing.Size(573, 200);
            this.lstViewCerveja.TabIndex = 5;
            this.lstViewCerveja.UseCompatibleStateImageBehavior = false;
            this.lstViewCerveja.Visible = false;
            // 
            // BuscaDeCervejaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 428);
            this.Controls.Add(this.lstViewCerveja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBusca);
            this.Controls.Add(this.SeletorBusca);
            this.Name = "BuscaDeCervejaUsuario";
            this.Text = "BuscaDeCervejaUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SeletorBusca;
        private System.Windows.Forms.TextBox textBusca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstViewCerveja;
    }
}