﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum Kierunek
    {
        Gora,
        Dol,
        Lewo,
        Prawo
    };
    public class Ustawienia
    {
        public static int Szerokosc { get; set; }
        public static int Wysokosc { get; set; }
        public static int Predkosc { get; set; }
        public static int Wynik { get; set; }
        public static int Punkty { get; set; }
        public static bool KoniecGry { get; set; }
        public static Kierunek kierunek { get; set; }
        public Ustawienia()
        {
            Szerokosc = 20;
            Wysokosc = 20;
            Predkosc = 15;
            Wynik = 0;
            Punkty = 1;
            KoniecGry = false;
            kierunek = Kierunek.Dol;
        }
    }
  
}
