// See https://aka.ms/new-console-template for more information
double n1;
double n2;
string formula;
double resultadoSoma;
double resultadoSubtracao;
double resultadoMultiplicacao;
double resultadoDivisao;
bool formulaErrada = true;

Console.WriteLine("Digite o primeiro número: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
n2 = Convert.ToDouble(Console.ReadLine());

resultadoSoma = n1 + n2;
resultadoSubtracao = n1 - n2;
resultadoMultiplicacao = n1 * n2;
resultadoDivisao = n1 / n2;

while (formulaErrada == true)
{

    Console.WriteLine("Digite qual fórmula: /    *    -    + ");
    formula = Console.ReadLine();

    if (formula == "+")
    {
        Console.WriteLine($"Total: {resultadoSoma}");
        formulaErrada = false;
    }
    else if (formula == "-")
    {
        Console.WriteLine($"Total: {resultadoSubtracao}");
        formulaErrada = false;
    }
    else if (formula == "*")
    {
        Console.WriteLine($"Total: {resultadoMultiplicacao}");
        formulaErrada = false;
    }
    else if (formula == "/")
    {
        Console.WriteLine($"Total: {resultadoDivisao}");
        formulaErrada = false;
    }
    if (formulaErrada == true)
    {
        Console.WriteLine("Erro");

    }
}

Console.ReadKey();
