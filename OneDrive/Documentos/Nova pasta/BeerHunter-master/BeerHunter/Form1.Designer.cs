namespace BeerHunter
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.radioFornecedor = new System.Windows.Forms.RadioButton();
            this.radioUsuario = new System.Windows.Forms.RadioButton();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.btnCadastro = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtNome_usuario = new MetroFramework.Controls.MetroTextBox();
            this.txt_Senha = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioFornecedor
            // 
            this.radioFornecedor.AutoSize = true;
            this.radioFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.radioFornecedor.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radioFornecedor.ForeColor = System.Drawing.Color.White;
            this.radioFornecedor.Location = new System.Drawing.Point(260, 220);
            this.radioFornecedor.Name = "radioFornecedor";
            this.radioFornecedor.Size = new System.Drawing.Size(124, 24);
            this.radioFornecedor.TabIndex = 8;
            this.radioFornecedor.Text = "Fornecedor";
            this.radioFornecedor.UseVisualStyleBackColor = false;
            // 
            // radioUsuario
            // 
            this.radioUsuario.AutoSize = true;
            this.radioUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.radioUsuario.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUsuario.ForeColor = System.Drawing.Color.White;
            this.radioUsuario.Location = new System.Drawing.Point(72, 220);
            this.radioUsuario.Name = "radioUsuario";
            this.radioUsuario.Size = new System.Drawing.Size(94, 24);
            this.radioUsuario.TabIndex = 7;
            this.radioUsuario.Text = "Usuario";
            this.radioUsuario.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(149, 369);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(151, 25);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.Location = new System.Drawing.Point(149, 400);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(151, 36);
            this.btnCadastro.TabIndex = 10;
            this.btnCadastro.Text = "CADASTRAR-SE";
            this.btnCadastro.UseSelectable = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(191, 456);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "sair";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtNome_usuario
            // 
            // 
            // 
            // 
            this.txtNome_usuario.CustomButton.Image = null;
            this.txtNome_usuario.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txtNome_usuario.CustomButton.Name = "";
            this.txtNome_usuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome_usuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome_usuario.CustomButton.TabIndex = 1;
            this.txtNome_usuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome_usuario.CustomButton.UseSelectable = true;
            this.txtNome_usuario.CustomButton.Visible = false;
            this.txtNome_usuario.Lines = new string[0];
            this.txtNome_usuario.Location = new System.Drawing.Point(117, 277);
            this.txtNome_usuario.MaxLength = 32767;
            this.txtNome_usuario.Name = "txtNome_usuario";
            this.txtNome_usuario.PasswordChar = '\0';
            this.txtNome_usuario.PromptText = "digite o usuario.....";
            this.txtNome_usuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome_usuario.SelectedText = "";
            this.txtNome_usuario.SelectionLength = 0;
            this.txtNome_usuario.SelectionStart = 0;
            this.txtNome_usuario.ShortcutsEnabled = true;
            this.txtNome_usuario.Size = new System.Drawing.Size(217, 23);
            this.txtNome_usuario.TabIndex = 12;
            this.txtNome_usuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome_usuario.UseCustomBackColor = true;
            this.txtNome_usuario.UseCustomForeColor = true;
            this.txtNome_usuario.UseSelectable = true;
            this.txtNome_usuario.UseStyleColors = true;
            this.txtNome_usuario.WaterMark = "digite o usuario.....";
            this.txtNome_usuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome_usuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Senha
            // 
            // 
            // 
            // 
            this.txt_Senha.CustomButton.Image = null;
            this.txt_Senha.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txt_Senha.CustomButton.Name = "";
            this.txt_Senha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Senha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Senha.CustomButton.TabIndex = 1;
            this.txt_Senha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Senha.CustomButton.UseSelectable = true;
            this.txt_Senha.CustomButton.Visible = false;
            this.txt_Senha.Lines = new string[0];
            this.txt_Senha.Location = new System.Drawing.Point(117, 325);
            this.txt_Senha.MaxLength = 32767;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '●';
            this.txt_Senha.PromptText = "digite a senha....";
            this.txt_Senha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Senha.SelectedText = "";
            this.txt_Senha.SelectionLength = 0;
            this.txt_Senha.SelectionStart = 0;
            this.txt_Senha.ShortcutsEnabled = true;
            this.txt_Senha.Size = new System.Drawing.Size(217, 23);
            this.txt_Senha.TabIndex = 13;
            this.txt_Senha.UseSelectable = true;
            this.txt_Senha.UseStyleColors = true;
            this.txt_Senha.UseSystemPasswordChar = true;
            this.txt_Senha.WaterMark = "digite a senha....";
            this.txt_Senha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Senha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BeerHunter.Properties.Resources.WhatsApp_Image_2019_12_06_at_19_00_19;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.txtNome_usuario);
            this.panel1.Controls.Add(this.txt_Senha);
            this.panel1.Controls.Add(this.btnCadastro);
            this.panel1.Controls.Add(this.radioUsuario);
            this.panel1.Controls.Add(this.radioFornecedor);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Location = new System.Drawing.Point(-1, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 515);
            this.panel1.TabIndex = 14;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 506);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioFornecedor;
        private System.Windows.Forms.RadioButton radioUsuario;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroButton btnCadastro;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtNome_usuario;
        private MetroFramework.Controls.MetroTextBox txt_Senha;
        private System.Windows.Forms.Panel panel1;
    }
}

