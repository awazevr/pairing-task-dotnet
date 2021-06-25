using System;

namespace AreaSearch
{
    public class Rectangle : IRectangle
    {
        public float x1, x2, y1, y2;

        public Rectangle() : this(float.PositiveInfinity, float.PositiveInfinity, float.NegativeInfinity, float.NegativeInfinity) {
            //null rectangle (contains nothing)
        }

        public Rectangle(float x1, float x2, float y1, float y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public Boolean contains(DataPoint point) {
            return false;
        }
    }
}
