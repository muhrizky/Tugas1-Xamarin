using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tugas1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TugasSatuDicoding : ContentPage
	{
		public TugasSatuDicoding ()
		{
            InitializeComponent();
        }

        double tinggiBadan = 0;
        double beratBadan = 0;
        string kesimpulan = "";

        private void btnLakiLaki_Clicked(object sender, EventArgs e)
        {
            //if (entryBerat.Text == null)
            //{
            //	beratBadan = 0;
            //}

            //if (entryTinggi.Text == null)
            //{
            //	tinggiBadan = 0;
            //}

            tinggiBadan = Int32.Parse(entryTinggi.Text);
            beratBadan = Int32.Parse(entryBerat.Text);


            double hasilBroscha = hitungBroscha("p", tinggiBadan);
            double hasilBMI = hitungBMI("p", beratBadan);

            entryBeratBadanIdeal.Text = hasilBroscha.ToString();
            entryNilaiBMI.Text = hasilBMI.ToString();
            entryKesimpulan.Text = kesimpulan;
        }

        private void btnPerempuan_Clicked(object sender, EventArgs e)
        {
            if (entryBerat.Text == null)
            {
                entryBerat.Text = "0";
            }

            if (entryTinggi.Text == null)
            {
                entryTinggi.Text = "0";
            }

            tinggiBadan = Int32.Parse(entryTinggi.Text);
            beratBadan = Int32.Parse(entryBerat.Text);

            double hasilBroscha = hitungBroscha("w", tinggiBadan);
            double hasilBMI = hitungBMI("w", beratBadan);


            entryBeratBadanIdeal.Text = hasilBroscha.ToString();
            entryNilaiBMI.Text = hasilBMI.ToString();
            entryKesimpulan.Text = kesimpulan;

        }

        public double hitungBroscha(string x, double y)
        {
            double hasilBroscha = 0;

            if (x == "p")
            {
                hasilBroscha = (y - 100) - ((0.1) * (y - 100));
            }
            else if (x == "w")
            {
                hasilBroscha = (y - 100) - ((0.15) * (y - 100));
            }

            return hasilBroscha;
        }

        public double hitungBMI(string x, double y)
        {
            double hasilBMI = 0;

            double tinggiBadanMeter = tinggiBadan / 100;

            hasilBMI = y / (tinggiBadanMeter * tinggiBadanMeter);

            if (x == "p")
            {
                if (hasilBMI < 17)
                {
                    kesimpulan = "Under Weight/Kurus";
                }
                if (hasilBMI > 17 && hasilBMI < 23)
                {
                    kesimpulan = "Normal Weight/Normal";
                }
                if (hasilBMI > 23 && hasilBMI < 27)
                {
                    kesimpulan = "Over Weight/Kegemukan ";
                }
                if (hasilBMI > 27)
                {
                    kesimpulan = "Obesitas";
                }
            }

            else if (x == "w")
            {
                if (hasilBMI < 18)
                {
                    kesimpulan = "Under Weight/Kurus";
                }
                if (hasilBMI > 18 && hasilBMI < 25)
                {
                    kesimpulan = "Normal Weight/Normal";
                }
                if (hasilBMI > 25 && hasilBMI < 27)
                {
                    kesimpulan = "Over Weight/Kegemukan ";
                }
                if (hasilBMI > 27)
                {
                    kesimpulan = "Obesitas";
                }
            }

            return hasilBMI;
        }
    }
}
