using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz5
{
    class Ball:Shape3D
    {
        private double _radius;

        public Ball (double _radius, double density)
            :base(density)
        {
            Radius = _radius;
        }

        public double Radius
        {
            get { return _radius; }
            set
            {
                if (_radius<0)
                {
                    _radius = 0;
                }
                else
                {
                    _radius = value;
                }
            }
        }

        public override double Volume()
        {
            return 4.0 / 3 * Constant.pi * _radius * _radius * _radius;
        }

        public override string ShowProperty()
        {
            string str = "Ball";
            str += '\t';
            str += string.Format("{0,8:F2}", _radius);
            str += '\t';
            str += "";
            return str;
        }
    }
}
