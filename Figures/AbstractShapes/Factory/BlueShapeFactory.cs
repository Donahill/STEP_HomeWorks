namespace AbstractShapes
{
    class BlueShapeFactory : ShapeFactory, IShapeFactory
    {
        public override IShape GetRectangle(int x, int y, int width, int height)
        {
            return new BlueRectangle(x, y, width, height);
        }
        public override IShape GetTriangle(int x, int y, int width, int height)
        {
            return new BlueTriangle(x, y, width, height);
        }
        public override IShape GetEllipse(int x, int y, int width, int height)
        {
            return new BlueEllipse(x, y, width, height);
        }
    }
}
