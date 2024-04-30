using CalculadoraDIO;

List<int> LerDoisNumeros(){
    Console.WriteLine("Digite dois numeros inteiros separados por espaco");
    try
    {
        string entrada = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("Campo vazio. Inserindo valores padrao 1 e 1");
            return new List<int> { 1, 1 };
        }
        return entrada.Split(' ').Select(s => int.Parse(s)).ToList();
    }
    catch 
    {
        Console.WriteLine("valores invalidos. Inserindo valores padrao 1 e 1");
        return new List<int> { 1, 1 };
    }
}

short input = 1;
List<int> numeros;
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
        input = 7;
    }

    switch (input)
    {
        case 1:
            numeros = LerDoisNumeros();
            Console.WriteLine("Resultado = " + minhaCalculadora.Soma(numeros[0], numeros[1]));
            break;
        case 2:
            numeros = LerDoisNumeros();
            Console.WriteLine("Resultado = " + minhaCalculadora.Subtracao(numeros[0], numeros[1]));
            break;
        case 3:
            numeros = LerDoisNumeros();
            Console.WriteLine("Resultado = " + minhaCalculadora.Divisao(numeros[0], numeros[1]));
            break;
        case 4:
            numeros = LerDoisNumeros();
            Console.WriteLine("Resultado = " + minhaCalculadora.Multiplicacao(numeros[0], numeros[1]));
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