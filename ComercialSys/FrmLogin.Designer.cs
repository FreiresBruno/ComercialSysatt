namespace ComercialSys
{
    partial class FrmLogin
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
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 58);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 110);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Senha";
            label2.Click += label1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(129, 76);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(348, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(129, 128);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(348, 23);
            txtSenha.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(129, 171);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(106, 23);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(371, 171);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button1_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}