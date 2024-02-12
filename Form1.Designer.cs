namespace WindowsForms_Sueldo_Neto
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_descuento_sfs = new System.Windows.Forms.TextBox();
            this.txt_total_descuento = new System.Windows.Forms.TextBox();
            this.txt_sueldo_neto = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_sueldo_bruto = new System.Windows.Forms.TextBox();
            this.txt_descuento_afp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pago_por_hora = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_horas_trabajadas = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sueldo Neto de un empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(32, 316);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descuento SFS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MintCream;
            this.label5.Location = new System.Drawing.Point(32, 380);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Descuentos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MintCream;
            this.label6.Location = new System.Drawing.Point(31, 446);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sueldo Neto";
            // 
            // txt_descuento_sfs
            // 
            this.txt_descuento_sfs.Location = new System.Drawing.Point(189, 309);
            this.txt_descuento_sfs.Margin = new System.Windows.Forms.Padding(5);
            this.txt_descuento_sfs.Name = "txt_descuento_sfs";
            this.txt_descuento_sfs.Size = new System.Drawing.Size(164, 29);
            this.txt_descuento_sfs.TabIndex = 8;
            // 
            // txt_total_descuento
            // 
            this.txt_total_descuento.Location = new System.Drawing.Point(207, 377);
            this.txt_total_descuento.Margin = new System.Windows.Forms.Padding(5);
            this.txt_total_descuento.Name = "txt_total_descuento";
            this.txt_total_descuento.Size = new System.Drawing.Size(164, 29);
            this.txt_total_descuento.TabIndex = 9;
            // 
            // txt_sueldo_neto
            // 
            this.txt_sueldo_neto.Location = new System.Drawing.Point(207, 439);
            this.txt_sueldo_neto.Margin = new System.Windows.Forms.Padding(5);
            this.txt_sueldo_neto.Name = "txt_sueldo_neto";
            this.txt_sueldo_neto.Size = new System.Drawing.Size(164, 29);
            this.txt_sueldo_neto.TabIndex = 10;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(525, 204);
            this.btn_calcular.Margin = new System.Windows.Forms.Padding(5);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(125, 39);
            this.btn_calcular.TabIndex = 11;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(525, 272);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(125, 39);
            this.btn_limpiar.TabIndex = 12;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(525, 344);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(5);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(125, 39);
            this.btn_salir.TabIndex = 13;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_sueldo_bruto
            // 
            this.txt_sueldo_bruto.Location = new System.Drawing.Point(189, 179);
            this.txt_sueldo_bruto.Margin = new System.Windows.Forms.Padding(5);
            this.txt_sueldo_bruto.Name = "txt_sueldo_bruto";
            this.txt_sueldo_bruto.Size = new System.Drawing.Size(164, 29);
            this.txt_sueldo_bruto.TabIndex = 6;
            // 
            // txt_descuento_afp
            // 
            this.txt_descuento_afp.Location = new System.Drawing.Point(189, 247);
            this.txt_descuento_afp.Margin = new System.Windows.Forms.Padding(5);
            this.txt_descuento_afp.Name = "txt_descuento_afp";
            this.txt_descuento_afp.Size = new System.Drawing.Size(164, 29);
            this.txt_descuento_afp.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MintCream;
            this.label7.Location = new System.Drawing.Point(32, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sueldo bruto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MintCream;
            this.label8.Location = new System.Drawing.Point(31, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Descuento AFP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(32, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pago por Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(366, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Horas trabajadas";
            // 
            // txt_pago_por_hora
            // 
            this.txt_pago_por_hora.Location = new System.Drawing.Point(207, 108);
            this.txt_pago_por_hora.Name = "txt_pago_por_hora";
            this.txt_pago_por_hora.Size = new System.Drawing.Size(100, 29);
            this.txt_pago_por_hora.TabIndex = 16;
            // 
            // txt_horas_trabajadas
            // 
            this.txt_horas_trabajadas.Location = new System.Drawing.Point(573, 108);
            this.txt_horas_trabajadas.Name = "txt_horas_trabajadas";
            this.txt_horas_trabajadas.Size = new System.Drawing.Size(100, 29);
            this.txt_horas_trabajadas.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(807, 578);
            this.Controls.Add(this.txt_horas_trabajadas);
            this.Controls.Add(this.txt_pago_por_hora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_sueldo_neto);
            this.Controls.Add(this.txt_total_descuento);
            this.Controls.Add(this.txt_descuento_sfs);
            this.Controls.Add(this.txt_descuento_afp);
            this.Controls.Add(this.txt_sueldo_bruto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_descuento_sfs;
        private System.Windows.Forms.TextBox txt_total_descuento;
        private System.Windows.Forms.TextBox txt_sueldo_neto;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_sueldo_bruto;
        private System.Windows.Forms.TextBox txt_descuento_afp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pago_por_hora;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txt_horas_trabajadas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

