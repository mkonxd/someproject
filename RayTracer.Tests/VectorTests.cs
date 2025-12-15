namespace Raytracer.Tests;

using Xunit;
using RayTracer;

public class VectorTests
{
    [Fact]
    public void Length()
    {
        var v = new Vector(3, 4, 0);
        Assert.Equal(5, v.Length());
    }
    
}