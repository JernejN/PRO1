﻿using System;

namespace VajaLiki
{
    internal class Pravokotnik
    {
        int x1, y1, x2, y2;
        public Pravokotnik(int x1p, int y1p, int x2p, int y2p)
        {
            x1 = x1p;
            y1 = y1p;
            x2 = x2p;
            y2 = y2p;
        }

        public int X1 { get => x1; set => x1 = value; }
        public int Y1 { get => y1; set => y1 = value; }
        public int X2 { get => x2; set => x2 = value; }
        public int Y2 { get => y2; set => y2 = value; }

        public int StranicaA()
        {
            return Math.Abs(x2 - x1);
        }
        public int StranicaB()
        {
            return Math.Abs(y2 - y1);
        }
        public int Ploscina()
        {
            return StranicaA() * StranicaB();
        }
    }
}
