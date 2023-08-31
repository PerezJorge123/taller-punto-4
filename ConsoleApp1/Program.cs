//Realizar un algoritmo con C# donde me permita calcular el perímetro/circunferencia y área de las siguientes figuras geométricas: cuadrado, rectángulo, triángulo y círculo. Mostrar en pantalla los valores calculados por cada figura geométrica.
using System;

public class Ejercicio4
{static void Main(string[] args)
    {
        double ladoCuadrado, baseRectangulo, alturaRectangulo, lado1, lado2, lado3, alturaTriangulo, radio, areaCuadrado, areaRectangulo, areaTriangulo, areaCirculo, perimetroCuadrado, perimetroRectangulo, perimetroTriangulo, perimetroCirculo;
        
        Console.Write("Ingrese lado del cuadrado");
        ladoCuadrado = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese base del rectangulo");
        baseRectangulo = double.Parse(Console.ReadLine());
        Console.Write("Ingrese altura del rectangulo");
        alturaRectangulo = double.Parse(Console.ReadLine());
        Console.Write("Ingrese lado 1 del triangulo");
        lado1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese lado 2 del triangulo");
        lado2 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese lado 3 del triangulo");
        lado3 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese altura del triangulo");
        alturaTriangulo = double.Parse(Console.ReadLine());
        Console.Write("Ingrese radio del circulo");
        radio = double.Parse(Console.ReadLine());

        perimetroCuadrado = ladoCuadrado * 4;
        areaCuadrado = 2 * ladoCuadrado;

        perimetroRectangulo = 2 * baseRectangulo + 2 * alturaRectangulo;
        areaRectangulo = baseRectangulo * alturaRectangulo;

        perimetroTriangulo = lado1 + lado2 + lado3;
        areaTriangulo = (lado1 * alturaTriangulo) / 2;

        perimetroCirculo = Math.PI * radio;
        areaCirculo = Math.PI * Math.Pow(radio, 2);

        Console.WriteLine($"Area del cuadrado es: {areaCuadrado}");
        Console.WriteLine($"El perimetro del cuadrado es: {perimetroCuadrado}");

        Console.WriteLine($"Area del rectangulo es: {areaRectangulo}");
        Console.WriteLine($"El perimetro del rectangulo es: {perimetroRectangulo}");

        Console.WriteLine($"Area del triangulo es: {areaTriangulo}");
        Console.WriteLine($"El perimetro del triangulo es: {perimetroTriangulo}");

        Console.WriteLine($"Area del circulo es: {areaCirculo}");
        Console.WriteLine($"El perimetro del circulo es: {perimetroCirculo}");
    }

}