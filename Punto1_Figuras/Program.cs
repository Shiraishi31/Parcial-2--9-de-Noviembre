using Punto1_Figuras.Figuras;

Console.OutputEncoding = System.Text.Encoding.UTF8;   // para que se vean bien las tildes en la consola

Console.WriteLine("=== Parcial 3 - Punto 1: Clase abstracta y polimorfismo ===");
Console.WriteLine();

// 1) Arreglo UNIDIMENSIONAL (vector) cuyo tipo es la clase PADRE: Figura[]
//    Cada casilla puede guardar cualquier objeto que "sea una" Figura.
Figura[] figuras = new Figura[4];

figuras[0] = new Rectangulo(5, 3);
figuras[1] = new Cuadrado(6);
figuras[2] = new Triangulo(3, 4, 5);
figuras[3] = new Rectangulo(2.5, 4);

// 2) Recorrido POLIMÓRFICO: la variable "figura" es de tipo Figura (padre),
//    pero en tiempo de ejecución C# llama al método del objeto real (hijo).
Console.WriteLine($"{"Figura",-12}{"Área",10}{"Perímetro",13}");
Console.WriteLine(new string('-', 35));

foreach (Figura figura in figuras)
{
    string nombre = figura.GetType().Name;      // nombre real de la clase, obtenido dinámicamente
    double area = figura.CalcularArea();        // ¿cuál CalcularArea()? la del hijo
    double perimetro = figura.CalcularPerimetro();

    Console.WriteLine($"{nombre,-12}{area,10:F2}{perimetro,13:F2}");
}

Console.WriteLine();
Console.WriteLine($"Total de figuras en el arreglo: {figuras.Length}");
