namespace ComercialSys
{
    partial class FrmPedido
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
            Pedido = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            txtNomeCliente = new TextBox();
            txtIdCliente = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtVendedor = new TextBox();
            btnAbrirPedido = new Button();
            dataGridView1 = new DataGridView();
            btnFecharPedido = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox3 = new GroupBox();
            txtCodBarras = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtdescricao = new TextBox();
            label9 = new Label();
            txtValorUnit = new TextBox();
            label5 = new Label();
            txtQuantidade = new TextBox();
            btnInserir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // Pedido
            // 
            Pedido.AutoSize = true;
            Pedido.Location = new Point(267, 9);
            Pedido.Name = "Pedido";
            Pedido.Size = new Size(44, 15);
            Pedido.TabIndex = 0;
            Pedido.Text = "Pedido";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNomeCliente);
            groupBox1.Controls.Add(txtIdCliente);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(658, 96);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 20);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(197, 17);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(390, 23);
            txtNomeCliente.TabIndex = 3;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(30, 17);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(100, 23);
            txtIdCliente.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(694, 26);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(94, 50);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(642, 27);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Número";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 27);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 0;
            label4.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(155, 27);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.ReadOnly = true;
            txtVendedor.Size = new Size(366, 23);
            txtVendedor.TabIndex = 3;
            txtVendedor.TextChanged += txtVendedor_TextChanged;
            // 
            // btnAbrirPedido
            // 
            btnAbrirPedido.Location = new Point(587, 158);
            btnAbrirPedido.Name = "btnAbrirPedido";
            btnAbrirPedido.Size = new Size(83, 33);
            btnAbrirPedido.TabIndex = 4;
            btnAbrirPedido.Text = "&Abrir Pedido";
            btnAbrirPedido.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 312);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(658, 126);
            dataGridView1.TabIndex = 6;
            // 
            // btnFecharPedido
            // 
            btnFecharPedido.Location = new Point(688, 401);
            btnFecharPedido.Name = "btnFecharPedido";
            btnFecharPedido.Size = new Size(100, 37);
            btnFecharPedido.TabIndex = 7;
            btnFecharPedido.Text = "&Fechar Pedido";
            btnFecharPedido.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(688, 356);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 39);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(688, 327);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(688, 298);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtdescricao);
            groupBox3.Controls.Add(txtQuantidade);
            groupBox3.Controls.Add(txtValorUnit);
            groupBox3.Controls.Add(txtCodBarras);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(btnInserir);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(12, 197);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(658, 91);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Produto";
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(6, 37);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(100, 23);
            txtCodBarras.TabIndex = 5;
            txtCodBarras.TextChanged += textBox6_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(129, 19);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 8;
            label7.Text = "Descrição";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 19);
            label8.Name = "label8";
            label8.Size = new Size(97, 15);
            label8.TabIndex = 8;
            label8.Text = "Código de Barras";
            // 
            // txtdescricao
            // 
            txtdescricao.Location = new Point(112, 37);
            txtdescricao.Name = "txtdescricao";
            txtdescricao.Size = new Size(218, 23);
            txtdescricao.TabIndex = 5;
            txtdescricao.TextChanged += textBox6_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(348, 19);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 8;
            label9.Text = "Valor Unitário";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(336, 37);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(100, 23);
            txtValorUnit.TabIndex = 5;
            txtValorUnit.TextChanged += textBox6_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(472, 19);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 8;
            label5.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(442, 37);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 5;
            txtQuantidade.TextChanged += textBox6_TextChanged;
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserir.Location = new Point(559, 29);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(83, 33);
            btnInserir.TabIndex = 4;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(btnFecharPedido);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView1);
            Controls.Add(btnAbrirPedido);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(txtVendedor);
            Controls.Add(label4);
            Controls.Add(Pedido);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Pedido;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtNomeCliente;
        private TextBox txtIdCliente;
        private Label label4;
        private TextBox txtVendedor;
        private Button btnAbrirPedido;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button btnFecharPedido;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label6;
        private GroupBox groupBox3;
        private TextBox txtCodBarras;
        private Label label7;
        private Label label8;
        private TextBox txtdescricao;
        private Label label9;
        private TextBox txtValorUnit;
        private Label label5;
        private TextBox txtQuantidade;
        private Button btnInserir;
    }
}