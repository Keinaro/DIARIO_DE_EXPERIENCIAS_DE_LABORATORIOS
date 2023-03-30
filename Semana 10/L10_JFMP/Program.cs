using System;

public class Circulo
{
    private double radio;
    public Circulo(double elRadio)
    {
        radio = elRadio;
    }

    private double ObtenerPerimetro()
    {
        double perimetro = 2 * Math.PI * radio;
        return perimetro;
    }

    private double ObtenerArea()
    {
        double area = Math.PI * Math.Pow(radio, 2);
        return area;
    }

    private double ObtenerVolumen()
    {
        double volumen = (4 * Math.PI * Math.Pow(radio, 3)) / 3;
        return volumen;
    }

    public void CalcularGeometria(ref double unPerimetro, ref double unArea, ref double unVolumen)
    {
        unPerimetro = ObtenerPerimetro();
        unArea = ObtenerArea();
        unVolumen = ObtenerVolumen();
    }

    public static void Main()
    {
        Console.Write("Ingresar el valor del radio: ");
        Circulo objCirculo = new Circulo(Convert.ToDouble(Console.ReadLine()));

        double perimetro = 0, area = 0, volumen = 0;
        objCirculo.CalcularGeometria(ref perimetro, ref area, ref volumen);
        perimetro = Math.Round(perimetro, 2);
        area = Math.Round(area, 2);
        volumen = Math.Round(volumen, 2);

        Console.WriteLine("\nEl perimetro es: " + perimetro);
        Console.WriteLine("El área es: " + area);
        Console.WriteLine("El volumen es: " + volumen + "\n");

        Console.ReadKey();
    }
}