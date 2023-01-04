using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    public class Quadrilatero
    {
        public Quadrilatero() { }
        public Quadrilatero(int baseQuadrilatero, int alturaQuadrilatero)
        {
            this.BaseQuad = baseQuadrilatero;
            this.AltQuad= alturaQuadrilatero;
        }

        private int baseQuad;

        public int BaseQuad
        {
            get { return baseQuad; }
            set 
            { 
                if (value >= 0) baseQuad = value; 
                else baseQuad = 0;
            }
        }

        private int altQuad;

        public int AltQuad
        {
            get { return altQuad; }
            set 
            {
                if (value >= 0) altQuad = value;
                else altQuad = 0;
            }
        }

        public int Area
        {
            get 
            {
                return baseQuad * altQuad;
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine("Valores do Quadrilátero:");
            Console.WriteLine("Base = " + this.BaseQuad);
            Console.WriteLine("Altura = " + this.AltQuad);
            Console.WriteLine("Área = " + this.Area);
        }
    }
}