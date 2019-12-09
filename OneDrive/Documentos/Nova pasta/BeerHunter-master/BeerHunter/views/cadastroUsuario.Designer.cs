using System;

namespace BeerHunter.views
{
    partial class Cadastro
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
        [Obsolete]
        private void InitializeComponent()
        {
            this.radioUsuario = new System.Windows.Forms.RadioButton();
            this.picBoxUsuario = new System.Windows.Forms.PictureBox();
            this.radioFornecedor = new System.Windows.Forms.RadioButton();
            this.picBoxFornecedor = new System.Windows.Forms.PictureBox();
            this.btnMetroSalvar = new MetroFramework.Controls.MetroButton();
            this.btnMetroVoltar = new MetroFramework.Controls.MetroButton();
            this.txt_NomeUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txt_Nome = new MetroFramework.Controls.MetroTextBox();
            this.txt_Senha = new MetroFramework.Controls.MetroTextBox();
            this.txt_Email = new MetroFramework.Controls.MetroTextBox();
            this.txt_Login = new MetroFramework.Controls.MetroTextBox();
            this.txt_SenhaFornecedor = new MetroFramework.Controls.MetroTextBox();
            this.txt_NomeFornecedor = new MetroFramework.Controls.MetroTextBox();
            this.txt_CEP = new MetroFramework.Controls.MetroTextBox();
            this.txt_Logradouro = new MetroFramework.Controls.MetroTextBox();
            this.txt_Bairro = new MetroFramework.Controls.MetroTextBox();
            this.txt_Numero = new MetroFramework.Controls.MetroTextBox();
            this.txt_Estado = new MetroFramework.Controls.MetroTextBox();
            this.txt_Localidade = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // radioUsuario
            // 
            this.radioUsuario.AutoSize = true;
            this.radioUsuario.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUsuario.Location = new System.Drawing.Point(34, 184);
            this.radioUsuario.Name = "radioUsuario";
            this.radioUsuario.Size = new System.Drawing.Size(65, 19);
            this.radioUsuario.TabIndex = 0;
            this.radioUsuario.Text = "Usuario";
            this.radioUsuario.UseVisualStyleBackColor = true;
            this.radioUsuario.CheckedChanged += new System.EventHandler(this.Usuario_CheckedChanged);
            // 
            // picBoxUsuario
            // 
            this.picBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxUsuario.Location = new System.Drawing.Point(23, 63);
            this.picBoxUsuario.Name = "picBoxUsuario";
            this.picBoxUsuario.Size = new System.Drawing.Size(100, 115);
            this.picBoxUsuario.TabIndex = 10;
            this.picBoxUsuario.TabStop = false;
            this.picBoxUsuario.Click += new System.EventHandler(this.picBoxUsuario_Click);
            // 
            // radioFornecedor
            // 
            this.radioFornecedor.AutoSize = true;
            this.radioFornecedor.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.radioFornecedor.Location = new System.Drawing.Point(27, 353);
            this.radioFornecedor.Name = "radioFornecedor";
            this.radioFornecedor.Size = new System.Drawing.Size(84, 19);
            this.radioFornecedor.TabIndex = 1;
            this.radioFornecedor.Text = "Fornecedor";
            this.radioFornecedor.UseVisualStyleBackColor = true;
            this.radioFornecedor.CheckedChanged += new System.EventHandler(this.RadioFornecedor_CheckedChanged);
            // 
            // picBoxFornecedor
            // 
            this.picBoxFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxFornecedor.Location = new System.Drawing.Point(23, 232);
            this.picBoxFornecedor.Name = "picBoxFornecedor";
            this.picBoxFornecedor.Size = new System.Drawing.Size(100, 115);
            this.picBoxFornecedor.TabIndex = 11;
            this.picBoxFornecedor.TabStop = false;
            this.picBoxFornecedor.Click += new System.EventHandler(this.picBoxFornecedor_Click);
            // 
            // btnMetroSalvar
            // 
            this.btnMetroSalvar.Location = new System.Drawing.Point(169, 470);
            this.btnMetroSalvar.Name = "btnMetroSalvar";
            this.btnMetroSalvar.Size = new System.Drawing.Size(113, 31);
            this.btnMetroSalvar.TabIndex = 33;
            this.btnMetroSalvar.Text = "SALVAR";
            this.btnMetroSalvar.UseSelectable = true;
            this.btnMetroSalvar.Click += new System.EventHandler(this.btnMetroSalvar_Click);
            // 
            // btnMetroVoltar
            // 
            this.btnMetroVoltar.Location = new System.Drawing.Point(321, 470);
            this.btnMetroVoltar.Name = "btnMetroVoltar";
            this.btnMetroVoltar.Size = new System.Drawing.Size(100, 31);
            this.btnMetroVoltar.TabIndex = 34;
            this.btnMetroVoltar.Text = "VOLTAR";
            this.btnMetroVoltar.UseSelectable = true;
            this.btnMetroVoltar.Click += new System.EventHandler(this.btnMetroVoltar_Click);
            // 
            // txt_NomeUsuario
            // 
            // 
            // 
            // 
            this.txt_NomeUsuario.CustomButton.Image = null;
            this.txt_NomeUsuario.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txt_NomeUsuario.CustomButton.Name = "";
            this.txt_NomeUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_NomeUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_NomeUsuario.CustomButton.TabIndex = 1;
            this.txt_NomeUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_NomeUsuario.CustomButton.UseSelectable = true;
            this.txt_NomeUsuario.CustomButton.Visible = false;
            this.txt_NomeUsuario.Lines = new string[0];
            this.txt_NomeUsuario.Location = new System.Drawing.Point(136, 81);
            this.txt_NomeUsuario.MaxLength = 32767;
            this.txt_NomeUsuario.Name = "txt_NomeUsuario";
            this.txt_NomeUsuario.PasswordChar = '\0';
            this.txt_NomeUsuario.PromptText = "Nome Usuario";
            this.txt_NomeUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_NomeUsuario.SelectedText = "";
            this.txt_NomeUsuario.SelectionLength = 0;
            this.txt_NomeUsuario.SelectionStart = 0;
            this.txt_NomeUsuario.ShortcutsEnabled = true;
            this.txt_NomeUsuario.Size = new System.Drawing.Size(128, 23);
            this.txt_NomeUsuario.TabIndex = 35;
            this.txt_NomeUsuario.UseSelectable = true;
            this.txt_NomeUsuario.WaterMark = "Nome Usuario";
            this.txt_NomeUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_NomeUsuario.WaterMarkFont = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeUsuario.Leave += new System.EventHandler(this.txt_NomeUsuario_Leave);
            // 
            // txt_Nome
            // 
            // 
            // 
            // 
            this.txt_Nome.CustomButton.Image = null;
            this.txt_Nome.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txt_Nome.CustomButton.Name = "";
            this.txt_Nome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Nome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Nome.CustomButton.TabIndex = 1;
            this.txt_Nome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Nome.CustomButton.UseSelectable = true;
            this.txt_Nome.CustomButton.Visible = false;
            this.txt_Nome.Lines = new string[0];
            this.txt_Nome.Location = new System.Drawing.Point(281, 81);
            this.txt_Nome.MaxLength = 32767;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.PasswordChar = '\0';
            this.txt_Nome.PromptText = "Nome";
            this.txt_Nome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Nome.SelectedText = "";
            this.txt_Nome.SelectionLength = 0;
            this.txt_Nome.SelectionStart = 0;
            this.txt_Nome.ShortcutsEnabled = true;
            this.txt_Nome.Size = new System.Drawing.Size(260, 23);
            this.txt_Nome.TabIndex = 36;
            this.txt_Nome.UseSelectable = true;
            this.txt_Nome.WaterMark = "Nome";
            this.txt_Nome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Nome.WaterMarkFont = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_Senha
            // 
            // 
            // 
            // 
            this.txt_Senha.CustomButton.Image = null;
            this.txt_Senha.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txt_Senha.CustomButton.Name = "";
            this.txt_Senha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Senha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Senha.CustomButton.TabIndex = 1;
            this.txt_Senha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Senha.CustomButton.UseSelectable = true;
            this.txt_Senha.CustomButton.Visible = false;
            this.txt_Senha.Lines = new string[0];
            this.txt_Senha.Location = new System.Drawing.Point(136, 123);
            this.txt_Senha.MaxLength = 32767;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '●';
            this.txt_Senha.PromptText = "Senha";
            this.txt_Senha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Senha.SelectedText = "";
            this.txt_Senha.SelectionLength = 0;
            this.txt_Senha.SelectionStart = 0;
            this.txt_Senha.ShortcutsEnabled = true;
            this.txt_Senha.Size = new System.Drawing.Size(128, 23);
            this.txt_Senha.TabIndex = 37;
            this.txt_Senha.UseSelectable = true;
            this.txt_Senha.UseSystemPasswordChar = true;
            this.txt_Senha.WaterMark = "Senha";
            this.txt_Senha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Senha.WaterMarkFont = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_Email
            // 
            // 
            // 
            // 
            this.txt_Email.CustomButton.Image = null;
            this.txt_Email.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txt_Email.CustomButton.Name = "";
            this.txt_Email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Email.CustomButton.TabIndex = 1;
            this.txt_Email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Email.CustomButton.UseSelectable = true;
            this.txt_Email.CustomButton.Visible = false;
            this.txt_Email.Lines = new string[0];
            this.txt_Email.Location = new System.Drawing.Point(281, 123);
            this.txt_Email.MaxLength = 32767;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.PromptText = "Email";
            this.txt_Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Email.SelectedText = "";
            this.txt_Email.SelectionLength = 0;
            this.txt_Email.SelectionStart = 0;
            this.txt_Email.ShortcutsEnabled = true;
            this.txt_Email.Size = new System.Drawing.Size(260, 23);
            this.txt_Email.TabIndex = 38;
            this.txt_Email.UseSelectable = true;
            this.txt_Email.WaterMark = "Email";
            this.txt_Email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Email.WaterMarkFont = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // txt_Login
            // 
            // 
            // 
            // 
            this.txt_Login.CustomButton.Image = null;
            this.txt_Login.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txt_Login.CustomButton.Name = "";
            this.txt_Login.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Login.CustomButton.TabIndex = 1;
            this.txt_Login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Login.CustomButton.UseSelectable = true;
            this.txt_Login.CustomButton.Visible = false;
            this.txt_Login.Lines = new string[0];
            this.txt_Login.Location = new System.Drawing.Point(136, 279);
            this.txt_Login.MaxLength = 32767;
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.PasswordChar = '\0';
            this.txt_Login.PromptText = "Nome Login";
            this.txt_Login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Login.SelectedText = "";
            this.txt_Login.SelectionLength = 0;
            this.txt_Login.SelectionStart = 0;
            this.txt_Login.ShortcutsEnabled = true;
            this.txt_Login.Size = new System.Drawing.Size(200, 23);
            this.txt_Login.TabIndex = 39;
            this.txt_Login.UseSelectable = true;
            this.txt_Login.WaterMark = "Nome Login";
            this.txt_Login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Login.WaterMarkFont = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Login.Leave += new System.EventHandler(this.txt_Login_Leave);
            // 
            // txt_SenhaFornecedor
            // 
            // 
            // 
            // 
            this.txt_SenhaFornecedor.CustomButton.Image = null;
            this.txt_SenhaFornecedor.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txt_SenhaFornecedor.CustomButton.Name = "";
            this.txt_SenhaFornecedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_SenhaFornecedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_SenhaFornecedor.CustomButton.TabIndex = 1;
            this.txt_SenhaFornecedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_SenhaFornecedor.CustomButton.UseSelectable = true;
            this.txt_SenhaFornecedor.CustomButton.Visible = false;
            this.txt_SenhaFornecedor.Lines = new string[0];
            this.txt_SenhaFornecedor.Location = new System.Drawing.Point(342, 279);
            this.txt_SenhaFornecedor.MaxLength = 32767;
            this.txt_SenhaFornecedor.Name = "txt_SenhaFornecedor";
            this.txt_SenhaFornecedor.PasswordChar = '●';
            this.txt_SenhaFornecedor.PromptText = "Senha";
            this.txt_SenhaFornecedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_SenhaFornecedor.SelectedText = "";
            this.txt_SenhaFornecedor.SelectionLength = 0;
            this.txt_SenhaFornecedor.SelectionStart = 0;
            this.txt_SenhaFornecedor.ShortcutsEnabled = true;
            this.txt_SenhaFornecedor.Size = new System.Drawing.Size(200, 23);
            this.txt_SenhaFornecedor.TabIndex = 40;
            this.txt_SenhaFornecedor.UseSelectable = true;
            this.txt_SenhaFornecedor.UseSystemPasswordChar = true;
            this.txt_SenhaFornecedor.WaterMark = "Senha";
            this.txt_SenhaFornecedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_SenhaFornecedor.WaterMarkFont = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_NomeFornecedor
            // 
            // 
            // 
            // 
            this.txt_NomeFornecedor.CustomButton.Image = null;
            this.txt_NomeFornecedor.CustomButton.Location = new System.Drawing.Point(384, 1);
            this.txt_NomeFornecedor.CustomButton.Name = "";
            this.txt_NomeFornecedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_NomeFornecedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_NomeFornecedor.CustomButton.TabIndex = 1;
            this.txt_NomeFornecedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_NomeFornecedor.CustomButton.UseSelectable = true;
            this.txt_NomeFornecedor.CustomButton.Visible = false;
            this.txt_NomeFornecedor.ForeColor = System.Drawing.Color.Black;
            this.txt_NomeFornecedor.Lines = new string[0];
            this.txt_NomeFornecedor.Location = new System.Drawing.Point(136, 250);
            this.txt_NomeFornecedor.MaxLength = 32767;
            this.txt_NomeFornecedor.Name = "txt_NomeFornecedor";
            this.txt_NomeFornecedor.PasswordChar = '\0';
            this.txt_NomeFornecedor.PromptText = "Nome Fornecedor";
            this.txt_NomeFornecedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_NomeFornecedor.SelectedText = "";
            this.txt_NomeFornecedor.SelectionLength = 0;
            this.txt_NomeFornecedor.SelectionStart = 0;
            this.txt_NomeFornecedor.ShortcutsEnabled = true;
            this.txt_NomeFornecedor.Size = new System.Drawing.Size(406, 23);
            this.txt_NomeFornecedor.TabIndex = 41;
            this.txt_NomeFornecedor.UseSelectable = true;
            this.txt_NomeFornecedor.WaterMark = "Nome Fornecedor";
            this.txt_NomeFornecedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_NomeFornecedor.WaterMarkFont = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_CEP
            // 
            // 
            // 
            // 
            this.txt_CEP.CustomButton.Image = null;
            this.txt_CEP.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txt_CEP.CustomButton.Name = "";
            this.txt_CEP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_CEP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_CEP.CustomButton.TabIndex = 1;
            this.txt_CEP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_CEP.CustomButton.UseSelectable = true;
            this.txt_CEP.CustomButton.Visible = false;
            this.txt_CEP.Lines = new string[0];
            this.txt_CEP.Location = new System.Drawing.Point(281, 324);
            this.txt_CEP.MaxLength = 32767;
            this.txt_CEP.Name = "txt_CEP";
            this.txt_CEP.PasswordChar = '\0';
            this.txt_CEP.PromptText = "CEP";
            this.txt_CEP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_CEP.SelectedText = "";
            this.txt_CEP.SelectionLength = 0;
            this.txt_CEP.SelectionStart = 0;
            this.txt_CEP.ShortcutsEnabled = true;
            this.txt_CEP.Size = new System.Drawing.Size(117, 23);
            this.txt_CEP.TabIndex = 42;
            this.txt_CEP.UseSelectable = true;
            this.txt_CEP.WaterMark = "CEP";
            this.txt_CEP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_CEP.WaterMarkFont = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CEP_KeyPress);
            this.txt_CEP.Leave += new System.EventHandler(this.txt_CEP_Leave);
            // 
            // txt_Logradouro
            // 
            // 
            // 
            // 
            this.txt_Logradouro.CustomButton.Image = null;
            this.txt_Logradouro.CustomButton.Location = new System.Drawing.Point(384, 1);
            this.txt_Logradouro.CustomButton.Name = "";
            this.txt_Logradouro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Logradouro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Logradouro.CustomButton.TabIndex = 1;
            this.txt_Logradouro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Logradouro.CustomButton.UseSelectable = true;
            this.txt_Logradouro.CustomButton.Visible = false;
            this.txt_Logradouro.Lines = new string[0];
            this.txt_Logradouro.Location = new System.Drawing.Point(135, 351);
            this.txt_Logradouro.MaxLength = 32767;
            this.txt_Logradouro.Name = "txt_Logradouro";
            this.txt_Logradouro.PasswordChar = '\0';
            this.txt_Logradouro.PromptText = "Endereco";
            this.txt_Logradouro.ReadOnly = true;
            this.txt_Logradouro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Logradouro.SelectedText = "";
            this.txt_Logradouro.SelectionLength = 0;
            this.txt_Logradouro.SelectionStart = 0;
            this.txt_Logradouro.ShortcutsEnabled = true;
            this.txt_Logradouro.Size = new System.Drawing.Size(406, 23);
            this.txt_Logradouro.TabIndex = 43;
            this.txt_Logradouro.UseSelectable = true;
            this.txt_Logradouro.WaterMark = "Endereco";
            this.txt_Logradouro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Logradouro.WaterMarkFont = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_Bairro
            // 
            // 
            // 
            // 
            this.txt_Bairro.CustomButton.Image = null;
            this.txt_Bairro.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txt_Bairro.CustomButton.Name = "";
            this.txt_Bairro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Bairro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Bairro.CustomButton.TabIndex = 1;
            this.txt_Bairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Bairro.CustomButton.UseSelectable = true;
            this.txt_Bairro.CustomButton.Visible = false;
            this.txt_Bairro.Lines = new string[0];
            this.txt_Bairro.Location = new System.Drawing.Point(135, 380);
            this.txt_Bairro.MaxLength = 32767;
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.PasswordChar = '\0';
            this.txt_Bairro.PromptText = "Bairro";
            this.txt_Bairro.ReadOnly = true;
            this.txt_Bairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Bairro.SelectedText = "";
            this.txt_Bairro.SelectionLength = 0;
            this.txt_Bairro.SelectionStart = 0;
            this.txt_Bairro.ShortcutsEnabled = true;
            this.txt_Bairro.Size = new System.Drawing.Size(263, 23);
            this.txt_Bairro.TabIndex = 44;
            this.txt_Bairro.UseSelectable = true;
            this.txt_Bairro.WaterMark = "Bairro";
            this.txt_Bairro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Bairro.WaterMarkFont = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_Numero
            // 
            // 
            // 
            // 
            this.txt_Numero.CustomButton.Image = null;
            this.txt_Numero.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txt_Numero.CustomButton.Name = "";
            this.txt_Numero.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Numero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Numero.CustomButton.TabIndex = 1;
            this.txt_Numero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Numero.CustomButton.UseSelectable = true;
            this.txt_Numero.CustomButton.Visible = false;
            this.txt_Numero.Lines = new string[0];
            this.txt_Numero.Location = new System.Drawing.Point(404, 380);
            this.txt_Numero.MaxLength = 32767;
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.PasswordChar = '\0';
            this.txt_Numero.PromptText = "Numero";
            this.txt_Numero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Numero.SelectedText = "";
            this.txt_Numero.SelectionLength = 0;
            this.txt_Numero.SelectionStart = 0;
            this.txt_Numero.ShortcutsEnabled = true;
            this.txt_Numero.Size = new System.Drawing.Size(137, 23);
            this.txt_Numero.TabIndex = 45;
            this.txt_Numero.UseSelectable = true;
            this.txt_Numero.WaterMark = "Numero";
            this.txt_Numero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Numero.WaterMarkFont = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_Estado
            // 
            // 
            // 
            // 
            this.txt_Estado.CustomButton.Image = null;
            this.txt_Estado.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txt_Estado.CustomButton.Name = "";
            this.txt_Estado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Estado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Estado.CustomButton.TabIndex = 1;
            this.txt_Estado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Estado.CustomButton.UseSelectable = true;
            this.txt_Estado.CustomButton.Visible = false;
            this.txt_Estado.Lines = new string[0];
            this.txt_Estado.Location = new System.Drawing.Point(135, 409);
            this.txt_Estado.MaxLength = 32767;
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.PasswordChar = '\0';
            this.txt_Estado.PromptText = "Estado";
            this.txt_Estado.ReadOnly = true;
            this.txt_Estado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Estado.SelectedText = "";
            this.txt_Estado.SelectionLength = 0;
            this.txt_Estado.SelectionStart = 0;
            this.txt_Estado.ShortcutsEnabled = true;
            this.txt_Estado.Size = new System.Drawing.Size(93, 23);
            this.txt_Estado.TabIndex = 46;
            this.txt_Estado.UseSelectable = true;
            this.txt_Estado.WaterMark = "Estado";
            this.txt_Estado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Estado.WaterMarkFont = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_Localidade
            // 
            // 
            // 
            // 
            this.txt_Localidade.CustomButton.Image = null;
            this.txt_Localidade.CustomButton.Location = new System.Drawing.Point(274, 1);
            this.txt_Localidade.CustomButton.Name = "";
            this.txt_Localidade.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Localidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Localidade.CustomButton.TabIndex = 1;
            this.txt_Localidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Localidade.CustomButton.UseSelectable = true;
            this.txt_Localidade.CustomButton.Visible = false;
            this.txt_Localidade.Lines = new string[0];
            this.txt_Localidade.Location = new System.Drawing.Point(245, 409);
            this.txt_Localidade.MaxLength = 32767;
            this.txt_Localidade.Name = "txt_Localidade";
            this.txt_Localidade.PasswordChar = '\0';
            this.txt_Localidade.PromptText = "Localidade";
            this.txt_Localidade.ReadOnly = true;
            this.txt_Localidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Localidade.SelectedText = "";
            this.txt_Localidade.SelectionLength = 0;
            this.txt_Localidade.SelectionStart = 0;
            this.txt_Localidade.ShortcutsEnabled = true;
            this.txt_Localidade.Size = new System.Drawing.Size(296, 23);
            this.txt_Localidade.TabIndex = 47;
            this.txt_Localidade.UseSelectable = true;
            this.txt_Localidade.WaterMark = "Localidade";
            this.txt_Localidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Localidade.WaterMarkFont = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 540);
            this.Controls.Add(this.txt_Localidade);
            this.Controls.Add(this.txt_Estado);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.txt_Bairro);
            this.Controls.Add(this.txt_Logradouro);
            this.Controls.Add(this.txt_CEP);
            this.Controls.Add(this.txt_NomeFornecedor);
            this.Controls.Add(this.txt_SenhaFornecedor);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_NomeUsuario);
            this.Controls.Add(this.btnMetroVoltar);
            this.Controls.Add(this.btnMetroSalvar);
            this.Controls.Add(this.picBoxFornecedor);
            this.Controls.Add(this.picBoxUsuario);
            this.Controls.Add(this.radioUsuario);
            this.Controls.Add(this.radioFornecedor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro";
            this.Text = "cadastro";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Orange;
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioUsuario;
        private System.Windows.Forms.PictureBox picBoxUsuario;
        private System.Windows.Forms.RadioButton radioFornecedor;
        private System.Windows.Forms.PictureBox picBoxFornecedor;
        private MetroFramework.Controls.MetroButton btnMetroSalvar;
        private MetroFramework.Controls.MetroButton btnMetroVoltar;
        private MetroFramework.Controls.MetroTextBox txt_NomeUsuario;
        private MetroFramework.Controls.MetroTextBox txt_Nome;
        private MetroFramework.Controls.MetroTextBox txt_Senha;
        private MetroFramework.Controls.MetroTextBox txt_Email;
        private MetroFramework.Controls.MetroTextBox txt_Login;
        private MetroFramework.Controls.MetroTextBox txt_SenhaFornecedor;
        private MetroFramework.Controls.MetroTextBox txt_NomeFornecedor;
        private MetroFramework.Controls.MetroTextBox txt_CEP;
        private MetroFramework.Controls.MetroTextBox txt_Logradouro;
        private MetroFramework.Controls.MetroTextBox txt_Bairro;
        private MetroFramework.Controls.MetroTextBox txt_Numero;
        private MetroFramework.Controls.MetroTextBox txt_Estado;
        private MetroFramework.Controls.MetroTextBox txt_Localidade;
    }
}