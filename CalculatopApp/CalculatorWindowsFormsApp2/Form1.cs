using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorClassLibrary1;

namespace CalculatorWindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Penambahan");
            comboBox1.Items.Add("Pengurangan");
            comboBox1.Items.Add("Perkalian");
            comboBox1.Items.Add("Pembagian");
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            var cal = new Calculator();
            
            int index = comboBox1.SelectedIndex;
            switch(index)
            {
                case 0: txtHasil.Text = cal.penambahan(a, b).ToString(); break;
                case 1: txtHasil.Text = cal.pengurangan(a, b).ToString(); break;
                case 2: txtHasil.Text = cal.perkalian(a, b).ToString(); break;
                case 3: txtHasil.Text = Calculator.pembagian(a, b).ToString(); break;
                case 4: txtHasil.Text = cal.pangkat(a, b).ToString(); break;
                case 5: txtHasil.Text = cal.Modulo(a, b).ToString(); break;
            }
        }

        private void txtHasil_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Penambahan");
            comboBox1.Items.Add("Pengurangan");
            comboBox1.Items.Add("Perkalian");
            comboBox1.Items.Add("Pembagian");
            comboBox1.Items.Add("Pangkat");
            comboBox1.Items.Add("Modulo");
        }
    }
}
