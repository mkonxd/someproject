namespace Raytracer.Tests;

using Xunit;
using RayTracer;

public class VectorTests
{
    [Fact]
    public void Length()
    {
        Vector v = new Vector(3, 4, 0);
        Assert.Equal(5, v.Length());
    }

    [Fact]
    public void Normalize()
    {
        Vector v = new Vector(1, 2, 3);
        Vector unit = v.Normalize();
        Assert.Equal(1, unit.Length());
        
        v = new Vector(-251, 1, 28);
        unit = v.Normalize();
        Assert.Equal(1, unit.Length());
    }

    [Fact]
    public void DotProduct()
    {
        Vector v1 = new Vector(1, 2, 3);
        Vector v2 = new Vector(3, 4, 5);
        double dot = v1.DotProduct(v2);
        
        Assert.Equal(26, dot);
        
        v1 = new Vector(1, 2, -3);
        v2 = new Vector(3, 4, 5);
        dot = v1.DotProduct(v2);
        Assert.Equal(-4, dot);

    }

    [Fact]
    private void Operators()
    {
        Vector v1 = new Vector(1, 2, 3);
        Vector v2 = v1 * 2;
        Assert.Equal(2, v2.X);
        Assert.Equal(4, v2.Y);
        Assert.Equal(6, v2.Z);
        
        v1 = new Vector(1, 2, 3);
        v2 = 2 * v1;
        Assert.Equal(2, v2.X);
        Assert.Equal(4, v2.Y);
        Assert.Equal(6, v2.Z);
        
        v1 = new Vector(2, 3, 4);
        v2 = new Vector(2, 3, -4);
        Vector v3 = v1 + v2;
        Assert.Equal(4, v3.X);
        Assert.Equal(6, v3.Y);
        Assert.Equal(0, v3.Z);

        v3 = v1 - v2;
        Assert.Equal(0, v3.X);
        Assert.Equal(0, v3.Y);
        Assert.Equal(8, v3.Z);
    }
    
}