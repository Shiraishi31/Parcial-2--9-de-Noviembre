namespace Punto1_Figuras.Figuras;

/// <summary>
/// Clase derivada de Figura. Se define con sus tres lados (a, b, c).
/// El área se calcula con la fórmula de Herón, que solo necesita los lados.
/// </summary>
public class Triangulo : Figura
{
    public double LadoA { get; }
    public double LadoB { get; }
    public double LadoC { get; }

    public Triangulo(double ladoA, double ladoB, double ladoC)
    {
        if (ladoA <= 0 || ladoB <= 0 || ladoC <= 0)
            throw new ArgumentException("Los lados deben ser mayores que cero.");

        // Desigualdad triangular: cada lado debe ser menor que la suma de los otros dos.
        if (ladoA + ladoB <= ladoC || ladoA + ladoC <= ladoB || ladoB + ladoC <= ladoA)
            throw new ArgumentException("Esos tres lados no forman un triángulo.");

        LadoA = ladoA;
        LadoB = ladoB;
        LadoC = ladoC;
    }

    public override double CalcularPerimetro() => LadoA + LadoB + LadoC;

    public override double CalcularArea()
    {
        double s = CalcularPerimetro() / 2;   // semiperímetro
        return Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
    }
}
