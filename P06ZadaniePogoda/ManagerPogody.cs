using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadaniePogoda
{
    enum JednostkaTemperatury
    {
        Celsjusz,
        Kelvin,
        Farenheit
    }

    class Temperatura
    {
        public double WartoscWCelsjusz { get; set; }
        public double WartoscSkonwertowana { get; set; }

    }

    internal class ManagerPogody
    {
        public Temperatura PodajTemperature(string miasto, JednostkaTemperatury jednostka)
        {
            string url = $"https://wttr.in/{miasto}?format=%t";

            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                string odpowiedz = client.DownloadString(url);
                string liczba = odpowiedz.Replace("+", "").Replace("°C", "").Trim();
                double tempCelsjusz = Convert.ToDouble(liczba);

                double tempSkonwertowana = transformujTemperature(jednostka, Convert.ToDouble(tempCelsjusz));
                return new Temperatura
                {
                    WartoscWCelsjusz = tempCelsjusz,
                    WartoscSkonwertowana = tempSkonwertowana
                };
            }
        }

        private double transformujTemperature(JednostkaTemperatury jednostka, double temp)
        {
            if (jednostka == JednostkaTemperatury.Celsjusz)
                return temp;
            else if (jednostka == JednostkaTemperatury.Farenheit)
                return (temp * 1.8) + 32;
            else if (jednostka == JednostkaTemperatury.Kelvin)
                return temp + 273.15;
            else
                throw new ArgumentException("Nieznana jednostka temperatury");


        }
    }
}
