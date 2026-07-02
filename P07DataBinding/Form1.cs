using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sciezka = @"C:\Users\csharp\source\repos\Dzien4\P04AplikacjaZawodnicy\zawodnicy.txt";

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ManagerZawodnikow mz = new ManagerZawodnikow();
            Zawodnik[] zawodnicy = mz.WczytajZawodnikow(sciezka);

            lbDane.DataSource = zawodnicy; // wiązanie danych z listboxem
            lbDane.DisplayMember = "ImieNazwisko"; // wyświetlanie imienia zawodnika w listboxie
        }

        private void btnPodajTemperature_Click(object sender, EventArgs e)
        {
            // checmy odczytać, który zawodnik jest aktualnie zaznaczony 
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;

            // MessageBox.Show(zaznaczony.ImieNazwisko);

            ManagerPogody mp = new ManagerPogody();
            Temperatura temp =mp.PodajTemperature(zaznaczony.Kraj, JednostkaTemperatury.Celsjusz);

            lblRaport.Text = String.Format("W kraju {0}, skąd pochodzi zawodnik {1} temperatura wynosi {2}",
                zaznaczony.Kraj, zaznaczony.ImieNazwisko, temp.WartoscWCelsjusz);
        }
    }
}
