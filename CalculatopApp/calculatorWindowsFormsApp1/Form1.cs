using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorWindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            lstHasil.Items.Clear();

            lstHasil.Items.Add(string.Format("Hasil Penambahan : {0} + {1} = {2}", a, b, penambahan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pengurangan : {0} - {1} = {2}", a, b, pengurangan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Perkalian : {0} * {1} = {2}", a, b, perkalian(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pembagian : {0} / {1} = {2}", a, b, pembagian(a, b)));
        }
    }
}
