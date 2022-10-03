using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);
         
        //O long é um tipo de variável de 64 bits
        long x = 2000000000000000000;
        Console.WriteLine(x);

        //O short é um tipo de variável de 32 bits
        short y = 15000;
        Console.WriteLine(y);
       
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}