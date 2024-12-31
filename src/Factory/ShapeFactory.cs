using Factory.Shapes;

namespace Factory;

public class ShapeFactory
{
    public IShape GetShape(string shapeType)
    {
        if (shapeType == null)
        {
            return null;
        }
        if (shapeType.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase))
        {
            return new Circle();
        }
        else if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase))
        {
            return new Square();
        }
        return null;
    }
}