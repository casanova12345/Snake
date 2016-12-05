using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Kolo> Snake = new List<Kolo>();
        private Kolo jedzenie = new Kolo();
        public Form1()
        {
            InitializeComponent();
            
            new Ustawienia();
           
            Timer.Interval = 1000 / Ustawienia.Predkosc;
            Timer.Tick += Odswiez;
            Timer.Start();
            
            StartGry();
        }
        private void StartGry()
        {
            lblKoniecGry.Visible = false;
            
            new Ustawienia();
            
            Snake.Clear();
            Kolo glowa = new Kolo { X = 10, Y = 5 };
            Snake.Add(glowa);
            lblPunkty2.Text = Ustawienia.Wynik.ToString();
            GenerowanieJedzenia();
        }
    }
}
