using NUnit.Framework;

namespace AreaSearch.Test
{
    public class Tests
    {
        [Test]
        public void testNullRectangle()
        {
            Rectangle rect = new Rectangle();
            DataPoint point = new DataPoint(0f, 0f);
            Assert.IsFalse(rect.contains(point));
        }

        [Test]
        public void testInside()
        {
            Rectangle rect = new Rectangle(0, 0, 2, 2);
            DataPoint point = new DataPoint(1, 1);
            Assert.IsTrue(rect.contains(point));
        }

        [Test]
        public void testOutside()
        {
            Rectangle rect = new Rectangle(0, 0, 2, 2);
            DataPoint point = new DataPoint(3, 3);
            Assert.IsFalse(rect.contains(point));
        }
    }
}