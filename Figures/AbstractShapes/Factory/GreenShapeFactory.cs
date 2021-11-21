namespace AbstractShapes
{
    class GreenShapeFactory : ShapeFactory, IShapeFactory
    {
        public override IShape GetRectangle(int x, int y, int width, int height)
        {
            return new GreenRectangle(x, y, width, height);
        }
        public override IShape GetTriangle(int x, int y, int width, int height)
        {
            return new GreenTriangle(x, y, width, height);
        }
        public override IShape GetEllipse(int x, int y, int width, int height)
        {
            return new GreenEllipse(x, y, width, height);
        }
    }
}
