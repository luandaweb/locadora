
namespace LocadoraFilmes
{
    partial class TelaInicial
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.btnTelaCadastro = new System.Windows.Forms.Button();
            this.btnTelaLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTelaCadastro
            // 
            this.btnTelaCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(101)))), ((int)(((byte)(246)))));
            this.btnTelaCadastro.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaCadastro.ForeColor = System.Drawing.Color.White;
            this.btnTelaCadastro.Location = new System.Drawing.Point(365, 164);
            this.btnTelaCadastro.Name = "btnTelaCadastro";
            this.btnTelaCadastro.Size = new System.Drawing.Size(125, 45);
            this.btnTelaCadastro.TabIndex = 0;
            this.btnTelaCadastro.Text = "Cadastro";
            this.btnTelaCadastro.UseVisualStyleBackColor = false;
            this.btnTelaCadastro.Click += new System.EventHandler(this.btnTelaCadastro_Click);
            // 
            // btnTelaLogin
            // 
            this.btnTelaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(101)))), ((int)(((byte)(246)))));
            this.btnTelaLogin.Font = new System.Drawing.Font("Bahnschrift", 15.75F);
            this.btnTelaLogin.ForeColor = System.Drawing.Color.White;
            this.btnTelaLogin.Location = new System.Drawing.Point(149, 164);
            this.btnTelaLogin.Name = "btnTelaLogin";
            this.btnTelaLogin.Size = new System.Drawing.Size(125, 45);
            this.btnTelaLogin.TabIndex = 1;
            this.btnTelaLogin.Text = "Login";
            this.btnTelaLogin.UseVisualStyleBackColor = false;
            this.btnTelaLogin.Click += new System.EventHandler(this.btnTelaLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bem vindo(a) a Luanda Locadora!";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(666, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTelaLogin);
            this.Controls.Add(this.btnTelaCadastro);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaInicial";
            this.Text = "Luanda Locadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTelaCadastro;
        private System.Windows.Forms.Button btnTelaLogin;
        private System.Windows.Forms.Label label1;
    }
}

