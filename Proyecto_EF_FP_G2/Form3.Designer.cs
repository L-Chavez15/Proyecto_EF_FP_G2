namespace Proyecto_EF_FP_G2
{
    partial class Form3
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            btnRegistrarProductos = new Button();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtNombreP = new TextBox();
            txtCodigo = new TextBox();
            cbbCategoria = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnRegistrarProductos);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtNombreP);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(cbbCategoria);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 305);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 223);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 29;
            label1.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 19);
            label2.Name = "label2";
            label2.Size = new Size(174, 21);
            label2.TabIndex = 28;
            label2.Text = "Registro de Productos";
            // 
            // btnRegistrarProductos
            // 
            btnRegistrarProductos.BackColor = SystemColors.GradientActiveCaption;
            btnRegistrarProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarProductos.Location = new Point(80, 262);
            btnRegistrarProductos.Name = "btnRegistrarProductos";
            btnRegistrarProductos.Size = new Size(166, 33);
            btnRegistrarProductos.TabIndex = 18;
            btnRegistrarProductos.Text = "REGISTRAR";
            btnRegistrarProductos.UseVisualStyleBackColor = false;
            btnRegistrarProductos.Click += btnRegistrarProductos_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(100, 220);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(107, 23);
            txtStock.TabIndex = 19;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(100, 181);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(107, 23);
            txtPrecio.TabIndex = 20;
            // 
            // txtNombreP
            // 
            txtNombreP.Location = new Point(100, 104);
            txtNombreP.Name = "txtNombreP";
            txtNombreP.Size = new Size(166, 23);
            txtNombreP.TabIndex = 21;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(100, 61);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(146, 23);
            txtCodigo.TabIndex = 22;
            // 
            // cbbCategoria
            // 
            cbbCategoria.FormattingEnabled = true;
            cbbCategoria.Items.AddRange(new object[] { "Electrónica", "Hogar", "Alimentos", "Limpieza" });
            cbbCategoria.Location = new Point(100, 142);
            cbbCategoria.Name = "cbbCategoria";
            cbbCategoria.Size = new Size(166, 23);
            cbbCategoria.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 145);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 26;
            label9.Text = "Categoría";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 184);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 25;
            label10.Text = "Precio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 107);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 24;
            label8.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 64);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 23;
            label7.Text = "Código";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 326);
            Controls.Add(groupBox1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRegistrarProductos;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtNombreP;
        private TextBox txtCodigo;
        private ComboBox cbbCategoria;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label2;
        private Label label1;
    }
}