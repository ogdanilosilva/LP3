int num1 = 0;
int num2 = 0;

Console.WriteLine("Calculadora em C#");
Console.WriteLine("----------------\n");

Console.WriteLine("Digite um número,e pressione o Enter");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro número,e pressione o Enter");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escolha uma opção da lista seguinte:");

Console.WriteLine("\ta  - Soma");
Console.WriteLine("\ts  - Subtração");
Console.WriteLine("\tm - Multiplicação");
Console.WriteLine("\td  - Divisão");
Console.WriteLine("Qual sua opção?");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Seu resultado: {(num1) + (num2)}");
        break;

    case "s":
        Console.WriteLine($"Seu resultado: {(num1) - (num2)}");
        break;

    case "m":
        Console.WriteLine($"Seu resultado: {(num1) * (num2)}");
        break;

    case "d":
        Console.WriteLine($"Seu resultado: {(num1) / (num2)}");
        break;

    default:
        Console.WriteLine("Opção Inválida");
        break;
}