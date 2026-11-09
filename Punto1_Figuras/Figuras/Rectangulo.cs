namespace Punto1_Figuras.Figuras;

/// <summary>
/// Clase derivada (hija) de Figura. Se lee: "Rectangulo ES UNA Figura".
/// </summary>
public class Rectangulo : Figura
{
    public double Base { get; }
    public double Altura { get; }

    public Rectangulo(double baseRect, double altura)
    {
        if (baseRect <= 0 || altura <= 0)
            throw new ArgumentException("La base y la altura deben ser mayores que cero.");

        Base = baseRect;
        Altura = altura;
    }

    // override = "aquí escribo MI versión del método abstracto del padre"
    public override double CalcularArea() => Base * Altura;

    public override double CalcularPerimetro() => 2 * (Base + Altura);
}
