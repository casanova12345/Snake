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

    }
}
