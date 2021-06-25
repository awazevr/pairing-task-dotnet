using System;

namespace AreaSearch
{
    public class DataPoint : IDataPoint
    {
        private static float EPSILON = 0.000001f;
        public float x, y;

        public DataPoint(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object value)
        {
            if (value is DataPoint) {
            DataPoint that = (DataPoint)value;
            return Math.Abs(this.x - that.x) < EPSILON && Math.Abs(this.y - that.y) < EPSILON;
            }

            return false;
        }

        public override string ToString()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);

            return "";
        }

    }
}