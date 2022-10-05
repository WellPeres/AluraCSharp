using System;
class Programa
{
    static void Main(string[] args)
    {
        double investimento = 1000;
        int mes = 1;
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("no mês " + mes + "você tem : $" + investimento);

            mes = mes + 1;
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}