using System.Text.Json;

// Caminho do arquivo JSON
string filePath = "dados.json";

// Lendo e desserializando o arquivo JSON
var faturamentos = JsonSerializer.Deserialize<List<Faturamento>>(File.ReadAllText(filePath));

// Removendo dias sem faturamento (valor = 0)
faturamentos!.RemoveAll(f => f.Valor == 0);

// Calculando o menor e maior valor de faturamento
double menorFaturamento = double.MaxValue;
double maiorFaturamento = double.MinValue;
double somaFaturamento = 0;

foreach (var faturamento in faturamentos)
{
    if (faturamento.Valor < menorFaturamento)
    {
        menorFaturamento = faturamento.Valor;
    }
    if (faturamento.Valor > maiorFaturamento)
    {
        maiorFaturamento = faturamento.Valor;
    }

    somaFaturamento += faturamento.Valor;
}

// Calculando a média mensal
double mediaMensal = somaFaturamento / faturamentos.Count;

// Contando os dias com faturamento superior à média mensal
int diasAcimaDaMedia = 0;

foreach (var faturamento in faturamentos)
{
    if (faturamento.Valor > mediaMensal)
    {
        diasAcimaDaMedia += 1;
    }
}

// Exibindo os resultados
Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");
Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");
Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");

