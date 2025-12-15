using System;
using System.Runtime.CompilerServices;

namespace RayTracer;

/// <summary>
/// Class <c>Vector</c> represents a three-dimensional mathematical vector.
/// It provides properties for the X, Y, and Z components, and supports
/// common vector operations such as addition, subtraction, and scalar multiplication.
/// </summary>
public class Vector(double x, double y, double z)
{
    private double x = x;
    private double y = y;
    private double z = z;

    public double X { get => x; set => x = value; }
    public double Y { get => y; set => y = value; }
    public double Z { get => z; set => z = value; }
    
    public static Vector operator +(Vector left, Vector right) 
    { 
        return new Vector(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
    }

    public static Vector operator -(Vector left, Vector right) 
    {
        return new Vector(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
    }

    public static Vector operator *(Vector left, double right)
    {
        return new Vector(left.X * right, left.Y * right, left.Z * right);
    }
    
    public static Vector operator *(double left, Vector right)
    {
        return new Vector(right.X * left, right.Y * left, right.Z * left);
    }

    /// <summary>
    /// Function <c>Length</c> Takes input as Vector.
    /// </summary>
    /// <returns>
    /// The Length of the vector
    /// </returns>
    public static double Length(Vector vector)
    {
        return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z);
    }

    /// <summary>
    /// Function <c>Normalize</c> Takes input as Vector.
    /// </summary>
    /// <returns>
    /// Returns the normalized vector of length 1
    /// </returns>
    public static Vector Normalize(Vector vector)
    {
        double length = Vector.Length(vector);
        return new Vector(vector.X / length, vector.Y / length, vector.Z / length);
    }

    /// <summary>
    /// Function <c>DotProduct</c> Takes input as two vectors
    /// </summary>
    /// <returns>
    /// Returns the dot product of the two vectors.
    /// </returns>
    private static double DotProduct(Vector left, Vector right)
    {
        left = Vector.Normalize(left); right = Vector.Normalize(right);
        return  left.X * right.X + left.Y * right.Y + left.Z * right.Z;
    }
    

    
    

}