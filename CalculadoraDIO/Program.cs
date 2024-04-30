using CalculadoraDIO;

short input = 1;
Calculadora minhaCalculadora = new Calculadora();

Console.WriteLine("////////////////////////////////////////////");
Console.WriteLine("/////BEM VINDO A CALCULADORA DE CONSOLE/////");
Console.WriteLine("////////////////////////////////////////////");
Console.WriteLine("--------------------------------------------");


while(input != 6)
{
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("(1) Somar (2) Subtrair (3) Dividir (4) Multiplicar (5) Historico (6) Sair");

    try
    {
        input = Convert.ToInt16(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Digite apenas um numero");
        input = 6;
    }

    switch (input)
    {
        case 1:
            Console.WriteLine("Resultado = " + minhaCalculadora.Soma(2, 2));
            break;
        case 2:
            Console.WriteLine("Resultado = " + minhaCalculadora.Subtracao(2, 2));
            break;
        case 3:
            Console.WriteLine("Resultado = " + minhaCalculadora.Divisao(2, 2));
            break;
        case 4:
            Console.WriteLine("Resultado = " + minhaCalculadora.Multiplicacao(2, 2));
            break;
        case 5:
            foreach(var item in minhaCalculadora.Historico())
            {
                Console.WriteLine(item);
            }
            break;
        case 6:
            Console.WriteLine("Obrigado por usar!");
            break;
        default:
            Console.WriteLine("Valor invalido. Digite novamente");
            break;
    }
}

Console.WriteLine("Fechando Aplicacao...");