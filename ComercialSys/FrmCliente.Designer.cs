namespace ComercialSys
{
    partial class FrmCliente
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
            dgvEnderecos = new DataGridView();
            clnCep = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnUf = new DataGridViewTextBoxColumn();
            clnTipoEndereco = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tbpDadosPessoais = new TabPage();
            txtClienteId = new TextBox();
            btnEditar = new Button();
            btnInsert = new Button();
            label4 = new Label();
            mxtCpf = new MaskedTextBox();
            mstTelefone = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblNome = new Label();
            chkAtivo = new CheckBox();
            dtpDataNasc = new DateTimePicker();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            tbpEnderecos = new TabPage();
            label6 = new Label();
            label13 = new Label();
            label12 = new Label();
            label14 = new Label();
            label11 = new Label();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            btnAdiciona = new Button();
            btnSalvar = new Button();
            cmbTipoEndereco = new ComboBox();
            txtUf = new TextBox();
            txtCidade = new TextBox();
            txtBairros = new TextBox();
            txtBairro = new TextBox();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            txtLogradouro = new TextBox();
            mxtCEP = new MaskedTextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            tabControl1.SuspendLayout();
            tbpDadosPessoais.SuspendLayout();
            tbpEnderecos.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEnderecos
            // 
            dgvEnderecos.AllowUserToAddRows = false;
            dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnderecos.Columns.AddRange(new DataGridViewColumn[] { clnCep, clnLogradouro, clnNumero, clnComplemento, clnBairro, clnCidade, clnUf, clnTipoEndereco });
            dgvEnderecos.Location = new Point(74, 244);
            dgvEnderecos.Name = "dgvEnderecos";
            dgvEnderecos.ReadOnly = true;
            dgvEnderecos.RowHeadersVisible = false;
            dgvEnderecos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEnderecos.Size = new Size(510, 125);
            dgvEnderecos.TabIndex = 3;
            // 
            // clnCep
            // 
            clnCep.Frozen = true;
            clnCep.HeaderText = "CEP";
            clnCep.Name = "clnCep";
            clnCep.ReadOnly = true;
            clnCep.Width = 60;
            // 
            // clnLogradouro
            // 
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            clnLogradouro.Width = 200;
            // 
            // clnNumero
            // 
            clnNumero.HeaderText = "Número";
            clnNumero.Name = "clnNumero";
            clnNumero.ReadOnly = true;
            clnNumero.Width = 60;
            // 
            // clnComplemento
            // 
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            // 
            // clnBairro
            // 
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            clnBairro.Width = 150;
            // 
            // clnCidade
            // 
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            clnCidade.Width = 150;
            // 
            // clnUf
            // 
            clnUf.HeaderText = "UF";
            clnUf.Name = "clnUf";
            clnUf.ReadOnly = true;
            clnUf.Width = 30;
            // 
            // clnTipoEndereco
            // 
            clnTipoEndereco.HeaderText = "Tipo";
            clnTipoEndereco.Name = "clnTipoEndereco";
            clnTipoEndereco.ReadOnly = true;
            clnTipoEndereco.Width = 60;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpDadosPessoais);
            tabControl1.Controls.Add(tbpEnderecos);
            tabControl1.Location = new Point(69, 13);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(515, 229);
            tabControl1.TabIndex = 2;
            // 
            // tbpDadosPessoais
            // 
            tbpDadosPessoais.Controls.Add(txtClienteId);
            tbpDadosPessoais.Controls.Add(btnEditar);
            tbpDadosPessoais.Controls.Add(btnInsert);
            tbpDadosPessoais.Controls.Add(label4);
            tbpDadosPessoais.Controls.Add(mxtCpf);
            tbpDadosPessoais.Controls.Add(mstTelefone);
            tbpDadosPessoais.Controls.Add(label3);
            tbpDadosPessoais.Controls.Add(label2);
            tbpDadosPessoais.Controls.Add(label1);
            tbpDadosPessoais.Controls.Add(lblNome);
            tbpDadosPessoais.Controls.Add(chkAtivo);
            tbpDadosPessoais.Controls.Add(dtpDataNasc);
            tbpDadosPessoais.Controls.Add(txtEmail);
            tbpDadosPessoais.Controls.Add(txtNome);
            tbpDadosPessoais.Location = new Point(4, 24);
            tbpDadosPessoais.Name = "tbpDadosPessoais";
            tbpDadosPessoais.Padding = new Padding(3);
            tbpDadosPessoais.Size = new Size(507, 201);
            tbpDadosPessoais.TabIndex = 0;
            tbpDadosPessoais.Text = "Dados pessoais";
            tbpDadosPessoais.UseVisualStyleBackColor = true;
            tbpDadosPessoais.Click += tbpDadosPessoais_Click;
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(309, 113);
            txtClienteId.Multiline = true;
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(100, 23);
            txtClienteId.TabIndex = 16;
            txtClienteId.Text = "0";
            txtClienteId.Visible = false;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(143, 162);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(25, 161);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 14;
            btnInsert.Text = "&Inserir";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 92);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 13;
            label4.Text = "Data de Nascimento";
            // 
            // mxtCpf
            // 
            mxtCpf.Location = new Point(24, 64);
            mxtCpf.Mask = "000.000.000-99";
            mxtCpf.Name = "mxtCpf";
            mxtCpf.Size = new Size(95, 23);
            mxtCpf.TabIndex = 12;
            // 
            // mstTelefone
            // 
            mstTelefone.Location = new Point(25, 110);
            mstTelefone.Mask = "(99) 00000-0000";
            mstTelefone.Name = "mstTelefone";
            mstTelefone.Size = new Size(100, 23);
            mstTelefone.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 92);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 10;
            label3.Text = "Telefone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 46);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 9;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 49);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 8;
            label1.Text = "CPF";
            label1.Click += label1_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(24, 5);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            lblNome.Click += lblNome_Click;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.FlatAppearance.BorderSize = 0;
            chkAtivo.Location = new Point(373, 29);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 6;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(150, 110);
            dtpDataNasc.MaxDate = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            dtpDataNasc.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(110, 23);
            dtpDataNasc.TabIndex = 5;
            dtpDataNasc.Value = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(134, 64);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(291, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(24, 23);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(320, 23);
            txtNome.TabIndex = 1;
            // 
            // tbpEnderecos
            // 
            tbpEnderecos.Controls.Add(label6);
            tbpEnderecos.Controls.Add(label13);
            tbpEnderecos.Controls.Add(label12);
            tbpEnderecos.Controls.Add(label14);
            tbpEnderecos.Controls.Add(label11);
            tbpEnderecos.Controls.Add(label9);
            tbpEnderecos.Controls.Add(label7);
            tbpEnderecos.Controls.Add(label5);
            tbpEnderecos.Controls.Add(btnAdiciona);
            tbpEnderecos.Controls.Add(btnSalvar);
            tbpEnderecos.Controls.Add(cmbTipoEndereco);
            tbpEnderecos.Controls.Add(txtUf);
            tbpEnderecos.Controls.Add(txtCidade);
            tbpEnderecos.Controls.Add(txtBairros);
            tbpEnderecos.Controls.Add(txtBairro);
            tbpEnderecos.Controls.Add(txtComplemento);
            tbpEnderecos.Controls.Add(txtNumero);
            tbpEnderecos.Controls.Add(txtLogradouro);
            tbpEnderecos.Controls.Add(mxtCEP);
            tbpEnderecos.Location = new Point(4, 24);
            tbpEnderecos.Name = "tbpEnderecos";
            tbpEnderecos.Padding = new Padding(3);
            tbpEnderecos.Size = new Size(507, 201);
            tbpEnderecos.TabIndex = 1;
            tbpEnderecos.Text = "Endereços";
            tbpEnderecos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 11);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 10;
            label6.Text = "CEP";
            label6.Click += label5_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(54, 109);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 10;
            label13.Text = "Tipo RES";
            label13.Click += label5_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(375, 60);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 10;
            label12.Text = "Cidade";
            label12.Click += label5_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(54, 60);
            label14.Name = "label14";
            label14.Size = new Size(84, 15);
            label14.TabIndex = 10;
            label14.Text = "Complemento";
            label14.Click += label5_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(221, 60);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 10;
            label11.Text = "Bairro";
            label11.Click += label5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(470, 60);
            label9.Name = "label9";
            label9.Size = new Size(21, 15);
            label9.TabIndex = 10;
            label9.Text = "UF";
            label9.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(391, 14);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 10;
            label7.Text = "Numero";
            label7.Click += label5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 11);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 10;
            label5.Text = "Logradouro";
            label5.Click += label5_Click;
            // 
            // btnAdiciona
            // 
            btnAdiciona.Location = new Point(330, 166);
            btnAdiciona.Name = "btnAdiciona";
            btnAdiciona.Size = new Size(161, 23);
            btnAdiciona.TabIndex = 9;
            btnAdiciona.Text = "Adicionar &Novo";
            btnAdiciona.UseVisualStyleBackColor = true;
            btnAdiciona.Click += btnAdiciona_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(23, 166);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // cmbTipoEndereco
            // 
            cmbTipoEndereco.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTipoEndereco.FormattingEnabled = true;
            cmbTipoEndereco.Items.AddRange(new object[] { "RES - Residencial", "COM - Comercial", "ENT - Entrega", "COB - Cobrança", "RET - Retirada", "TMP - Temporário" });
            cmbTipoEndereco.Location = new Point(21, 127);
            cmbTipoEndereco.Name = "cmbTipoEndereco";
            cmbTipoEndereco.Size = new Size(151, 24);
            cmbTipoEndereco.TabIndex = 7;
            cmbTipoEndereco.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(470, 78);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(21, 23);
            txtUf.TabIndex = 6;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(319, 78);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(145, 23);
            txtCidade.TabIndex = 5;
            // 
            // txtBairros
            // 
            txtBairros.Location = new Point(171, 78);
            txtBairros.Name = "txtBairros";
            txtBairros.Size = new Size(142, 23);
            txtBairros.TabIndex = 4;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(178, 78);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(120, 23);
            txtBairro.TabIndex = 4;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(19, 78);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(134, 23);
            txtComplemento.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(391, 32);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(104, 32);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(281, 23);
            txtLogradouro.TabIndex = 1;
            // 
            // mxtCEP
            // 
            mxtCEP.Location = new Point(19, 32);
            mxtCEP.Mask = "00000-999";
            mxtCEP.Name = "mxtCEP";
            mxtCEP.Size = new Size(79, 23);
            mxtCEP.TabIndex = 0;
            mxtCEP.MaskInputRejected += mxtCEP_MaskInputRejected;
            mxtCEP.Leave += mxtCEP_Leave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Controls.Add(dgvEnderecos);
            groupBox1.Location = new Point(81, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(676, 369);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
            tabControl1.ResumeLayout(false);
            tbpDadosPessoais.ResumeLayout(false);
            tbpDadosPessoais.PerformLayout();
            tbpEnderecos.ResumeLayout(false);
            tbpEnderecos.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEnderecos;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnUf;
        private DataGridViewTextBoxColumn clnTipoEndereco;
        private TabControl tabControl1;
        private TabPage tbpDadosPessoais;
        private Button btnEditar;
        private Button btnInsert;
        private Label label4;
        private MaskedTextBox mxtCpf;
        private MaskedTextBox mstTelefone;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblNome;
        private CheckBox chkAtivo;
        private DateTimePicker dtpDataNasc;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TabPage tbpEnderecos;
        private Button btnAdiciona;
        private Button btnSalvar;
        private ComboBox cmbTipoEndereco;
        private TextBox txtUf;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtComplemento;
        private TextBox txtNumero;
        private TextBox txtLogradouro;
        private MaskedTextBox mxtCEP;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label7;
        private TextBox txtBairros;
        private Label label13;
        private Label label12;
        private Label label14;
        private Label label11;
        private GroupBox groupBox1;
        private TextBox txtClienteId;
    }
}