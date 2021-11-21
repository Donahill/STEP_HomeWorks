namespace AbstractShapes
{
    abstract class ShapeFactory : IShapeFactory
    {
        public abstract IShape GetRectangle(int x, int y, int width, int height);
        public abstract IShape GetTriangle(int x, int y, int width, int height);
        public abstract IShape GetEllipse(int x, int y, int width, int height);

    }
}
