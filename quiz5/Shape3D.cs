using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace quiz5
{
    abstract class Shape3D
    {
        protected double density;
        private static int _amount = 0;

        protected Shape3D()
        {
            Density = 0;
            _amount++;
        }

        protected Shape3D(double d)
        {
            Density = d;
            _amount++;
        }

        public double Density
        {
            get { return density; }
            set
            {
                if (density<0)
                {
                    density = 0;
                }
                else
                {
                    density = value;
                }
            }
        }
        public static int Amount
        {
            get { return _amount; }
        }

        public abstract double Volume();
        
        public double Weight()
        {
            return density * Volume();
        }

        public abstract string ShowProperty();

        public string ShowResults()
        {
            string results = ShowProperty();
            results+='\t';
            results += string.Format("{0,8:F2}", density);
            results += '\t';
            results += string.Format("{0,8:F2}", Volume());
            results += '\t';
            results += string.Format("{0,8:F2}", Weight());
            return results;

        }
    }
}
