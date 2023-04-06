double faturamentoSP = 67836.43;
double faturamentoRJ = 36678.66;
double faturamentoMG = 29229.88;
double faturamentoES = 27165.48;
double faturamentoOutros = 19849.53;

double total = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;
Console.WriteLine($"Total: {total}");
Console.WriteLine($"SP: {faturamentoSP / total * 100}%");
Console.WriteLine($"RJ: {faturamentoRJ / total * 100}%");
Console.WriteLine($"MG: {faturamentoMG / total * 100}%");
Console.WriteLine($"ES: {faturamentoES / total * 100}%");
Console.WriteLine($"Outros: {faturamentoOutros / total * 100}%");
