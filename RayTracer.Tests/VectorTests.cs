namespace Raytracer.Tests;

using Xunit;
using RayTracer;

public class VectorTests
{
    [Fact]
    public void Length()
    {
        var v = new Vector(3, 4, 0);
        Assert.Equal(5, Vector.Length(v)); //A bit dumb having to invoke class function on itself TODO rewrite as to call v.Length()
    }
    
}