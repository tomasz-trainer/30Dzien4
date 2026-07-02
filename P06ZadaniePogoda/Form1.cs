using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06ZadaniePogoda
{
    public partial class Form1 : Form
    {
        private string sciezkaMiasta = @"C:\Users\csharp\source\repos\Dzien4\P06ZadaniePogoda\miasta.txt";

        public Form1()
        {
            InitializeComponent();

            string[] miasta = System.IO.File.ReadAllLines(sciezkaMiasta);
            cbMiasta.Items.Clear();
            // mozemy podobnie jak poprzednio w listbox uzupelnic w petli element po elemencie
            // zamiast tego mozemy zrobic to w jednej metodzie 
            cbMiasta.Items.AddRange(miasta);
        }

        private void btnPodajTemperature_Click(object sender, EventArgs e)
        {

            string wybraneMiasto = cbMiasta.Text;


            JednostkaTemperatury wybranaJednostka = JednostkaTemperatury.Celsjusz;
            if (rbFrenheit.Checked)
                wybranaJednostka = JednostkaTemperatury.Farenheit;
            else if (rbKelvin.Checked)
                wybranaJednostka = JednostkaTemperatury.Kelvin;

            ManagerPogody mp = new ManagerPogody();
            Temperatura temp =mp.PodajTemperature(wybraneMiasto, wybranaJednostka);

            lblRaport.Text = string.Format("Temperatura w mieście {0} wynosi {1} w jednostce {2}", wybraneMiasto, temp.WartoscSkonwertowana, wybranaJednostka);

              // Ustawienie obrazka 
            if(temp.WartoscWCelsjusz < 0)
                pbPogoda.Image = Properties.Resources.snow;
            else if (temp.WartoscWCelsjusz < 11)
                pbPogoda.Image = Properties.Resources.rain;
            else
                pbPogoda.Image = Properties.Resources.sun;


        }
    }
}
