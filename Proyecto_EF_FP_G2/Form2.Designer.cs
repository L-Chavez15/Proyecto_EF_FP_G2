namespace Proyecto_EF_FP_G2
{
    partial class Form2
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
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            label4 = new Label();
            btnRegistrar = new Button();
            txtTelefono = new TextBox();
            txtDni = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 300);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 62);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(206, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(95, 97);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(206, 23);
            txtApellidos.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 105);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 9;
            label4.Text = "Apellidos";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.GradientInactiveCaption;
            btnRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(95, 238);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(186, 34);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(95, 185);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 15;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(95, 143);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(139, 23);
            txtDni.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 188);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 13;
            label6.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 146);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 12;
            label5.Text = "DNI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 19);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 17;
            label1.Text = "Registro de Clientes";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 321);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRegistrar;
        private TextBox txtApellidos;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtDni;
        private TextBox txtNombre;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label1;
    }
}