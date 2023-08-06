
namespace Sistema_Inventario
{
    partial class Movimiento_Inventario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movimiento_Inventario));
            this.Ptitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Pbotones = new System.Windows.Forms.Panel();
            this.Bsalir = new System.Windows.Forms.Button();
            this.Bcancelar = new System.Windows.Forms.Button();
            this.Bguardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.toolTipempleado = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TRepresentaciongrafica = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Ptitulo.SuspendLayout();
            this.Pbotones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ptitulo
            // 
            this.Ptitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.Ptitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ptitulo.Controls.Add(this.label1);
            this.Ptitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ptitulo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ptitulo.ForeColor = System.Drawing.Color.White;
            this.Ptitulo.Location = new System.Drawing.Point(0, 0);
            this.Ptitulo.Name = "Ptitulo";
            this.Ptitulo.Size = new System.Drawing.Size(1043, 100);
            this.Ptitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movimiento Inventario";
            // 
            // Pbotones
            // 
            this.Pbotones.BackColor = System.Drawing.Color.SteelBlue;
            this.Pbotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pbotones.Controls.Add(this.Bsalir);
            this.Pbotones.Controls.Add(this.Bcancelar);
            this.Pbotones.Controls.Add(this.Bguardar);
            this.Pbotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pbotones.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pbotones.Location = new System.Drawing.Point(0, 649);
            this.Pbotones.Name = "Pbotones";
            this.Pbotones.Size = new System.Drawing.Size(1043, 100);
            this.Pbotones.TabIndex = 1;
            // 
            // Bsalir
            // 
            this.Bsalir.BackColor = System.Drawing.SystemColors.Window;
            this.Bsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bsalir.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Bsalir.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.Bsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Bsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.Bsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bsalir.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bsalir.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Bsalir.Image = global::Sistema_Inventario.Properties.Resources.salir_boton;
            this.Bsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bsalir.Location = new System.Drawing.Point(669, 33);
            this.Bsalir.Name = "Bsalir";
            this.Bsalir.Size = new System.Drawing.Size(94, 43);
            this.Bsalir.TabIndex = 5;
            this.Bsalir.Text = "&Salir";
            this.Bsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipempleado.SetToolTip(this.Bsalir, "Salir del formulario");
            this.Bsalir.UseVisualStyleBackColor = false;
            this.Bsalir.Click += new System.EventHandler(this.Bsalir_Click);
            // 
            // Bcancelar
            // 
            this.Bcancelar.BackColor = System.Drawing.SystemColors.Window;
            this.Bcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bcancelar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Bcancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.Bcancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Bcancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.Bcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bcancelar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcancelar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Bcancelar.Image = global::Sistema_Inventario.Properties.Resources.cancelar;
            this.Bcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bcancelar.Location = new System.Drawing.Point(488, 33);
            this.Bcancelar.Name = "Bcancelar";
            this.Bcancelar.Size = new System.Drawing.Size(130, 43);
            this.Bcancelar.TabIndex = 3;
            this.Bcancelar.Text = "&Cancelar";
            this.Bcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipempleado.SetToolTip(this.Bcancelar, "Cancelar cambios de empleado");
            this.Bcancelar.UseVisualStyleBackColor = false;
            this.Bcancelar.Click += new System.EventHandler(this.Bcancelar_Click);
            // 
            // Bguardar
            // 
            this.Bguardar.BackColor = System.Drawing.SystemColors.Window;
            this.Bguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bguardar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Bguardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.Bguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Bguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.Bguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bguardar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bguardar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Bguardar.Image = global::Sistema_Inventario.Properties.Resources.guardar;
            this.Bguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bguardar.Location = new System.Drawing.Point(307, 33);
            this.Bguardar.Name = "Bguardar";
            this.Bguardar.Size = new System.Drawing.Size(130, 43);
            this.Bguardar.TabIndex = 1;
            this.Bguardar.Text = "&Guardar";
            this.Bguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipempleado.SetToolTip(this.Bguardar, "Guardar cambios de empleado");
            this.Bguardar.UseVisualStyleBackColor = false;
            this.Bguardar.Click += new System.EventHandler(this.Bguardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id_movimiento_inventario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Busqueda producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de movimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 31);
            this.label9.TabIndex = 9;
            this.label9.Text = "Empleado";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(376, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(134, 39);
            this.textBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox2.Location = new System.Drawing.Point(831, 181);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(251, 39);
            this.comboBox2.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Image = global::Sistema_Inventario.Properties.Resources.buscarboton;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(304, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 43);
            this.button1.TabIndex = 24;
            this.button1.Text = "&Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipempleado.SetToolTip(this.button1, "Buscar empleados");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Jeremy",
            "Jhonny",
            "Carlos",
            "Rafael",
            "Marvin",
            "Adrian",
            "Gabriel",
            "Mariia",
            "Rosa"});
            this.comboBox3.Location = new System.Drawing.Point(259, 207);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(251, 39);
            this.comboBox3.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(259, 454);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 39);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.White;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.comboBox4.Location = new System.Drawing.Point(299, 361);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(211, 39);
            this.comboBox4.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(259, 288);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(251, 39);
            this.textBox4.TabIndex = 29;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TRepresentaciongrafica);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(543, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 525);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de los productos";
            // 
            // TRepresentaciongrafica
            // 
            this.TRepresentaciongrafica.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRepresentaciongrafica.Location = new System.Drawing.Point(101, 368);
            this.TRepresentaciongrafica.Name = "TRepresentaciongrafica";
            this.TRepresentaciongrafica.Size = new System.Drawing.Size(251, 39);
            this.TRepresentaciongrafica.TabIndex = 37;
            this.TRepresentaciongrafica.Visible = false;
            this.TRepresentaciongrafica.TextChanged += new System.EventHandler(this.TRepresentaciongrafica_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 191);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 31);
            this.label10.TabIndex = 33;
            this.label10.Text = "Imagen del producto:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(187, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 39);
            this.textBox2.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 31);
            this.label6.TabIndex = 30;
            this.label6.Text = "Nombre";
            // 
            // Movimiento_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1043, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pbotones);
            this.Controls.Add(this.Ptitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Movimiento_Inventario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Movimiento_Inventario_FormClosing);
            this.Ptitulo.ResumeLayout(false);
            this.Ptitulo.PerformLayout();
            this.Pbotones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Ptitulo;
        private System.Windows.Forms.Panel Pbotones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bsalir;
        private System.Windows.Forms.Button Bcancelar;
        private System.Windows.Forms.Button Bguardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolTip toolTipempleado;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TRepresentaciongrafica;
    }
}