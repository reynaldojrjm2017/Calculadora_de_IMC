using System;
using System.Collections.Generic;
using System.Text;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso;
            float altura;
            float total;
            Console.WriteLine("Vamos calcular o seu IMC");
            Console.WriteLine("Digite o seu peso");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura");
            altura = float.Parse(Console.ReadLine());
            total = peso / (altura * altura);
            Console.WriteLine("Seu IMC é igual a =" + " " + total);
            if(total <= 18.5)
                {
                Console.WriteLine("Classificado como MAGREZA");
                }
            else if ((total >= 18.5) && (total < 24.9))
                {
                Console.WriteLine("Classificado como NORMAL");
                }
            else if ((total >= 25) && (total < 29.9))
            {
                Console.WriteLine("Classificado como SOBREPESO");
            }
            else if((total >= 30) && (total < 39.9))
            {
                Console.WriteLine("Classificado como OBESIDADE");
            }
            else
            {
                Console.WriteLine("Classificado como OBESIDADE GRAVE");
            }
            Console.ReadKey();

        }

    }
}
