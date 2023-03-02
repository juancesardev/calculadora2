using CalculadoraSchad;
using System;
namespace calculadoraTest
{
    public class Program
    {
        // Test with Strategy Design Pattern

        public static void Main(string[] args)
        {
            double val1;
            double val2;
            double result;

            Console.WriteLine("Hola, vamos a realizar calculaos con dos números \nPor favor ingresa el primer número");
            val1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("ingrese el segundo número");
            val2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            //Suma
            Operacion calculadora = new Operacion(new Suma());
            result = calculadora.Execute(val1, val2);
            Console.WriteLine("La suma es: " + result);
            Console.WriteLine();


            //Resta
            calculadora = new Operacion(new Resta());
            result = calculadora.Execute(val1, val2);
            Console.WriteLine("La resta es: " + result);
            Console.WriteLine();


            //Multiplica
            calculadora = new Operacion(new Multiplica());
            result = calculadora.Execute(val1, val2);
            Console.WriteLine("La multiplicación es: " + result);
            Console.WriteLine();


            //Divide
            calculadora = new Operacion(new Divide());
            result = calculadora.Execute(val1, val2);
            Console.WriteLine("La división es: " + result);
            Console.WriteLine();

        }


    }        

}
