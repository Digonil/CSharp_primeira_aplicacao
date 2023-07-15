//Screen Sound


string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!!!";
//List<string> listaDasBandas = new List<string> {"U2", "Iron Maiden", "Avenged Sevenfold"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int>{ 8, 8,10});
bandasRegistradas.Add("The Beatles", new List<int>());

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
        case 3:  AvaliarUmaBanda(); 
            break;
        case 4:  ExibirMediaBanda(); 
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
    ExibirTituloDaOpcao("Registrar Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void MostrarBandasRegistradas() 
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    /*
    for(int i = 0; i < listaDasBandas.Count; i++) 
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }
    */

    foreach (var banda in bandasRegistradas.Keys) 
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda() 
    { 
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: \n");
        string nomeDaBanda = Console.ReadLine()!;
        
    if(bandasRegistradas.ContainsKey(nomeDaBanda)) 
        
        {
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            int nota = int.Parse(Console.ReadLine())!;
            bandasRegistradas[nomeDaBanda].Add(nota);
            Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
            Thread.Sleep(4000);
            Console.Clear();
            ExibirOpcoesDoMenu();

        } else 
        {
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            ExibirOpcoesDoMenu();
            Console.Clear();
    }
    }

void ExibirTituloDaOpcao(string titulo) 
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void ExibirMediaBanda() {
    Console.Clear();
    ExibirTituloDaOpcao("Cálculo de média de notas da banda");
    Console.WriteLine("Qual banda você gostaria de calcular a média? ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda)) {
        double calculoDaMedia = Math.Round(bandasRegistradas[nomeDaBanda].Average(), 2);  
        Console.WriteLine($"A nota média da banda {nomeDaBanda} é {calculoDaMedia}");
        Thread.Sleep(6000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    } else {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
        Console.Clear();
    }


}

ExibirOpcoesDoMenu();






/*
Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

double media = vendasCarros["Bugatti Veyron"].Average();
Console.WriteLine($"A média de vendas é de {media}");
*/
    

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
