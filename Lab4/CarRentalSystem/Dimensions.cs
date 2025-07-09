using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    struct Dimensions
    {
        public double Length;
        public double Width;
        public double Height;
        public Dimensions(double Length,
        double Width,
        double Height)
        {
            this.Width = Width;
            this.Height = Height;
            this.Length = Length;
        }
    }
}
