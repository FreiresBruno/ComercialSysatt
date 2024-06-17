namespace ComercialSys
{
    partial class FrmProduto
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
            txtCategoria = new TextBox();
            txtDescricao = new TextBox();
            txtClasseDesconto = new TextBox();
            mskCodigo = new MaskedTextBox();
            mskValor = new MaskedTextBox();
            cmbUnidedeVendas = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnInserir = new Button();
            txtEstoqueMinimo = new TextBox();
            label7 = new Label();
            btnEditar = new Button();
            label8 = new Label();
            txtId = new TextBox();
            btnConsultarPorId = new Button();
            dgvProdutos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCodigoDeBarras = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnvalor = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewCheckBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnEstoque = new DataGridViewTextBoxColumn();
            clnClasseDesconto = new DataGridViewTextBoxColumn();
            txtdataCad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(288, 148);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(190, 23);
            txtCategoria.TabIndex = 5;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(288, 61);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(190, 23);
            txtDescricao.TabIndex = 2;
            // 
            // txtClasseDesconto
            // 
            txtClasseDesconto.Location = new Point(288, 206);
            txtClasseDesconto.Name = "txtClasseDesconto";
            txtClasseDesconto.Size = new Size(190, 23);
            txtClasseDesconto.TabIndex = 7;
            // 
            // mskCodigo
            // 
            mskCodigo.Location = new Point(288, 32);
            mskCodigo.Mask = "0 000000 000000";
            mskCodigo.Name = "mskCodigo";
            mskCodigo.Size = new Size(190, 23);
            mskCodigo.TabIndex = 1;
            // 
            // mskValor
            // 
            mskValor.Location = new Point(288, 90);
            mskValor.Name = "mskValor";
            mskValor.Size = new Size(190, 23);
            mskValor.TabIndex = 3;
            // 
            // cmbUnidedeVendas
            // 
            cmbUnidedeVendas.FormattingEnabled = true;
            cmbUnidedeVendas.Items.AddRange(new object[] { "1 - METRO", "2 - UNIDADE", "3 - QUILOGRAMA", "4 - LITRO", "5 - CAIXA ", "6 - MILILITRO", "7 - PEÇA ", "8 - FARDO", "9 - FRASCO", "10 - PACOTE", "11 - GRAMA" });
            cmbUnidedeVendas.Location = new Point(288, 119);
            cmbUnidedeVendas.Name = "cmbUnidedeVendas";
            cmbUnidedeVendas.Size = new Size(190, 23);
            cmbUnidedeVendas.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 35);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 15;
            label1.Text = "Código de barras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 69);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 14;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 93);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 13;
            label3.Text = "Valor unitário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 127);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 12;
            label4.Text = "Unidade de venda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 151);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 11;
            label5.Text = "Categoria ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(188, 180);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 10;
            label6.Text = "Estoque minimo";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(185, 240);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(94, 30);
            btnInserir.TabIndex = 8;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // txtEstoqueMinimo
            // 
            txtEstoqueMinimo.Location = new Point(288, 177);
            txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            txtEstoqueMinimo.Size = new Size(190, 23);
            txtEstoqueMinimo.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(173, 209);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 9;
            label7.Text = "Classe de Desconto";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(312, 240);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(97, 30);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(244, 6);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 16;
            label8.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(288, 3);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(61, 23);
            txtId.TabIndex = 18;
            // 
            // btnConsultarPorId
            // 
            btnConsultarPorId.Location = new Point(443, 240);
            btnConsultarPorId.Name = "btnConsultarPorId";
            btnConsultarPorId.Size = new Size(96, 30);
            btnConsultarPorId.TabIndex = 19;
            btnConsultarPorId.Text = "&Consultar";
            btnConsultarPorId.UseVisualStyleBackColor = true;
            btnConsultarPorId.Click += btnConsultarPorId_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodigoDeBarras, clnDescricao, clnvalor, clnUnidadeVenda, clnCategoria, clnEstoque, clnClasseDesconto });
            dgvProdutos.Location = new Point(3, 298);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(785, 150);
            dgvProdutos.TabIndex = 20;
            dgvProdutos.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // clnCodigoDeBarras
            // 
            clnCodigoDeBarras.Frozen = true;
            clnCodigoDeBarras.HeaderText = "Codigo de Barras";
            clnCodigoDeBarras.Name = "clnCodigoDeBarras";
            clnCodigoDeBarras.ReadOnly = true;
            clnCodigoDeBarras.Width = 120;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descricao";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 120;
            // 
            // clnvalor
            // 
            clnvalor.Frozen = true;
            clnvalor.HeaderText = "Valor";
            clnvalor.Name = "clnvalor";
            clnvalor.ReadOnly = true;
            clnvalor.Width = 60;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.Frozen = true;
            clnUnidadeVenda.HeaderText = "Unidade de Venda";
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            clnUnidadeVenda.Width = 110;
            // 
            // clnCategoria
            // 
            clnCategoria.Frozen = true;
            clnCategoria.HeaderText = "Categoria Id";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            clnCategoria.Width = 110;
            // 
            // clnEstoque
            // 
            clnEstoque.HeaderText = "Estoque minimo";
            clnEstoque.Name = "clnEstoque";
            clnEstoque.ReadOnly = true;
            clnEstoque.Width = 130;
            // 
            // clnClasseDesconto
            // 
            clnClasseDesconto.HeaderText = "Desconto";
            clnClasseDesconto.Name = "clnClasseDesconto";
            clnClasseDesconto.ReadOnly = true;
            clnClasseDesconto.Width = 90;
            // 
            // txtdataCad
            // 
            txtdataCad.Location = new Point(469, -2);
            txtdataCad.Multiline = true;
            txtdataCad.Name = "txtdataCad";
            txtdataCad.Size = new Size(100, 23);
            txtdataCad.TabIndex = 21;
            txtdataCad.Text = "0";
            txtdataCad.Visible = false;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtdataCad);
            Controls.Add(dgvProdutos);
            Controls.Add(btnConsultarPorId);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(btnEditar);
            Controls.Add(label7);
            Controls.Add(txtEstoqueMinimo);
            Controls.Add(btnInserir);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbUnidedeVendas);
            Controls.Add(mskValor);
            Controls.Add(mskCodigo);
            Controls.Add(txtDescricao);
            Controls.Add(txtClasseDesconto);
            Controls.Add(txtCategoria);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCategoria;
        private TextBox txtDescricao;
        private TextBox txtClasseDesconto;
        private MaskedTextBox mskCodigo;
        private MaskedTextBox mskValor;
        private ComboBox cmbUnidedeVendas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnInserir;
        private TextBox txtEstoqueMinimo;
        private Label label7;
        private Button btnEditar;
        private Label label8;
        private TextBox txtId;
        private Button btnConsultarPorId;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodigoDeBarras;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnvalor;
        private DataGridViewCheckBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoque;
        private DataGridViewTextBoxColumn clnClasseDesconto;
        private TextBox txtdataCad;
    }
}