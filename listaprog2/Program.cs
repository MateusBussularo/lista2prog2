using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaprog2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1

            int laranjan = int.Parse(Console.ReadLine());

            double preco_unitario;

            if (laranjan < 0)
            {
                preco_unitario = 0.35;
            }
            else
            {
                preco_unitario = 0.28;
            }

            double todo_valor = laranjan * preco_unitario;

            Console.WriteLine("Valor da compra R$: ", todo_valor);
            Console.ReadLine();


            //Exercicio2

            Console.WriteLine("Digite sua data de nascimento");

            int anonascimento = int.Parse(Console.ReadLine());

            int anoatual = DateTime.Now.Year;

            int idade = anoatual - anonascimento;

            if (idade >= 16)
            {
                Console.WriteLine("Você poderá votar na proxima eleição que tiver");
            }
            else
            {
                Console.WriteLine("Você não poderá votar na proxima eleição que tiver");
            }

            Console.WriteLine();
            Console.ReadLine();


            //Exercicio3


            Console.WriteLine("Digite o primeiro lado do trinagulo: ");

            double lado1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo lado do triangulo: ");

            double lado2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro lado do triangulo: ");

            double lado3 = double.Parse(Console.ReadLine());

            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("O triangulo e equilatero");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("O triangulo e isoceles");
            }
            else
            {
                Console.WriteLine("O triangulo e escaleno");
            }

            Console.WriteLine();
            Console.ReadLine();


            //Exercicio4

            float a, b, c, delta, resultado1, resultado2;

            Console.WriteLine("Entre com o valor do coeficiente A: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor do coeficiente B: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor do coeficiente C: ");
            c = float.Parse(Console.ReadLine());

            if (a != 0)
            {
                delta = (b * b) - 4 * (a * c);
                if (delta < 0)
                {
                    Console.WriteLine("A equação não possui raízes reais!");
                }
                else
                {
                    resultado1 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("A raíz R1 é igual a " + resultado1);

                    if (delta > 0f)
                    {
                        resultado2 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine("A raíz R2 é igual a " + resultado2);
                    }
                }
            }


            //Exercicio5

            float num;

            Console.WriteLine("Entre com um valor qualquer: ");
            num = float.Parse(Console.ReadLine());

            if (num % 3 == 0 && num % 5 == 0) ;
        }
    }
}
