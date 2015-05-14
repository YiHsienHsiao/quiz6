using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz5
{
    class Cube:Shape3D
    {
        private double _length;

        public Cube(double _length, double density)
            : base(density)
        {
            Length = _length;
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

        public override double Volume()
        {
            return _length * _length * _length;
        }

        public override string ShowProperty()
        {
            string str = "Cube";
            str += '\t';
            str += string.Format("{0,8:F2}", _length);
            str += '\t';
            str += "";
            return str;
        }
    }
}
