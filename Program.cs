using System;

class Program
{

    static void Main(string[] args)
    {
        int tabuada, contador = 0, resultado;

        Console.WriteLine("Qual a tabuada?");
        tabuada = Convert.ToInt32(Console.ReadLine());

        while(contador <= 10)
        {
            resultado = tabuada * contador;
            Console.WriteLine("{0} x {1} = {2}", tabuada, contador, resultado);
            contador++;
        }
    }
}