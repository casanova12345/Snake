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

        private void plansza_Paint(object sender, PaintEventArgs e)
        {
            Graphics plansza = e.Graphics;
            if (!Ustawienia.KoniecGry)
            {

                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Black; 
                    else
                        snakeColour = Brushes.Green; 
 
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Ustawienia.Szerokosc,
                                      Snake[i].Y * Ustawienia.Wysokosc,
                                      Ustawienia.Szerokosc, Ustawienia.Wysokosc));

                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(jedzenie.X * Ustawienia.Szerokosc,
                             jedzenie.Y * Ustawienia.Wysokosc, Ustawienia.Szerokosc, Ustawienia.Wysokosc));
                }
            }
            else
            {
                string KoniecGry = "Koniec Gry \nTwoje zdobyte punkty: " + Ustawienia.Wynik + "\nNacisnij Enter aby zaczac ponownie";
                lblKoniecGry.Text = KoniecGry;
                lblKoniecGry.Visible = true;
            }
            private void Ruch()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
               
                if (i == 0)
                {
                    switch (Ustawienia.kierunek)
                    {
                        case Kierunek.Right:
                            Snake[i].X++;
                            break;
                        case Kierunek.Left:
                            Snake[i].X--;
                            break;
                        case Kierunek.Up:
                            Snake[i].Y--;
                            break;
                        case Kierunek.Down:
                            Snake[i].Y++;
                            break;
                    }

                    int maxXPos = plansza.Size.Width / Ustawienia.Szerokosc;
                    int maxYPos = plansza.Size.Height / Ustawienia.Wysokosc;
  
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Smierc();
                    }
 
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                           Smierc();
                        }
                    }
 
                    if (Snake[0].X == jedzenie.X && Snake[0].Y == jedzenie.Y)
                    {
                        Jesc();
                    }
                }
                else
                {
 
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }
        }
}
