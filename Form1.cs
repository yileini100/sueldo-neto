﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Sueldo_Neto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los cuadros de texto
            txt_pago_por_hora.Clear();
            txt_horas_trabajadas.Clear();
            txt_sueldo_bruto.Clear();
            txt_descuento_afp.Clear();
            txt_descuento_sfs.Clear();
            txt_total_descuento.Clear();
            txt_sueldo_neto.Clear();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            
            double pagoPorHora = Convert.ToDouble(txt_pago_por_hora.Text);
            double horasTrabajadas = Convert.ToDouble(txt_horas_trabajadas.Text);

            
            double sueldoBruto = pagoPorHora * horasTrabajadas;

            double descuentoAFP = sueldoBruto * 0.0287; // 2.87%
            double descuentoSFS = sueldoBruto * 0.0304; // 3.04%

            
            double totalDescuentos = descuentoAFP + descuentoSFS;
            double sueldoNeto = sueldoBruto - totalDescuentos;

            txt_sueldo_bruto.Text = sueldoBruto.ToString("0.00");
            txt_descuento_afp.Text = descuentoAFP.ToString("0.00");
            txt_descuento_sfs.Text = descuentoSFS.ToString("0.00");
            txt_total_descuento.Text = totalDescuentos.ToString("0.00");
            txt_sueldo_neto.Text = sueldoNeto.ToString("0.00");
        }
    }
}
