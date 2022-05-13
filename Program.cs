using System;

class Program
{

    static void Main(string[] args)
    {
        int tabuada, contador, resultado;
        string userAnswer = "S";

        while (userAnswer != "N")
        {
            Console.WriteLine("Digite um valor inteiro para cálculo da tabuada?");
            tabuada = Convert.ToInt32(Console.ReadLine());
            contador = 0;
            
            while (contador <= 10)
            {
                resultado = tabuada * contador;
                Console.WriteLine("{0} x {1} = {2}", tabuada, contador, resultado);

                contador++;
            }
            Console.WriteLine("Deseja calcular outra tabuada? (S/N) ");
            userAnswer = Console.ReadLine();
        }
        Console.WriteLine("FIM DA TABUADA!");
    }
}