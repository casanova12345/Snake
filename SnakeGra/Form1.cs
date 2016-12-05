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
        private void GenerowanieJedzenia()
        {
            int maxXPos = plansza.Size.Width / Ustawienia.Szerokosc;
            int maxYPos = plansza.Size.Height / Ustawienia.Wysokosc;
            Random random = new Random();
            jedzenie = new Kolo {X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos)};
    }
        private void Odswiez(object sender, EventArgs e)
        {
            
            if (Ustawienia.KoniecGry)
            {
            
                if (Wprowadzanie.Klawisze(Keys.Enter))
                {
                    StartGry();
                }
            }
            else
            {
                if (Wprowadzanie.Klawisze(Keys.Right) && Ustawienia.kierunek != Kierunek.Left)
                    Ustawienia.kierunek = Kierunek.Right;
                else if (Wprowadzanie.Klawisze(Keys.Left) && Ustawienia.kierunek != Kierunek.Right)
                    Ustawienia.kierunek = Kierunek.Left;
                else if (Wprowadzanie.Klawisze(Keys.Up) && Ustawienia.kierunek != Kierunek.Down)
                    Ustawienia.kierunek = Kierunek.Up;
                else if (Wprowadzanie.Klawisze(Keys.Down) && Ustawienia.kierunek != Kierunek.Up)
                    Ustawienia.kierunek = Kierunek.Down;
                Ruch();
            }
            plansza.Invalidate();
        }
}
