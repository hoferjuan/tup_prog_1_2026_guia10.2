namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarNumero = new System.Windows.Forms.Button();
            this.tbIngresarNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbMinimo = new System.Windows.Forms.Label();
            this.lbMaximo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizar1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbPromedio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActualizar2 = new System.Windows.Forms.Button();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnActualizar3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnListaSupProm = new System.Windows.Forms.Button();
            this.btnListaO = new System.Windows.Forms.Button();
            this.lsbCantidadIngresados = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.lbValorABuscar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarNumero);
            this.groupBox1.Controls.Add(this.tbIngresarNumero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procesar un número:";
            // 
            // btnRegistrarNumero
            // 
            this.btnRegistrarNumero.Location = new System.Drawing.Point(137, 70);
            this.btnRegistrarNumero.Name = "btnRegistrarNumero";
            this.btnRegistrarNumero.Size = new System.Drawing.Size(214, 32);
            this.btnRegistrarNumero.TabIndex = 2;
            this.btnRegistrarNumero.Text = "Registrar número";
            this.btnRegistrarNumero.UseVisualStyleBackColor = true;
            this.btnRegistrarNumero.Click += new System.EventHandler(this.btnRegistrarNumero_Click);
            // 
            // tbIngresarNumero
            // 
            this.tbIngresarNumero.Location = new System.Drawing.Point(183, 40);
            this.tbIngresarNumero.Name = "tbIngresarNumero";
            this.tbIngresarNumero.Size = new System.Drawing.Size(130, 24);
            this.tbIngresarNumero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un número";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbMinimo);
            this.groupBox2.Controls.Add(this.lbMaximo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnActualizar1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procesar máximo y mínimo";
            // 
            // lbMinimo
            // 
            this.lbMinimo.AutoSize = true;
            this.lbMinimo.Location = new System.Drawing.Point(179, 66);
            this.lbMinimo.Name = "lbMinimo";
            this.lbMinimo.Size = new System.Drawing.Size(68, 18);
            this.lbMinimo.TabIndex = 4;
            this.lbMinimo.Text = "lbMinimo";
            // 
            // lbMaximo
            // 
            this.lbMaximo.AutoSize = true;
            this.lbMaximo.Location = new System.Drawing.Point(179, 28);
            this.lbMaximo.Name = "lbMaximo";
            this.lbMaximo.Size = new System.Drawing.Size(72, 18);
            this.lbMaximo.TabIndex = 3;
            this.lbMaximo.Text = "lbMaximo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor mínimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor máximo";
            // 
            // btnActualizar1
            // 
            this.btnActualizar1.Location = new System.Drawing.Point(341, 41);
            this.btnActualizar1.Name = "btnActualizar1";
            this.btnActualizar1.Size = new System.Drawing.Size(110, 36);
            this.btnActualizar1.TabIndex = 0;
            this.btnActualizar1.Text = "Actualizar";
            this.btnActualizar1.UseVisualStyleBackColor = true;
            this.btnActualizar1.Click += new System.EventHandler(this.btnActualizar1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbPromedio);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnActualizar2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 91);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Procesar Promedio";
            // 
            // lbPromedio
            // 
            this.lbPromedio.AutoSize = true;
            this.lbPromedio.Location = new System.Drawing.Point(134, 45);
            this.lbPromedio.Name = "lbPromedio";
            this.lbPromedio.Size = new System.Drawing.Size(84, 18);
            this.lbPromedio.TabIndex = 3;
            this.lbPromedio.Text = "lbPromedio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Promedio";
            // 
            // btnActualizar2
            // 
            this.btnActualizar2.Location = new System.Drawing.Point(341, 38);
            this.btnActualizar2.Name = "btnActualizar2";
            this.btnActualizar2.Size = new System.Drawing.Size(110, 36);
            this.btnActualizar2.TabIndex = 0;
            this.btnActualizar2.Text = "Actualizar";
            this.btnActualizar2.UseVisualStyleBackColor = true;
            this.btnActualizar2.Click += new System.EventHandler(this.btnActualizar2_Click);
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(206, 43);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(77, 18);
            this.lbCantidad.TabIndex = 4;
            this.lbCantidad.Text = "lbCantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cantidad";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbCantidad);
            this.groupBox4.Controls.Add(this.btnActualizar3);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(18, 347);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(451, 91);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mostrar Cantidad de Ingresados";
            // 
            // btnActualizar3
            // 
            this.btnActualizar3.Location = new System.Drawing.Point(335, 36);
            this.btnActualizar3.Name = "btnActualizar3";
            this.btnActualizar3.Size = new System.Drawing.Size(110, 36);
            this.btnActualizar3.TabIndex = 0;
            this.btnActualizar3.Text = "Actualizar";
            this.btnActualizar3.UseVisualStyleBackColor = true;
            this.btnActualizar3.Click += new System.EventHandler(this.btnActualizar3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnListaSupProm);
            this.groupBox5.Controls.Add(this.btnListaO);
            this.groupBox5.Controls.Add(this.lsbCantidadIngresados);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(486, 137);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(302, 301);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mostrar Cantidad de ingresados";
            // 
            // btnListaSupProm
            // 
            this.btnListaSupProm.Location = new System.Drawing.Point(209, 154);
            this.btnListaSupProm.Name = "btnListaSupProm";
            this.btnListaSupProm.Size = new System.Drawing.Size(87, 128);
            this.btnListaSupProm.TabIndex = 2;
            this.btnListaSupProm.Text = "Mostrar Lista Superior al Promedio";
            this.btnListaSupProm.UseVisualStyleBackColor = true;
            this.btnListaSupProm.Click += new System.EventHandler(this.btnListaSupProm_Click);
            // 
            // btnListaO
            // 
            this.btnListaO.Location = new System.Drawing.Point(209, 29);
            this.btnListaO.Name = "btnListaO";
            this.btnListaO.Size = new System.Drawing.Size(87, 119);
            this.btnListaO.TabIndex = 1;
            this.btnListaO.Text = "Mostrar Lista Ordenada";
            this.btnListaO.UseVisualStyleBackColor = true;
            this.btnListaO.Click += new System.EventHandler(this.btnListaO_Click);
            // 
            // lsbCantidadIngresados
            // 
            this.lsbCantidadIngresados.FormattingEnabled = true;
            this.lsbCantidadIngresados.ItemHeight = 18;
            this.lsbCantidadIngresados.Location = new System.Drawing.Point(9, 29);
            this.lsbCantidadIngresados.Name = "lsbCantidadIngresados";
            this.lsbCantidadIngresados.Size = new System.Drawing.Size(194, 256);
            this.lsbCantidadIngresados.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnBuscar);
            this.groupBox6.Controls.Add(this.tbBuscar);
            this.groupBox6.Controls.Add(this.lbValorABuscar);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(486, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(302, 119);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(186, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 34);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(68, 57);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(100, 24);
            this.tbBuscar.TabIndex = 2;
            // 
            // lbValorABuscar
            // 
            this.lbValorABuscar.Location = new System.Drawing.Point(77, 88);
            this.lbValorABuscar.Name = "lbValorABuscar";
            this.lbValorABuscar.Size = new System.Drawing.Size(140, 25);
            this.lbValorABuscar.TabIndex = 1;
            this.lbValorABuscar.Text = "Valor a buscar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Valor a buscar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ejercicio1 Introducción";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistrarNumero;
        private System.Windows.Forms.TextBox tbIngresarNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnActualizar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnActualizar2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnActualizar3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbMinimo;
        private System.Windows.Forms.Label lbMaximo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbPromedio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label lbValorABuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnListaSupProm;
        private System.Windows.Forms.Button btnListaO;
        private System.Windows.Forms.ListBox lsbCantidadIngresados;
    }
}

