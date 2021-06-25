namespace AreaSearch
{
    public interface AreaFinder
    {
        void findPointsInside(Rectangle rectangle, PointConsumer consumer);
    }
}


