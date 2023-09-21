using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex2
{
    internal class Quadrado
    {
        private double aresta;
        private double area;

        public void setAresta(double n)
        {
            aresta = n;
        }

        public double getAresta()
        {
            return aresta;
        }

        public double getArea()
        {
            return area;
        }

        public void calcular()
        {
            area = aresta * aresta;
        }
    }
}
