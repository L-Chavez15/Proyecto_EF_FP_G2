namespace Proyecto_EF_FP_G2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            dgvListadoClientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            dgvListadoProductos = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnMostrar = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoProductos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1287, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(129, 22);
            toolStripButton1.Text = "Registro de Cliente ";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(138, 22);
            toolStripButton2.Text = "Registro de producto";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // dgvListadoClientes
            // 
            dgvListadoClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoClientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvListadoClientes.Location = new Point(15, 72);
            dgvListadoClientes.Name = "dgvListadoClientes";
            dgvListadoClientes.Size = new Size(543, 269);
            dgvListadoClientes.TabIndex = 1;
            dgvListadoClientes.CellContentClick += dgvListadoClientes_CellContentClick;
            // 
            // Column1
            // 
            Column1.FillWeight = 150F;
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.FillWeight = 150F;
            Column2.HeaderText = "Apellido";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "DNI";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Teléfono";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // dgvListadoProductos
            // 
            dgvListadoProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoProductos.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8, Column9 });
            dgvListadoProductos.Location = new Point(18, 72);
            dgvListadoProductos.Name = "dgvListadoProductos";
            dgvListadoProductos.Size = new Size(636, 269);
            dgvListadoProductos.TabIndex = 2;
            // 
            // Column5
            // 
            Column5.FillWeight = 120F;
            Column5.HeaderText = "Código";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 120;
            // 
            // Column6
            // 
            Column6.FillWeight = 150F;
            Column6.HeaderText = "Nombre";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.FillWeight = 130F;
            Column7.HeaderText = "Categoría";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 130;
            // 
            // Column8
            // 
            Column8.HeaderText = "Precio";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Stock";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvListadoClientes);
            groupBox1.Location = new Point(12, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 357);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvListadoProductos);
            groupBox2.Location = new Point(604, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(671, 357);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(565, 432);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 5;
            btnMostrar.Text = "mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 480);
            Controls.Add(btnMostrar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoProductos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private DataGridView dgvListadoClientes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridView dgvListadoProductos;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn Column9;
        private Button btnMostrar;
    }
}
