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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        string historiaDodawanie;
        string historiaOdejmowanie;
        string historiaMnozenie;
        string historiaDzielenie;
        private void label1_Click(object sender, EventArgs e)
        {
            OkienkoLiczace okienko = new OkienkoLiczace(label1.Text);
            if (okienko.ShowDialog() == DialogResult.OK)
            {
                label1.Text = okienko.dzialanie;
                char[] znaki = { '+', '-', '*', '/' };
                int indexZnaku = label1.Text.IndexOfAny(znaki);
                string znak = label1.Text[indexZnaku].ToString();
                if (znak == "+")
                {
                    historiaDodawanie = okienko.dzialanie;
                }
                else if (znak == "-")
                {
                    historiaOdejmowanie = okienko.dzialanie;
                }
                else if (znak == "*")
                {
                    historiaMnozenie = okienko.dzialanie;
                }
                else if (znak == "/")
                {
                    historiaDzielenie = okienko.dzialanie;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OkienkoLiczace okienko;
            if (historiaDzielenie == null)
            {
                okienko = new OkienkoLiczace('/');
            }
            else
            {
                okienko = new OkienkoLiczace(historiaDzielenie);
            }
            okienko.ShowDialog();
            if (okienko.DialogResult == DialogResult.OK)
            {
                label1.Text = okienko.dzialanie;
                historiaDzielenie = okienko.dzialanie;
            }
        }

        private void Dodawanie_But_Click(object sender, EventArgs e)
        {
            OkienkoLiczace okienko;
            if (historiaDzielenie == null)
            {
                okienko = new OkienkoLiczace('+');
            }
            else
            {
                okienko = new OkienkoLiczace(historiaDodawanie);
            }
            
            if (okienko.ShowDialog() == DialogResult.OK)
            {
                label1.Text = okienko.dzialanie;
                historiaDodawanie = okienko.dzialanie;
            }
        }

        private void Mnozenie_But_Click(object sender, EventArgs e)
        {
            OkienkoLiczace okienko;
            if (historiaDzielenie == null)
            {
                okienko = new OkienkoLiczace('*');
                
            }
            else
            {
                okienko = new OkienkoLiczace(historiaMnozenie);
                
            }
            
            if (okienko.ShowDialog() == DialogResult.OK)
            {

                label1.Text = okienko.dzialanie;
                historiaMnozenie = okienko.dzialanie;
            }
        }

        private void Odejmowanie_But_Click(object sender, EventArgs e)
        {
            OkienkoLiczace okienko;
            if (historiaDzielenie == null)
            {
                okienko = new OkienkoLiczace('-');
                
            }
            else
            {
                okienko = new OkienkoLiczace(historiaOdejmowanie);
                
            }
            if (okienko.ShowDialog() == DialogResult.OK)
            {
                label1.Text = okienko.dzialanie;
                historiaOdejmowanie = okienko.dzialanie;
            }
        }
    }
}
