using System;

class Seno
{
    public static void Main(string[] args)
    {
        double angulo, seno;
        int num;
        Console.WriteLine("Ingrese el valor del angulo en grados: ");
        angulo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el numero de repeticiones de la serie: ");
        num = Convert.ToInt32(Console.ReadLine());
        seno = (SenoCalculado(angulo, num));
        Console.WriteLine("Seno de " + angulo + " es: " + seno);

    }

    public static double Factorial(int n)
    {
        int i = 1;
        double factorial = 1;
        while (i <= n)
        {
            factorial *= i;
            i++;
        }
        return factorial;
    }

    public static double SenoCalculado(double grados, int n)
    {
        double suma = 0;
        int i = 0;
        grados = Math.PI * grados / 180;
        while (i <= n)
        {
            if (i % 2 == 0)
            {
                suma += (Math.Pow(grados, 2 * i + 1)) / (Factorial(2 * i + 1));
            }
            else
            {
                suma -= (Math.Pow(grados, 2 * i + 1)) / (Factorial(2 * i + 1));
            }

            i++;
        }
        return suma;
    }
}
