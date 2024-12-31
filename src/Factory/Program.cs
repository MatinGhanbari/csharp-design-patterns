using Factory;

ShapeFactory shapeFactory = new();

// Create a Circle
IShape circle = shapeFactory.GetShape("CIRCLE");
circle?.Draw(); // Output: Drawing a Circle

// Create a Square
IShape square = shapeFactory.GetShape("SQUARE");
square?.Draw(); // Output: Drawing a Square

// Attempt to create an unknown shape
IShape unknownShape = shapeFactory.GetShape("TRIANGLE");
if (unknownShape == null)
{
    Console.WriteLine("Unknown shape type.");
}