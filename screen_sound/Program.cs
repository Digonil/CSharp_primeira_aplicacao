//Screen Sound


string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!!!";
List<string> listaDasBandas = new List<string> {"U2", "Iron Maiden", "Avenged Sevenfold"};

void ExibirLogo() 
{
    //Verbatim Literal
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void     ExibirOpcoesDoMenu() {
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");


    Console.Write("\nDigite a sua opção: ");

    string opcaoEscolhida = Console.ReadLine()!;//! indica que o readline não pode ser nulo.

    //Aplicado parse no tipo pois não se aplica operador em tipos diferentes.
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica) {
        case 1:  RegistrarBanda(); 
            break;
        case 2:  MostrarBandasRegistradas(); 
            break;
        case 3:  Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica); 
            break;
        case 4:  Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica); 
            break;
        case -1:  Console.WriteLine("Tchau tchau :)"); 
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
    
}

void RegistrarBanda() 
{
    Console.Clear();
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void MostrarBandasRegistradas() 
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("************************************\n");

    /*
    for(int i = 0; i < listaDasBandas.Count; i++) 
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }
    */

    foreach (var banda in listaDasBandas) 
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

//ExibirOpcoesDoMenu();


/*

List<int> inteiros = new List<int> { 2, 5, 8, 11 };

foreach (var inteiro in inteiros) 
    {
    if (inteiro % 2  == 0) 
        Console.WriteLine(inteiro);
    }

for (int i = 0;i < inteiros.Count; i++) 
{
    if (i % 2 == 0)
        Console.WriteLine(inteiros[i]);
}
*/










/*
Console.WriteLine("Digite um número de 1 a 5: ");
Random rand = new Random();
int valorAcertado = rand.Next(1, 5);
int numeroDigitadoConvertido;

do {
    string numeroDigitado = Console.ReadLine()!;
    numeroDigitadoConvertido = int.Parse(numeroDigitado);
    numeroDigitadoConvertido = int.Parse(numeroDigitado);
} while (numeroDigitadoConvertido != valorAcertado);

Console.WriteLine($"O valor acertado foi {valorAcertado}");
*/

//Exemplo de uso de interpolação de string
//Console.WriteLine($"texto teste, {opcaoEscolhida}");

//Exemplo que permite substituir marcadores de posição
//Console.WriteLine("Olá, {0}!", opcaoEscolhida);
