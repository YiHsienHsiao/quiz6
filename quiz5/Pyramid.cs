using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz5
{
    class Pyramid:Shape3D
    {
        private double _length;
        private double _height;

        public Pyramid(double _length, double _height, double density)
            :base(density)
        {
            Length = _length;
            Height = _height;
        }

        public double Length
        { 
            get { return _length; }
            set
            {
                if (_length < 0)
                {
                    _length = 0;
                }
                else
                {
                    _length = value;
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
            return 1.0/3*_length*_length*_height;
        }

        public override string ShowProperty()
        {
            string str = "Pyramid";
            str += '\t';
            str += string.Format("{0,8:F2}", _length);
            str += '\t';
            str += string.Format("{0,8:F2}", _height);
            return str;
        }
    }
}
