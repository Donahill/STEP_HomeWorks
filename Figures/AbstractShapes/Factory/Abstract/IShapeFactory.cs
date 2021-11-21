namespace AbstractShapes
{
    interface IShapeFactory
    {
        IShape GetRectangle(int x, int y, int width, int height);
        IShape GetTriangle(int x, int y, int width, int height);
        IShape GetEllipse(int x, int y, int width, int height);

    }
}
