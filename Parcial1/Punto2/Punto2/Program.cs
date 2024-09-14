public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el coeficiente a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el coeficiente b:");
        double b = Convert.ToDouble(Console.ReadLine());


        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("La ecuación tiene infinitas soluciones.");
            }
            else
            {
                Console.WriteLine("La ecuación no tiene solución.");
            }
        }
        else
        {
            double x = -b / a;
            Console.WriteLine("La solución de la ecuación es x = " + x);
        }
    



    }
}