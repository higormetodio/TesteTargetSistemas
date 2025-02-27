// Faturamento por estado
double sp = 67836.43;
double rj = 36678.66;
double mg = 29229.88;
double es = 27165.48;
double outros = 19849.53;

// Calculando o valor total do faturamento mensal
double total = sp + rj + mg + es + outros;

// Calculando os percentuais
double percentualSP = sp / total * 100;
double percentualRJ = rj / total * 100;
double percentualMG = mg / total * 100;
double percentualES = es / total * 100;
double percentualOutros = outros / total * 100;

// Exibindo os resultados
Console.WriteLine($"Percentual de representação de SP: {percentualSP:F2}%");
Console.WriteLine($"Percentual de representação de RJ: {percentualRJ:F2}%");
Console.WriteLine($"Percentual de representação de MG: {percentualMG:F2}%");
Console.WriteLine($"Percentual de representação de ES: {percentualES:F2}%");
Console.WriteLine($"Percentual de representação de Outros: {percentualOutros:F2}%");

