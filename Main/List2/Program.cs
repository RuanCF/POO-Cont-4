using System;
using System.Globalization;
class Lista2
{
    static void Main()
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("Bom dia!");
        Console.WriteLine("...");
        Console.Write("--- ");
        Console.WriteLine("OI");
        Console.WriteLine("______________________________ ");
        //Sem erro de sintaxesx ^^^^


        //Declaração de variáveis
        bool presente = false;
        char genero = 'F';
        char letra = '\u0041';
        byte num1 = 126;
        int num2 = 1000;
        int num3 = 2147483647;
        long num4 = 2147483648L;
        float num5 = 2.5f;
        double num6 = 3.8;
        string nome = "Joao Bosco";

        Console.WriteLine("variáveis:");
        Console.WriteLine(nome);
        Console.WriteLine(presente);
        Console.WriteLine(genero);
        Console.WriteLine(letra);
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);
        Console.WriteLine(num4);
        Console.WriteLine(num5);
        Console.WriteLine(num6);
        Console.WriteLine("______________________________ ");

        //Placeholders, concatenação e interpolação 
        char gen = 'M';
        byte numero = 26;
        string name = "Joao Bosco";
        Console.WriteLine("{0} tem {1} anos e é do gênero {2}", name, numero, gen);
        Console.WriteLine($"{name} tem {numero} anos e é do gênero {gen}");
        Console.WriteLine(name + " tem " + numero + " anos e é do gênero " + gen);


        //registro de venda de um produto para cliente
        Console.WriteLine("______________________________ ");
        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";
        byte idade = 30;
        int codigo = 5290;
        char genero1 = 'M';
        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;
        Console.WriteLine("Produtos:");
        Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
        Console.WriteLine("{0}, cujo preco é $ {1:F2}", produto2, preco2);
        Console.WriteLine();
        Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero1);
        Console.WriteLine();
        Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
        Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
        Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

        /*
        Operadores aritméticos:
        SOMA
        “+” = Adição
        “-“ = Subtração
        “*” = Multiplicação
        “/” = Divisão
        “%” = Módulo (resto da divisão) 
        */
        Console.WriteLine("______________________________ ");
        int a = 5;
        int b = 15;
        int c = 24;
        int d = 30;
        Console.WriteLine(a + b);
        Console.WriteLine(d - c);
        Console.WriteLine(c * a);
        Console.WriteLine(d / b);
        Console.WriteLine(c % a);

        /*
        Operadores aritméticos de atribuição reduzida:
        +=  Mais igual
        -=  Menos igual
        *=  Vezes igual
        /=  Divisão igual
        %=  Módulo igual

        */
        Console.WriteLine("______________________________ ");
        int a1 = 53;
        a1++;
        Console.WriteLine(a1);

        a1 += 100;
        Console.WriteLine(a1);
    }
}