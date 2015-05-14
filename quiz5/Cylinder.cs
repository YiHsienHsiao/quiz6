using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz5
{
    class Cylinder:Shape3D
    {
        private double _radius;
        private double _height;

        public Cylinder(double _radius, double _height, double density)
            :base(density)
        {
            Radius = _radius;
            Height = _height;
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

        public double Height
        {
            get { return _height; }
            set
            {
                if (_height < 0)
                {
                    _height = 0;
                }
                else
                {
                    _height = value;
                }
            }
        }

        public override double Volume()
        {
            return Constant.pi * _radius * _radius * _height;
        }

        public override string ShowProperty()
        {
            string str = "Cylinder";
            str += '\t';
            str += string.Format("{0,8:F2}", _radius);
            str += '\t';
            str += string.Format("{0,8:F2}", _height);
            return str;
        }
    }
}
