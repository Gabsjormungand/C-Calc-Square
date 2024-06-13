﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Calc_Square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtNumero.Text;
            double numero;

            if (double.TryParse(input, out numero))
            {
                double quadrado = Math.Pow(numero, 2);
                lblResultado.Text = $"O quadrado de {numero} é {quadrado}";
            }
            else
            {
                lblResultado.Text = "Entrada inválida. Por favor, digite um número.";
            }
        }
    }
}
