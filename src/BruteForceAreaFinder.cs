using System.Collections.ObjectModel;

namespace AreaSearch
{
    public class BruteForceAreaFinder : AreaFinder

    {

        Collection<DataPoint> fullDataSet;

        public static BruteForceAreaFinder constructFrom(Collection<DataPoint> dataPoints)
        {
            return new BruteForceAreaFinder(dataPoints);
        }

        private BruteForceAreaFinder(Collection<DataPoint> dataPoints)
        {
            fullDataSet = dataPoints;
        }

        public void findPointsInside(Rectangle rectangle, PointConsumer consumer)
        {
            //TODO : implement
        }

    }
}