Console.WriteLine("Abasteça Com Etanol ou Gasolina:");
Console.WriteLine("Para Economizar divida o valor do etanol pelo valor da gasolina \n" +
    "se o resultado for Menor (70% = 0.7) Abasteça com Etanol \n" +
    "se for Maior que (70% = 0.7) Abasteça com Gasolina");

Console.Write("Digite o Preço do Etanol:");
double precoEtanol = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o Preço Da Gasolina:");
double precoGasolina = Convert.ToDouble(Console.ReadLine());

double economia = precoEtanol / precoGasolina;
Console.WriteLine($"Preço do Etanol / Gasolina:{economia.ToString("F1")}");
if(economia <= 0.7) {
    Console.WriteLine("Para Economizar:");
    Console.WriteLine("Abasteça com Etanol");
    Console.WriteLine("Etanol < 70% da Gasolina:Álcool.");
}
else {
    Console.WriteLine("Para Economizar:");
    Console.WriteLine("Abasteça com Gasolina");
    Console.WriteLine("Etanol > 70% da Gasolina:Gasolina.");
}

