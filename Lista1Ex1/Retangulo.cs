﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex1
{
    internal class Retangulo
    {
        private double b;
        private double h;
        private double area;

        public void setB(double n)
        {
            b = n;
        }
        public void setH(double n)
        {
            h = n;
        }
        public double getB()
        {
            return b;
        }
        public double getH()
        {
            return h;
        }

        public double getArea()
        {
            return area;
        }
        public void calcular()
        {
            area = b * h;
        }
    }
}
