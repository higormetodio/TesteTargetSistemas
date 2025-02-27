// Solicitando e convertendo o número
Console.Write("Informe um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

// Verificando se o núemro pertence a sequência de Fibonacci com a chamada do método
if (PertenceFibonacci(numero))
{
    Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
}

static bool PertenceFibonacci(int numero)
{
    int primeiro = 0;
    int segundo = 1;

    if (numero == primeiro || numero == segundo)
    {
        return true;
    }

    int proximo = primeiro + segundo;

    while (proximo <= numero)
    {
        if (proximo == numero)
        {
            return true;
        }

        primeiro = segundo;
        segundo = proximo;
        proximo = primeiro + segundo;
    }

    return false;
}