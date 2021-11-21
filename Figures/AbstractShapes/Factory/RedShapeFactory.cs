namespace AbstractShapes
{
    class RedShapeFactory : ShapeFactory, IShapeFactory
    {
        public override IShape GetRectangle(int x, int y, int width, int height)
        {
            return new RedRectangle(x, y, width, height);
        }
        public override IShape GetTriangle(int x, int y, int width, int height)
        {
            return new RedTriangle(x, y, width, height);
        }
        public override IShape GetEllipse(int x, int y, int width, int height)
        {
            return new RedEllipse(x, y, width, height);
        }
    }
}
