using System.ComponentModel.Design;

public class Program
{
    private static void Main(string[] args)
    {
        double sueldoBase = 1000000;
        double venta1 = 400000;
        double venta2 = 350000;
        double venta3 = 280000;
        double objetivo = 1000000;
        double beneficioExtra = 100000;

        // Cálculos
        double comision1 = venta1 * 0.1;
        double comision2 = venta2 * 0.1;
        double comision3 = venta3 * 0.1;

        double comisionTotal = comision1 + comision2 + comision3;
        double sueldoTotal = sueldoBase + comisionTotal;

        // Encontrar la mayor comisión
        double mayorComision = comision1;
        if (comision2 > mayorComision)
        {
            mayorComision = comision2;
        }
        if (comision3 > mayorComision)
        {
            mayorComision = comision3;
        }

        // Promedio de comisiones
        double promedioComisiones = comisionTotal / 3;

        // Condicional para el beneficio extra
        bool ganoBeneficio = venta1 + venta2 + venta3 >= objetivo;

        // Mostrar resultados
        Console.WriteLine("Comisión total: $" + comisionTotal);
        Console.WriteLine("Sueldo total: $" + sueldoTotal);
        Console.WriteLine("Mayor comisión: $" + mayorComision);
        Console.WriteLine("Promedio de comisiones: $" + promedioComisiones);

        if (ganoBeneficio)
        {
            Console.WriteLine("¡Felicidades! Ganó el beneficio extra de $" + beneficioExtra);
        }
        else
        {
            Console.WriteLine("No alcanzó el objetivo para el beneficio extra.");
        }
    }
}
