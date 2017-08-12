using System;

namespace Exercicio5CalcularHipotenusa
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			double baseT, altT, hipoT;
			Console.WriteLine("Digite a base do triângulo: ");
            baseT = Convert.ToDouble(Console.ReadLine());
            baseT = Math.Pow(baseT, 2);
			Console.WriteLine("Digite a altura do triângulo: ");
			altT = Convert.ToDouble(Console.ReadLine());
            altT = Math.Pow(altT, 2);
            hipoT = baseT + altT;
            hipoT = Math.Sqrt(hipoT);
			Console.Write("A hipotenusa do triângulo é " + hipoT);
			Console.ReadLine();
        }
    }
}
