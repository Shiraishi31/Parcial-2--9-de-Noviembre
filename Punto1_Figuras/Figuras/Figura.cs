namespace Punto1_Figuras.Figuras;

/// <summary>
/// Clase ABSTRACTA: es un "molde obligatorio".
/// - No se puede instanciar (new Figura() da error de compilación CS0144).
/// - Obliga a toda clase hija a implementar sus métodos abstractos.
/// </summary>
public abstract class Figura
{
    // Métodos abstractos: solo la firma, SIN cuerpo { }.
    // Cada clase hija está obligada a escribir su propia versión con "override".
    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();
}
