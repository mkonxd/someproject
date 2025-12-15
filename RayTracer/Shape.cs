namespace RayTracer;

public interface Shape
{
    bool Hit(Shape shape, Vector vector);
}