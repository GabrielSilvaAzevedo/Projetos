Console.WriteLine("Tabuada teste");
Console.Write("Digite Numero da tabuada que deseja:");

string entrada = Console.ReadLine();
int.TryParse(entrada,out int numero );

Console.WriteLine("Usando For:");
for (int tabuada1 = 0;tabuada1 <= 10;tabuada1++) {
    Console.WriteLine(tabuada1 * numero); 
}

Console.WriteLine("Usando Foreach:");
int[] tabuada2 = [0,1,2,3,4,5,6,7,8,9,10];
foreach(var n in tabuada2) {
    Console.WriteLine(n*numero);
}
Console.WriteLine("Usando Enumerable:");
foreach(int i in Enumerable.Range(0, 11)) {
    Console.WriteLine(i * numero);
}

Console.WriteLine("Usando While:");
int a = 0;
while (a <= 9) {
    a++;
    Console.WriteLine(a * numero);
}
