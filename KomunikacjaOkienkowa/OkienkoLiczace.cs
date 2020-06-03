using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomunikacjaOkienkowa
{
    public partial class OkienkoLiczace : Form
    {

        public string dzialanie { get; private set; }

        delegate string mojDelegat();
        mojDelegat delegat;
        public OkienkoLiczace(char znak)
        {
            InitializeComponent();
            if (znak == '+')
            {
                this.Text = "Dodawanie";
                ZnakDzialania_Label.Text = "+";
                delegat = dodawanie;
            }
            else if (znak == '-')
            {
                this.Text = "Odejmowanie";
                ZnakDzialania_Label.Text = "-";
                delegat = odejmowanie;
            }
            else if (znak == '*')
            {
                this.Text = "Mnozenie";
                ZnakDzialania_Label.Text = "*";
                delegat = mnozenie;
            }
            else if (znak == '/')
            {
                this.Text = "Dzielenie";
                ZnakDzialania_Label.Text = "/";
                delegat = dzielenie;
            }
        }

        private void Wynik_Button_Click(object sender, EventArgs e)
        {
            dzialanie = delegat();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private string dodawanie()
        {
            double wynik = double.Parse(LiczbaA_TextBox.Text) + double.Parse(LiczbaB_TextBox.Text);
            return LiczbaA_TextBox.Text + ZnakDzialania_Label.Text + LiczbaB_TextBox.Text + "=" + wynik.ToString();
        }

        private string odejmowanie()
        {
            double wynik = double.Parse(LiczbaA_TextBox.Text) - double.Parse(LiczbaB_TextBox.Text);
            return LiczbaA_TextBox.Text + ZnakDzialania_Label.Text + LiczbaB_TextBox.Text + "=" + wynik.ToString();
        }

        private string mnozenie()
        {
            double wynik = double.Parse(LiczbaA_TextBox.Text) * double.Parse(LiczbaB_TextBox.Text);
            return LiczbaA_TextBox.Text + ZnakDzialania_Label.Text + LiczbaB_TextBox.Text + "=" + wynik.ToString();
        }

        private string dzielenie()
        {
            if (double.Parse(LiczbaB_TextBox.Text) == 0)
            {
                MessageBox.Show("Brzydko!");
                return LiczbaA_TextBox.Text + ZnakDzialania_Label.Text + LiczbaB_TextBox.Text + "= inf";

            }
            else
            {
                double wynik = double.Parse(LiczbaA_TextBox.Text) / double.Parse(LiczbaB_TextBox.Text);
                return LiczbaA_TextBox.Text + ZnakDzialania_Label.Text + LiczbaB_TextBox.Text +  "=" + wynik.ToString();
            }
            
        }

        public OkienkoLiczace(string dzialanie)
        {
            InitializeComponent();
            char[] znaki = { '+', '-', '*', '/' };
            int indexZnaku = dzialanie.IndexOfAny(znaki);
            int indexRowna = dzialanie.IndexOf('=');
            ZnakDzialania_Label.Text = dzialanie[indexZnaku].ToString();
            LiczbaA_TextBox.Text = dzialanie.Substring(0, indexZnaku);
            LiczbaB_TextBox.Text = dzialanie.Substring(indexZnaku + 1, indexRowna- indexZnaku-1);
            if (ZnakDzialania_Label.Text == "+")
            {
                this.Text = "Dodawanie";
                delegat = dodawanie;
            }
            else if (ZnakDzialania_Label.Text == "-")
            {
                this.Text = "Odejmowanie";
                delegat = odejmowanie;
            }
            else if (ZnakDzialania_Label.Text == "*")
            {
                this.Text = "Mnozenie";
                delegat = mnozenie;
            }
            else if (ZnakDzialania_Label.Text == "/")
            {
                this.Text = "Dzielenie";
                delegat = dzielenie;
            }
        }

        /*
                public double wynik;
                double liczbaA;
                double liczbaB;

                public OkienkoLiczace(char znak)
                 {
                     InitializeComponent();
                    if (znak == '+')
                    {
                        this.Text = "dodawanie";
                        ZnakDzialania_Label.Text = "+";
                    }
                 }

                private void Wynik_Button_Click(object sender, EventArgs e)
                {
                    if (this.Text == "dodawanie")
                    {
                        liczbaA = 3;
                        liczbaB = 5;
                        wynik = 20;
                    }
                    this.Close();
                }*/

    }
}
