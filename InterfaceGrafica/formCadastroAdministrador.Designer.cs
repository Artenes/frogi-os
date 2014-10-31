namespace FROGI_OS.InterfaceGrafica {
    partial class formCadastroAdministrador {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textNome = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(29, 100);
            this.textNome.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textNome.MaxLength = 60;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(406, 34);
            this.textNome.TabIndex = 0;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(29, 184);
            this.textSenha.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textSenha.MaxLength = 10;
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(406, 34);
            this.textSenha.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNome.Location = new System.Drawing.Point(29, 66);
            this.labelNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(63, 28);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSenha.Location = new System.Drawing.Point(29, 150);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(64, 28);
            this.labelSenha.TabIndex = 3;
            this.labelSenha.Text = "Senha";
            // 
            // buttonSair
            // 
            this.buttonSair.AutoSize = true;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSair.Location = new System.Drawing.Point(345, 227);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(90, 40);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.AutoSize = true;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSalvar.Location = new System.Drawing.Point(246, 227);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(83, 40);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cadastre um administrador";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStatus.Location = new System.Drawing.Point(29, 239);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 28);
            this.labelStatus.TabIndex = 7;
            // 
            // formCadastroAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(468, 294);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textNome);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "formCadastroAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formCadastroAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
    }
}