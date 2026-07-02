using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01AplikacjaOkienkowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPolicz_Click(object sender, EventArgs e)
        {
            int liczba1 = int.Parse(txtLiczba1.Text);
            int liczba2 = int.Parse(txtLiczba2.Text);

            int wynik = liczba1 + liczba2;

            lblWynik.Text = wynik.ToString();

            MessageBox.Show("Wynik to:" + wynik);
        }
    }
}
