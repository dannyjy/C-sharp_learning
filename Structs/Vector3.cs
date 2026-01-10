public struct Vector3
{
    public float X, Y, Z;

    public float Magnitude() => (float)Math.Sqrt(X * X + Y * Y + Z * Z);
}